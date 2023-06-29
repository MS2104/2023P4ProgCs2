namespace ConsoleMonGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            static void TestConsoleMonFunctions()
            {
                Console.WriteLine("TestSkillFunctions");
                ConsoleMon casterMon = new ConsoleMon();
                ConsoleMon targetMon = new ConsoleMon();
                Skill skill = new Skill()
                {
                    damage = 100,
                    energyCost = 20,
                };
                skill.UseOn(targetMon, casterMon);

                Console.WriteLine(targetMon.health == -150);

                Console.WriteLine(casterMon.energy == -20);
            }

            static void TestFactoryFunctions()
            {
                Console.WriteLine("TestFactoryFunctions");
                ConsoleMonFactory factory = new ConsoleMonFactory();
                factory.Load("monsterdata.txt");
                factory.Load("monsterdata.json");
            }

            static void TestConstructors()
            {
                Console.WriteLine("TestConstructors");
                ConsoleMon mon = new ConsoleMon(200, 200, "ConsoleColorMon", Element.Earth);

                Console.WriteLine(mon.energy == 200);
                Console.WriteLine(mon.pokemonName == "ConsoleColorMon");
                Console.WriteLine(mon.health == 200);
                Console.WriteLine(mon.weakness == Element.Earth);

            }

            TestConsoleMonFunctions();
            TestFactoryFunctions();
            TestConstructors();
        }
    }
}