using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2204M.Session3
{
    public class Button
    {
        public event PrintString Action;
        //public DemoEven()
        //{
        //    Click += Demo1.Alert;
        //    Click += new Demo1().ShowMessage;
        //}
        public Button(PrintString functionName)
        {
            Action += functionName;
        }

        public void ClickAction()
        {
            Action("Click here");
        }
    }
}
