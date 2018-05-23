using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatchTheDeceiver.Models.Deciever;

namespace CatchTheDeceiver.Models
{
    /// <summary>
    /// Potencial Deciever, Contains ID, IPAdress and List of Proof
    /// </summary>
    public class PotentialDeciever
    {
        public int ID { get; set; }

        public IPAddress IpAddress { get; set; }

        public ApplicationUser UserAddedApplicationUser { get; set; }

        private List<IProofData> listOfProof;

    }
    /// <summary>
    /// Base IP Address class
    /// </summary>
    public class IPAddress
    {
        public int ID { get; set; }

        public string Address { get; set; }
    }
}
