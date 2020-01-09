using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _70_A_Custom_Search_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            BuildList(numbers, 20);
            Display(numbers);
            int item;
            Console.WriteLine();
            Console.WriteLine("Enter an Item: ");
            item = Convert.ToInt32(Console.ReadLine());
            List<int> foundItems = new List<int>();
            foundItems = Search(numbers, item);
            Display(foundItems);
        }
        static List<int> Search(List<int> lyst, int item)
        {
            int foundAt, pos;
            pos = 0;
            List<int> items = new List<int>();
            foundAt = lyst.IndexOf(item, pos);
            items.Add(foundAt);
            while (foundAt > -1)
            {
                pos = foundAt + 1;
                foundAt = lyst.IndexOf(item, pos); // stores item and position in foundAt variable
                if (foundAt > -1) 
                {
                    items.Add(foundAt);
                }
                
            }
            return items;

        }
            

        static void Display(List<int> lyst) // Displays the random number generators and adds a space every 5th line
        {
            for (int i = 0; i < lyst.Count; ++i)
            {
                if (i % 25 == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(lyst[i] + " ");
                }
            }
        }
        static void BuildList(List<int> lyst, int numItems ) // This method populates our list with random numbers using .Next method
        {
            Random rand = new Random();
            for (int i = 0; i <= numItems; ++i)
            {
                lyst.Add(rand.Next(1, 101));
            }
        }
        
    }
}
