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
        Kunde neuerKunde = null;
        public Kunde NeuerKunde1
        {
            get { return neuerKunde; }
            set { neuerKunde = value; }
        }

        public NeuerKunde()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //neues Objekt erzeugen
            //Daten aus Textbox
        }

        private void buttonAbbruch_Click(object sender, EventArgs e)
        {

        }
    }
}
