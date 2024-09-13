

using Dzien_6;
using System.Runtime.Intrinsics.X86;

namespace TestProject1.dzien_7
{
    public class TypeTests
    {
        [Test]
        //public void Test1()
        public void TestWartosciowyDlaNumberCzyNieSaRowne()
        {
            //arrage
            int number1 = 1;
            int number2 = 2;

            //   int age1 = 10;
            //   int age2 = 2;
            //act


            //  int result = age1 + age2;
            //assert
            Assert.AreNotEqual(number1, number2);
            //   Assert.AreEqual(12, result);
        }
        private User GetUser(string name)
        {

            return new User(name);
        }
        [Test]
        //public void Test1()
        public void TestReferencyjnyDlaUserCzyNieSaRowne()
        {
            //arrage
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");

            //   int age1 = 10;
            //   int age2 = 2;
            //act


            //  int result = age1 + age2;
            //assert
            Assert.AreNotEqual(user1, user2);
            
            //   Assert.AreEqual(12, result);
        }
        [Test]
        public void TestReferencyjnyDlaUserStringLoginCzySaRowne()
        {
            //arrage
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");

            //   int age1 = 10;
            //   int age2 = 2;
            //act


            //  int result = age1 + age2;
            //assert
            Assert.AreEqual(user1.Login, user2.Login);
            //   Assert.AreEqual(12, result);
        }
    }      
}
