namespace AprendiendoAConectarSQLserver
{
    partial class Facturacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnColocar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.lb2 = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbtotal = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lbImporte = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colimporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCantidad = new miLibreria.ErrorTXTBox();
            this.txtPrecio = new miLibreria.ErrorTXTBox();
            this.txtCodColum = new miLibreria.ErrorTXTBox();
            this.txtDescripcion = new miLibreria.ErrorTXTBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbCodigoCol = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbLeAtiende = new System.Windows.Forms.Label();
            this.txtID = new miLibreria.ErrorTXTBox();
            this.txtCliente = new miLibreria.ErrorTXTBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1050, 668);
            this.btnSalir.Size = new System.Drawing.Size(231, 23);
            // 
            // btnColocar
            // 
            this.btnColocar.Location = new System.Drawing.Point(1050, 201);
            this.btnColocar.Name = "btnColocar";
            this.btnColocar.Size = new System.Drawing.Size(231, 32);
            this.btnColocar.TabIndex = 2;
            this.btnColocar.Text = "Colocar";
            this.btnColocar.UseVisualStyleBackColor = true;
            this.btnColocar.Click += new System.EventHandler(this.btnColocar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1050, 278);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(231, 30);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(1050, 356);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(231, 31);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(1050, 436);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(231, 32);
            this.btnProductos.TabIndex = 5;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(1050, 505);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(231, 30);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(1050, 562);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(231, 46);
            this.btnFacturar.TabIndex = 7;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(71, 97);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(167, 29);
            this.lb2.TabIndex = 8;
            this.lb2.Text = "ID del cliente";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.ForeColor = System.Drawing.SystemColors.Control;
            this.lbDescripcion.Location = new System.Drawing.Point(174, 251);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(238, 38);
            this.lbDescripcion.TabIndex = 9;
            this.lbDescripcion.Text = "Descripcion";
            this.lbDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPrecio
            // 
            this.lbPrecio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecio.ForeColor = System.Drawing.SystemColors.Control;
            this.lbPrecio.Location = new System.Drawing.Point(410, 251);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(169, 38);
            this.lbPrecio.TabIndex = 10;
            this.lbPrecio.Text = "Precio";
            this.lbPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(820, 665);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 37);
            this.label4.TabIndex = 11;
            // 
            // lbtotal
            // 
            this.lbtotal.AutoSize = true;
            this.lbtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotal.Location = new System.Drawing.Point(718, 668);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(86, 34);
            this.lbtotal.TabIndex = 12;
            this.lbtotal.Text = "Total";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(71, 42);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(138, 29);
            this.lb1.TabIndex = 13;
            this.lb1.Text = "Le Atiende";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.Location = new System.Drawing.Point(91, 141);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(96, 29);
            this.lb3.TabIndex = 14;
            this.lb3.Text = "Cliente";
            // 
            // lbImporte
            // 
            this.lbImporte.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImporte.ForeColor = System.Drawing.SystemColors.Control;
            this.lbImporte.Location = new System.Drawing.Point(734, 251);
            this.lbImporte.Name = "lbImporte";
            this.lbImporte.Size = new System.Drawing.Size(269, 38);
            this.lbImporte.TabIndex = 15;
            this.lbImporte.Text = "Importe";
            this.lbImporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColDescripcion,
            this.ColPrecio,
            this.ColCantidad,
            this.Colimporte});
            this.dataGridView1.Location = new System.Drawing.Point(12, 292);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(991, 361);
            this.dataGridView1.TabIndex = 16;
            // 
            // ColCodigo
            // 
            this.ColCodigo.HeaderText = "Codigo";
            this.ColCodigo.MinimumWidth = 6;
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.ReadOnly = true;
            this.ColCodigo.Width = 120;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.HeaderText = "Descripcion";
            this.ColDescripcion.MinimumWidth = 6;
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.ReadOnly = true;
            this.ColDescripcion.Width = 190;
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.MinimumWidth = 6;
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            this.ColPrecio.Width = 120;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.MinimumWidth = 6;
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.ReadOnly = true;
            this.ColCantidad.Width = 120;
            // 
            // Colimporte
            // 
            this.Colimporte.HeaderText = "Importe";
            this.Colimporte.MinimumWidth = 6;
            this.Colimporte.Name = "Colimporte";
            this.Colimporte.ReadOnly = true;
            this.Colimporte.Width = 190;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(556, 211);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(148, 22);
            this.txtCantidad.SoloNumeros = false;
            this.txtCantidad.TabIndex = 20;
            this.txtCantidad.Validar = true;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(402, 211);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(145, 22);
            this.txtPrecio.SoloNumeros = false;
            this.txtPrecio.TabIndex = 22;
            this.txtPrecio.Validar = true;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // txtCodColum
            // 
            this.txtCodColum.Location = new System.Drawing.Point(12, 212);
            this.txtCodColum.Name = "txtCodColum";
            this.txtCodColum.Size = new System.Drawing.Size(127, 22);
            this.txtCodColum.SoloNumeros = false;
            this.txtCodColum.TabIndex = 23;
            this.txtCodColum.Validar = true;
            this.txtCodColum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(174, 212);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(212, 22);
            this.txtDescripcion.SoloNumeros = false;
            this.txtDescripcion.TabIndex = 24;
            this.txtDescripcion.Validar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(750, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(463, 121);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // lbCodigoCol
            // 
            this.lbCodigoCol.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCodigoCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoCol.ForeColor = System.Drawing.SystemColors.Control;
            this.lbCodigoCol.Location = new System.Drawing.Point(12, 251);
            this.lbCodigoCol.Name = "lbCodigoCol";
            this.lbCodigoCol.Size = new System.Drawing.Size(175, 38);
            this.lbCodigoCol.TabIndex = 26;
            this.lbCodigoCol.Text = "Codigo";
            this.lbCodigoCol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCantidad
            // 
            this.lbCantidad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.ForeColor = System.Drawing.SystemColors.Control;
            this.lbCantidad.Location = new System.Drawing.Point(571, 251);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(165, 38);
            this.lbCantidad.TabIndex = 27;
            this.lbCantidad.Text = "Cantidad";
            this.lbCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(448, 89);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(147, 37);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lbLeAtiende
            // 
            this.lbLeAtiende.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLeAtiende.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLeAtiende.Location = new System.Drawing.Point(245, 42);
            this.lbLeAtiende.Name = "lbLeAtiende";
            this.lbLeAtiende.Size = new System.Drawing.Size(150, 29);
            this.lbLeAtiende.TabIndex = 29;
            this.lbLeAtiende.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(245, 95);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(185, 31);
            this.txtID.SoloNumeros = false;
            this.txtID.TabIndex = 30;
            this.txtID.Validar = true;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(245, 141);
            this.txtCliente.Multiline = true;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(185, 29);
            this.txtCliente.SoloNumeros = false;
            this.txtCliente.TabIndex = 31;
            this.txtCliente.Validar = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 712);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbLeAtiende);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.lbCodigoCol);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodColum);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lbImporte);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.lbtotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnColocar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnColocar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnClientes, 0);
            this.Controls.SetChildIndex(this.btnProductos, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnFacturar, 0);
            this.Controls.SetChildIndex(this.lb2, 0);
            this.Controls.SetChildIndex(this.lbDescripcion, 0);
            this.Controls.SetChildIndex(this.lbPrecio, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.lbtotal, 0);
            this.Controls.SetChildIndex(this.lb1, 0);
            this.Controls.SetChildIndex(this.lb3, 0);
            this.Controls.SetChildIndex(this.lbImporte, 0);
            this.Controls.SetChildIndex(this.txtCantidad, 0);
            this.Controls.SetChildIndex(this.txtPrecio, 0);
            this.Controls.SetChildIndex(this.txtCodColum, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.lbCodigoCol, 0);
            this.Controls.SetChildIndex(this.lbCantidad, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.lbLeAtiende, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.txtCliente, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnColocar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbtotal;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lbImporte;
        private System.Windows.Forms.DataGridView dataGridView1;
        private miLibreria.ErrorTXTBox txtCantidad;
        private miLibreria.ErrorTXTBox txtPrecio;
        private miLibreria.ErrorTXTBox txtCodColum;
        private miLibreria.ErrorTXTBox txtDescripcion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbCodigoCol;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lbLeAtiende;
        private miLibreria.ErrorTXTBox txtID;
        private miLibreria.ErrorTXTBox txtCliente;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colimporte;
    }
}