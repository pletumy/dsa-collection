using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_chap4
{
    public class Node {
        public Node next;
        public object data;
    }
    public class MyStack
    {
        Node top;

        public bool isEmpty() { 
            return top == null; 
        }
        public void push(object ele)
        {
            Node n = new Node();
            n.data = ele;
            n.next = top;
            top = n;    
        }
        public Node pop() { 
            if (top == null)
            {
                return null;
            }
            Node d = top;
            top = top.next;
            return d;   
        }
    }
}
