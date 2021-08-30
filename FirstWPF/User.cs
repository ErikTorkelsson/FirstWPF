using System;
using System.Collections.Generic;
using System.Text;

namespace FirstWPF
{
    public class User
    {
        public string Email { get; set; }
        public string PassWord { get; set; }

        public User(string email, string password)
        {
            Email = email;
            PassWord = password;
        }
    }

    public static class MockUsers
    {
        public static List<User> users = new List<User>();

        public static void addUsers()
        {
            User erik = new User("erik.torkelsson@hotmail.com", "holla");
            User arne = new User("arne.svensson@hotmail.com", "hej");

            users.Add(erik);
            users.Add(arne);        }
        }
}
