using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CviceniOOP
{
    class Monstrum:Bytost
    {
        public Monstrum(int HP, int DMG)
        {
            this.HP = HP;
            this.DMG = DMG;
        }

        public void Utoci(Hrdina hrdina)
        {
            hrdina.DostalDMG(this.DMG);
        }

        public override string ZbyvajiciHP()
        {
            return "Monstrum zbiva " + this.HP + " HP.";
        }
    }
}
