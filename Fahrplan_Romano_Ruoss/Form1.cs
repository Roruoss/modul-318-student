using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;
using System.Net.Mail;


namespace Fahrplan_Romano_Ruoss
{
    public partial class Form1 : Form
    {
        Transport transport = new Transport();
        Coordinate coordinate = new Coordinate();


        public Form1()
        {

            InitializeComponent();

        }
        private void Get_Stations(string text, ListBox listbox)
        {
            if (text.Length >= 3)
            {
                listbox.Items.Clear();
                Stations stations = transport.GetStations(text);
                foreach (Station station in stations.StationList)
                {
                    listbox.Items.Add(station.Name);
                    listbox.Visible = true;
                    listbox.BringToFront();
                }

            }
        }
        //Methode um Tabelle in DataGrip zu erstellen
        public string Get_TablefromDataGrid()
        {
            StringBuilder strTable = new StringBuilder();
            try
            {
                strTable.Append("<table border='1' cellpadding='0' cellspacing='0'>");
                strTable.Append("<tr>");
                foreach (DataGridViewColumn col in dtgVerbindungen.Columns)
                {
                    strTable.AppendFormat("<th>{0}</th>", col.HeaderText);
                }
                strTable.Append("</tr>");
                for (int i = 0; i < dtgVerbindungen.Rows.Count; i++)
                {
                    strTable.Append("<tr>");
                    foreach (DataGridViewCell cell in dtgVerbindungen.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            strTable.AppendFormat("<td>{0}</td>", cell.Value.ToString());
                        }
                    }
                    strTable.Append("</tr>");
                }
                strTable.Append("</table>");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return strTable.ToString();


        }//Methode für das Erstellen von Attributen einer Tabelle um Verbindungen zu suchen
        private void GetGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            lbLaden.Visible = true;
            DataTable dttConnections = new DataTable();
            dttConnections.Columns.Add("Datum");
            dttConnections.Columns.Add("Von");
            dttConnections.Columns.Add("Abfahrt");
            dttConnections.Columns.Add("Nach");
            dttConnections.Columns.Add("Ankunft");
            dttConnections.Columns.Add("Gleis");

            Connections connections = transport.GetConnections(txtStart.Text, txtEnd.Text, dtDatum.Value.ToString("yyyy-MM-dd"), dtZeit.Text);
            //Jedes Resultat wird zur Liste hinzugefügt
            foreach (Connection connection in connections.ConnectionList)
            {
                dttConnections.Rows.Add(GetDatum(connection.From.Departure), connection.From.Station.Name, GetTime(connection.From.Departure), connection.To.Station.Name, GetTime(connection.To.Arrival), connection.To.Platform);
            }
            dtgVerbindungen.DataSource = dttConnections;
            lbLaden.Visible = false;
            UseWaitCursor = false;



        }//Methode für die Abfahrtstafel-Tabelle
        private void GetGrid2()
        {
            DataTable dttRoutes = new DataTable();
            dttRoutes.Columns.Add("Zeit");
            dttRoutes.Columns.Add("Nach");
            dttRoutes.Columns.Add("Linie");

            Station station = transport.GetStations(txtStart.Text).StationList.First();
            StationBoardRoot departures = transport.GetStationBoard(station.Name, station.Id);

            foreach (StationBoard stationA in departures.Entries)
            {
                dttRoutes.Rows.Add(GetTime(stationA.Stop.Departure.ToString()), stationA.To, (stationA.Category + "" + stationA.Number));

            }
            dtgVerbindungen.DataSource = dttRoutes;
        }

        private string GetDatum(string datum1)
        {
            string datum2 = datum1.Remove(10);
            DateTime datum3 = Convert.ToDateTime(datum2);
            return datum3.ToString("dd.MM.yyyy");
        }

        private string GetTime(string Zeit1)
        {
            string Zeit2 = Zeit1.Remove(0, 11);
            Zeit2 = Zeit2.Remove(5);
            return Zeit2;
        }






        //Methode um Google Maps anzeigen zu lassen
        private void Create_GooglemapStation(string x, string y)
        {
            string url = "https://www.google.ch/maps/place/" + x + "," + y;
            WBGMaps.Navigate(url);
        }

        //Event um Verbindungen zu suchen
        private void btnSuchen_Click(object sender, EventArgs e)
        {
            if (txtStart.Text != string.Empty)
            {
                GetGrid();
            }
            else
            {
                MessageBox.Show("Bitte geben sie beide Orte an!", "error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Event um Applikation zu schliessen
        private void btnSchliessen_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Daten werden an die Textbox "von" hinzugegeben
        private void txtStart_TextChanged(object sender, EventArgs e)
        {
            Get_Stations(txtStart.Text, lsbStart);
        }

        private void txtEnd_TextChanged(object sender, EventArgs e)
        {
            Get_Stations(txtEnd.Text, lsbEnd);
        }
        //Event um Daten anzuzeigen von DataGrid2 (Abfahrtstafel)
        private void btnAbfahrtstafel_Click(object sender, EventArgs e)
        {
            {
                if (btnAbfahrtstafel.Text != string.Empty)
                {
                    GetGrid2();
                }
                else
                {
                    MessageBox.Show("Bitte geben Sie einen Ort ein!");
                }
            }
        }
        //Die eingegebenden Daten in der Abfahrtsstation werden in dieser Liste hinüber angezeigt
        private void lsbStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStart.Text = lsbStart.SelectedItem.ToString();
            btnSuchen.Focus();
            lsbStart.Visible = false;
        }

        private void lsbEnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEnd.Text = lsbEnd.SelectedItem.ToString();
            btnSuchen.Focus();
            lsbEnd.Visible = false;
        }
        //Event um die Haltestelle auf Google Maps anzuzeigen
        private void btnGoogleMaps_Click(object sender, EventArgs e)
        {
            if (txtStart.Text != string.Empty)
            {
                Stations stations = transport.GetStations(txtStart.Text);
                Station station = stations.StationList[0];


                Create_GooglemapStation(Convert.ToString(station.Coordinate.XCoordinate).Replace(',', '.'), Convert.ToString(station.Coordinate.YCoordinate).Replace(',', '.'));
                WBGMaps.Visible = true;
                btnSchliessen.Visible = true;
            }
            else
            {
                MessageBox.Show("Bitte geben Sie einen Ort ein");
            }
        }
        //Beide Standorte wechseln
        private void lbswitch_Click(object sender, EventArgs e)
        {
            string von = txtStart.Text;
            string nach = txtEnd.Text;

            txtEnd.Text = von;
            txtStart.Text = nach;
        }
        //Event um Fahrplan bzw Anzeigetafel per Email zu senden
        private void btnEmail_Click(object sender, EventArgs e)
        {
            if (txtMail.Text == "")

                MessageBox.Show("Bitte geben Sie eine Email-Adresse eingeben");
            else {
                try
                {
                    MailMessage email = new MailMessage();
                    email.From = new MailAddress("m318.rossi@gmail.com");
                    email.To.Add(new MailAddress(Convert.ToString(this.txtMail)));
                    email.Subject = "Fahrplan";
                    email.Body = "Deine Fahrplandaten wurden erfolgreich übermittelt.";
                    email.Body += "<b>" + Get_TablefromDataGrid() + "</b>";
                    email.IsBodyHtml = true;
                    SmtpClient SmtpServer = new SmtpClient();
                    SmtpServer.Host = "smtp.gmail.com";
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("m318.rossi@gmail.com", "hacksbro95");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(email);
                    MessageBox.Show("Dein Email wurde erfolgreich gesendet");



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }
    }
}
        
    









    
    
    
       

    

   

       

        

        

   
    

    
           
        

    
