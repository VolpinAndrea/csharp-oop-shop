// See https://aka.ms/new-console-template for more information
using CSharpShopBonus;

List<Prodotto> prodotti = new List<Prodotto>();

Prodotto pUno = new Prodotto("Salmone", "Fresco", 12.45, 3.6);
prodotti.Add(pUno);

prodotti.Add(new Prodotto("Torta", "Cioccolato", 3.654, 1.344243278472));

prodotti.Add((Prodotto)new Prodotto("Bicciere", "Vetro", 1, 1.1));
// me lo sugerisce con tab ma è ridondante (poi lo cerca di correggere)

foreach(Prodotto elemento in prodotti)
{
    elemento.stampaTutto();
}