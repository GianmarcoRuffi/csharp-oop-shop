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


Prodotto libro = new Prodotto();



// classe prodotto
public class Prodotto
{

    //attributi

     int codice;
     string nome;
     string descrizione;
     double prezzo;
     int iva;

    public Prodotto()
    {
        Random random = new Random();
        codice = random.Next(1, 12345678);
    }

    // costruttore
    public Prodotto(string nome, string descrizione, float prezzo)
    {
        Random random = new Random();
        codice = random.Next(1, 12345678);
        this.nome = nome;
        this.descrizione = descrizione;
        this.prezzo = prezzo;
        iva = 22;
    }

}