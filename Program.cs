// Refactoring dell'esercizio utilizzando le property


Prodotto prodottoEsempio = new Prodotto("Romanzo giallo", "Un thriller mozzafiato.", 15.99);

Console.WriteLine("Codice ISBN: " + prodottoEsempio.Codice);
Console.WriteLine("Titolo del libro: " + prodottoEsempio.Nome);
Console.WriteLine("Descrizione: " + prodottoEsempio.Descrizione);
Console.WriteLine("Prezzo: " + prodottoEsempio.Prezzo + " euro");
Console.WriteLine("Iva applicabile: " + prodottoEsempio.Iva + " %");
Console.WriteLine("Prezzo con Iva: " + prodottoEsempio.GetPrezzoIvato() + " euro");
Console.WriteLine(prodottoEsempio.GetNomeCodice());


// classe prodotto
public class Prodotto

{

    //properties

    public int Codice { get; }
    public string Nome { get; set; }
    public string Descrizione { get; set; }
    public double Prezzo { get; set; }
    public int Iva { get; set; }
   

    // costruttore
    public Prodotto(string nome, string descrizione, double prezzo)
    {
        Random random = new Random();
        Codice = random.Next(1, 12345678);
        Nome = nome;
        Descrizione = descrizione;
        Prezzo = prezzo;
        Iva = 22;
    }



    // methods

    public double GetPrezzoIvato()
    {
        double prezzoIvato = Prezzo + (Prezzo / 100 * Iva);
        prezzoIvato = Math.Round(prezzoIvato, 2);

        return prezzoIvato;
    }
    public string GetNomeCodice()
    {
        return "Titolo del libro: " + Nome + " - " + "Codice: " + Codice;
    }

}



//Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop. Un prodotto è caratterizzato da:
//codice(numero intero)
//nome
//descrizione
//prezzo
//iva
//Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
//alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
//Il codice prodotto sia accessibile solo in lettura
//Gli altri attributi siano accessibili sia in lettura che in scrittura
//Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
//Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
//Nella vostro programma principale, testate tutte le funzionalità della classe Prodotto.
//BONUS: create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)


//Prodotto prodottoEsempio = new Prodotto("Romanzo giallo", "Un thriller mozzafiato.", 15.99);

//Console.WriteLine("Codice ISBN: " + prodottoEsempio.GetCodice());
//Console.WriteLine("Titolo del libro: " + prodottoEsempio.GetNome());
//Console.WriteLine("Descrizione: " + prodottoEsempio.GetDescrizione());
//Console.WriteLine("Prezzo: " + prodottoEsempio.GetPrezzo() + " euro");
//Console.WriteLine("Iva applicabile: " + prodottoEsempio.GetIva() + " %");
//Console.WriteLine("Prezzo con Iva: " + prodottoEsempio.GetPrezzoIvato() + " euro");
//Console.WriteLine(prodottoEsempio.GetNomeCodice());


//// classe prodotto
//public class Prodotto
//{

//    //attributi

//     int codice;
//     string nome;
//     string descrizione;
//     double prezzo;
//     int iva;
 

//    // costruttore
//    public Prodotto(string nome, string descrizione, double prezzo)
//    {
//        Random random = new Random();
//        codice = random.Next(1, 12345678);
//        this.nome = nome;
//        this.descrizione = descrizione;
//        this.prezzo = prezzo;
//        iva = 22;
//    }

//    // methods

//    public int GetCodice()
//    {
//        return codice;
//    }
//    public void SetNome(string nome)
//    {
//        this.nome = nome;
//    }
//    public string GetNome()
//    {
//        return nome;
//    }
//    public void SetDescrizione(string descrizione)
//    {
//        this.descrizione = descrizione;
//    }
//    public string GetDescrizione()
//    {
//        return descrizione;
//    }
//    public void SetPrezzo(double prezzo)
//    {
//        this.prezzo = prezzo;
//    }
//    public double GetPrezzo()
//    {
//        return prezzo;
//    }
//    public void SetIva(int iva)
//    {
//        this.iva = iva;
//    }

//    public int GetIva()
//    {
//        return iva;
//    }

//    public double GetPrezzoIvato()
//    {
//        double prezzoIvato = prezzo + (prezzo / 100 * iva);
//        prezzoIvato = Math.Round(prezzoIvato, 2);

//        return prezzoIvato;


//    }
//    public string GetNomeCodice()
//    {
//        return "Titolo del libro: " + nome + " - " + "Codice: " + codice;
//    }

//}

