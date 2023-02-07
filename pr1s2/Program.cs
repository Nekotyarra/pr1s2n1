using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1s2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*вычислить угол наклона прямой проходящей через начало координат и точку (х, у)*/
            bool N = false, N2 = false;
            string strx, stry;
            double x = 1, y = 0;
            while (!N || !N2)
            { 
            Console.WriteLine("Введите численное х");
            strx = Console.ReadLine();
            Console.WriteLine("Введите численное у");
            stry = Console.ReadLine();
            N = double.TryParse(strx, out x);
            N2 = double.TryParse(stry, out y);
            }
            double s = Math.Atan(y / x) * 180 /Math.PI;
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
