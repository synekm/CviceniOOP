using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CviceniOOP
{
    class Bytost
    {
        public int HP { get; protected set; }
        public int DMG { get; protected set; }
        public int Shield { get; protected set; }

        public void DostalDMG(int DMG)
        {
            if (this.Shield <= 0)
            {
                this.HP = this.HP - DMG;
                this.Shield = 0;
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
