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
        }

        private void verlassen_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void open_Click(object sender, EventArgs e)
        {
            Tresor tresor = new Tresor();
            tresor.Show();
        }
    }
}
