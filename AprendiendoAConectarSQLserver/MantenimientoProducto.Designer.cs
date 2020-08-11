namespace AprendiendoAConectarSQLserver
{
    partial class MantenimientoProducto
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
            this.lbIdProducto = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.txtIdProducto = new miLibreria.ErrorTXTBox();
            this.txtDescripcionProd = new miLibreria.ErrorTXTBox();
            this.txtPrecio = new miLibreria.ErrorTXTBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIdProducto
            // 
            this.lbIdProducto.AutoSize = true;
            this.lbIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdProducto.Location = new System.Drawing.Point(43, 111);
            this.lbIdProducto.Name = "lbIdProducto";
            this.lbIdProducto.Size = new System.Drawing.Size(129, 20);
            this.lbIdProducto.TabIndex = 11;
            this.lbIdProducto.Text = "Id de producto";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.Location = new System.Drawing.Point(44, 177);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(110, 20);
            this.lbDescripcion.TabIndex = 12;
            this.lbDescripcion.Text = "Descripcion";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecio.Location = new System.Drawing.Point(45, 236);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(63, 20);
            this.lbPrecio.TabIndex = 13;
            this.lbPrecio.Text = "Precio";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(192, 109);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(172, 22);
            this.txtIdProducto.SoloNumeros = true;
            this.txtIdProducto.TabIndex = 14;
            this.txtIdProducto.Validar = true;
            this.txtIdProducto.TextChanged += new System.EventHandler(this.txtIdProducto_TextChanged);
            // 
            // txtDescripcionProd
            // 
            this.txtDescripcionProd.Location = new System.Drawing.Point(192, 175);
            this.txtDescripcionProd.Name = "txtDescripcionProd";
            this.txtDescripcionProd.Size = new System.Drawing.Size(172, 22);
            this.txtDescripcionProd.SoloNumeros = false;
            this.txtDescripcionProd.TabIndex = 15;
            this.txtDescripcionProd.Validar = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(183, 236);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(181, 22);
            this.txtPrecio.SoloNumeros = true;
            this.txtPrecio.TabIndex = 16;
            this.txtPrecio.Validar = true;
            // 
            // MantenimientoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcionProd);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbIdProducto);
            this.Name = "MantenimientoProducto";
            this.Text = "MantenimientoProducto";
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.lbIdProducto, 0);
            this.Controls.SetChildIndex(this.lbDescripcion, 0);
            this.Controls.SetChildIndex(this.lbPrecio, 0);
            this.Controls.SetChildIndex(this.txtIdProducto, 0);
            this.Controls.SetChildIndex(this.txtDescripcionProd, 0);
            this.Controls.SetChildIndex(this.txtPrecio, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbIdProducto;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbPrecio;
        private miLibreria.ErrorTXTBox txtIdProducto;
        private miLibreria.ErrorTXTBox txtDescripcionProd;
        private miLibreria.ErrorTXTBox txtPrecio;
    }
}