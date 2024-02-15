using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace U1S3E4
{
    public partial class Preventivo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //metodo per mostrare l'immagine e il prezzo basea quando si seleziona un'auto dalla dropdownlist ddlAuto

        protected void ddlAuto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //se l'auto viene selezionata mostro l'immagine e il prezzo base dell'auto in una card bootstrap, con uno switch case
            switch (ddlAuto.SelectedValue)
            {
                case "500":
                    imgAuto.ImageUrl = "~/Content/img/Fiat500.jpg";
                    lblPrezzoBase.Text = "Prezzo base: 30000€";
                    break;
                case "Panda":
                    imgAuto.ImageUrl = "~/Content/img/FiatPanda.jpg";
                    lblPrezzoBase.Text = "Prezzo base: 35000€";
                    break;
                case "Punto":
                    imgAuto.ImageUrl = "~/Content/img/FiatPunto.jpg";
                    lblPrezzoBase.Text = "Prezzo base: 20000€";
                    break;
                default:
                    imgAuto.ImageUrl = "";
                    lblPrezzoBase.Text = "";
                    break;
            }
        }

        //metodi per le checkbox degli optional e la dropdownlist della garanzia che richiamano il metodo CalcolaPreventivo per aggiornare il prezzo totale 
        protected void cbCerchi_CheckedChanged(object sender, EventArgs e)
        {
            CalcolaPreventivo();
        }

        protected void cbClima_CheckedChanged(object sender, EventArgs e)
        {
            CalcolaPreventivo();
        }

        protected void cbRadio_CheckedChanged(object sender, EventArgs e)
        {
            CalcolaPreventivo();
        }

        protected void ddlGaranzia_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcolaPreventivo(true);
        }


        //metodo per calcolare il preventivo in base agli optional selezionati dall'utente e mostrare il risultato
        private void CalcolaPreventivo(bool includeGaranzia = false)
        {
            double prezzo = 0;

            // Ottengo il prezzo base in base all'auto selezionata
            switch (ddlAuto.SelectedValue)
            {
                case "500":
                    prezzo += 30000;
                    break;
                case "Panda":
                    prezzo += 35000;
                    break;
                case "Punto":
                    prezzo += 20000;
                    break;
                default:
                    break;
            }

            // Aggiungo il costo degli optional
            if (cbCerchi.Checked)
            {
                prezzo += 500;
            }
            if (cbClima.Checked)
            {
                prezzo += 1000;
            }
            if (cbRadio.Checked)
            {
                prezzo += 800;
            }

            // Aggiungo il costo della garanzia se richiesto
            if (includeGaranzia)
            {
                switch (ddlGaranzia.SelectedValue)
                {
                    case "1":
                        prezzo += 500;
                        break;
                    case "2":
                        prezzo += 1000;
                        break;
                    case "3":
                        prezzo += 1500;
                        break;
                    default:
                        break;
                }
            }

            // Mostro il prezzo nella label lblPrezzoBase
            lblPrezzoBase.Text = "Prezzo totale: " + prezzo.ToString("C");
        }

        //metodo per stampare il preventivo finale in una nuova pagina
        protected void btnStampa_Click(object sender, EventArgs e)
        {
            // Recupera i valori necessari
            string auto = ddlAuto.SelectedItem.Text;
            string prezzoBase = lblPrezzoBase.Text;
            string optional = "";
            if (cbCerchi.Checked)
            {
                optional += "Cerchi in lega, ";
            }
            if (cbClima.Checked)
            {
                optional += "Climatizzatore, ";
            }
            if (cbRadio.Checked)
            {
                optional += "Radio, ";
            }
            string garanzia = ddlGaranzia.SelectedItem.Text;
            string prezzoFinale = lblPrezzoBase.Text;

            // Reindirizza alla pagina StampaPreventivo.aspx passando i parametri tramite query string che poi verranno visualizzati nella pagina stampapreventivo 
            Response.Redirect($"StampaPreventivo.aspx?auto={auto}&prezzoBase={prezzoBase}&optional={optional}&garanzia={garanzia}&prezzoFinale={prezzoFinale}");
        }






    }
}

