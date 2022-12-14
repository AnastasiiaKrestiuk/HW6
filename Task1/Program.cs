using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int GetNumbers(string massage)
            {
                int result = 0;
                bool isCorrect = false;

                while (!isCorrect)
                {
                    Console.WriteLine(massage);
                    if (int.TryParse(Console.ReadLine(), out result))
                    {
                        isCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели не число. Введите число.");
                    }
                }

                return result;
            }
            int[] InitArray(int length)
            {
                int[] array = new int[length];                
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = GetNumbers("Ведите значение:");
                }
                return array;
            }
            int CountPlus(int[] array)
            {
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {                    
                    if(array[i] > 0)
                    {
                        count++;
                    }                    
                }
                return count;
            }
            int m = GetNumbers("Введите размер массива:");
            int[] array = InitArray(m);
            Console.WriteLine(CountPlus(array));
        }
    }
}
