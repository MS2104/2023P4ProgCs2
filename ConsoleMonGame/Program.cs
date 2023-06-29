namespace ConsoleMonGame
{
    class Program
    {
        static void Main(string[] args)
        {
            TestConsoleMonFunctions();
            TestFactoryFunctions();
            TestConstructors();
            //TestCopySkill(); // Object reference not set to an instance of an object. Zie lijn 62.
            TestCopyConsoleMon();
        }

        static void TestConsoleMonFunctions()
        {
            Console.WriteLine("TestConsoleMonFunctions");
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


            Skill skill = new Skill(90, 80, "FireBlade", Element.Fire);
            Console.WriteLine(skill.energyCost == 80);
            Console.WriteLine(skill.name == "FireBlade");
            Console.WriteLine(skill.damage == 90);
            Console.WriteLine(skill.element == Element.Fire);
        }

        static void TestCopySkill()
        {
            Console.WriteLine("TestCopySkill");
            ConsoleMonFactory factory = new ConsoleMonFactory();
            List<ConsoleMon> templates = factory.LoadJson("monsterdata.json"); // 
            Skill copyFrom = templates[0].skills[0];

            Skill copy = factory.CopySkill(copyFrom);
            Console.WriteLine(copy.name == copyFrom.name);
            Console.WriteLine(copy.damage == copyFrom.damage);
            Console.WriteLine(copy.element == copyFrom.element);
            copy.name = "anders";
            Console.WriteLine(copy.name != copyFrom.name);
        }

        static void TestCopyConsoleMon()
        {
            Console.WriteLine("TestCopyConsoleMon");
            ConsoleMonFactory factory = new ConsoleMonFactory();
            List<ConsoleMon> templates = factory.LoadJson("monsterdata.json");
            ConsoleMon copyFrom = templates[0];

            ConsoleMon copy = factory.CopyConsoleMon(copyFrom);
            Console.WriteLine(copy.pokemonName == copyFrom.pokemonName);
            Console.WriteLine(copy.health == copyFrom.health);
            Console.WriteLine(copy.skills == copyFrom.skills);
            Console.WriteLine(copy.skills[0] == copyFrom.skills[0]);
            copy.pokemonName = "anders";
            copy.skills[0].name = "newskill";
            Console.WriteLine(copy.pokemonName != copyFrom.pokemonName);
            Console.WriteLine(copy.skills[0].name != copyFrom.skills[0].name);
        }
    }
}
