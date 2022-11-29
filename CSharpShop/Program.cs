﻿// See https://aka.ms/new-console-template for more information

/*Nel progetto CSharpShop , creare la classe Prodotto che gestisce i prodotti del vostro shop.
Un prodotto è caratterizzato da:
codice (numero intero)
nome
descrizione
prezzo
iva
Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random.
Il codice prodotto sia accessibile solo in lettura
Gli altri attributi siano accessibili sia in lettura che in scrittura
Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva.
Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
Testate poi i vostri oggetti Prodotto, istanziandoli e provando ad interagirci con loro per testare tutti i metodi che avete previsto e implementato.
BONUS:
create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)
Usando una List, dichiarate una lista dei prodotti di un negozio e inseriteci al suo interno qualche prodotto che vi aspettate di trovare nel negozio. Stampate poi l’elenco dei vostri prodotti che avete previsto nel negozio.
Buon lavoro!*/
using CSharpShop;

Prodotto pUno = new Prodotto();
pUno.stampaTutto();
pUno.setNome("pane");
pUno.setDescrizione("caldo");
pUno.setPrezzo(3.5);
pUno.setIva(1.1);
pUno.stampaTutto();

Prodotto pDue = new Prodotto("Salmone", "Fresco", 12.45, 3.6);
pDue.stampaTutto();
pDue.setDescrizione("affumicato");
pDue.setPrezzo(8.12);
pDue.stampaTutto();
