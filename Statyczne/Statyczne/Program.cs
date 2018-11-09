using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statyczne
{
    static class Rozszerzenie
    {
        public static double Silnia(this double n)
        {
            return (n < 1) ? 1 : n * Silnia(n - 1);
        }

        public static double Newton(this double x, double n)
        {
            return x.Silnia() / (n.Silnia() * (x-n).Silnia());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double x = 5, y = 3;
            Console.WriteLine($"{x}! = {x.Silnia()}");
            Console.WriteLine($"N({x})({y}) = {x.Newton(y)}");
            Console.ReadKey();
        }
    }
}
