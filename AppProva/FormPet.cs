using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppProva
{
    public partial class FormPet : Form
    {
        public FormPet()
        {
            InitializeComponent();
            carregarDt();
        }
        private void carregarDt()
        {
            dtAnimais.Rows.Clear();
            string cmdSql = "SELECT * FROM pet";
            DataTable listaPet = Program.cx.SELECT(cmdSql);
            if (listaPet != null)
            {
                foreach (DataRow linha in listaPet.Rows)
                {
                    dtAnimais.Rows.Add(
                        linha[1], linha[2], linha[3], linha[4], linha[5], linha[6], linha[7]
                    );
                }
            }
        }
        private void FormAdocao_Resize(object sender, EventArgs e)
        {            
            tbcCadastrar.Size = new Size(ClientSize.Width - 15, ClientSize.Height-15);
            dtAnimais.Size = new Size(ClientSize.Width - 20, ClientSize.Height - 30);

        }
        List<string[]> animais;
        private void FormAdocao_Load(object sender, EventArgs e)
        {
            tbcCadastrar.Size = new Size(ClientSize.Width - 15, ClientSize.Height - 15);
            dtAnimais.Size = new Size(ClientSize.Width - 20, ClientSize.Height - 30);

            string[] Mamiferos = { "Cão", "Gato", "Furão", "Cavalo", "Coelho", "Hamster", "Rato", "Camundongo", "Porquinho-da-índia", "Porco doméstico", "Chinchila", "Gerbil" };
            string[] Aves = { "Piriquitos", "Canário", "Caturra (Calopsita)", "Cacatuas", "Papagaios", "Galinha (Galo)", "Peru", "Pato", "Arara", "Mandarim", "Agapornis", "Pardal doméstico", "Galah", "Calafate", "Cardeal (ave)", "Curió", "Canário-da-terra", "Trinca-Ferro" };
            string[] Repteis = { "Cágados", "Tartarugas", "Jabutis", "Lagartos (Teiú, Iguana, gecko, etc…)", "Cobras (Serpentes)" };
            string[] Anfibios = { "Sapos", "Perereca", "Salamandras" };
            string[] Peixes = { "Poecilídeos (Platy, lebiste, etc...)", "Betta", "Kinguio", "Carpa", "Barbos", "Peixe-palhaço", "Tetras (néon, Matogrosso, rodóstomus, etc...)", "Acarás", "Oscar", "Cirurgiões", "Cascudos", "Coridoras" };

            animais = new List<string[]> { Mamiferos, Aves, Repteis, Anfibios, Peixes };

        }

        private void cbEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEspecie.SelectedIndex > -1) 
            {
                cbAnimal.Items.Clear();
                int index = cbEspecie.SelectedIndex;
                string[] especieEscolhida = animais[index];
                foreach (string animal in especieEscolhida) 
                {
                    cbAnimal.Items.Add(animal);
                }
            }
        }

        private void BtnCadastrr_Click(object sender, EventArgs e)
        {
            int vacinado = rbVacinadoSim.Checked ? 1 : 0;
           

            string cmdmysql = $"CALL cadastrar_pet('{txtNome.Text}','{cbEspecie.Text}','{ cbAnimal.Text}','{Convert.ToDateTime(dtpDataNasc.Text).ToString("yyyy-MM-dd")}','{txtPeso.Text}','{vacinado}','{ txtSobre.Text}')";

            if (Program.cx.INSERT(cmdmysql) > 0)
            {
                MessageBox.Show("erro");
                carregarDt();
                
            }
            else
            {
                MessageBox.Show("cadastrado");
            }



            dtAnimais.Rows.Add(txtNome.Text, cbEspecie.Text, cbAnimal.Text, dtpDataNasc.Text, txtPeso.Text, vacinado, txtSobre.Text);
            txtNome.Clear();
            txtPeso.Clear();
            txtSobre.Clear();
       

           

        }

        private void DtAnimais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string buscar= txtNome.Text + cbEspecie.Text + cbAnimal.Text + dtpDataNasc.Text + txtPeso.Text + txtSobre.Text;
        }
    }
}
