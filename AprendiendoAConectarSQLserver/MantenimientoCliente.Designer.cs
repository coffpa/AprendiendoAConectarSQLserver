namespace AprendiendoAConectarSQLserver
{
    partial class MantenimientoCliente
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
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbIdCliente = new System.Windows.Forms.Label();
            this.txtApellidoCli = new System.Windows.Forms.TextBox();
            this.txtNombrecli = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.Location = new System.Drawing.Point(81, 253);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(76, 20);
            this.lbApellido.TabIndex = 19;
            this.lbApellido.Text = "Apellido";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(80, 194);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(74, 20);
            this.lbNombre.TabIndex = 18;
            this.lbNombre.Text = "Nombre";
            // 
            // lbIdCliente
            // 
            this.lbIdCliente.AutoSize = true;
            this.lbIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdCliente.Location = new System.Drawing.Point(79, 128);
            this.lbIdCliente.Name = "lbIdCliente";
            this.lbIdCliente.Size = new System.Drawing.Size(112, 20);
            this.lbIdCliente.TabIndex = 17;
            this.lbIdCliente.Text = "Id de cliente";
            // 
            // txtApellidoCli
            // 
            this.txtApellidoCli.Location = new System.Drawing.Point(228, 248);
            this.txtApellidoCli.Name = "txtApellidoCli";
            this.txtApellidoCli.Size = new System.Drawing.Size(172, 22);
            this.txtApellidoCli.TabIndex = 16;
            // 
            // txtNombrecli
            // 
            this.txtNombrecli.Location = new System.Drawing.Point(228, 191);
            this.txtNombrecli.Name = "txtNombrecli";
            this.txtNombrecli.Size = new System.Drawing.Size(172, 22);
            this.txtNombrecli.TabIndex = 15;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(228, 126);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(172, 22);
            this.txtIdCliente.TabIndex = 14;
            // 
            // MantenimientoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbIdCliente);
            this.Controls.Add(this.txtApellidoCli);
            this.Controls.Add(this.txtNombrecli);
            this.Controls.Add(this.txtIdCliente);
            this.Name = "MantenimientoCliente";
            this.Text = "MantenimientoCliente";
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.txtIdCliente, 0);
            this.Controls.SetChildIndex(this.txtNombrecli, 0);
            this.Controls.SetChildIndex(this.txtApellidoCli, 0);
            this.Controls.SetChildIndex(this.lbIdCliente, 0);
            this.Controls.SetChildIndex(this.lbNombre, 0);
            this.Controls.SetChildIndex(this.lbApellido, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbIdCliente;
        private System.Windows.Forms.TextBox txtApellidoCli;
        private System.Windows.Forms.TextBox txtNombrecli;
        private System.Windows.Forms.TextBox txtIdCliente;
    }
}