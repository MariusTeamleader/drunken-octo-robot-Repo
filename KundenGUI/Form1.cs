using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace KundenGUI
{
    public partial class Form1 : Form
    {
        List<Kunde> lstKunde = new List<Kunde>();
        DataTransfer dto = new DataTransfer();
        public Form1()
        {
            InitializeComponent();        
        }

        private void anzeigenKundenButton_Click(object sender, EventArgs e)
        {
            dto = null;
            dto = new DataTransfer();
            lstKunde = dto.getAlleKunden();         
            DataBinding();
        }
        private void DataBinding()
        {
            comboBoxKunde.DataSource = null;
            comboBoxKunde.DataSource = lstKunde;

            textBoxKundenID.DataBindings.Clear();
            textBoxVorname.DataBindings.Clear();
            textBoxNachname.DataBindings.Clear();
            textBoxGebDat.DataBindings.Clear();

            textBoxKundenID.DataBindings.Add("Text", lstKunde, "KundenID");
            textBoxVorname.DataBindings.Add("Text", lstKunde, "Vorname");
            textBoxNachname.DataBindings.Add("Text", lstKunde, "Name");
            textBoxGebDat.DataBindings.Add("Text", lstKunde, "GebDat");
        }

        private void buttonNeu_Click(object sender, EventArgs e)
        {
            NeuerKunde nk = new NeuerKunde(dto);
            nk.ShowDialog();
            if(nk.NeuerKunde1 != null)
            {
                if (dto.updateKunde(nk.NeuerKunde1) == true)
                { toolStripStatusLabel1.Text = "Gespeichert"; }
                else
                { toolStripStatusLabel1.Text = "Nicht Gespeichert"; }
                lstKunde.Add(nk.NeuerKunde1);
                DataBinding();
            }
            
        }
    }
}
