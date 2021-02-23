using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facturation.Shared
{
    public class ClassClient
    {
        private string NumeroClient { get; set; }
        private string NomClient { get; set; }
        private string PrenomClient { get; set; }


        public ClassClient (string NumeroClient, string NomClient, string PrenomClient)
        {
            this.NumeroClient = NumeroClient;
            this.NomClient = NomClient;
            this.PrenomClient = PrenomClient;

        }
    }
}
