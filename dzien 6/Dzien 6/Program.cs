using Dzien_9;

var employee = new Employee("Kamil", "Drabik");
employee.AddGrade(2);
employee.AddGrade(2);
employee.AddGrade(2);
var statistics = employee.GetStatistics(); 
Console.Write($"Average: {statistics.Average}");
Console.Write($"Min: {statistics.Min}");
Console.Write($"Max: {statistics.Max}");
