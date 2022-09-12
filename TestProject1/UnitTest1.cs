using WebApplication5.Services;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            SomeService someService = new SomeService();

            string result = someService.SomeMethod();

            Assert.That(result, Is.EqualTo("lol"));
        }
    }
}