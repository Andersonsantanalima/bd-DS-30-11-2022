using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppProva
{
    public partial class FormContainer : Form
    {
        public FormContainer()
        {
            InitializeComponent();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            FormPet formPet = new FormPet();
            formPet.MdiParent = this;
            formPet.Show();
        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {
            FormTutor formCliente = new FormTutor();
            formCliente.MdiParent = this;
            formCliente.Show();
        }

        private void toolStripSplitButton3_ButtonClick(object sender, EventArgs e)
        {
            FormAdocao formAdocao = new FormAdocao();
            formAdocao.MdiParent = this;    
            formAdocao.Show(); 
        }
    }
}
