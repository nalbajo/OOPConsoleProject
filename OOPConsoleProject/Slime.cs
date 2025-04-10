using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleProject
{
    public class Slime : Monster
    {
        public Slime(Vector2 position) : base('S', position, false)
        {
            name = "슬라임";
            description = "말캉말캉한 슬라임입니다. 공격성은 없습니다.";
            hp = 1;
            power = 0;

            if (hp == 0)
            {
                isOnce = true;
            }
        }
    }
}
