using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        //Напишите простой конвертер валют (без возможности динамичесского выбора валюты пользователем.)
        //Валюты заданы хардкодом и не изменяются. Тип валют на выбор программиста.
        static void Main(string[] args)
        {
            double UsdToRub = 76.59; //Доллар к рублю
            double UsdToChf = 0.92;  //Доллар к швейцарскому франку
            Console.WriteLine("Сколько долларов конвертировать во франки и рубли? ");
            double Usd = double.Parse(Console.ReadLine());

            Console.WriteLine($"{Usd * UsdToRub} руб. в {Usd}$ ");
            Console.WriteLine($"{Usd * UsdToChf} франк в {Usd}$ ");
        }
    }
}
