namespace AprendiendoAConectarSQLserver
{
    partial class VentanaAdmin
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
            this.lbAdmin = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.lbNomAd = new System.Windows.Forms.Label();
            this.lbUsAdmin = new System.Windows.Forms.Label();
            this.lbIDAdmin = new System.Windows.Forms.Label();
            this.btnGeneradorPrincipal = new System.Windows.Forms.Button();
            this.btnAdministrarUsuarios = new System.Windows.Forms.Button();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.btnCerrarSesión = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(578, 343);
            this.btnSalir.Size = new System.Drawing.Size(162, 27);
            // 
            // lbAdmin
            // 
            this.lbAdmin.AutoSize = true;
            this.lbAdmin.Location = new System.Drawing.Point(70, 53);
            this.lbAdmin.Name = "lbAdmin";
            this.lbAdmin.Size = new System.Drawing.Size(51, 17);
            this.lbAdmin.TabIndex = 0;
            this.lbAdmin.Text = "Admin:";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(70, 141);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(61, 17);
            this.lbUsuario.TabIndex = 1;
            this.lbUsuario.Text = "Usuario:";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(70, 220);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(23, 17);
            this.lbId.TabIndex = 2;
            this.lbId.Text = "Id:";
            // 
            // lbNomAd
            // 
            this.lbNomAd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNomAd.Location = new System.Drawing.Point(185, 53);
            this.lbNomAd.Name = "lbNomAd";
            this.lbNomAd.Size = new System.Drawing.Size(156, 23);
            this.lbNomAd.TabIndex = 3;
            this.lbNomAd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUsAdmin
            // 
            this.lbUsAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbUsAdmin.Location = new System.Drawing.Point(185, 141);
            this.lbUsAdmin.Name = "lbUsAdmin";
            this.lbUsAdmin.Size = new System.Drawing.Size(156, 23);
            this.lbUsAdmin.TabIndex = 4;
            this.lbUsAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbIDAdmin
            // 
            this.lbIDAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbIDAdmin.Location = new System.Drawing.Point(185, 220);
            this.lbIDAdmin.Name = "lbIDAdmin";
            this.lbIDAdmin.Size = new System.Drawing.Size(156, 23);
            this.lbIDAdmin.TabIndex = 5;
            this.lbIDAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGeneradorPrincipal
            // 
            this.btnGeneradorPrincipal.Location = new System.Drawing.Point(578, 53);
            this.btnGeneradorPrincipal.Name = "btnGeneradorPrincipal";
            this.btnGeneradorPrincipal.Size = new System.Drawing.Size(162, 30);
            this.btnGeneradorPrincipal.TabIndex = 6;
            this.btnGeneradorPrincipal.Text = "Contenedor Principal";
            this.btnGeneradorPrincipal.UseVisualStyleBackColor = true;
            this.btnGeneradorPrincipal.Click += new System.EventHandler(this.btnGeneradorPrincipal_Click);
            // 
            // btnAdministrarUsuarios
            // 
            this.btnAdministrarUsuarios.Location = new System.Drawing.Point(578, 129);
            this.btnAdministrarUsuarios.Name = "btnAdministrarUsuarios";
            this.btnAdministrarUsuarios.Size = new System.Drawing.Size(162, 30);
            this.btnAdministrarUsuarios.TabIndex = 7;
            this.btnAdministrarUsuarios.Text = "Administrar Usuarios";
            this.btnAdministrarUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.Location = new System.Drawing.Point(578, 200);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(162, 30);
            this.btnCambiarContraseña.TabIndex = 8;
            this.btnCambiarContraseña.Text = "Cambiar Contraseña";
            this.btnCambiarContraseña.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesión
            // 
            this.btnCerrarSesión.Location = new System.Drawing.Point(578, 271);
            this.btnCerrarSesión.Name = "btnCerrarSesión";
            this.btnCerrarSesión.Size = new System.Drawing.Size(162, 30);
            this.btnCerrarSesión.TabIndex = 9;
            this.btnCerrarSesión.Text = "Cerrar Sesión";
            this.btnCerrarSesión.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // VentanaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCerrarSesión);
            this.Controls.Add(this.btnCambiarContraseña);
            this.Controls.Add(this.btnAdministrarUsuarios);
            this.Controls.Add(this.btnGeneradorPrincipal);
            this.Controls.Add(this.lbIDAdmin);
            this.Controls.Add(this.lbUsAdmin);
            this.Controls.Add(this.lbNomAd);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbAdmin);
            this.Name = "VentanaAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VentanaAdmin_FormClosed);
            this.Load += new System.EventHandler(this.VentanaAdmin_Load);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.lbAdmin, 0);
            this.Controls.SetChildIndex(this.lbUsuario, 0);
            this.Controls.SetChildIndex(this.lbId, 0);
            this.Controls.SetChildIndex(this.lbNomAd, 0);
            this.Controls.SetChildIndex(this.lbUsAdmin, 0);
            this.Controls.SetChildIndex(this.lbIDAdmin, 0);
            this.Controls.SetChildIndex(this.btnGeneradorPrincipal, 0);
            this.Controls.SetChildIndex(this.btnAdministrarUsuarios, 0);
            this.Controls.SetChildIndex(this.btnCambiarContraseña, 0);
            this.Controls.SetChildIndex(this.btnCerrarSesión, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAdmin;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbNomAd;
        private System.Windows.Forms.Label lbUsAdmin;
        private System.Windows.Forms.Label lbIDAdmin;
        private System.Windows.Forms.Button btnGeneradorPrincipal;
        private System.Windows.Forms.Button btnAdministrarUsuarios;
        private System.Windows.Forms.Button btnCambiarContraseña;
        private System.Windows.Forms.Button btnCerrarSesión;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}