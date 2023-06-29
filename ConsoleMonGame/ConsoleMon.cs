using System;

namespace ConsoleMonGame
{
	internal class ConsoleMon
	{
		public int health {  get; set; }
		public int energy { get; set; }
		public string? pokemonName { get; set; } // "Umm non-nullable field 'name' must con-" SHUT UUUUUUUUUUUUUUUP

        public List<Skill> skills { get; set; } // At this point verklaar ik ze gwn nullable om die kut lijntjes weg te halen, sorry not sorry ¯\_(ツ)_/¯

        internal Element weakness;

        public ConsoleMon()
        {

        }

        internal ConsoleMon(int health, int energy, string name, Element weakness)
        {
            //opdracht 13
            this.energy = energy;
            this.pokemonName = name;
            this.weakness = weakness;
            this.health = health;
        }


        internal void TakeDamage(int damage)
		{
			health -= damage;
		}

		internal void DepleteEnergy(int energy)
		{
			this.energy -= 20;
		}
	}
}
