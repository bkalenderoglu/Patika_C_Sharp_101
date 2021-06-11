using System;

namespace ToDoUygulamasi{
    class Card{

        public string Title{get; set;}
        public string Content{get; set;}
        public int MemberId{get; set;}
        public Sizes Size;

        public Card(string title, string content, int memberId, Sizes size){

            Title = title;
            Content = content;
            MemberId = memberId;
            Size = size;
        }

        public Card()
        {
        }
    }
}