using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloObjectWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Zdravic zdravic;
            zdravic = new Zdravic();
            zdravic.text = "Ahoj užívateľ ";
            Console.WriteLine(zdravic.Pozdrav("Palo"));
            Console.WriteLine(zdravic.Pozdrav("Karol"));
            zdravic.text = "Vítam ťa programátor";
            Console.WriteLine(zdravic.Pozdrav("Rišo"));
            Console.ReadKey();
        }
    }
}
