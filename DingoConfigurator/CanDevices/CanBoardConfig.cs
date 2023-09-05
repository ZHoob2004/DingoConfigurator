﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanDevices
{
    public class CanBoardConfig
    {
        public CanBoardConfig()
        {
            name = String.Empty;
            label = String.Empty;
            baseCanId = 0;
        }

        public string name {  get; set; }
        public string label { get; set; }
        public int baseCanId { get; set; }
    }
}
