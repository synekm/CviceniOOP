using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CviceniOOP
{
    class Monstrum
    {
        private int CisloMonstra = 0;
        static public List<Monstrum> SeznamMonster;



        public Monstrum()
        {
            int CisloMonstra = 1;
            for (int i = 0; i < SeznamMonster.Count; i++)
            {

                SeznamMonster[i].CisloMonstra = CisloMonstra;
                CisloMonstra++;
                Console.WriteLine(SeznamMonster[i].CisloMonstra);
            }
        }
    }
}
