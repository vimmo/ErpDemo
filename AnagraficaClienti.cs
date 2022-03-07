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
        private readonly DBClientiService _dbClientiService;
        public AnagraficaClienti()
        {
            InitializeComponent();
            txtId.Enabled = false;
            ChangeFieldsState();
            _dbClientiService = new DBClientiService();
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

            IEnumerable<Clienti> a = _dbClientiService.GetClienti();

            foreach(Clienti clienti in a)
            {
                MessageBox.Show(clienti.RagioneSociale);
            }

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
               Clienti cliente = _dbClientiService.FindCliente(1009);
                // fai qualcosa
                _dbClientiService.DeleteCliente(cliente);
            }

            return bOk;
        }
        public override bool OnSave()
        {
            bool bOk = true;

            if(txtRagioneSociale.Text =="")
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
                // fai qualcosa
                var cliente = new Clienti
                {
                    Id = DOCUMENT_MODE == _DOC_MODE.NEW ? 0 : Convert.ToInt32(txtId.Text),
                    RagioneSociale = txtRagioneSociale.Text,
                    Indirizzo = txtIndirizzo.Text,
                    Città = txtCitta.Text,
                    IsFornitore = false
                };

                if (DOCUMENT_MODE == _DOC_MODE.NEW)
                    _dbClientiService.PostCliente(cliente);
                else
                    _dbClientiService.PutCliente(cliente);
            }
            if (bOk)
                ChangeFieldsState(false);

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

        private void txtRagioneSociale_Leave(object sender, EventArgs e)
        {
            if (txtRagioneSociale.Text == "")
                lblRagSoc.ForeColor = Color.Red;
            else
                lblRagSoc.ForeColor = Color.Black;

        }
    }
}
