using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlamekLib
{
    public class Ulamek
    {
        private readonly long licznik = 0;
        private readonly long mianownik = 1;

        public long Licznik => licznik;
        /*
        {
            get
            {
                return licznik;
            }
        }
        */
        public long Mianownik => mianownik;

        public Ulamek(long licznik, long mianownik )
        {
            this.licznik = licznik;
            if (mianownik == 0)
                throw new DivideByZeroException("mianownik nie może być 0");

            this.mianownik = mianownik;
        }

        public Ulamek() : this(0 ,1) { }

        public Ulamek( long liczba ) : this(liczba, 1) { }

        public Ulamek( string napis )
        {
            //to do
            throw new NotImplementedException();
        }

        public Ulamek( double )
        {
            //to do
            throw new NotImplementedException();
        }

        public override string ToString() //=> $"{licznik}/{mianownik}";
        {
            return $"{licznik}/{mianownik}";
        }

    }
}
