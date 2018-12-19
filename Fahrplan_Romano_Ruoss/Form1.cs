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


namespace Fahrplan_Romano_Ruoss
{
    public partial class Form1 : Form
    {
        
       

        public Form1()
        {
        
            InitializeComponent();
            
        }

        private void btnSuchen_Click(object sender, EventArgs e)
        {
            var transport = new Transport();
            string Start = txtstar.Text;
            string End = txtend.Text;
            string time = txtZeit.Text;
            string date = txtDatum.Text;

            if (time != null)
            {
                var Listconnection = transport.getdate
            }
        }

        private void btnswitch_Click(object sender, EventArgs e)
        {
            string nach = txtend.Text;
            string von = txtstar.Text;

            txtstar.Text = nach;
            txtend.Text = von;
        }

        private void txtstar_TextChanged(object sender, EventArgs e)
        {

        }
    }
           
        }

       

        

        

   
    

    
           
        

    
