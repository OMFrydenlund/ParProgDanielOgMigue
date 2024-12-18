using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgDanielOgMigue
{
    internal class Character
    {
        public string Name { get; private set; }
        public string House { get; private set; }
        public List<Item> ItemList;

        public Character(string name, string house)
        {
            ItemList = new List<Item>();
            Name = name;
            House = house;
        }

        
        
      











    }

}
