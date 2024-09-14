using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesListsLINQ
{
    class LINQ
    {
        public void DivisibleByTwo()
        {
            int[] arr = new int[10] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            //use linq to extract a list of numbers that are divisible by 2
            // print the resulting list values
            var filtered = from value in arr
                           where value % 2 == 0
                           select value;

            Console.Write("DivisibleByTwo Results: ");

            foreach (var item in filtered)
            {
                Console.Write(item + " ");
            }
            
        }

        public void NumbersInRange()
        {
            int[] arr = new int[13] { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14};
            // linq for numbers 0-12 excluding 0 and 12
            // sort in descending order
            // print resulting values
            var filtered = from value in arr
                           where value > 0 && value < 12
                           orderby value descending
                           select value;

            Console.Write("\nNumbersInRange Results: ");
            foreach (var item in filtered)
            {
                Console.Write(item + " ");
            }
        }

        public void CityInformation()
        {
            string[] cities = new string[9] { "ROME", "LONDON", "NAIROBI",
                "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS"};
            // ask for a starting char
            // ask for an ending char
            // extract all city names that start with start char or end with end char
            // print resulting values
            // if no city was found print an appropriate message
            Console.Write("\nThe cities are : ");
            
            foreach (string city in cities)
            {
                Console.Write("\'" + city + "\',");
            }
            
            Console.Write("\nInput starting character for the city : ");
            string start = Console.ReadLine();
            Console.Write("Input ending character for the city : ");
            string end = Console.ReadLine();
            var filtered = from city in cities
                           where city.StartsWith(start.ToUpper()) || city.EndsWith(end.ToUpper())
                           select city;

            Console.WriteLine("City(s) starting with a or ending with i : ");
            foreach (var item in filtered)
            {
                Console.WriteLine(item);
            }
            if(filtered.Count() == 0)
            {
                Console.WriteLine("Sorry no cities found with those selected characters");
            }

        }
    }
}
