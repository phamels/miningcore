using System;
using System.Collections.Generic;
using System.Text;

namespace MiningCore.Blockchain.Zoin.DaemonResponses
{
    class ZoinBlockSubsidy
    {
        public decimal Amount { get; set; }
        public string Payee { get; set; }
        public string Script { get; set; }
    }
}
