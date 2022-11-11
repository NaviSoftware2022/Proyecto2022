namespace JAGSport.FormVariable
{
    partial class eventosPasados
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
            this.estadio = new System.Windows.Forms.Label();
            this.fechaEve = new System.Windows.Forms.Label();
            this.team1 = new System.Windows.Forms.Label();
            this.resultado1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultado2 = new System.Windows.Forms.Label();
            this.team2 = new System.Windows.Forms.Label();
            this.horaEve = new System.Windows.Forms.Label();
            this.deporteEve = new System.Windows.Forms.Label();
            this.jugador1 = new System.Windows.Forms.DataGridView();
            this.jugador2 = new System.Windows.Forms.DataGridView();
            this.ganador1 = new System.Windows.Forms.Label();
            this.perdedor1 = new System.Windows.Forms.Label();
            this.perdedor2 = new System.Windows.Forms.Label();
            this.ganador2 = new System.Windows.Forms.Label();
            this.empate = new System.Windows.Forms.Label();
            this.pais = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jugador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugador2)).BeginInit();
            this.SuspendLayout();
            // 
            // estadio
            // 
            this.estadio.AutoSize = true;
            this.estadio.Location = new System.Drawing.Point(64, 42);
            this.estadio.Name = "estadio";
            this.estadio.Size = new System.Drawing.Size(50, 13);
            this.estadio.TabIndex = 0;
            this.estadio.Text = "*Estadio*";
            this.estadio.Click += new System.EventHandler(this.label1_Click);
            // 
            // fechaEve
            // 
            this.fechaEve.AutoSize = true;
            this.fechaEve.Location = new System.Drawing.Point(187, 42);
            this.fechaEve.Name = "fechaEve";
            this.fechaEve.Size = new System.Drawing.Size(34, 13);
            this.fechaEve.TabIndex = 1;
            this.fechaEve.Text = "fecha";
            // 
            // team1
            // 
            this.team1.AutoSize = true;
            this.team1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team1.Location = new System.Drawing.Point(47, 106);
            this.team1.Name = "team1";
            this.team1.Size = new System.Drawing.Size(109, 37);
            this.team1.TabIndex = 2;
            this.team1.Text = "team1";
            // 
            // resultado1
            // 
            this.resultado1.AutoSize = true;
            this.resultado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado1.Location = new System.Drawing.Point(123, 143);
            this.resultado1.Name = "resultado1";
            this.resultado1.Size = new System.Drawing.Size(67, 31);
            this.resultado1.TabIndex = 3;
            this.resultado1.Text = "res1";
            this.resultado1.Click += new System.EventHandler(this.resultado1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 55);
            this.label2.TabIndex = 4;
            this.label2.Text = "-";
            // 
            // resultado2
            // 
            this.resultado2.AutoSize = true;
            this.resultado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado2.Location = new System.Drawing.Point(501, 146);
            this.resultado2.Name = "resultado2";
            this.resultado2.Size = new System.Drawing.Size(67, 31);
            this.resultado2.TabIndex = 6;
            this.resultado2.Text = "res2";
            // 
            // team2
            // 
            this.team2.AutoSize = true;
            this.team2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team2.Location = new System.Drawing.Point(445, 109);
            this.team2.Name = "team2";
            this.team2.Size = new System.Drawing.Size(111, 37);
            this.team2.TabIndex = 5;
            this.team2.Text = "team2";
            this.team2.Click += new System.EventHandler(this.team2_Click);
            // 
            // horaEve
            // 
            this.horaEve.AutoSize = true;
            this.horaEve.Location = new System.Drawing.Point(327, 42);
            this.horaEve.Name = "horaEve";
            this.horaEve.Size = new System.Drawing.Size(28, 13);
            this.horaEve.TabIndex = 7;
            this.horaEve.Text = "hora";
            // 
            // deporteEve
            // 
            this.deporteEve.AutoSize = true;
            this.deporteEve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deporteEve.Location = new System.Drawing.Point(306, 159);
            this.deporteEve.Name = "deporteEve";
            this.deporteEve.Size = new System.Drawing.Size(64, 20);
            this.deporteEve.TabIndex = 8;
            this.deporteEve.Text = "deporte";
            // 
            // jugador1
            // 
            this.jugador1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jugador1.Location = new System.Drawing.Point(67, 215);
            this.jugador1.Name = "jugador1";
            this.jugador1.Size = new System.Drawing.Size(194, 318);
            this.jugador1.TabIndex = 9;
            this.jugador1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jugador1_CellDoubleClick);
            // 
            // jugador2
            // 
            this.jugador2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jugador2.Location = new System.Drawing.Point(424, 215);
            this.jugador2.Name = "jugador2";
            this.jugador2.Size = new System.Drawing.Size(210, 318);
            this.jugador2.TabIndex = 10;
            this.jugador2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jugador2_CellDoubleClick);
            // 
            // ganador1
            // 
            this.ganador1.AutoSize = true;
            this.ganador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ganador1.Location = new System.Drawing.Point(106, 192);
            this.ganador1.Name = "ganador1";
            this.ganador1.Size = new System.Drawing.Size(72, 20);
            this.ganador1.TabIndex = 11;
            this.ganador1.Text = "Ganador";
            this.ganador1.Visible = false;
            // 
            // perdedor1
            // 
            this.perdedor1.AutoSize = true;
            this.perdedor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perdedor1.Location = new System.Drawing.Point(106, 192);
            this.perdedor1.Name = "perdedor1";
            this.perdedor1.Size = new System.Drawing.Size(74, 20);
            this.perdedor1.TabIndex = 12;
            this.perdedor1.Text = "Perdedor";
            this.perdedor1.Visible = false;
            // 
            // perdedor2
            // 
            this.perdedor2.AutoSize = true;
            this.perdedor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perdedor2.Location = new System.Drawing.Point(482, 192);
            this.perdedor2.Name = "perdedor2";
            this.perdedor2.Size = new System.Drawing.Size(74, 20);
            this.perdedor2.TabIndex = 13;
            this.perdedor2.Text = "Perdedor";
            this.perdedor2.Visible = false;
            // 
            // ganador2
            // 
            this.ganador2.AutoSize = true;
            this.ganador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ganador2.Location = new System.Drawing.Point(484, 192);
            this.ganador2.Name = "ganador2";
            this.ganador2.Size = new System.Drawing.Size(72, 20);
            this.ganador2.TabIndex = 14;
            this.ganador2.Text = "Ganador";
            this.ganador2.Visible = false;
            // 
            // empate
            // 
            this.empate.AutoSize = true;
            this.empate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empate.Location = new System.Drawing.Point(305, 192);
            this.empate.Name = "empate";
            this.empate.Size = new System.Drawing.Size(65, 20);
            this.empate.TabIndex = 15;
            this.empate.Text = "Empate";
            this.empate.Visible = false;
            // 
            // pais
            // 
            this.pais.AutoSize = true;
            this.pais.Location = new System.Drawing.Point(64, 68);
            this.pais.Name = "pais";
            this.pais.Size = new System.Drawing.Size(35, 13);
            this.pais.TabIndex = 16;
            this.pais.Text = "label3";
            // 
            // eventosPasados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 562);
            this.Controls.Add(this.pais);
            this.Controls.Add(this.empate);
            this.Controls.Add(this.ganador2);
            this.Controls.Add(this.perdedor2);
            this.Controls.Add(this.perdedor1);
            this.Controls.Add(this.ganador1);
            this.Controls.Add(this.jugador2);
            this.Controls.Add(this.jugador1);
            this.Controls.Add(this.deporteEve);
            this.Controls.Add(this.horaEve);
            this.Controls.Add(this.resultado2);
            this.Controls.Add(this.team2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultado1);
            this.Controls.Add(this.team1);
            this.Controls.Add(this.fechaEve);
            this.Controls.Add(this.estadio);
            this.Name = "eventosPasados";
            this.Text = "eventosPasados";
            this.Load += new System.EventHandler(this.eventosPasados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jugador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugador2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label estadio;
        private System.Windows.Forms.Label fechaEve;
        private System.Windows.Forms.Label team1;
        private System.Windows.Forms.Label resultado1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultado2;
        private System.Windows.Forms.Label team2;
        private System.Windows.Forms.Label horaEve;
        private System.Windows.Forms.Label deporteEve;
        private System.Windows.Forms.DataGridView jugador1;
        private System.Windows.Forms.DataGridView jugador2;
        private System.Windows.Forms.Label ganador1;
        private System.Windows.Forms.Label perdedor1;
        private System.Windows.Forms.Label perdedor2;
        private System.Windows.Forms.Label ganador2;
        private System.Windows.Forms.Label empate;
        private System.Windows.Forms.Label pais;
    }
}