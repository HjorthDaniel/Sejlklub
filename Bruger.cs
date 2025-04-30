using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sejlklub
{
    public abstract class Bruger //klassenavn
    {
        //Felter - instance fields(attributter)
        static int nextID = 1;
        private int id;
        private string navn;
        private string email;
        private int telefonNr;

        //Konstruktør
        public Bruger(string Navn, string email, int telefonNr)
        {
            this.id = nextID++;
            this.navn = Navn;
            this.email = email;
            this.telefonNr = telefonNr;
        }

        //Properties
        // get betyder hent
        // set betyder ændre værdien til noget andet (f.eks. brugerId)

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        //Get and set NAVN
        public string Navn
        {
            get { return this.navn; }
            set { this.navn = value; }
        }
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
            set { telefonNr = value; }
        }
        //Metoder


    }

}
