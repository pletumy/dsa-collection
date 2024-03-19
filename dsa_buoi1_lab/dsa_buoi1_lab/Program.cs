using dsa_buoi1_lab;
using System.Text;

namespace dsa_lab_buoi1 {
    public class dsa_lab_buoi1 {
        public static T hamCong<T>(ref T a, ref T b){ 
            if(a is Array || b is Array)
            {
                Array arr = (dynamic)a;
                Array brr = (dynamic)b;
                Array sum = Array.CreateInstance(typeof(object),arr.Length + brr.Length);
                for(int i = 0; i < arr.Length; i++)
                {
                    sum.SetValue(arr.GetValue(i),i);
                }
                for (int i = 0; i < brr.Length; i++)
                {
                    sum.SetValue(brr.GetValue(i), arr.Length + i);
                }
                return (dynamic)sum;
            }
            return (dynamic)a + (dynamic)b;
        } 
        public static void FindMinMax<T>(ref T a) {
            int[] arr = (dynamic)a;
            int max = arr[0];
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("\t\tSố nguyên lớn nhất: " + max);
            Console.WriteLine("\t\tSố nguyên bé nhất: " + min);
        }
        public static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            //Bài 1
            Console.WriteLine("\t* BÀI 1 : ");
            Timing timeObj = new Timing();
            timeObj.startTime();
            int x1 = 1;
            int x2 = 3;
            Console.WriteLine($"\t\t{x1} + {x2} = " + hamCong<int>(ref x1, ref x2));

            string x3 = "Pích";
            string x4 = " cà bu";
            Console.WriteLine($"\t\t{x3} + {x4} = " + hamCong<string>(ref x3, ref x4));

            object[] x5 = {"Học tài","thi phận"};
            object[] x6 = { "Học tài", "thi xỉu" };
            //Console.WriteLine($"\t\t{x5} + {x6} = " + hamCong<Object[]>(ref x5, ref x6));
            Array cr = hamCong<object[]>(ref x5,ref x6);
            Console.Write("\t\t");
            foreach (string item in cr)
            {
                Console.Write(item + " ");
            }
            timeObj.StopTime();
            Console.WriteLine("\n\t\tTổng thời gian chạy chương trình số 2: " + timeObj.Result().TotalMilliseconds);

            //Bài 2
            Console.WriteLine("\t* BÀI 2 : ");
            int[] arr = new int[1000];
            Random rand = new Random();
            int i = 0;
            while (i < 1000)
            {
                arr[i++] = rand.Next(1,1000);
            }
            Timing timeObj2 = new Timing();
            timeObj2.startTime();
            FindMinMax<int[]>(ref arr);

            Console.WriteLine("\t\tIn các phần tử trong mảng: ");
            for (i = 0; i < 1000; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            
            timeObj2.StopTime();
            Console.WriteLine("\t\tTổng thời gian chạy chương trình số 2: " + timeObj2.Result().TotalMilliseconds);
        }
    }

}
