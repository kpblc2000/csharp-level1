using ConsoleApp71;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dota2
{
    class Program
    {
        static void Main(string[] args)
        {

            Rubic rubic = new Rubic();
            AniMag aniMag = new AniMag();
            Zeus zeus = new Zeus();
            EartShaker eartShaker = new EartShaker();

            aniMag.Blink();
            zeus.LightninkBolt();
            eartShaker.Fissure();

            rubic.SpellSteal(aniMag.Blink);
            rubic.UseSkill();

            rubic.SpellSteal(zeus.LightninkBolt);
            rubic.UseSkill();

            rubic.SpellSteal(eartShaker.Fissure);
            rubic.UseSkill();
        }
    }
}
