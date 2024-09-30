namespace ChallengeApp
{

    public class Employee
    {

        private List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;

        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid Data");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                AddGrade(result);
                //var value = float.Parse(grade);
                // this.AddGrade(value);
            }
            else
            {
                Console.WriteLine("String is not float");
            }

        }
        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add((float)grade);
            }
            else
            {
                Console.WriteLine("Double is not in range");
            }

        }
        public void AddGrade(long grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add((float)grade);
            }
            else
            {
                Console.WriteLine("Long is not in range");
            }

        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;

            }
            statistics.Average = statistics.Average / this.grades.Count;
            return statistics;
        }
    }
}