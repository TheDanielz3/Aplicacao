namespace GCC
{
    partial class Menu
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
            this.buttonGerirClientes = new System.Windows.Forms.Button();
            this.buttonGerirCasas = new System.Windows.Forms.Button();
            this.labelGCC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGerirClientes
            // 
            this.buttonGerirClientes.Location = new System.Drawing.Point(12, 288);
            this.buttonGerirClientes.Name = "buttonGerirClientes";
            this.buttonGerirClientes.Size = new System.Drawing.Size(169, 150);
            this.buttonGerirClientes.TabIndex = 0;
            this.buttonGerirClientes.Text = "Gerir Clientes";
            this.buttonGerirClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGerirClientes.UseVisualStyleBackColor = true;
            // 
            // buttonGerirCasas
            // 
            this.buttonGerirCasas.Location = new System.Drawing.Point(275, 288);
            this.buttonGerirCasas.Name = "buttonGerirCasas";
            this.buttonGerirCasas.Size = new System.Drawing.Size(169, 150);
            this.buttonGerirCasas.TabIndex = 1;
            this.buttonGerirCasas.Text = "Gerir Casas";
            this.buttonGerirCasas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGerirCasas.UseVisualStyleBackColor = true;
            // 
            // labelGCC
            // 
            this.labelGCC.AutoSize = true;
            this.labelGCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGCC.Location = new System.Drawing.Point(165, 100);
            this.labelGCC.Name = "labelGCC";
            this.labelGCC.Size = new System.Drawing.Size(131, 55);
            this.labelGCC.TabIndex = 2;
            this.labelGCC.Text = "GCC";
            this.labelGCC.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.Controls.Add(this.labelGCC);
            this.Controls.Add(this.buttonGerirCasas);
            this.Controls.Add(this.buttonGerirClientes);
            this.Name = "Menu";
            this.Text = "GCC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGerirClientes;
        private System.Windows.Forms.Button buttonGerirCasas;
        private System.Windows.Forms.Label labelGCC;
    }
}

