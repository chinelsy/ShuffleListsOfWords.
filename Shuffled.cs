
using System;
using System.Collections.Generic;
using System.Linq;

namespace WeekEndTask
{// Question: Write a query that shuffles a sorted List of words.
    public static class Shuffled
    {
        public static void SortedList()
        {
            //A list of word sorted in alphabatical order
            var SortedList = new List<string>()
            { "Apple", "Ball", "Cat", "Dog", "Fish", "House","Zebra" };

            Console.WriteLine();
            //Shuffled the alphabatical sortedlist using the random()
            Console.WriteLine("Random sorting ===========================");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            var random = new Random();
            var shuffle = SortedList.OrderBy(x => random.Next());
            foreach (var items in shuffle)
            {
                Console.WriteLine($"{items}");
            }
            Console.ResetColor();

            Console.WriteLine();

            //Shuffled the alphabatical sortedlist using the Query Syntax()
            Console.WriteLine("Query Syntax ===========================");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            var querySortedList = from sorted in SortedList
                                  orderby random.Next()
                                  select sorted;
            foreach (var items in querySortedList)
            {
                Console.WriteLine($"{items}");
            }
            Console.ResetColor();

            Console.WriteLine();

            //Shuffled the alphabatical sortedlist using the Method Syntax ()
            Console.WriteLine("Method Syntax ===========================");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            var methodSortedList = SortedList.OrderBy(x => random.Next());
            foreach (var items in methodSortedList)
            {
                Console.WriteLine($"{items}");
            }
            Console.ResetColor();

           
        }
    }
}      
      
   
    
            

