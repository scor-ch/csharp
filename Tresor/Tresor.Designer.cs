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
            this.open = new System.Windows.Forms.Button();
            this.set = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.schliessfach = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.autoOpen = new System.Windows.Forms.CheckBox();
            this.zahlenBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // zahlenBox
            // 
            this.zahlenBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.zahlenBox.Controls.Add(this.hilfe);
            this.zahlenBox.Controls.Add(this.open);
            this.zahlenBox.Controls.Add(this.set);
            this.zahlenBox.Controls.Add(this.button10);
            this.zahlenBox.Controls.Add(this.c);
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
            this.zahlenBox.Location = new System.Drawing.Point(656, 29);
            this.zahlenBox.Margin = new System.Windows.Forms.Padding(7);
            this.zahlenBox.Name = "zahlenBox";
            this.zahlenBox.Padding = new System.Windows.Forms.Padding(7);
            this.zahlenBox.Size = new System.Drawing.Size(350, 578);
            this.zahlenBox.TabIndex = 0;
            this.zahlenBox.TabStop = false;
            this.zahlenBox.Text = "Tresor c2018+";
            // 
            // hilfe
            // 
            this.hilfe.Location = new System.Drawing.Point(14, 364);
            this.hilfe.Margin = new System.Windows.Forms.Padding(7);
            this.hilfe.Name = "hilfe";
            this.hilfe.Size = new System.Drawing.Size(93, 89);
            this.hilfe.TabIndex = 25;
            this.hilfe.Text = "?";
            this.hilfe.UseVisualStyleBackColor = true;
            this.hilfe.Click += new System.EventHandler(this.Hilfe_Click);
            // 
            // open
            // 
            this.open.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open.Location = new System.Drawing.Point(166, 466);
            this.open.Margin = new System.Windows.Forms.Padding(7);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(156, 89);
            this.open.TabIndex = 24;
            this.open.Text = "OPEN";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // set
            // 
            this.set.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set.Location = new System.Drawing.Point(14, 466);
            this.set.Margin = new System.Windows.Forms.Padding(7);
            this.set.Name = "set";
            this.set.Size = new System.Drawing.Size(156, 89);
            this.set.TabIndex = 23;
            this.set.Text = "SET";
            this.set.UseVisualStyleBackColor = true;
            this.set.Click += new System.EventHandler(this.setOrC_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(121, 364);
            this.button10.Margin = new System.Windows.Forms.Padding(7);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(93, 89);
            this.button10.TabIndex = 20;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button_Click);
            // 
            // c
            // 
            this.c.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.Location = new System.Drawing.Point(229, 364);
            this.c.Margin = new System.Windows.Forms.Padding(7);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(93, 89);
            this.c.TabIndex = 21;
            this.c.Text = "C";
            this.c.UseVisualStyleBackColor = true;
            this.c.Click += new System.EventHandler(this.setOrC_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(229, 261);
            this.button7.Margin = new System.Windows.Forms.Padding(7);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(93, 89);
            this.button7.TabIndex = 19;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(121, 261);
            this.button8.Margin = new System.Windows.Forms.Padding(7);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(93, 89);
            this.button8.TabIndex = 18;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(14, 261);
            this.button9.Margin = new System.Windows.Forms.Padding(7);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(93, 89);
            this.button9.TabIndex = 17;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(229, 158);
            this.button4.Margin = new System.Windows.Forms.Padding(7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 89);
            this.button4.TabIndex = 16;
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(121, 158);
            this.button5.Margin = new System.Windows.Forms.Padding(7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 89);
            this.button5.TabIndex = 15;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(14, 158);
            this.button6.Margin = new System.Windows.Forms.Padding(7);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 89);
            this.button6.TabIndex = 14;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(229, 56);
            this.button3.Margin = new System.Windows.Forms.Padding(7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 89);
            this.button3.TabIndex = 13;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(121, 56);
            this.button2.Margin = new System.Windows.Forms.Padding(7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 89);
            this.button2.TabIndex = 12;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(14, 56);
            this.button1.Margin = new System.Windows.Forms.Padding(7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 89);
            this.button1.TabIndex = 11;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // display
            // 
            this.display.Font = new System.Drawing.Font("Consolas", 12F);
            this.display.Location = new System.Drawing.Point(656, 620);
            this.display.Margin = new System.Windows.Forms.Padding(7);
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.Size = new System.Drawing.Size(345, 50);
            this.display.TabIndex = 1;
            this.display.Text = "0000";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // schliessfach
            // 
            this.schliessfach.AllowDrop = true;
            this.schliessfach.Location = new System.Drawing.Point(26, 85);
            this.schliessfach.Margin = new System.Windows.Forms.Padding(7);
            this.schliessfach.Name = "schliessfach";
            this.schliessfach.Size = new System.Drawing.Size(616, 591);
            this.schliessfach.TabIndex = 2;
            // 
            // autoOpen
            // 
            this.autoOpen.AutoSize = true;
            this.autoOpen.Location = new System.Drawing.Point(26, 29);
            this.autoOpen.Name = "autoOpen";
            this.autoOpen.Size = new System.Drawing.Size(209, 33);
            this.autoOpen.TabIndex = 3;
            this.autoOpen.Text = "Autom. Öffnung";
            this.autoOpen.UseVisualStyleBackColor = true;
            this.autoOpen.CheckedChanged += new System.EventHandler(this.autoOpen_CheckedChanged);
            // 
            // Tresor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1022, 692);
            this.Controls.Add(this.autoOpen);
            this.Controls.Add(this.schliessfach);
            this.Controls.Add(this.display);
            this.Controls.Add(this.zahlenBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
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
        private System.Windows.Forms.Button c;
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
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Panel schliessfach;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button set;
        private System.Windows.Forms.Button hilfe;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox autoOpen;
    }
}