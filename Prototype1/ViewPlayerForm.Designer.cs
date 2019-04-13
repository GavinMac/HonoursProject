namespace Prototype1
{
    partial class ViewPlayerForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.lstViewPlayerRankDetails = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Prototype1.Properties.Resources.profileIcon;
            this.pictureBox1.Location = new System.Drawing.Point(97, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(17, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(315, 34);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Name";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRank
            // 
            this.lblRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.ForeColor = System.Drawing.Color.White;
            this.lblRank.Location = new System.Drawing.Point(12, 190);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(320, 45);
            this.lblRank.TabIndex = 2;
            this.lblRank.Text = "Rank";
            this.lblRank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRandomize
            // 
            this.btnRandomize.Location = new System.Drawing.Point(122, 414);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(100, 35);
            this.btnRandomize.TabIndex = 3;
            this.btnRandomize.Text = "Randomize Score";
            this.btnRandomize.UseVisualStyleBackColor = true;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // lstViewPlayerRankDetails
            // 
            this.lstViewPlayerRankDetails.BackColor = System.Drawing.Color.DimGray;
            this.lstViewPlayerRankDetails.ForeColor = System.Drawing.Color.White;
            this.lstViewPlayerRankDetails.Location = new System.Drawing.Point(12, 238);
            this.lstViewPlayerRankDetails.Name = "lstViewPlayerRankDetails";
            this.lstViewPlayerRankDetails.Size = new System.Drawing.Size(320, 156);
            this.lstViewPlayerRankDetails.TabIndex = 4;
            this.lstViewPlayerRankDetails.UseCompatibleStateImageBehavior = false;
            this.lstViewPlayerRankDetails.View = System.Windows.Forms.View.List;
            // 
            // ViewPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(344, 461);
            this.Controls.Add(this.lstViewPlayerRankDetails);
            this.Controls.Add(this.btnRandomize);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewPlayerForm";
            this.Text = "View Player";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.ListView lstViewPlayerRankDetails;
    }
}