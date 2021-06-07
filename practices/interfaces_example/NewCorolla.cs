using System;

namespace interfaces_example
{
    public class NewCorolla : Otomobil
    {
        public override Marka HangiMarkanınAraci()
        {
            return Marka.Toyota;
        }
    }
}