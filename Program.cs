/*int[] stranice = new int[2] {266,353};

Knjiga book = new Knjiga("Svijet", 1, "Mate Mikulić", stranice [0], true);
Knjiga book2 = new Knjiga("Moral", 3, "Mateja Mikulić", stranice [1], false);
Knjiga book3 = new Knjiga("Pravda", 3, "Mateo Mikulić", stranice [1], true);
Knjiga book4 = new Knjiga("Život", 3, "Matija Mikulić", stranice [1], true);
Knjiga book5 = new Knjiga("Mačak", 3, "Matea Mikulić", stranice [1], false);


List<Knjiga> booklist = new List<Knjiga>();
List<Knjiga> booklist2 = new List<Knjiga>();


booklist.Add(book);
booklist.Add(book2);
booklist.Add(book3);
booklist2.Add(book4);
booklist2.Add(book5);


PrintBook print = new PrintBook();
print.printBook(booklist);
print.printBook(booklist2);

/* Console.WriteLine("-----------------------------------------------");
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

class PrintBook {
    public void printBook (List<Knjiga>book) {
        //foreach loop
        foreach (Knjiga x in book) {
            Console.WriteLine("Ime ove knjige je: {0} ", x.naziv);
            Console.WriteLine("Verzija knjige: {0} ", x.verzija);
            Console.WriteLine("Autor: {0}", x.autor);
            Console.WriteLine("Broj stranica: {0}", x.stranice);
            Console.WriteLine("Spol autora: {0}", x.spol ? "Muško": "Žensko");
        }
    }
}

*/

Student ucenik = new Student ("Marko", 5, "Ekonomska škola");
Student ucenik2 = new Student ("Petar", 3, "Ekonomska škola");
Student ucenik3 = new Student ("Petra", 4, "Ekonomska škola");
Student ucenik4 = new Student ("Jelena", 5, "Ekonomska škola");


List<Student> uceniklist = new List<Student>();

uceniklist.Add(ucenik);
uceniklist.Add(ucenik2);
uceniklist.Add(ucenik3);
uceniklist.Add(ucenik4);

PrintBook printBook = new PrintBook();
printBook.printStudent(uceniklist);
class Student {
    public string ime;
    public int ocjena;
    public string skola;

    public Student (string ime, int ocjena, string skola) {
        this.ime = ime;
        this.ocjena = ocjena;
        this.skola = skola;

}
}

class PrintBook {
    public void printStudent (List<Student> ucenici) {
        foreach ( Student x in ucenici) {
            Console.WriteLine("Ime je: {0} ", x.ime);
            Console.WriteLine("Ocjena: {0} ", x.ocjena);
            Console.WriteLine("Skola: {0}", x.skola);
            Console.WriteLine("*************************************");
           
        }
    }
}