using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31211022442_PhanLeTuMy
{
    public class WebBrowser { 
        public string title { get; set; }
        public DateTime last_visited { get; set; }
        public string url { get; set; }

        public WebBrowser(string title, DateTime last_visited, string url)
        {
            this.title = title;
            this.last_visited = last_visited;
            this.url = url;
        }
         public override string ToString() { 
            return this.title + " \n| Last Visisted : " +  this.last_visited + " \n| URL : " + this.url;  
        }
    }
}
