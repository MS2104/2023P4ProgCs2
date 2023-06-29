using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class ConsoleMonFactory
    {
        internal void Load(string datafile)
        {
            string[] lines = File.ReadAllLines("C:\\School M3\\2023P4ProgCs2\\ConsoleMonGame\\monsterdata.txt");

            foreach (string line in lines)
            {
                string[] typesplit = line.Split('|');

                string[] consoleMonData = typesplit[0].Split(',');

                ConsoleMon dataMon = new ConsoleMon();

                dataMon.pokemonName = consoleMonData[0];
                dataMon.health = Convert.ToInt32(consoleMonData[2]);
                dataMon.energy = Convert.ToInt32(consoleMonData[4]);
                dataMon.weakness = (Element)Enum.Parse(typeof(Element), consoleMonData[6]);

                Console.WriteLine($"Name: " + dataMon.pokemonName);
                Console.WriteLine($"Health: " + dataMon.health);
                Console.WriteLine($"Energy: " + dataMon.energy);
                Console.WriteLine($"Weakness: " + dataMon.weakness);
            }
        }

        internal List<ConsoleMon> LoadJson(string datafile)
        {
            string json = File.ReadAllText("monsterdata.json");

            List<ConsoleMon> templates = JsonSerializer.Deserialize<List<ConsoleMon>>(json);
            Console.WriteLine(templates[0].pokemonName);

            return templates;
        }
    }
}
