namespace Prototype1
{
    partial class SortPlayersForm
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
            this.btnSort = new System.Windows.Forms.Button();
            this.AllPlayersListBox = new System.Windows.Forms.ListBox();
            this.lstBoxChaoticEvil = new System.Windows.Forms.ListBox();
            this.lstBoxChaoticNeutral = new System.Windows.Forms.ListBox();
            this.lstBoxNeutral = new System.Windows.Forms.ListBox();
            this.lstBoxLawfulNeutral = new System.Windows.Forms.ListBox();
            this.lstBoxLawfulGood = new System.Windows.Forms.ListBox();
            this.lblNeutral = new System.Windows.Forms.Label();
            this.lblLawfulNeutral = new System.Windows.Forms.Label();
            this.lblLawfulGood = new System.Windows.Forms.Label();
            this.lblChaoticNeutral = new System.Windows.Forms.Label();
            this.lblChaoticEvil = new System.Windows.Forms.Label();
            this.btnOpenPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSort
            // 
            this.btnSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSort.Location = new System.Drawing.Point(12, 133);
            this.btnSort.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(780, 34);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Sort Players Into Ranks";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // AllPlayersListBox
            // 
            this.AllPlayersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllPlayersListBox.BackColor = System.Drawing.Color.DimGray;
            this.AllPlayersListBox.ForeColor = System.Drawing.Color.White;
            this.AllPlayersListBox.FormattingEnabled = true;
            this.AllPlayersListBox.Location = new System.Drawing.Point(12, 12);
            this.AllPlayersListBox.Name = "AllPlayersListBox";
            this.AllPlayersListBox.Size = new System.Drawing.Size(784, 108);
            this.AllPlayersListBox.TabIndex = 3;
            this.AllPlayersListBox.SelectedIndexChanged += new System.EventHandler(this.AllPlayersListBox_SelectedIndexChanged);
            // 
            // lstBoxChaoticEvil
            // 
            this.lstBoxChaoticEvil.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lstBoxChaoticEvil.BackColor = System.Drawing.Color.DimGray;
            this.lstBoxChaoticEvil.DisplayMember = "Username";
            this.lstBoxChaoticEvil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxChaoticEvil.ForeColor = System.Drawing.Color.White;
            this.lstBoxChaoticEvil.FormattingEnabled = true;
            this.lstBoxChaoticEvil.ItemHeight = 16;
            this.lstBoxChaoticEvil.Location = new System.Drawing.Point(15, 277);
            this.lstBoxChaoticEvil.Name = "lstBoxChaoticEvil";
            this.lstBoxChaoticEvil.Size = new System.Drawing.Size(150, 212);
            this.lstBoxChaoticEvil.TabIndex = 4;
            this.lstBoxChaoticEvil.SelectedIndexChanged += new System.EventHandler(this.lstBoxChaoticEvil_SelectedIndexChanged);
            // 
            // lstBoxChaoticNeutral
            // 
            this.lstBoxChaoticNeutral.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lstBoxChaoticNeutral.BackColor = System.Drawing.Color.DimGray;
            this.lstBoxChaoticNeutral.DisplayMember = "Username";
            this.lstBoxChaoticNeutral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxChaoticNeutral.ForeColor = System.Drawing.Color.White;
            this.lstBoxChaoticNeutral.FormattingEnabled = true;
            this.lstBoxChaoticNeutral.ItemHeight = 16;
            this.lstBoxChaoticNeutral.Location = new System.Drawing.Point(171, 277);
            this.lstBoxChaoticNeutral.Name = "lstBoxChaoticNeutral";
            this.lstBoxChaoticNeutral.Size = new System.Drawing.Size(150, 212);
            this.lstBoxChaoticNeutral.TabIndex = 5;
            this.lstBoxChaoticNeutral.SelectedIndexChanged += new System.EventHandler(this.lstBoxChaoticNeutral_SelectedIndexChanged);
            // 
            // lstBoxNeutral
            // 
            this.lstBoxNeutral.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lstBoxNeutral.BackColor = System.Drawing.Color.DimGray;
            this.lstBoxNeutral.DisplayMember = "Username";
            this.lstBoxNeutral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxNeutral.ForeColor = System.Drawing.Color.White;
            this.lstBoxNeutral.FormattingEnabled = true;
            this.lstBoxNeutral.ItemHeight = 16;
            this.lstBoxNeutral.Location = new System.Drawing.Point(327, 277);
            this.lstBoxNeutral.Name = "lstBoxNeutral";
            this.lstBoxNeutral.Size = new System.Drawing.Size(150, 212);
            this.lstBoxNeutral.TabIndex = 6;
            this.lstBoxNeutral.SelectedIndexChanged += new System.EventHandler(this.lstBoxNeutral_SelectedIndexChanged);
            // 
            // lstBoxLawfulNeutral
            // 
            this.lstBoxLawfulNeutral.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lstBoxLawfulNeutral.BackColor = System.Drawing.Color.DimGray;
            this.lstBoxLawfulNeutral.DisplayMember = "Username";
            this.lstBoxLawfulNeutral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxLawfulNeutral.ForeColor = System.Drawing.Color.White;
            this.lstBoxLawfulNeutral.FormattingEnabled = true;
            this.lstBoxLawfulNeutral.ItemHeight = 16;
            this.lstBoxLawfulNeutral.Location = new System.Drawing.Point(483, 277);
            this.lstBoxLawfulNeutral.Name = "lstBoxLawfulNeutral";
            this.lstBoxLawfulNeutral.Size = new System.Drawing.Size(150, 212);
            this.lstBoxLawfulNeutral.TabIndex = 7;
            this.lstBoxLawfulNeutral.SelectedIndexChanged += new System.EventHandler(this.lstBoxLawfulNeutral_SelectedIndexChanged);
            // 
            // lstBoxLawfulGood
            // 
            this.lstBoxLawfulGood.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lstBoxLawfulGood.BackColor = System.Drawing.Color.DimGray;
            this.lstBoxLawfulGood.DisplayMember = "Username";
            this.lstBoxLawfulGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxLawfulGood.ForeColor = System.Drawing.Color.White;
            this.lstBoxLawfulGood.FormattingEnabled = true;
            this.lstBoxLawfulGood.ItemHeight = 16;
            this.lstBoxLawfulGood.Location = new System.Drawing.Point(639, 277);
            this.lstBoxLawfulGood.Name = "lstBoxLawfulGood";
            this.lstBoxLawfulGood.Size = new System.Drawing.Size(150, 212);
            this.lstBoxLawfulGood.TabIndex = 8;
            this.lstBoxLawfulGood.SelectedIndexChanged += new System.EventHandler(this.lstBoxLawfulGood_SelectedIndexChanged);
            // 
            // lblNeutral
            // 
            this.lblNeutral.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNeutral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeutral.ForeColor = System.Drawing.Color.White;
            this.lblNeutral.Location = new System.Drawing.Point(327, 251);
            this.lblNeutral.Name = "lblNeutral";
            this.lblNeutral.Size = new System.Drawing.Size(150, 23);
            this.lblNeutral.TabIndex = 9;
            this.lblNeutral.Text = "Neutral";
            this.lblNeutral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLawfulNeutral
            // 
            this.lblLawfulNeutral.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblLawfulNeutral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLawfulNeutral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lblLawfulNeutral.Location = new System.Drawing.Point(483, 251);
            this.lblLawfulNeutral.Name = "lblLawfulNeutral";
            this.lblLawfulNeutral.Size = new System.Drawing.Size(150, 23);
            this.lblLawfulNeutral.TabIndex = 10;
            this.lblLawfulNeutral.Text = "Lawful Neutral";
            this.lblLawfulNeutral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLawfulGood
            // 
            this.lblLawfulGood.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblLawfulGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLawfulGood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.lblLawfulGood.Location = new System.Drawing.Point(639, 251);
            this.lblLawfulGood.Name = "lblLawfulGood";
            this.lblLawfulGood.Size = new System.Drawing.Size(150, 23);
            this.lblLawfulGood.TabIndex = 11;
            this.lblLawfulGood.Text = "Lawful Good";
            this.lblLawfulGood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChaoticNeutral
            // 
            this.lblChaoticNeutral.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblChaoticNeutral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChaoticNeutral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblChaoticNeutral.Location = new System.Drawing.Point(171, 251);
            this.lblChaoticNeutral.Name = "lblChaoticNeutral";
            this.lblChaoticNeutral.Size = new System.Drawing.Size(150, 23);
            this.lblChaoticNeutral.TabIndex = 12;
            this.lblChaoticNeutral.Text = "Chaotic Neutral";
            this.lblChaoticNeutral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChaoticEvil
            // 
            this.lblChaoticEvil.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblChaoticEvil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChaoticEvil.ForeColor = System.Drawing.Color.Red;
            this.lblChaoticEvil.Location = new System.Drawing.Point(15, 251);
            this.lblChaoticEvil.Name = "lblChaoticEvil";
            this.lblChaoticEvil.Size = new System.Drawing.Size(150, 23);
            this.lblChaoticEvil.TabIndex = 13;
            this.lblChaoticEvil.Text = "Chaotic Evil";
            this.lblChaoticEvil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpenPlayer
            // 
            this.btnOpenPlayer.Location = new System.Drawing.Point(327, 202);
            this.btnOpenPlayer.Name = "btnOpenPlayer";
            this.btnOpenPlayer.Size = new System.Drawing.Size(150, 34);
            this.btnOpenPlayer.TabIndex = 14;
            this.btnOpenPlayer.Text = "Open Selected Player";
            this.btnOpenPlayer.UseVisualStyleBackColor = true;
            this.btnOpenPlayer.Click += new System.EventHandler(this.btnOpenPlayer_Click);
            // 
            // SortPlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(804, 501);
            this.Controls.Add(this.btnOpenPlayer);
            this.Controls.Add(this.lblChaoticEvil);
            this.Controls.Add(this.lblChaoticNeutral);
            this.Controls.Add(this.lblLawfulGood);
            this.Controls.Add(this.lblLawfulNeutral);
            this.Controls.Add(this.lblNeutral);
            this.Controls.Add(this.lstBoxLawfulGood);
            this.Controls.Add(this.lstBoxLawfulNeutral);
            this.Controls.Add(this.lstBoxNeutral);
            this.Controls.Add(this.lstBoxChaoticNeutral);
            this.Controls.Add(this.lstBoxChaoticEvil);
            this.Controls.Add(this.AllPlayersListBox);
            this.Controls.Add(this.btnSort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SortPlayersForm";
            this.Text = "Player Lobby";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ListBox AllPlayersListBox;
        private System.Windows.Forms.ListBox lstBoxChaoticEvil;
        private System.Windows.Forms.ListBox lstBoxChaoticNeutral;
        private System.Windows.Forms.ListBox lstBoxNeutral;
        private System.Windows.Forms.ListBox lstBoxLawfulNeutral;
        private System.Windows.Forms.ListBox lstBoxLawfulGood;
        private System.Windows.Forms.Label lblNeutral;
        private System.Windows.Forms.Label lblLawfulNeutral;
        private System.Windows.Forms.Label lblLawfulGood;
        private System.Windows.Forms.Label lblChaoticNeutral;
        private System.Windows.Forms.Label lblChaoticEvil;
        private System.Windows.Forms.Button btnOpenPlayer;
    }
}