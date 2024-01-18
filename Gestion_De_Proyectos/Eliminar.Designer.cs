namespace Gestion_De_Proyectos
{
    partial class Eliminar
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
            this.cbEliminar = new System.Windows.Forms.ComboBox();
            this.labelEliminar = new System.Windows.Forms.Label();
            this.bEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbEliminar
            // 
            this.cbEliminar.FormattingEnabled = true;
            this.cbEliminar.Location = new System.Drawing.Point(79, 71);
            this.cbEliminar.Name = "cbEliminar";
            this.cbEliminar.Size = new System.Drawing.Size(276, 24);
            this.cbEliminar.TabIndex = 0;
            // 
            // labelEliminar
            // 
            this.labelEliminar.AutoSize = true;
            this.labelEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.labelEliminar.Location = new System.Drawing.Point(40, 27);
            this.labelEliminar.Name = "labelEliminar";
            this.labelEliminar.Size = new System.Drawing.Size(358, 31);
            this.labelEliminar.TabIndex = 1;
            this.labelEliminar.Text = "LISTADO DE PRODUCTOS";
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(79, 458);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(276, 52);
            this.bEliminar.TabIndex = 2;
            this.bEliminar.Text = "ELIMINAR";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 522);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.labelEliminar);
            this.Controls.Add(this.cbEliminar);
            this.Name = "Eliminar";
            this.Text = "Eliminar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelEliminar;
        private System.Windows.Forms.Button bEliminar;
        public System.Windows.Forms.ComboBox cbEliminar;
    }
}