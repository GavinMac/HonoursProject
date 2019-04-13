namespace Prototype1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnEnableMic = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.RichTextBox();
            this.btnDisableMic = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.savePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ranksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RankNameLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UserRankListView = new System.Windows.Forms.ListView();
            this.deviceComboBox = new System.Windows.Forms.ComboBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.volumeMeter = new NAudio.Gui.VolumeMeter();
            this.PlayerPicBox = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnableMic
            // 
            this.btnEnableMic.Location = new System.Drawing.Point(222, 42);
            this.btnEnableMic.Name = "btnEnableMic";
            this.btnEnableMic.Size = new System.Drawing.Size(121, 21);
            this.btnEnableMic.TabIndex = 1;
            this.btnEnableMic.Text = "Enable Microphone";
            this.btnEnableMic.UseVisualStyleBackColor = true;
            this.btnEnableMic.Click += new System.EventHandler(this.btnEnableMic_Click);
            // 
            // logTextBox
            // 
            this.logTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logTextBox.BackColor = System.Drawing.Color.Gray;
            this.logTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logTextBox.ForeColor = System.Drawing.Color.White;
            this.logTextBox.Location = new System.Drawing.Point(222, 164);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(830, 505);
            this.logTextBox.TabIndex = 2;
            this.logTextBox.Text = "";
            // 
            // btnDisableMic
            // 
            this.btnDisableMic.Enabled = false;
            this.btnDisableMic.Location = new System.Drawing.Point(349, 42);
            this.btnDisableMic.Name = "btnDisableMic";
            this.btnDisableMic.Size = new System.Drawing.Size(121, 21);
            this.btnDisableMic.TabIndex = 3;
            this.btnDisableMic.Text = "Disable Microphone";
            this.btnDisableMic.UseVisualStyleBackColor = true;
            this.btnDisableMic.Click += new System.EventHandler(this.btnDisableMic_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1064, 24);
            this.menuStrip.TabIndex = 10;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPlayerToolStripMenuItem,
            this.openPlayerToolStripMenuItem,
            this.toolStripSeparator1,
            this.savePlayerToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newPlayerToolStripMenuItem
            // 
            this.newPlayerToolStripMenuItem.Name = "newPlayerToolStripMenuItem";
            this.newPlayerToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.newPlayerToolStripMenuItem.Text = "New Player";
            this.newPlayerToolStripMenuItem.Click += new System.EventHandler(this.newPlayerToolStripMenuItem_Click);
            // 
            // openPlayerToolStripMenuItem
            // 
            this.openPlayerToolStripMenuItem.Name = "openPlayerToolStripMenuItem";
            this.openPlayerToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.openPlayerToolStripMenuItem.Text = "Open Player";
            this.openPlayerToolStripMenuItem.Click += new System.EventHandler(this.openPlayerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(135, 6);
            // 
            // savePlayerToolStripMenuItem
            // 
            this.savePlayerToolStripMenuItem.Name = "savePlayerToolStripMenuItem";
            this.savePlayerToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.savePlayerToolStripMenuItem.Text = "Save Player";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(135, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playersToolStripMenuItem,
            this.ranksToolStripMenuItem});
            this.viewToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // playersToolStripMenuItem
            // 
            this.playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            this.playersToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.playersToolStripMenuItem.Text = "Players";
            this.playersToolStripMenuItem.Click += new System.EventHandler(this.playersToolStripMenuItem_Click);
            // 
            // ranksToolStripMenuItem
            // 
            this.ranksToolStripMenuItem.Name = "ranksToolStripMenuItem";
            this.ranksToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.ranksToolStripMenuItem.Text = "Ranks";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.RankNameLabel);
            this.panel1.Controls.Add(this.UsernameLabel);
            this.panel1.Controls.Add(this.UserRankListView);
            this.panel1.Controls.Add(this.PlayerPicBox);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 626);
            this.panel1.TabIndex = 11;
            // 
            // RankNameLabel
            // 
            this.RankNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RankNameLabel.ForeColor = System.Drawing.Color.White;
            this.RankNameLabel.Location = new System.Drawing.Point(5, 150);
            this.RankNameLabel.Margin = new System.Windows.Forms.Padding(5);
            this.RankNameLabel.Name = "RankNameLabel";
            this.RankNameLabel.Size = new System.Drawing.Size(188, 24);
            this.RankNameLabel.TabIndex = 13;
            this.RankNameLabel.Text = "Rank";
            this.RankNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.White;
            this.UsernameLabel.Location = new System.Drawing.Point(5, 120);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(5);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(188, 23);
            this.UsernameLabel.TabIndex = 12;
            this.UsernameLabel.Text = "Username";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserRankListView
            // 
            this.UserRankListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserRankListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserRankListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserRankListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserRankListView.ForeColor = System.Drawing.Color.White;
            this.UserRankListView.Location = new System.Drawing.Point(5, 184);
            this.UserRankListView.Margin = new System.Windows.Forms.Padding(5);
            this.UserRankListView.Name = "UserRankListView";
            this.UserRankListView.Size = new System.Drawing.Size(188, 435);
            this.UserRankListView.TabIndex = 11;
            this.UserRankListView.UseCompatibleStateImageBehavior = false;
            this.UserRankListView.View = System.Windows.Forms.View.List;
            // 
            // deviceComboBox
            // 
            this.deviceComboBox.FormattingEnabled = true;
            this.deviceComboBox.Location = new System.Drawing.Point(476, 42);
            this.deviceComboBox.Name = "deviceComboBox";
            this.deviceComboBox.Size = new System.Drawing.Size(216, 21);
            this.deviceComboBox.TabIndex = 14;
            // 
            // timer
            // 
            this.timer.Interval = 5;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // volumeMeter
            // 
            this.volumeMeter.Amplitude = 0F;
            this.volumeMeter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.volumeMeter.Location = new System.Drawing.Point(222, 69);
            this.volumeMeter.MaxDb = 50F;
            this.volumeMeter.MinDb = 0F;
            this.volumeMeter.Name = "volumeMeter";
            this.volumeMeter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.volumeMeter.Size = new System.Drawing.Size(470, 33);
            this.volumeMeter.TabIndex = 15;
            this.volumeMeter.Text = "volumeMeter";
            // 
            // PlayerPicBox
            // 
            this.PlayerPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerPicBox.Image = ((System.Drawing.Image)(resources.GetObject("PlayerPicBox.Image")));
            this.PlayerPicBox.Location = new System.Drawing.Point(47, 12);
            this.PlayerPicBox.Name = "PlayerPicBox";
            this.PlayerPicBox.Size = new System.Drawing.Size(100, 100);
            this.PlayerPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerPicBox.TabIndex = 10;
            this.PlayerPicBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.volumeMeter);
            this.Controls.Add(this.deviceComboBox);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDisableMic);
            this.Controls.Add(this.btnEnableMic);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Honors Prototype 1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnEnableMic;
        private System.Windows.Forms.RichTextBox logTextBox;
        private System.Windows.Forms.Button btnDisableMic;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ranksToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PlayerPicBox;
        private System.Windows.Forms.ToolStripMenuItem openPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.ListView UserRankListView;
        private System.Windows.Forms.Label RankNameLabel;
        private System.Windows.Forms.ComboBox deviceComboBox;
        private System.Windows.Forms.Timer timer;
        private NAudio.Gui.VolumeMeter volumeMeter;
    }
}

