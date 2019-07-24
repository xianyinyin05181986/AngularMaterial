using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> ky = new Dictionary<string, object>();
            ky.Add("hi",1);
            object a = ky["hi"];
        }
    }
}
