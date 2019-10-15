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
        protected int Shield;

        public void DostalDMG(int DMG)
        {
            if (this.Shield <= 0)
            {
                this.HP = this.HP - DMG;
            }
            else
            { 
                this.Shield = this.Shield - DMG;
            }
        }

        public virtual string ZbyvajiciHP()
        {
            return "Bytosti zbiva " + this.HP + " HP a " + this.Shield + " stitu.";
        }

        public bool Mrtvy()
        {
            if (this.HP <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
