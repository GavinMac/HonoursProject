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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.lstViewPlayerRankDetails = new System.Windows.Forms.ListView();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.btnResetStats = new System.Windows.Forms.Button();
            this.txtBoxEditName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
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
            this.btnRandomize.Location = new System.Drawing.Point(12, 414);
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
            // profilePictureBox
            // 
            this.profilePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.profilePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilePictureBox.Image = global::Prototype1.Properties.Resources.profileIcon;
            this.profilePictureBox.Location = new System.Drawing.Point(97, 46);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(150, 150);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePictureBox.TabIndex = 5;
            this.profilePictureBox.TabStop = false;
            // 
            // btnResetStats
            // 
            this.btnResetStats.Location = new System.Drawing.Point(232, 414);
            this.btnResetStats.Name = "btnResetStats";
            this.btnResetStats.Size = new System.Drawing.Size(100, 35);
            this.btnResetStats.TabIndex = 6;
            this.btnResetStats.Text = "Reset Stats";
            this.btnResetStats.UseVisualStyleBackColor = true;
            this.btnResetStats.Click += new System.EventHandler(this.btnResetStats_Click);
            // 
            // txtBoxEditName
            // 
            this.txtBoxEditName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxEditName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxEditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEditName.ForeColor = System.Drawing.Color.White;
            this.txtBoxEditName.Location = new System.Drawing.Point(97, 5);
            this.txtBoxEditName.Name = "txtBoxEditName";
            this.txtBoxEditName.Size = new System.Drawing.Size(150, 35);
            this.txtBoxEditName.TabIndex = 7;
            this.txtBoxEditName.Text = "Username";
            this.txtBoxEditName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(344, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBoxEditName);
            this.Controls.Add(this.btnResetStats);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.lstViewPlayerRankDetails);
            this.Controls.Add(this.btnRandomize);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.lblUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewPlayerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Player";
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.ListView lstViewPlayerRankDetails;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Button btnResetStats;
        private System.Windows.Forms.TextBox txtBoxEditName;
        private System.Windows.Forms.Button button1;
    }
}