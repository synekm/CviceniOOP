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
            Console.WriteLine();
            Console.WriteLine("--------------Zacatek Boje--------------");
            Console.WriteLine();

            int HPMonstra = 10;

            Hrdina hrdina = new Hrdina(100, 12);
            Monstrum monstrum = new Monstrum(HPMonstra, 6);
            int PocetZabitychMonster = 0;

            while (hrdina.JeMrtvy() == false)
            {
                hrdina.Utoci(monstrum);
                monstrum.Utoci(hrdina);
                Console.WriteLine(monstrum.ZbyvajiciHP());
                Console.WriteLine(hrdina.ZbyvajiciHP());
                if (monstrum.JeMrtve() == true)
                {
                    Console.WriteLine("Monstrum umrelo.");
                    monstrum = new Monstrum(++HPMonstra, 6);
                    PocetZabitychMonster++;
                }
            }
            
            if (hrdina.JeMrtvy() == true)
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
