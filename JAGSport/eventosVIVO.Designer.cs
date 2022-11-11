namespace JAGSport
{
    partial class eventosVIVO
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.resultado2 = new System.Windows.Forms.NumericUpDown();
            this.resultado1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.team1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.team2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.paisComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listaLugarBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultado1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(677, 76);
            this.dataGridView1.TabIndex = 38;
            // 
            // resultado2
            // 
            this.resultado2.Location = new System.Drawing.Point(462, 190);
            this.resultado2.Name = "resultado2";
            this.resultado2.Size = new System.Drawing.Size(58, 20);
            this.resultado2.TabIndex = 35;
            // 
            // resultado1
            // 
            this.resultado1.Location = new System.Drawing.Point(256, 195);
            this.resultado1.Name = "resultado1";
            this.resultado1.Size = new System.Drawing.Size(58, 20);
            this.resultado1.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 26);
            this.label7.TabIndex = 33;
            this.label7.Text = "Resultado \r\nEquipo 1";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // team1
            // 
            this.team1.AutoSize = true;
            this.team1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team1.Location = new System.Drawing.Point(207, 144);
            this.team1.Name = "team1";
            this.team1.Size = new System.Drawing.Size(61, 24);
            this.team1.TabIndex = 32;
            this.team1.Text = "team1";
            this.team1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 33);
            this.label1.TabIndex = 23;
            this.label1.Text = "Asignacion de Resultados";
            // 
            // team2
            // 
            this.team2.AutoSize = true;
            this.team2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team2.Location = new System.Drawing.Point(422, 144);
            this.team2.Name = "team2";
            this.team2.Size = new System.Drawing.Size(61, 24);
            this.team2.TabIndex = 39;
            this.team2.Text = "team2";
            this.team2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 26);
            this.label2.TabIndex = 40;
            this.label2.Text = "Resultado \r\nEquipo 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(224, 341);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(250, 36);
            this.btn.TabIndex = 41;
            this.btn.Text = "Enviar";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(253, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 26);
            this.label10.TabIndex = 45;
            this.label10.Text = "Pais de la\r\nUbicacion";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paisComboBox
            // 
            this.paisComboBox.Enabled = false;
            this.paisComboBox.FormattingEnabled = true;
            this.paisComboBox.Location = new System.Drawing.Point(328, 296);
            this.paisComboBox.Name = "paisComboBox";
            this.paisComboBox.Size = new System.Drawing.Size(121, 21);
            this.paisComboBox.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 26);
            this.label8.TabIndex = 43;
            this.label8.Text = "Nombre del\r\nLugar\r\n";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listaLugarBox
            // 
            this.listaLugarBox.FormattingEnabled = true;
            this.listaLugarBox.Location = new System.Drawing.Point(328, 250);
            this.listaLugarBox.Name = "listaLugarBox";
            this.listaLugarBox.Size = new System.Drawing.Size(121, 21);
            this.listaLugarBox.TabIndex = 42;
            this.listaLugarBox.SelectedIndexChanged += new System.EventHandler(this.listaLugarBox_SelectedIndexChanged);
            // 
            // eventosVIVO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 389);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.paisComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listaLugarBox);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.team2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.resultado2);
            this.Controls.Add(this.resultado1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.team1);
            this.Controls.Add(this.label1);
            this.Name = "eventosVIVO";
            this.Text = "eventosVIVO";
            this.Load += new System.EventHandler(this.eventosVIVO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultado1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown resultado2;
        private System.Windows.Forms.NumericUpDown resultado1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label team1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label team2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox paisComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox listaLugarBox;
    }
}