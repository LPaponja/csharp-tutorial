namespace Program {
    
    class Application {
        static void Main(string[] args) {

            MainMenu menu = new MainMenu();
            string kategorija = menu.ChampionOrigin();
            string ime = menu.ChampionIme();

            Champion player = new Champion(kategorija, ime);
            player.print();
        }
    }
}