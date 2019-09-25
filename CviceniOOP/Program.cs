using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CviceniOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------Zacatek Boje--------------");

            Hrdina a = new Hrdina(HP.HrdinovoHP);
            Monstrum a1 = new Monstrum(HP.KonecneHPMonster);
        }
    }
}
