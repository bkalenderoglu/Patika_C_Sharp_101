using System;

namespace Inheritance
{
    public class Bitkiler:Canlilar
    {
        
        protected void FotosentezYapmak(){
            Console.WriteLine("Bitkiler fotosentez yapar");
        }
    }

    public class TohumluBitkiler:Bitkiler{

        public TohumluBitkiler()
        {
            //base ile kalıtım aldığım üst sınıfların metoduna erişebilirim.
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }

        public void TohumlaCogalma(){
            Console.WriteLine("Tohumlu bitkiler tohumla çoğalır");
        }
    }

    public class TohumsuzBitkiler:Bitkiler{

        public TohumsuzBitkiler()
        {
            //base ile kalıtım aldığım üst sınıfların metoduna erişebilirim.
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }

        public void SporlaCogalma(){
            Console.WriteLine("Tohumsuz bitkiler sporla çoğalır");
        }
    }
}