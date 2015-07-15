using System;
using System.Collections.Generic;
using System.IO;
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

            foreach (System.IO.FileInfo file in dir.GetFiles("*.JSON"))
            {
                Console.WriteLine("{0}, {1}", file.Name, file.Length);

                StreamReader streamReader = file.OpenText();
                Console.WriteLine(streamReader.ReadToEnd());


                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    DoSomethingWith(line);
                }
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static void DoSomethingWith(string line)
        {
            //throw new NotImplementedException();
        }
    }
}
