using System.Text;

namespace dsa_lab_binary_tree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
           //BAI 1
           BinarySearchTree tree = new BinarySearchTree();  
           Random rd = new Random(); 
           int[] arr = new int[10000];

            for (int i = 0; i < 10000; i++)
            {
                arr[i] = rd.Next(0, 10);
            }
            foreach (int i in arr)
            {
                tree.Insert(arr[i]);
            }
            tree.TraversePreOrder(tree.Root);

            Console.WriteLine();
            Dictionary<int, int> dict = tree.CountCharacters(tree.Root);
            foreach (var item in dict) {
                Console.WriteLine(item);
            }

            //BAI 2
            Console.WriteLine("Số cạnh của cây nhị phân: " + tree.CountEdges()) ;   
           
        }
    }
}