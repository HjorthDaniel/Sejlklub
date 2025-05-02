using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sejlklub
{
    public class MotorOplysningRepo
    {
        List<MotorOplysning> motorOplysningListe = new List<MotorOplysning>();

        public bool Add(MotorOplysning motorOplysning)
        {
            motorOplysningListe.Add(motorOplysning);
            return true;

        }
        public List<MotorOplysning> GetAll()
        {
            return motorOplysningListe;
        }
    }

}
