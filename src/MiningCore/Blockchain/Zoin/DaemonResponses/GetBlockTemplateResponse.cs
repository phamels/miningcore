using System;
using System.Collections.Generic;
using System.Text;

namespace MiningCore.Blockchain.Zoin.DaemonResponses
{
    class GetBlockTemplateResponse : Bitcoin.DaemonResponses.BlockTemplate
    {
        public ZoinBlockSubsidy Subsidy { get; set; }
    }
}
