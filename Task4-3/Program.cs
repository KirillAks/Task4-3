using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_3
{
    class Program
    {
        // Найти количество квадратов размещенных на прямоугольнике
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительные числа A, B, C");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int counterA = 0;
            int counterB = 0;            
            while (a>=c)
            {
                a -= c;
                counterA++;
            }
            while (b >= c)
            {
                b -= c;
                counterB += counterA;
            }            
            Console.WriteLine("Количество квадратов в прямоугольнике равно {0}", counterB);
            Console.ReadKey();
        }
    }
}
