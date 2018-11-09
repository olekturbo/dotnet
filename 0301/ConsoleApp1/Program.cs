using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Ilosc
    {
        public Ilosc(int sztuka) => Sztuka = sztuka;

        public int Sztuka { get; set; }

        public int Kopa
        {
            set => Sztuka = value / 60;
            get => Sztuka * 60;
        }

        public int Tuzin
        {
            set => Sztuka = value / 12;
            get => Sztuka * 12;
        }

        public int Mendel
        {
            set => Sztuka = value / 15;
            get => Sztuka * 15;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ilosc i1 = new Ilosc(10);
            Console.WriteLine($"Kopa = {i1.Kopa}, Tuzin = {i1.Tuzin}, Mendel = {i1.Mendel}, Sztuka = {i1.Sztuka}");
            i1.Kopa = 60;
            Console.WriteLine($"Kopa = {i1.Kopa}, Tuzin = {i1.Tuzin}, Mendel = {i1.Mendel}, Sztuka = {i1.Sztuka}");
            Console.ReadKey();
        }
    }
}
