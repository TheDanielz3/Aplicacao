namespace GCC
{
    partial class GerirClientes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label contactoLabel;
            System.Windows.Forms.Label moradaLabel;
            System.Windows.Forms.Label nIFLabel;
            System.Windows.Forms.Label nomeLabel;
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.contactoTextBox = new System.Windows.Forms.TextBox();
            this.moradaTextBox = new System.Windows.Forms.TextBox();
            this.nIFTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.groupBoxDetalhesCliente = new System.Windows.Forms.GroupBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.labelAquisicoes = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.labelArrendamentos = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelCasas = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxFilterCliente = new System.Windows.Forms.TextBox();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumnIDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            contactoLabel = new System.Windows.Forms.Label();
            moradaLabel = new System.Windows.Forms.Label();
            nIFLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            this.groupBoxDetalhesCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contactoLabel
            // 
            contactoLabel.AutoSize = true;
            contactoLabel.Location = new System.Drawing.Point(31, 97);
            contactoLabel.Name = "contactoLabel";
            contactoLabel.Size = new System.Drawing.Size(53, 13);
            contactoLabel.TabIndex = 2;
            contactoLabel.Text = "Contacto:";
            // 
            // moradaLabel
            // 
            moradaLabel.AutoSize = true;
            moradaLabel.Location = new System.Drawing.Point(31, 123);
            moradaLabel.Name = "moradaLabel";
            moradaLabel.Size = new System.Drawing.Size(46, 13);
            moradaLabel.TabIndex = 6;
            moradaLabel.Text = "Morada:";
            // 
            // nIFLabel
            // 
            nIFLabel.AutoSize = true;
            nIFLabel.Location = new System.Drawing.Point(31, 71);
            nIFLabel.Name = "nIFLabel";
            nIFLabel.Size = new System.Drawing.Size(27, 13);
            nIFLabel.TabIndex = 8;
            nIFLabel.Text = "NIF:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(31, 45);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 10;
            nomeLabel.Text = "Nome:";
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.AutoGenerateColumns = false;
            this.clienteDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnIDCliente,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4});
            this.clienteDataGridView.DataSource = this.clienteBindingSource;
            this.clienteDataGridView.Location = new System.Drawing.Point(12, 113);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.ReadOnly = true;
            this.clienteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clienteDataGridView.Size = new System.Drawing.Size(530, 459);
            this.clienteDataGridView.TabIndex = 1;
            this.clienteDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clienteDataGridView_CellContentClick);
            // 
            // contactoTextBox
            // 
            this.contactoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Contacto", true));
            this.contactoTextBox.Location = new System.Drawing.Point(91, 94);
            this.contactoTextBox.Name = "contactoTextBox";
            this.contactoTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactoTextBox.TabIndex = 3;
            // 
            // moradaTextBox
            // 
            this.moradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Morada", true));
            this.moradaTextBox.Location = new System.Drawing.Point(91, 120);
            this.moradaTextBox.Name = "moradaTextBox";
            this.moradaTextBox.Size = new System.Drawing.Size(100, 20);
            this.moradaTextBox.TabIndex = 7;
            // 
            // nIFTextBox
            // 
            this.nIFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "NIF", true));
            this.nIFTextBox.Location = new System.Drawing.Point(91, 68);
            this.nIFTextBox.Name = "nIFTextBox";
            this.nIFTextBox.Size = new System.Drawing.Size(100, 20);
            this.nIFTextBox.TabIndex = 9;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(91, 42);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 11;
            // 
            // groupBoxDetalhesCliente
            // 
            this.groupBoxDetalhesCliente.Controls.Add(contactoLabel);
            this.groupBoxDetalhesCliente.Controls.Add(this.listBox3);
            this.groupBoxDetalhesCliente.Controls.Add(this.contactoTextBox);
            this.groupBoxDetalhesCliente.Controls.Add(this.labelAquisicoes);
            this.groupBoxDetalhesCliente.Controls.Add(this.listBox2);
            this.groupBoxDetalhesCliente.Controls.Add(moradaLabel);
            this.groupBoxDetalhesCliente.Controls.Add(this.labelArrendamentos);
            this.groupBoxDetalhesCliente.Controls.Add(this.moradaTextBox);
            this.groupBoxDetalhesCliente.Controls.Add(this.listBox1);
            this.groupBoxDetalhesCliente.Controls.Add(nIFLabel);
            this.groupBoxDetalhesCliente.Controls.Add(this.labelCasas);
            this.groupBoxDetalhesCliente.Controls.Add(this.nIFTextBox);
            this.groupBoxDetalhesCliente.Controls.Add(this.button2);
            this.groupBoxDetalhesCliente.Controls.Add(nomeLabel);
            this.groupBoxDetalhesCliente.Controls.Add(this.button1);
            this.groupBoxDetalhesCliente.Controls.Add(this.nomeTextBox);
            this.groupBoxDetalhesCliente.Location = new System.Drawing.Point(570, 125);
            this.groupBoxDetalhesCliente.Name = "groupBoxDetalhesCliente";
            this.groupBoxDetalhesCliente.Size = new System.Drawing.Size(300, 503);
            this.groupBoxDetalhesCliente.TabIndex = 12;
            this.groupBoxDetalhesCliente.TabStop = false;
            this.groupBoxDetalhesCliente.Text = "Detalhes";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(31, 423);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(243, 69);
            this.listBox3.TabIndex = 7;
            // 
            // labelAquisicoes
            // 
            this.labelAquisicoes.AutoSize = true;
            this.labelAquisicoes.Location = new System.Drawing.Point(31, 407);
            this.labelAquisicoes.Name = "labelAquisicoes";
            this.labelAquisicoes.Size = new System.Drawing.Size(58, 13);
            this.labelAquisicoes.TabIndex = 6;
            this.labelAquisicoes.Text = "Aquisicoes";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(31, 321);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(240, 69);
            this.listBox2.TabIndex = 5;
            // 
            // labelArrendamentos
            // 
            this.labelArrendamentos.AutoSize = true;
            this.labelArrendamentos.Location = new System.Drawing.Point(28, 305);
            this.labelArrendamentos.Name = "labelArrendamentos";
            this.labelArrendamentos.Size = new System.Drawing.Size(81, 13);
            this.labelArrendamentos.TabIndex = 4;
            this.labelArrendamentos.Text = "Arrendamentos:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(31, 223);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(243, 69);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labelCasas
            // 
            this.labelCasas.AutoSize = true;
            this.labelCasas.Location = new System.Drawing.Point(31, 203);
            this.labelCasas.Name = "labelCasas";
            this.labelCasas.Size = new System.Drawing.Size(39, 13);
            this.labelCasas.TabIndex = 2;
            this.labelCasas.Text = "Casas:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Novo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxFilterCliente
            // 
            this.textBoxFilterCliente.Location = new System.Drawing.Point(12, 29);
            this.textBoxFilterCliente.Name = "textBoxFilterCliente";
            this.textBoxFilterCliente.Size = new System.Drawing.Size(510, 20);
            this.textBoxFilterCliente.TabIndex = 14;
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(12, 66);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCliente.TabIndex = 15;
            this.comboBoxCliente.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Location = new System.Drawing.Point(150, 66);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltrar.TabIndex = 16;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 590);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(530, 49);
            this.button3.TabIndex = 13;
            this.button3.Text = "Apagar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // dataGridViewTextBoxColumnIDCliente
            // 
            this.dataGridViewTextBoxColumnIDCliente.DataPropertyName = "IdCliente";
            this.dataGridViewTextBoxColumnIDCliente.HeaderText = "IdCliente";
            this.dataGridViewTextBoxColumnIDCliente.Name = "dataGridViewTextBoxColumnIDCliente";
            this.dataGridViewTextBoxColumnIDCliente.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NIF";
            this.dataGridViewTextBoxColumn3.HeaderText = "NIF";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Contacto";
            this.dataGridViewTextBoxColumn5.HeaderText = "Contacto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Morada";
            this.dataGridViewTextBoxColumn4.HeaderText = "Morada";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(GCC.Cliente);
            // 
            // GerirClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 656);
            this.Controls.Add(this.buttonFiltrar);
            this.Controls.Add(this.comboBoxCliente);
            this.Controls.Add(this.textBoxFilterCliente);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.clienteDataGridView);
            this.Controls.Add(this.groupBoxDetalhesCliente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GerirClientes";
            this.Text = "GerirClientes";
            this.Load += new System.EventHandler(this.GerirClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            this.groupBoxDetalhesCliente.ResumeLayout(false);
            this.groupBoxDetalhesCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.TextBox contactoTextBox;
        private System.Windows.Forms.TextBox moradaTextBox;
        private System.Windows.Forms.TextBox nIFTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.GroupBox groupBoxDetalhesCliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label labelAquisicoes;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label labelArrendamentos;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelCasas;
        private System.Windows.Forms.TextBox textBoxFilterCliente;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnIDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        public System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.Button button3;
    }
}