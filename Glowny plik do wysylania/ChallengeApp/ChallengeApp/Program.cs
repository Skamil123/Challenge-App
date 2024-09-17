
using ChallengeApp;

var employee = new Employee("Kamil", "Drabik");
employee.AddGrade("2000");
employee.AddGrade("Adam");
employee.AddGrade(2);
employee.AddGrade(6);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
//N2 dwa miejsca po przecinku
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

SetSth(out statistics);
void SetSth(out Statistics statistics)
{
    statistics = new Statistics();
}