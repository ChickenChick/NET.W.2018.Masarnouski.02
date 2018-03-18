using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Masarnouski._02
{
    public class Task_1
    {
        public static int InsertNumber(int numberSourse, int numberIn, int start, int end)
        {
            if (start < 0 || end < 0)
                throw new ArgumentException("Аргументы 3 и 4 должны быть больше нуля");
           
           if (start > end)
                throw new ArgumentException("Начальный индекс должен быть меньше конечного");

            int numberInShifted = numberIn << start;                     //бинарный сдвиг влево 

            string BinarySourse = Convert.ToString(numberSourse, 2);          //Convert to binary in a string 
            string BinaryIn = Convert.ToString(numberInShifted, 2);                  //Convert to binary in a string 


            int[] bitsSourse = BinarySourse.PadLeft(31, '0')         // Add 0's from left 
           .Select(c => int.Parse(c.ToString()))                     // convert each char to int 
           .ToArray();                                               // Convert IEnumerable from select to Array 
            int[] bitsIn = BinaryIn.PadLeft(31, '0')                 // Add 0's from left 
            .Select(c => int.Parse(c.ToString()))                    // convert each char to int 
            .ToArray();
            //foreach (var b in bitsSourse)
            //    Console.Write(b + " ");
            //Console.ReadLine();
            //foreach (var b in bitsIn)
            //    Console.Write(b + " ");
            //Console.ReadLine();

            if (start == 0)                                     //если стартовый индекс = 0, скопировать
            {                                                   //весь первый массив во второй, кроме последнего числа
                for (int i = 0; i <= 30 - 1; i++)                   
                {
                    bitsIn[i] = bitsSourse[i];
                }
            }
            else
            {
               
                for (int i = 30; i > 30 - start; i--)    //скорировать значения из первого массива во второй(после сдвинутой части)
                {
                    bitsIn[i] = bitsSourse[i];
                }

                for (int i = 0; i < 30 - end; i++)       //скопировать значения из первого массива во второй(до сдвинутой части)
                {
                    bitsIn[i] = bitsSourse[i];
                }
            }
            //foreach (var b in bitsIn)
            //    Console.Write(b + " ");
            //Console.ReadLine();
            string resultStroke = "";
            foreach (var n in bitsIn)                      // формирование результирующей строки
            {
                resultStroke += n.ToString();    
            }

            int result = Convert.ToInt32(resultStroke, 2);       // перевод строки в десятичное число
            return result;
        } 
    }
}
