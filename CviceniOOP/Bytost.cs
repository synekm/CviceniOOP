using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CviceniOOP
{
    class Bytost
    {
        protected int HP;
        protected int DMG;

        public void DostalDMG(int DMG)
        {
            this.HP = this.HP - DMG;
        }

        public virtual string ZbyvajiciHP()
        {
            return "Bytosti zbiva " + this.HP + " HP.";
        }

        public bool Mrtvy()
        {
            if (this.HP <= 0)
                return true;
            else
                return false;
        }
    }
}
