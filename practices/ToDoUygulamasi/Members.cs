using System;
using System.Collections;
using System.Collections.Generic;

namespace ToDoUygulamasi{
    public class Members{

        public static List<TeamMember> memberList;


        static Members()
        {
            memberList = ListMembers();

        }

        public static List<TeamMember> ListMembers()
        {
            return new List<TeamMember>()
            {
                new TeamMember(1,"Beyza"),
                new TeamMember(2,"Ali"),
                new TeamMember(3,"Ayse"),
                new TeamMember(4,"Ahmet"),
                new TeamMember(5,"Zeynep")
            };

        }

        
    }
}