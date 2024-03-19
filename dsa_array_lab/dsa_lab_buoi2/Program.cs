// See https://aka.ms/new-console-template for more information
using dsa_buoi1_lab;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace dsa_lab_buoi2
{
    public class Program {
        //Using Array 
        public static void tinhDiemTrungBinhMon_Array(int[,] a, int index) {
            int dtb_Mon = ((int)a[index, 0] + (int)a[index, 1]) / 2;
            Console.Write(dtb_Mon);
        }
        public static void findMinMax_Array(int[,] a)
        {
            int min = 10;
            int max = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    int currentValue = (int)a.GetValue(i, j);
                    if (currentValue > max)
                    {
                        max = currentValue;
                    }
                    if (currentValue < min)
                    {
                        min = currentValue;
                    }
                }

            }
            Console.WriteLine("Điểm thấp nhất:" + min + "\nĐiểm cao nhất :" + max);
        }
        //Using List
        public static void tinhDiemTrungBinh_List(List<List<int>> list) {
            for (int i = 0; i < list.Count; i++)
            {
                if (i == 0 || i == 1) Console.Write("Điểm trung bình môn Toán: ");
                if (i == 2 || i == 3) Console.Write("Điểm trung bình môn Văn: ");
                if (i == 4 || i == 5) Console.Write("Điểm trung bình môn Anh: ");
                for (int j = 0; j < list[i].Count - 1; j++)
                {
                    int dtb = ((int)list[i][j] + (int)list[i][j + 1]) / 2;
                    Console.Write(dtb);
                }
                Console.WriteLine();
            }
        }
        public static void findMinMax_List(List<List<int>> list, int index)
        {
            int max = 0;
            int min = 10;
            for (int i = index; i < 2; i++)
            {
                for (int j = 0; j < list[i].Count; j++) {
                    if (list[i][j] > max) max = list[i][j];
                    else if (list[i][j] < min) min = list[i][j];
                }
            }
            Console.WriteLine("Điểm thấp nhất:" + min + "\nĐiểm cao nhất :" + max);
        }

        //Using ArrayList

        public static float tinhDiemTrungBinh_ArrayList(int i, int j) {
            return (float)(i + j) / 2;
        }
        public static void findMinMax_ArrayList(ArrayList a)
        {
            int min = 10;
            int max = 0;
            for (int i = 0; i < a.Count; i++)
            {
                    int[] capDiem = (int[])a[i];
                    foreach (var item in capDiem)
                    {
                        if (min > (int)item) min = item;
                        if (max < (int)item) max = item;
                    }
                
            }
            Console.WriteLine("Điểm thấp nhất:" + min + "\nĐiểm cao nhất :" + max);
        }
        public static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            //Using ARRAY
            Timing timeObj = new Timing();
            timeObj.startTime();
            Console.WriteLine("\t\t\t\tARRAY");
            int[,] bangDiem_Toan = { {9,9}, {6,8} };
            int[,] bangDiem_Anh = { {7,10}, {6,7 }};
            int[,] bangDiem_Van = { { 5,7 }, { 10, 8 } };
            Array bangDiem = Array.CreateInstance(typeof(object), new int[] { 3, 1 }, new int[] { 0, 0 });
            bangDiem.SetValue(bangDiem_Toan,0,0);
            bangDiem.SetValue(bangDiem_Anh,1,0);
            bangDiem.SetValue(bangDiem_Van,2,0);
            
            for (int i = 0; i < bangDiem.GetLength(0); i++)
            {
                int[,] subArray = (int[,])bangDiem.GetValue(i, 0);
                for (int j = 0; j < subArray.GetLength(0); j++)
                {
                    int value1 = subArray[j, 0];
                    int value2 = subArray[j, 1];
                    if (i == 0)
                    {
                        Console.WriteLine($"MÔN TOÁN : {value1}, {value2}");
                    }
                    if (i == 1) Console.WriteLine($"MÔN ANH : {value1}, {value2}");
                    if (i == 2) Console.WriteLine($"MÔN VĂN : {value1}, {value2}");
                    Console.Write("Điểm trung bình môn: ");
                    tinhDiemTrungBinhMon_Array(subArray, j);
                    Console.WriteLine();
                }
                
            }
            Console.WriteLine("===========================");
            Console.WriteLine("MÔN TOÁN: ");
            findMinMax_Array(bangDiem_Toan);
            Console.WriteLine("\nMÔN ANH: ");
            findMinMax_Array(bangDiem_Anh);
            Console.WriteLine("\nMÔN VĂN: ");
            findMinMax_Array(bangDiem_Van);
            Console.WriteLine("===========================");
            timeObj.StopTime();
            
            //Using LIST
            Timing timeObj2 = new Timing();
            timeObj2.startTime();
            Console.WriteLine("\t\t\t\tLIST");
            List<List<int>> list = new List<List<int>> { };
            List<int> toan1 = new List<int>() { 9, 8};
            List<int> toan2 = new List<int>() { 10, 8 };
            List<int> van1 = new List<int>() { 9, 7 };
            List<int> van2 = new List<int>() { 9, 6 };
            List<int> anh1 = new List<int>() { 10, 8 };
            List<int> anh2 = new List<int>() { 9, 5 };

            list.Add(toan1);
            list.Add(toan2);
            list.Add(van1);
            list.Add(van1);
            list.Add(anh1);
            list.Add(anh2);

            for (int i = 0; i < list.Count; i++) {
                if (i == 0 || i == 1) Console.Write("Môn Toán: ");
                if (i == 2 || i == 3) Console.Write("Môn Văn: ");
                if (i == 4 || i == 5) Console.Write("Môn Anh: ");
                for (int j = 0; j < list[i].Count; j++)
                { 
                    Console.Write(list[i][j] + " ");
                }
                Console.WriteLine();
            }

            tinhDiemTrungBinh_List(list);
            Console.WriteLine("===========================");
            Console.WriteLine("MÔN TOÁN: ");
            findMinMax_List(list, 0);
            Console.WriteLine("\nMÔN ANH: ");
            findMinMax_List(list, 4);
            Console.WriteLine("\nMÔN VĂN: ");
            findMinMax_List(list, 2);
            Console.WriteLine("===========================");
            timeObj2.StopTime();
            
            //Using ArrayList
            Timing timeObj3 = new Timing();
            timeObj3.startTime();
            Console.WriteLine("\t\t\t\tARRAYLIST");
            ArrayList arrayList = new ArrayList();
            
            ArrayList al_Toan = new ArrayList() { 
                new int[] { 8, 9},
                new int[] { 10, 7},
            };
            ArrayList al_Anh = new ArrayList() {
                new int[] { 10, 9},
                new int[] { 10, 5},
            };
            ArrayList al_Van = new ArrayList() {
                new int[] { 8, 6},
                new int[] { 8, 7},
            };

            arrayList.Add(al_Toan);
            arrayList.Add(al_Anh);
            arrayList.Add(al_Van);

            for (int i = 0; i < arrayList.Count; i++)
            {
                ArrayList monHoc = (ArrayList)arrayList[i];
                if (monHoc.Equals(al_Toan)) Console.WriteLine("ĐIỂM MÔN TOÁN :");
                if (monHoc.Equals(al_Anh)) Console.WriteLine("ĐIỂM MÔN ANH :");
                if (monHoc.Equals(al_Van)) Console.WriteLine("ĐIỂM MÔN VĂN :");
                for (int j = 0; j < monHoc.Count; j++)
                {
                    int[] capDiem = (int[])monHoc[j];
                    Console.WriteLine("Điểm của sinh viên " + (j + 1) + ":");
                    Console.WriteLine("Điểm giữa kỳ: " + capDiem[0]);
                    Console.WriteLine("Điểm cuối kỳ: " + capDiem[1]);
                    Console.WriteLine("Điểm trung bình môn: " + tinhDiemTrungBinh_ArrayList(capDiem[0], capDiem[1]) +"\n");
                }
            }

            Console.WriteLine("===========================");
            Console.WriteLine("MÔN TOÁN: ");
            findMinMax_ArrayList(al_Toan);
            Console.WriteLine("\nMÔN ANH: ");
            findMinMax_ArrayList(al_Anh);
            Console.WriteLine("\nMÔN VĂN: ");
            findMinMax_ArrayList(al_Van);
            Console.WriteLine("===========================");
            timeObj3.StopTime();

            Console.WriteLine("\t\tTổng thời gian chạy chương trình số 1: " + timeObj.Result().TotalMilliseconds);
            Console.WriteLine("\t\tTổng thời gian chạy chương trình số 2: " + timeObj2.Result().TotalSeconds);
            Console.WriteLine("\t\tTổng thời gian chạy chương trình số 3: " + timeObj3.Result().TotalSeconds);
            //Tính thời gian
        }
        
       
    }
}
