using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tresor
{
    public partial class Bank : Form
    {
        public Bank()
        {
            InitializeComponent();
            // Tooltip zum "Schliessfach eröffnen" Knopf anzeigen
            ToolTip hilfeToolTip = new ToolTip();
            hilfeToolTip.SetToolTip(open, "Ein oder mehrere Schliessfächer eröffnen");
            hilfeToolTip.InitialDelay = 200;
        }

        // Programm verlassen auf Knopfdruck
        private void Verlassen_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        // Neuen Tresor auf Knopfdruck erzeugen
        private void Open_Click(object sender, EventArgs e)
        {            
            Tresor tresor = new Tresor();
            tresor.Show();
        }
    }
}
