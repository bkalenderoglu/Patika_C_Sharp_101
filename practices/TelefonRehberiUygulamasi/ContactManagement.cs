using System;

namespace TelefonRehberiUygulamasi
{
    class ContactManagement
    {
       public void AddNewContact(Contact contact)
        {
            Contacts.contactList.Add(contact);
            Console.WriteLine("Yeni numara kaydedildi...");
            //checking wheter its added or not with listing
            Program.Menu();
            int choi = int.Parse(Console.ReadLine());
            Program.MenuChoice(choi);
            
        }

        public void DeleteNumber(string contactName)
        {
            Console.WriteLine();
            int count = 0;
            foreach (var contact in Contacts.contactList)
            {
                if (contactName.ToLower().Equals(contact.Soyisim.ToLower()) || contactName.ToLower().Equals(contact.İsim.ToLower()))
                {
                    count++;
                    Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", contactName);
                    string option = Console.ReadLine();
                    if (option.ToLower() == "y" || option.ToUpper() == "Y")
                    {
                        Contacts.contactList.Remove(contact);
                        Console.WriteLine("Kişi kayıtlarınızdan silindi");
                        break;
                    }
                    else if (option.ToLower() == "n" || option.ToUpper() == "N")
                    {
                        Program.Menu();
                        break;
                    }

                }
                if (count == 0)
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için      : (2)");

                    int option = int.Parse(Console.ReadLine());

                    if (option == 2)
                    {
                        Program.DeleteExistingNumber();
                    }
                }
            }
            //checking wheter its deleted or not with listing
            Program.Menu();
            int choi = int.Parse(Console.ReadLine());
            Program.MenuChoice(choi);
        }
        public void UpdateNumber(string contactName)
        {
            Console.WriteLine();
            int count = 0;
            foreach (var contact in Contacts.contactList)
            {
                if (contactName.ToLower().Equals(contact.Soyisim.ToLower()) || contactName.ToLower().Equals(contact.İsim.ToLower()))

                {
                    count++;
                    Console.WriteLine("Lütfen yeni telefon numarasını giriniz: ");
                    string updated = Console.ReadLine();
                    contact.Numara = updated;
                    break;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
                Console.WriteLine("* Güncellemeyi sonlandırmak için    : (1)");
                Console.WriteLine("* Yeniden denemek için              : (2)");
                int option = int.Parse(Console.ReadLine());
                if (option == 2)
                {
                    Program.UpdateExistingNumber();
                }
            }

            //checking wheter its updated or not with listing
            Program.Menu();
            int choi = int.Parse(Console.ReadLine());
            Program.MenuChoice(choi);
        }
        public void ListContactList()
        {
            Console.WriteLine();

            foreach (var contact in Contacts.contactList)
            {
                Console.WriteLine("İsim: {0}", contact.İsim);
                Console.WriteLine("Soyisim: {0}", contact.Soyisim);
                Console.WriteLine("Telefon Numarası: {0}", contact.Numara);
                Console.WriteLine("-");
            }
        }
        public void searchFromContacts(int choice)
        {
            Console.WriteLine();
            if (choice == 1)
            {
                Console.WriteLine("Arama yapmak istediğiniz kişinin ismini ya da soyismini giriniz:");
                string contactName = Console.ReadLine();

                Console.WriteLine("Arama Sonuçlarınız:");
                Console.WriteLine("**********************************************");

                foreach (var contact in Contacts.contactList)
                {
                    if (contactName.ToLower().Equals(contact.İsim.ToLower()) || contactName.ToLower().Equals(contact.Soyisim.ToLower()))
                    {
                        Console.WriteLine("İsim: {0}", contact.İsim);
                        Console.WriteLine("Soyisim: {0}", contact.Soyisim);
                        Console.WriteLine("Numara: {0}", contact.Numara);
                    }
                }

            }

            else if (choice == 2)
            {
                Console.WriteLine("Arama yapmak istediğiniz kişinin numarasını giriniz:");
                string contactNo = Console.ReadLine();

                Console.WriteLine("Arama Sonuçlarınız:");
                Console.WriteLine("**********************************************");
                
                foreach (var contact in Contacts.contactList)
                {
                    if (contact.Numara == contactNo)
                    {
                        Console.WriteLine("İsim: {0}", contact.İsim);
                        Console.WriteLine("Soyisim: {0}", contact.Soyisim);
                        Console.WriteLine("Numara: {0}", contact.Numara);
                    }
                }
            }
            //checking 
            Program.Menu();
            int choi = int.Parse(Console.ReadLine());
            Program.MenuChoice(choi);
        }
    }
}
