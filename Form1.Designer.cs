namespace gemeinsamesPROJEKTv2
{
    partial class Form1
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
            this.btnUmwandeln = new System.Windows.Forms.Button();
            this.txtEingabe = new System.Windows.Forms.TextBox();
            this.txtAusgabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUmwandeln
            // 
            this.btnUmwandeln.Location = new System.Drawing.Point(158, 12);
            this.btnUmwandeln.Name = "btnUmwandeln";
            this.btnUmwandeln.Size = new System.Drawing.Size(113, 23);
            this.btnUmwandeln.TabIndex = 0;
            this.btnUmwandeln.Text = "Umwandeln";
            this.btnUmwandeln.UseVisualStyleBackColor = true;
            this.btnUmwandeln.Click += new System.EventHandler(this.BtnUmwandeln_Click);
            // 
            // txtEingabe
            // 
            this.txtEingabe.Location = new System.Drawing.Point(29, 13);
            this.txtEingabe.Name = "txtEingabe";
            this.txtEingabe.Size = new System.Drawing.Size(100, 22);
            this.txtEingabe.TabIndex = 1;
            // 
            // txtAusgabe
            // 
            this.txtAusgabe.Location = new System.Drawing.Point(29, 41);
            this.txtAusgabe.Name = "txtAusgabe";
            this.txtAusgabe.Size = new System.Drawing.Size(100, 22);
            this.txtAusgabe.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 89);
            this.Controls.Add(this.txtAusgabe);
            this.Controls.Add(this.txtEingabe);
            this.Controls.Add(this.btnUmwandeln);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUmwandeln;
        private System.Windows.Forms.TextBox txtEingabe;
        private System.Windows.Forms.TextBox txtAusgabe;
    }
}

