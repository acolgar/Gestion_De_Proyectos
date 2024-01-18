namespace Gestion_De_Proyectos
{
    partial class Actualizar
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
            this.labelActualizar = new System.Windows.Forms.Label();
            this.cbActualizar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbProductoActualizar = new System.Windows.Forms.TextBox();
            this.tbCategoriaActualizar = new System.Windows.Forms.TextBox();
            this.tbPrecioActualizar = new System.Windows.Forms.TextBox();
            this.bActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelActualizar
            // 
            this.labelActualizar.AutoSize = true;
            this.labelActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.labelActualizar.Location = new System.Drawing.Point(44, 9);
            this.labelActualizar.Name = "labelActualizar";
            this.labelActualizar.Size = new System.Drawing.Size(561, 31);
            this.labelActualizar.TabIndex = 2;
            this.labelActualizar.Text = "LISTADO DE PRODUCTOS A ACTUALIZAR";
            // 
            // cbActualizar
            // 
            this.cbActualizar.FormattingEnabled = true;
            this.cbActualizar.Location = new System.Drawing.Point(94, 62);
            this.cbActualizar.Name = "cbActualizar";
            this.cbActualizar.Size = new System.Drawing.Size(452, 24);
            this.cbActualizar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precio";
            // 
            // tbProductoActualizar
            // 
            this.tbProductoActualizar.Location = new System.Drawing.Point(50, 262);
            this.tbProductoActualizar.Name = "tbProductoActualizar";
            this.tbProductoActualizar.ReadOnly = true;
            this.tbProductoActualizar.Size = new System.Drawing.Size(143, 22);
            this.tbProductoActualizar.TabIndex = 7;
            // 
            // tbCategoriaActualizar
            // 
            this.tbCategoriaActualizar.Location = new System.Drawing.Point(251, 262);
            this.tbCategoriaActualizar.Name = "tbCategoriaActualizar";
            this.tbCategoriaActualizar.ReadOnly = true;
            this.tbCategoriaActualizar.Size = new System.Drawing.Size(137, 22);
            this.tbCategoriaActualizar.TabIndex = 8;
            // 
            // tbPrecioActualizar
            // 
            this.tbPrecioActualizar.Location = new System.Drawing.Point(473, 262);
            this.tbPrecioActualizar.Name = "tbPrecioActualizar";
            this.tbPrecioActualizar.Size = new System.Drawing.Size(100, 22);
            this.tbPrecioActualizar.TabIndex = 9;
            // 
            // bActualizar
            // 
            this.bActualizar.Location = new System.Drawing.Point(234, 330);
            this.bActualizar.Name = "bActualizar";
            this.bActualizar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bActualizar.Size = new System.Drawing.Size(171, 23);
            this.bActualizar.TabIndex = 10;
            this.bActualizar.Text = "ACTUALIZAR";
            this.bActualizar.UseVisualStyleBackColor = true;
            this.bActualizar.Click += new System.EventHandler(this.bActualizarPrecio);
            // 
            // Actualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.bActualizar);
            this.Controls.Add(this.tbPrecioActualizar);
            this.Controls.Add(this.tbCategoriaActualizar);
            this.Controls.Add(this.tbProductoActualizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbActualizar);
            this.Controls.Add(this.labelActualizar);
            this.Name = "Actualizar";
            this.Text = "Actualizar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelActualizar;
        public System.Windows.Forms.ComboBox cbActualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbProductoActualizar;
        private System.Windows.Forms.TextBox tbCategoriaActualizar;
        private System.Windows.Forms.TextBox tbPrecioActualizar;
        private System.Windows.Forms.Button bActualizar;
    }
}