using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Razlomak r1 = new Razlomak(2, 5);

            Razlomak r2 = new Razlomak(4, 0);

            Console.WriteLine("Razlomak 1  {0} / {1} = {2}, razlomak ispravan: {3}", r1.VratiBrojnik(), r1.VratiNazivnik(), r1.Pretvoriufloat(), r1.Ispravan());

            Console.WriteLine("Razlomak 2  {0} / {1} = {2}, razlomak ispravan: {3}", r2.VratiBrojnik(), r2.VratiNazivnik(), r2.Pretvoriufloat(), r2.Ispravan());

            Razlomak r3 = new Razlomak(12, 16);
            r3.SkratiRazlomak();
            Console.WriteLine("Razlomak 3  {0} / {1} = {2}, razlomak ispravan: {3}", r3.VratiBrojnik(), r3.VratiNazivnik(), r3.Pretvoriufloat(), r3.Ispravan());

            List<Razlomak> razlomci = new  List<Razlomak>();
            razlomci.Add(r1);
            razlomci.Add(r2);
            razlomci.Add(r3);
            razlomci.Sort();
            //ispis po velicini
            Console.Write("Ispis po velicini: ");

            foreach (Razlomak r in razlomci)
                Console.Write(r.Pretvoriufloat() + ", ");
        }

    }
    
}
