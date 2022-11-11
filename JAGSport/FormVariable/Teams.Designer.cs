namespace JAGSport.FormVariable
{
    partial class Teams
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
            this.nameTeam = new System.Windows.Forms.Label();
            this.deporteTeam = new System.Windows.Forms.Label();
            this.playersTeam = new System.Windows.Forms.Label();
            this.gridTeam = new System.Windows.Forms.DataGridView();
            this.zonatxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTeam
            // 
            this.nameTeam.AutoSize = true;
            this.nameTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTeam.Location = new System.Drawing.Point(21, 28);
            this.nameTeam.Name = "nameTeam";
            this.nameTeam.Size = new System.Drawing.Size(138, 25);
            this.nameTeam.TabIndex = 0;
            this.nameTeam.Text = "NAME TEAM";
            // 
            // deporteTeam
            // 
            this.deporteTeam.AutoSize = true;
            this.deporteTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deporteTeam.Location = new System.Drawing.Point(310, 33);
            this.deporteTeam.Name = "deporteTeam";
            this.deporteTeam.Size = new System.Drawing.Size(51, 20);
            this.deporteTeam.TabIndex = 2;
            this.deporteTeam.Text = "label1";
            // 
            // playersTeam
            // 
            this.playersTeam.AutoSize = true;
            this.playersTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersTeam.Location = new System.Drawing.Point(36, 119);
            this.playersTeam.Name = "playersTeam";
            this.playersTeam.Size = new System.Drawing.Size(109, 24);
            this.playersTeam.TabIndex = 3;
            this.playersTeam.Text = "Jugadores :";
            // 
            // gridTeam
            // 
            this.gridTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTeam.Location = new System.Drawing.Point(199, 100);
            this.gridTeam.Name = "gridTeam";
            this.gridTeam.Size = new System.Drawing.Size(299, 338);
            this.gridTeam.TabIndex = 4;
            this.gridTeam.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTeam_CellDoubleClick);
            // 
            // zonatxt
            // 
            this.zonatxt.AutoSize = true;
            this.zonatxt.Location = new System.Drawing.Point(58, 62);
            this.zonatxt.Name = "zonatxt";
            this.zonatxt.Size = new System.Drawing.Size(35, 13);
            this.zonatxt.TabIndex = 5;
            this.zonatxt.Text = "label1";
            // 
            // Teams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.zonatxt);
            this.Controls.Add(this.gridTeam);
            this.Controls.Add(this.playersTeam);
            this.Controls.Add(this.deporteTeam);
            this.Controls.Add(this.nameTeam);
            this.Name = "Teams";
            this.Text = "Teams";
            this.Load += new System.EventHandler(this.Teams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameTeam;
        private System.Windows.Forms.Label deporteTeam;
        private System.Windows.Forms.Label playersTeam;
        private System.Windows.Forms.DataGridView gridTeam;
        private System.Windows.Forms.Label zonatxt;
    }
}