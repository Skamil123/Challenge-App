
using System.Runtime.CompilerServices;

namespace Zadaniedomowedzien6
{
    public class Employee

    {
        private List<int> score = new List<int>();
        public Employee(string name, string last_name, string age, int score)
        {
            this.Name = name;
            this.LastName = last_name;
            this.Age = age;
            this.Score = score;

        }
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Age { get; private set; }
        public int Score { get; private set; }
        public int Result { get { return this.score.Sum(); } }

        public void AddScore(int score)
        { this.score.Add(score); }
   

    }
}
