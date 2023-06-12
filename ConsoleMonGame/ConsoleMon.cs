using System;

namespace ConsoleMonGame
{
	internal class ConsoleMon
	{
		public int health;
		public int energy;
		public string? pokemonName; // "Umm non-nullable field 'name' must con-" SHUT UUUUUUUUUUUUUUUP

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
			this.energy -= 10;
		}
	}

}
