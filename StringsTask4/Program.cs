using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsTask4
{
    class Program
    {
        static void Main()
        {//Написать программу, которая запрашивает символ и выводить на консоль его код в шестнадцатеричной системе счисления, а также символ, следующий за ним в таблице символов.
            Console.WriteLine("Введите символ: ");
            int a = Convert.ToInt32(char.Parse(Console.ReadLine()));

            string symbol1 = a.ToString("X");
            a++;
            string symbol2 = a.ToString("X"); 

            Console.WriteLine("0x{0}, 0x{1}", symbol1, symbol2);
            Console.ReadKey();
        }
    }
}
