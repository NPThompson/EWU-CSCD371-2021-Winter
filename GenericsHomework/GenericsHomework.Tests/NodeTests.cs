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
         
            Assert.AreNotEqual<int>(node0.Next.data, node1.Next.data);
        }

        [TestMethod]
        public void Node_IsCircular()
        {
            Node<int> node0 = new(0);
            
            node0.Insert(new(1));
            node0.Insert(new(2));

            Assert.AreNotEqual<Node<int>>(node0.Next, node0);
            Assert.AreNotEqual<Node<int>>(node0.Next.Next, node0);
            Assert.AreEqual<Node<int>>(node0.Next.Next.Next, node0);
        }

        // see Node.cs for comment
        [TestMethod]
        public void Node_Clear_RemovesAllOtherNodes()
        {
            Node<int> node0 = new(0);
            node0.Insert(new(1));
            node0.Insert(new(2));
            node0.Insert(new(3));

            node0.Clear();
            Assert.AreEqual<Node<int>>(node0, node0.Next);
        }
    }
}
