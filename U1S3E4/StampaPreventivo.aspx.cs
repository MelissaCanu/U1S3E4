using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace U1S3E4
{
    public partial class StampaPreventivo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // Se la pagina non è stata ricaricata dopo un postback (ad esempio dopo aver premuto un pulsante)
            {
                // Recupero i valori passati tramite query string e li visualizzo nei controlli della pagina
                string auto = Request.QueryString["auto"];
                string prezzoBase = Request.QueryString["prezzoBase"];
                string optional = Request.QueryString["optional"];
                string garanzia = Request.QueryString["garanzia"];
                string prezzoFinale = Request.QueryString["prezzoFinale"];

                lblAuto.Text = auto;
                lblPrezzoBase.Text = prezzoBase;
                lblOptional.Text = optional;
                lblGaranzia.Text = garanzia;
                lblPrezzoFinale.Text = prezzoFinale;
            }
        }
    }
}