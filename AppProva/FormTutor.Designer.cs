namespace AppProva
{
    partial class FormTutor
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
            this.tbcTutor = new System.Windows.Forms.TabControl();
            this.tbCadastrar = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtDataNasc = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCadastrr = new System.Windows.Forms.Button();
            this.tbConsultarTutor = new System.Windows.Forms.TabPage();
            this.dtTutor = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.tbcTutor.SuspendLayout();
            this.tbCadastrar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbConsultarTutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTutor)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcTutor
            // 
            this.tbcTutor.Controls.Add(this.tbCadastrar);
            this.tbcTutor.Controls.Add(this.tbConsultarTutor);
            this.tbcTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcTutor.Location = new System.Drawing.Point(12, 12);
            this.tbcTutor.Name = "tbcTutor";
            this.tbcTutor.SelectedIndex = 0;
            this.tbcTutor.Size = new System.Drawing.Size(863, 595);
            this.tbcTutor.TabIndex = 1;
            // 
            // tbCadastrar
            // 
            this.tbCadastrar.Controls.Add(this.groupBox2);
            this.tbCadastrar.Controls.Add(this.groupBox1);
            this.tbCadastrar.Controls.Add(this.btnCadastrr);
            this.tbCadastrar.Location = new System.Drawing.Point(4, 31);
            this.tbCadastrar.Name = "tbCadastrar";
            this.tbCadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.tbCadastrar.Size = new System.Drawing.Size(855, 560);
            this.tbCadastrar.TabIndex = 0;
            this.tbCadastrar.Text = "Cadastrar";
            this.tbCadastrar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtDataNasc);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtTelefone);
            this.groupBox2.Controls.Add(this.txtCpf);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 419);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados pessoais";
            // 
            // dtDataNasc
            // 
            this.dtDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataNasc.Location = new System.Drawing.Point(34, 370);
            this.dtDataNasc.Name = "dtDataNasc";
            this.dtDataNasc.Size = new System.Drawing.Size(170, 28);
            this.dtDataNasc.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 22);
            this.label4.TabIndex = 31;
            this.label4.Text = "Data de nascimento:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(34, 289);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(324, 28);
            this.txtEmail.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 29;
            this.label3.Text = "E-mail:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(34, 212);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(324, 28);
            this.txtTelefone.TabIndex = 28;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(34, 55);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(324, 28);
            this.txtCpf.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "CPF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 22);
            this.label7.TabIndex = 25;
            this.label7.Text = "Telefone:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(34, 126);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(324, 28);
            this.txtNome.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nome:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbUF);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCEP);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtLogradouro);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(420, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 419);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(15, 126);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(352, 28);
            this.txtCidade.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 22);
            this.label12.TabIndex = 36;
            this.label12.Text = "Cidade:";
            // 
            // cbUF
            // 
            this.cbUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Items.AddRange(new object[] {
            "AC - Acre",
            "AL - Alagoas",
            "AP - Amapá",
            "AM - Amazonas",
            "BA - Bahia",
            "CE - Ceará",
            "DF - Distrito Federal",
            "ES - Espírito Santo",
            "GO - Goiás",
            "MA - Maranhão",
            "MT - Mato Grosso",
            "MS - Mato Grosso do Sul",
            "MG - Minas Gerais",
            "PA - Pará",
            "PB - Paraíba",
            "PR - Paraná",
            "PE - Pernambuco",
            "PI - Piauí",
            "RJ - Rio de Janeiro",
            "RN - Rio Grande do Norte",
            "RS - Rio Grande do Sul",
            "RO - Rondônia",
            "RR - Roraima",
            "SC - Santa Catarina",
            "SP - São Paulo",
            "SE - Sergipe",
            "TO - Tocantins"});
            this.cbUF.Location = new System.Drawing.Point(246, 53);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(121, 30);
            this.cbUF.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(242, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 22);
            this.label10.TabIndex = 32;
            this.label10.Text = "UP";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(15, 212);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(352, 28);
            this.txtBairro.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 22);
            this.label9.TabIndex = 30;
            this.label9.Text = "Bairro:";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(15, 53);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(201, 28);
            this.txtCEP.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 22);
            this.label8.TabIndex = 28;
            this.label8.Text = "CEP:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(15, 370);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(103, 28);
            this.txtNumero.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 22);
            this.label6.TabIndex = 26;
            this.label6.Text = "Número:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(15, 289);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(352, 28);
            this.txtLogradouro.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 22);
            this.label5.TabIndex = 24;
            this.label5.Text = "Logradouro:";
            // 
            // btnCadastrr
            // 
            this.btnCadastrr.Location = new System.Drawing.Point(40, 478);
            this.btnCadastrr.Name = "btnCadastrr";
            this.btnCadastrr.Size = new System.Drawing.Size(766, 58);
            this.btnCadastrr.TabIndex = 8;
            this.btnCadastrr.Text = "Cadastrar";
            this.btnCadastrr.UseVisualStyleBackColor = true;
            this.btnCadastrr.Click += new System.EventHandler(this.btnCadastrr_Click);
            // 
            // tbConsultarTutor
            // 
            this.tbConsultarTutor.Controls.Add(this.dtTutor);
            this.tbConsultarTutor.Controls.Add(this.txtBusca);
            this.tbConsultarTutor.Location = new System.Drawing.Point(4, 31);
            this.tbConsultarTutor.Name = "tbConsultarTutor";
            this.tbConsultarTutor.Padding = new System.Windows.Forms.Padding(3);
            this.tbConsultarTutor.Size = new System.Drawing.Size(855, 560);
            this.tbConsultarTutor.TabIndex = 1;
            this.tbConsultarTutor.Text = "Consultar tutores";
            this.tbConsultarTutor.UseVisualStyleBackColor = true;
            // 
            // dtTutor
            // 
            this.dtTutor.AllowUserToAddRows = false;
            this.dtTutor.AllowUserToDeleteRows = false;
            this.dtTutor.AllowUserToOrderColumns = true;
            this.dtTutor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTutor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtTutor.Location = new System.Drawing.Point(13, 40);
            this.dtTutor.Name = "dtTutor";
            this.dtTutor.ReadOnly = true;
            this.dtTutor.RowHeadersWidth = 51;
            this.dtTutor.RowTemplate.Height = 24;
            this.dtTutor.Size = new System.Drawing.Size(836, 514);
            this.dtTutor.TabIndex = 1;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "CPF";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Nome";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Telefone";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "E-mail";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Idade";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Endereço";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // txtBusca
            // 
            this.txtBusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusca.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBusca.Location = new System.Drawing.Point(6, 6);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(843, 28);
            this.txtBusca.TabIndex = 0;
            this.txtBusca.Text = "Busque aqui...";
            this.txtBusca.Enter += new System.EventHandler(this.txtBusca_Enter);
            this.txtBusca.Leave += new System.EventHandler(this.txtBusca_Leave);
            // 
            // FormTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 616);
            this.Controls.Add(this.tbcTutor);
            this.Name = "FormTutor";
            this.Text = "Tutor";
            this.Load += new System.EventHandler(this.FormTutor_Load);
            this.Resize += new System.EventHandler(this.FormTutor_Resize);
            this.tbcTutor.ResumeLayout(false);
            this.tbCadastrar.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbConsultarTutor.ResumeLayout(false);
            this.tbConsultarTutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTutor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcTutor;
        private System.Windows.Forms.TabPage tbCadastrar;
        private System.Windows.Forms.Button btnCadastrr;
        private System.Windows.Forms.TabPage tbConsultarTutor;
        private System.Windows.Forms.DataGridView dtTutor;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtDataNasc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}