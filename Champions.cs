namespace Program{

    class Champion {
        public string championOrigin;
        public string championName;

        public Champion(string championOrigin,string championName) {
            this.championOrigin=championOrigin;
            this.championName=championName;
        }

        public void print() {
            Console.WriteLine("Champion region:" + championOrigin + "\nChampion Name:" + championName);
        }
    }
}
