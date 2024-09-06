namespace Mercado
{
    partial class Mercado
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvArticulosLista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulosLista
            // 
            this.dgvArticulosLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulosLista.Location = new System.Drawing.Point(0, 0);
            this.dgvArticulosLista.Name = "dgvArticulosLista";
            this.dgvArticulosLista.Size = new System.Drawing.Size(775, 261);
            this.dgvArticulosLista.TabIndex = 0;
          
            // 
            // Mercado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvArticulosLista);
            this.Name = "MercadoGen";
            this.Text = "Articulo";
            this.Load += new System.EventHandler(this.Mercado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulosLista;
    }
}

