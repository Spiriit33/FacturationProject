using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Facturation.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Facturation.Client.Pages;

namespace Facturation.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FacturesController : Controllerbase
    {
        public readonly ILogger<FacturesController> logger;
        public readonly IBusinessData _data;

        public FacturesController(ILogger<FacturesController> logger, IBusinessData data)
        {
            _logger = logger;
            _data = data;
        }

        [HttpGet]

        public IEnumerable<Factures> Get()
        { 
            => _data.Factures;
        }

        public ActionResult<Factures> Get(string numero)
        {
            var facture = _data.Factures.Where(f => f.NumFacture == numero).FirstOrDefault();

            if (facture == null)
            {
                return NotFound("Aucune Facture trouvée");
            }
            else
            {
                return facture;
            }
        }

        [HttpPost]

        public ActionResult<Factures> CreateFacture([FromBody] Factures nouvelleFacture)
        {
            if (ModelState.IsValid)
            {
                _data.Add(nouvelleFacture);
                return nouvelleFacture;
            }
        }
    }