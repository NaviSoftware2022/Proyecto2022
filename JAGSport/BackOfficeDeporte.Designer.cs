namespace JAGSport
{
    partial class BackOfficeDeporte
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lista1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.deporteTxt = new System.Windows.Forms.TextBox();
            this.btnDeporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador de Eventos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Deportes ";
            // 
            // lista1
            // 
            this.lista1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista1.FormattingEnabled = true;
            this.lista1.ItemHeight = 16;
            this.lista1.Location = new System.Drawing.Point(168, 131);
            this.lista1.Name = "lista1";
            this.lista1.Size = new System.Drawing.Size(101, 132);
            this.lista1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Añadir Deporte:";
            // 
            // deporteTxt
            // 
            this.deporteTxt.Location = new System.Drawing.Point(168, 310);
            this.deporteTxt.Name = "deporteTxt";
            this.deporteTxt.Size = new System.Drawing.Size(100, 20);
            this.deporteTxt.TabIndex = 4;
            // 
            // btnDeporte
            // 
            this.btnDeporte.Location = new System.Drawing.Point(180, 354);
            this.btnDeporte.Name = "btnDeporte";
            this.btnDeporte.Size = new System.Drawing.Size(75, 23);
            this.btnDeporte.TabIndex = 5;
            this.btnDeporte.Text = "Añadir";
            this.btnDeporte.UseVisualStyleBackColor = true;
            this.btnDeporte.Click += new System.EventHandler(this.btnDeporte_Click);
            // 
            // BackOfficeDeporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeporte);
            this.Controls.Add(this.deporteTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lista1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BackOfficeDeporte";
            this.Text = "BackOfficeDeporte";
            this.Load += new System.EventHandler(this.BackOfficeDeporte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lista1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox deporteTxt;
        private System.Windows.Forms.Button btnDeporte;
    }
}