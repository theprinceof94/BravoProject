using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BravoProject.Models
{
    public class User:ApplicationUser
    {
        [Key]
        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser ApplicationUser { get; set; }

        public User(string fullname,string email): base(fullname, email)
        {

        }

        public User()
        {
        }

        public static List<User> PopulateUsers()
        {
            List<User> userList = new List<User>();

            User user = new User("Liv Sartoris","liv@test.com");
            user.UserID = user.Id;
            userList.Add(user);

            user = new User("Erick Williams","erick@test.com");
            user.UserID = user.Id;
            userList.Add(user);

            user = new User("Cam Morris","cam@test.com");
            user.UserID = user.Id;
            userList.Add(user);

            user = new User("Jacob Spitale","jake@test.com");
            user.UserID = user.Id;
            userList.Add(user);

            return userList;
        }

    }
}