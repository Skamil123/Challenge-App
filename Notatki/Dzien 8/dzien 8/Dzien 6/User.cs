﻿

namespace Dzien_9
{
    public class User
    {
        public static string GameName = "Diablo";
        private List<int> score = new List<int>();
        private string password;
        // private string name;

        public User(string login)
        {
            this.Login = login;
        }
        public User(string login, string password)
        {
            this.Login = login;
            this.Password = password;


        }
        public string Login { get; private set; }
        public string Password { get; private set; }
        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }


        public void AddScore(int number)
        {
            this.score.Add(number);
            //this.score += number to to samo
        }
    }
}
