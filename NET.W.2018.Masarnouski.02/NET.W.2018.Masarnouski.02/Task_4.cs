using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Masarnouski._02
{
   public class Task_4
    {
        public static List<int> FilterDigit(List<int> inputList,int inputNumber)
        {
            List<int> resultList = new List<int>();
            foreach (var item in inputList)
            {
                int temp = item;
                while (temp != 0)
                {
                    if (temp % 10 == inputNumber || temp % 10 == -inputNumber)
                    {
                        resultList.Add(item);
                        break;
                    }
                    else
                    {
                        temp /= 10;
                    }
                }
            }
            return resultList;
        }
    }
}
