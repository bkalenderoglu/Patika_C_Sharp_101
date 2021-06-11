using System;
using System.Collections;
using System.Collections.Generic;


namespace TelefonRehberiUygulamasi
{
    class Contacts
    {
        public static List<Contact> contactList;


        static Contacts()
        {
            contactList = ListContacts();

        }

        public static List<Contact> ListContacts()
        {
            return new List<Contact>()
            {
                new Contact("Beyza", "Kalenderoglu" ,"0000 000 00 00"),
                new Contact("Ali", "Veli", "0111 111 11 11"),
                new Contact("Ayse", "Fatma", "0222 222 22 22"),
                new Contact("Ahmet", "Mehmet", "0333 333 33 33"),
                new Contact("Zeynep", "Yılmaz", "0444 444 44 44")
            };

        }


    }
}