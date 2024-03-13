using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    //how to write all lines of a text
    public class FlieHandlingProblems
    {
        public void WriteText()
        {
            string filePath = @"C:\Users\billu\source\repos\FileHandling\text.txt";
            try
            {
                string data = "Hello World";
                File.WriteAllText(filePath, data);
            }
            catch(IOException e) {
                Console.WriteLine(e.Message);
            }
           

        }
        //read all line of text 
        public void ReadText()
        {
            string path = @"C:\Users\billu\source\repos\FileHandling\text.txt";
            try
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //How to append data to an existing text file 
        public void AppendOfExistingFile()
        {
            string path= @"C:\Users\billu\source\repos\FileHandling\text.txt";
            string data = "this is DotNet"; 

        }
    }
}
