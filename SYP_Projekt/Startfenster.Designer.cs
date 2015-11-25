namespace SYP_Projekt
{
    partial class frmMenueFenster
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uebersichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rahmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.umsatzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jahrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jahreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sonstigesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lagerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rahmenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.leistenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liefernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRechnungErstellen = new System.Windows.Forms.Button();
            this.btnBestellungErfassen = new System.Windows.Forms.Button();
            this.btnRahmenHinzufuegen = new System.Windows.Forms.Button();
            this.btnLeistenBestellen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.uebersichtToolStripMenuItem,
            this.bearbeitenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // uebersichtToolStripMenuItem
            // 
            this.uebersichtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rahmenToolStripMenuItem,
            this.umsatzToolStripMenuItem,
            this.statistikToolStripMenuItem,
            this.sonstigesToolStripMenuItem});
            this.uebersichtToolStripMenuItem.Name = "uebersichtToolStripMenuItem";
            this.uebersichtToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.uebersichtToolStripMenuItem.Text = "Uebersicht";
            // 
            // rahmenToolStripMenuItem
            // 
            this.rahmenToolStripMenuItem.Name = "rahmenToolStripMenuItem";
            this.rahmenToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.rahmenToolStripMenuItem.Text = "Rahmen und Leisten";
            this.rahmenToolStripMenuItem.Click += new System.EventHandler(this.rahmenToolStripMenuItem_Click);
            // 
            // umsatzToolStripMenuItem
            // 
            this.umsatzToolStripMenuItem.Name = "umsatzToolStripMenuItem";
            this.umsatzToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.umsatzToolStripMenuItem.Text = "Umsatz";
            // 
            // statistikToolStripMenuItem
            // 
            this.statistikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monatToolStripMenuItem,
            this.jahrToolStripMenuItem,
            this.jahreToolStripMenuItem});
            this.statistikToolStripMenuItem.Name = "statistikToolStripMenuItem";
            this.statistikToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.statistikToolStripMenuItem.Text = "Statistik";
            // 
            // monatToolStripMenuItem
            // 
            this.monatToolStripMenuItem.Name = "monatToolStripMenuItem";
            this.monatToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.monatToolStripMenuItem.Text = "Monat";
            // 
            // jahrToolStripMenuItem
            // 
            this.jahrToolStripMenuItem.Name = "jahrToolStripMenuItem";
            this.jahrToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.jahrToolStripMenuItem.Text = "Jahr";
            // 
            // jahreToolStripMenuItem
            // 
            this.jahreToolStripMenuItem.Name = "jahreToolStripMenuItem";
            this.jahreToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.jahreToolStripMenuItem.Text = "Jahre";
            // 
            // sonstigesToolStripMenuItem
            // 
            this.sonstigesToolStripMenuItem.Name = "sonstigesToolStripMenuItem";
            this.sonstigesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.sonstigesToolStripMenuItem.Text = "Sonstiges";
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lagerToolStripMenuItem1,
            this.liefernToolStripMenuItem,
            this.preiseToolStripMenuItem});
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // lagerToolStripMenuItem1
            // 
            this.lagerToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rahmenToolStripMenuItem1,
            this.leistenToolStripMenuItem});
            this.lagerToolStripMenuItem1.Name = "lagerToolStripMenuItem1";
            this.lagerToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.lagerToolStripMenuItem1.Text = "Lager";
            // 
            // rahmenToolStripMenuItem1
            // 
            this.rahmenToolStripMenuItem1.Name = "rahmenToolStripMenuItem1";
            this.rahmenToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.rahmenToolStripMenuItem1.Text = "Rahmen ";
            // 
            // leistenToolStripMenuItem
            // 
            this.leistenToolStripMenuItem.Name = "leistenToolStripMenuItem";
            this.leistenToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.leistenToolStripMenuItem.Text = "Leisten";
            // 
            // liefernToolStripMenuItem
            // 
            this.liefernToolStripMenuItem.Name = "liefernToolStripMenuItem";
            this.liefernToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.liefernToolStripMenuItem.Text = "Liefern";
            // 
            // preiseToolStripMenuItem
            // 
            this.preiseToolStripMenuItem.Name = "preiseToolStripMenuItem";
            this.preiseToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.preiseToolStripMenuItem.Text = "Preise";
            this.preiseToolStripMenuItem.Click += new System.EventHandler(this.preiseToolStripMenuItem_Click);
            // 
            // btnRechnungErstellen
            // 
            this.btnRechnungErstellen.BackColor = System.Drawing.SystemColors.Window;
            this.btnRechnungErstellen.ForeColor = System.Drawing.Color.Navy;
            this.btnRechnungErstellen.Location = new System.Drawing.Point(170, 28);
            this.btnRechnungErstellen.Name = "btnRechnungErstellen";
            this.btnRechnungErstellen.Size = new System.Drawing.Size(144, 62);
            this.btnRechnungErstellen.TabIndex = 2;
            this.btnRechnungErstellen.Text = "Rechnung erstellen";
            this.btnRechnungErstellen.UseVisualStyleBackColor = false;
            this.btnRechnungErstellen.Click += new System.EventHandler(this.btnRechnungErstellen_Click);
            // 
            // btnBestellungErfassen
            // 
            this.btnBestellungErfassen.BackColor = System.Drawing.SystemColors.Window;
            this.btnBestellungErfassen.ForeColor = System.Drawing.Color.Navy;
            this.btnBestellungErfassen.Location = new System.Drawing.Point(321, 28);
            this.btnBestellungErfassen.Name = "btnBestellungErfassen";
            this.btnBestellungErfassen.Size = new System.Drawing.Size(156, 62);
            this.btnBestellungErfassen.TabIndex = 3;
            this.btnBestellungErfassen.Text = "Bestellung erfassen";
            this.btnBestellungErfassen.UseVisualStyleBackColor = false;
            this.btnBestellungErfassen.Click += new System.EventHandler(this.btnBestellungErfassen_Click);
            // 
            // btnRahmenHinzufuegen
            // 
            this.btnRahmenHinzufuegen.BackColor = System.Drawing.SystemColors.Window;
            this.btnRahmenHinzufuegen.ForeColor = System.Drawing.Color.Navy;
            this.btnRahmenHinzufuegen.Location = new System.Drawing.Point(170, 96);
            this.btnRahmenHinzufuegen.Name = "btnRahmenHinzufuegen";
            this.btnRahmenHinzufuegen.Size = new System.Drawing.Size(144, 59);
            this.btnRahmenHinzufuegen.TabIndex = 4;
            this.btnRahmenHinzufuegen.Text = "Rahmen hinzufuegen";
            this.btnRahmenHinzufuegen.UseVisualStyleBackColor = false;
            this.btnRahmenHinzufuegen.Click += new System.EventHandler(this.btnRahmenHinzufuegen_Click);
            // 
            // btnLeistenBestellen
            // 
            this.btnLeistenBestellen.BackColor = System.Drawing.SystemColors.Window;
            this.btnLeistenBestellen.ForeColor = System.Drawing.Color.Navy;
            this.btnLeistenBestellen.Location = new System.Drawing.Point(321, 96);
            this.btnLeistenBestellen.Name = "btnLeistenBestellen";
            this.btnLeistenBestellen.Size = new System.Drawing.Size(156, 59);
            this.btnLeistenBestellen.TabIndex = 5;
            this.btnLeistenBestellen.Text = "Leisten bestellen";
            this.btnLeistenBestellen.UseVisualStyleBackColor = false;
            this.btnLeistenBestellen.Click += new System.EventHandler(this.btnLeistenBestellen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SYP_Projekt.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmMenueFenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 381);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLeistenBestellen);
            this.Controls.Add(this.btnRahmenHinzufuegen);
            this.Controls.Add(this.btnBestellungErfassen);
            this.Controls.Add(this.btnRechnungErstellen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenueFenster";
            this.Text = "Verwaltung";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uebersichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rahmenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem umsatzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistikToolStripMenuItem;
        private System.Windows.Forms.Button btnRechnungErstellen;
        private System.Windows.Forms.Button btnBestellungErfassen;
        private System.Windows.Forms.Button btnRahmenHinzufuegen;
        private System.Windows.Forms.Button btnLeistenBestellen;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lagerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rahmenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem leistenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sonstigesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liefernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jahrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jahreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preiseToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

