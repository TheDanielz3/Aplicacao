namespace GCC
{
    partial class GerirArrendamentos
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
            System.Windows.Forms.Label inicioContratoLabel;
            System.Windows.Forms.Label duracaoMesesLabel;
            System.Windows.Forms.Label arrendatarioLabel;
            this.buttonRemoverArrendamento = new System.Windows.Forms.Button();
            this.buttonInserirArrendamento = new System.Windows.Forms.Button();
            this.inicioContratoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.arrendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duracaoMesesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.renovavelCheckBox = new System.Windows.Forms.CheckBox();
            this.arrendatarioComboBox = new System.Windows.Forms.ComboBox();
            this.casaArrendavelListBox = new System.Windows.Forms.ListBox();
            this.labelCasa = new System.Windows.Forms.Label();
            this.labelIdCasa = new System.Windows.Forms.Label();
            this.labelLocalidade = new System.Windows.Forms.Label();
            this.labelProprietario = new System.Windows.Forms.Label();
            inicioContratoLabel = new System.Windows.Forms.Label();
            duracaoMesesLabel = new System.Windows.Forms.Label();
            arrendatarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.arrendamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duracaoMesesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // inicioContratoLabel
            // 
            inicioContratoLabel.AutoSize = true;
            inicioContratoLabel.Location = new System.Drawing.Point(437, 111);
            inicioContratoLabel.Name = "inicioContratoLabel";
            inicioContratoLabel.Size = new System.Drawing.Size(78, 13);
            inicioContratoLabel.TabIndex = 7;
            inicioContratoLabel.Text = "Inicio Contrato:";
            inicioContratoLabel.Click += new System.EventHandler(this.inicioContratoLabel_Click);
            // 
            // duracaoMesesLabel
            // 
            duracaoMesesLabel.AutoSize = true;
            duracaoMesesLabel.Location = new System.Drawing.Point(437, 162);
            duracaoMesesLabel.Name = "duracaoMesesLabel";
            duracaoMesesLabel.Size = new System.Drawing.Size(85, 13);
            duracaoMesesLabel.TabIndex = 9;
            duracaoMesesLabel.Text = "Duracao Meses:";
            duracaoMesesLabel.Click += new System.EventHandler(this.duracaoMesesLabel_Click);
            // 
            // arrendatarioLabel
            // 
            arrendatarioLabel.AutoSize = true;
            arrendatarioLabel.Location = new System.Drawing.Point(437, 251);
            arrendatarioLabel.Name = "arrendatarioLabel";
            arrendatarioLabel.Size = new System.Drawing.Size(67, 13);
            arrendatarioLabel.TabIndex = 11;
            arrendatarioLabel.Text = "Arrendatario:";
            arrendatarioLabel.Click += new System.EventHandler(this.arrendatarioLabel_Click);
            // 
            // buttonRemoverArrendamento
            // 
            this.buttonRemoverArrendamento.Location = new System.Drawing.Point(52, 342);
            this.buttonRemoverArrendamento.Name = "buttonRemoverArrendamento";
            this.buttonRemoverArrendamento.Size = new System.Drawing.Size(330, 23);
            this.buttonRemoverArrendamento.TabIndex = 0;
            this.buttonRemoverArrendamento.Text = "Remover";
            this.buttonRemoverArrendamento.UseVisualStyleBackColor = true;
            this.buttonRemoverArrendamento.Click += new System.EventHandler(this.buttonRemoverArrendamento_Click);
            // 
            // buttonInserirArrendamento
            // 
            this.buttonInserirArrendamento.Location = new System.Drawing.Point(431, 302);
            this.buttonInserirArrendamento.Name = "buttonInserirArrendamento";
            this.buttonInserirArrendamento.Size = new System.Drawing.Size(200, 23);
            this.buttonInserirArrendamento.TabIndex = 1;
            this.buttonInserirArrendamento.Text = "Inserir";
            this.buttonInserirArrendamento.UseVisualStyleBackColor = true;
            this.buttonInserirArrendamento.Click += new System.EventHandler(this.buttonInserirArrendamento_Click);
            // 
            // inicioContratoDateTimePicker
            // 
            this.inicioContratoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.arrendamentoBindingSource, "InicioContrato", true));
            this.inicioContratoDateTimePicker.Location = new System.Drawing.Point(440, 127);
            this.inicioContratoDateTimePicker.Name = "inicioContratoDateTimePicker";
            this.inicioContratoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.inicioContratoDateTimePicker.TabIndex = 8;
            this.inicioContratoDateTimePicker.ValueChanged += new System.EventHandler(this.inicioContratoDateTimePicker_ValueChanged);
            // 
            // arrendamentoBindingSource
            // 
            this.arrendamentoBindingSource.DataSource = typeof(GCC.Arrendamento);
            // 
            // duracaoMesesNumericUpDown
            // 
            this.duracaoMesesNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.arrendamentoBindingSource, "DuracaoMeses", true));
            this.duracaoMesesNumericUpDown.Location = new System.Drawing.Point(440, 178);
            this.duracaoMesesNumericUpDown.Name = "duracaoMesesNumericUpDown";
            this.duracaoMesesNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.duracaoMesesNumericUpDown.TabIndex = 10;
            this.duracaoMesesNumericUpDown.ValueChanged += new System.EventHandler(this.duracaoMesesNumericUpDown_ValueChanged);
            // 
            // renovavelCheckBox
            // 
            this.renovavelCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.arrendamentoBindingSource, "Renovavel", true));
            this.renovavelCheckBox.Location = new System.Drawing.Point(440, 204);
            this.renovavelCheckBox.Name = "renovavelCheckBox";
            this.renovavelCheckBox.Size = new System.Drawing.Size(104, 24);
            this.renovavelCheckBox.TabIndex = 11;
            this.renovavelCheckBox.Text = "Renovavel";
            this.renovavelCheckBox.UseVisualStyleBackColor = true;
            this.renovavelCheckBox.CheckedChanged += new System.EventHandler(this.renovavelCheckBox_CheckedChanged);
            // 
            // arrendatarioComboBox
            // 
            this.arrendatarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.arrendamentoBindingSource, "Arrendatario", true));
            this.arrendatarioComboBox.FormattingEnabled = true;
            this.arrendatarioComboBox.Location = new System.Drawing.Point(510, 248);
            this.arrendatarioComboBox.Name = "arrendatarioComboBox";
            this.arrendatarioComboBox.Size = new System.Drawing.Size(121, 21);
            this.arrendatarioComboBox.TabIndex = 12;
            this.arrendatarioComboBox.SelectedIndexChanged += new System.EventHandler(this.arrendatarioComboBox_SelectedIndexChanged);
            // 
            // casaArrendavelListBox
            // 
            this.casaArrendavelListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.arrendamentoBindingSource, "CasaArrendavel", true));
            this.casaArrendavelListBox.FormattingEnabled = true;
            this.casaArrendavelListBox.Location = new System.Drawing.Point(52, 111);
            this.casaArrendavelListBox.Name = "casaArrendavelListBox";
            this.casaArrendavelListBox.Size = new System.Drawing.Size(330, 212);
            this.casaArrendavelListBox.TabIndex = 13;
            // 
            // labelCasa
            // 
            this.labelCasa.AutoSize = true;
            this.labelCasa.Location = new System.Drawing.Point(57, 42);
            this.labelCasa.Name = "labelCasa";
            this.labelCasa.Size = new System.Drawing.Size(34, 13);
            this.labelCasa.TabIndex = 14;
            this.labelCasa.Text = "Casa:";
            // 
            // labelIdCasa
            // 
            this.labelIdCasa.AutoSize = true;
            this.labelIdCasa.Location = new System.Drawing.Point(110, 42);
            this.labelIdCasa.Name = "labelIdCasa";
            this.labelIdCasa.Size = new System.Drawing.Size(52, 13);
            this.labelIdCasa.TabIndex = 15;
            this.labelIdCasa.Text = "sem casa";
            this.labelIdCasa.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelLocalidade
            // 
            this.labelLocalidade.AutoSize = true;
            this.labelLocalidade.Location = new System.Drawing.Point(110, 59);
            this.labelLocalidade.Name = "labelLocalidade";
            this.labelLocalidade.Size = new System.Drawing.Size(77, 13);
            this.labelLocalidade.TabIndex = 16;
            this.labelLocalidade.Text = "sem localidade";
            // 
            // labelProprietario
            // 
            this.labelProprietario.AutoSize = true;
            this.labelProprietario.Location = new System.Drawing.Point(110, 79);
            this.labelProprietario.Name = "labelProprietario";
            this.labelProprietario.Size = new System.Drawing.Size(81, 13);
            this.labelProprietario.TabIndex = 17;
            this.labelProprietario.Text = "sem proprietario";
            // 
            // GerirArrendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 382);
            this.Controls.Add(this.labelProprietario);
            this.Controls.Add(this.labelLocalidade);
            this.Controls.Add(this.labelIdCasa);
            this.Controls.Add(this.labelCasa);
            this.Controls.Add(this.casaArrendavelListBox);
            this.Controls.Add(arrendatarioLabel);
            this.Controls.Add(this.arrendatarioComboBox);
            this.Controls.Add(this.renovavelCheckBox);
            this.Controls.Add(duracaoMesesLabel);
            this.Controls.Add(this.duracaoMesesNumericUpDown);
            this.Controls.Add(inicioContratoLabel);
            this.Controls.Add(this.inicioContratoDateTimePicker);
            this.Controls.Add(this.buttonInserirArrendamento);
            this.Controls.Add(this.buttonRemoverArrendamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GerirArrendamentos";
            this.Text = "Arrendamentos";
            this.Load += new System.EventHandler(this.GerirArrendamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arrendamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duracaoMesesNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRemoverArrendamento;
        private System.Windows.Forms.Button buttonInserirArrendamento;
        private System.Windows.Forms.BindingSource arrendamentoBindingSource;
        private System.Windows.Forms.DateTimePicker inicioContratoDateTimePicker;
        private System.Windows.Forms.NumericUpDown duracaoMesesNumericUpDown;
        private System.Windows.Forms.CheckBox renovavelCheckBox;
        private System.Windows.Forms.ComboBox arrendatarioComboBox;
        private System.Windows.Forms.ListBox casaArrendavelListBox;
        private System.Windows.Forms.Label labelCasa;
        private System.Windows.Forms.Label labelIdCasa;
        private System.Windows.Forms.Label labelLocalidade;
        private System.Windows.Forms.Label labelProprietario;
    }
}