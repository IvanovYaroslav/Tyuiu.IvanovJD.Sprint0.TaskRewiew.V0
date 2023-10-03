using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovJD.Sprint0.TaskRewiew.V0.Lib;

namespace Tyuiu.IvanovJD.Sprint0.TaskRewiew.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт №0 | Выполнил: Иванов Я. Д. | ПКТБ-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #0                                                                *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                              *");
            Console.WriteLine("* Задания #7                                                               *");
            Console.WriteLine("* Вариант #0                                                               *");
            Console.WriteLine("* Выполнил: Иванов Ярослав Дмитриевич  | ПКТБ-23-2                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать консольную программуна С# контрольная работа TaskRewiew#0       *");
            Console.WriteLine("* вычислить значение выражения (x+y+z)*5                                   *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:x = 2 y = 7 z = 9                                        *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Введите число x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число y");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число z");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine(DataService.Calc(x, y, z));
            Console.ReadLine();
        }
    }
}