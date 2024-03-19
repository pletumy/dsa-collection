using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_lab_binary_tree
{
    public class BinarySearchTree
    { 
        public Node Root { get; set; }

        public bool Insert(int value)
        {
            Node before = null, after = this.Root;
            while (after != null)
            {
                before = after;
                if (value < after.Data)//<=
                    after = after.LeftNode;
                else if (value > after.Data)//not if
                    after = after.RightNode;
                else//remove
                    return false;
            }
            Node newNode = new Node();
            newNode.Data = value;
            if (this.Root == null)
                this.Root = newNode;
            else
            {
                if (value < before.Data)//<=
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }
            return true;
        }
        public void TraverseInOrder(Node parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.LeftNode);
                Console.Write(parent.Data + " ");
                TraverseInOrder(parent.RightNode);
            }
        }
        public void TraversePreOrder(Node parent)
        {
            if (parent != null)
            {
                Console.Write(parent.Data + " ");
                TraversePreOrder(parent.LeftNode);
                TraversePreOrder(parent.RightNode);
            }
        }
        public void TraversePostOrder(Node parent)
        {
            if (parent != null)
            {
                TraversePostOrder(parent.LeftNode);
                TraversePostOrder(parent.RightNode);
                Console.Write(parent.Data + " ");
            }
        }
        
        //Đếm số lần xuất hiện của item
        public Dictionary<int, int> CountCharacters(Node root)
        {
            Dictionary<int, int> characterCounts = new Dictionary<int, int>();
            CountCharactersRecursive(root, characterCounts);
            return characterCounts;
        }

        private static void CountCharactersRecursive(Node node, Dictionary<int, int> characterCounts)
        {
            if (node == null)
            {
                return;
            }

            if (characterCounts.ContainsKey(node.Data))
            {
                characterCounts[node.Data]++;
            }
            else
            {
                characterCounts[node.Data] = 1;
            }

            CountCharactersRecursive(node.LeftNode, characterCounts);
            CountCharactersRecursive(node.RightNode, characterCounts);
        }

        //Đếm số cạnh
        public int CountEdges()
        {
            return CountEdgesRecursive(Root);
        }

        private int CountEdgesRecursive(Node node)
        {
            if (node == null)
            {
                return 0;
            }

            // Đệ quy để đếm số cạnh trong cây con trái và cây con phải
            int leftEdges = CountEdgesRecursive(node.LeftNode);
            int rightEdges = CountEdgesRecursive(node.RightNode);

            // Tổng số cạnh trong cây hiện tại bằng tổng số cạnh trong cây con trái, cây con phải và 1 cạnh nối từ nút hiện tại đến nút cha (2 cạnh nếu nút cha tồn tại)
            return leftEdges + rightEdges + (node.LeftNode != null ? 1 : 0) + (node.RightNode != null ? 1 : 0);
        }
    }
}
