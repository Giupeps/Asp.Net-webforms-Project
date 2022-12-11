using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net_webforms_Project
{
    public partial class Detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id= Request.QueryString["idprodotto"];
            foreach (Prodotto item in Prodotto.ListaProdotti)
            {
                if ( Convert.ToInt32(id) == item.IdProdotto )
                {
                    immagineProdotto.ImageUrl = item.Immagine;
                    titolo.InnerHtml = item.Nome;
                    descrizione.InnerHtml = item.Descrizione;
                    prezzo.InnerHtml = item.Prezzo.ToString("c2");
                }
            }


        }

        protected void AggiungiCarrello(object sender, EventArgs e)
        {
            string id = Request.QueryString["idprodotto"];
            foreach (Prodotto item in Prodotto.ListaProdotti)
            {
                if (item.IdProdotto == Convert.ToInt32(id))
                {
                    Prodotto.Carrello.Add(item);
                }
            }
        }
    }
}