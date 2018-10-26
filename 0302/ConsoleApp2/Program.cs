using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03DniTygodnia
{
    class MonthsCollection
    {
        string[] months = { "Styczeń", "Luty", "Marzec", "Kwiecień", "Maj", "Czerwiec", "Lipiec", "Sierpień", "Wrzesień", "Październik", "Listopad", "Grudzień" };
        int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        private int getData(string month)
        {
            for(int i = 0; i < months.Length; i++)
            {
                if(months[i] == month)
                {
                    return days[i];
                }
            }
            return -1;
        }

        private int find(string month)
        {
            for(int i = 0; i < months.Length; i++)
            {
                if(months[i] == month)
                {
                    return i;
                }
            }
            return -1;
        }

        public int this[string month]
        {
            get => getData(month);
            set => days[find(month)] = value;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MonthsCollection month = new MonthsCollection();
            System.Console.WriteLine(month["Styczeń"]);
            month["Styczeń"] = 15;
            System.Console.WriteLine(month["Styczeń"]);
            Console.ReadKey();
        }
    }
}