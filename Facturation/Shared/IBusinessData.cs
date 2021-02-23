using Facturation.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation.Shared
{
    public interface IBusinessData
    {
        IEnumerable<ClassFacture> Factures { get; }

        IEnumerable<ClassFacture> GetFactures(DateTime? debut, DateTime? fin);
    }
}
