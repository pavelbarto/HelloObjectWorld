using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloObjectWorld
{
    class Zdravic
    {
        public string text;
        public string Pozdrav(string meno)
        {
            // Console.WriteLine("Hello world objeckt ");
            // Console.WriteLine("Ahoj užívateľ {0}", meno);
            return String.Format("{0} {1}", text, meno);
        }
    }
}
