using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class Skill
    {
        internal int damage;
        internal int energyCost;
        string? name; // "Umm non-nullable field 'name' must con-" You are merely a machine, you do as I say so and will not speak without my permission.

        internal void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.energy -= energyCost;
            target.health -= damage;
        }
    }
}
