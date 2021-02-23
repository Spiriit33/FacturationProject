using Facturation.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation.Shared
{
    public class DashboardDto
    {

        public DashboardDto(IBusinessData from)
        {
            CA = from.Factures.Sum(f => f.Montant);
            MontantDu = from
                .GetFactures(DateTime.Now);
            .Select(f => new Montant(f));

        public Ienumerable<Montant> Montant { get; set; }
    }
}
