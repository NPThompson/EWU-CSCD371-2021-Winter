using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SetLibrary.Tests
{
    [TestClass]
    public class NumSetTests
    {
        [TestMethod]
        public void NumSet_Constructor_AcceptsParamList()
        { 
           NumSet numSet = new(0, 1, 2, 3, 4, 5);
        }
    }
}
