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

                Console.WriteLine(targetMon.health == -100);

                Console.WriteLine(casterMon.energy == -20);
            }

            TestConsoleMonFunctions();
        }
    }
}