using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SetLibrary.Tests
{
    [TestClass]
    public class NumSetTests
    {
        NumSet numSet = new();
     
        void setup()
        {
            numSet = new(0, 1, 2, 3, 4, 5);
        }

        [TestMethod]
        public void NumSet_Constructor_AcceptsParamList()
        {
            setup();
        }

        [TestMethod]
        public void NumSet_Contains_ShowsContainedElement()
        {
            setup();

            Assert.IsTrue(numSet.Contains(0));
        }

        [TestMethod]
        public void NumSet_Contains_DoesNotShowMissingElement()
        {
            setup();

            Assert.IsFalse(numSet.Contains(6));
        }

        [TestMethod]
        public void NumSet_AreUnequalToNullOrOtherTypes()
        {
            Assert.IsFalse(new NumSet() == null);
            Assert.IsFalse(null == new NumSet());
            Assert.IsFalse(new NumSet().Equals(42));
        }

        [TestMethod]
        public void NumSet_EqualSets_AreEqualUnderDoubleEqualsOperator()
        {
            setup();

            NumSet numSet2 = new(5, 4, 3, 2, 1, 0);
            
            Assert.IsTrue(numSet == numSet2);
        }
    }
}
