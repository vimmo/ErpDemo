
namespace ErpDemo
{
    partial class AnagraficaBase
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
            this.anagraficaMenuStrip = new System.Windows.Forms.MenuStrip();
            this.nuovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cercaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indietroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avantiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ultimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annullaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anagraficaMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // anagraficaMenuStrip
            // 
            this.anagraficaMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovoToolStripMenuItem,
            this.modificaToolStripMenuItem,
            this.eliminaToolStripMenuItem,
            this.cercaToolStripMenuItem,
            this.primoToolStripMenuItem,
            this.indietroToolStripMenuItem,
            this.avantiToolStripMenuItem,
            this.ultimoToolStripMenuItem,
            this.salvaToolStripMenuItem,
            this.annullaToolStripMenuItem});
            this.anagraficaMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.anagraficaMenuStrip.Name = "anagraficaMenuStrip";
            this.anagraficaMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.anagraficaMenuStrip.TabIndex = 0;
            this.anagraficaMenuStrip.Text = "menuStrip1";
            // 
            // nuovoToolStripMenuItem
            // 
            this.nuovoToolStripMenuItem.Name = "nuovoToolStripMenuItem";
            this.nuovoToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.nuovoToolStripMenuItem.Text = "Nuovo";
            this.nuovoToolStripMenuItem.Click += new System.EventHandler(this.nuovoToolStripMenuItem_Click);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.modificaToolStripMenuItem.Text = "Modifica";
            this.modificaToolStripMenuItem.Click += new System.EventHandler(this.modificaToolStripMenuItem_Click);
            // 
            // eliminaToolStripMenuItem
            // 
            this.eliminaToolStripMenuItem.Name = "eliminaToolStripMenuItem";
            this.eliminaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.eliminaToolStripMenuItem.Text = "Elimina";
            this.eliminaToolStripMenuItem.Click += new System.EventHandler(this.eliminaToolStripMenuItem_Click);
            // 
            // cercaToolStripMenuItem
            // 
            this.cercaToolStripMenuItem.Name = "cercaToolStripMenuItem";
            this.cercaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.cercaToolStripMenuItem.Text = "Cerca";
            this.cercaToolStripMenuItem.Click += new System.EventHandler(this.cercaToolStripMenuItem_Click);
            // 
            // primoToolStripMenuItem
            // 
            this.primoToolStripMenuItem.Name = "primoToolStripMenuItem";
            this.primoToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.primoToolStripMenuItem.Text = "<<";
            this.primoToolStripMenuItem.Click += new System.EventHandler(this.primoToolStripMenuItem_Click);
            // 
            // indietroToolStripMenuItem
            // 
            this.indietroToolStripMenuItem.Name = "indietroToolStripMenuItem";
            this.indietroToolStripMenuItem.Size = new System.Drawing.Size(27, 20);
            this.indietroToolStripMenuItem.Text = "<";
            this.indietroToolStripMenuItem.Click += new System.EventHandler(this.indietroToolStripMenuItem_Click);
            // 
            // avantiToolStripMenuItem
            // 
            this.avantiToolStripMenuItem.Name = "avantiToolStripMenuItem";
            this.avantiToolStripMenuItem.Size = new System.Drawing.Size(27, 20);
            this.avantiToolStripMenuItem.Text = ">";
            this.avantiToolStripMenuItem.Click += new System.EventHandler(this.avantiToolStripMenuItem_Click);
            // 
            // ultimoToolStripMenuItem
            // 
            this.ultimoToolStripMenuItem.Name = "ultimoToolStripMenuItem";
            this.ultimoToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.ultimoToolStripMenuItem.Text = ">>";
            this.ultimoToolStripMenuItem.Click += new System.EventHandler(this.ultimoToolStripMenuItem_Click);
            // 
            // salvaToolStripMenuItem
            // 
            this.salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            this.salvaToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.salvaToolStripMenuItem.Text = "Salva";
            this.salvaToolStripMenuItem.Click += new System.EventHandler(this.salvaToolStripMenuItem_Click);
            // 
            // annullaToolStripMenuItem
            // 
            this.annullaToolStripMenuItem.Name = "annullaToolStripMenuItem";
            this.annullaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.annullaToolStripMenuItem.Text = "Annulla";
            this.annullaToolStripMenuItem.Click += new System.EventHandler(this.annullaToolStripMenuItem_Click);
            // 
            // AnagraficaBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.anagraficaMenuStrip);
            this.MainMenuStrip = this.anagraficaMenuStrip;
            this.Name = "AnagraficaBase";
            this.Text = "AnagraficaBase";
            this.anagraficaMenuStrip.ResumeLayout(false);
            this.anagraficaMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip anagraficaMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem nuovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cercaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indietroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avantiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ultimoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annullaToolStripMenuItem;
    }
}