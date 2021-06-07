using System;

namespace interfaces_example
{
    public class NewFocus : Otomobil
    {
        public override Marka HangiMarkanınAraci()
        {
            return Marka.Ford;
        }
    }
}