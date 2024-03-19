// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//namespace ConsoleApplication1 {

class DSA_buoi1 {
    public static void Swap<T,Q>(ref T a, ref T b)
    {
        T temp = a; a = b; b = temp;
    }
    public static void Swap(ref object a, ref object b) { 
        object temp = a; a = b; b = temp;   
    }
    //Add(int)
    //dynamic skip check datatype
    public static T Add<T, Q>(T a, T b) {
        if (a is Array && b is Array)
        {
            Array ar = (dynamic)a;
            Array br = (dynamic)b;
            Array sum = Array.CreateInstance(typeof(object),ar.Length+br.Length);

            for (int i = 0; i < ar.Length; i++) {
                sum.SetValue(ar.GetValue(i),i);
            }
            for (int i = 0; i < br.Length; i++)
            {
                sum.SetValue(br.GetValue(i), ar.Length+i);
            }
            Q[] sumr = new Q[sum.Length];
            //Array sumr = Array.CreateInstance(typeof(sum.), );
            for (int i = 0; i < sum.Length; i++) {
                sumr[i] = (Q)sum.GetValue(i);
            }   
            return (dynamic)sumr;
        }
        else
         return (dynamic)a + (dynamic)b;
    }
    

    static void Main(string[] args)
    {
        /*
        int x = 2; int y = 3;   
        Swap(ref x, ref y);
        
        int x = 2, y = 3;
        Console.WriteLine($"x={x}, y={y}");
        Swap<int>(ref x, ref y);
        Console.WriteLine($"x={x}, y={y}");

        string xx = "di", yy = "hoc";
        Console.WriteLine($"x={xx}, y={yy}");
        Swap<string>(ref xx, ref yy);
        Console.WriteLine($"x={xx}, y={yy}");

        //ADD INT
        int a = 2, b = 3;
        Console.WriteLine(Add<int>(a,b));

        //ADD STRING
        string c = "di", d = "hoc";
        Console.WriteLine(Add<string>(c,d));
        */
        //ADD ARRAY
        string[] e = {"1","2"};
        string[] f = { "3","4"};
        Array cr = Add<string[], string>(e,f);
        foreach (string item in cr) { 
            Console.Write(item +" ");    
        }

        Timing timer = new Timing();
        timer.startTime();
        Array cr1 = Add<string[], string>(e, f);
        timer.StopTime();
        Console.WriteLine("\nTime: "+timer.Result().Milliseconds);

    }
}
     






