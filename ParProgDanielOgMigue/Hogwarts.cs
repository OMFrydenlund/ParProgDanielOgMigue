using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgDanielOgMigue
{
    internal class Hogwarts
    {
        private List<Character> CharacterList;

        public Hogwarts()
        {
            CharacterList = new List<Character>()
            {
                new Character("Harry", "Griffindor"),
                new Character("Ron", "Griffindor"),
                new Character("Hermine", "Griffindor"),
                new Character("Draco Malfoy", "Slytherin")
            };

        }

        public void PrintCharacter()
        {
            foreach (Character c in CharacterList)
            {
                Console.WriteLine($"Name: {c.Name}\nHouse: {c.House}\n");

            }




        }
        
        public void Run()
        {
            PrintCharacter();     

            Console.ReadLine();
        
        
        
        
        
        }
    
    
    
    
    
    
    
    }
}
