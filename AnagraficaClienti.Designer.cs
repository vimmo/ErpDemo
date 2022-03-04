
namespace ErpDemo
{
    partial class AnagraficaClienti
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRagioneSociale = new System.Windows.Forms.TextBox();
            this.lblRagSoc = new System.Windows.Forms.Label();
            this.txtIndirizzo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSettore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCitta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(105, 49);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(33, 20);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id";
            // 
            // txtRagioneSociale
            // 
            this.txtRagioneSociale.BackColor = System.Drawing.SystemColors.Window;
            this.txtRagioneSociale.Location = new System.Drawing.Point(105, 76);
            this.txtRagioneSociale.Multiline = true;
            this.txtRagioneSociale.Name = "txtRagioneSociale";
            this.txtRagioneSociale.Size = new System.Drawing.Size(265, 63);
            this.txtRagioneSociale.TabIndex = 3;
            this.txtRagioneSociale.Leave += new System.EventHandler(this.txtRagioneSociale_Leave);
            // 
            // lblRagSoc
            // 
            this.lblRagSoc.AutoSize = true;
            this.lblRagSoc.Location = new System.Drawing.Point(16, 79);
            this.lblRagSoc.Name = "lblRagSoc";
            this.lblRagSoc.Size = new System.Drawing.Size(83, 13);
            this.lblRagSoc.TabIndex = 4;
            this.lblRagSoc.Text = "Ragione sociale";
            // 
            // txtIndirizzo
            // 
            this.txtIndirizzo.Location = new System.Drawing.Point(105, 145);
            this.txtIndirizzo.Name = "txtIndirizzo";
            this.txtIndirizzo.Size = new System.Drawing.Size(265, 20);
            this.txtIndirizzo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "lndirizzo";
            // 
            // txtSettore
            // 
            this.txtSettore.Location = new System.Drawing.Point(105, 197);
            this.txtSettore.Name = "txtSettore";
            this.txtSettore.Size = new System.Drawing.Size(100, 20);
            this.txtSettore.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Settore";
            // 
            // txtCitta
            // 
            this.txtCitta.Location = new System.Drawing.Point(105, 171);
            this.txtCitta.Name = "txtCitta";
            this.txtCitta.Size = new System.Drawing.Size(100, 20);
            this.txtCitta.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Città";
            // 
            // AnagraficaClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCitta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSettore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIndirizzo);
            this.Controls.Add(this.lblRagSoc);
            this.Controls.Add(this.txtRagioneSociale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AnagraficaClienti";
            this.Text = "Anagrafica Clienti";
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtRagioneSociale, 0);
            this.Controls.SetChildIndex(this.lblRagSoc, 0);
            this.Controls.SetChildIndex(this.txtIndirizzo, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtSettore, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtCitta, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRagioneSociale;
        private System.Windows.Forms.Label lblRagSoc;
        private System.Windows.Forms.TextBox txtIndirizzo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSettore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCitta;
        private System.Windows.Forms.Label label5;
    }
}