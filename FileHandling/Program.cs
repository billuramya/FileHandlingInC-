using FileHandling;
using System;
class Program
{
    public static void Main(string[] args)
    {
        FlieHandlingProblems file = new FlieHandlingProblems();
        file.WriteText();
        file.ReadText();
    }
}