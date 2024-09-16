namespace ChallengeApp.Tests
{
    public class Tests
    {
    


            [Test]
            //public void Test1()
            public void WhenUserColletc_CheckSumOperation()
            {
                //arrage

                var user = new Employee("Adam", "123");
                user.AddScore(5);
                user.AddScore(6);
                user.AddScore(-10);
                user.AddScore(-6);

                //   int age1 = 10;
                //   int age2 = 2;
                //act
                var result = user.Result;

                //  int result = age1 + age2;
                //assert
                Assert.AreEqual(-5, result);
                //   Assert.AreEqual(12, result);
            }
        
    }
}