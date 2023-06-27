using System.IO;

namespace SplitOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string content = File.ReadAllText("TextFile1.txt");

            // System.IO.FileNotFoundException: 'Could not find file 'C:\School M3\2023P4ProgCs2\SplitOpdracht\bin\Debug\net7.0\TextFile1.txt'.'
            // Ik heb TextFile1.txt maar hier naar toe verplaatst.

            string[] keyvalue = content.Split(":");

            foreach (string key in keyvalue)
            {
                Console.WriteLine(key);
            }
            
            string[] cijfers = keyvalue[1].Split(",");

            foreach (string cijfer in cijfers)
            {
                Console.WriteLine(cijfer);
            }
        }
    }
}