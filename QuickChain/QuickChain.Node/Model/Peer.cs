﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickChain.Node.Model
{
    public class Peer
    {
        public string Url { get; set; }
        public long MinedBlocksSinceConnected { get; set; }
    }
}
