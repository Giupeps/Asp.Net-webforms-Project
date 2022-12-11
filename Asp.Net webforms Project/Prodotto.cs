using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp.Net_webforms_Project
{
    public class Prodotto
    {
        public int IdProdotto { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; } 
        public string Immagine { get; set; }
        public double Prezzo { get; set; }

        public static List<Prodotto> ListaProdotti { get; set; } = new List<Prodotto>();
        public static List<Prodotto> Carrello { get; set; } = new List<Prodotto>();

        public static List<Prodotto> GetProdotti()
        {
           Prodotto prodotto1 = new Prodotto { IdProdotto = 1, Nome = "Fender Ritchie Blackmore Strat", Descrizione = "Fender Stratocaster Ritchie Blackmoure Signature, bianco olimpico", Immagine = "~/Images/FenderBlackmoure.jpg", Prezzo = 1433.00 };
            Prodotto prodotto2 = new Prodotto { IdProdotto = 2, Nome = "Fender Clapton Strat", Descrizione = "Fender Stratocaster Signature Eric Clapton Pewter", Immagine = "~/Images/FenderClapton.jpg", Prezzo = 2499.00 };
            Prodotto prodotto3 = new Prodotto { IdProdotto = 3, Nome = "Gibson Les Paul Slash Standard", Descrizione = "Gibson Les Paul Slash signature model Made in USA", Immagine = "~/Images/GibsonSlash.jpg", Prezzo = 2699.00 };
            Prodotto prodotto4 = new Prodotto { IdProdotto = 4, Nome = "Ibanez Andy Timmons", Descrizione = "Ibanez ATZ10P-STM Andy Timmons", Immagine = "~/Images/IbanezTimmon.jpg", Prezzo = 1469.00 };
            Prodotto prodotto5 = new Prodotto { IdProdotto = 5, Nome = "Ibanez TQM", Descrizione = "Ibanez TQM1-NT Tom Quayle signature model, Natural Color", Immagine = "~/Images/IbanezTQM1.jpg", Prezzo = 2333.00 };
            Prodotto prodotto6 = new Prodotto { IdProdotto = 6, Nome = "PRS SE Silver Sky Stone Blue", Descrizione = "PRS SE Silver Sky Stone Blue John Mayer Signature Model Stone blue color", Immagine = "~/Images/prs.jpg", Prezzo = 999.00 };
            ListaProdotti.Add(prodotto1);
            ListaProdotti.Add(prodotto2);
            ListaProdotti.Add(prodotto3);
            ListaProdotti.Add(prodotto4);
            ListaProdotti.Add(prodotto5);
            ListaProdotti.Add(prodotto6);
            return ListaProdotti;
        }
    }
}