using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
        public void NumSet_EqualsImpliesNotUnequals()
        {
            setup();
            NumSet numSet2 = new(0, 1, 2);
            Assert.AreEqual  (numSet2 == numSet, 
                            !(numSet2 != numSet)  );
        }


        [TestMethod]
        public void NumSet_EqualsIsCommutative()
        {
            setup();
            NumSet numSet2 = new(0, 1, 2);
            Assert.AreEqual(numSet2 == numSet,
                            numSet  == numSet2);
        }


        [TestMethod]
        public void NumSet_EqualSets_AreEqual()
        {
            setup();

            NumSet numSet2 = new(5, 4, 3, 2, 1, 0);
            
            Assert.IsTrue(numSet == numSet2);
        }

        [TestMethod]
        public void NumSet_EqualSetsImpliesEqualHashCodes()
        {
            setup();
            NumSet numSet2 = new(0, 2, 5, 1, 4, 3);
            Assert.IsTrue(numSet.GetHashCode() == numSet2.GetHashCode());
        }

        [TestMethod]
        public void NumSet_ToString_IncludesAllElements()
        {
            string toString = new NumSet(3, 7, 9).ToString();
            Assert.IsTrue(toString.Contains('3'));
            Assert.IsTrue(toString.Contains('7'));
            Assert.IsTrue(toString.Contains('9'));
        }

        [TestMethod]
        public void NumSet_ElementArray_ContainsAllElements()
        {
            int[] elements = new NumSet(10, 9, 8).GetElements();
            Assert.IsTrue(Array.Exists(elements, element => element == 10));
            Assert.IsTrue(Array.Exists(elements, element => element == 9));
            Assert.IsTrue(Array.Exists(elements, element => element == 9));
        }

        [TestMethod]
        public void NumSet_ModifyingArray_DoesNotModifySet()
        {
            NumSet set1 = new(11, 13, 17);
            int[] elements = set1.GetElements();
            elements[0] = 19;
            Assert.IsFalse(set1.Contains(19));
        }
    }
}
