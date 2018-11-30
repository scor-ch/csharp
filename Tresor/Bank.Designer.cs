namespace Tresor
{
    partial class Bank
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bank));
            this.open = new System.Windows.Forms.Button();
            this.verlassen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(12, 12);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(121, 23);
            this.open.TabIndex = 0;
            this.open.Text = "Schliessfach eröffnen";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.Open_Click);
            // 
            // verlassen
            // 
            this.verlassen.Location = new System.Drawing.Point(140, 12);
            this.verlassen.Name = "verlassen";
            this.verlassen.Size = new System.Drawing.Size(99, 23);
            this.verlassen.TabIndex = 1;
            this.verlassen.Text = "Bank verlassen";
            this.verlassen.UseVisualStyleBackColor = true;
            this.verlassen.Click += new System.EventHandler(this.Verlassen_Click);
            // 
            // Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 44);
            this.Controls.Add(this.verlassen);
            this.Controls.Add(this.open);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Bank";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button exitBank;
        private System.Windows.Forms.Button verlassen;
    }
}

