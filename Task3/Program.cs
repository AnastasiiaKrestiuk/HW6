using System;
//Я не поняла как сделать, чтобы программа копировала любой массив, только с определенным типом значений.
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ArrayCopy(int[] array)
            {
                int[] copied = new int[array.Length];
                for(int i = 0; i < array.Length; i++)
                {
                    copied[i] = array[i];
                }
                return copied;
            }
            void PrintArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
            }
            int[] array = { 5, 8, 6, 9, 15, 78, 26, 18, 0 };
            PrintArray(ArrayCopy(array));
        }
    }
}
