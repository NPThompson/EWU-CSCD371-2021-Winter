using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericsHomework.Tests
{
    [TestClass]
    public class NodeTests
    {
        [TestMethod]
        public void Node_ConstructorIsGeneric()
        {
            Node<int> intNode = new(10);
        }
    }
}
