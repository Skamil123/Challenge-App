
namespace Dzien_9
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
            this.grades.Add(grade);
        }
        public Statistics GetStatistics()
        {
            var Statiscics = new Statistics();
            //
            return Statiscics;
        }
    }
}
