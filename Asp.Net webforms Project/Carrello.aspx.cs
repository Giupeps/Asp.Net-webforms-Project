using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net_webforms_Project
{
    public partial class Carrello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Prodotto.Carrello.Count != 0)
                {
                    double totale = 0;
                    foreach (Prodotto item in Prodotto.Carrello)
                    {
                        totale += item.Prezzo;

                    }
                    Totale.Text = totale.ToString("c2");
                }


                GrigliaCarrello.DataSource = Prodotto.Carrello;
                GrigliaCarrello.DataBind();
            }
        }

        protected void Svuota(object sender, EventArgs e)
        {
            Prodotto.Carrello.Clear();
            GrigliaCarrello.Visible= false;
            Totale.Text = 0.ToString();
        }
    }
}