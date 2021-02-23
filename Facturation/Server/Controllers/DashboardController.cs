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
        public class DashboardController : ControllerBase
        {
            private readonly IBusinessData _data;
        }

        public DashboardController(IBusinessData data)
        {
            _data = data;
        }
        [HttpGet]

        public DashboardDto GetDashboard() =>
            new DashboardDto(_data);
    }
