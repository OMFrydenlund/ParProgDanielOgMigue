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
       
        
        public void Run()
        {
            //LoopThroughCharacterList();
            //meny:
            /*
             * 1. Go to shop
             * 2. View characters
             *  - underlist med navn, print ut en char info eller gå tilbake
             * 3. cast spell.
             */

            /*
             * Select a character:
             * 
             */
            MainMenu();
            Console.ReadLine();
        
        
        
        }

        public void MainMenu()
        {
            bool inMain = true;
            int userInput = 0;
            while (inMain)
            {
                int listCounter = 1;              
                Console.WriteLine("Select a character: ");
                foreach (var character in CharacterList)
                {
                    Console.Write($"{listCounter}. {character.Name}\n");
                    listCounter++;
                }
                userInput = Convert.ToInt32(Console.ReadLine()) - 1;
                CharacterList[userInput].RunCharacterMenu(CharacterList[userInput]);
            }
        }

        public void LoopThroughCharacterList()
        {
            foreach (Character c in CharacterList)
            {
                c.PrintCharacterInfo(c);

            }




        }

        public void PrintCharacterWithItemInfo(Character c)
        {
            c.PrintCharacterInfo(c);
            foreach (Item i in c.Inventory)
            {
                i.PrintItemInformation();
            }

        }






    }
}
