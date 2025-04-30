using System.Reflection.Metadata;

namespace Sejlklub
{
    public class Program
    {
       
        static void Main(string[] args)
        {

            List <Begivenhed> begivenheder = new List <Begivenhed> ();

            List <Administrator> administrators = new List <Administrator> ();

            List <Medlem> medlemmer = new List <Medlem> ();

            List <Bruger> brugerlist = new List <Bruger> ();


            Bruger Admin1 = new Administrator("John", "Formand", 10000);
            Bruger Admin2 = new Administrator("Mathias", "vice-Formand", 15000);
            Bruger Medlem2 = new Medlem("Bob","Bob@gmail.com", 80807070);
            Bruger Medlem3 = new Medlem("Daniel", "Daniel@gmail.com", 90902020);

            administrators.Add((Administrator)Admin1);
            administrators.Add((Administrator)Admin2);
            medlemmer.Add((Medlem)Medlem2);
            medlemmer.Add((Medlem)Medlem3);
            brugerlist.Add((Administrator)Admin1);
            brugerlist.Add((Administrator)Admin2);
            brugerlist.Add((Medlem)Medlem2);
            brugerlist.Add((Medlem)Medlem3);


            Console.WriteLine(administrators);

            Console.WriteLine("Registrede brugere:");
            Console.WriteLine("");
            Console.WriteLine($"ID{Admin1.Id}: Navn:{Admin1.Navn}");
            Console.WriteLine($"ID{Admin2.Id}: Navn:{Admin2.Navn}");
            Console.WriteLine($"ID{Medlem2.Id}: Navn:{Medlem2.Navn}");
            Console.WriteLine($"ID{Medlem3.Id}: Navn:{Medlem3.Navn}");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Alle brugere (Inkl.):");


            foreach (Bruger bruger in brugerlist)
            {
     
                Console.WriteLine(bruger.ToString());

            }

            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Alle administrators:");
            foreach (Administrator administrator in administrators)
            {
                Console.WriteLine(administrator.ToString() );

            }

            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Alle Medlemmer");
            foreach (Medlem medlem in medlemmer)
            {
                Console.WriteLine(medlem.ToString() );
            }
            


        }
    }
}
