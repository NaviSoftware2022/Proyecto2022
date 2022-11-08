namespace JAGSport
{
    partial class eventoProximoBackOffice
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
            this.zonaCombo2 = new System.Windows.Forms.ComboBox();
            this.zonaCombo1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sda = new System.Windows.Forms.Label();
            this.horaEvento = new System.Windows.Forms.DateTimePicker();
            this.listaEquipo2 = new System.Windows.Forms.ComboBox();
            this.listaEquipo1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fechaEvento = new System.Windows.Forms.DateTimePicker();
            this.listaDeportes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // zonaCombo2
            // 
            this.zonaCombo2.Enabled = false;
            this.zonaCombo2.FormattingEnabled = true;
            this.zonaCombo2.Location = new System.Drawing.Point(642, 100);
            this.zonaCombo2.Name = "zonaCombo2";
            this.zonaCombo2.Size = new System.Drawing.Size(121, 21);
            this.zonaCombo2.TabIndex = 43;
            // 
            // zonaCombo1
            // 
            this.zonaCombo1.Enabled = false;
            this.zonaCombo1.FormattingEnabled = true;
            this.zonaCombo1.Location = new System.Drawing.Point(403, 100);
            this.zonaCombo1.Name = "zonaCombo1";
            this.zonaCombo1.Size = new System.Drawing.Size(121, 21);
            this.zonaCombo1.TabIndex = 42;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 26);
            this.label9.TabIndex = 40;
            this.label9.Text = "* Para eliminar un Evento haga doble *\r\n * clic sobre el evento *";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(77, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 29);
            this.button1.TabIndex = 39;
            this.button1.Text = "Añadir Evento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(321, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(467, 226);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // sda
            // 
            this.sda.AutoSize = true;
            this.sda.Location = new System.Drawing.Point(74, 182);
            this.sda.Name = "sda";
            this.sda.Size = new System.Drawing.Size(47, 26);
            this.sda.TabIndex = 37;
            this.sda.Text = "Hora del\r\n Evento";
            this.sda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // horaEvento
            // 
            this.horaEvento.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaEvento.Location = new System.Drawing.Point(155, 183);
            this.horaEvento.Name = "horaEvento";
            this.horaEvento.Size = new System.Drawing.Size(121, 20);
            this.horaEvento.TabIndex = 36;
            this.horaEvento.Value = new System.DateTime(2022, 10, 24, 0, 0, 0, 0);
            // 
            // listaEquipo2
            // 
            this.listaEquipo2.Enabled = false;
            this.listaEquipo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaEquipo2.FormattingEnabled = true;
            this.listaEquipo2.Location = new System.Drawing.Point(642, 70);
            this.listaEquipo2.Name = "listaEquipo2";
            this.listaEquipo2.Size = new System.Drawing.Size(121, 24);
            this.listaEquipo2.TabIndex = 31;
            this.listaEquipo2.SelectedIndexChanged += new System.EventHandler(this.listaEquipo2_SelectedIndexChanged);
            // 
            // listaEquipo1
            // 
            this.listaEquipo1.Enabled = false;
            this.listaEquipo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaEquipo1.FormattingEnabled = true;
            this.listaEquipo1.Location = new System.Drawing.Point(403, 70);
            this.listaEquipo1.Name = "listaEquipo1";
            this.listaEquipo1.Size = new System.Drawing.Size(121, 24);
            this.listaEquipo1.TabIndex = 30;
            this.listaEquipo1.SelectedIndexChanged += new System.EventHandler(this.listaEquipo1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 26);
            this.label5.TabIndex = 29;
            this.label5.Text = "Equipo \r\nNumero 2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 26);
            this.label4.TabIndex = 28;
            this.label4.Text = "Equipo \r\nNumero 1";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 26);
            this.label3.TabIndex = 27;
            this.label3.Text = "Fecha del\r\n Evento";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fechaEvento
            // 
            this.fechaEvento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaEvento.Location = new System.Drawing.Point(155, 130);
            this.fechaEvento.MaxDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.fechaEvento.Name = "fechaEvento";
            this.fechaEvento.Size = new System.Drawing.Size(121, 20);
            this.fechaEvento.TabIndex = 26;
            this.fechaEvento.Value = new System.DateTime(2022, 10, 24, 0, 0, 0, 0);
            // 
            // listaDeportes
            // 
            this.listaDeportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaDeportes.FormattingEnabled = true;
            this.listaDeportes.Location = new System.Drawing.Point(155, 74);
            this.listaDeportes.Name = "listaDeportes";
            this.listaDeportes.Size = new System.Drawing.Size(121, 24);
            this.listaDeportes.TabIndex = 25;
            this.listaDeportes.SelectedIndexChanged += new System.EventHandler(this.listaDeportes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "Deporte del \r\nEvento";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 33);
            this.label1.TabIndex = 23;
            this.label1.Text = "Eventos Futuros";
            // 
            // eventoProximoBackOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.zonaCombo2);
            this.Controls.Add(this.zonaCombo1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sda);
            this.Controls.Add(this.horaEvento);
            this.Controls.Add(this.listaEquipo2);
            this.Controls.Add(this.listaEquipo1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fechaEvento);
            this.Controls.Add(this.listaDeportes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "eventoProximoBackOffice";
            this.Text = "eventoProximoBackOffice";
            this.Load += new System.EventHandler(this.eventoProximoBackOffice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox zonaCombo2;
        private System.Windows.Forms.ComboBox zonaCombo1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label sda;
        private System.Windows.Forms.DateTimePicker horaEvento;
        private System.Windows.Forms.ComboBox listaEquipo2;
        private System.Windows.Forms.ComboBox listaEquipo1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fechaEvento;
        private System.Windows.Forms.ComboBox listaDeportes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}