namespace Gestione_campionato
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("");
            this.listPart = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_caricapartite = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aggiornaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listPart
            // 
            this.listPart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listPart.GridLines = true;
            this.listPart.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14});
            this.listPart.Location = new System.Drawing.Point(12, 27);
            this.listPart.Name = "listPart";
            this.listPart.Size = new System.Drawing.Size(517, 291);
            this.listPart.TabIndex = 1;
            this.listPart.UseCompatibleStateImageBehavior = false;
            this.listPart.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "N°";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Squadra in Casa";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Squadra Ospite";
            this.columnHeader3.Width = 109;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Goal squadra in casa";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Goal squadra ospite";
            this.columnHeader5.Width = 118;
            // 
            // btn_caricapartite
            // 
            this.btn_caricapartite.Location = new System.Drawing.Point(12, 324);
            this.btn_caricapartite.Name = "btn_caricapartite";
            this.btn_caricapartite.Size = new System.Drawing.Size(86, 42);
            this.btn_caricapartite.TabIndex = 3;
            this.btn_caricapartite.Text = "Carica partite";
            this.btn_caricapartite.UseVisualStyleBackColor = true;
            this.btn_caricapartite.Click += new System.EventHandler(this.btn_aggiorna_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operazioniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(583, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operazioniToolStripMenuItem
            // 
            this.operazioniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggiornaToolStripMenuItem});
            this.operazioniToolStripMenuItem.Name = "operazioniToolStripMenuItem";
            this.operazioniToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.operazioniToolStripMenuItem.Text = "Operazioni";
            // 
            // aggiornaToolStripMenuItem
            // 
            this.aggiornaToolStripMenuItem.Name = "aggiornaToolStripMenuItem";
            this.aggiornaToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.aggiornaToolStripMenuItem.Text = "Aggiorna";
            this.aggiornaToolStripMenuItem.Click += new System.EventHandler(this.aggiornaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 378);
            this.Controls.Add(this.btn_caricapartite);
            this.Controls.Add(this.listPart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listPart;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btn_carica;
        private System.Windows.Forms.Button btn_caricapartite;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aggiornaToolStripMenuItem;

    }
}

