namespace TournamentTrackerUI
{
    partial class TournamentViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.lbl_TournamentName = new System.Windows.Forms.Label();
            this.lbl_TournamentNameSelected = new System.Windows.Forms.Label();
            this.cmb_TournamentName = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_Round = new System.Windows.Forms.Label();
            this.chk_UnplayedOnly = new System.Windows.Forms.CheckBox();
            this.lbx_Matchups = new System.Windows.Forms.ListBox();
            this.lbl_MatchUps = new System.Windows.Forms.Label();
            this.lbl_Team1 = new System.Windows.Forms.Label();
            this.lbl_Team2 = new System.Windows.Forms.Label();
            this.lbl_Score1 = new System.Windows.Forms.Label();
            this.lbl_Score2 = new System.Windows.Forms.Label();
            this.txt_Score1 = new System.Windows.Forms.TextBox();
            this.txt_Score2 = new System.Windows.Forms.TextBox();
            this.btn_Score = new System.Windows.Forms.Button();
            this.grp_Selection = new System.Windows.Forms.GroupBox();
            this.pnl_Selection = new System.Windows.Forms.Panel();
            this.grp_Details = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grp_ScoreEntry = new System.Windows.Forms.GroupBox();
            this.pnl_Scores = new System.Windows.Forms.Panel();
            this.lbl_Versus = new System.Windows.Forms.Label();
            this.grp_Selection.SuspendLayout();
            this.pnl_Selection.SuspendLayout();
            this.grp_Details.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grp_ScoreEntry.SuspendLayout();
            this.pnl_Scores.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_TournamentName
            // 
            this.lbl_TournamentName.AutoSize = true;
            this.lbl_TournamentName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TournamentName.Location = new System.Drawing.Point(10, 12);
            this.lbl_TournamentName.Name = "lbl_TournamentName";
            this.lbl_TournamentName.Size = new System.Drawing.Size(146, 21);
            this.lbl_TournamentName.TabIndex = 0;
            this.lbl_TournamentName.Text = "Tournament Name: ";
            // 
            // lbl_TournamentNameSelected
            // 
            this.lbl_TournamentNameSelected.AutoSize = true;
            this.lbl_TournamentNameSelected.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TournamentNameSelected.Location = new System.Drawing.Point(162, 12);
            this.lbl_TournamentNameSelected.Name = "lbl_TournamentNameSelected";
            this.lbl_TournamentNameSelected.Size = new System.Drawing.Size(121, 21);
            this.lbl_TournamentNameSelected.TabIndex = 1;
            this.lbl_TournamentNameSelected.Text = "<Please Select>";
            // 
            // cmb_TournamentName
            // 
            this.cmb_TournamentName.FormattingEnabled = true;
            this.cmb_TournamentName.Location = new System.Drawing.Point(13, 39);
            this.cmb_TournamentName.Name = "cmb_TournamentName";
            this.cmb_TournamentName.Size = new System.Drawing.Size(270, 21);
            this.cmb_TournamentName.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(270, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // lbl_Round
            // 
            this.lbl_Round.AutoSize = true;
            this.lbl_Round.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Round.Location = new System.Drawing.Point(10, 79);
            this.lbl_Round.Name = "lbl_Round";
            this.lbl_Round.Size = new System.Drawing.Size(59, 21);
            this.lbl_Round.TabIndex = 5;
            this.lbl_Round.Text = "Round:";
            // 
            // chk_UnplayedOnly
            // 
            this.chk_UnplayedOnly.AutoSize = true;
            this.chk_UnplayedOnly.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.chk_UnplayedOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_UnplayedOnly.Location = new System.Drawing.Point(188, 83);
            this.chk_UnplayedOnly.Name = "chk_UnplayedOnly";
            this.chk_UnplayedOnly.Size = new System.Drawing.Size(92, 17);
            this.chk_UnplayedOnly.TabIndex = 6;
            this.chk_UnplayedOnly.Text = "Unplayed Only";
            this.chk_UnplayedOnly.UseVisualStyleBackColor = true;
            // 
            // lbx_Matchups
            // 
            this.lbx_Matchups.FormattingEnabled = true;
            this.lbx_Matchups.Location = new System.Drawing.Point(14, 27);
            this.lbx_Matchups.Name = "lbx_Matchups";
            this.lbx_Matchups.Size = new System.Drawing.Size(269, 277);
            this.lbx_Matchups.TabIndex = 7;
            // 
            // lbl_MatchUps
            // 
            this.lbl_MatchUps.AutoSize = true;
            this.lbl_MatchUps.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MatchUps.Location = new System.Drawing.Point(10, 3);
            this.lbl_MatchUps.Name = "lbl_MatchUps";
            this.lbl_MatchUps.Size = new System.Drawing.Size(83, 21);
            this.lbl_MatchUps.TabIndex = 8;
            this.lbl_MatchUps.Text = "MatchUps:";
            // 
            // lbl_Team1
            // 
            this.lbl_Team1.AutoSize = true;
            this.lbl_Team1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Team1.Location = new System.Drawing.Point(12, 11);
            this.lbl_Team1.Name = "lbl_Team1";
            this.lbl_Team1.Size = new System.Drawing.Size(101, 21);
            this.lbl_Team1.TabIndex = 9;
            this.lbl_Team1.Text = "<Team One>";
            // 
            // lbl_Team2
            // 
            this.lbl_Team2.AutoSize = true;
            this.lbl_Team2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Team2.Location = new System.Drawing.Point(12, 158);
            this.lbl_Team2.Name = "lbl_Team2";
            this.lbl_Team2.Size = new System.Drawing.Size(100, 21);
            this.lbl_Team2.TabIndex = 10;
            this.lbl_Team2.Text = "<Team Two>";
            // 
            // lbl_Score1
            // 
            this.lbl_Score1.AutoSize = true;
            this.lbl_Score1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score1.Location = new System.Drawing.Point(27, 37);
            this.lbl_Score1.Name = "lbl_Score1";
            this.lbl_Score1.Size = new System.Drawing.Size(52, 21);
            this.lbl_Score1.TabIndex = 11;
            this.lbl_Score1.Text = "Score:";
            // 
            // lbl_Score2
            // 
            this.lbl_Score2.AutoSize = true;
            this.lbl_Score2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score2.Location = new System.Drawing.Point(27, 184);
            this.lbl_Score2.Name = "lbl_Score2";
            this.lbl_Score2.Size = new System.Drawing.Size(52, 21);
            this.lbl_Score2.TabIndex = 12;
            this.lbl_Score2.Text = "Score:";
            // 
            // txt_Score1
            // 
            this.txt_Score1.Location = new System.Drawing.Point(85, 37);
            this.txt_Score1.Name = "txt_Score1";
            this.txt_Score1.Size = new System.Drawing.Size(68, 22);
            this.txt_Score1.TabIndex = 13;
            // 
            // txt_Score2
            // 
            this.txt_Score2.Location = new System.Drawing.Point(85, 184);
            this.txt_Score2.Name = "txt_Score2";
            this.txt_Score2.Size = new System.Drawing.Size(68, 22);
            this.txt_Score2.TabIndex = 14;
            // 
            // btn_Score
            // 
            this.btn_Score.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_Score.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Score.Location = new System.Drawing.Point(214, 106);
            this.btn_Score.Name = "btn_Score";
            this.btn_Score.Size = new System.Drawing.Size(75, 23);
            this.btn_Score.TabIndex = 15;
            this.btn_Score.Text = "Score";
            this.btn_Score.UseVisualStyleBackColor = true;
            // 
            // grp_Selection
            // 
            this.grp_Selection.Controls.Add(this.pnl_Selection);
            this.grp_Selection.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_Selection.Location = new System.Drawing.Point(0, 0);
            this.grp_Selection.Name = "grp_Selection";
            this.grp_Selection.Size = new System.Drawing.Size(720, 154);
            this.grp_Selection.TabIndex = 16;
            this.grp_Selection.TabStop = false;
            this.grp_Selection.Text = "Tournament";
            // 
            // pnl_Selection
            // 
            this.pnl_Selection.Controls.Add(this.lbl_TournamentName);
            this.pnl_Selection.Controls.Add(this.lbl_TournamentNameSelected);
            this.pnl_Selection.Controls.Add(this.cmb_TournamentName);
            this.pnl_Selection.Controls.Add(this.comboBox1);
            this.pnl_Selection.Controls.Add(this.lbl_Round);
            this.pnl_Selection.Controls.Add(this.chk_UnplayedOnly);
            this.pnl_Selection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Selection.Location = new System.Drawing.Point(3, 16);
            this.pnl_Selection.Name = "pnl_Selection";
            this.pnl_Selection.Size = new System.Drawing.Size(714, 135);
            this.pnl_Selection.TabIndex = 0;
            // 
            // grp_Details
            // 
            this.grp_Details.Controls.Add(this.panel1);
            this.grp_Details.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grp_Details.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Details.Location = new System.Drawing.Point(0, 154);
            this.grp_Details.Name = "grp_Details";
            this.grp_Details.Size = new System.Drawing.Size(720, 351);
            this.grp_Details.TabIndex = 17;
            this.grp_Details.TabStop = false;
            this.grp_Details.Text = "Details";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grp_ScoreEntry);
            this.panel1.Controls.Add(this.lbx_Matchups);
            this.panel1.Controls.Add(this.lbl_MatchUps);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 330);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // grp_ScoreEntry
            // 
            this.grp_ScoreEntry.Controls.Add(this.pnl_Scores);
            this.grp_ScoreEntry.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ScoreEntry.Location = new System.Drawing.Point(299, 21);
            this.grp_ScoreEntry.Name = "grp_ScoreEntry";
            this.grp_ScoreEntry.Size = new System.Drawing.Size(393, 283);
            this.grp_ScoreEntry.TabIndex = 9;
            this.grp_ScoreEntry.TabStop = false;
            this.grp_ScoreEntry.Text = "Scores";
            // 
            // pnl_Scores
            // 
            this.pnl_Scores.Controls.Add(this.lbl_Versus);
            this.pnl_Scores.Controls.Add(this.lbl_Team1);
            this.pnl_Scores.Controls.Add(this.txt_Score1);
            this.pnl_Scores.Controls.Add(this.btn_Score);
            this.pnl_Scores.Controls.Add(this.lbl_Team2);
            this.pnl_Scores.Controls.Add(this.lbl_Score1);
            this.pnl_Scores.Controls.Add(this.lbl_Score2);
            this.pnl_Scores.Controls.Add(this.txt_Score2);
            this.pnl_Scores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Scores.Location = new System.Drawing.Point(3, 18);
            this.pnl_Scores.Name = "pnl_Scores";
            this.pnl_Scores.Size = new System.Drawing.Size(387, 262);
            this.pnl_Scores.TabIndex = 0;
            // 
            // lbl_Versus
            // 
            this.lbl_Versus.AutoSize = true;
            this.lbl_Versus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Versus.Location = new System.Drawing.Point(32, 102);
            this.lbl_Versus.Name = "lbl_Versus";
            this.lbl_Versus.Size = new System.Drawing.Size(47, 25);
            this.lbl_Versus.TabIndex = 10;
            this.lbl_Versus.Text = "-Vs-";
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 505);
            this.Controls.Add(this.grp_Details);
            this.Controls.Add(this.grp_Selection);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.grp_Selection.ResumeLayout(false);
            this.pnl_Selection.ResumeLayout(false);
            this.pnl_Selection.PerformLayout();
            this.grp_Details.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grp_ScoreEntry.ResumeLayout(false);
            this.pnl_Scores.ResumeLayout(false);
            this.pnl_Scores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_TournamentName;
        private System.Windows.Forms.Label lbl_TournamentNameSelected;
        private System.Windows.Forms.ComboBox cmb_TournamentName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_Round;
        private System.Windows.Forms.CheckBox chk_UnplayedOnly;
        private System.Windows.Forms.ListBox lbx_Matchups;
        private System.Windows.Forms.Label lbl_MatchUps;
        private System.Windows.Forms.Label lbl_Team1;
        private System.Windows.Forms.Label lbl_Team2;
        private System.Windows.Forms.Label lbl_Score1;
        private System.Windows.Forms.Label lbl_Score2;
        private System.Windows.Forms.TextBox txt_Score1;
        private System.Windows.Forms.TextBox txt_Score2;
        private System.Windows.Forms.Button btn_Score;
        private System.Windows.Forms.GroupBox grp_Selection;
        private System.Windows.Forms.Panel pnl_Selection;
        private System.Windows.Forms.GroupBox grp_Details;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grp_ScoreEntry;
        private System.Windows.Forms.Panel pnl_Scores;
        private System.Windows.Forms.Label lbl_Versus;
    }
}