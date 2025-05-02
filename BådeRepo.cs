using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sejlklub
{
    public class BådeRepo
    {
        List<Både> bådeList = new List<Både>();

        public bool Add(Både båd)
        {
            bådeList.Add(båd);
            return true;
        }
        public List<Både> GetAll()
        {
            return bådeList;
        }
        public Både Get(int sejlnummer)
        {
            foreach (Både båd in bådeList)
            {
                if (båd.Sejlnummer == sejlnummer)

                { return båd; }
            }
            Console.WriteLine("Båden blev ikke fundet");
            return null;



        }
    }
}
