using System;
using System.Collections;
namespace TelefonRehberiUygulamasi
{
    class Contact
    {
        public string İsim { get; set; }
        public string Soyisim { get; set; }
        public string Numara { get; set; }

        public Contact(string isim, string soyisim, string numara)
        {
            this.İsim = isim;
            this.Soyisim = soyisim;
            this.Numara = numara;
        }
    }
}