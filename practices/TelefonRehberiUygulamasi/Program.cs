using System;
using System.Collections.Generic;
namespace TelefonRehberiUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            int choice = int.Parse(Console.ReadLine());
            MenuChoice(choice);
        }

        public static void Menu(){
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");

            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
        }

        public static void MenuChoice(int choice){
            switch (choice)
            {
                case 1:

                    AddNumber();
                    break;

                case 2:

                    DeleteExistingNumber();
                    break;

                case 3:
                    UpdateExistingNumber();
                    break;

                case 4:
                    ListContacts();
                    break;

                case 5:
                    SearchFromContacts();
                    break;
                
                default:
                    Console.WriteLine("1,2,3,4 veya 5 girmelisiniz!");
                    break;
            }
        }

        public static void AddNumber(){


            Console.WriteLine("Lütfen isim giriniz              :");
            string isim = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz           :");
            string soyisim = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz  :");
            string numara = Console.ReadLine();

            Contact newContact = new Contact(isim, soyisim, numara);
            ContactManagement add = new ContactManagement();
            add.AddNewContact(newContact);

        }
        public static void DeleteExistingNumber(){

            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string deleted = Console.ReadLine();

            ContactManagement delete = new ContactManagement();
            delete.DeleteNumber(deleted);
        }
        public static void UpdateExistingNumber(){
             Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
             string updated = Console.ReadLine();

            ContactManagement updating = new ContactManagement();
            updating.UpdateNumber(updated);
        }
        public static void ListContacts(){

            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");

            ContactManagement list = new ContactManagement();
            list.ListContactList();

        }

        public static void SearchFromContacts(){

            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

            int choice = int.Parse(Console.ReadLine());
            ContactManagement search = new ContactManagement();
            search.searchFromContacts(choice);
        }
    }
}
