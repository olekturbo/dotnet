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
            if (n < 1)
                return 1;
            else
                return n * Silnia(n - 1);
        }

        public static double Newton(this double x, double n)
        {
            double difference = x - n;
            return x.Silnia() / (n.Silnia() * difference.Silnia());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double x = 5;
            double y = 3;
            Console.WriteLine($"{x}! = {x.Silnia()}");
            Console.WriteLine($"N({x})({y}) = {x.Newton(y)}");
            Console.ReadKey();
        }
    }
}
