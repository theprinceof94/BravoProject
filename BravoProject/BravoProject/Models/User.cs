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

        public User(string fullname): base(fullname)
        {

        }

        public User()
        {
        }

        public static List<User> PopulateUsers()
        {
            List<User> userList = new List<User>();

            User user = new User("Liv Sartoris");
            user.UserID = user.Id;
            userList.Add(user);

            user = new User("Erick Williams");
            user.UserID = user.Id;
            userList.Add(user);

            user = new User("Cam Morris");
            user.UserID = user.Id;
            userList.Add(user);

            user = new User("Jacob Spitale");
            user.UserID = user.Id;
            userList.Add(user);

            return userList;
        }

    }
}