namespace JAGSport.FormVariable
{
    partial class Deportes
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
            this.deportetxt = new System.Windows.Forms.Label();
            this.equiposGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eventosGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.equiposGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // deportetxt
            // 
            this.deportetxt.AutoSize = true;
            this.deportetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deportetxt.Location = new System.Drawing.Point(12, 9);
            this.deportetxt.Name = "deportetxt";
            this.deportetxt.Size = new System.Drawing.Size(75, 24);
            this.deportetxt.TabIndex = 0;
            this.deportetxt.Text = "deporte";
            // 
            // equiposGrid
            // 
            this.equiposGrid.AllowUserToAddRows = false;
            this.equiposGrid.AllowUserToDeleteRows = false;
            this.equiposGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equiposGrid.Location = new System.Drawing.Point(69, 119);
            this.equiposGrid.Name = "equiposGrid";
            this.equiposGrid.ReadOnly = true;
            this.equiposGrid.Size = new System.Drawing.Size(240, 292);
            this.equiposGrid.TabIndex = 1;
            this.equiposGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.equiposGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.equiposGrid_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Equipos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(418, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Eventos";
            // 
            // eventosGrid
            // 
            this.eventosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventosGrid.Location = new System.Drawing.Point(422, 96);
            this.eventosGrid.Name = "eventosGrid";
            this.eventosGrid.Size = new System.Drawing.Size(352, 315);
            this.eventosGrid.TabIndex = 4;
            this.eventosGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventosGrid_CellDoubleClick);
            // 
            // Deportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eventosGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.equiposGrid);
            this.Controls.Add(this.deportetxt);
            this.Name = "Deportes";
            this.Text = "Deportes";
            this.Load += new System.EventHandler(this.Deportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equiposGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deportetxt;
        private System.Windows.Forms.DataGridView equiposGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView eventosGrid;
    }
}