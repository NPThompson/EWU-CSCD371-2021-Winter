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
    }
}
