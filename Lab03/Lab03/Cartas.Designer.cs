namespace Lab03
{
    partial class Cartas
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
            this.btnLeerArchivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeerArchivo
            // 
            this.btnLeerArchivo.Font = new System.Drawing.Font("DrawingRainbow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeerArchivo.Location = new System.Drawing.Point(22, 22);
            this.btnLeerArchivo.Name = "btnLeerArchivo";
            this.btnLeerArchivo.Size = new System.Drawing.Size(138, 42);
            this.btnLeerArchivo.TabIndex = 0;
            this.btnLeerArchivo.Text = "Leer Archivo";
            this.btnLeerArchivo.UseVisualStyleBackColor = true;
            // 
            // Cartas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLeerArchivo);
            this.Name = "Cartas";
            this.Text = "Cartas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLeerArchivo;
    }
}