using T2204M.Asignment2;
using T2204M.bill;
using T2204M.session1;
using T2204M.session2;
using T2204M.Session2;

public class Program
{
    static void Main(string[] args)

    {
        KhachHangVN a = new KhachHangVN(1, "Le Minh Duc", "2022-07-22", 219, "Cá nhân");
        KhachHangNN b = new KhachHangNN(2, "Nguyen Van An", "2022-09-21", 156, "US");
        Console.WriteLine(a.ThanhTien);
        Console.WriteLine(b.ThanhTienNN);

    }

    public static void Main4(string[] args)
    {
        PhoneNumber pn = new PhoneNumber();
        Console.WriteLine(pn.InsertPhone);
    }
    public static void Main3(string[] args)
    {
        //Dog d = new Dog();
        //d.SetKind("DOG");
        //d.Info();
        Dog d = new Dog("Dog", 12);
        d.Weight = 10;
        d.Color = "yellow";
        Console.WriteLine(d.Weight);
        Console.WriteLine(d.Color);
        Dog[] dd = new Dog[10];

        for (int i = 0; i < dd.Length; i++)
        {
            dd[i] = new Dog();
        }
        // dd[0].Weight = 20;

        foreach (Dog o in dd)
        {
            o.Color = "green";
        }

        List<Dog> ls = new List<Dog>();
        ls.Add(new Dog());
        Console.WriteLine(ls.Count);// .Count -> kich thuoc tap hop
        List<int> ints = new List<int>();

    }
    public static void Main2(string[] args)
    {

        double y = 3.14;

        string s = "T2204M";

        int x = 10;
        if (x >= 10)
        {
            Console.WriteLine("A");
        }
        else if (x > 5)
        {
            Console.WriteLine("B");
        }
        else if (x > 15)
        {
            Console.WriteLine("C");
        }
        else
        {
            Console.WriteLine("D");
        }

        int[] ns = new int[3];

        ns[0] = 15;
        ns[1] = 20;
        ns[2] = 25;

        foreach (int n in ns)
        {
            //n
        }

        for (int i = 0; i < ns.Length; i++)
        {
            // ns[i]
        }

        string input = Console.ReadLine(); // scan
        int num = Convert.ToInt32(input);
        Console.WriteLine("num = " + num);

        Human h = new Human();
        h.name = "Nguyen Van An";
        h.Run();
    }
}