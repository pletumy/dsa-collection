using System.Text;
using System.Xml;

namespace _31211022442_PhanLeTuMy
{

    public class Program
    {
        //sort trên list
        public static void Swap(WebBrowser a, WebBrowser b)
        {
            WebBrowser temp = new WebBrowser(a.title, a.last_visited, a.url); ;
            a.title = b.title; a.last_visited = b.last_visited; a.url = b.url;
            b.title = temp.title; b.last_visited = temp.last_visited; b.url = temp.url;
        }

        public static void ExchangeSort(List<WebBrowser> browserList)
        {
            int n = browserList.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (browserList[j].last_visited.CompareTo(browserList[i].last_visited) > 0)
                    {
                        Swap(browserList[i], browserList[j]);
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Tạo Datetime
            DateTime d1 = new DateTime(2020, 1, 21, 11, 22, 1);
            DateTime d2 = new DateTime(2022, 1, 21, 11, 22, 1);
            DateTime d3 = new DateTime(2021, 1, 21, 11, 22, 1);
            DateTime d4 = new DateTime(2024, 1, 21, 11, 22, 1);
            DateTime d5 = new DateTime(2023, 1, 21, 11, 22, 1);

            //Node
            WebBrowser wb1 = new WebBrowser("Đồ gia dụng | Máy lạnh | Máy giặt", d1, "https://www.dienmayxanh.com/");
            WebBrowser wb2 = new WebBrowser("Con Cưng", d2, "https://concung.com/");
            WebBrowser wb3 = new WebBrowser("GS25 - Trang chủ GS 25 Việt Nam", d3, "https://gs25.com.vn/");
            WebBrowser wb4 = new WebBrowser("Vincom - Hệ Thống Trung Tâm Thương Mại", d4, "https://vincom.com.vn/");
            WebBrowser wb5 = new WebBrowser("Tập đoàn Novaland – Wikipedia tiếng Việt", d5, "https://www.novaland.com.vn/");

            //Thêm vào Stack
            WebBrowserHistory stackWeb = new WebBrowserHistory();
            stackWeb.push(wb1);
            stackWeb.push(wb2);
            stackWeb.push(wb3);
            stackWeb.push(wb4);
            stackWeb.push(wb5);

            //Chuyển Stack --> List
            List<WebBrowser> newList = stackWeb.ConvertStackToList(stackWeb);
            foreach (WebBrowser browser in newList) {
                Console.WriteLine("\n" + browser.ToString());
            }

            //Sort theo last_visited
            ExchangeSort(newList);
            Console.WriteLine("\nList sau khi sort: ");
            foreach (WebBrowser browser in newList)
            {
                Console.WriteLine("\n" + browser.ToString());
            }

            //Chuyen List --> Stack 
            WebBrowserHistory newStackWeb = new WebBrowserHistory();
            foreach (WebBrowser browser in newList)
            {
                newStackWeb.push(browser);
            }
            //Check Empty
            Console.WriteLine(newStackWeb.isEmpty());
            
        }
    }
}