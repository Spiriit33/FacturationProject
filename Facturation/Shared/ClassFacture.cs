using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facturation.Shared
{
    public class ClassFacture
    {
        public string NumFacture { get; set; }
        public DateTime EmissionFacture { get; set; }
        public DateTime ReglementAttendu { get; set; }
        public string MontantDu { get; set; }
        public string MontantRegle { get; set; }

        public ClassFacture(string NumFacture, DateTime EmissionFacture, DateTime ReglementAttendu, string MontantDu, string MontantRegle)
        {
            this.NumFacture = NumFacture;
            this.EmissionFacture = EmissionFacture;
            this.ReglementAttendu = ReglementAttendu;
            this.MontantDu = MontantDu;
            this.MontantRegle = MontantRegle;

        }
    }
}
