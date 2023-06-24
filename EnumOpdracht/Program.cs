using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace EnumOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Colors myMainThemeColors = Colors.Purple;

            if (myMainThemeColors == Colors.Purple)
            {
                Console.WriteLine("Dat is mijn kleur denk ik...");
            }
        }
    }
}