using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Boy : ");
            double boy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kilo : ");
            int kilo = Convert.ToInt32(Console.ReadLine());
            double boy2 = boy / 100;
            double boy2m = boy2 * boy2;
            double vke = kilo / boy2m;
            vke = Math.Round(vke, 1);
            Console.WriteLine();
            if (vke <= 18.5)
            {
                Console.WriteLine("Vücut kitle endeksiniz : {0}\nZayıfsınız.", vke);
            }
            else if (vke > 18.5 && vke <= 24.9)
            {
                Console.WriteLine("Vücut kitle endeksiniz : {0}\nNormal ağırlıktasınız.", vke);
            }
            else if (vke > 24.9 && vke <= 29.9)
            {
                Console.WriteLine("Vücut kitle endeksiniz : {0}\nKilolusunuz.", vke);
            }
            else
            {
                Console.WriteLine("Vücut kitle endeksiniz : {0}\nObezsiniz.", vke);
            }
            Console.Read();
        }
    }
}
