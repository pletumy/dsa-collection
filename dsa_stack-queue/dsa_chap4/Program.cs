using System.Collections;

namespace dsa_chap4 {
    public class Program {
        public static void Main(string[] args) {
            //BLab1
            /*
            MyStack ms = new MyStack();
            //Console.WriteLine(ms.isEmpty());
            ms.push(1);
            ms.push(2);
            ms.push(3);//xóa
            ms.push(4);
            ms.push(5);
            
            Console.WriteLine(ms.isEmpty());
            Node n = ms.pop();
            Console.WriteLine(n == null ? "null" : n.data);
            n = ms.pop();
            Console.WriteLine(n == null ? "null" : n.data);
            n = ms.pop();
            Console.WriteLine(n == null ? "null" : n.data);
            n = ms.pop();
            Console.WriteLine(n == null ? "null" : n.data);
            Console.WriteLine(ms.isEmpty());
            
            
            MyStack temp = new MyStack();
            int c;
            while((c = (int)ms.pop().data) != 3) {
                temp.push(c);
            }
            do {
                ms.push(temp.pop().data);
            } while (!temp.isEmpty());
            
            */
            
            //
            Stack<int> stack = new Stack<int>();
            Queue<int> temp = new Queue<int>(); 
            int index = 4;

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);

            int x;
            while ((x = (int)stack.Pop()) != index)
            {
                temp.Enqueue(x);
            }
            while (temp.Count != 0)
            {
                stack.Push(temp.Dequeue());
            }
            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }


        }
    }
            
}

