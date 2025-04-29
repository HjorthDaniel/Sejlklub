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

        //Konstruktør
        public Bruger(string Navn)
        {
            this.id = nextID++;
            this.navn = Navn;
        }
        
        //Properties
        // get betyder hent
        // set betyder ændre værdien til noget andet (f.eks. brugerId)
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Navn
        {
            get { return this.navn; }
            set { this.navn = value; }
        }
        //Metode

    
    }

}
