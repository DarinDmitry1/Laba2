using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class Cat
    {

        public string Namecat { get; set; }

    public Cat (string name)
        { 
            Namecat = name;
        }

        public override string ToString()
        {
            return $"Кот {Namecat}";
        }
        
        public void Mew()
        {
            Console.WriteLine($"{Namecat} МЯУ");
        }

        public void MewN(int times)
        {
            if (times <= 0)
            {
                Console.WriteLine($"{Namecat} молчит");
            }

            string sound = string.Join("-", Enumerable.Repeat("мяу", times));
            Console.WriteLine($"{Namecat}: {sound}");
        }
    }

}
