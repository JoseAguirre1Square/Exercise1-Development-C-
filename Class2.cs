using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class2
    {
        internal static void PrintFirstFiveValues(List<int> listOfIntegers)
        {

            /* Traditional Way */
            Console.Write("First Five Elements(Traditional Way): ");
            if (listOfIntegers.Count > 5)
            {
               
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(" - ");
                    Console.Write(listOfIntegers[i]);
                    
                }
            }
            else
            {
                for (int i = 0; i < listOfIntegers.Count; i++)
                {
                    Console.Write(" - ");
                    Console.Write(listOfIntegers[i]);
                }
            }
          
            /* With Take Method of C# */
            Console.WriteLine("\nFirst Five Elements(Take method of List Class):" + string.Join(" - ", listOfIntegers.Take(5)));
                       


        }
        internal static void PrintSmallestNumber(int[] array)
        {
            int y = array[0];
            for(int x = 0; x < array.Length; x++)
            {
                if (y > array[x])
                {
                    y = array[x];
                }
            }
            Console.WriteLine("Smallest Number: " + y);

        }
        internal static void PrintDictionary()
        {
            Dictionary<int,string> dictorionaryExample = new Dictionary<int,string>();
            dictorionaryExample.Add(1, "example1");
            dictorionaryExample.Add(2, "example2");
            dictorionaryExample.Add(3, "example3");
            dictorionaryExample.Add(4, "example4");
            dictorionaryExample.Add(5, "example5");
            dictorionaryExample.Add(6, "example6");
            dictorionaryExample.Add(7, "example7");

            foreach (KeyValuePair<int,string> keyValuePair in dictorionaryExample)
            {
                Console.WriteLine("Key: "+keyValuePair.Key + ",Value: " + keyValuePair.Value);
            }



        }

    }
}
