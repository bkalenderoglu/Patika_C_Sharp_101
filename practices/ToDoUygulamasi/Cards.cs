using System;
using System.Collections;
using System.Collections.Generic;

namespace ToDoUygulamasi{
    class Cards{

        public static List<Card> TODO = new List<Card>();
        public static List<Card> PROGRESS = new List<Card>();
        public static List<Card> DONE = new List<Card>();
    

        static Cards(){
            TODO = ListTodoCards();
            PROGRESS = ListProgressCards();
            DONE = ListDoneCards();
        }

        public static List<Card> ListTodoCards(){
            return new List<Card>()
            {
                new Card("Deneme1","exam",2,Sizes.S)
            };
        }
        public static List<Card> ListProgressCards(){
            return new List<Card>()
            {
                new Card("Deneme2","exam",3,Sizes.M)

            };
        }

        public static List<Card> ListDoneCards(){
            return new List<Card>()
            {
                new Card("Deneme3","exam",4,Sizes.XL)

            };
        }
    }
}