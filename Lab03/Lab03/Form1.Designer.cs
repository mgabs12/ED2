namespace Lab03
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
            this.btnCargarArchivo = new System.Windows.Forms.Button();
            this.Cartas = new System.Windows.Forms.ListBox();
            this.lblNodeCartas = new System.Windows.Forms.Label();
            this.txtDPI = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.NoCartas = new System.Windows.Forms.ListBox();
            this.lblCartasEncontradas = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtMostrarCarta = new System.Windows.Forms.TextBox();
            this.btnTexto = new System.Windows.Forms.Button();
            this.txtMostrarTexto = new System.Windows.Forms.TextBox();
            this.btnComprimirTexto = new System.Windows.Forms.Button();
            this.btnDescomprimirTexto = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.Location = new System.Drawing.Point(24, 28);
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(96, 23);
            this.btnCargarArchivo.TabIndex = 0;
            this.btnCargarArchivo.Text = "Cargar archivo";
            this.btnCargarArchivo.UseVisualStyleBackColor = true;
            this.btnCargarArchivo.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cartas
            // 
            this.Cartas.FormattingEnabled = true;
            this.Cartas.Location = new System.Drawing.Point(24, 58);
            this.Cartas.Name = "Cartas";
            this.Cartas.Size = new System.Drawing.Size(243, 147);
            this.Cartas.TabIndex = 1;
            this.Cartas.Visible = false;
            // 
            // lblNodeCartas
            // 
            this.lblNodeCartas.AutoSize = true;
            this.lblNodeCartas.Location = new System.Drawing.Point(56, 212);
            this.lblNodeCartas.Name = "lblNodeCartas";
            this.lblNodeCartas.Size = new System.Drawing.Size(0, 13);
            this.lblNodeCartas.TabIndex = 2;
            // 
            // txtDPI
            // 
            this.txtDPI.Location = new System.Drawing.Point(393, 30);
            this.txtDPI.Name = "txtDPI";
            this.txtDPI.Size = new System.Drawing.Size(193, 20);
            this.txtDPI.TabIndex = 3;
            this.txtDPI.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar DPI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // NoCartas
            // 
            this.NoCartas.FormattingEnabled = true;
            this.NoCartas.Location = new System.Drawing.Point(393, 88);
            this.NoCartas.Name = "NoCartas";
            this.NoCartas.Size = new System.Drawing.Size(230, 121);
            this.NoCartas.TabIndex = 5;
            this.NoCartas.Visible = false;
            // 
            // lblCartasEncontradas
            // 
            this.lblCartasEncontradas.AutoSize = true;
            this.lblCartasEncontradas.Location = new System.Drawing.Point(434, 216);
            this.lblCartasEncontradas.Name = "lblCartasEncontradas";
            this.lblCartasEncontradas.Size = new System.Drawing.Size(0, 13);
            this.lblCartasEncontradas.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Seleccionar Carta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtMostrarCarta
            // 
            this.txtMostrarCarta.Location = new System.Drawing.Point(24, 271);
            this.txtMostrarCarta.Name = "txtMostrarCarta";
            this.txtMostrarCarta.Size = new System.Drawing.Size(659, 20);
            this.txtMostrarCarta.TabIndex = 8;
            this.txtMostrarCarta.Visible = false;
            // 
            // btnTexto
            // 
            this.btnTexto.Location = new System.Drawing.Point(24, 298);
            this.btnTexto.Name = "btnTexto";
            this.btnTexto.Size = new System.Drawing.Size(125, 23);
            this.btnTexto.TabIndex = 9;
            this.btnTexto.Text = "Mostrar Carta";
            this.btnTexto.UseVisualStyleBackColor = true;
            this.btnTexto.Visible = false;
            this.btnTexto.Click += new System.EventHandler(this.btnTexto_Click);
            // 
            // txtMostrarTexto
            // 
            this.txtMostrarTexto.Location = new System.Drawing.Point(24, 328);
            this.txtMostrarTexto.Multiline = true;
            this.txtMostrarTexto.Name = "txtMostrarTexto";
            this.txtMostrarTexto.Size = new System.Drawing.Size(659, 214);
            this.txtMostrarTexto.TabIndex = 10;
            this.txtMostrarTexto.Visible = false;
            // 
            // btnComprimirTexto
            // 
            this.btnComprimirTexto.Location = new System.Drawing.Point(100, 559);
            this.btnComprimirTexto.Name = "btnComprimirTexto";
            this.btnComprimirTexto.Size = new System.Drawing.Size(111, 23);
            this.btnComprimirTexto.TabIndex = 11;
            this.btnComprimirTexto.Text = "Comprimir Carta";
            this.btnComprimirTexto.UseVisualStyleBackColor = true;
            this.btnComprimirTexto.Visible = false;
            this.btnComprimirTexto.Click += new System.EventHandler(this.btnComprimirTexto_Click);
            // 
            // btnDescomprimirTexto
            // 
            this.btnDescomprimirTexto.Location = new System.Drawing.Point(272, 559);
            this.btnDescomprimirTexto.Name = "btnDescomprimirTexto";
            this.btnDescomprimirTexto.Size = new System.Drawing.Size(120, 23);
            this.btnDescomprimirTexto.TabIndex = 12;
            this.btnDescomprimirTexto.Text = "Descomprimir Carta";
            this.btnDescomprimirTexto.UseVisualStyleBackColor = true;
            this.btnDescomprimirTexto.Visible = false;
            this.btnDescomprimirTexto.Click += new System.EventHandler(this.btnDescomprimirTexto_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(437, 559);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Guardar archivo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(708, 594);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDescomprimirTexto);
            this.Controls.Add(this.btnComprimirTexto);
            this.Controls.Add(this.txtMostrarTexto);
            this.Controls.Add(this.btnTexto);
            this.Controls.Add(this.txtMostrarCarta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblCartasEncontradas);
            this.Controls.Add(this.NoCartas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDPI);
            this.Controls.Add(this.lblNodeCartas);
            this.Controls.Add(this.Cartas);
            this.Controls.Add(this.btnCargarArchivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargarArchivo;
        private System.Windows.Forms.ListBox Cartas;
        private System.Windows.Forms.Label lblNodeCartas;
        private System.Windows.Forms.TextBox txtDPI;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox NoCartas;
        private System.Windows.Forms.Label lblCartasEncontradas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtMostrarCarta;
        private System.Windows.Forms.Button btnTexto;
        private System.Windows.Forms.TextBox txtMostrarTexto;
        private System.Windows.Forms.Button btnComprimirTexto;
        private System.Windows.Forms.Button btnDescomprimirTexto;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

