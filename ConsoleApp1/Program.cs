using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько чисел будем анализировать? (введите количество): ");
            int n = GetIntegerNum();
            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите {i + 1}  целое число: ");
                nums[i] = (int)GetIntegerNum();
            }

            int min = nums[0], max = nums[0], sum = 0;
            int positiveCount = 0, negativeCount = 0, zeroCount = 0;

            foreach (int num in nums)
            {
                sum += num;
                if (min > num) min = num;
                if (max < num) max = num;

                if (num < 0)
                    negativeCount++;
                else if (num > 0)
                    positiveCount++;
                else
                    zeroCount++;
            }

            double avg = Convert.ToDouble(sum) / Convert.ToDouble(n);

            Console.WriteLine();

            Console.WriteLine($"Минимальное значение:             {min}");
            Console.WriteLine($"Максимальное значение:            {max}");
            Console.WriteLine($"Среднее значение:                 {avg}");
            Console.WriteLine($"Количество положительных чисел:   {positiveCount}");
            Console.WriteLine($"Количество отрицательных чисел:   {negativeCount}");
            Console.WriteLine($"Количество нулей:                 {zeroCount}");

            Console.ReadKey();
        }

        static int GetIntegerNum()
        {
            string amount = Console.ReadLine();
            int n;
            while (!int.TryParse(amount, out n))
            {
                Console.Write("Введено ошибочное значение! Повторите ввод: ");
                amount = Console.ReadLine();
            }
            return n;
        }
    }
}

  
