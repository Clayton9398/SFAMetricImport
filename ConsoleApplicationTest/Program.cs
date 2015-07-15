using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplicationTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //This is stating where to find the documents we will be writing to a CSV format
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"C:\Users\tomclayton\Documents\GitHub\SFAMetricImport\");

            foreach (System.IO.FileInfo file in dir.GetFiles("*.JSON"))
            {
                Console.WriteLine("{0}, {1}", file.Name, file.Length);

                //streamReader is what is used to read the information in the given directory
                StreamReader streamReader = file.OpenText();

                //streamWriter is what is used to write the text to the CSV file
                StreamWriter streamWriter = new StreamWriter(file.FullName.Replace(".json", ".csv"));
                streamWriter.WriteLine("Date,Count");

                string line;
                for (int i = 0; i < 186; i++)
                {

                    string readLine = streamReader.ReadLine();

                    //this is telling us if the line of text contains _id, then it should only show the values related to it
                    if (readLine.Contains("_id"))
                    {
                        //this section tells us that it is replacing phrases. In this instance, it is changing them for a blank space
                        readLine = readLine.Replace("_id", "").Replace(" ", "").Replace("\"\":", "");

                        Console.Write(readLine);
                        streamWriter.Write(readLine);
                    }

                    //same as with the _id, if it contains "count", then it should only show data related to it. Because both "_id" and "count" are being displayed
                    if (readLine.Contains("count"))
                    {
                        readLine = readLine.Replace("00", "").Replace(".", "").Replace("count", "").Replace(" ", "").Replace("\"\":", "");

                        //this here is stating that the streamWriter must write up the data from the console; in other words the contents of the readLine will be written to the CSV
                        Console.WriteLine(readLine);
                        streamWriter.WriteLine(readLine);
                    }
                    //Code MUST go between the braces in order for it to be recognised
                }

                //Completes writing to the file and flushes
                streamWriter.Flush();
                streamWriter.Close();
            }
            //this is the exit option for the application. "Press any key to exit" simply allows you to close the app by pressing any key on the keyboard
            Console.WriteLine("Data extract complete!");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static void DoSomethingWith(string line)
        {


        }
    }
}

// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -DUMP CODE- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
//readLine = readLine.Replace(".", "")
//readLine = readLine.Replace("count", "");
//readLine = readLine.Replace(" ", "");
//readLine = readLine.Replace("\"\":", "");
//readLine = readLine.Replace(" ", "");
//readLine = readLine.Replace("\"\":", "");
//throw new NotImplementedException();
//Console.WriteLine("A Line " + i);
//while ((line = streamReader.ReadLine()) != null)