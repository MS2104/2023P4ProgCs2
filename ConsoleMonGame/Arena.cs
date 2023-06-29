namespace ConsoleMonGame
{
    internal class Arena
    {
        public void Fight(ConsoleMon fighterA, ConsoleMon fighterB)
        {
            fighterA.skills[0].UseOn(fighterB, fighterA);
            Thread.Sleep(1000);
            Console.WriteLine($"{fighterA.pokemonName} attacks {fighterB.pokemonName}!");
            Thread.Sleep(1000);

            fighterB.skills[0].UseOn(fighterA, fighterB);
            Console.WriteLine($"{fighterB.pokemonName} attacks {fighterA.pokemonName}!");
            Thread.Sleep(1000);

            Console.WriteLine($"{fighterA.pokemonName} has {fighterA.health} HP left.");
            Console.WriteLine($"{fighterB.pokemonName} has {fighterB.health} HP left.");
            Thread.Sleep(1000);
        }
    }
}
