using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace democonsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TestStrim();
        }

        private static void TestStrim()
        {
            string str = "abcdc acbd";
            var index=str.LastIndexOf("_");
            var str1 = str.Substring(index+1, str.Length-index-1);
        }
    }
}
