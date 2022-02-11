using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        internal static string StringComparison(string wordOne, string wordTwo)
        {
            if(wordOne == wordTwo)
            {
                return "Igual";
            }
            else
            {
                return "No Igual";
            }

        }
        internal static void VerifyBiggestNumber(List<int> a)
        {
            Console.WriteLine("The biggest number in the list is: " + a.Max());
         }
        internal static void SortList(List<string> listStringToOrder)
        {
            listStringToOrder.Sort();

                Console.WriteLine("List sorted by asc order: " + string.Join(" - ", listStringToOrder));
           
            listStringToOrder.Reverse();
           
                Console.WriteLine("List sorted by desc order: " + string.Join(" - " ,listStringToOrder));
         
        }
        internal static int CountStringLength(string wordToCount)
        {
            return wordToCount.Length;
        }
    }
}
