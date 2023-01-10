
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace T2204M.news
{
    internal interface INew
    {
        int ID { get; set; }
        String Title { get; set; }
        DateTime PublishDate { get; set; }
        String Author { get; set; }
        String Content { get; set; }
        float AverageRate { get; }
        void Display();
    }
}