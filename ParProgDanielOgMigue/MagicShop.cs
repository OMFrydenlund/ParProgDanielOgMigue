using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgDanielOgMigue
{
    internal class MagicShop
    {
        public MagicShop()
        {
            
        }

        public void RunShopMenu(Character character)
        {
            bool inShopMenu = true;
            while (inShopMenu)
            {
                Console.WriteLine("1. Buy animal\n2. Buy staves\n3. Return to main menu");
                var userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        BuyAnimal(character);
                        break;
                    case "2":
                        BuyStaff(character);
                        break;
                    case "3":
                        inShopMenu = false;
                        break;
                    default:
                        Console.WriteLine("Not a valid choice!");
                        break;
                }
            }
            
        }
       
        public void BuyAnimal(Character character)
        {
            Console.WriteLine("Which animal would you like to buy:\n1. Owl\n2. Rat\n3 Cat");
            var userInput = Console.ReadLine();
            character.AddAnimalToInventory(userInput);
            foreach (Item i in character.Inventory) 
            {
                i.PrintItemInformation();
            }

        }  
      
        

        public void BuyStaff(Character character)
        {
            Console.WriteLine("Which weapon would you like to buy:\n1. Phoenix staff\n2. Unicorn staff\n3. Troll staff");
            var userInput = Console.ReadLine();
            character.AddWeaponToInventory(userInput);
            foreach (Item i in character.Inventory)
            {
                i.PrintItemInformation();
            }
        }
    }
}
