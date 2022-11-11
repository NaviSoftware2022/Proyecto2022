namespace JAGSport
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.equiposLabel = new System.Windows.Forms.Label();
            this.eventoLabel = new System.Windows.Forms.Label();
            this.deporteLabel = new System.Windows.Forms.Label();
            this.btnSesion = new System.Windows.Forms.Button();
            this.btnCuenta = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ubicacionesLabel = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.jugadoresLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnActivar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerCorreo = new System.Windows.Forms.Timer(this.components);
            this.idiomaEspañol = new System.Windows.Forms.CheckBox();
            this.idiomaIngles = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.Restaurar);
            this.panel1.Controls.Add(this.Minimizar);
            this.panel1.Controls.Add(this.Maximizar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 60);
            this.panel1.TabIndex = 5;
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Restaurar.Image = global::JAGSport.Properties.Resources.maximizar;
            this.Restaurar.Location = new System.Drawing.Point(909, 12);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(27, 31);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Restaurar.TabIndex = 8;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.Image = global::JAGSport.Properties.Resources.minimizar_signo;
            this.Minimizar.Location = new System.Drawing.Point(860, 12);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(27, 31);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimizar.TabIndex = 7;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maximizar.Image = global::JAGSport.Properties.Resources.opcion_de_maximizar_tamano__1_;
            this.Maximizar.Location = new System.Drawing.Point(909, 12);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(27, 31);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Maximizar.TabIndex = 6;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::JAGSport.Properties.Resources.x1;
            this.pictureBox1.Location = new System.Drawing.Point(956, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // equiposLabel
            // 
            this.equiposLabel.AutoSize = true;
            this.equiposLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.equiposLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equiposLabel.Location = new System.Drawing.Point(385, 49);
            this.equiposLabel.Name = "equiposLabel";
            this.equiposLabel.Size = new System.Drawing.Size(80, 24);
            this.equiposLabel.TabIndex = 3;
            this.equiposLabel.Text = "Equipos";
            this.equiposLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // eventoLabel
            // 
            this.eventoLabel.AutoSize = true;
            this.eventoLabel.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.eventoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventoLabel.Location = new System.Drawing.Point(209, 49);
            this.eventoLabel.Name = "eventoLabel";
            this.eventoLabel.Size = new System.Drawing.Size(78, 24);
            this.eventoLabel.TabIndex = 1;
            this.eventoLabel.Text = "Eventos";
            this.eventoLabel.UseWaitCursor = true;
            this.eventoLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // deporteLabel
            // 
            this.deporteLabel.AutoSize = true;
            this.deporteLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deporteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deporteLabel.Location = new System.Drawing.Point(293, 49);
            this.deporteLabel.Name = "deporteLabel";
            this.deporteLabel.Size = new System.Drawing.Size(86, 24);
            this.deporteLabel.TabIndex = 2;
            this.deporteLabel.Text = "Deportes";
            this.deporteLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnSesion
            // 
            this.btnSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.btnSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSesion.Location = new System.Drawing.Point(762, 36);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Size = new System.Drawing.Size(143, 28);
            this.btnSesion.TabIndex = 4;
            this.btnSesion.Text = "Iniciar Sesion";
            this.btnSesion.UseVisualStyleBackColor = false;
            this.btnSesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCuenta
            // 
            this.btnCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.btnCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuenta.Location = new System.Drawing.Point(739, 36);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Size = new System.Drawing.Size(191, 28);
            this.btnCuenta.TabIndex = 5;
            this.btnCuenta.Text = "Cuenta";
            this.btnCuenta.UseVisualStyleBackColor = false;
            this.btnCuenta.Visible = false;
            this.btnCuenta.Click += new System.EventHandler(this.btnCuenta_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel2.Controls.Add(this.idiomaIngles);
            this.panel2.Controls.Add(this.idiomaEspañol);
            this.panel2.Controls.Add(this.ubicacionesLabel);
            this.panel2.Controls.Add(this.reset);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.jugadoresLabel);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.btnActivar);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btnSesion);
            this.panel2.Controls.Add(this.deporteLabel);
            this.panel2.Controls.Add(this.eventoLabel);
            this.panel2.Controls.Add(this.equiposLabel);
            this.panel2.Controls.Add(this.btnCuenta);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(995, 571);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // ubicacionesLabel
            // 
            this.ubicacionesLabel.AutoSize = true;
            this.ubicacionesLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ubicacionesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubicacionesLabel.Location = new System.Drawing.Point(576, 49);
            this.ubicacionesLabel.Name = "ubicacionesLabel";
            this.ubicacionesLabel.Size = new System.Drawing.Size(114, 24);
            this.ubicacionesLabel.TabIndex = 14;
            this.ubicacionesLabel.Text = "Ubicaciones";
            this.ubicacionesLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // reset
            // 
            this.reset.AutoSize = true;
            this.reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(437, 509);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(124, 35);
            this.reset.TabIndex = 13;
            this.reset.Text = "Actualizar";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::JAGSport.Properties.Resources.publi4;
            this.pictureBox4.Location = new System.Drawing.Point(860, 159);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(98, 331);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // jugadoresLabel
            // 
            this.jugadoresLabel.AutoSize = true;
            this.jugadoresLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jugadoresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jugadoresLabel.Location = new System.Drawing.Point(471, 49);
            this.jugadoresLabel.Name = "jugadoresLabel";
            this.jugadoresLabel.Size = new System.Drawing.Size(99, 24);
            this.jugadoresLabel.TabIndex = 11;
            this.jugadoresLabel.Text = "Jugadores";
            this.jugadoresLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::JAGSport.Properties.Resources.publi4;
            this.pictureBox3.Location = new System.Drawing.Point(30, 159);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(98, 331);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(160, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(679, 331);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnActivar
            // 
            this.btnActivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.btnActivar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivar.Location = new System.Drawing.Point(741, 70);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(189, 28);
            this.btnActivar.TabIndex = 7;
            this.btnActivar.Text = "Activa tu Membresia!!";
            this.btnActivar.UseVisualStyleBackColor = false;
            this.btnActivar.Visible = false;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::JAGSport.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(30, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(138, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerCorreo
            // 
            this.timerCorreo.Enabled = true;
            this.timerCorreo.Interval = 60000;
            this.timerCorreo.Tick += new System.EventHandler(this.timerCorreo_Tick);
            // 
            // idiomaEspañol
            // 
            this.idiomaEspañol.AutoSize = true;
            this.idiomaEspañol.Checked = true;
            this.idiomaEspañol.CheckState = System.Windows.Forms.CheckState.Checked;
            this.idiomaEspañol.Location = new System.Drawing.Point(213, 92);
            this.idiomaEspañol.Name = "idiomaEspañol";
            this.idiomaEspañol.Size = new System.Drawing.Size(64, 17);
            this.idiomaEspañol.TabIndex = 15;
            this.idiomaEspañol.Text = "Español";
            this.idiomaEspañol.UseVisualStyleBackColor = true;
            this.idiomaEspañol.CheckedChanged += new System.EventHandler(this.idiomaEspañol_CheckedChanged);
            // 
            // idiomaIngles
            // 
            this.idiomaIngles.AutoSize = true;
            this.idiomaIngles.Location = new System.Drawing.Point(213, 115);
            this.idiomaIngles.Name = "idiomaIngles";
            this.idiomaIngles.Size = new System.Drawing.Size(54, 17);
            this.idiomaIngles.TabIndex = 16;
            this.idiomaIngles.Text = "Ingles";
            this.idiomaIngles.UseVisualStyleBackColor = true;
            this.idiomaIngles.CheckedChanged += new System.EventHandler(this.idiomaIngles_CheckedChanged);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 631);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.Label equiposLabel;
        private System.Windows.Forms.Label eventoLabel;
        private System.Windows.Forms.Label deporteLabel;
        private System.Windows.Forms.Button btnSesion;
        private System.Windows.Forms.Button btnCuenta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label jugadoresLabel;
        private System.Windows.Forms.Timer timerCorreo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label ubicacionesLabel;
        private System.Windows.Forms.CheckBox idiomaIngles;
        private System.Windows.Forms.CheckBox idiomaEspañol;
    }
}