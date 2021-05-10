using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            //Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
            //Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
            //В данной задаче под парой подразумевается два подряд идущих элемента массива.
            //Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.

            int count = 0;
            double[] array = new double[6];

            Random r = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(-10, 10);
                Console.Write($"{array[i]}, ");

                if (array[i] %3 == 0 && array[i])
                {
                    count++;
                }
            }
            Console.WriteLine("\n " +count);
            Console.ReadLine();
        }
    }
}
