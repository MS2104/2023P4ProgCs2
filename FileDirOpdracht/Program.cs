namespace FileDirOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DirectoryInfo dir = ;
            Console.WriteLine("Hello, World!");

            DirectoryInfo dir = new DirectoryInfo(@"C:\School M3\2023P4ProgCs2");
            // Ja ik bewaar mijn school werk in de C:. Mocht u daar een probleem mee hebben
            // dan kunt u contact opnemen met mijn advocaat.

            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.Name);
            }

            foreach (DirectoryInfo dirs in dir.GetDirectories())
            {
                Console.WriteLine(dirs.Name);
            }
        }
    }
}