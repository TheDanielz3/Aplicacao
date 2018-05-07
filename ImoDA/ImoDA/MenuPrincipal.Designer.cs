namespace GCC
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.buttonGerirClientes = new System.Windows.Forms.Button();
            this.buttonGerirCasas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGerirClientes
            // 
            this.buttonGerirClientes.Image = ((System.Drawing.Image)(resources.GetObject("buttonGerirClientes.Image")));
            this.buttonGerirClientes.Location = new System.Drawing.Point(44, 273);
            this.buttonGerirClientes.Name = "buttonGerirClientes";
            this.buttonGerirClientes.Size = new System.Drawing.Size(186, 173);
            this.buttonGerirClientes.TabIndex = 0;
            this.buttonGerirClientes.Text = "Gerir Clientes";
            this.buttonGerirClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGerirClientes.UseVisualStyleBackColor = true;
            this.buttonGerirClientes.Click += new System.EventHandler(this.buttonGerirClientes_Click_1);
            // 
            // buttonGerirCasas
            // 
            this.buttonGerirCasas.Image = ((System.Drawing.Image)(resources.GetObject("buttonGerirCasas.Image")));
            this.buttonGerirCasas.Location = new System.Drawing.Point(315, 273);
            this.buttonGerirCasas.Name = "buttonGerirCasas";
            this.buttonGerirCasas.Size = new System.Drawing.Size(186, 173);
            this.buttonGerirCasas.TabIndex = 1;
            this.buttonGerirCasas.Text = "Gerir Casas";
            this.buttonGerirCasas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGerirCasas.UseVisualStyleBackColor = true;
            this.buttonGerirCasas.Click += new System.EventHandler(this.buttonGerirCasas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(102, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 188);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(230, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "GCC";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 475);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonGerirCasas);
            this.Controls.Add(this.buttonGerirClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuPrincipal";
            this.Text = "Imo DA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGerirClientes;
        private System.Windows.Forms.Button buttonGerirCasas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

