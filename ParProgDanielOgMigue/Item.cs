﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgDanielOgMigue
{
    internal class Item
    {
        public string Type { get; set; }
        public string Name { get; set; }

        public Item(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}
