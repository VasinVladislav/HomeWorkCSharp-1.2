using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.2. Вывести на экран число e (основание натурального логарифма) с точностью до десятых.
            double numberE = Math.E; //Определяем переменную и присваеваем ей константу (E).
            double result = Math.Round(numberE, 1); //сокращаем до 1го символова после целого числа.
            Console.WriteLine(result);
        }
    }
}
