using Facturation.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facturation.Shared
{
    public class BusinessData : IBusinessData
    {
        public BusinessData()
        {
            Factures = new ClassFacture[]
            {
                new ClassFacture("EDF", new DateTime(2020,07,30), new DateTime(2020,08,11),"17000", "25000"),
                new ClassFacture("FRE", new DateTime(2020,01,22), new DateTime(2020,02,11),"36000", "15000"),
                new ClassFacture("OPM", new DateTime(2020,11,12), new DateTime(2020,12,11),"7000", "0")
            };
        }
        public IEnumerable<ClassFacture> Factures { get; }
 
    }
}
