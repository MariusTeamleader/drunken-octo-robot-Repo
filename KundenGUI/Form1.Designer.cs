namespace KundenGUI
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
            this.anzeigenKundenButton = new System.Windows.Forms.Button();
            this.comboBoxKunde = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKundenID = new System.Windows.Forms.TextBox();
            this.textBoxVorname = new System.Windows.Forms.TextBox();
            this.textBoxNachname = new System.Windows.Forms.TextBox();
            this.textBoxGebDat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonNeu = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // anzeigenKundenButton
            // 
            this.anzeigenKundenButton.Location = new System.Drawing.Point(12, 12);
            this.anzeigenKundenButton.Name = "anzeigenKundenButton";
            this.anzeigenKundenButton.Size = new System.Drawing.Size(231, 23);
            this.anzeigenKundenButton.TabIndex = 1;
            this.anzeigenKundenButton.Text = "Kunden anzeigen";
            this.anzeigenKundenButton.UseVisualStyleBackColor = true;
            this.anzeigenKundenButton.Click += new System.EventHandler(this.anzeigenKundenButton_Click);
            // 
            // comboBoxKunde
            // 
            this.comboBoxKunde.FormattingEnabled = true;
            this.comboBoxKunde.Location = new System.Drawing.Point(12, 41);
            this.comboBoxKunde.Name = "comboBoxKunde";
            this.comboBoxKunde.Size = new System.Drawing.Size(231, 21);
            this.comboBoxKunde.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "KundenID";
            // 
            // textBoxKundenID
            // 
            this.textBoxKundenID.Location = new System.Drawing.Point(96, 68);
            this.textBoxKundenID.Name = "textBoxKundenID";
            this.textBoxKundenID.Size = new System.Drawing.Size(147, 20);
            this.textBoxKundenID.TabIndex = 4;
            // 
            // textBoxVorname
            // 
            this.textBoxVorname.Location = new System.Drawing.Point(96, 94);
            this.textBoxVorname.Name = "textBoxVorname";
            this.textBoxVorname.Size = new System.Drawing.Size(147, 20);
            this.textBoxVorname.TabIndex = 5;
            // 
            // textBoxNachname
            // 
            this.textBoxNachname.Location = new System.Drawing.Point(96, 120);
            this.textBoxNachname.Name = "textBoxNachname";
            this.textBoxNachname.Size = new System.Drawing.Size(147, 20);
            this.textBoxNachname.TabIndex = 6;
            // 
            // textBoxGebDat
            // 
            this.textBoxGebDat.Location = new System.Drawing.Point(96, 146);
            this.textBoxGebDat.Name = "textBoxGebDat";
            this.textBoxGebDat.Size = new System.Drawing.Size(147, 20);
            this.textBoxGebDat.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vorname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nachname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "GebDat";
            // 
            // buttonNeu
            // 
            this.buttonNeu.Location = new System.Drawing.Point(12, 176);
            this.buttonNeu.Name = "buttonNeu";
            this.buttonNeu.Size = new System.Drawing.Size(75, 23);
            this.buttonNeu.TabIndex = 11;
            this.buttonNeu.Text = "Neu";
            this.buttonNeu.UseVisualStyleBackColor = true;
            this.buttonNeu.Click += new System.EventHandler(this.buttonNeu_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 346);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(617, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 368);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonNeu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxGebDat);
            this.Controls.Add(this.textBoxNachname);
            this.Controls.Add(this.textBoxVorname);
            this.Controls.Add(this.textBoxKundenID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxKunde);
            this.Controls.Add(this.anzeigenKundenButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button anzeigenKundenButton;
        private System.Windows.Forms.ComboBox comboBoxKunde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKundenID;
        private System.Windows.Forms.TextBox textBoxVorname;
        private System.Windows.Forms.TextBox textBoxNachname;
        private System.Windows.Forms.TextBox textBoxGebDat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonNeu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

