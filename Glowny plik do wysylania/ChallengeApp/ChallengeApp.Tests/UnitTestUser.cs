using NUnit.Framework;
using ChallengeApp;

namespace ChallengeApp.Tests
{
    public class TestsUser
    {
    


            [Test]
            //public void Test1()
            public void WhenUserColletc_CheckSumOperation()
            {
                //arrage

                var user = new Employee("Adam", "123");
                user.AddGrade(5);
                user.AddGrade(5);
                user.AddGrade(5);
                user.AddGrade(5);

                //   int age1 = 10;
                //   int age2 = 2;
                //act
                var statistics = user.GetStatistics();

            //  int result = age1 + age2;
            //assert
            Assert.AreEqual(5, statistics.Average);
            //   Assert.AreEqual(12, result);
        }
        
    }
}