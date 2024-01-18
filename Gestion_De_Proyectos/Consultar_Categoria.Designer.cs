namespace Gestion_De_Proyectos
{
    partial class Consultar_Categoria
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
            this.lbConsultarProd = new System.Windows.Forms.ListBox();
            this.lConsultar = new System.Windows.Forms.Label();
            this.bConsultar = new System.Windows.Forms.Button();
            this.labelIndicar = new System.Windows.Forms.Label();
            this.tbIndicarCategoria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbConsultarProd
            // 
            this.lbConsultarProd.FormattingEnabled = true;
            this.lbConsultarProd.ItemHeight = 16;
            this.lbConsultarProd.Location = new System.Drawing.Point(38, 118);
            this.lbConsultarProd.Name = "lbConsultarProd";
            this.lbConsultarProd.Size = new System.Drawing.Size(477, 244);
            this.lbConsultarProd.TabIndex = 0;
            // 
            // lConsultar
            // 
            this.lConsultar.AutoSize = true;
            this.lConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.lConsultar.Location = new System.Drawing.Point(33, 26);
            this.lConsultar.Name = "lConsultar";
            this.lConsultar.Size = new System.Drawing.Size(482, 26);
            this.lConsultar.TabIndex = 1;
            this.lConsultar.Text = "CONSULTAR PRODUCTOS POR CATEGORIA";
            // 
            // bConsultar
            // 
            this.bConsultar.Location = new System.Drawing.Point(139, 398);
            this.bConsultar.Name = "bConsultar";
            this.bConsultar.Size = new System.Drawing.Size(267, 40);
            this.bConsultar.TabIndex = 1;
            this.bConsultar.Text = "CONSULTAR";
            this.bConsultar.UseVisualStyleBackColor = true;
            this.bConsultar.Click += new System.EventHandler(this.bConsultar_Click);
            // 
            // labelIndicar
            // 
            this.labelIndicar.AutoSize = true;
            this.labelIndicar.Location = new System.Drawing.Point(35, 86);
            this.labelIndicar.Name = "labelIndicar";
            this.labelIndicar.Size = new System.Drawing.Size(123, 16);
            this.labelIndicar.TabIndex = 3;
            this.labelIndicar.Text = "Indica la categoria: ";
            // 
            // tbIndicarCategoria
            // 
            this.tbIndicarCategoria.Location = new System.Drawing.Point(177, 83);
            this.tbIndicarCategoria.Name = "tbIndicarCategoria";
            this.tbIndicarCategoria.Size = new System.Drawing.Size(335, 22);
            this.tbIndicarCategoria.TabIndex = 0;
            // 
            // Consultar_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.tbIndicarCategoria);
            this.Controls.Add(this.labelIndicar);
            this.Controls.Add(this.bConsultar);
            this.Controls.Add(this.lConsultar);
            this.Controls.Add(this.lbConsultarProd);
            this.Name = "Consultar_Categoria";
            this.Text = "Consultar_Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbConsultarProd;
        private System.Windows.Forms.Label lConsultar;
        private System.Windows.Forms.Button bConsultar;
        private System.Windows.Forms.Label labelIndicar;
        private System.Windows.Forms.TextBox tbIndicarCategoria;
    }
}