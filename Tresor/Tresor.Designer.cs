namespace Tresor
{
    partial class Tresor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tresor));
            this.zahlenBox = new System.Windows.Forms.GroupBox();
            this.hilfe = new System.Windows.Forms.Button();
            this.oeffnen = new System.Windows.Forms.Button();
            this.setzen = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.zuruecksetzen = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.anzeige = new System.Windows.Forms.TextBox();
            this.schliessfach = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.AutoOeffnungCheckbox = new System.Windows.Forms.CheckBox();
            this.SoundsCheckbox = new System.Windows.Forms.CheckBox();
            this.zahlenBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // zahlenBox
            // 
            this.zahlenBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.zahlenBox.Controls.Add(this.hilfe);
            this.zahlenBox.Controls.Add(this.oeffnen);
            this.zahlenBox.Controls.Add(this.setzen);
            this.zahlenBox.Controls.Add(this.button10);
            this.zahlenBox.Controls.Add(this.zuruecksetzen);
            this.zahlenBox.Controls.Add(this.button7);
            this.zahlenBox.Controls.Add(this.button8);
            this.zahlenBox.Controls.Add(this.button9);
            this.zahlenBox.Controls.Add(this.button4);
            this.zahlenBox.Controls.Add(this.button5);
            this.zahlenBox.Controls.Add(this.button6);
            this.zahlenBox.Controls.Add(this.button3);
            this.zahlenBox.Controls.Add(this.button2);
            this.zahlenBox.Controls.Add(this.button1);
            this.zahlenBox.Font = new System.Drawing.Font("Consolas", 12F);
            this.zahlenBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.zahlenBox.Location = new System.Drawing.Point(281, 13);
            this.zahlenBox.Name = "zahlenBox";
            this.zahlenBox.Size = new System.Drawing.Size(150, 259);
            this.zahlenBox.TabIndex = 0;
            this.zahlenBox.TabStop = false;
            this.zahlenBox.Text = "Tresor c2018+";
            // 
            // hilfe
            // 
            this.hilfe.Location = new System.Drawing.Point(6, 163);
            this.hilfe.Name = "hilfe";
            this.hilfe.Size = new System.Drawing.Size(40, 40);
            this.hilfe.TabIndex = 25;
            this.hilfe.Text = "?";
            this.hilfe.UseVisualStyleBackColor = true;
            this.hilfe.Click += new System.EventHandler(this.Hilfe_Click);
            // 
            // oeffnen
            // 
            this.oeffnen.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oeffnen.Location = new System.Drawing.Point(71, 209);
            this.oeffnen.Name = "oeffnen";
            this.oeffnen.Size = new System.Drawing.Size(67, 40);
            this.oeffnen.TabIndex = 24;
            this.oeffnen.Text = "OEFFNEN";
            this.oeffnen.UseVisualStyleBackColor = true;
            this.oeffnen.Click += new System.EventHandler(this.oeffnen_Click);
            // 
            // setzen
            // 
            this.setzen.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setzen.Location = new System.Drawing.Point(6, 209);
            this.setzen.Name = "setzen";
            this.setzen.Size = new System.Drawing.Size(67, 40);
            this.setzen.TabIndex = 23;
            this.setzen.Text = "EINGABE";
            this.setzen.UseVisualStyleBackColor = true;
            this.setzen.Click += new System.EventHandler(this.setOrC_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(52, 163);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(40, 40);
            this.button10.TabIndex = 20;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Knopf_Click);
            // 
            // zuruecksetzen
            // 
            this.zuruecksetzen.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zuruecksetzen.Location = new System.Drawing.Point(98, 163);
            this.zuruecksetzen.Name = "zuruecksetzen";
            this.zuruecksetzen.Size = new System.Drawing.Size(40, 40);
            this.zuruecksetzen.TabIndex = 21;
            this.zuruecksetzen.Text = "C";
            this.zuruecksetzen.UseVisualStyleBackColor = true;
            this.zuruecksetzen.Click += new System.EventHandler(this.setOrC_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(98, 117);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 40);
            this.button7.TabIndex = 19;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Knopf_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(52, 117);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 40);
            this.button8.TabIndex = 18;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Knopf_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(6, 117);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(40, 40);
            this.button9.TabIndex = 17;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Knopf_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(98, 71);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 16;
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Knopf_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(52, 71);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 40);
            this.button5.TabIndex = 15;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Knopf_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(6, 71);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 40);
            this.button6.TabIndex = 14;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Knopf_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(98, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 13;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Knopf_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(52, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Knopf_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Knopf_Click);
            // 
            // anzeige
            // 
            this.anzeige.Font = new System.Drawing.Font("Consolas", 12F);
            this.anzeige.Location = new System.Drawing.Point(281, 278);
            this.anzeige.Name = "anzeige";
            this.anzeige.ReadOnly = true;
            this.anzeige.Size = new System.Drawing.Size(150, 26);
            this.anzeige.TabIndex = 1;
            this.anzeige.Text = "0000";
            this.anzeige.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // schliessfach
            // 
            this.schliessfach.AllowDrop = true;
            this.schliessfach.Location = new System.Drawing.Point(11, 38);
            this.schliessfach.Name = "schliessfach";
            this.schliessfach.Size = new System.Drawing.Size(264, 265);
            this.schliessfach.TabIndex = 2;
            // 
            // AutoOeffnungCheckbox
            // 
            this.AutoOeffnungCheckbox.AutoSize = true;
            this.AutoOeffnungCheckbox.Location = new System.Drawing.Point(11, 13);
            this.AutoOeffnungCheckbox.Margin = new System.Windows.Forms.Padding(1);
            this.AutoOeffnungCheckbox.Name = "AutoOeffnungCheckbox";
            this.AutoOeffnungCheckbox.Size = new System.Drawing.Size(100, 17);
            this.AutoOeffnungCheckbox.TabIndex = 3;
            this.AutoOeffnungCheckbox.Text = "Autom. Öffnung";
            this.AutoOeffnungCheckbox.UseVisualStyleBackColor = true;
            this.AutoOeffnungCheckbox.CheckedChanged += new System.EventHandler(this.AutoOeffnen_CheckedChanged);
            // 
            // SoundsCheckbox
            // 
            this.SoundsCheckbox.AutoSize = true;
            this.SoundsCheckbox.Location = new System.Drawing.Point(135, 13);
            this.SoundsCheckbox.Name = "SoundsCheckbox";
            this.SoundsCheckbox.Size = new System.Drawing.Size(62, 17);
            this.SoundsCheckbox.TabIndex = 4;
            this.SoundsCheckbox.Text = "Sounds";
            this.SoundsCheckbox.UseVisualStyleBackColor = true;
            this.SoundsCheckbox.CheckedChanged += new System.EventHandler(this.Sounds_CheckedChanged);
            // 
            // Tresor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(438, 310);
            this.Controls.Add(this.SoundsCheckbox);
            this.Controls.Add(this.AutoOeffnungCheckbox);
            this.Controls.Add(this.schliessfach);
            this.Controls.Add(this.anzeige);
            this.Controls.Add(this.zahlenBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Tresor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tresor";
            this.zahlenBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox zahlenBox;
        private System.Windows.Forms.Button zuruecksetzen;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox anzeige;
        private System.Windows.Forms.Panel schliessfach;
        private System.Windows.Forms.Button oeffnen;
        private System.Windows.Forms.Button setzen;
        private System.Windows.Forms.Button hilfe;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox AutoOeffnungCheckbox;
        private System.Windows.Forms.CheckBox SoundsCheckbox;
    }
}