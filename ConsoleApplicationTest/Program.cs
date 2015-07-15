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
                //Console.WriteLine(streamReader.ReadLine());
                //Console.WriteLine(streamReader.ReadToEnd());

                string line;
                //while ((line = streamReader.ReadLine()) != null)
                for (int i = 0; i < 186; i++)
                {
                    //Console.WriteLine("A Line " + i);
                    string readLine = streamReader.ReadLine();

                    if (readLine.Contains("_id"))
                    {

                       readLine = readLine.Replace("_id", "");
                       readLine = readLine.Replace(" ","");
                       readLine = readLine.Replace("\"\":", "");
                        
                       Console.Write(readLine);
                    }
                    
                    
                    if (readLine.Contains("count"))
                    {
                       readLine = readLine.Replace("00", "");
                       readLine = readLine.Replace(".", "");
                       readLine = readLine.Replace("count", "");
                       readLine = readLine.Replace(" ", "");
                       readLine = readLine.Replace("\"\":", "");
                        
                       Console.WriteLine(readLine);
                    }

                    //readLine = readLine.Replace("{", "Was a curly brace!");
                    //readLine = readLine.Replace(".0000000000000000", "");
                    //readLine = readLine.Replace("00", "");
                    //readLine = readLine.Replace(".", "");
                    //readLine = "A line";

                    //Console.WriteLine(readLine);
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
