using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31211022442_PhanLeTuMy
{
    public class Node
    {
        public Node next;
        public WebBrowser data;
    }
 
    public class WebBrowserHistory
    {
            Node top;

            public bool isEmpty()
            {
                return top == null;
            }
            public void push(WebBrowser ele)
            {
                Node n = new Node();
                n.data = ele;
                n.next = top;
                top = n;
            }
            public WebBrowser pop()
            {
                if (top == null)
                {
                    return null;
                }
                Node d = top;
                top = top.next;
                return d.data;
            }
        public List<WebBrowser> ConvertStackToList(WebBrowserHistory stack)
        {
            List<WebBrowser> browserList = new List<WebBrowser>();

            Node current = stack.top;

            while (current != null)
            {
                // Ép kiểu dữ liệu của node thành kiểu WebBrowser và thêm vào danh sách
                WebBrowser browser = (WebBrowser)current.data;
                browserList.Add(browser);

                // Di chuyển tới node kế tiếp trong stack
                current = current.next;
            }

            return browserList;
        }
    }
}
