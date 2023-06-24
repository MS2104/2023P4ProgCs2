using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        internal Element element;


        internal void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.DepleteEnergy(energyCost);
            target.TakeDamage(damage);
            if (target.weakness == element)
            {
                target.TakeDamage(damage / 2);
            }

            /* Bij les 8 kreeg ik de hele tijd
             * 
             * false
             * true
             * 
             * in de console te zien, ik zat een half uur uit te vogelen wat ik verkeerd had gedaan
             * totdat ik erachter kwam dat DepleteEnergy maar 10 energy aftrok ipv 20...
             * 
             * Ik ben echt zo extreem intelligent. 
             */
        }
    }
}
