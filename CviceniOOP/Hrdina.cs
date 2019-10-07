using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CviceniOOP
{
    class Hrdina:Bytost
    {
        public Hrdina(int HP, int DMG)
        {
            this.HP = HP;
            this.DMG = DMG;
        }

        public void Utoci(Monstrum monstrum)
        {
            monstrum.DostalDMG(this.DMG);
        }

        public override string ZbyvajiciHP()
        {
            return "Hrdinovy zbiva " + this.HP + " HP.";
        }
    }
}
