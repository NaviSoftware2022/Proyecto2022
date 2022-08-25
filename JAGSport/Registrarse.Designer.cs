namespace JAGSport
{
    partial class Form2
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
            this.botonCorreo = new System.Windows.Forms.Button();
            this.contraseniaBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.correoBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botonCorreo
            // 
            this.botonCorreo.Location = new System.Drawing.Point(346, 231);
            this.botonCorreo.Name = "botonCorreo";
            this.botonCorreo.Size = new System.Drawing.Size(85, 23);
            this.botonCorreo.TabIndex = 15;
            this.botonCorreo.Text = "Ingresar";
            this.botonCorreo.UseVisualStyleBackColor = true;
            this.botonCorreo.Click += new System.EventHandler(this.botonCorreo_Click);
            // 
            // contraseniaBox
            // 
            this.contraseniaBox.Location = new System.Drawing.Point(428, 176);
            this.contraseniaBox.Name = "contraseniaBox";
            this.contraseniaBox.Size = new System.Drawing.Size(116, 20);
            this.contraseniaBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ingresa una Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ingresa un Correo";
            // 
            // correoBox
            // 
            this.correoBox.Location = new System.Drawing.Point(237, 176);
            this.correoBox.Name = "correoBox";
            this.correoBox.Size = new System.Drawing.Size(115, 20);
            this.correoBox.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonCorreo);
            this.Controls.Add(this.contraseniaBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.correoBox);
            this.Name = "Form2";
            this.Text = "Registrarse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonCorreo;
        private System.Windows.Forms.TextBox contraseniaBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox correoBox;
    }
}