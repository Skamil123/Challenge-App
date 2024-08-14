using Dzien_6;
using System.ComponentModel;
using System.Threading.Tasks.Sources;

User user1 = new User("Adam", "1234");
User user2 = new User("Monika", "12345");
User user3 = new User("Zuzia", "5432");
User user4 = new User("Damian", "2589");



//var name = user1.Login;

user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
Console.WriteLine(result);
var name = User.GameName;
