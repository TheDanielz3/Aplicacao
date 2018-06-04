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
            System.Windows.Forms.Label casaArrendavelLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            casaArrendavelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.arrendamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duracaoMesesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // inicioContratoLabel
            // 
            inicioContratoLabel.AutoSize = true;
            inicioContratoLabel.Location = new System.Drawing.Point(526, 167);
            inicioContratoLabel.Name = "inicioContratoLabel";
            inicioContratoLabel.Size = new System.Drawing.Size(78, 13);
            inicioContratoLabel.TabIndex = 7;
            inicioContratoLabel.Text = "Inicio Contrato:";
            // 
            // duracaoMesesLabel
            // 
            duracaoMesesLabel.AutoSize = true;
            duracaoMesesLabel.Location = new System.Drawing.Point(526, 227);
            duracaoMesesLabel.Name = "duracaoMesesLabel";
            duracaoMesesLabel.Size = new System.Drawing.Size(85, 13);
            duracaoMesesLabel.TabIndex = 9;
            duracaoMesesLabel.Text = "Duracao Meses:";
            // 
            // arrendatarioLabel
            // 
            arrendatarioLabel.AutoSize = true;
            arrendatarioLabel.Location = new System.Drawing.Point(526, 310);
            arrendatarioLabel.Name = "arrendatarioLabel";
            arrendatarioLabel.Size = new System.Drawing.Size(67, 13);
            arrendatarioLabel.TabIndex = 11;
            arrendatarioLabel.Text = "Arrendatario:";
            // 
            // casaArrendavelLabel
            // 
            casaArrendavelLabel.AutoSize = true;
            casaArrendavelLabel.Location = new System.Drawing.Point(31, 129);
            casaArrendavelLabel.Name = "casaArrendavelLabel";
            casaArrendavelLabel.Size = new System.Drawing.Size(88, 13);
            casaArrendavelLabel.TabIndex = 12;
            casaArrendavelLabel.Text = "Casa Arrendavel:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(330, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(529, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // inicioContratoDateTimePicker
            // 
            this.inicioContratoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.arrendamentoBindingSource, "InicioContrato", true));
            this.inicioContratoDateTimePicker.Location = new System.Drawing.Point(529, 183);
            this.inicioContratoDateTimePicker.Name = "inicioContratoDateTimePicker";
            this.inicioContratoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.inicioContratoDateTimePicker.TabIndex = 8;
            // 
            // arrendamentoBindingSource
            // 
            this.arrendamentoBindingSource.DataSource = typeof(GCC.Arrendamento);
            // 
            // duracaoMesesNumericUpDown
            // 
            this.duracaoMesesNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.arrendamentoBindingSource, "DuracaoMeses", true));
            this.duracaoMesesNumericUpDown.Location = new System.Drawing.Point(529, 243);
            this.duracaoMesesNumericUpDown.Name = "duracaoMesesNumericUpDown";
            this.duracaoMesesNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.duracaoMesesNumericUpDown.TabIndex = 10;
            // 
            // renovavelCheckBox
            // 
            this.renovavelCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.arrendamentoBindingSource, "Renovavel", true));
            this.renovavelCheckBox.Location = new System.Drawing.Point(529, 269);
            this.renovavelCheckBox.Name = "renovavelCheckBox";
            this.renovavelCheckBox.Size = new System.Drawing.Size(104, 24);
            this.renovavelCheckBox.TabIndex = 11;
            this.renovavelCheckBox.Text = "Renovavel";
            this.renovavelCheckBox.UseVisualStyleBackColor = true;
            // 
            // arrendatarioComboBox
            // 
            this.arrendatarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.arrendamentoBindingSource, "Arrendatario", true));
            this.arrendatarioComboBox.FormattingEnabled = true;
            this.arrendatarioComboBox.Location = new System.Drawing.Point(599, 307);
            this.arrendatarioComboBox.Name = "arrendatarioComboBox";
            this.arrendatarioComboBox.Size = new System.Drawing.Size(121, 21);
            this.arrendatarioComboBox.TabIndex = 12;
            // 
            // casaArrendavelListBox
            // 
            this.casaArrendavelListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.arrendamentoBindingSource, "CasaArrendavel", true));
            this.casaArrendavelListBox.FormattingEnabled = true;
            this.casaArrendavelListBox.Location = new System.Drawing.Point(52, 145);
            this.casaArrendavelListBox.Name = "casaArrendavelListBox";
            this.casaArrendavelListBox.Size = new System.Drawing.Size(330, 251);
            this.casaArrendavelListBox.TabIndex = 13;
            // 
            // labelCasa
            // 
            this.labelCasa.AutoSize = true;
            this.labelCasa.Location = new System.Drawing.Point(31, 56);
            this.labelCasa.Name = "labelCasa";
            this.labelCasa.Size = new System.Drawing.Size(34, 13);
            this.labelCasa.TabIndex = 14;
            this.labelCasa.Text = "Casa:";
            // 
            // labelIdCasa
            // 
            this.labelIdCasa.AutoSize = true;
            this.labelIdCasa.Location = new System.Drawing.Point(84, 56);
            this.labelIdCasa.Name = "labelIdCasa";
            this.labelIdCasa.Size = new System.Drawing.Size(52, 13);
            this.labelIdCasa.TabIndex = 15;
            this.labelIdCasa.Text = "sem casa";
            this.labelIdCasa.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelLocalidade
            // 
            this.labelLocalidade.AutoSize = true;
            this.labelLocalidade.Location = new System.Drawing.Point(84, 73);
            this.labelLocalidade.Name = "labelLocalidade";
            this.labelLocalidade.Size = new System.Drawing.Size(77, 13);
            this.labelLocalidade.TabIndex = 16;
            this.labelLocalidade.Text = "sem localidade";
            // 
            // labelProprietario
            // 
            this.labelProprietario.AutoSize = true;
            this.labelProprietario.Location = new System.Drawing.Point(84, 93);
            this.labelProprietario.Name = "labelProprietario";
            this.labelProprietario.Size = new System.Drawing.Size(81, 13);
            this.labelProprietario.TabIndex = 17;
            this.labelProprietario.Text = "sem proprietario";
            // 
            // GerirArrendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.labelProprietario);
            this.Controls.Add(this.labelLocalidade);
            this.Controls.Add(this.labelIdCasa);
            this.Controls.Add(this.labelCasa);
            this.Controls.Add(casaArrendavelLabel);
            this.Controls.Add(this.casaArrendavelListBox);
            this.Controls.Add(arrendatarioLabel);
            this.Controls.Add(this.arrendatarioComboBox);
            this.Controls.Add(this.renovavelCheckBox);
            this.Controls.Add(duracaoMesesLabel);
            this.Controls.Add(this.duracaoMesesNumericUpDown);
            this.Controls.Add(inicioContratoLabel);
            this.Controls.Add(this.inicioContratoDateTimePicker);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "GerirArrendamentos";
            this.Text = "GerirArrendamentos";
            ((System.ComponentModel.ISupportInitialize)(this.arrendamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duracaoMesesNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
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