using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Вариант 12
В одномерном массиве, состоящем из n вещественных элементов, вычислить:
 количество элементов массива, больших С;
 произведение элементов массива, расположенных после максимального по модулю элемента.*/

namespace _3_1_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] elems = new double[] { -8, -2, 0, -1, -15, 1, 6, 7 };
            double C = 3;

            // Количество элементов массива, больших С:
            int count = 0;
            for (int i = 0; i < elems.Length; i++)
                if (elems[i] > C)
                    count++;
            Console.WriteLine($"count = {count}");

            // Номер максимального элемента:
            double max = Math.Abs(elems[0]);
            int num = 0;
            for (int i = 1; i < elems.Length; i++)
                if (Math.Abs(elems[i]) > max)
                {
                    max = Math.Abs(elems[i]);
                    num = i;
                }
            Console.WriteLine($"max = {max}, num = {num}");

            // Произведение:
            double prod = 1;
            for (int i = num + 1; i < elems.Length; i++)
                prod *= elems[i];
            Console.WriteLine($"prod = {prod}");

            Console.ReadKey();
        }
    }
}
