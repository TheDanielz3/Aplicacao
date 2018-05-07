namespace GCC
{
    partial class Gerir_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gerir_Clientes));
            this.textBoxInserir = new System.Windows.Forms.TextBox();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.comboBoxInserir = new System.Windows.Forms.ComboBox();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.colunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaNIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaContacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonApagarCliente = new System.Windows.Forms.Button();
            this.groupBoxDetalhesClientes = new System.Windows.Forms.GroupBox();
            this.listBoxAquisicoes = new System.Windows.Forms.ListBox();
            this.labelAquisicoes = new System.Windows.Forms.Label();
            this.labelArrendamentos = new System.Windows.Forms.Label();
            this.listBoxCasas = new System.Windows.Forms.ListBox();
            this.labelCasas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonNovoCliente = new System.Windows.Forms.Button();
            this.textBoxContacto = new System.Windows.Forms.TextBox();
            this.textBoxMorada = new System.Windows.Forms.TextBox();
            this.textBoxNIF = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.buttonGuardarCliente = new System.Windows.Forms.Button();
            this.labelContacto = new System.Windows.Forms.Label();
            this.labelMorada = new System.Windows.Forms.Label();
            this.labelNIF = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.listBoxArrendamentos = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            this.groupBoxDetalhesClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxInserir
            // 
            this.textBoxInserir.Location = new System.Drawing.Point(13, 13);
            this.textBoxInserir.Name = "textBoxInserir";
            this.textBoxInserir.Size = new System.Drawing.Size(316, 20);
            this.textBoxInserir.TabIndex = 0;
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Location = new System.Drawing.Point(141, 40);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(81, 23);
            this.buttonFiltrar.TabIndex = 1;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            // 
            // comboBoxInserir
            // 
            this.comboBoxInserir.FormattingEnabled = true;
            this.comboBoxInserir.Location = new System.Drawing.Point(12, 42);
            this.comboBoxInserir.Name = "comboBoxInserir";
            this.comboBoxInserir.Size = new System.Drawing.Size(121, 21);
            this.comboBoxInserir.TabIndex = 2;
            this.comboBoxInserir.SelectedIndexChanged += new System.EventHandler(this.comboBoxCliente_SelectedIndexChanged);
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaNome,
            this.colunaNIF,
            this.colunaContacto});
            this.dataGridViewCliente.Location = new System.Drawing.Point(13, 98);
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.Size = new System.Drawing.Size(343, 592);
            this.dataGridViewCliente.TabIndex = 3;
            // 
            // colunaNome
            // 
            this.colunaNome.HeaderText = "Nome";
            this.colunaNome.Name = "colunaNome";
            // 
            // colunaNIF
            // 
            this.colunaNIF.HeaderText = "NIF";
            this.colunaNIF.Name = "colunaNIF";
            // 
            // colunaContacto
            // 
            this.colunaContacto.HeaderText = "Contacto";
            this.colunaContacto.Name = "colunaContacto";
            // 
            // buttonApagarCliente
            // 
            this.buttonApagarCliente.Location = new System.Drawing.Point(13, 696);
            this.buttonApagarCliente.Name = "buttonApagarCliente";
            this.buttonApagarCliente.Size = new System.Drawing.Size(343, 23);
            this.buttonApagarCliente.TabIndex = 4;
            this.buttonApagarCliente.Text = "Apagar";
            this.buttonApagarCliente.UseVisualStyleBackColor = true;
            // 
            // groupBoxDetalhesClientes
            // 
            this.groupBoxDetalhesClientes.Controls.Add(this.listBoxAquisicoes);
            this.groupBoxDetalhesClientes.Controls.Add(this.labelAquisicoes);
            this.groupBoxDetalhesClientes.Controls.Add(this.labelArrendamentos);
            this.groupBoxDetalhesClientes.Controls.Add(this.listBoxCasas);
            this.groupBoxDetalhesClientes.Controls.Add(this.labelCasas);
            this.groupBoxDetalhesClientes.Controls.Add(this.label4);
            this.groupBoxDetalhesClientes.Controls.Add(this.buttonNovoCliente);
            this.groupBoxDetalhesClientes.Controls.Add(this.textBoxContacto);
            this.groupBoxDetalhesClientes.Controls.Add(this.textBoxMorada);
            this.groupBoxDetalhesClientes.Controls.Add(this.textBoxNIF);
            this.groupBoxDetalhesClientes.Controls.Add(this.textBoxNome);
            this.groupBoxDetalhesClientes.Controls.Add(this.buttonGuardarCliente);
            this.groupBoxDetalhesClientes.Controls.Add(this.labelContacto);
            this.groupBoxDetalhesClientes.Controls.Add(this.labelMorada);
            this.groupBoxDetalhesClientes.Controls.Add(this.labelNIF);
            this.groupBoxDetalhesClientes.Controls.Add(this.labelNome);
            this.groupBoxDetalhesClientes.Location = new System.Drawing.Point(382, 98);
            this.groupBoxDetalhesClientes.Name = "groupBoxDetalhesClientes";
            this.groupBoxDetalhesClientes.Size = new System.Drawing.Size(316, 601);
            this.groupBoxDetalhesClientes.TabIndex = 5;
            this.groupBoxDetalhesClientes.TabStop = false;
            this.groupBoxDetalhesClientes.Text = "Detalhes";
            // 
            // listBoxAquisicoes
            // 
            this.listBoxAquisicoes.FormattingEnabled = true;
            this.listBoxAquisicoes.Location = new System.Drawing.Point(12, 497);
            this.listBoxAquisicoes.Name = "listBoxAquisicoes";
            this.listBoxAquisicoes.Size = new System.Drawing.Size(277, 95);
            this.listBoxAquisicoes.TabIndex = 16;
            // 
            // labelAquisicoes
            // 
            this.labelAquisicoes.AutoSize = true;
            this.labelAquisicoes.Location = new System.Drawing.Point(11, 478);
            this.labelAquisicoes.Name = "labelAquisicoes";
            this.labelAquisicoes.Size = new System.Drawing.Size(58, 13);
            this.labelAquisicoes.TabIndex = 15;
            this.labelAquisicoes.Text = "Aquisições";
            // 
            // labelArrendamentos
            // 
            this.labelArrendamentos.AutoSize = true;
            this.labelArrendamentos.Location = new System.Drawing.Point(11, 342);
            this.labelArrendamentos.Name = "labelArrendamentos";
            this.labelArrendamentos.Size = new System.Drawing.Size(78, 13);
            this.labelArrendamentos.TabIndex = 13;
            this.labelArrendamentos.Text = "Arrendamentos";
            // 
            // listBoxCasas
            // 
            this.listBoxCasas.FormattingEnabled = true;
            this.listBoxCasas.Location = new System.Drawing.Point(11, 228);
            this.listBoxCasas.Name = "listBoxCasas";
            this.listBoxCasas.Size = new System.Drawing.Size(278, 95);
            this.listBoxCasas.TabIndex = 12;
            // 
            // labelCasas
            // 
            this.labelCasas.AutoSize = true;
            this.labelCasas.Location = new System.Drawing.Point(11, 209);
            this.labelCasas.Name = "labelCasas";
            this.labelCasas.Size = new System.Drawing.Size(36, 13);
            this.labelCasas.TabIndex = 11;
            this.labelCasas.Text = "Casas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "  ";
            // 
            // buttonNovoCliente
            // 
            this.buttonNovoCliente.Location = new System.Drawing.Point(213, 177);
            this.buttonNovoCliente.Name = "buttonNovoCliente";
            this.buttonNovoCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonNovoCliente.TabIndex = 9;
            this.buttonNovoCliente.Text = "Novo";
            this.buttonNovoCliente.UseVisualStyleBackColor = true;
            // 
            // textBoxContacto
            // 
            this.textBoxContacto.Location = new System.Drawing.Point(64, 145);
            this.textBoxContacto.Name = "textBoxContacto";
            this.textBoxContacto.Size = new System.Drawing.Size(225, 20);
            this.textBoxContacto.TabIndex = 8;
            this.textBoxContacto.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBoxMorada
            // 
            this.textBoxMorada.Location = new System.Drawing.Point(64, 109);
            this.textBoxMorada.Name = "textBoxMorada";
            this.textBoxMorada.Size = new System.Drawing.Size(225, 20);
            this.textBoxMorada.TabIndex = 7;
            // 
            // textBoxNIF
            // 
            this.textBoxNIF.Location = new System.Drawing.Point(64, 72);
            this.textBoxNIF.Name = "textBoxNIF";
            this.textBoxNIF.Size = new System.Drawing.Size(225, 20);
            this.textBoxNIF.TabIndex = 6;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(64, 38);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(225, 20);
            this.textBoxNome.TabIndex = 5;
            // 
            // buttonGuardarCliente
            // 
            this.buttonGuardarCliente.Location = new System.Drawing.Point(64, 177);
            this.buttonGuardarCliente.Name = "buttonGuardarCliente";
            this.buttonGuardarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardarCliente.TabIndex = 4;
            this.buttonGuardarCliente.Text = "Guardar";
            this.buttonGuardarCliente.UseVisualStyleBackColor = true;
            // 
            // labelContacto
            // 
            this.labelContacto.AutoSize = true;
            this.labelContacto.Location = new System.Drawing.Point(8, 148);
            this.labelContacto.Name = "labelContacto";
            this.labelContacto.Size = new System.Drawing.Size(53, 13);
            this.labelContacto.TabIndex = 3;
            this.labelContacto.Text = "Contacto:";
            // 
            // labelMorada
            // 
            this.labelMorada.AutoSize = true;
            this.labelMorada.Location = new System.Drawing.Point(15, 112);
            this.labelMorada.Name = "labelMorada";
            this.labelMorada.Size = new System.Drawing.Size(46, 13);
            this.labelMorada.TabIndex = 2;
            this.labelMorada.Text = "Morada:";
            // 
            // labelNIF
            // 
            this.labelNIF.AutoSize = true;
            this.labelNIF.Location = new System.Drawing.Point(34, 75);
            this.labelNIF.Name = "labelNIF";
            this.labelNIF.Size = new System.Drawing.Size(27, 13);
            this.labelNIF.TabIndex = 1;
            this.labelNIF.Text = "NIF:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(23, 41);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // listBoxArrendamentos
            // 
            this.listBoxArrendamentos.FormattingEnabled = true;
            this.listBoxArrendamentos.Location = new System.Drawing.Point(393, 460);
            this.listBoxArrendamentos.Name = "listBoxArrendamentos";
            this.listBoxArrendamentos.Size = new System.Drawing.Size(277, 95);
            this.listBoxArrendamentos.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(573, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Gerir_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 721);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBoxArrendamentos);
            this.Controls.Add(this.groupBoxDetalhesClientes);
            this.Controls.Add(this.buttonApagarCliente);
            this.Controls.Add(this.dataGridViewCliente);
            this.Controls.Add(this.comboBoxInserir);
            this.Controls.Add(this.buttonFiltrar);
            this.Controls.Add(this.textBoxInserir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Gerir_Clientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            this.groupBoxDetalhesClientes.ResumeLayout(false);
            this.groupBoxDetalhesClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInserir;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.ComboBox comboBoxInserir;
        private System.Windows.Forms.DataGridView dataGridViewCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaContacto;
        private System.Windows.Forms.Button buttonApagarCliente;
        private System.Windows.Forms.GroupBox groupBoxDetalhesClientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonNovoCliente;
        private System.Windows.Forms.TextBox textBoxContacto;
        private System.Windows.Forms.TextBox textBoxMorada;
        private System.Windows.Forms.TextBox textBoxNIF;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Button buttonGuardarCliente;
        private System.Windows.Forms.Label labelContacto;
        private System.Windows.Forms.Label labelMorada;
        private System.Windows.Forms.Label labelNIF;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.ListBox listBoxAquisicoes;
        private System.Windows.Forms.Label labelAquisicoes;
        private System.Windows.Forms.Label labelArrendamentos;
        private System.Windows.Forms.ListBox listBoxCasas;
        private System.Windows.Forms.Label labelCasas;
        private System.Windows.Forms.ListBox listBoxArrendamentos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}