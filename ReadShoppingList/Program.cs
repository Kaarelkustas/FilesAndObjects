using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ReadShoppingList
{
    class Program
    {
        public class Item
        {
            string name;
            int price;

            public Item(string _name, int _price)
            {
                name = _name;
                price = _price;
            }

            public string Name { get { return name; } }
            public int Pirce { get { return price; } }
        }

        static void Main(string[] args)
        {
            ReadFromShoppingList();
                
        }

        public static void ReadFromShoppingList()
        {
            string filePath = @"C:\Users\opilane\samples";
            string fileName = @"shoppingList.txt";
            List<Item> shoppingItems = new List<>
        }

                                                                  
    }
}
