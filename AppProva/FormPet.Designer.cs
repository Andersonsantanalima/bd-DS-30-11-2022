namespace AppProva
{
    partial class FormPet
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
            this.tbcCadastrar = new System.Windows.Forms.TabControl();
            this.tbCadastrar = new System.Windows.Forms.TabPage();
            this.cbAnimal = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbn = new System.Windows.Forms.RadioButton();
            this.rbVacinadoSim = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSobre = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCadastrr = new System.Windows.Forms.Button();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.cbEspecie = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBuscarPets = new System.Windows.Forms.TabPage();
            this.dtAnimais = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbcCadastrar.SuspendLayout();
            this.tbCadastrar.SuspendLayout();
            this.tbBuscarPets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAnimais)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcCadastrar
            // 
            this.tbcCadastrar.Controls.Add(this.tbCadastrar);
            this.tbcCadastrar.Controls.Add(this.tbBuscarPets);
            this.tbcCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcCadastrar.Location = new System.Drawing.Point(9, 10);
            this.tbcCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.tbcCadastrar.Name = "tbcCadastrar";
            this.tbcCadastrar.SelectedIndex = 0;
            this.tbcCadastrar.Size = new System.Drawing.Size(717, 483);
            this.tbcCadastrar.TabIndex = 0;
            // 
            // tbCadastrar
            // 
            this.tbCadastrar.Controls.Add(this.cbAnimal);
            this.tbCadastrar.Controls.Add(this.label7);
            this.tbCadastrar.Controls.Add(this.rbn);
            this.tbCadastrar.Controls.Add(this.rbVacinadoSim);
            this.tbCadastrar.Controls.Add(this.label6);
            this.tbCadastrar.Controls.Add(this.txtSobre);
            this.tbCadastrar.Controls.Add(this.label5);
            this.tbCadastrar.Controls.Add(this.btnCadastrr);
            this.tbCadastrar.Controls.Add(this.txtPeso);
            this.tbCadastrar.Controls.Add(this.dtpDataNasc);
            this.tbCadastrar.Controls.Add(this.cbEspecie);
            this.tbCadastrar.Controls.Add(this.txtNome);
            this.tbCadastrar.Controls.Add(this.label4);
            this.tbCadastrar.Controls.Add(this.label3);
            this.tbCadastrar.Controls.Add(this.label2);
            this.tbCadastrar.Controls.Add(this.label1);
            this.tbCadastrar.Location = new System.Drawing.Point(4, 26);
            this.tbCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.tbCadastrar.Name = "tbCadastrar";
            this.tbCadastrar.Padding = new System.Windows.Forms.Padding(2);
            this.tbCadastrar.Size = new System.Drawing.Size(709, 453);
            this.tbCadastrar.TabIndex = 0;
            this.tbCadastrar.Text = "Cadastar";
            this.tbCadastrar.UseVisualStyleBackColor = true;
            // 
            // cbAnimal
            // 
            this.cbAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnimal.FormattingEnabled = true;
            this.cbAnimal.Items.AddRange(new object[] {
            "Mamíferos",
            "Aves",
            "Répteis",
            "Anfíbios",
            "Peixes"});
            this.cbAnimal.Location = new System.Drawing.Point(30, 178);
            this.cbAnimal.Margin = new System.Windows.Forms.Padding(2);
            this.cbAnimal.Name = "cbAnimal";
            this.cbAnimal.Size = new System.Drawing.Size(265, 25);
            this.cbAnimal.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Animal";
            // 
            // rbn
            // 
            this.rbn.AutoSize = true;
            this.rbn.Location = new System.Drawing.Point(392, 52);
            this.rbn.Margin = new System.Windows.Forms.Padding(2);
            this.rbn.Name = "rbn";
            this.rbn.Size = new System.Drawing.Size(54, 22);
            this.rbn.TabIndex = 13;
            this.rbn.TabStop = true;
            this.rbn.Text = "Não";
            this.rbn.UseVisualStyleBackColor = true;
            // 
            // rbVacinadoSim
            // 
            this.rbVacinadoSim.AutoSize = true;
            this.rbVacinadoSim.Location = new System.Drawing.Point(342, 52);
            this.rbVacinadoSim.Margin = new System.Windows.Forms.Padding(2);
            this.rbVacinadoSim.Name = "rbVacinadoSim";
            this.rbVacinadoSim.Size = new System.Drawing.Size(52, 22);
            this.rbVacinadoSim.TabIndex = 12;
            this.rbVacinadoSim.TabStop = true;
            this.rbVacinadoSim.Text = "Sim";
            this.rbVacinadoSim.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Vacinado";
            // 
            // txtSobre
            // 
            this.txtSobre.Location = new System.Drawing.Point(342, 120);
            this.txtSobre.Margin = new System.Windows.Forms.Padding(2);
            this.txtSobre.Name = "txtSobre";
            this.txtSobre.Size = new System.Drawing.Size(350, 210);
            this.txtSobre.TabIndex = 10;
            this.txtSobre.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sobre";
            // 
            // btnCadastrr
            // 
            this.btnCadastrr.Location = new System.Drawing.Point(30, 360);
            this.btnCadastrr.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrr.Name = "btnCadastrr";
            this.btnCadastrr.Size = new System.Drawing.Size(661, 47);
            this.btnCadastrr.TabIndex = 8;
            this.btnCadastrr.Text = "Cadastrar";
            this.btnCadastrr.UseVisualStyleBackColor = true;
            this.btnCadastrr.Click += new System.EventHandler(this.BtnCadastrr_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(30, 306);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(2);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(265, 24);
            this.txtPeso.TabIndex = 7;
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Location = new System.Drawing.Point(30, 242);
            this.dtpDataNasc.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(265, 24);
            this.dtpDataNasc.TabIndex = 6;
            // 
            // cbEspecie
            // 
            this.cbEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEspecie.FormattingEnabled = true;
            this.cbEspecie.Items.AddRange(new object[] {
            "Mamíferos",
            "Aves",
            "Répteis",
            "Anfíbios",
            "Peixes"});
            this.cbEspecie.Location = new System.Drawing.Point(30, 114);
            this.cbEspecie.Margin = new System.Windows.Forms.Padding(2);
            this.cbEspecie.Name = "cbEspecie";
            this.cbEspecie.Size = new System.Drawing.Size(265, 25);
            this.cbEspecie.TabIndex = 5;
            this.cbEspecie.SelectedIndexChanged += new System.EventHandler(this.cbEspecie_SelectedIndexChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(30, 50);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(265, 24);
            this.txtNome.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 286);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Peso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de nascimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Espécie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // tbBuscarPets
            // 
            this.tbBuscarPets.Controls.Add(this.dtAnimais);
            this.tbBuscarPets.Controls.Add(this.textBox1);
            this.tbBuscarPets.Location = new System.Drawing.Point(4, 26);
            this.tbBuscarPets.Margin = new System.Windows.Forms.Padding(2);
            this.tbBuscarPets.Name = "tbBuscarPets";
            this.tbBuscarPets.Padding = new System.Windows.Forms.Padding(2);
            this.tbBuscarPets.Size = new System.Drawing.Size(709, 453);
            this.tbBuscarPets.TabIndex = 1;
            this.tbBuscarPets.Text = "Buscar pets";
            this.tbBuscarPets.UseVisualStyleBackColor = true;
            // 
            // dtAnimais
            // 
            this.dtAnimais.AllowUserToAddRows = false;
            this.dtAnimais.AllowUserToDeleteRows = false;
            this.dtAnimais.AllowUserToOrderColumns = true;
            this.dtAnimais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtAnimais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAnimais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dtAnimais.Location = new System.Drawing.Point(10, 32);
            this.dtAnimais.Margin = new System.Windows.Forms.Padding(2);
            this.dtAnimais.Name = "dtAnimais";
            this.dtAnimais.ReadOnly = true;
            this.dtAnimais.RowHeadersWidth = 51;
            this.dtAnimais.RowTemplate.Height = 24;
            this.dtAnimais.Size = new System.Drawing.Size(704, 418);
            this.dtAnimais.TabIndex = 1;
            this.dtAnimais.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtAnimais_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Nome";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Espécie";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Animal";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Data de nascimento";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Peso";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Vacinado";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Sobre";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(4, 5);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(703, 24);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Busque aqui";
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // FormPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 495);
            this.Controls.Add(this.tbcCadastrar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPet";
            this.Text = "Pets";
            this.Load += new System.EventHandler(this.FormAdocao_Load);
            this.Resize += new System.EventHandler(this.FormAdocao_Resize);
            this.tbcCadastrar.ResumeLayout(false);
            this.tbCadastrar.ResumeLayout(false);
            this.tbCadastrar.PerformLayout();
            this.tbBuscarPets.ResumeLayout(false);
            this.tbBuscarPets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAnimais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCadastrar;
        private System.Windows.Forms.TabPage tbCadastrar;
        private System.Windows.Forms.TabPage tbBuscarPets;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCadastrr;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.ComboBox cbEspecie;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbn;
        private System.Windows.Forms.RadioButton rbVacinadoSim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtSobre;
        private System.Windows.Forms.ComboBox cbAnimal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dtAnimais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}