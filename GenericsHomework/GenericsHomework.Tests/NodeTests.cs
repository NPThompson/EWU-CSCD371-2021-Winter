using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericsHomework.Tests
{
    [TestClass]
    public class NodeTests
    {
        private (Node<int>,Node<string>) makeNodes()
        {
            return (new Node<int>(10), new Node<string>("Miracle Max"));
        }

        [TestMethod]
        public void Node_ConstructorIsGeneric()
        {
            var (intNode, stringNode) = makeNodes();
        }

        [TestMethod]
        public void Node_ToStringWorks()
        {
            var (intNode, stringNode) = makeNodes();

            Assert.AreEqual<string>(intNode.ToString(), "10");
            Assert.AreEqual<string>(stringNode.ToString(), "Miracle Max");
        }

        [TestMethod]
       public void Node_Insert_AltersNode()
        {
            Node<int> node0 = new(0);
            Node<int> node1 = new(1);

            node0.Insert(node1);
            node1.Insert(node0);

            Assert.AreNotEqual<int>(node0.Next.data, node1.Next.data);
        }
    }
}
