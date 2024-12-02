﻿namespace FootballTradingCards
{
    partial class Form1
    {
        //private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            lstPlayers = new ListBox();
            picPlayerPhoto = new PictureBox();
            pnlPlayerDetails = new Panel();
            btnRemovePlayer = new Button();
            lblAge = new Label();
            lblNationality = new Label();
            btnBack = new Button();
            lblAssists = new Label();
            lblGoals = new Label();
            lblMatchesPlayed = new Label();
            lblPosition = new Label();
            lblTeam = new Label();
            lblName = new Label();
            btnAddPlayer = new Button();
            ((System.ComponentModel.ISupportInitialize)picPlayerPhoto).BeginInit();
            pnlPlayerDetails.SuspendLayout();
            SuspendLayout();
            // 
            // lstPlayers
            // 
            lstPlayers.FormattingEnabled = true;
            lstPlayers.ItemHeight = 15;
            lstPlayers.Location = new Point(12, 12);
            lstPlayers.Name = "lstPlayers";
            lstPlayers.Size = new Size(275, 304);
            lstPlayers.TabIndex = 0;
            lstPlayers.SelectedIndexChanged += lstPlayers_SelectedIndexChanged;
            // 
            // picPlayerPhoto
            // 
            picPlayerPhoto.Location = new Point(206, 81);
            picPlayerPhoto.Name = "picPlayerPhoto";
            picPlayerPhoto.Size = new Size(150, 111);
            picPlayerPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlayerPhoto.TabIndex = 1;
            picPlayerPhoto.TabStop = false;
            // 
            // pnlPlayerDetails
            // 
            pnlPlayerDetails.Controls.Add(btnRemovePlayer);
            pnlPlayerDetails.Controls.Add(lblAge);
            pnlPlayerDetails.Controls.Add(lblNationality);
            pnlPlayerDetails.Controls.Add(btnBack);
            pnlPlayerDetails.Controls.Add(lblAssists);
            pnlPlayerDetails.Controls.Add(picPlayerPhoto);
            pnlPlayerDetails.Controls.Add(lblGoals);
            pnlPlayerDetails.Controls.Add(lblMatchesPlayed);
            pnlPlayerDetails.Controls.Add(lblPosition);
            pnlPlayerDetails.Controls.Add(lblTeam);
            pnlPlayerDetails.Controls.Add(lblName);
            pnlPlayerDetails.Location = new Point(12, 12);
            pnlPlayerDetails.Name = "pnlPlayerDetails";
            pnlPlayerDetails.Size = new Size(376, 304);
            pnlPlayerDetails.TabIndex = 8;
            pnlPlayerDetails.Visible = false;
            // 
            // btnRemovePlayer
            // 
            btnRemovePlayer.Location = new Point(281, 239);
            btnRemovePlayer.Name = "btnRemovePlayer";
            btnRemovePlayer.Size = new Size(75, 23);
            btnRemovePlayer.TabIndex = 10;
            btnRemovePlayer.Text = "Remove Player";
            btnRemovePlayer.UseVisualStyleBackColor = true;
            btnRemovePlayer.Click += btnRemovePlayer_Click;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(12, 247);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(28, 15);
            lblAge.TabIndex = 8;
            lblAge.Text = "Age";
            // 
            // lblNationality
            // 
            lblNationality.AutoSize = true;
            lblNationality.Location = new Point(12, 214);
            lblNationality.Name = "lblNationality";
            lblNationality.Size = new Size(65, 15);
            lblNationality.TabIndex = 7;
            lblNationality.Text = "Nationality";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(281, 15);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.Click += btnBack_Click;
            // 
            // lblAssists
            // 
            lblAssists.AutoSize = true;
            lblAssists.Location = new Point(12, 177);
            lblAssists.Name = "lblAssists";
            lblAssists.Size = new Size(42, 15);
            lblAssists.TabIndex = 5;
            lblAssists.Text = "Assists";
            // 
            // lblGoals
            // 
            lblGoals.AutoSize = true;
            lblGoals.Location = new Point(12, 144);
            lblGoals.Name = "lblGoals";
            lblGoals.Size = new Size(36, 15);
            lblGoals.TabIndex = 4;
            lblGoals.Text = "Goals";
            // 
            // lblMatchesPlayed
            // 
            lblMatchesPlayed.AutoSize = true;
            lblMatchesPlayed.Location = new Point(12, 112);
            lblMatchesPlayed.Name = "lblMatchesPlayed";
            lblMatchesPlayed.Size = new Size(90, 15);
            lblMatchesPlayed.TabIndex = 3;
            lblMatchesPlayed.Text = "Matches Played";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(12, 81);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(50, 15);
            lblPosition.TabIndex = 2;
            lblPosition.Text = "Position";
            // 
            // lblTeam
            // 
            lblTeam.AutoSize = true;
            lblTeam.Location = new Point(12, 50);
            lblTeam.Name = "lblTeam";
            lblTeam.Size = new Size(36, 15);
            lblTeam.TabIndex = 1;
            lblTeam.Text = "Team";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 19);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // btnAddPlayer
            // 
            btnAddPlayer.Location = new Point(313, 12);
            btnAddPlayer.Name = "btnAddPlayer";
            btnAddPlayer.Size = new Size(75, 33);
            btnAddPlayer.TabIndex = 0;
            btnAddPlayer.Text = "AddPlayer";
            btnAddPlayer.Click += btnAddPlayer_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(400, 329);
            Controls.Add(btnAddPlayer);
            Controls.Add(pnlPlayerDetails);
            Controls.Add(lstPlayers);
            Name = "Form1";
            Text = "Football Trading Cards";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picPlayerPhoto).EndInit();
            pnlPlayerDetails.ResumeLayout(false);
            pnlPlayerDetails.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox lstPlayers;
        private System.Windows.Forms.PictureBox picPlayerPhoto;
        private Panel pnlPlayerDetails;
        private Label lblAssists;
        private Label lblGoals;
        private Label lblMatchesPlayed;
        private Label lblPosition;
        private Label lblTeam;
        private Label lblName;
        private Button btnBack;
        private Label lblAge;
        private Label lblNationality;
        private Button btnAddPlayer;
        private Button btnRemovePlayer;
    }
}
