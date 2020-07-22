using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp71
{
    delegate void Ability();

    class Rubic
    {
        Ability SpellAbility;
        public void SpellSteal(Ability ability) 
        {
            Console.WriteLine($"\nАнимация воровства... {ability.GetInvocationList()[0].Method.Name}\n");
            SpellAbility = ability; 
        }

        public void UseSkill() 
        {
            Console.Write("Rubic использует ");
            SpellAbility();
        }
    }

    class AniMag
    {
        public void Blink() { Console.WriteLine("AniMag.Blink"); }
        
    }


    class Zeus
    {
        public void LightninkBolt() { Console.WriteLine("Zeus.LightninkBolt"); }
    }

    class EartShaker
    {
        public void Fissure() { Console.WriteLine("EartShaker.Fissure"); }

    }
}
