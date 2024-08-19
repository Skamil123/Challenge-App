using Zadaniedomowedzien6;

Employee user1 = new Employee ("Adam", "Adamowicz", "20", 0);
Employee user2 = new Employee ("Adam", "Kowalski", "25", 0);
Employee user3 = new Employee ("Adam", "iEwa", "30", 0);

user1.AddScore(9);
user1.AddScore(9);
user1.AddScore(9);
user1.AddScore(9);
user1.AddScore(9);

user2.AddScore(1);
user2.AddScore(1);
user2.AddScore(1);
user2.AddScore(1);
user2.AddScore(1);

user3.AddScore(11);
user3.AddScore(1);
user3.AddScore(1);
user3.AddScore(2);
user3.AddScore(1);

List<Employee> users = new List<Employee>()
{
    user1, user2, user3
};

int maxResult = -1;
Employee userWithMaxResult = null;
foreach (var Employee in users )
{
if(Employee.Result > maxResult)
    {
        maxResult = Employee.Result;
        userWithMaxResult = Employee; 
    }
}

Console.WriteLine(userWithMaxResult.Name);
Console.WriteLine(userWithMaxResult.LastName);
Console.WriteLine("Wiek " + userWithMaxResult.Age);
Console.WriteLine(maxResult);