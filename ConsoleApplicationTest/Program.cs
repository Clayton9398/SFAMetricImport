using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Code goes here!

            Console.WriteLine("Hello!");
            
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"C:\Users\tomclayton\Documents\GitHub\SFAMetricImport\");

            foreach (System.IO.FileInfo file in dir.GetFiles("*.*"))
            {
                Console.WriteLine("{0}, {1}", file.Name, file.Length);
            }
            Console.ReadLine();
            
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
