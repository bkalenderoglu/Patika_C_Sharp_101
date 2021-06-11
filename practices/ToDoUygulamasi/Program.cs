using System;

namespace ToDoUygulamasi
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

            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
        }
        public static void MenuChoice(int choice){
            switch (choice)
            {
                case 1:

                    ListBoard();
                    break;

                case 2:

                    AddCard();
                    break;

                case 3:
                    DeleteCard();
                    break;

                case 4:
                    MoveCard();
                    break;

                default:
                    Console.WriteLine("1,2,3 veya 4 girmelisiniz!");
                    break;
            }
        }

        public static void ListBoard()
        {
            Console.WriteLine("TODO Line");
            Console.WriteLine("************************");

            foreach (var cards in Cards.TODO)
            {
                Console.WriteLine("Başlık: {0}", cards.Title);
                Console.WriteLine("İçerik: {0}", cards.Content);
                Console.WriteLine("Atanan Kişi: {0}", cards.MemberId);
                Console.WriteLine("Büyüklük: {0}", cards.Size);
                Console.WriteLine("-");
            }
            Console.WriteLine("PROGRESS Line");
            Console.WriteLine("************************");
            foreach (var cards in Cards.PROGRESS)
            {
                Console.WriteLine("Başlık: {0}", cards.Title);
                Console.WriteLine("İçerik: {0}", cards.Content);
                Console.WriteLine("Atanan Kişi: {0}", cards.MemberId);
                Console.WriteLine("Büyüklük: {0}", cards.Size);
                Console.WriteLine("-");
            }
            Console.WriteLine("DONE Line");
            Console.WriteLine("************************");
            foreach (var cards in Cards.DONE)
            {
                Console.WriteLine("Başlık: {0}", cards.Title);
                Console.WriteLine("İçerik: {0}", cards.Content);
                Console.WriteLine("Atanan Kişi: {0}", cards.MemberId);
                Console.WriteLine("Büyüklük: {0}", cards.Size);
                Console.WriteLine("-");
            }
        }
        public static void AddCard(){

            Card card = new Card();

            Console.WriteLine("Başlık Giriniz                                  :");
            card.Title = Console.ReadLine();
            Console.WriteLine("İçerik Giriniz                                  :");
            card.Content = Console.ReadLine();
            Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
            int size = int.Parse(Console.ReadLine());
            if (size == 1)
            {
                card.Size = Sizes.XS;
            }
            if (size == 2)
            {
                card.Size = Sizes.S;
            }
            if (size == 3)
            {
                card.Size = Sizes.M;
            }
            if (size == 4)
            {
                card.Size = Sizes.L;
            }
            if (size == 5)
            {
                card.Size = Sizes.XL;
            }
            Console.WriteLine("Kişi Seçiniz                                    :");
            int id = int.Parse(Console.ReadLine());
            foreach(var member in Members.memberList ){
                if(member.Id == id)
                    card.MemberId = id;
      
            }
            if(card.MemberId!=0){
            Console.WriteLine("Hangi board'a eklemek istiyorsunuz? -> ToDo (1), Progress (2), Done (3) :");
            int board = int.Parse(Console.ReadLine());
            if (board == 1)
                Cards.TODO.Add(card);

            else if (board == 2)
              Cards.PROGRESS.Add(card);

            else if (board == 3)
                Cards.DONE.Add(card);

            else
                Console.WriteLine("Hatalı giriş yaptınız");
            }
            else{
                System.Console.WriteLine("Bu kullanıcı bulunamadı;");
            Menu();
            int choice = int.Parse(Console.ReadLine());
            MenuChoice(choice);
            }  
        }
        public static void DeleteCard(){

            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:");
            string title = Console.ReadLine();
            int counter = 0;
            for (int i = 0; i < Cards.TODO.Count; i++)
            {
                if (Cards.TODO[i].Title.ToLower() == title.ToLower())
                {
                    Cards.TODO.RemoveAt(i);
                    Console.WriteLine("Silme işlemi başarıyla tamamlandı.");
                    Main(null);
                    counter++;
                }
            }
            for (int i = 0; i < Cards.PROGRESS.Count; i++)
            {
                if (Cards.PROGRESS[i].Title.ToLower() == title.ToLower())
                {
                    Cards.PROGRESS.RemoveAt(i);
                    Console.WriteLine("Silme işlemi başarıyla tamamlandı.");
                    Main(null);
                    counter++;
                }
            
            }
            for (int i = 0; i < Cards.DONE.Count; i++)
            {
                if (Cards.DONE[i].Title.ToLower()== title.ToLower())
                {
                    Cards.DONE.RemoveAt(i);
                    Console.WriteLine("Silme işlemi başarıyla tamamlandı.");
                    Main(null);
                    counter++;
                }
            }
            if(counter==0){
                Console.WriteLine("Aradığınız krititerlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2))");
                int choice = int.Parse(Console.ReadLine());
                if(choice == 1)     
                    Main(null);
                    
                else
                     DeleteCard();

            }

        }

        public static void MoveCard(){

            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız: ");
            string title = Console.ReadLine();

            foreach (var card in Cards.TODO)
            {
                if(card.Title.ToLower()== title.ToLower()){
                    Console.WriteLine("Bulunan Kart Bilgileri:");
                    Console.WriteLine("**************************************");
                    Console.WriteLine("Başlık : " + card.Title);
                    Console.WriteLine("İçerik : " + card.Content);
                    Console.WriteLine("Atanan Kişi : "+ card.MemberId);
                    Console.WriteLine("Büyüklük: " + card.Size);
                    Console.WriteLine("Line: ToDo");
                    Console.WriteLine();
                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz.");
                    Console.WriteLine("(1) ToDo");
                    Console.WriteLine("(2) Progess");
                    Console.WriteLine("(3) Done");
                    int option = Convert.ToInt32(Console.ReadLine());
                    if(option == 2)
                    {
                        Cards.PROGRESS.Add(card);
                        Cards.TODO.Remove(card);
                        Console.WriteLine("İşlem başarıyla gerçekleştirildi");
                        ListBoard();
                    }
                    if(option == 3)
                    {
                        Cards.DONE.Add(card);
                        Cards.TODO.Remove(card);
                        Console.WriteLine("İşlem başarıyla gerçekleştirildi");
                        ListBoard();;
                    }
                    else
                    {
                        MoveCard();
                    }
                }
            }
            foreach(var card in Cards.PROGRESS)
            {
                if(card.Title.ToLower()== title.ToLower()){
                    Console.WriteLine("Bulunan Kart Bilgileri:");
                    Console.WriteLine("**************************************");
                    Console.WriteLine("Başlık : " + card.Title);
                    Console.WriteLine("İçerik : " + card.Content);
                    Console.WriteLine("Atanan Kişi : "+ card.MemberId);
                    Console.WriteLine("Büyüklük: " + card.Size);
                    Console.WriteLine("Line: PROGRESS");
                    Console.WriteLine();
                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz.");
                    Console.WriteLine("(1) ToDo");
                    Console.WriteLine("(2) Progess");
                    Console.WriteLine("(3) Done");
                    int option = Convert.ToInt32(Console.ReadLine());
                    if(option == 1)
                    {
                        Cards.TODO.Add(card);
                        Cards.PROGRESS.Remove(card);
                        Console.WriteLine("İşlem başarıyla gerçekleştirildi");
                        Console.ReadKey();
                        ListBoard();
                    }
                    if(option == 3)
                    {
                        Cards.DONE.Add(card);
                        Cards.PROGRESS.Remove(card);
                        Console.WriteLine("İşlem başarıyla gerçekleştirildi");
                        ListBoard();;
                    }
                    else
                    {
                        MoveCard();
                    }
                } 
                
            }
            foreach (var card in Cards.DONE)
            {
                if(card.Title.ToLower()== title.ToLower()){
                    Console.WriteLine("Bulunan Kart Bilgileri:");
                    Console.WriteLine("**************************************");
                    Console.WriteLine("Başlık : " + card.Title);
                    Console.WriteLine("İçerik : " + card.Content);
                    Console.WriteLine("Atanan Kişi : "+ card.MemberId);
                    Console.WriteLine("Büyüklük: " + card.Size);
                    Console.WriteLine("Line: DONE");
                    Console.WriteLine();
                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz.");
                    Console.WriteLine("(1) ToDo");
                    Console.WriteLine("(2) Progess");
                    Console.WriteLine("(3) Done");
                    int option = Convert.ToInt32(Console.ReadLine());
                    if(option == 1)
                    {
                        Cards.TODO.Add(card);
                        Cards.DONE.Remove(card);
                        Console.WriteLine("İşlem başarıyla gerçekleştirildi");
                        ListBoard();
                    }
                    if(option == 2)
                    {
                        Cards.PROGRESS.Add(card);
                        Cards.DONE.Remove(card);
                        Console.WriteLine("İşlem başarıyla gerçekleştirildi");
                        ListBoard();
                    }
                    else
                    {
                        MoveCard();
                    }
                }
            }
        }        
    }   
}

