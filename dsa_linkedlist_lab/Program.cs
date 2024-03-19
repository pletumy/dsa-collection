using System.Xml.Linq;

namespace dsa_lab_chap6
{
    internal class Program
    {
        public class Node
        {
            public object element;//data
            public Node link;//liên kết
            public Node()
            {
                this.element = null;
                this.link = null;
            }
            public Node(object element)
            {
                this.element = element;
                this.link = null;
            }
        }
        public class LinkedList
        {
            public Node header;//Nút đầu
            public LinkedList()
            {
                header = new Node("header");
            }
            public Node Find(object ele)
            {
                Node current = header;
                while (!current.element.Equals(ele) && current.link != null)
                    current = current.link;
                return current;
            }
            public void Insert(object newele, object after)
            {
                Node current = Find(after);
                Node newNode = new Node(newele);
                newNode.link = current.link;
                current.link = newNode;
            }
            public Node FindPrev(object ele)
            {
                Node current = header;
                while (!current.link.element.Equals(ele) && current.link != null)
                    current = current.link;
                return current;
            }
            public void Remove(object ele)
            {
                Node current = FindPrev(ele);
                if (current.link != null)
                    current.link = current.link.link;
            }
            public void Swap(object o1, object o2)
            {
                object n1 = FindPrev(o1).element;
                object n2 = FindPrev(o2).element;
                Remove(o1);
                Remove(o2);
                Insert(o1, n2);
                Insert(o2, n1);
            }
            public void Sort()
            {
            Begin:
                Node current = header.link;
                while (current.link != null)
                {
                    Node current2 = current.link;
                    while (current2 != null)
                    {
                        if ((int)current.element > (int)current2.element)
                        {
                            Swap(current2.element, current.element);
                            goto Begin;
                        }
                        current2 = current2.link;
                    }
                    current = current.link;
                }
            }
            public void AddLast(object o1)
            {
                Node current = header;
                while (current.link != null)
                {
                    current = current.link;
                }
                current.link = new Node(o1);

            }
            public void InsertBefore(object o1, object before)
            {
                Node current = FindPrev(before);
                Node newNode = new Node(o1);
                newNode.link = current.link;
                current.link = newNode;
            }
         
        }
        class Book
        {
            public string title, author;
            public long price;
            public Book(string title, string author, long price)
            {
                this.title = title;
                this.author = author;
                this.price = price;
            }
            override public string ToString()
            {
                return $"[Book: {title}, {author}, {price}]";
            }
        }
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Book b1 = new Book("Gone with the Wind",
                           "Margaret Mitchell",
                           100000);
            Book b2 = new Book("Kieu's Story",
                           "Nguyen Du",
                           120000);
            Book b3 = new Book("Doraemon",
                           "Fujiko F Fujio",
                           190000);
            list.Insert(b1, "Header");
            list.Insert(b2, b1);
            list.Insert(b3, b2);
            ;
            Book b4 = new Book("Beautiful Disaster",
                           "Jamie McGuire",
                           190000);
            list.InsertBefore(b4, b1);
            ;
            list.Swap(b4, b1);
            ;
            list.Remove(b2);
            ;
        }  
    }
}