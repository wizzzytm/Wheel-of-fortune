﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoloFortunyPL
{
    public class Player
    {
        public string Name { get; set; }
        public int Money { get; set; }
        public Player(string name)
        {
            Name = name;
        }
    }
}
