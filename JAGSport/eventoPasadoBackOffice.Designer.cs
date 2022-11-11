namespace JAGSport
{
    partial class eventoPasadoBackOffice
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
            this.listaDeportes = new System.Windows.Forms.ComboBox();
            this.fechaEvento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listaEquipo1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.resultado1 = new System.Windows.Forms.NumericUpDown();
            this.resultado2 = new System.Windows.Forms.NumericUpDown();
            this.horaEvento = new System.Windows.Forms.DateTimePicker();
            this.sda = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.zonaCombo1 = new System.Windows.Forms.ComboBox();
            this.zonaCombo2 = new System.Windows.Forms.ComboBox();
            this.listaEquipo2 = new System.Windows.Forms.ComboBox();
            this.listaLugarBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.paisComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resultado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eventos Pasados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Deporte del \r\nEvento";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listaDeportes
            // 
            this.listaDeportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaDeportes.FormattingEnabled = true;
            this.listaDeportes.Location = new System.Drawing.Point(132, 84);
            this.listaDeportes.Name = "listaDeportes";
            this.listaDeportes.Size = new System.Drawing.Size(121, 24);
            this.listaDeportes.TabIndex = 2;
            this.listaDeportes.SelectedIndexChanged += new System.EventHandler(this.listaDeportes_SelectedIndexChanged);
            // 
            // fechaEvento
            // 
            this.fechaEvento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaEvento.Location = new System.Drawing.Point(132, 140);
            this.fechaEvento.MaxDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.fechaEvento.Name = "fechaEvento";
            this.fechaEvento.Size = new System.Drawing.Size(121, 20);
            this.fechaEvento.TabIndex = 3;
            this.fechaEvento.Value = new System.DateTime(2022, 10, 24, 0, 0, 0, 0);
            this.fechaEvento.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha del\r\n Evento";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Equipo \r\nNumero 1";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(563, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Equipo \r\nNumero 2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listaEquipo1
            // 
            this.listaEquipo1.Enabled = false;
            this.listaEquipo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaEquipo1.FormattingEnabled = true;
            this.listaEquipo1.Location = new System.Drawing.Point(383, 82);
            this.listaEquipo1.Name = "listaEquipo1";
            this.listaEquipo1.Size = new System.Drawing.Size(121, 24);
            this.listaEquipo1.TabIndex = 7;
            this.listaEquipo1.SelectedIndexChanged += new System.EventHandler(this.listaEquipo1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Resultado \r\nEquipo 1";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(563, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 26);
            this.label7.TabIndex = 11;
            this.label7.Text = "Resultado \r\nEquipo 2";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultado1
            // 
            this.resultado1.Location = new System.Drawing.Point(383, 175);
            this.resultado1.Name = "resultado1";
            this.resultado1.Size = new System.Drawing.Size(58, 20);
            this.resultado1.TabIndex = 13;
            // 
            // resultado2
            // 
            this.resultado2.Location = new System.Drawing.Point(622, 175);
            this.resultado2.Name = "resultado2";
            this.resultado2.Size = new System.Drawing.Size(58, 20);
            this.resultado2.TabIndex = 14;
            // 
            // horaEvento
            // 
            this.horaEvento.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaEvento.Location = new System.Drawing.Point(132, 193);
            this.horaEvento.Name = "horaEvento";
            this.horaEvento.Size = new System.Drawing.Size(121, 20);
            this.horaEvento.TabIndex = 15;
            this.horaEvento.Value = new System.DateTime(2022, 10, 24, 0, 0, 0, 0);
            // 
            // sda
            // 
            this.sda.AutoSize = true;
            this.sda.Location = new System.Drawing.Point(51, 192);
            this.sda.Name = "sda";
            this.sda.Size = new System.Drawing.Size(47, 26);
            this.sda.TabIndex = 16;
            this.sda.Text = "Hora del\r\n Evento";
            this.sda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(276, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(467, 226);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(54, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 29);
            this.button1.TabIndex = 18;
            this.button1.Text = "Añadir Evento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 26);
            this.label9.TabIndex = 19;
            this.label9.Text = "* Para eliminar un Evento haga doble *\r\n * clic sobre el evento *";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // zonaCombo1
            // 
            this.zonaCombo1.Enabled = false;
            this.zonaCombo1.FormattingEnabled = true;
            this.zonaCombo1.Location = new System.Drawing.Point(383, 112);
            this.zonaCombo1.Name = "zonaCombo1";
            this.zonaCombo1.Size = new System.Drawing.Size(121, 21);
            this.zonaCombo1.TabIndex = 21;
            // 
            // zonaCombo2
            // 
            this.zonaCombo2.Enabled = false;
            this.zonaCombo2.FormattingEnabled = true;
            this.zonaCombo2.Location = new System.Drawing.Point(622, 112);
            this.zonaCombo2.Name = "zonaCombo2";
            this.zonaCombo2.Size = new System.Drawing.Size(121, 21);
            this.zonaCombo2.TabIndex = 22;
            // 
            // listaEquipo2
            // 
            this.listaEquipo2.Enabled = false;
            this.listaEquipo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaEquipo2.FormattingEnabled = true;
            this.listaEquipo2.Location = new System.Drawing.Point(622, 82);
            this.listaEquipo2.Name = "listaEquipo2";
            this.listaEquipo2.Size = new System.Drawing.Size(121, 24);
            this.listaEquipo2.TabIndex = 8;
            this.listaEquipo2.SelectedIndexChanged += new System.EventHandler(this.listaEquipo2_SelectedIndexChanged);
            // 
            // listaLugarBox
            // 
            this.listaLugarBox.FormattingEnabled = true;
            this.listaLugarBox.Location = new System.Drawing.Point(132, 244);
            this.listaLugarBox.Name = "listaLugarBox";
            this.listaLugarBox.Size = new System.Drawing.Size(121, 21);
            this.listaLugarBox.TabIndex = 23;
            this.listaLugarBox.SelectedIndexChanged += new System.EventHandler(this.listaLugarBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 26);
            this.label8.TabIndex = 24;
            this.label8.Text = "Nombre del\r\nLugar\r\n";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paisComboBox
            // 
            this.paisComboBox.Enabled = false;
            this.paisComboBox.FormattingEnabled = true;
            this.paisComboBox.Location = new System.Drawing.Point(132, 290);
            this.paisComboBox.Name = "paisComboBox";
            this.paisComboBox.Size = new System.Drawing.Size(121, 21);
            this.paisComboBox.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 26);
            this.label10.TabIndex = 26;
            this.label10.Text = "Pais de la\r\nUbicacion";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventoPasadoBackOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.paisComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listaLugarBox);
            this.Controls.Add(this.zonaCombo2);
            this.Controls.Add(this.zonaCombo1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sda);
            this.Controls.Add(this.horaEvento);
            this.Controls.Add(this.resultado2);
            this.Controls.Add(this.resultado1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listaEquipo2);
            this.Controls.Add(this.listaEquipo1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fechaEvento);
            this.Controls.Add(this.listaDeportes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "eventoPasadoBackOffice";
            this.Text = "eventoPasadoBackOffice";
            this.Load += new System.EventHandler(this.eventoPasadoBackOffice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox listaDeportes;
        private System.Windows.Forms.DateTimePicker fechaEvento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox listaEquipo1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown resultado1;
        private System.Windows.Forms.NumericUpDown resultado2;
        private System.Windows.Forms.DateTimePicker horaEvento;
        private System.Windows.Forms.Label sda;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox zonaCombo1;
        private System.Windows.Forms.ComboBox zonaCombo2;
        private System.Windows.Forms.ComboBox listaEquipo2;
        private System.Windows.Forms.ComboBox listaLugarBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox paisComboBox;
        private System.Windows.Forms.Label label10;
    }
}