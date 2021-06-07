using System;

namespace interfaces_example
{
    public class Civic : IOtomobil
    {
        public Marka HangiMarkanınAracı()
        {
            return Marka.Honda;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
    }
}