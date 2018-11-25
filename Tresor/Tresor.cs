﻿using System;
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
    public partial class Tresor : Form

    {
        int gesetzterCode;
        int eingegebenerCode;
        bool codeSet = false;
        bool resetDisplayOk = true;
        bool tresorOpen = false;
        public Tresor()
        {
            InitializeComponent();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (resetDisplayOk == true)
            {
                display.Clear();
            }
            Button b = (Button)sender;
            display.Text = display.Text + b.Text;
            resetDisplayOk = false;
        }

        private void c_Click(object sender, EventArgs e)
        {

        }

        private void setOrC_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "SET" && display.Text != "0000" && this.codeSet == false)
            {
                gesetzterCode = Convert.ToInt32(display.Text);
                display.Text = "Code Saved";
                this.codeSet = true;
                this.resetDisplayOk = true;
            }
            else if (display.Text == "0000")
            {
                display.Text = "Invalid";
                this.resetDisplayOk = true;
            }
            else if (this.codeSet == true && b.Text == "SET")
            {
                display.Text = "Alter Code aktiv";
                this.resetDisplayOk = true;
            }
            else if (b.Text == "C")
            {
                this.eingegebenerCode = default(int);
                display.Text = "0000";
                this.resetDisplayOk = true;
            }
        }

        private void schliessfach_Paint(object sender, PaintEventArgs e)
        {
                schliessfach.Enabled = false;
                schliessfach.BackColor = Color.DarkRed;
        }

        private void open_Click(object sender, EventArgs e)
        {
            this.eingegebenerCode = Convert.ToInt32(display.Text);
            if (this.codeSet = true && eingegebenerCode == gesetzterCode)
            {
                display.Text = "Code Korrekt";
                this.codeSet = false;
                this.resetDisplayOk = true;
                this.tresorOpen = true;
            }
            else
            {
                display.Text = "Code Inkorrekt";
                this.codeSet = true;
                this.resetDisplayOk = true;
            }
        }
        private void griff_Click(object sender, EventArgs e)
        {
            if (this.tresorOpen == true)
            {
                griff.Visible = false;
                //griff.VisibleChanged += new EventHandler();
                schliessfach.Enabled = true;
                schliessfach.BackColor = Color.Green;

            }
        }

        private void hilfe_Click(object sender, EventArgs e)
        {
            if (this.codeSet == true)
            {
                display.Text = Convert.ToString("Code: " + gesetzterCode);
                this.resetDisplayOk = true;
            }
            else
                Console.WriteLine("Kein Code");
            this.resetDisplayOk = true;
        }
    }
}
