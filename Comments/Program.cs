using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments
{
    class Program
    {
        static void Main(string[] args)
        {
            String goOn = "press any key to get more Infos about Comments.";
            Console.WriteLine("// introduce a SingleLineComment. ({0})", goOn);
            Console.ReadLine();
            Console.WriteLine("/* starts a CommmentBlock\n({0})", goOn);
            Console.ReadLine();
            Console.WriteLine("/** starts a DocumentationBlock\n({0})", goOn);
            Console.ReadLine();
            Console.WriteLine("*/ends a Comment or a DocumentationBlock");
            Console.ReadLine();
        }
    }
}
