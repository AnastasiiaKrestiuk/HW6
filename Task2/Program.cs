using System;

namespace Task2
{
    //y = k1 * x + b1
    //y = k2 * x + b2
    class Program
    {
        static void Main(string[] args)
        {
            double GetNumbers(string massage)
            {
                double result = 0;
                bool isCorrect = false;

                while (!isCorrect)
                {
                    Console.WriteLine(massage);
                    if (double.TryParse(Console.ReadLine(), out result))
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
            string Solution(double k1, double b1, double k2, double b2)
            {
                double x = (b1 - b2) / (k2 - k1);
                double y = (k2 * x) + b2;
                
                string result = $"({x}; {y})";

                return result;
            }

            double k1 = GetNumbers("Введите k1:");
            double b1 = GetNumbers("Введите b1:");
            double k2 = GetNumbers("Введите k2:");
            double b2 = GetNumbers("Введите b2:");
            
            Console.WriteLine(Solution(k1, b1, k2, b2));
        }
    }
}
