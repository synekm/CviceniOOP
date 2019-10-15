using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CviceniOOP
{
    class Hra
    {
        public void SpustitHru()
        {
            Console.WriteLine();
            Console.WriteLine("--------------Zacatek Boje--------------");
            Console.WriteLine();

            int HPMonstra = 10;
            int HPHrdiny = 100;
            int UtokMonstra = 6;
            int UtokHrdiny = 12;
            int ShieldMonstra = 1;
            int ShieldHrdiny = 1000;
            int PocetZabitychMonster = 0;

            Hrdina hrdina = new Hrdina(HPHrdiny, UtokHrdiny, ShieldHrdiny);
            Monstrum monstrum = new Monstrum(HPMonstra, UtokMonstra, ShieldMonstra);

            while (!hrdina.Mrtvy())
            {
                hrdina.Utoci(monstrum);
                monstrum.Utoci(hrdina);
                Console.WriteLine(monstrum.ZbyvajiciHP());
                Console.WriteLine(hrdina.ZbyvajiciHP());

                if (monstrum.Mrtvy() == true)
                {
                    Console.WriteLine("Monstrum umrelo.");
                    monstrum = new Monstrum(++HPMonstra, ++UtokMonstra, ShieldMonstra);
                    PocetZabitychMonster++;
                }
            }

            if (hrdina.Mrtvy() == true)
            {
                Console.WriteLine("Hrdina zemrel.");
                Console.WriteLine();
                Console.WriteLine("--------------Konec Boje--------------");
                Console.WriteLine();
                Console.WriteLine("Hrdina zabil " + PocetZabitychMonster + " monster.");
                Console.ReadLine();
            }
        }
    }
}
