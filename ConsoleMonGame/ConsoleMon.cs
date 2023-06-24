using System;

namespace ConsoleMonGame
{
	internal class ConsoleMon
	{
		public int health;
		public int energy;
		public string? pokemonName; // "Umm non-nullable field 'name' must con-" SHUT UUUUUUUUUUUUUUUP

		private List<Skill>? skills; // At this point verklaar ik ze gwn nullable om die kut lijntjes weg te halen, sorry not sorry ¯\_(ツ)_/¯

		internal Element weakness;

		public void ConsoleMon2()
		{
			// whats poppin
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
