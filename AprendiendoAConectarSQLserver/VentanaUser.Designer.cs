namespace AprendiendoAConectarSQLserver
{
    partial class VentanaUser
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
            this.btnCerrarSesión = new System.Windows.Forms.Button();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.btnGeneradorPrincipal = new System.Windows.Forms.Button();
            this.lbCon = new System.Windows.Forms.Label();
            this.lbUs = new System.Windows.Forms.Label();
            this.lbNomUs = new System.Windows.Forms.Label();
            this.lbContraseña = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(578, 340);
            this.btnSalir.Size = new System.Drawing.Size(162, 30);
            // 
            // btnCerrarSesión
            // 
            this.btnCerrarSesión.Location = new System.Drawing.Point(578, 273);
            this.btnCerrarSesión.Name = "btnCerrarSesión";
            this.btnCerrarSesión.Size = new System.Drawing.Size(162, 30);
            this.btnCerrarSesión.TabIndex = 21;
            this.btnCerrarSesión.Text = "Cerrar Sesión";
            this.btnCerrarSesión.UseVisualStyleBackColor = true;
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.Location = new System.Drawing.Point(578, 202);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(162, 30);
            this.btnCambiarContraseña.TabIndex = 20;
            this.btnCambiarContraseña.Text = "Cambiar Contraseña";
            this.btnCambiarContraseña.UseVisualStyleBackColor = true;
            // 
            // btnGeneradorPrincipal
            // 
            this.btnGeneradorPrincipal.Location = new System.Drawing.Point(578, 140);
            this.btnGeneradorPrincipal.Name = "btnGeneradorPrincipal";
            this.btnGeneradorPrincipal.Size = new System.Drawing.Size(162, 30);
            this.btnGeneradorPrincipal.TabIndex = 18;
            this.btnGeneradorPrincipal.Text = "Generador Principal";
            this.btnGeneradorPrincipal.UseVisualStyleBackColor = true;
            this.btnGeneradorPrincipal.Click += new System.EventHandler(this.btnGeneradorPrincipal_Click);
            // 
            // lbCon
            // 
            this.lbCon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCon.Location = new System.Drawing.Point(175, 248);
            this.lbCon.Name = "lbCon";
            this.lbCon.Size = new System.Drawing.Size(143, 23);
            this.lbCon.TabIndex = 17;
            this.lbCon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUs
            // 
            this.lbUs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbUs.Location = new System.Drawing.Point(175, 169);
            this.lbUs.Name = "lbUs";
            this.lbUs.Size = new System.Drawing.Size(143, 23);
            this.lbUs.TabIndex = 16;
            this.lbUs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNomUs
            // 
            this.lbNomUs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNomUs.Location = new System.Drawing.Point(175, 81);
            this.lbNomUs.Name = "lbNomUs";
            this.lbNomUs.Size = new System.Drawing.Size(143, 23);
            this.lbNomUs.TabIndex = 15;
            this.lbNomUs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbContraseña
            // 
            this.lbContraseña.AutoSize = true;
            this.lbContraseña.Location = new System.Drawing.Point(60, 248);
            this.lbContraseña.Name = "lbContraseña";
            this.lbContraseña.Size = new System.Drawing.Size(85, 17);
            this.lbContraseña.TabIndex = 14;
            this.lbContraseña.Text = "Contraseña:";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(60, 169);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(61, 17);
            this.lbUsuario.TabIndex = 13;
            this.lbUsuario.Text = "Usuario:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(60, 81);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(58, 17);
            this.lbNombre.TabIndex = 12;
            this.lbNombre.Text = "Nombre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(383, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // VentanaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 515);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCerrarSesión);
            this.Controls.Add(this.btnCambiarContraseña);
            this.Controls.Add(this.btnGeneradorPrincipal);
            this.Controls.Add(this.lbCon);
            this.Controls.Add(this.lbUs);
            this.Controls.Add(this.lbNomUs);
            this.Controls.Add(this.lbContraseña);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbNombre);
            this.Name = "VentanaUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaUser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VentanaUser_FormClosed);
            this.Load += new System.EventHandler(this.VentanaUser_Load);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.lbNombre, 0);
            this.Controls.SetChildIndex(this.lbUsuario, 0);
            this.Controls.SetChildIndex(this.lbContraseña, 0);
            this.Controls.SetChildIndex(this.lbNomUs, 0);
            this.Controls.SetChildIndex(this.lbUs, 0);
            this.Controls.SetChildIndex(this.lbCon, 0);
            this.Controls.SetChildIndex(this.btnGeneradorPrincipal, 0);
            this.Controls.SetChildIndex(this.btnCambiarContraseña, 0);
            this.Controls.SetChildIndex(this.btnCerrarSesión, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCerrarSesión;
        private System.Windows.Forms.Button btnCambiarContraseña;
        private System.Windows.Forms.Button btnGeneradorPrincipal;
        private System.Windows.Forms.Label lbCon;
        private System.Windows.Forms.Label lbUs;
        private System.Windows.Forms.Label lbNomUs;
        private System.Windows.Forms.Label lbContraseña;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbNombre;
    }
}