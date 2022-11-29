using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop
{
    internal class Prodotto
    {
        private int codice;
        private string nome;
        private string descrizione;
        private double prezzo;
        private double iva;

        Random RandomClass = new Random();
        /*Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random.*/
        public Prodotto() 
        {
            this.codice = RandomClass.Next(1, 10000);
        }

        public Prodotto(string nome, string descrizione, double prezzo, double iva):this()
        {
            this.nome = nome;   
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }
        /*Il codice prodotto sia accessibile solo in lettura
Gli altri attributi siano accessibili sia in lettura che in scrittura*/
        public int getCodice()
        {
            return this.codice;
        }

        public string getNome()
        {
            return this.nome;
        }
        public void setNome(string newNome)
        {
            this.nome = newNome;
        }

        public string getDescrizione()
        {
            return this.descrizione;
        }
        public void setDescrizione(string newDescrizione)
        {
            this.descrizione = newDescrizione;
        }

        public double getPrezzo()
        {
            return this.prezzo;
        }
        public void setPrezzo(double newPrezzo)
        {
            this.prezzo = newPrezzo;
        }
            public double getIva()
        {
            return this.iva;
        }
        public void setIva(double newIva)
        {
            this.iva = newIva;
        }

        /*Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva.*/
        public double prezzoIva()
        {
            return this.prezzo+this.iva;
        }
        public string nomeEsteso() 
        { 
            return this.codice + this.nome;
        }

        public void stampaTutto()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Codice: " + this.codice);
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Descrizione: " + descrizione); // senza this apposta
            Console.WriteLine("Prezzo: " + this.prezzo);
            Console.WriteLine("IVA: " + this.iva);
            Console.WriteLine("Prezo con IVA : " + string.Format("{0:F2}", prezzoIva())); // taglia di decimali ma trasforma in string
            Console.WriteLine("Nome esteso: " + nomeEsteso());

        }


    }
}
