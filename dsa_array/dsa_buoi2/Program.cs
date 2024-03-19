// See https://aka.ms/new-console-template for more information
using System.Collections;

namespace dsa_buoi2
{
    public class dsa_buoi2
    {
        static Array create1DFibArray(int n)
        {
            Array ar = Array.CreateInstance(typeof(int), new int[] { n }, new int[] { 1 });
            ar.SetValue(0, 1);
            ar.SetValue(1, 2);
            for (int i = 3; i <= ar.GetUpperBound(0);i++) {
                ar.SetValue(
                        (int)ar.GetValue(i-1) + (int)ar.GetValue(i-2),i
                    );    
            }
            return ar;
        }

        static void convert1DTo2D(int x, int m, int n, out int alpha, out int beta) { 
            alpha = (x + m - 1)/m;
            beta = (x % m == 0) ? (m) : (x%m);            
        }
        /*
        static Array create2DFibArray(int m, int n)
        {
            Array ar = Array.CreateInstance(
                typeof(int),
                new int[2] { m, n }, new int[2] { 1, 1 }
            );
            for (int i = 1; i <= ar.GetUpperBound(0); i++)
                for (int j = 1; j <= ar.GetUpperBound(1); j++)
                {
                    int x = (i - 1) * n + j;
                    if (x == 1)
                        ar.SetValue(0, i, j);
                    if (x == 2)
                        ar.SetValue(1, i, j);
                    if (x > 2)
                    {
                        int ii, jj, iii, jjj;
                        convert1DTo2D(x - 1, m, n, out ii, out jj);
                        convert1DTo2D(x - 2, m, n, out iii, out jjj);
                        ar.SetValue(
                            (int)ar.GetValue(ii, jj) +
                            (int)ar.GetValue(iii, jjj), i, j
                        );
                    }
                }
            return ar;
        }
        */
        static void print1DArray(Array a) {
            foreach (int item in a)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void print2DArray(Array ar)
        {
            for (int i = ar.GetLowerBound(0); i <= ar.GetUpperBound(0); i++)
            {
                for (int j = ar.GetLowerBound(1); j <= ar.GetUpperBound(1); j++)
                    Console.Write(ar.GetValue(i, j) + "\t");
                Console.WriteLine();
            }
        }
        public static void Main(string[] args)
        {
            //Lab1
            Array arr1 = Array.CreateInstance(typeof(int),
                                            new int[1] { 5 },
                                            new int[1] { 1 }
                );
            //ar1[1] ar1[2]
            Random r = new Random();
            for( int i = arr1.GetLowerBound(0); i < arr1.Length + arr1.GetLowerBound(0); i++ )
            {
                arr1.SetValue(r.Next(1,9),i); //arr1[i] = ?
            }
            for (int i = arr1.GetLowerBound(0); i < arr1.Length + arr1.GetLowerBound(0); i++)
            {
                Console.Write(arr1.GetValue(i)+" ");
            }
            System.Console.WriteLine();
            /*
            foreach(int v in arr1)
            {
            Console.WriteLine(v+" ");
            }
            */

            //Lab2: Fibonacci using array
            Array ar2 = create1DFibArray(5);
            print1DArray(ar2);

            /*Lab3: Fibonacci using 2c-array
             * Array ar2dfib = create2DFibArray(3, 4);
             * print2DArray(ar2dfib);
             */
            /*
            //Lab4: LIST
            List<int> list = new List<int>();
            list.Add(0);
            list.Add(1);
            for (int i = 0; i <= 10; i++)
            {
                if (i >= 2) {
                    list.Add(list[i - 1] + list[i - 2]);
                }   
            }
            foreach (int v in list) { 
                Console.Write(v+" ");
            }
            System.Console.WriteLine();
            //Lab5: ARRAYLIST
            ArrayList arlist = new ArrayList();
            arlist.Add(0);
            arlist.Add(1);
            for (int i = 0; i <= 10; i++)
            {
                if (i >= 2)
                {
                    arlist.Add((int)arlist[i - 1] + (int)arlist[i - 2]);
                }
            }
            foreach (int v in arlist)
            {
                Console.Write(v+" ");
            }
            */
        }
    }
}

    


