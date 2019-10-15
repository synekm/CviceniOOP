using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CviceniOOP
{
    class Hrdina:Bytost
    {
        public Hrdina(int HP, int DMG, int Shield)
        {
            this.HP = HP;
            this.DMG = DMG;
            this.Shield = Shield;
        }

        public void Utoci(Monstrum monstrum)
        {
            monstrum.DostalDMG(this.DMG);
        }

        public override string ZbyvajiciHP()
        {
            return "Hrdinovy zbiva " + this.HP + " HP a " + this.Shield + " stitu.";
        }
    }
}
