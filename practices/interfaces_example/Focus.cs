using System;

namespace interfaces_example
{
    public class Focus : IOtomobil
    {
        public Marka HangiMarkan─▒nAraci()
        {
            return Marka.Ford;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }
    }
}