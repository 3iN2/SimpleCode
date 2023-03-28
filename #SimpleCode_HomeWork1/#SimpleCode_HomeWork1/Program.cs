using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _SimpleCode_HomeWork1
{
    // Написать программу, вычисляющую среднее арфиметичесское двух чисел.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое целое число: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе целое число: ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine($"Среднее арифметичесское двух чисел: {(firstNumber + secondNumber) / 2}");
        }
    }
}
