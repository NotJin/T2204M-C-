using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2204M.Session3
{
    public delegate void PrintString(String s);
    public class Demo1
    {
        public void ShowMessage(String mgs)
        {
            Console.WriteLine("Show info: "+mgs); 
        }

        public static void Alert(String str)
        {
            Console.WriteLine("Alert: " + str);
        }
    }
}
