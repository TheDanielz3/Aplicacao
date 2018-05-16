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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirArrendamentos));
            System.Windows.Forms.Label inicioContratoLabel;
            System.Windows.Forms.Label duracaoMesesLabel;
            System.Windows.Forms.Label arrendatarioLabel;
            System.Windows.Forms.Label casaArrendavelLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.arrendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arrendamentoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.arrendamentoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.inicioContratoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.duracaoMesesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.renovavelCheckBox = new System.Windows.Forms.CheckBox();
            this.arrendatarioComboBox = new System.Windows.Forms.ComboBox();
            this.casaArrendavelListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            inicioContratoLabel = new System.Windows.Forms.Label();
            duracaoMesesLabel = new System.Windows.Forms.Label();
            arrendatarioLabel = new System.Windows.Forms.Label();
            casaArrendavelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.arrendamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrendamentoBindingNavigator)).BeginInit();
            this.arrendamentoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duracaoMesesNumericUpDown)).BeginInit();
            this.SuspendLayout();
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
            this.button2.Location = new System.Drawing.Point(529, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // arrendamentoBindingSource
            // 
            this.arrendamentoBindingSource.DataSource = typeof(GCC.Arrendamento);
            // 
            // arrendamentoBindingNavigator
            // 
            this.arrendamentoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.arrendamentoBindingNavigator.BindingSource = this.arrendamentoBindingSource;
            this.arrendamentoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.arrendamentoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.arrendamentoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.arrendamentoBindingNavigatorSaveItem});
            this.arrendamentoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.arrendamentoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.arrendamentoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.arrendamentoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.arrendamentoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.arrendamentoBindingNavigator.Name = "arrendamentoBindingNavigator";
            this.arrendamentoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.arrendamentoBindingNavigator.Size = new System.Drawing.Size(840, 25);
            this.arrendamentoBindingNavigator.TabIndex = 7;
            this.arrendamentoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // arrendamentoBindingNavigatorSaveItem
            // 
            this.arrendamentoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.arrendamentoBindingNavigatorSaveItem.Enabled = false;
            this.arrendamentoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("arrendamentoBindingNavigatorSaveItem.Image")));
            this.arrendamentoBindingNavigatorSaveItem.Name = "arrendamentoBindingNavigatorSaveItem";
            this.arrendamentoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.arrendamentoBindingNavigatorSaveItem.Text = "Save Data";
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
            // inicioContratoDateTimePicker
            // 
            this.inicioContratoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.arrendamentoBindingSource, "InicioContrato", true));
            this.inicioContratoDateTimePicker.Location = new System.Drawing.Point(529, 183);
            this.inicioContratoDateTimePicker.Name = "inicioContratoDateTimePicker";
            this.inicioContratoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.inicioContratoDateTimePicker.TabIndex = 8;
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
            // arrendatarioLabel
            // 
            arrendatarioLabel.AutoSize = true;
            arrendatarioLabel.Location = new System.Drawing.Point(526, 310);
            arrendatarioLabel.Name = "arrendatarioLabel";
            arrendatarioLabel.Size = new System.Drawing.Size(67, 13);
            arrendatarioLabel.TabIndex = 11;
            arrendatarioLabel.Text = "Arrendatario:";
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
            // casaArrendavelLabel
            // 
            casaArrendavelLabel.AutoSize = true;
            casaArrendavelLabel.Location = new System.Drawing.Point(31, 129);
            casaArrendavelLabel.Name = "casaArrendavelLabel";
            casaArrendavelLabel.Size = new System.Drawing.Size(88, 13);
            casaArrendavelLabel.TabIndex = 12;
            casaArrendavelLabel.Text = "Casa Arrendavel:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "label4";
            // 
            // GerirArrendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(casaArrendavelLabel);
            this.Controls.Add(this.casaArrendavelListBox);
            this.Controls.Add(arrendatarioLabel);
            this.Controls.Add(this.arrendatarioComboBox);
            this.Controls.Add(this.renovavelCheckBox);
            this.Controls.Add(duracaoMesesLabel);
            this.Controls.Add(this.duracaoMesesNumericUpDown);
            this.Controls.Add(inicioContratoLabel);
            this.Controls.Add(this.inicioContratoDateTimePicker);
            this.Controls.Add(this.arrendamentoBindingNavigator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "GerirArrendamentos";
            this.Text = "GerirArrendamentos";
            ((System.ComponentModel.ISupportInitialize)(this.arrendamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrendamentoBindingNavigator)).EndInit();
            this.arrendamentoBindingNavigator.ResumeLayout(false);
            this.arrendamentoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duracaoMesesNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource arrendamentoBindingSource;
        private System.Windows.Forms.BindingNavigator arrendamentoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton arrendamentoBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker inicioContratoDateTimePicker;
        private System.Windows.Forms.NumericUpDown duracaoMesesNumericUpDown;
        private System.Windows.Forms.CheckBox renovavelCheckBox;
        private System.Windows.Forms.ComboBox arrendatarioComboBox;
        private System.Windows.Forms.ListBox casaArrendavelListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}