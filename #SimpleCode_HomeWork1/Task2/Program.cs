using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    //Введите три числа и выведите на экран значение суммы и произведения этих чисел.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите третие число ");
            double thirdNumber = double.Parse(Console.ReadLine());

            Console.WriteLine($"Сумма чисел равна: {firstNumber + secondNumber + thirdNumber}");
            Console.WriteLine($"Произведение чисел равно: {firstNumber * secondNumber * thirdNumber}");
        }
    }
}
