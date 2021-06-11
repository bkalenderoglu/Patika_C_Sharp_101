using System;

namespace ToDoUygulamasi{
    public class TeamMember{

        public int Id{get; set;}
        public string Fullname{get; set;}

        public TeamMember(int id, string fullname){

            Id = id;
            Fullname = fullname;
           
        }
     
    }
}