namespace Gestion_De_Proyectos
{
    partial class Insertar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombreInsertar = new System.Windows.Forms.TextBox();
            this.tbCategoriaInsertar = new System.Windows.Forms.TextBox();
            this.tbPrecioInsertar = new System.Windows.Forms.TextBox();
            this.bInsertar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categoria: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio: ";
            // 
            // tbNombreInsertar
            // 
            this.tbNombreInsertar.Location = new System.Drawing.Point(91, 26);
            this.tbNombreInsertar.Name = "tbNombreInsertar";
            this.tbNombreInsertar.Size = new System.Drawing.Size(100, 22);
            this.tbNombreInsertar.TabIndex = 0;
            // 
            // tbCategoriaInsertar
            // 
            this.tbCategoriaInsertar.Location = new System.Drawing.Point(91, 68);
            this.tbCategoriaInsertar.Name = "tbCategoriaInsertar";
            this.tbCategoriaInsertar.Size = new System.Drawing.Size(100, 22);
            this.tbCategoriaInsertar.TabIndex = 1;
            // 
            // tbPrecioInsertar
            // 
            this.tbPrecioInsertar.Location = new System.Drawing.Point(91, 112);
            this.tbPrecioInsertar.Name = "tbPrecioInsertar";
            this.tbPrecioInsertar.Size = new System.Drawing.Size(100, 22);
            this.tbPrecioInsertar.TabIndex = 2;
            // 
            // bInsertar
            // 
            this.bInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.18F);
            this.bInsertar.Location = new System.Drawing.Point(209, 29);
            this.bInsertar.Name = "bInsertar";
            this.bInsertar.Size = new System.Drawing.Size(221, 102);
            this.bInsertar.TabIndex = 3;
            this.bInsertar.Text = "INSERTAR";
            this.bInsertar.UseVisualStyleBackColor = true;
            this.bInsertar.Click += new System.EventHandler(this.bInsertar_Click);
            // 
            // Insertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 168);
            this.Controls.Add(this.bInsertar);
            this.Controls.Add(this.tbPrecioInsertar);
            this.Controls.Add(this.tbCategoriaInsertar);
            this.Controls.Add(this.tbNombreInsertar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Insertar";
            this.Text = "Insertar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombreInsertar;
        private System.Windows.Forms.TextBox tbCategoriaInsertar;
        private System.Windows.Forms.TextBox tbPrecioInsertar;
        private System.Windows.Forms.Button bInsertar;
    }
}