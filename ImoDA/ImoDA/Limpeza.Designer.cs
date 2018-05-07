namespace GCC
{
    partial class Limpeza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Limpeza));
            this.labelBase = new System.Windows.Forms.Label();
            this.listBoxFatura = new System.Windows.Forms.ListBox();
            this.groupBoxDetalhesLimpeza = new System.Windows.Forms.GroupBox();
            this.listBoxValorUnitario = new System.Windows.Forms.ListBox();
            this.labelValorUnitario = new System.Windows.Forms.Label();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.domainUpDownQuantidade = new System.Windows.Forms.DomainUpDown();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.comboBoxServico = new System.Windows.Forms.ComboBox();
            this.labelServico = new System.Windows.Forms.Label();
            this.buttonEmitirFatura = new System.Windows.Forms.Button();
            this.buttonCriar = new System.Windows.Forms.Button();
            this.labelInfoBase = new System.Windows.Forms.Label();
            this.dateTimePickerFatura = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxDetalhesLimpeza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBase
            // 
            this.labelBase.AutoSize = true;
            this.labelBase.Location = new System.Drawing.Point(13, 13);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(34, 13);
            this.labelBase.TabIndex = 0;
            this.labelBase.Text = "Base:";
            // 
            // listBoxFatura
            // 
            this.listBoxFatura.FormattingEnabled = true;
            this.listBoxFatura.Location = new System.Drawing.Point(12, 68);
            this.listBoxFatura.Name = "listBoxFatura";
            this.listBoxFatura.Size = new System.Drawing.Size(249, 316);
            this.listBoxFatura.TabIndex = 1;
            // 
            // groupBoxDetalhesLimpeza
            // 
            this.groupBoxDetalhesLimpeza.Controls.Add(this.listBoxValorUnitario);
            this.groupBoxDetalhesLimpeza.Controls.Add(this.labelValorUnitario);
            this.groupBoxDetalhesLimpeza.Controls.Add(this.buttonInserir);
            this.groupBoxDetalhesLimpeza.Controls.Add(this.domainUpDownQuantidade);
            this.groupBoxDetalhesLimpeza.Controls.Add(this.labelQuantidade);
            this.groupBoxDetalhesLimpeza.Controls.Add(this.comboBoxServico);
            this.groupBoxDetalhesLimpeza.Controls.Add(this.labelServico);
            this.groupBoxDetalhesLimpeza.Location = new System.Drawing.Point(267, 68);
            this.groupBoxDetalhesLimpeza.Name = "groupBoxDetalhesLimpeza";
            this.groupBoxDetalhesLimpeza.Size = new System.Drawing.Size(518, 379);
            this.groupBoxDetalhesLimpeza.TabIndex = 2;
            this.groupBoxDetalhesLimpeza.TabStop = false;
            this.groupBoxDetalhesLimpeza.Text = "Detalhes da Limpeza";
            // 
            // listBoxValorUnitario
            // 
            this.listBoxValorUnitario.FormattingEnabled = true;
            this.listBoxValorUnitario.Location = new System.Drawing.Point(7, 97);
            this.listBoxValorUnitario.Name = "listBoxValorUnitario";
            this.listBoxValorUnitario.Size = new System.Drawing.Size(505, 277);
            this.listBoxValorUnitario.TabIndex = 6;
            // 
            // labelValorUnitario
            // 
            this.labelValorUnitario.AutoSize = true;
            this.labelValorUnitario.Location = new System.Drawing.Point(29, 74);
            this.labelValorUnitario.Name = "labelValorUnitario";
            this.labelValorUnitario.Size = new System.Drawing.Size(76, 13);
            this.labelValorUnitario.TabIndex = 5;
            this.labelValorUnitario.Text = "Valor Unitário: ";
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(430, 32);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(75, 23);
            this.buttonInserir.TabIndex = 4;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            // 
            // domainUpDownQuantidade
            // 
            this.domainUpDownQuantidade.Location = new System.Drawing.Point(339, 35);
            this.domainUpDownQuantidade.Name = "domainUpDownQuantidade";
            this.domainUpDownQuantidade.Size = new System.Drawing.Size(75, 20);
            this.domainUpDownQuantidade.TabIndex = 3;
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Location = new System.Drawing.Point(265, 38);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(68, 13);
            this.labelQuantidade.TabIndex = 2;
            this.labelQuantidade.Text = "Quantidade: ";
            // 
            // comboBoxServico
            // 
            this.comboBoxServico.FormattingEnabled = true;
            this.comboBoxServico.Location = new System.Drawing.Point(81, 35);
            this.comboBoxServico.Name = "comboBoxServico";
            this.comboBoxServico.Size = new System.Drawing.Size(170, 21);
            this.comboBoxServico.TabIndex = 1;
            // 
            // labelServico
            // 
            this.labelServico.AutoSize = true;
            this.labelServico.Location = new System.Drawing.Point(26, 38);
            this.labelServico.Name = "labelServico";
            this.labelServico.Size = new System.Drawing.Size(49, 13);
            this.labelServico.TabIndex = 0;
            this.labelServico.Text = "Serviço: ";
            // 
            // buttonEmitirFatura
            // 
            this.buttonEmitirFatura.Location = new System.Drawing.Point(12, 390);
            this.buttonEmitirFatura.Name = "buttonEmitirFatura";
            this.buttonEmitirFatura.Size = new System.Drawing.Size(249, 23);
            this.buttonEmitirFatura.TabIndex = 3;
            this.buttonEmitirFatura.Text = "Emitir Fatura";
            this.buttonEmitirFatura.UseVisualStyleBackColor = true;
            this.buttonEmitirFatura.Click += new System.EventHandler(this.buttonEmitirFatura_Click);
            // 
            // buttonCriar
            // 
            this.buttonCriar.Location = new System.Drawing.Point(186, 416);
            this.buttonCriar.Name = "buttonCriar";
            this.buttonCriar.Size = new System.Drawing.Size(75, 23);
            this.buttonCriar.TabIndex = 4;
            this.buttonCriar.Text = "Criar";
            this.buttonCriar.UseVisualStyleBackColor = true;
            // 
            // labelInfoBase
            // 
            this.labelInfoBase.AutoSize = true;
            this.labelInfoBase.Location = new System.Drawing.Point(54, 13);
            this.labelInfoBase.Name = "labelInfoBase";
            this.labelInfoBase.Size = new System.Drawing.Size(55, 13);
            this.labelInfoBase.TabIndex = 5;
            this.labelInfoBase.Text = "Sem Base";
            // 
            // dateTimePickerFatura
            // 
            this.dateTimePickerFatura.Location = new System.Drawing.Point(13, 418);
            this.dateTimePickerFatura.Name = "dateTimePickerFatura";
            this.dateTimePickerFatura.Size = new System.Drawing.Size(167, 20);
            this.dateTimePickerFatura.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(720, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Limpeza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePickerFatura);
            this.Controls.Add(this.labelInfoBase);
            this.Controls.Add(this.buttonCriar);
            this.Controls.Add(this.buttonEmitirFatura);
            this.Controls.Add(this.groupBoxDetalhesLimpeza);
            this.Controls.Add(this.listBoxFatura);
            this.Controls.Add(this.labelBase);
            this.Name = "Limpeza";
            this.Text = "Limpezas";
            this.groupBoxDetalhesLimpeza.ResumeLayout(false);
            this.groupBoxDetalhesLimpeza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBase;
        private System.Windows.Forms.ListBox listBoxFatura;
        private System.Windows.Forms.GroupBox groupBoxDetalhesLimpeza;
        private System.Windows.Forms.ListBox listBoxValorUnitario;
        private System.Windows.Forms.Label labelValorUnitario;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.DomainUpDown domainUpDownQuantidade;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.ComboBox comboBoxServico;
        private System.Windows.Forms.Label labelServico;
        private System.Windows.Forms.Button buttonEmitirFatura;
        private System.Windows.Forms.Button buttonCriar;
        private System.Windows.Forms.Label labelInfoBase;
        private System.Windows.Forms.DateTimePicker dateTimePickerFatura;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}