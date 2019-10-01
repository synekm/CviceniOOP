using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CviceniOOP
{
    class Monstrum
    {


        private int HP;
        private int DMG;

        public Monstrum(int HP, int DMG)
        {
            this.HP = HP;
            this.DMG = DMG;
        }

        public void DostalDMG(int DMG)
        {
            this.HP = this.HP - DMG;
        }

        public void Utoci(Hrdina hrdina)
        {
            hrdina.DostalDMG(this.DMG);
        }

        public string ZbyvajiciHP()
        {
            return "Monstrum zbiva " + this.HP + " HP.";
        }

        public bool JeMrtve()
        {
            if (this.HP <= 0)
                return true;
            else
                return false;
        }
        
    }
}
