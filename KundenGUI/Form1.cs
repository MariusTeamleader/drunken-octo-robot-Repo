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
            lstKunde = dto.getAlleKunden();
            comboBoxKunde.DataSource = lstKunde;
            DataBinding();
        }
        private void DataBinding()
        {
            textBoxKundenID.DataBindings.Add("Text", lstKunde, "KundenID");
            textBoxVorname.DataBindings.Add("Text", lstKunde, "Vorname");
            textBoxNachname.DataBindings.Add("Text", lstKunde, "Name");
            textBoxGebDat.DataBindings.Add("Text", lstKunde, "GebDat");
        }

        private void buttonNeu_Click(object sender, EventArgs e)
        {
            NeuerKunde nk = new NeuerKunde();
            nk.Show();
        }
    }
}
