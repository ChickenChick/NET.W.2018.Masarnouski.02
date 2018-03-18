using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Combinatorics.Collections;

namespace NET.W._2018.Masarnouski._02
{
    public class Task_2_3
    {
        public static int FindNextBiggerNumber(int inputNumber)
        {
            
            List<int> resultList = new List<int>();
            List<char> inputSet = inputNumber.ToString().ToList(); //Create char List from inputNumber
            List<string> stringList = new List<string>();
            Permutations<char> combinations =
                new Permutations<char>(inputSet, GenerateOption.WithoutRepetition);  //List  of combinations

            foreach (IList<char> p in combinations)    //Get a string list of all combinations
            {
                string temp = string.Empty;
                foreach (char v in p)
                {
                    temp += v;
                }
                resultList.Add(int.Parse(temp));
            }
            resultList.Sort();                      
            try
            {
                return resultList[resultList.FindIndex(c => c == inputNumber) + 1];    //Get index next to index
                                                                                       // of input number in sorted list
            }
            catch
            {
                return -1;
            }

        }
        public static void FindNextBiggerNumberExtended(int inputNumber)  //метод с подсчётом времени исполнения
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine($"The Number Is {Task_2_3.FindNextBiggerNumber(inputNumber)}");
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
            Console.ReadLine();
        }

    }
}
