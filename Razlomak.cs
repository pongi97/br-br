using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Razlomak : IComparable<Razlomak>
    {
        private int brojnik, nazivnik;

        public Razlomak(int brojnik, int nazivnik)
        {
            this.brojnik = brojnik;
            this.nazivnik = nazivnik;


         }
        public void ZadajBrojnik(int brojnik)
        {
            this.brojnik = brojnik;

        }
        public void ZadajNazivnik(int nazivnik)
        {
            this.nazivnik = nazivnik;

        }
        public int VratiNazivnik()
        {
            return nazivnik;
        }
        public int VratiBrojnik()
        {
            return brojnik;

        }
        public float Pretvoriufloat()
        {
            return (float)brojnik / nazivnik;
        }
        public bool Ispravan()
        {
            return nazivnik != 0;
           /* if(nazivnik!=0)
            {
                return true;
            }
            else
            {
                return false;
            }*/
        }
        private int Nzm(int brojnik,int nazivnik)
        {
            int temp;
            while(nazivnik!=0)
            {
                temp = nazivnik;
                nazivnik = brojnik % nazivnik;
                brojnik=temp;
            }
            return brojnik;

        }
        public void SkratiRazlomak()
        {
            if(brojnik<nazivnik)
            {
                int mjera= Nzm(nazivnik, brojnik);
                brojnik = brojnik / mjera;
                nazivnik = nazivnik / mjera;
            }
            else
            {
                int mjera = Nzm(brojnik, nazivnik);
                brojnik = brojnik / mjera;
                nazivnik = nazivnik / mjera;
            }
            

            }

        public int CompareTo(Razlomak other)
        {
            //throw new NotImplementedException();
            if (Pretvoriufloat() > other.Pretvoriufloat())
            {
                return 1;
            }
            else if (Pretvoriufloat() < other.Pretvoriufloat())
            {
                return -1;
            }
            else
            return 0;
        }
    }
}
