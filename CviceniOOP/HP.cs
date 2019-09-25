using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CviceniOOP
{
    class HP
    {
        public float KonecneHPMonster()
        {
            int ZakladniHP = 10;
            if (Level.LevelHry == 1000)
                return (int)(ZakladniHP);
            else
                return (float)(ZakladniHP * 1 + (Level.LevelHry / 2));
            
        }

        public float HrdinovoHP()
        {
            int ZakladniHPHrdiny = 100;
            return (float)(ZakladniHPHrdiny + Level.LevelHry);
        }
    }
}
