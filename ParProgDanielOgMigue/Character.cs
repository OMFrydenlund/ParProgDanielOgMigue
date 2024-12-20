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
        public List<Item> Inventory;

        public Character()
        {

        }

        public Character(string name, string house)
        {
            Inventory = new List<Item>();
            Name = name;
            House = house;
        }

        public void RunCharacterMenu(Character character)
        {
            bool inCharacterMenu = true;
            string userInput;
            while (inCharacterMenu)
            {
                
                Console.WriteLine($"Current wizard: {character.Name}\nChoose an action: \n1. Cast spells\n2. Go to magic shop\n3. Show character info\n" +
                    $"4. Back to main menu");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        CastSpell();
                        break;
                    case "2":
                        MagicShop newShop = new MagicShop();
                        newShop.RunShopMenu(character);
                        break;
                    case "3":
                        character.PrintCharacterInfo(character);
                        break;
                    case "4":
                        inCharacterMenu = false;
                        break;
                    default:
                        Console.WriteLine("That's not a valid choice.");
                        break;
                }
            }
        }

        public void PrintCharacterInfo(Character character)
        {
            Console.WriteLine($"Name: {character.Name}\nHouse: {character.House}\nItems: ");
            PrintInventoryInfo(character);
        }

        private void PrintInventoryInfo(Character character)
        {
            foreach (var item in character.Inventory)
            {
                item.PrintItemInformation();
            }
        }


        private void CastSpell()
        {
            Console.WriteLine("Speak your phrase: ");
            var userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case "vingardium leviosa":
                    VingardiumLeviosa();
                    break;
                case "hokus pokus":
                    HokusPokus();
                    break;
                default:
                    Console.WriteLine("You have no idea what you're trying to cast, do you?");
                    break;
            }

        }





        public void VingardiumLeviosa()
        {
            Console.WriteLine($"{Name} casts Wingardium Leviosa!");
        }




        public void HokusPokus()
        {
            Console.WriteLine($"{Name} casts Hokus Pokus!");
        }


        public void AddWeaponToInventory(string choice)
        {
            Item newItem = new Item();
            if (choice == "1")
            {
                newItem.Name = "Phoenix";
                newItem.Type = "Staff";
            }
            else if (choice == "2")
            {
                newItem.Name = "Unicorn";
                newItem.Type = "Staff";
            }
            else if (choice == "3")
            {
                newItem.Name = "Troll";
                newItem.Type = "Staff";
            }
            Inventory.Add(newItem);
        }

        public void AddAnimalToInventory(string choice)
        {
            Item newItem = new Item();
            if(choice == "1")
            {
                newItem.Name = "Owl";
                newItem.Type = "Bird";
            }
            
            if(choice == "2")
            {
                newItem.Name = "Rat";
                newItem.Type = "Vermin";
            }
            
            if(choice == "3")
            {
                newItem.Name = "Cat";
                newItem.Type = "Mammal";
            }
            Inventory.Add(newItem);
        }
    
    } 

}
