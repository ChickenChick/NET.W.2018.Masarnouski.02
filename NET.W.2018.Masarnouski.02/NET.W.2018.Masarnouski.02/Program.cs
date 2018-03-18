using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Combinatorics.Collections;
namespace NET.W._2018.Masarnouski._02
{
    class Program
    {
        static void Main()
        {
            //Task5
            Console.WriteLine(Task_5.FindNthRoot(-0.008, 3, 0.1));
            Console.ReadLine();

            //Task 4
            List<int> temp = new List<int>() { 3, 66, 54, 0, 23, 76, 87, 45, 0, 23, 7, 0 };
            var result = Task_4.FilterDigit(temp, 7);
            foreach (var n in result)
                Console.WriteLine(n);
                Console.ReadLine();

            //Task3
            Task_2_3.FindNextBiggerNumberExtended(214748);

            // Task2
            Console.WriteLine(Task_2_3.FindNextBiggerNumber(214748364));
            Console.ReadLine();

            //Task1
            Console.WriteLine(Task_1.InsertNumber(8, 15, 3, 8));
            Console.ReadLine();
        }
    }
}
    

