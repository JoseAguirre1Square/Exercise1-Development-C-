using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Call method CountStringLength*/
            Console.WriteLine("String length: " + Class1.CountStringLength("Dario"));


            /*Call method StringComparison*/
            Console.WriteLine("String Comparison:" + Class1.StringComparison("Dario","Dario"));
           

            /*Call method VerifyBiggestNumber*/
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            Class1.VerifyBiggestNumber(list);
        
            /* Call method to order a list SortList  */
            List<string> list2 = new List<string>();
            list2.Add("a");
            list2.Add("b");
            list2.Add("c");
            list2.Add("d");
            list2.Add("e");
            list2.Add("f");
            list2.Add("g");
            Class1.SortList(list2);


            Class2.PrintFirstFiveValues(list);

            Class2.PrintSmallestNumber(list.ToArray());

            Class2.PrintDictionary();
     
            Console.ReadKey();
           
        }
    }
}
