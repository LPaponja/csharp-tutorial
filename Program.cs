int[] stranice = new int[2] {266,353};

Knjiga book = new Knjiga("Svijet", 1, "Mate Mikulić", stranice [0], true);
Knjiga book2 = new Knjiga("Moral", 3, "Mateja Mikulić", stranice [1], false);


Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Ime ove knjige je: {0} ", book.naziv);
Console.WriteLine("Verzija knjige: {0} ", book.verzija);
Console.WriteLine("Autor: {0}", book.autor);
Console.WriteLine("Broj stranica: {0}", book.stranice);
Console.WriteLine("Spol autora: {0}", book.spol ? "Muško": "Žensko");
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Ime ove knjige je; {0} ", book2.naziv);
Console.WriteLine("Verzija knjige: {0}", book2.verzija);
Console.WriteLine("Autor: {0}", book2.autor);
Console.WriteLine("Broj stranica: {0}", book2.stranice);
Console.WriteLine("Spol autora: {0}", book2.spol ? "Muško": "Žensko");
Console.WriteLine("-----------------------------------------------");

class Knjiga {
    public string naziv ; 
    public int verzija ;
    public string autor ;
    public int stranice ;
    public bool spol ;


    public Knjiga (string naziv, int verzija, string autor, int stranice, bool spol) {
        this.naziv = naziv;
        this.verzija = verzija;
        this.autor = autor;
        this.stranice = stranice;
        this.spol = spol;
}
}