using System.Xml.Serialization;

namespace Program{

    class MainMenu {
        private string champOrigin;
        public string ChampionOrigin () {
            
            bool running = false;
            do {
                Console.WriteLine("1.Ionia");
                Console.WriteLine("2.Demacia");
                Console.WriteLine(" \nUpišite broj region-a koju želite uzeti");  

                string key = Console.ReadLine();
                int odabir = key == "" ? 0 : int.Parse(key);

                if (odabir == 1) {
                    Console.WriteLine("\nOdabrali ste region: Ionia");
                    champOrigin = "Ionia";
                    running = false;
                }  
                else if (odabir == 2) {
                    Console.WriteLine("\nOdabrali ste region: Demacia");
                    champOrigin = "Demacia";
                    running = false;
                }
                else {
                    Console.WriteLine("\nNedozvoljeni unos! Probajte ponovno!");
                    Environment.Exit(0);
                }

            } while (running);

            return champOrigin;
        }
        public string ChampionIme() {
            
            string ime;
            bool running = true;
            do {
                Console.WriteLine("\n***********************************************");
                Console.WriteLine("\nUpišite ime championa: ");
                ime = Console.ReadLine();

                if(ime == null || ime == "" ) {

                    Console.WriteLine("\nError! Niste unijeli ime championa. Probajte ponovno!");
                }
                else {
                    running = false;
                }
            } while (running);

            return ime;
        }
    }
}
