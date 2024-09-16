using ChallengeApp;
namespace ChallengeApp.Tests
{

    public class EmplyeeTests
        {
            [Test]
           
            public void Sprawdzanie_MAX()
            {

            var employee1 = new Employee("Jan", "Kowalski");

      
            employee1.AddGrade(1);
            employee1.AddGrade(2);
            employee1.AddGrade(3);
            employee1.AddGrade(4);

            var statistics = employee1.GetStatistics();  
    
            Assert.AreEqual(4, statistics.Max);
     
            }

        [Test]

        public void Sprawdzanie_MIN()
        {

            var employee2 = new Employee("Ewa", "Kowalska");


            employee2.AddGrade(1);
            employee2.AddGrade(2);
            employee2.AddGrade(3);
            employee2.AddGrade(4);

            var statistics = employee2.GetStatistics();

            Assert.AreEqual(1, statistics.Min);

        }
        [Test]

        public void Sprawdzanie_Average()
        {

            var employee3 = new Employee("Jan", "Jeziorski");


            employee3.AddGrade(1);
            employee3.AddGrade(2);
            employee3.AddGrade(3);
            employee3.AddGrade(4);

            var statistics = employee3.GetStatistics();

            Assert.AreEqual(2.5, statistics.Average);

        }
                    
        }
    }

