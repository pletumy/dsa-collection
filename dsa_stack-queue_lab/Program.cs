using Aspose.Html;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace dsa_lab_chap3
{
    public class Program
    {
        public static int xetDoUuTien(char c) {
            if (c == '^') {
                return 3;
            }
            if (c == '/' || c == '*')
            {
                return 2;
            }
            if (c == '+' || c == '-')
            {
                return 1;
            }
            else return -1;
        }

        public static char xetTinhKetHop(char c) {
            if (c == '^') return 'R';
            return 'L';
        }

        public static void infixToPostfix(string s) {
            Stack<char> stack = new Stack<char>();
            List<char> list = new List<char>();

            for (int i = 0; i < s.Length; i++) {
                char c = s[i];
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9'))
                {
                    list.Add(c);
                }
                else if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        list.Add(stack.Pop());
                    }
                    stack.Pop(); // Pop '('
                }
                else
                {
                    while (stack.Count > 0 && (xetDoUuTien(s[i]) < xetDoUuTien(stack.Peek()) || xetDoUuTien(s[i]) == xetDoUuTien(stack.Peek()) &&
                                                   xetTinhKetHop(s[i]) == 'L'))
                    {
                        list.Add(stack.Pop());
                    }
                    stack.Push(c);
                }
            }
            while (stack.Count > 0)
            {
                list.Add(stack.Pop());
            }

            Console.WriteLine("KẾT QUẢ INFIX --> POSTFIX : " + string.Join("", list));
        }

        public static void tinhGiaTriPostfix(string s) {
            int a, b, ans;
            Stack stack = new Stack();
            for (int i = 0; i < s.Length; i++)
            {
                string c = s.Substring(i, 1);
                if (c.Equals("*"))
                {
                    a = Convert.ToInt32(stack.Pop());
                    b = Convert.ToInt32(stack.Pop());
                    ans = a * b;
                    stack.Push(ans);
                }
                else if (c.Equals("/"))
                {
                    a = Convert.ToInt32(stack.Pop());
                    b = Convert.ToInt32(stack.Pop());
                    ans = a / b;
                    stack.Push(ans);
                }
                else if (c.Equals("+"))
                {
                    a = Convert.ToInt32(stack.Pop());
                    b = Convert.ToInt32(stack.Pop());
                    ans = a + b;
                    stack.Push(ans);
                }
                else if (c.Equals("-"))
                {
                    a = Convert.ToInt32(stack.Pop());
                    b = Convert.ToInt32(stack.Pop());
                    ans = a - b;
                    if (a < b) ans *= -1;
                    stack.Push(ans);
                }
                else {
                    stack.Push(c);
                }
            }
            Int32 res = (Int32)stack.Pop();
            Console.WriteLine("KẾT QUẢ: " + res);
        }

        public static string xoaNoiDungTag(string s, char x) {
            string result = "";
            foreach (char item in s)
            {
                if (item == x)
                {
                    result += item;
                    break;
                }
                result += item;
            }
            return result;
        }

        public static string layNoiDung(string s) {
            string result = "";
            foreach (char c in s)
            {
                if (Char.IsLetter(c))
                {
                    result += c;
                }
            }
            return result;
        }
        public static int doiSanhTheHTML(string c)
        {
            Queue queue = new Queue();
            //Nối chuỗi + Xóa khoảng trắng
            c = string.Join("", c.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
            Console.WriteLine("HTML Script: \n"+c);
            //Tách chuỗi '<'
            string[] txt_TachChuoi = c.Split("<");
            string[] txt_TachChuoi2 = txt_TachChuoi;

            foreach (String str in txt_TachChuoi)
            {
                if (!str.EndsWith(">"))
                {
                    string res = xoaNoiDungTag(str, '>');
                    txt_TachChuoi2[Array.IndexOf(txt_TachChuoi, str)] = res;
                }
            }
            Queue temp = new Queue();
         
            foreach (string item in txt_TachChuoi2)
            {
                string a = layNoiDung(item);
                if (!queue.Contains(a))
                {
                    queue.Enqueue(a); 
                }
                else {
                    if (queue.Peek().Equals(a))
                    {
                        queue.Clear();
                    }
                    else {
                        while (!queue.Peek().Equals(a))
                        {
                            temp.Enqueue(queue.Dequeue());              
                        }
                        queue.Clear();
                        while (temp.Count != 0)
                        {
                            queue.Enqueue(temp.Dequeue());
                        }
                        
                    }
                }
            }
            return queue.Count;
        }
        
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // BÀI 1
            Console.WriteLine("==> BÀI 1 : ");
            string a = "a+b*(c^d-e)^(f+g*h)-i";
            Console.WriteLine("INFIX : " + a);
            infixToPostfix(a);

            // BÀI 2
            Console.WriteLine("==> BÀI 2 : ");
            string b = "57+67+*";
            tinhGiaTriPostfix(b);

            // BÀI 3
            Console.WriteLine("==> BÀI 3 : ");
            string documentPath = @"C:\Users\ADMIN\OneDrive\Documents\dsa\dsa_lab_chap3\text.html";
            var document = new HTMLDocument(documentPath);
            string c = document.DocumentElement.OuterHTML;
            if (doiSanhTheHTML(c) == 1) Console.WriteLine("File hợp lệ!");
            else Console.WriteLine("Có thẻ bị lỗi");
            
        }
    }
}