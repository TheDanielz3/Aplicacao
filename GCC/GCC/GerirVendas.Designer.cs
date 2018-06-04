namespace GCC
{
    partial class GerirVendas
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
            System.Windows.Forms.Label dataVendaLabel;
            System.Windows.Forms.Label valorNegociadoLabel;
            System.Windows.Forms.Label comissaoNegocioLabel;
            System.Windows.Forms.Label compradorLabel;
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelProprietario = new System.Windows.Forms.Label();
            this.labelValorBase = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataVendaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.valorNegociadoTextBox = new System.Windows.Forms.TextBox();
            this.comissaoNegocioTextBox = new System.Windows.Forms.TextBox();
            this.compradorComboBox = new System.Windows.Forms.ComboBox();
            this.labelEuro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelEstadoInfo = new System.Windows.Forms.Label();
            this.labelProprietarioInfo = new System.Windows.Forms.Label();
            this.labelBaseInfo = new System.Windows.Forms.Label();
            this.labelComissaoBaseInfo = new System.Windows.Forms.Label();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonEfetivarVenda = new System.Windows.Forms.Button();
            dataVendaLabel = new System.Windows.Forms.Label();
            valorNegociadoLabel = new System.Windows.Forms.Label();
            comissaoNegocioLabel = new System.Windows.Forms.Label();
            compradorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(13, 13);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(46, 13);
            this.labelEstado.TabIndex = 0;
            this.labelEstado.Text = "Estado: ";
            // 
            // labelProprietario
            // 
            this.labelProprietario.AutoSize = true;
            this.labelProprietario.Location = new System.Drawing.Point(13, 44);
            this.labelProprietario.Name = "labelProprietario";
            this.labelProprietario.Size = new System.Drawing.Size(63, 13);
            this.labelProprietario.TabIndex = 1;
            this.labelProprietario.Text = "Proprietário:";
            // 
            // labelValorBase
            // 
            this.labelValorBase.AutoSize = true;
            this.labelValorBase.Location = new System.Drawing.Point(13, 78);
            this.labelValorBase.Name = "labelValorBase";
            this.labelValorBase.Size = new System.Drawing.Size(61, 13);
            this.labelValorBase.TabIndex = 2;
            this.labelValorBase.Text = "Valor Base:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Comissão Base:";
            // 
            // dataVendaLabel
            // 
            dataVendaLabel.AutoSize = true;
            dataVendaLabel.Location = new System.Drawing.Point(12, 151);
            dataVendaLabel.Name = "dataVendaLabel";
            dataVendaLabel.Size = new System.Drawing.Size(67, 13);
            dataVendaLabel.TabIndex = 4;
            dataVendaLabel.Text = "Data Venda:";
            // 
            // dataVendaDateTimePicker
            // 
            this.dataVendaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vendaBindingSource, "DataVenda", true));
            this.dataVendaDateTimePicker.Location = new System.Drawing.Point(115, 145);
            this.dataVendaDateTimePicker.Name = "dataVendaDateTimePicker";
            this.dataVendaDateTimePicker.Size = new System.Drawing.Size(191, 20);
            this.dataVendaDateTimePicker.TabIndex = 5;
            // 
            // valorNegociadoLabel
            // 
            valorNegociadoLabel.AutoSize = true;
            valorNegociadoLabel.Location = new System.Drawing.Point(12, 183);
            valorNegociadoLabel.Name = "valorNegociadoLabel";
            valorNegociadoLabel.Size = new System.Drawing.Size(89, 13);
            valorNegociadoLabel.TabIndex = 6;
            valorNegociadoLabel.Text = "Valor Negociado:";
            // 
            // valorNegociadoTextBox
            // 
            this.valorNegociadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "ValorNegociado", true));
            this.valorNegociadoTextBox.Location = new System.Drawing.Point(116, 180);
            this.valorNegociadoTextBox.Name = "valorNegociadoTextBox";
            this.valorNegociadoTextBox.Size = new System.Drawing.Size(162, 20);
            this.valorNegociadoTextBox.TabIndex = 7;
            // 
            // comissaoNegocioLabel
            // 
            comissaoNegocioLabel.AutoSize = true;
            comissaoNegocioLabel.Location = new System.Drawing.Point(12, 219);
            comissaoNegocioLabel.Name = "comissaoNegocioLabel";
            comissaoNegocioLabel.Size = new System.Drawing.Size(97, 13);
            comissaoNegocioLabel.TabIndex = 8;
            comissaoNegocioLabel.Text = "Valor da Comissao:";
            // 
            // comissaoNegocioTextBox
            // 
            this.comissaoNegocioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "ComissaoNegocio", true));
            this.comissaoNegocioTextBox.Location = new System.Drawing.Point(116, 216);
            this.comissaoNegocioTextBox.Name = "comissaoNegocioTextBox";
            this.comissaoNegocioTextBox.Size = new System.Drawing.Size(162, 20);
            this.comissaoNegocioTextBox.TabIndex = 9;
            // 
            // compradorLabel
            // 
            compradorLabel.AutoSize = true;
            compradorLabel.Location = new System.Drawing.Point(13, 259);
            compradorLabel.Name = "compradorLabel";
            compradorLabel.Size = new System.Drawing.Size(61, 13);
            compradorLabel.TabIndex = 10;
            compradorLabel.Text = "Comprador:";
            // 
            // compradorComboBox
            // 
            this.compradorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Comprador", true));
            this.compradorComboBox.FormattingEnabled = true;
            this.compradorComboBox.Location = new System.Drawing.Point(115, 256);
            this.compradorComboBox.Name = "compradorComboBox";
            this.compradorComboBox.Size = new System.Drawing.Size(191, 21);
            this.compradorComboBox.TabIndex = 11;
            // 
            // labelEuro
            // 
            this.labelEuro.AutoSize = true;
            this.labelEuro.Location = new System.Drawing.Point(294, 183);
            this.labelEuro.Name = "labelEuro";
            this.labelEuro.Size = new System.Drawing.Size(13, 13);
            this.labelEuro.TabIndex = 12;
            this.labelEuro.Text = "€";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "€";
            // 
            // labelEstadoInfo
            // 
            this.labelEstadoInfo.AutoSize = true;
            this.labelEstadoInfo.Location = new System.Drawing.Point(113, 13);
            this.labelEstadoInfo.Name = "labelEstadoInfo";
            this.labelEstadoInfo.Size = new System.Drawing.Size(61, 13);
            this.labelEstadoInfo.TabIndex = 14;
            this.labelEstadoInfo.Text = "sem estado";
            // 
            // labelProprietarioInfo
            // 
            this.labelProprietarioInfo.AutoSize = true;
            this.labelProprietarioInfo.Location = new System.Drawing.Point(113, 44);
            this.labelProprietarioInfo.Name = "labelProprietarioInfo";
            this.labelProprietarioInfo.Size = new System.Drawing.Size(81, 13);
            this.labelProprietarioInfo.TabIndex = 15;
            this.labelProprietarioInfo.Text = "sem proprietário";
            // 
            // labelBaseInfo
            // 
            this.labelBaseInfo.AutoSize = true;
            this.labelBaseInfo.Location = new System.Drawing.Point(113, 78);
            this.labelBaseInfo.Name = "labelBaseInfo";
            this.labelBaseInfo.Size = new System.Drawing.Size(52, 13);
            this.labelBaseInfo.TabIndex = 16;
            this.labelBaseInfo.Text = "sem base";
            // 
            // labelComissaoBaseInfo
            // 
            this.labelComissaoBaseInfo.AutoSize = true;
            this.labelComissaoBaseInfo.Location = new System.Drawing.Point(113, 110);
            this.labelComissaoBaseInfo.Name = "labelComissaoBaseInfo";
            this.labelComissaoBaseInfo.Size = new System.Drawing.Size(99, 13);
            this.labelComissaoBaseInfo.TabIndex = 17;
            this.labelComissaoBaseInfo.Text = "sem comissão base";
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(GCC.Venda);
            // 
            // buttonEfetivarVenda
            // 
            this.buttonEfetivarVenda.Location = new System.Drawing.Point(15, 293);
            this.buttonEfetivarVenda.Name = "buttonEfetivarVenda";
            this.buttonEfetivarVenda.Size = new System.Drawing.Size(291, 23);
            this.buttonEfetivarVenda.TabIndex = 18;
            this.buttonEfetivarVenda.Text = "Efetivar Venda";
            this.buttonEfetivarVenda.UseVisualStyleBackColor = true;
            this.buttonEfetivarVenda.Click += new System.EventHandler(this.buttonEfetivarVenda_Click);
            // 
            // GerirVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 328);
            this.Controls.Add(this.buttonEfetivarVenda);
            this.Controls.Add(this.labelComissaoBaseInfo);
            this.Controls.Add(this.labelBaseInfo);
            this.Controls.Add(this.labelProprietarioInfo);
            this.Controls.Add(this.labelEstadoInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelEuro);
            this.Controls.Add(compradorLabel);
            this.Controls.Add(this.compradorComboBox);
            this.Controls.Add(comissaoNegocioLabel);
            this.Controls.Add(this.comissaoNegocioTextBox);
            this.Controls.Add(valorNegociadoLabel);
            this.Controls.Add(this.valorNegociadoTextBox);
            this.Controls.Add(dataVendaLabel);
            this.Controls.Add(this.dataVendaDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelValorBase);
            this.Controls.Add(this.labelProprietario);
            this.Controls.Add(this.labelEstado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GerirVendas";
            this.Text = "x";
            this.Load += new System.EventHandler(this.GerirVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelProprietario;
        private System.Windows.Forms.Label labelValorBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.DateTimePicker dataVendaDateTimePicker;
        private System.Windows.Forms.TextBox valorNegociadoTextBox;
        private System.Windows.Forms.TextBox comissaoNegocioTextBox;
        private System.Windows.Forms.ComboBox compradorComboBox;
        private System.Windows.Forms.Label labelEuro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelEstadoInfo;
        private System.Windows.Forms.Label labelProprietarioInfo;
        private System.Windows.Forms.Label labelBaseInfo;
        private System.Windows.Forms.Label labelComissaoBaseInfo;
        private System.Windows.Forms.Button buttonEfetivarVenda;
    }
}