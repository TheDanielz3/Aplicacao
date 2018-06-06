namespace GCC
{
    partial class GerirLimpezas
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
            System.Windows.Forms.Label descricaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirLimpezas));
            System.Windows.Forms.Label unidadesLabel;
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.limpezaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonCriarFatura = new System.Windows.Forms.Button();
            this.buttonEmitirFatura = new System.Windows.Forms.Button();
            this.servicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicosListBox = new System.Windows.Forms.ListBox();
            this.limpezaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.limpezaListBox = new System.Windows.Forms.ListBox();
            this.groupBoxDetalhesLimpeza = new System.Windows.Forms.GroupBox();
            this.numericUpDownValor = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownUnidades = new System.Windows.Forms.NumericUpDown();
            this.buttonInserirServico = new System.Windows.Forms.Button();
            this.descricaoComboBox = new System.Windows.Forms.ComboBox();
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelNomeCasa = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            unidadesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limpezaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limpezaBindingSource1)).BeginInit();
            this.groupBoxDetalhesLimpeza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            resources.ApplyResources(descricaoLabel, "descricaoLabel");
            descricaoLabel.Name = "descricaoLabel";
            // 
            // unidadesLabel
            // 
            resources.ApplyResources(unidadesLabel, "unidadesLabel");
            unidadesLabel.Name = "unidadesLabel";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(GCC.Cliente);
            // 
            // limpezaBindingSource
            // 
            this.limpezaBindingSource.DataSource = typeof(GCC.Limpeza);
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.limpezaBindingSource, "Data", true));
            resources.ApplyResources(this.dataDateTimePicker, "dataDateTimePicker");
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            // 
            // buttonCriarFatura
            // 
            resources.ApplyResources(this.buttonCriarFatura, "buttonCriarFatura");
            this.buttonCriarFatura.Name = "buttonCriarFatura";
            this.buttonCriarFatura.UseVisualStyleBackColor = true;
            this.buttonCriarFatura.Click += new System.EventHandler(this.buttonCriar_Click);
            // 
            // buttonEmitirFatura
            // 
            resources.ApplyResources(this.buttonEmitirFatura, "buttonEmitirFatura");
            this.buttonEmitirFatura.Name = "buttonEmitirFatura";
            this.buttonEmitirFatura.UseVisualStyleBackColor = true;
            this.buttonEmitirFatura.Click += new System.EventHandler(this.buttonEmitirFatura_Click);
            // 
            // servicosBindingSource
            // 
            this.servicosBindingSource.DataMember = "Servicos";
            this.servicosBindingSource.DataSource = this.limpezaBindingSource;
            // 
            // servicosListBox
            // 
            this.servicosListBox.DataSource = this.servicosBindingSource;
            this.servicosListBox.DisplayMember = "Descricao";
            this.servicosListBox.FormattingEnabled = true;
            resources.ApplyResources(this.servicosListBox, "servicosListBox");
            this.servicosListBox.Name = "servicosListBox";
            this.servicosListBox.ValueMember = "Descricao";
            // 
            // limpezaBindingSource1
            // 
            this.limpezaBindingSource1.DataSource = typeof(GCC.Limpeza);
            // 
            // limpezaListBox
            // 
            this.limpezaListBox.DataSource = this.limpezaBindingSource1;
            this.limpezaListBox.DisplayMember = "Data";
            this.limpezaListBox.FormattingEnabled = true;
            resources.ApplyResources(this.limpezaListBox, "limpezaListBox");
            this.limpezaListBox.Name = "limpezaListBox";
            this.limpezaListBox.ValueMember = "Casa";
            this.limpezaListBox.SelectedIndexChanged += new System.EventHandler(this.limpezaListBox_SelectedIndexChanged);
            // 
            // groupBoxDetalhesLimpeza
            // 
            this.groupBoxDetalhesLimpeza.Controls.Add(this.numericUpDownValor);
            this.groupBoxDetalhesLimpeza.Controls.Add(this.numericUpDownUnidades);
            this.groupBoxDetalhesLimpeza.Controls.Add(this.buttonInserirServico);
            this.groupBoxDetalhesLimpeza.Controls.Add(unidadesLabel);
            this.groupBoxDetalhesLimpeza.Controls.Add(descricaoLabel);
            this.groupBoxDetalhesLimpeza.Controls.Add(this.descricaoComboBox);
            this.groupBoxDetalhesLimpeza.Controls.Add(this.servicosListBox);
            resources.ApplyResources(this.groupBoxDetalhesLimpeza, "groupBoxDetalhesLimpeza");
            this.groupBoxDetalhesLimpeza.Name = "groupBoxDetalhesLimpeza";
            this.groupBoxDetalhesLimpeza.TabStop = false;
            // 
            // numericUpDownValor
            // 
            resources.ApplyResources(this.numericUpDownValor, "numericUpDownValor");
            this.numericUpDownValor.Name = "numericUpDownValor";
            // 
            // numericUpDownUnidades
            // 
            resources.ApplyResources(this.numericUpDownUnidades, "numericUpDownUnidades");
            this.numericUpDownUnidades.Name = "numericUpDownUnidades";
            // 
            // buttonInserirServico
            // 
            resources.ApplyResources(this.buttonInserirServico, "buttonInserirServico");
            this.buttonInserirServico.Name = "buttonInserirServico";
            this.buttonInserirServico.UseVisualStyleBackColor = true;
            this.buttonInserirServico.Click += new System.EventHandler(this.buttonInserirServico_Click);
            // 
            // descricaoComboBox
            // 
            this.descricaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Descricao", true));
            this.descricaoComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.descricaoComboBox, "descricaoComboBox");
            this.descricaoComboBox.Name = "descricaoComboBox";
            this.descricaoComboBox.SelectedIndexChanged += new System.EventHandler(this.descricaoComboBox_SelectedIndexChanged);
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataSource = typeof(GCC.Servico);
            // 
            // labelNomeCasa
            // 
            resources.ApplyResources(this.labelNomeCasa, "labelNomeCasa");
            this.labelNomeCasa.Name = "labelNomeCasa";
            // 
            // GerirLimpezas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelNomeCasa);
            this.Controls.Add(this.limpezaListBox);
            this.Controls.Add(this.buttonEmitirFatura);
            this.Controls.Add(this.buttonCriarFatura);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(this.groupBoxDetalhesLimpeza);
            this.Name = "GerirLimpezas";
            this.Load += new System.EventHandler(this.GerirLimpezas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limpezaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limpezaBindingSource1)).EndInit();
            this.groupBoxDetalhesLimpeza.ResumeLayout(false);
            this.groupBoxDetalhesLimpeza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.BindingSource limpezaBindingSource;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.Button buttonCriarFatura;
        private System.Windows.Forms.Button buttonEmitirFatura;
        private System.Windows.Forms.BindingSource servicosBindingSource;
        private System.Windows.Forms.ListBox servicosListBox;
        private System.Windows.Forms.BindingSource limpezaBindingSource1;
        private System.Windows.Forms.ListBox limpezaListBox;
        private System.Windows.Forms.GroupBox groupBoxDetalhesLimpeza;
        private System.Windows.Forms.Button buttonInserirServico;
        private System.Windows.Forms.BindingSource servicoBindingSource;
        private System.Windows.Forms.ComboBox descricaoComboBox;
        private System.Windows.Forms.Label labelNomeCasa;
        private System.Windows.Forms.NumericUpDown numericUpDownUnidades;
        private System.Windows.Forms.NumericUpDown numericUpDownValor;
    }
}