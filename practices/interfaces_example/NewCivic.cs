using System;

namespace interfaces_example
{
    public class NewCivic : Otomobil
    {
        public override Marka HangiMarkan─▒nAraci()
        {
            return Marka.Honda;
        }

        public override Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
    }
}