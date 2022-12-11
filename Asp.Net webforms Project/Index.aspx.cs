using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net_webforms_Project
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Prodotto.GetProdotti().Clear();
                Prodotto.GetProdotti();
                RepeaterGuitar.DataSource = Prodotto.ListaProdotti;
                RepeaterGuitar.DataBind();
                
            }
        }

       
    }
}