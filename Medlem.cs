using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sejlklub
{
    public class Medlem : Bruger
    {

        //Felter - instance fields(attributter)
        private string email;
        private int telefonNr;
      
        //Konstruktør
        public Medlem(string email, int telefonNr) : base() 
        {
            this.email = email;
            this.telefonNr = telefonNr;
        }


        //Properties

        //Get and set for EMAIL
        public string Email

        {
            get { return email; }
            set { email = value; }
        }

        //Get and set for TELEFONNR
        public int TelefonNr
        {
            get { return telefonNr; }
            set {  telefonNr = value; }
        }


        //Methods
        public string KontaktInfo()
        {
            return $"Email: {email}, Tlf: {telefonNr}";
        }



    }
}
