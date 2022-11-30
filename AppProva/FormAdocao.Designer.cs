namespace AppProva
{
    partial class FormAdocao
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbEscolher = new System.Windows.Forms.ListBox();
            this.txtCosultarAnimal = new System.Windows.Forms.TextBox();
            this.btnCadastrr = new System.Windows.Forms.Button();
            this.tbConsultarTutor = new System.Windows.Forms.TabPage();
            this.dtTutor = new System.Windows.Forms.DataGridView();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAnimalNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAnimalEspecie = new System.Windows.Forms.TextBox();
            this.txtAnimalAnimal = new System.Windows.Forms.TextBox();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tbcTutor.Size = new System.Drawing.Size(863, 539);
            this.tbcTutor.TabIndex = 2;
            // 
            // tbCadastrar
            // 
            this.tbCadastrar.Controls.Add(this.groupBox2);
            this.tbCadastrar.Controls.Add(this.groupBox1);
            this.tbCadastrar.Controls.Add(this.btnCadastrr);
            this.tbCadastrar.Location = new System.Drawing.Point(4, 31);
            this.tbCadastrar.Name = "tbCadastrar";
            this.tbCadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.tbCadastrar.Size = new System.Drawing.Size(855, 504);
            this.tbCadastrar.TabIndex = 0;
            this.tbCadastrar.Text = "Registrar";
            this.tbCadastrar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
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
            this.groupBox2.Size = new System.Drawing.Size(391, 394);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tutor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 30);
            this.button1.TabIndex = 31;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
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
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Location = new System.Drawing.Point(34, 212);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(324, 28);
            this.txtTelefone.TabIndex = 28;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(34, 55);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(238, 28);
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
            this.txtNome.Enabled = false;
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
            this.groupBox1.Controls.Add(this.txtAnimalAnimal);
            this.groupBox1.Controls.Add(this.txtAnimalEspecie);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAnimalNome);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbEscolher);
            this.groupBox1.Controls.Add(this.txtCosultarAnimal);
            this.groupBox1.Location = new System.Drawing.Point(420, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 394);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pet";
            // 
            // lbEscolher
            // 
            this.lbEscolher.FormattingEnabled = true;
            this.lbEscolher.ItemHeight = 22;
            this.lbEscolher.Location = new System.Drawing.Point(15, 55);
            this.lbEscolher.Name = "lbEscolher";
            this.lbEscolher.Size = new System.Drawing.Size(352, 114);
            this.lbEscolher.TabIndex = 38;
            // 
            // txtCosultarAnimal
            // 
            this.txtCosultarAnimal.ForeColor = System.Drawing.Color.DarkGray;
            this.txtCosultarAnimal.Location = new System.Drawing.Point(15, 30);
            this.txtCosultarAnimal.Name = "txtCosultarAnimal";
            this.txtCosultarAnimal.Size = new System.Drawing.Size(352, 28);
            this.txtCosultarAnimal.TabIndex = 29;
            this.txtCosultarAnimal.Text = "Busque por id, nome ou pelo tipo do animal";
            this.txtCosultarAnimal.Enter += new System.EventHandler(this.txtCosultarAnimal_Enter);
            this.txtCosultarAnimal.Leave += new System.EventHandler(this.txtCosultarAnimal_Leave);
            // 
            // btnCadastrr
            // 
            this.btnCadastrr.Location = new System.Drawing.Point(6, 422);
            this.btnCadastrr.Name = "btnCadastrr";
            this.btnCadastrr.Size = new System.Drawing.Size(800, 58);
            this.btnCadastrr.TabIndex = 8;
            this.btnCadastrr.Text = "Registrar";
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
            this.tbConsultarTutor.Size = new System.Drawing.Size(855, 504);
            this.tbConsultarTutor.TabIndex = 1;
            this.tbConsultarTutor.Text = "Consultar adoções";
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
            this.Column5,
            this.Column6,
            this.Column1});
            this.dtTutor.Location = new System.Drawing.Point(13, 40);
            this.dtTutor.Name = "dtTutor";
            this.dtTutor.ReadOnly = true;
            this.dtTutor.RowHeadersWidth = 51;
            this.dtTutor.RowTemplate.Height = 24;
            this.dtTutor.Size = new System.Drawing.Size(836, 461);
            this.dtTutor.TabIndex = 1;
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 22);
            this.label4.TabIndex = 43;
            this.label4.Text = "Animal";
            // 
            // txtAnimalNome
            // 
            this.txtAnimalNome.Enabled = false;
            this.txtAnimalNome.Location = new System.Drawing.Point(15, 212);
            this.txtAnimalNome.Name = "txtAnimalNome";
            this.txtAnimalNome.Size = new System.Drawing.Size(352, 28);
            this.txtAnimalNome.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 40;
            this.label5.Text = "Espécie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 22);
            this.label6.TabIndex = 39;
            this.label6.Text = "Nome";
            // 
            // txtAnimalEspecie
            // 
            this.txtAnimalEspecie.Enabled = false;
            this.txtAnimalEspecie.Location = new System.Drawing.Point(15, 276);
            this.txtAnimalEspecie.Name = "txtAnimalEspecie";
            this.txtAnimalEspecie.Size = new System.Drawing.Size(352, 28);
            this.txtAnimalEspecie.TabIndex = 44;
            // 
            // txtAnimalAnimal
            // 
            this.txtAnimalAnimal.Enabled = false;
            this.txtAnimalAnimal.Location = new System.Drawing.Point(15, 340);
            this.txtAnimalAnimal.Name = "txtAnimalAnimal";
            this.txtAnimalAnimal.Size = new System.Drawing.Size(352, 28);
            this.txtAnimalAnimal.TabIndex = 45;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Tutor";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Animal";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Data de adoção";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // FormAdocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 558);
            this.Controls.Add(this.tbcTutor);
            this.Name = "FormAdocao";
            this.Text = "Adoção";
            this.Load += new System.EventHandler(this.FormAdocao_Load);
            this.Resize += new System.EventHandler(this.FormAdocao_Resize);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCosultarAnimal;
        private System.Windows.Forms.Button btnCadastrr;
        private System.Windows.Forms.TabPage tbConsultarTutor;
        private System.Windows.Forms.DataGridView dtTutor;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbEscolher;
        private System.Windows.Forms.TextBox txtAnimalAnimal;
        private System.Windows.Forms.TextBox txtAnimalEspecie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAnimalNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}