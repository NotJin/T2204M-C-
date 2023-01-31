using T2204M.Asignment2;
using T2204M.bill;
using T2204M.session1;
using T2204M.session2;
using T2204M.Session2;
using T2204M.Session3;
using T2204M.session5;
using System.Net.Http;
//using Newtonsoft.Json;
using T2204M.managerStudent;

public class Program
{
    static void Main(string[] args)
    {
        StudentReport quanLySinhVien = new StudentReport();

        while (true)
        {
            Console.WriteLine("\nCHUONG TRINH QUAN LY SINH VIEN C#");
            Console.WriteLine("*************************MENU**************************");
            Console.WriteLine("**  1. Them sinh vien.                               **");
            Console.WriteLine("**  2. Cap nhat thong tin sinh vien boi ID.          **");
            Console.WriteLine("**  3. Xoa sinh vien boi ID.                         **");
            Console.WriteLine("**  4. Tim kiem sinh vien theo ten.                  **");
            Console.WriteLine("**  5. Sap xep sinh vien theo diem trung binh (GPA). **");
            Console.WriteLine("**  6. Sap xep sinh vien theo ten.                   **");
            Console.WriteLine("**  7. Sap xep sinh vien theo ID.                    **");
            Console.WriteLine("**  8. Hien thi danh sach sinh vien.                 **");
            Console.WriteLine("**  0. Thoat                                         **");
            Console.WriteLine("*******************************************************");
            Console.Write("Nhap tuy chon: ");
            int key = Convert.ToInt32(Console.ReadLine());
            switch (key)
            {
                case 1:
                    Console.WriteLine("\n1. Them sinh vien.");
                    quanLySinhVien.NhapSinhVien();
                    Console.WriteLine("\nThem sinh vien thanh cong!");
                    break;
                case 2:
                    if (quanLySinhVien.SoLuongSinhVien() > 0)
                    {
                        int id;
                        Console.WriteLine("\n2. Cap nhat thong tin sinh vien. ");
                        Console.Write("\nNhap ID: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        quanLySinhVien.UpdateSinhVien(id);
                    }
                    else
                    {
                        Console.WriteLine("\nSanh sach sinh vien trong!");
                    }
                    break;
                case 3:
                    if (quanLySinhVien.SoLuongSinhVien() > 0)
                    {
                        int id;
                        Console.WriteLine("\n3. Xoa sinh vien.");
                        Console.Write("\nNhap ID: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        if (quanLySinhVien.DeleteById(id))
                        {
                            Console.WriteLine("\nSinh vien co id = {0} da bi xoa.", id);
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nSanh sach sinh vien trong!");
                    }
                    break;
                case 4:
                    if (quanLySinhVien.SoLuongSinhVien() > 0)
                    {
                        Console.WriteLine("\n4. Tim kiem sinh vien theo ten.");
                        Console.Write("\nNhap ten de tim kiem: ");
                        string name = Convert.ToString(Console.ReadLine());
                        List<SinhVien> searchResult = quanLySinhVien.FindByName(name);
                        quanLySinhVien.ShowSinhVien(searchResult);
                    }
                    else
                    {
                        Console.WriteLine("\nSanh sach sinh vien trong!");
                    }
                    break;
                case 5:
                    if (quanLySinhVien.SoLuongSinhVien() > 0)
                    {
                        Console.WriteLine("\n5. Sap xep sinh vien theo diem trung binh (GPA).");
                        quanLySinhVien.SortByDiemTB();
                        quanLySinhVien.ShowSinhVien(quanLySinhVien.getListSinhVien());
                    }
                    else
                    {
                        Console.WriteLine("\nSanh sach sinh vien trong!");
                    }
                    break;
                case 6:
                    if (quanLySinhVien.SoLuongSinhVien() > 0)
                    {
                        Console.WriteLine("\n6. Sap xep sinh vien theo ten.");
                        quanLySinhVien.SortByName();
                        quanLySinhVien.ShowSinhVien(quanLySinhVien.getListSinhVien());
                    }
                    else
                    {
                        Console.WriteLine("\nSanh sach sinh vien trong!");
                    }
                    break;
                case 7:
                    if (quanLySinhVien.SoLuongSinhVien() > 0)
                    {
                        Console.WriteLine("\n6. Sap xep sinh vien theo ID.");
                        quanLySinhVien.SortByID();
                        quanLySinhVien.ShowSinhVien(quanLySinhVien.getListSinhVien());
                    }
                    else
                    {
                        Console.WriteLine("\nSanh sach sinh vien trong!");
                    }
                    break;
                case 8:
                    if (quanLySinhVien.SoLuongSinhVien() > 0)
                    {
                        Console.WriteLine("\n7. Hien thi danh sach sinh vien.");
                        quanLySinhVien.ShowSinhVien(quanLySinhVien.getListSinhVien());
                    }
                    else
                    {
                        Console.WriteLine("\nSanh sach sinh vien trong!");
                    }
                    break;
                case 0:
                    Console.WriteLine("\nBan da chon thoat chuong trinh!");
                    return;
                default:
                    Console.WriteLine("\nKhong co chuc nang nay!");
                    Console.WriteLine("\nHay chon chuc nang trong hop menu.");
                    break;
            }
        }
    }
    public static void Main6(string[] args)
    {
        Thread t1 = new Thread(RunThread);
        t1.Start("Xin chao");
        Thread t2 = new Thread(delegate () {
            Console.WriteLine("demo anonymous function");
        });
        t2.Start();
        Console.WriteLine("Main done");


    }

    static async Task<Root> CallApi()
    {
        string url = "https://api.openweathermap.org/data/2.5/weather?q=Hanoi,vietnam&appid=09a71427c59d38d6a34f89b47d75975c&units=metric";
        HttpClient http = new HttpClient();
        var rs = await http.GetAsync(url); // lay data ve

        if (rs.StatusCode == System.Net.HttpStatusCode.OK)
        {
            string content = await rs.Content.ReadAsStringAsync();
            Root r = JsonConvert.DeserializeObject<Root>(content);
            return r;
        }
        return null;
    }

    static void RunThread(object o)
    {
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine(o + ": " + i);
            try
            {
                Thread.Sleep(1000);
            }
            catch (Exception e) { }
        }
    }

    public static void Main5(string[] args)
    {
        PrintString ps = new PrintString(ShowDanger);
        //ps("Nguy hiem lam");
        //PrintString ps1 = new PrintString(Demo1.Alert);
        //PrintString ps2 = new PrintString(new Demo1().ShowMessage);

        ps += Demo1.Alert;
        ps += new Demo1().ShowMessage;

        ps("Nguy hiem lam");

        ps += (s) =>
        {
            Console.WriteLine("Anonymus: " + s);
        };

        ps += delegate (string s)
        {
            Console.WriteLine("Anonymus2: " + s);
        };

        PrintString ps3 = delegate (string s)
        {

        };

        Button de = new Button(ps3);
        de.ClickAction();
    }

    public static void ShowDanger(string mg)
    {
        Console.WriteLine("Danger: "+mg);
    }
    static void Main7(string[] args)

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