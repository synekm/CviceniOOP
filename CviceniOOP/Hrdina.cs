using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CviceniOOP
{
    class Hrdina
    {

        private int HP;
        private int DMG;


        public Hrdina(int HP, int DMG)
        {
            this.HP = HP;
            this.DMG = DMG;
        }

        public void DostalDMG(int DMG)
        {
            this.HP = this.HP - DMG;
        }

        public void Utoci(Monstrum monstrum)
        {
            monstrum.DostalDMG(this.DMG);
        }

        public string ZbyvajiciHP()
        {
            return "Hrdinovy zbiva " + this.HP + " HP.";
        }

        public bool JeMrtvy()
        {
            if (this.HP <= 0)
                return true;
            else
                return false;
        }
    }
}
