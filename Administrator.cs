using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sejlklub
{
    public class Administrator : Bruger
    {

        private string titel;
        private double løn;

        public Administrator(string navn, string titel, double løn) : base(navn)
        {
            this.titel = titel;
            this.løn = løn;
        }
        public string Titel
        {
            get { return titel; }
            set { titel = value; }
        }

        public double Løn
        {
            get { return løn; }
            set { løn = value; }
        }

        public void ÆndreBeskrivelse(Begivenhed begivenhed, string nyBeskrivelse)
        {
            begivenhed.Beskrivelse = nyBeskrivelse;
        }

        public void ÆndreNavn(Begivenhed begivenhed, string nytNavn)
        {
            begivenhed.Name = nytNavn;
        }

        public void ÆndreSted(Begivenhed begivenhed, string nytSted)
        {
            begivenhed.Sted = nytSted;
        }

        public void ÆndreDato(Begivenhed begivenhed, int nyDato)
        {
            begivenhed.Dato = nyDato;
        }





    }
}
