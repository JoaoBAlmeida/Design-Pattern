using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new Builder(new Material { material = "vidro" });
            Builder builder1 = new Builder(new Material { material = "madeira" });
            builder.Construct();
            Console.WriteLine("=====================================");
            builder1.Construct();
            Console.WriteLine("Press any key to close:");
            Console.ReadLine();
        }
    }
}
