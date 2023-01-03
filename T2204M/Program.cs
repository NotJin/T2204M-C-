using System;
using System.Collections.Generic;
public class program
{
    public static void Main(String[] args)
    {
        int x = 10;
        double y = 5.14;
        Console.WriteLine("Hello world: " + x);
        string s = "T2204M";

        int[] ns = new int[3];
        ns[0] = 15;
        ns[1] = 20;
        ns[2] = 25;

        foreach(int n in ns)
        {
            //n
        }

        for(int i = 0; i < ns.Length; i++)
        {
            //ns[i]
        }

        string input = Console.ReadLine(); //scan
        int num = Convert.ToInt32(input);
        Console.WriteLine("num = " + num);

        Human h = new Human();
        h.name = "Nguyen Van A";
        h.Run();
    }
}