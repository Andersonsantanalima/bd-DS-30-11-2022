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
    public partial class FormAdocao : Form
    {
        public FormAdocao()
        {
            InitializeComponent();
        }

        private void txtCosultarAnimal_Enter(object sender, EventArgs e)
        {
            if (txtCosultarAnimal.Text == "Busque por id, nome ou pelo tipo do animal") 
            {
                txtCosultarAnimal.Text = "";
                txtCosultarAnimal.ForeColor = Color.Black;
            }
        }

        private void btnCadastrr_Click(object sender, EventArgs e)
        {

        }

        private void txtCosultarAnimal_Leave(object sender, EventArgs e)
        {
            if (txtCosultarAnimal.Text == "")
            {
                txtCosultarAnimal.Text = "Busque por id, nome ou pelo tipo do animal";
                txtCosultarAnimal.ForeColor = Color.DarkGray;
            }
        }

        private void FormAdocao_Load(object sender, EventArgs e)
        {
            tbcTutor.Size = new Size(ClientSize.Width - 15, ClientSize.Height - 15);
            dtTutor.Size = new Size(ClientSize.Width - 20, ClientSize.Height - 30);
        }

        private void FormAdocao_Resize(object sender, EventArgs e)
        {
            tbcTutor.Size = new Size(ClientSize.Width - 15, ClientSize.Height - 15);
            dtTutor.Size = new Size(ClientSize.Width - 20, ClientSize.Height - 30);
        }
    }
}
