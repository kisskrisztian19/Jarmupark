using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmupark
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------Lada----------------");
            Auto lada = new Auto("piros", "Lada2112", 11);

            lada.Allapot();

            lada.Tankol(20);

            Console.WriteLine("Mennyit megy a Lada: ");
            int km = int.Parse(Console.ReadLine());

            lada.Megy(km);

            lada.Allapot();

            Console.WriteLine("-----------------Trabant----------------");

            Auto trabant = new Auto("zöld", "Trabant 1.1", 8);

            trabant.Allapot();

            trabant.Tankol(20);

            Console.WriteLine("Mennyit megy a Trabant: ");
            int km1 = int.Parse(Console.ReadLine());

            trabant.Megy(km1);

            trabant.Allapot();

            Console.ReadKey();
        }
    }
}
