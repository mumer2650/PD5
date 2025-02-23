using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    internal class MainMenu
    {
        public static string Menu()
        {

            Console.WriteLine("1.  Sing up Manu\n2.  Sing in Manu\n3.  Admin");
            return Console.ReadLine();
        }
    }
}
