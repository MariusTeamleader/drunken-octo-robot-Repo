using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KundenGUI
{
    public partial class NeuerKunde : Form
    {
        DataTransfer kg = null;
        Kunde neuerKunde = null;
        public Kunde NeuerKunde1
        {
            get { return neuerKunde; }
            set { neuerKunde = value; }
        }

        public NeuerKunde(DataTransfer kg)
        {
            InitializeComponent();
            this.kg = kg;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //neues Objekt erzeugen
            //Daten aus Textbox
            neuerKunde = new Kunde();
            neuerKunde.KundenID = textBoxKundenID.Text;
            neuerKunde.Vorname = textBoxVorname.Text;
            neuerKunde.Name = textBoxNachname.Text;
            neuerKunde.GebDat = textBoxGebDat.Text;
            this.Dispose();
        }

        private void buttonAbbruch_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
