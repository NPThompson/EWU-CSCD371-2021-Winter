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
            Jester jester = new(testService.Object);

            Assert.Fail("Test service should send chuck norris jokes first, then regular ones");
        }
    }
}
