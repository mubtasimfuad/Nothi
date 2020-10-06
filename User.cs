using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nothi_Next
{
    class User
    {
        //public User(string userName, string passWord, string name)
        //{
        //    UserName = userName;
        //    Password = passWord;
        //    Name = name;

        //        }
        public string UserName { get; set; }
        public string Password { get; set; }

        public  static string error = "Something is Wrong";

        public static bool IsEqual(User user1, User user2)
        {
            if(user1 ==null || user2 == null)
            {
                return false;
            }
            if(user1.UserName != user2.UserName)
            {
                error = "User Name Doesn't Exist";
            }
            else if (user1.Password != user2.Password)
            {
                error = "User Name and Password doesn't match";
            }

            return true;

        }
        ////public string Name { get; set; }

    }
}
