using System;

namespace interfaces_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkanınAraci().ToString());
            Console.WriteLine(focus.KacTekerlektenOlusur().ToString());
            Console.WriteLine(focus.StandartRengiNe().ToString());

            Console.WriteLine("***************************");

            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkanınAraci().ToString());
            Console.WriteLine(civic.KacTekerlektenOlusur().ToString());
            Console.WriteLine(civic.StandartRengiNe().ToString());

            Console.WriteLine("***************************");

            Corolla corolla = new Corolla();
            Console.WriteLine(corolla.HangiMarkanınAraci().ToString());
            Console.WriteLine(corolla.KacTekerlektenOlusur().ToString());
            Console.WriteLine(corolla.StandartRengiNe().ToString());

            Console.WriteLine("***************************");

            NewFocus focus1 = new NewFocus();
            Console.WriteLine(focus1.HangiMarkanınAraci().ToString());
            Console.WriteLine(focus1.KacTekerlektenOlusur().ToString());
            Console.WriteLine(focus1.StandartRengiNe().ToString());

            Console.WriteLine("***************************");

            NewCivic civic1 = new NewCivic();
            Console.WriteLine(civic1.HangiMarkanınAraci().ToString());
            Console.WriteLine(civic1.KacTekerlektenOlusur().ToString());
            Console.WriteLine(civic1.StandartRengiNe().ToString());

            Console.WriteLine("***************************");

            NewCorolla corolla1 = new NewCorolla();
            Console.WriteLine(corolla1.HangiMarkanınAraci().ToString());
            Console.WriteLine(corolla1.KacTekerlektenOlusur().ToString());
            Console.WriteLine(corolla1.StandartRengiNe().ToString());
        }
    }
}
