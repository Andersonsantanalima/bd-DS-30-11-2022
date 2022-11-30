using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppProva
{
    public partial class FormTutor : Form
    {
        public FormTutor()
        {
            InitializeComponent();
            carregarDt();
        }

        private void carregarDt()
        {
            dtTutor.Rows.Clear();
            string cmdSql = "SELECT * FROM tutor";
            DataTable listaTutor = Program.cx.SELECT(cmdSql);
            if (listaTutor != null)
            {
                foreach (DataRow linha in listaTutor.Rows)
                {
                    dtTutor.Rows.Add(
                        linha[1], linha[2], linha[3], linha[4], linha[5], linha[6]
                    );
                }
            }
        }
        private void btnCadastrr_Click(object sender, EventArgs e)
        {

            string cmdmysql = $"CALL cadastrar_tutor('{txtCpf.Text}','{txtNome.Text}','{ txtTelefone.Text}','{txtEmail.Text}')";

            if (Program.cx.INSERT(cmdmysql) > 0)
            {
                MessageBox.Show("erro");
                carregarDt();
            }
            else
            {
                MessageBox.Show("cadastrado");
            }

            dtTutor.Rows.Add(txtCpf.Text, txtNome.Text, txtTelefone.Text, txtEmail.Text, dtDataNasc.Text);
            txtCpf.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            
        }

        private void FormTutor_Load(object sender, EventArgs e)
        {
            tbcTutor.Size = new Size(ClientSize.Width - 15, ClientSize.Height - 15);
            dtTutor.Size = new Size(ClientSize.Width - 20, ClientSize.Height - 30);            

        }


        private void FormTutor_Resize(object sender, EventArgs e)
        {
            tbcTutor.Size = new Size(ClientSize.Width - 15, ClientSize.Height - 15);
            dtTutor.Size = new Size(ClientSize.Width - 20, ClientSize.Height - 30);
        }
        
        private void txtBusca_Enter(object sender, EventArgs e)
        {
            
            if (txtBusca.Text == "Busque aqui...")
            {
                txtBusca.Text = "";
                txtBusca.ForeColor = Color.Black;
            }
        }

        private void txtBusca_Leave(object sender, EventArgs e)
        {
            if (txtBusca.Text == "")
            {
                txtBusca.Text = "Busque aqui...";
                txtBusca.ForeColor = Color.DarkGray;
            }
        }
    }
}
