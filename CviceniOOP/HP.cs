using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CviceniOOP
{
    class HP
    {
        static private HP

        public int KonecneHP()
        {
            int ZakladniHP = 10;
            if (Level == null)
                return (int)(ZakladniHP * 1);
            else
                return (decimal)(ZakladniHP * 1 + Level / 2);
            
        }

        public int HrdinovoHP()
        {
            int ZakladniHP = 100;
            return (int)(ZakladniHP + Level);
        }
    }
}
