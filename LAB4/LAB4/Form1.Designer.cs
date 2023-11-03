namespace LAB4
{
    partial class Form1
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
            this.btn = new System.Windows.Forms.Button();
            this.Mensajes = new System.Windows.Forms.ListBox();
            this.btnDPI = new System.Windows.Forms.Button();
            this.txtDPI = new System.Windows.Forms.TextBox();
            this.MensajesDPI = new System.Windows.Forms.ListBox();
            this.btnSelecMensajes = new System.Windows.Forms.Button();
            this.txtSelecMensaje = new System.Windows.Forms.TextBox();
            this.btnMostMensajes = new System.Windows.Forms.Button();
            this.txtMostMensajes = new System.Windows.Forms.TextBox();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.lblEncriptar = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnDesencriptar = new System.Windows.Forms.Button();
            this.lblDesencriptar = new System.Windows.Forms.Label();
            this.txtClaveEncriptada = new System.Windows.Forms.TextBox();
            this.lblMensajeEncr = new System.Windows.Forms.Label();
            this.txtClaveDesencriptada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(29, 25);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(93, 23);
            this.btn.TabIndex = 0;
            this.btn.Text = "Cargar Archivo";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Mensajes
            // 
            this.Mensajes.FormattingEnabled = true;
            this.Mensajes.Location = new System.Drawing.Point(29, 55);
            this.Mensajes.Name = "Mensajes";
            this.Mensajes.Size = new System.Drawing.Size(475, 160);
            this.Mensajes.TabIndex = 1;
            this.Mensajes.Visible = false;
            // 
            // btnDPI
            // 
            this.btnDPI.Location = new System.Drawing.Point(551, 54);
            this.btnDPI.Name = "btnDPI";
            this.btnDPI.Size = new System.Drawing.Size(75, 23);
            this.btnDPI.TabIndex = 2;
            this.btnDPI.Text = "Buscar DPI";
            this.btnDPI.UseVisualStyleBackColor = true;
            this.btnDPI.Visible = false;
            this.btnDPI.Click += new System.EventHandler(this.btnDPI_Click);
            // 
            // txtDPI
            // 
            this.txtDPI.Location = new System.Drawing.Point(551, 28);
            this.txtDPI.Name = "txtDPI";
            this.txtDPI.Size = new System.Drawing.Size(220, 20);
            this.txtDPI.TabIndex = 3;
            this.txtDPI.Visible = false;
            // 
            // MensajesDPI
            // 
            this.MensajesDPI.FormattingEnabled = true;
            this.MensajesDPI.Location = new System.Drawing.Point(551, 84);
            this.MensajesDPI.Name = "MensajesDPI";
            this.MensajesDPI.Size = new System.Drawing.Size(402, 121);
            this.MensajesDPI.TabIndex = 4;
            this.MensajesDPI.Visible = false;
            // 
            // btnSelecMensajes
            // 
            this.btnSelecMensajes.Location = new System.Drawing.Point(29, 231);
            this.btnSelecMensajes.Name = "btnSelecMensajes";
            this.btnSelecMensajes.Size = new System.Drawing.Size(124, 23);
            this.btnSelecMensajes.TabIndex = 5;
            this.btnSelecMensajes.Text = "Seleccionar Mensajes";
            this.btnSelecMensajes.UseVisualStyleBackColor = true;
            this.btnSelecMensajes.Visible = false;
            this.btnSelecMensajes.Click += new System.EventHandler(this.btnSelecMensajes_Click);
            // 
            // txtSelecMensaje
            // 
            this.txtSelecMensaje.Location = new System.Drawing.Point(29, 261);
            this.txtSelecMensaje.Multiline = true;
            this.txtSelecMensaje.Name = "txtSelecMensaje";
            this.txtSelecMensaje.Size = new System.Drawing.Size(625, 20);
            this.txtSelecMensaje.TabIndex = 6;
            this.txtSelecMensaje.Visible = false;
            // 
            // btnMostMensajes
            // 
            this.btnMostMensajes.Location = new System.Drawing.Point(29, 298);
            this.btnMostMensajes.Name = "btnMostMensajes";
            this.btnMostMensajes.Size = new System.Drawing.Size(108, 23);
            this.btnMostMensajes.TabIndex = 7;
            this.btnMostMensajes.Text = "Mostrar Mensajes";
            this.btnMostMensajes.UseVisualStyleBackColor = true;
            this.btnMostMensajes.Visible = false;
            this.btnMostMensajes.Click += new System.EventHandler(this.btnMostMensajes_Click);
            // 
            // txtMostMensajes
            // 
            this.txtMostMensajes.Location = new System.Drawing.Point(29, 328);
            this.txtMostMensajes.Multiline = true;
            this.txtMostMensajes.Name = "txtMostMensajes";
            this.txtMostMensajes.Size = new System.Drawing.Size(583, 159);
            this.txtMostMensajes.TabIndex = 8;
            this.txtMostMensajes.Visible = false;
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Location = new System.Drawing.Point(638, 354);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(75, 23);
            this.btnEncriptar.TabIndex = 9;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Visible = false;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // lblEncriptar
            // 
            this.lblEncriptar.AutoSize = true;
            this.lblEncriptar.Location = new System.Drawing.Point(635, 308);
            this.lblEncriptar.Name = "lblEncriptar";
            this.lblEncriptar.Size = new System.Drawing.Size(210, 13);
            this.lblEncriptar.TabIndex = 10;
            this.lblEncriptar.Text = "Encriptar mesnajes por medio de una clave";
            this.lblEncriptar.Visible = false;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(638, 328);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(207, 20);
            this.txtClave.TabIndex = 11;
            this.txtClave.Visible = false;
            // 
            // btnDesencriptar
            // 
            this.btnDesencriptar.Location = new System.Drawing.Point(638, 446);
            this.btnDesencriptar.Name = "btnDesencriptar";
            this.btnDesencriptar.Size = new System.Drawing.Size(75, 23);
            this.btnDesencriptar.TabIndex = 12;
            this.btnDesencriptar.Text = "Desencriptar ";
            this.btnDesencriptar.UseVisualStyleBackColor = true;
            this.btnDesencriptar.Visible = false;
            this.btnDesencriptar.Click += new System.EventHandler(this.btnDesencriptar_Click);
            // 
            // lblDesencriptar
            // 
            this.lblDesencriptar.AutoSize = true;
            this.lblDesencriptar.Location = new System.Drawing.Point(635, 430);
            this.lblDesencriptar.Name = "lblDesencriptar";
            this.lblDesencriptar.Size = new System.Drawing.Size(188, 13);
            this.lblDesencriptar.TabIndex = 13;
            this.lblDesencriptar.Text = "Desencriptar los mensajes por la clave";
            this.lblDesencriptar.Visible = false;
            // 
            // txtClaveEncriptada
            // 
            this.txtClaveEncriptada.Location = new System.Drawing.Point(638, 398);
            this.txtClaveEncriptada.Multiline = true;
            this.txtClaveEncriptada.Name = "txtClaveEncriptada";
            this.txtClaveEncriptada.Size = new System.Drawing.Size(315, 20);
            this.txtClaveEncriptada.TabIndex = 14;
            this.txtClaveEncriptada.Visible = false;
            // 
            // lblMensajeEncr
            // 
            this.lblMensajeEncr.AutoSize = true;
            this.lblMensajeEncr.Location = new System.Drawing.Point(635, 380);
            this.lblMensajeEncr.Name = "lblMensajeEncr";
            this.lblMensajeEncr.Size = new System.Drawing.Size(219, 13);
            this.lblMensajeEncr.TabIndex = 15;
            this.lblMensajeEncr.Text = "Mensajes encriptados con la siguiente clave:";
            this.lblMensajeEncr.Visible = false;
            // 
            // txtClaveDesencriptada
            // 
            this.txtClaveDesencriptada.Location = new System.Drawing.Point(638, 475);
            this.txtClaveDesencriptada.Name = "txtClaveDesencriptada";
            this.txtClaveDesencriptada.Size = new System.Drawing.Size(216, 20);
            this.txtClaveDesencriptada.TabIndex = 16;
            this.txtClaveDesencriptada.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 499);
            this.Controls.Add(this.txtClaveDesencriptada);
            this.Controls.Add(this.lblMensajeEncr);
            this.Controls.Add(this.txtClaveEncriptada);
            this.Controls.Add(this.lblDesencriptar);
            this.Controls.Add(this.btnDesencriptar);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblEncriptar);
            this.Controls.Add(this.btnEncriptar);
            this.Controls.Add(this.txtMostMensajes);
            this.Controls.Add(this.btnMostMensajes);
            this.Controls.Add(this.txtSelecMensaje);
            this.Controls.Add(this.btnSelecMensajes);
            this.Controls.Add(this.MensajesDPI);
            this.Controls.Add(this.txtDPI);
            this.Controls.Add(this.btnDPI);
            this.Controls.Add(this.Mensajes);
            this.Controls.Add(this.btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.ListBox Mensajes;
        private System.Windows.Forms.Button btnDPI;
        private System.Windows.Forms.TextBox txtDPI;
        private System.Windows.Forms.ListBox MensajesDPI;
        private System.Windows.Forms.Button btnSelecMensajes;
        private System.Windows.Forms.TextBox txtSelecMensaje;
        private System.Windows.Forms.Button btnMostMensajes;
        private System.Windows.Forms.TextBox txtMostMensajes;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.Label lblEncriptar;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnDesencriptar;
        private System.Windows.Forms.Label lblDesencriptar;
        private System.Windows.Forms.TextBox txtClaveEncriptada;
        private System.Windows.Forms.Label lblMensajeEncr;
        private System.Windows.Forms.TextBox txtClaveDesencriptada;
    }
}

