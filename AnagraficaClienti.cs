using ErpDemoEF.Models;
using ErpDemoEF.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErpDemo
{
    public partial class AnagraficaClienti : AnagraficaBase
    {
        private readonly DBClientiService _db;
        public AnagraficaClienti()
        {
            InitializeComponent();
            txtId.Enabled = false;
            ChangeFieldsState();

            _db = new DBClientiService();
        }
        private void ChangeFieldsState()
        {
            txtRagioneSociale.Enabled = (DOCUMENT_MODE != _DOC_MODE.BROWSE);
            txtIndirizzo.Enabled = (DOCUMENT_MODE != _DOC_MODE.BROWSE);
            txtCitta.Enabled = (DOCUMENT_MODE != _DOC_MODE.BROWSE);
            txtSettore.Enabled = (DOCUMENT_MODE != _DOC_MODE.BROWSE);
        }
        private void ChangeFieldsState(bool setReadOnly)
        {
            txtRagioneSociale.Enabled = setReadOnly;
            txtIndirizzo.Enabled = setReadOnly;
            txtCitta.Enabled = setReadOnly;
            txtSettore.Enabled = setReadOnly;
        }
        private void ClearData()
        {
            txtId.Clear();
            txtRagioneSociale.Clear();
            txtIndirizzo.Clear();
            txtCitta.Clear();
            txtSettore.Clear();
            lblRagSoc.ForeColor = Color.Black;
        }
        public override void OnNew()
        {
            ChangeFieldsState();
            ClearData();
        }
        public override void OnEdit()
        {
            ChangeFieldsState();
        }
        public override bool OnDelete()
        {
            bool bOk = true;
            if (MessageBox.Show("Confermi eliminazione?",
                "Elimina",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Exclamation) == DialogResult.OK)
                bOk = true;
            else
                bOk = false;

            if(bOk)
            {
                // fai qualcosa
                var cliente = new Clienti
                {
                    Id = Convert.ToInt32(txtId.Text),
                    RagioneSociale = txtRagioneSociale.Text,
                    Indirizzo = txtIndirizzo.Text,
                    Citta = txtCitta.Text,
                    Settore = txtSettore.Text
                };
                bOk = _db.EliminaCliente(cliente);
            }

            return bOk;
        }
        public override bool OnSave()
        {
            bool bOk = true;

            if (txtRagioneSociale.Text == "")
            {
                MessageBox.Show("Ragione sociale obbligatoria");
                txtRagioneSociale.Focus();
                lblRagSoc.ForeColor = Color.Red;
                return false;
            }

            if (MessageBox.Show("Salvare modifiche?",
                "Salva",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel)
                bOk = false;

            if (bOk)
            {
                var cliente = new Clienti
                {
                    Id = DOCUMENT_MODE == _DOC_MODE.NEW ? 0 : Convert.ToInt32(txtId.Text),
                    RagioneSociale = txtRagioneSociale.Text,
                    Indirizzo = txtIndirizzo.Text,
                    Citta = txtCitta.Text,
                    Settore = txtSettore.Text
                };
                if (DOCUMENT_MODE == _DOC_MODE.NEW)
                {
                    Clienti cli = _db.CreaCliente(cliente);
                    txtId.Text = cli.Id.ToString();
                    bOk = txtId.Text != "";
                }
                else
                {
                    bOk = _db.ModificaCliente(cliente);
                }
                
            }


            if (bOk)
                ChangeFieldsState(false);
            else
                MessageBox.Show(
                    "Errore in " + (DOCUMENT_MODE == _DOC_MODE.NEW ? "inserimento" : "modifica"),
                    "Errore",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);

            return bOk;
        }
        public override bool OnCancel()
        {
            bool bOk = true;

            if (MessageBox.Show("Annullare modifiche?",
                "Annulla",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
                bOk = false;

            if (bOk)
            {
                ChangeFieldsState(false);
                ClearData();
            }
            return bOk;
        }

        public override void OnFirst()
        {
            RiempiCampi(_db.LeggiCliente(false));
        }
        public override void OnLast()
        {
            RiempiCampi(_db.LeggiCliente(true));
        }

        private void RiempiCampi(Clienti cliente)
        {
            txtId.Text = cliente.Id.ToString();
            txtRagioneSociale.Text = cliente.RagioneSociale;
            txtIndirizzo.Text = cliente.Indirizzo;
            txtCitta.Text = cliente.Citta;
            txtSettore.Text = cliente.Settore;
        }



        private void txtRagioneSociale_Leave(object sender, EventArgs e)
        {
            if (txtRagioneSociale.Text == "")
                lblRagSoc.ForeColor = Color.Red;
            else
                lblRagSoc.ForeColor = Color.Black;

        }
    }
}
