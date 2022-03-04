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
    public partial class AnagraficaBase : Form
    {
        private _DOC_MODE _docMode;
        public _DOC_MODE DOCUMENT_MODE
        {
            get { return _docMode; }
            set { 
                _docMode = value;
                OnDocModeChanged();
            }
        }

        private void OnDocModeChanged()
        {
            nuovoToolStripMenuItem.Enabled = (DOCUMENT_MODE == _DOC_MODE.BROWSE);
            modificaToolStripMenuItem.Enabled = (DOCUMENT_MODE == _DOC_MODE.BROWSE);
            eliminaToolStripMenuItem.Enabled = (DOCUMENT_MODE == _DOC_MODE.BROWSE);
            cercaToolStripMenuItem.Enabled = (DOCUMENT_MODE == _DOC_MODE.BROWSE);
            primoToolStripMenuItem.Enabled = (DOCUMENT_MODE == _DOC_MODE.BROWSE);
            indietroToolStripMenuItem.Enabled = (DOCUMENT_MODE == _DOC_MODE.BROWSE);
            avantiToolStripMenuItem.Enabled = (DOCUMENT_MODE == _DOC_MODE.BROWSE);
            ultimoToolStripMenuItem.Enabled = (DOCUMENT_MODE == _DOC_MODE.BROWSE);
            salvaToolStripMenuItem.Enabled = !(DOCUMENT_MODE == _DOC_MODE.BROWSE);
            annullaToolStripMenuItem.Enabled = !(DOCUMENT_MODE == _DOC_MODE.BROWSE);
        }

        public AnagraficaBase()
        {
            InitializeComponent();
            DOCUMENT_MODE = _DOC_MODE.BROWSE;
        }
        virtual public void OnNew() { }
        virtual public void OnEdit() { }
        virtual public void OnDelete() { }
        virtual public void OnFirst() { }
        virtual public void OnBack() { }
        virtual public void OnNext() { }
        virtual public void OnLast() { }
        virtual public void OnFind() { }
        virtual public bool OnSave() { return true; }
        virtual public bool OnCancel() { return true; }

        private void nuovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DOCUMENT_MODE = _DOC_MODE.NEW;
            OnNew();
        }

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DOCUMENT_MODE = _DOC_MODE.EDIT;
            OnEdit();
        }

        private void eliminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnDelete();
        }

        private void cercaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnFind();
        }

        private void primoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnFirst();
        }

        private void indietroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnBack();
        }

        private void avantiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnNext();
        }

        private void ultimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnLast();
        }

        private void salvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OnSave())
                DOCUMENT_MODE = _DOC_MODE.BROWSE;
        }

        private void annullaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OnCancel())
                DOCUMENT_MODE = _DOC_MODE.BROWSE;
        }

        private void AnagraficaBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DOCUMENT_MODE != _DOC_MODE.BROWSE)
            {
                MessageBox.Show("Documento aperto impossibile chiudere.");
                e.Cancel = true;
            }
        }
    }
}
