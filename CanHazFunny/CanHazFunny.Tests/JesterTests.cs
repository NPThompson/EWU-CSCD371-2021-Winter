using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CanHazFunny.Tests
{
    [TestClass]
    public class JesterTests
    {
     [TestMethod]
     [ExpectedException(typeof(System.ArgumentNullException))]
     public void Jester_ThrowsException_OnNullJokeService()
        {
            Jester jester = new(null!);
        }

    [TestMethod]
     public void Jester_FiltersChuckNorrisJokes()
        {
            Mock<IJokeService> testService = new();
            testService.SetupSequence(testService => testService.GetJoke())
                .Returns("chuck norris once threw a grenade. It killed fifty people, then it exploded.")
                .Returns("why do programmers celebrate halloween and christmas on the same day? Because oct 31 = dec 25!");
            Jester jester = new(testService.Object);
            string joke = jester.GetJoke();
            Assert.IsFalse(joke.Contains("chuck norris"));
        }
    }
}
