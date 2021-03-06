﻿namespace GCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirLimpezas));
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label unidadesLabel;
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.limpezaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonCriar = new System.Windows.Forms.Button();
            this.buttonEmitirFatura = new System.Windows.Forms.Button();
            this.servicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicosListBox = new System.Windows.Forms.ListBox();
            this.limpezaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.limpezaListBox = new System.Windows.Forms.ListBox();
            this.groupBoxDetalhesLimpeza = new System.Windows.Forms.GroupBox();
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descricaoComboBox = new System.Windows.Forms.ComboBox();
            this.unidadesDomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.buttonInserirServico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            unidadesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limpezaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limpezaBindingSource1)).BeginInit();
            this.groupBoxDetalhesLimpeza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // buttonCriar
            // 
            resources.ApplyResources(this.buttonCriar, "buttonCriar");
            this.buttonCriar.Name = "buttonCriar";
            this.buttonCriar.UseVisualStyleBackColor = true;
            // 
            // buttonEmitirFatura
            // 
            resources.ApplyResources(this.buttonEmitirFatura, "buttonEmitirFatura");
            this.buttonEmitirFatura.Name = "buttonEmitirFatura";
            this.buttonEmitirFatura.UseVisualStyleBackColor = true;
            // 
            // servicosBindingSource
            // 
            this.servicosBindingSource.DataMember = "Servicos";
            this.servicosBindingSource.DataSource = this.limpezaBindingSource;
            // 
            // servicosListBox
            // 
            this.servicosListBox.DataSource = this.servicosBindingSource;
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
            this.groupBoxDetalhesLimpeza.Controls.Add(this.buttonInserirServico);
            this.groupBoxDetalhesLimpeza.Controls.Add(unidadesLabel);
            this.groupBoxDetalhesLimpeza.Controls.Add(this.unidadesDomainUpDown);
            this.groupBoxDetalhesLimpeza.Controls.Add(descricaoLabel);
            this.groupBoxDetalhesLimpeza.Controls.Add(this.descricaoComboBox);
            this.groupBoxDetalhesLimpeza.Controls.Add(this.servicosListBox);
            resources.ApplyResources(this.groupBoxDetalhesLimpeza, "groupBoxDetalhesLimpeza");
            this.groupBoxDetalhesLimpeza.Name = "groupBoxDetalhesLimpeza";
            this.groupBoxDetalhesLimpeza.TabStop = false;
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataSource = typeof(GCC.Servico);
            // 
            // descricaoLabel
            // 
            resources.ApplyResources(descricaoLabel, "descricaoLabel");
            descricaoLabel.Name = "descricaoLabel";
            // 
            // descricaoComboBox
            // 
            this.descricaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "Descricao", true));
            this.descricaoComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.descricaoComboBox, "descricaoComboBox");
            this.descricaoComboBox.Name = "descricaoComboBox";
            // 
            // unidadesLabel
            // 
            resources.ApplyResources(unidadesLabel, "unidadesLabel");
            unidadesLabel.Name = "unidadesLabel";
            // 
            // unidadesDomainUpDown
            // 
            this.unidadesDomainUpDown.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.servicoBindingSource, "Unidades", true));
            resources.ApplyResources(this.unidadesDomainUpDown, "unidadesDomainUpDown");
            this.unidadesDomainUpDown.Name = "unidadesDomainUpDown";
            // 
            // buttonInserirServico
            // 
            resources.ApplyResources(this.buttonInserirServico, "buttonInserirServico");
            this.buttonInserirServico.Name = "buttonInserirServico";
            this.buttonInserirServico.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // GerirLimpezas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.limpezaListBox);
            this.Controls.Add(this.buttonEmitirFatura);
            this.Controls.Add(this.buttonCriar);
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
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.BindingSource limpezaBindingSource;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.Button buttonCriar;
        private System.Windows.Forms.Button buttonEmitirFatura;
        private System.Windows.Forms.BindingSource servicosBindingSource;
        private System.Windows.Forms.ListBox servicosListBox;
        private System.Windows.Forms.BindingSource limpezaBindingSource1;
        private System.Windows.Forms.ListBox limpezaListBox;
        private System.Windows.Forms.GroupBox groupBoxDetalhesLimpeza;
        private System.Windows.Forms.Button buttonInserirServico;
        private System.Windows.Forms.DomainUpDown unidadesDomainUpDown;
        private System.Windows.Forms.BindingSource servicoBindingSource;
        private System.Windows.Forms.ComboBox descricaoComboBox;
        private System.Windows.Forms.Label label1;
    }
}