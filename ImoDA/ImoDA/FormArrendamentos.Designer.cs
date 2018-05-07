namespace GCC
{
    partial class FormArrendamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArrendamentos));
            this.labelCasa = new System.Windows.Forms.Label();
            this.listBoxCasa = new System.Windows.Forms.ListBox();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.labelInicioContrato = new System.Windows.Forms.Label();
            this.labelDuracaoMeses = new System.Windows.Forms.Label();
            this.numericUpDownDuracaoMeses = new System.Windows.Forms.NumericUpDown();
            this.checkBoxRenovavel = new System.Windows.Forms.CheckBox();
            this.labelArrendatario = new System.Windows.Forms.Label();
            this.comboBoxArrendatario = new System.Windows.Forms.ComboBox();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.labelInfoLote = new System.Windows.Forms.Label();
            this.labelInfoMorada = new System.Windows.Forms.Label();
            this.labelInfoNomeNIF = new System.Windows.Forms.Label();
            this.dateTimePickerInicioContrato = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuracaoMeses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCasa
            // 
            this.labelCasa.AutoSize = true;
            this.labelCasa.Location = new System.Drawing.Point(29, 24);
            this.labelCasa.Name = "labelCasa";
            this.labelCasa.Size = new System.Drawing.Size(37, 13);
            this.labelCasa.TabIndex = 0;
            this.labelCasa.Text = "Casa: ";
            // 
            // listBoxCasa
            // 
            this.listBoxCasa.FormattingEnabled = true;
            this.listBoxCasa.Location = new System.Drawing.Point(32, 103);
            this.listBoxCasa.Name = "listBoxCasa";
            this.listBoxCasa.Size = new System.Drawing.Size(302, 290);
            this.listBoxCasa.TabIndex = 1;
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(32, 411);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(302, 23);
            this.buttonRemover.TabIndex = 2;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            // 
            // labelInicioContrato
            // 
            this.labelInicioContrato.AutoSize = true;
            this.labelInicioContrato.Location = new System.Drawing.Point(367, 103);
            this.labelInicioContrato.Name = "labelInicioContrato";
            this.labelInicioContrato.Size = new System.Drawing.Size(96, 13);
            this.labelInicioContrato.TabIndex = 3;
            this.labelInicioContrato.Text = "Inicio do Contrato: ";
            // 
            // labelDuracaoMeses
            // 
            this.labelDuracaoMeses.AutoSize = true;
            this.labelDuracaoMeses.Location = new System.Drawing.Point(367, 156);
            this.labelDuracaoMeses.Name = "labelDuracaoMeses";
            this.labelDuracaoMeses.Size = new System.Drawing.Size(93, 13);
            this.labelDuracaoMeses.TabIndex = 4;
            this.labelDuracaoMeses.Text = "Duração (meses): ";
            // 
            // numericUpDownDuracaoMeses
            // 
            this.numericUpDownDuracaoMeses.Location = new System.Drawing.Point(370, 180);
            this.numericUpDownDuracaoMeses.Name = "numericUpDownDuracaoMeses";
            this.numericUpDownDuracaoMeses.Size = new System.Drawing.Size(205, 20);
            this.numericUpDownDuracaoMeses.TabIndex = 5;
            // 
            // checkBoxRenovavel
            // 
            this.checkBoxRenovavel.AutoSize = true;
            this.checkBoxRenovavel.Location = new System.Drawing.Point(370, 220);
            this.checkBoxRenovavel.Name = "checkBoxRenovavel";
            this.checkBoxRenovavel.Size = new System.Drawing.Size(84, 17);
            this.checkBoxRenovavel.TabIndex = 6;
            this.checkBoxRenovavel.Text = "Renovável: ";
            this.checkBoxRenovavel.UseVisualStyleBackColor = true;
            // 
            // labelArrendatario
            // 
            this.labelArrendatario.AutoSize = true;
            this.labelArrendatario.Location = new System.Drawing.Point(367, 251);
            this.labelArrendatario.Name = "labelArrendatario";
            this.labelArrendatario.Size = new System.Drawing.Size(70, 13);
            this.labelArrendatario.TabIndex = 7;
            this.labelArrendatario.Text = "Arrendatário: ";
            // 
            // comboBoxArrendatario
            // 
            this.comboBoxArrendatario.FormattingEnabled = true;
            this.comboBoxArrendatario.Location = new System.Drawing.Point(370, 280);
            this.comboBoxArrendatario.Name = "comboBoxArrendatario";
            this.comboBoxArrendatario.Size = new System.Drawing.Size(202, 21);
            this.comboBoxArrendatario.TabIndex = 8;
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(370, 318);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(202, 23);
            this.buttonInserir.TabIndex = 9;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            // 
            // labelInfoLote
            // 
            this.labelInfoLote.AutoSize = true;
            this.labelInfoLote.Location = new System.Drawing.Point(73, 24);
            this.labelInfoLote.Name = "labelInfoLote";
            this.labelInfoLote.Size = new System.Drawing.Size(46, 13);
            this.labelInfoLote.TabIndex = 10;
            this.labelInfoLote.Text = "sem lote";
            // 
            // labelInfoMorada
            // 
            this.labelInfoMorada.AutoSize = true;
            this.labelInfoMorada.Location = new System.Drawing.Point(73, 47);
            this.labelInfoMorada.Name = "labelInfoMorada";
            this.labelInfoMorada.Size = new System.Drawing.Size(64, 13);
            this.labelInfoMorada.TabIndex = 11;
            this.labelInfoMorada.Text = "sem morada";
            // 
            // labelInfoNomeNIF
            // 
            this.labelInfoNomeNIF.AutoSize = true;
            this.labelInfoNomeNIF.Location = new System.Drawing.Point(73, 71);
            this.labelInfoNomeNIF.Name = "labelInfoNomeNIF";
            this.labelInfoNomeNIF.Size = new System.Drawing.Size(78, 13);
            this.labelInfoNomeNIF.TabIndex = 12;
            this.labelInfoNomeNIF.Text = "sem nome + nif";
            // 
            // dateTimePickerInicioContrato
            // 
            this.dateTimePickerInicioContrato.Location = new System.Drawing.Point(370, 125);
            this.dateTimePickerInicioContrato.Name = "dateTimePickerInicioContrato";
            this.dateTimePickerInicioContrato.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerInicioContrato.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(515, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 48);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // FormArrendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePickerInicioContrato);
            this.Controls.Add(this.labelInfoNomeNIF);
            this.Controls.Add(this.labelInfoMorada);
            this.Controls.Add(this.labelInfoLote);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.comboBoxArrendatario);
            this.Controls.Add(this.labelArrendatario);
            this.Controls.Add(this.checkBoxRenovavel);
            this.Controls.Add(this.numericUpDownDuracaoMeses);
            this.Controls.Add(this.labelDuracaoMeses);
            this.Controls.Add(this.labelInicioContrato);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.listBoxCasa);
            this.Controls.Add(this.labelCasa);
            this.Name = "FormArrendamentos";
            this.Text = "FormArrendamentos";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuracaoMeses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCasa;
        private System.Windows.Forms.ListBox listBoxCasa;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Label labelInicioContrato;
        private System.Windows.Forms.Label labelDuracaoMeses;
        private System.Windows.Forms.NumericUpDown numericUpDownDuracaoMeses;
        private System.Windows.Forms.CheckBox checkBoxRenovavel;
        private System.Windows.Forms.Label labelArrendatario;
        private System.Windows.Forms.ComboBox comboBoxArrendatario;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Label labelInfoLote;
        private System.Windows.Forms.Label labelInfoMorada;
        private System.Windows.Forms.Label labelInfoNomeNIF;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicioContrato;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}