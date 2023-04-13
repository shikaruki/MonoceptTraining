using GenericNodeApp.Model;

namespace GenericNodeApp
{
    internal class Program
    {
        [Serializable]
        static void Main(string[] args)
        {
            var nodeA = new Node<int>();
            var nodeB = new Node<int>();
            var nodeC = new Node<int>();
            var nodeD = new Node<string>();
            nodeA.Data = 10;
            nodeB.Data = 20;
            nodeC.Data = 30;
            nodeD.Data = "RAvi";
            nodeA.Next = nodeB;
            nodeB.Next = nodeC;
            nodeC.Next = nodeD;

            PrintDetails(nodeA);
        }

        private static void PrintDetails(Node<int> nodeA)
        {
            throw new NotImplementedException();
        }

        private static void PrintDetails(Node<T> nodeA)
        {
            if (nodeA == null) return;
            Console.WriteLine(nodeA.Data);
            PrintDetails(nodeA.Next);
        }
    }
}