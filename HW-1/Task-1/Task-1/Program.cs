using Microsoft.CSharp.RuntimeBinder;
using System.Diagnostics;
using System.Globalization;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Реализуйте 3 метода, чтобы в каждом из них получить разные исключения
               Посмотрите на код, и подумайте сколько разных типов исключений вы тут сможете получить?

               Реализуйте метод, принимающий в качестве аргументов два целочисленных массива, и возвращающий новый массив, 
               каждый элемент которого равен разности элементов двух входящих массивов в той же ячейке. 
               Если длины массивов не равны, необходимо как-то оповестить пользователя.

             * Реализуйте метод, принимающий в качестве аргументов два целочисленных массива, и возвращающий новый массив,
             * каждый элемент которого равен частному элементов двух входящих массивов в той же ячейке. 
             * Если длины массивов не равны, необходимо как-то оповестить пользователя. 
             * Важно: При выполнении метода единственное исключение, 
             * которое пользователь может увидеть - RuntimeException, т.е. ваше.
             */



            // Task - 1
            void PrintLength(string str)
            {
                if(str == null)
                {
                    throw new ArgumentNullException("Строка null");
                }
                else
                {
                    Console.WriteLine(str.Length);
                }
            }

            void GetElementAtIndex(int[] array,  int index) 
            {
                if(index < 0 || index >= array.Length)
                {
                    throw new ArgumentOutOfRangeException("Индекс за пределами массива");
                }
                else
                {
                    Console.WriteLine($"Индекс {index} имеет значение: {array[index]}");
                }
            }

            void ConvertToInt(string str)
            {
                int num;
                try
                {
                    num = Convert.ToInt32(str);
                    Console.WriteLine(num);
                }

                catch(FormatException)
                {
                    Console.WriteLine("Невозможно преобразовать строку в цисло");
                }
            }


            // Task - 2
            // Реализуйте метод, принимающий в качестве аргументов два целочисленных массива, и возвращающий новый массив, 
            // каждый элемент которого равен разности элементов двух входящих массивов в той же ячейке.
            // Если длины массивов не равны, необходимо как-то оповестить пользователя.



            int[] DifArray(int[] array1, int[] array2)
            {
                if(array1.Length != array2.Length)
                {
                    throw new RuntimeBinderException("Массивы разной длинны.");
                }
                else
                {
                    int[] resultArray = new int[array1.Length];
                    for (int i = 0; i < array1.Length; i++)
                    {
                        resultArray[i] = array1[i] - array2[i];
                    }
                    return resultArray;
                }
            }

            //Task - 3
            /*
             * Реализуйте метод, принимающий в качестве аргументов два целочисленных массива, и возвращающий новый массив,
             * каждый элемент которого равен частному элементов двух входящих массивов в той же ячейке. 
             * Если длины массивов не равны, необходимо как-то оповестить пользователя. 
             * Важно: При выполнении метода единственное исключение, 
             * которое пользователь может увидеть - RuntimeException, т.е. ваше.
             */

            Console.WriteLine(DiVArray(ar1, ar2));

            int[] DiVArray(int[] array1, int[] array2)
            {
                if (array1.Length != array2.Length)
                {
                    throw new RuntimeBinderException("Массивы разной длинны.");
                }
                else
                {
                    int[] resultArray = new int[array1.Length];
                    for (int i = 0; i < array1.Length; i++)
                    {
                        if (array2[i] == 0)
                        {
                            throw new RuntimeBinderException("На ноль делить нельзя.");
                        }
                        else
                        {
                            resultArray[i] = array1[i] / array2[i];
                        }

                    }
                    return resultArray;
                }
            }


        }
    }
}