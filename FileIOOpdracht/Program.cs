namespace FileIOOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string[] content = File.ReadAllLines("leesdezefile.txt");

            foreach (string line in content)
            {
                Console.WriteLine(line);
            }

            string[] content2 = new string[] { "ASTROWOLRD is beroofd van de Album of the Year 2019" };
            File.WriteAllText("C:\\School M3\\2023P4ProgCs2\\FileIOOpdracht\\bin\\Debug\\net7.0\\output\\mijnnieuwefile.txt", "ASTROWORLD >>> Invasion of Privacy");

            string[] lines = { "", "Baby I'm a firework", "h" };
            File.AppendAllLines("C:\\School M3\\2023P4ProgCs2\\FileIOOpdracht\\mijnnieuwefile.txt", lines);

            Directory.CreateDirectory("output");
        }
    }
}