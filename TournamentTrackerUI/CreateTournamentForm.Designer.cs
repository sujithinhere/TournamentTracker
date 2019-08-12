namespace TournamentTrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.lbx_Teams = new System.Windows.Forms.ListBox();
            this.lbl_TournamentName = new System.Windows.Forms.Label();
            this.cmb_TournamentTeams = new System.Windows.Forms.ComboBox();
            this.grp_Details = new System.Windows.Forms.GroupBox();
            this.txt_EntryFee = new System.Windows.Forms.TextBox();
            this.lbl_EntryFee = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_SelectTeam = new System.Windows.Forms.Label();
            this.lnkLbl_CreateNew = new System.Windows.Forms.LinkLabel();
            this.lbx_Prizes = new System.Windows.Forms.ListBox();
            this.lbl_SelectedTeams = new System.Windows.Forms.Label();
            this.grp_Teams = new System.Windows.Forms.GroupBox();
            this.btn_DeleteTeam = new System.Windows.Forms.Button();
            this.grp_Prizes = new System.Windows.Forms.GroupBox();
            this.lbl_Or = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lbl_PrizePercentage = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbl_PlaceName = new System.Windows.Forms.Label();
            this.txt_PrizeAmount = new System.Windows.Forms.TextBox();
            this.lbl_PrizeAmount = new System.Windows.Forms.Label();
            this.txt_PlaceNumber = new System.Windows.Forms.TextBox();
            this.lbl_PlaceNumber = new System.Windows.Forms.Label();
            this.btn_RemovePrizes = new System.Windows.Forms.Button();
            this.lbl_Prizes = new System.Windows.Forms.Label();
            this.pnl_Buttons = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.bnt_CreatePrize = new System.Windows.Forms.Button();
            this.grp_Details.SuspendLayout();
            this.grp_Teams.SuspendLayout();
            this.grp_Prizes.SuspendLayout();
            this.pnl_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbx_Teams
            // 
            this.lbx_Teams.FormattingEnabled = true;
            this.lbx_Teams.Location = new System.Drawing.Point(345, 48);
            this.lbx_Teams.Name = "lbx_Teams";
            this.lbx_Teams.Size = new System.Drawing.Size(318, 212);
            this.lbx_Teams.TabIndex = 10;
            // 
            // lbl_TournamentName
            // 
            this.lbl_TournamentName.AutoSize = true;
            this.lbl_TournamentName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TournamentName.Location = new System.Drawing.Point(13, 18);
            this.lbl_TournamentName.Name = "lbl_TournamentName";
            this.lbl_TournamentName.Size = new System.Drawing.Size(146, 21);
            this.lbl_TournamentName.TabIndex = 8;
            this.lbl_TournamentName.Text = "Tournament Name: ";
            // 
            // cmb_TournamentTeams
            // 
            this.cmb_TournamentTeams.FormattingEnabled = true;
            this.cmb_TournamentTeams.Location = new System.Drawing.Point(18, 48);
            this.cmb_TournamentTeams.Name = "cmb_TournamentTeams";
            this.cmb_TournamentTeams.Size = new System.Drawing.Size(298, 21);
            this.cmb_TournamentTeams.TabIndex = 9;
            // 
            // grp_Details
            // 
            this.grp_Details.Controls.Add(this.txt_EntryFee);
            this.grp_Details.Controls.Add(this.lbl_EntryFee);
            this.grp_Details.Controls.Add(this.textBox1);
            this.grp_Details.Controls.Add(this.lbl_TournamentName);
            this.grp_Details.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_Details.Location = new System.Drawing.Point(0, 0);
            this.grp_Details.Name = "grp_Details";
            this.grp_Details.Size = new System.Drawing.Size(881, 100);
            this.grp_Details.TabIndex = 11;
            this.grp_Details.TabStop = false;
            this.grp_Details.Text = "Details";
            // 
            // txt_EntryFee
            // 
            this.txt_EntryFee.Location = new System.Drawing.Point(162, 54);
            this.txt_EntryFee.Name = "txt_EntryFee";
            this.txt_EntryFee.Size = new System.Drawing.Size(115, 22);
            this.txt_EntryFee.TabIndex = 11;
            // 
            // lbl_EntryFee
            // 
            this.lbl_EntryFee.AutoSize = true;
            this.lbl_EntryFee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EntryFee.Location = new System.Drawing.Point(13, 54);
            this.lbl_EntryFee.Name = "lbl_EntryFee";
            this.lbl_EntryFee.Size = new System.Drawing.Size(81, 21);
            this.lbl_EntryFee.TabIndex = 10;
            this.lbl_EntryFee.Text = "Entry Fee: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(444, 22);
            this.textBox1.TabIndex = 9;
            // 
            // lbl_SelectTeam
            // 
            this.lbl_SelectTeam.AutoSize = true;
            this.lbl_SelectTeam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectTeam.Location = new System.Drawing.Point(13, 18);
            this.lbl_SelectTeam.Name = "lbl_SelectTeam";
            this.lbl_SelectTeam.Size = new System.Drawing.Size(200, 21);
            this.lbl_SelectTeam.TabIndex = 11;
            this.lbl_SelectTeam.Text = "Select Tournament Entrees: ";
            // 
            // lnkLbl_CreateNew
            // 
            this.lnkLbl_CreateNew.AutoSize = true;
            this.lnkLbl_CreateNew.Location = new System.Drawing.Point(250, 24);
            this.lnkLbl_CreateNew.Name = "lnkLbl_CreateNew";
            this.lnkLbl_CreateNew.Size = new System.Drawing.Size(66, 13);
            this.lnkLbl_CreateNew.TabIndex = 12;
            this.lnkLbl_CreateNew.TabStop = true;
            this.lnkLbl_CreateNew.Text = "Create New";
            // 
            // lbx_Prizes
            // 
            this.lbx_Prizes.FormattingEnabled = true;
            this.lbx_Prizes.Location = new System.Drawing.Point(345, 58);
            this.lbx_Prizes.Name = "lbx_Prizes";
            this.lbx_Prizes.Size = new System.Drawing.Size(318, 186);
            this.lbx_Prizes.TabIndex = 13;
            this.lbx_Prizes.SelectedIndexChanged += new System.EventHandler(this.lbx_Prizes_SelectedIndexChanged);
            // 
            // lbl_SelectedTeams
            // 
            this.lbl_SelectedTeams.AutoSize = true;
            this.lbl_SelectedTeams.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectedTeams.Location = new System.Drawing.Point(341, 18);
            this.lbl_SelectedTeams.Name = "lbl_SelectedTeams";
            this.lbl_SelectedTeams.Size = new System.Drawing.Size(130, 21);
            this.lbl_SelectedTeams.TabIndex = 14;
            this.lbl_SelectedTeams.Text = "Selected Entrees: ";
            // 
            // grp_Teams
            // 
            this.grp_Teams.Controls.Add(this.btn_DeleteTeam);
            this.grp_Teams.Controls.Add(this.lbl_SelectTeam);
            this.grp_Teams.Controls.Add(this.lbl_SelectedTeams);
            this.grp_Teams.Controls.Add(this.cmb_TournamentTeams);
            this.grp_Teams.Controls.Add(this.lbx_Teams);
            this.grp_Teams.Controls.Add(this.lnkLbl_CreateNew);
            this.grp_Teams.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_Teams.Location = new System.Drawing.Point(0, 100);
            this.grp_Teams.Name = "grp_Teams";
            this.grp_Teams.Size = new System.Drawing.Size(881, 286);
            this.grp_Teams.TabIndex = 15;
            this.grp_Teams.TabStop = false;
            this.grp_Teams.Text = "Teams";
            // 
            // btn_DeleteTeam
            // 
            this.btn_DeleteTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_DeleteTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_DeleteTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteTeam.Location = new System.Drawing.Point(697, 114);
            this.btn_DeleteTeam.Name = "btn_DeleteTeam";
            this.btn_DeleteTeam.Size = new System.Drawing.Size(90, 44);
            this.btn_DeleteTeam.TabIndex = 15;
            this.btn_DeleteTeam.Text = "Remove Selected";
            this.btn_DeleteTeam.UseVisualStyleBackColor = true;
            // 
            // grp_Prizes
            // 
            this.grp_Prizes.Controls.Add(this.bnt_CreatePrize);
            this.grp_Prizes.Controls.Add(this.lbl_Or);
            this.grp_Prizes.Controls.Add(this.textBox5);
            this.grp_Prizes.Controls.Add(this.lbl_PrizePercentage);
            this.grp_Prizes.Controls.Add(this.textBox4);
            this.grp_Prizes.Controls.Add(this.lbl_PlaceName);
            this.grp_Prizes.Controls.Add(this.txt_PrizeAmount);
            this.grp_Prizes.Controls.Add(this.lbl_PrizeAmount);
            this.grp_Prizes.Controls.Add(this.txt_PlaceNumber);
            this.grp_Prizes.Controls.Add(this.lbl_PlaceNumber);
            this.grp_Prizes.Controls.Add(this.btn_RemovePrizes);
            this.grp_Prizes.Controls.Add(this.lbl_Prizes);
            this.grp_Prizes.Controls.Add(this.lbx_Prizes);
            this.grp_Prizes.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_Prizes.Location = new System.Drawing.Point(0, 386);
            this.grp_Prizes.Name = "grp_Prizes";
            this.grp_Prizes.Size = new System.Drawing.Size(881, 298);
            this.grp_Prizes.TabIndex = 16;
            this.grp_Prizes.TabStop = false;
            this.grp_Prizes.Text = "Prizes";
            // 
            // lbl_Or
            // 
            this.lbl_Or.AutoSize = true;
            this.lbl_Or.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Or.Location = new System.Drawing.Point(125, 179);
            this.lbl_Or.Name = "lbl_Or";
            this.lbl_Or.Size = new System.Drawing.Size(52, 21);
            this.lbl_Or.TabIndex = 31;
            this.lbl_Or.Text = "- OR -";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(141, 221);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(189, 22);
            this.textBox5.TabIndex = 30;
            // 
            // lbl_PrizePercentage
            // 
            this.lbl_PrizePercentage.AutoSize = true;
            this.lbl_PrizePercentage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrizePercentage.Location = new System.Drawing.Point(6, 222);
            this.lbl_PrizePercentage.Name = "lbl_PrizePercentage";
            this.lbl_PrizePercentage.Size = new System.Drawing.Size(131, 21);
            this.lbl_PrizePercentage.TabIndex = 29;
            this.lbl_PrizePercentage.Text = "Prize Percentage :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(141, 99);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(189, 22);
            this.textBox4.TabIndex = 28;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lbl_PlaceName
            // 
            this.lbl_PlaceName.AutoSize = true;
            this.lbl_PlaceName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlaceName.Location = new System.Drawing.Point(6, 99);
            this.lbl_PlaceName.Name = "lbl_PlaceName";
            this.lbl_PlaceName.Size = new System.Drawing.Size(99, 21);
            this.lbl_PlaceName.TabIndex = 27;
            this.lbl_PlaceName.Text = "Place Name :";
            // 
            // txt_PrizeAmount
            // 
            this.txt_PrizeAmount.Location = new System.Drawing.Point(141, 138);
            this.txt_PrizeAmount.Name = "txt_PrizeAmount";
            this.txt_PrizeAmount.Size = new System.Drawing.Size(189, 22);
            this.txt_PrizeAmount.TabIndex = 26;
            this.txt_PrizeAmount.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lbl_PrizeAmount
            // 
            this.lbl_PrizeAmount.AutoSize = true;
            this.lbl_PrizeAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrizeAmount.Location = new System.Drawing.Point(6, 138);
            this.lbl_PrizeAmount.Name = "lbl_PrizeAmount";
            this.lbl_PrizeAmount.Size = new System.Drawing.Size(111, 21);
            this.lbl_PrizeAmount.TabIndex = 25;
            this.lbl_PrizeAmount.Text = "Prize Amount :";
            // 
            // txt_PlaceNumber
            // 
            this.txt_PlaceNumber.Location = new System.Drawing.Point(141, 58);
            this.txt_PlaceNumber.Name = "txt_PlaceNumber";
            this.txt_PlaceNumber.Size = new System.Drawing.Size(189, 22);
            this.txt_PlaceNumber.TabIndex = 24;
            // 
            // lbl_PlaceNumber
            // 
            this.lbl_PlaceNumber.AutoSize = true;
            this.lbl_PlaceNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlaceNumber.Location = new System.Drawing.Point(6, 58);
            this.lbl_PlaceNumber.Name = "lbl_PlaceNumber";
            this.lbl_PlaceNumber.Size = new System.Drawing.Size(115, 21);
            this.lbl_PlaceNumber.TabIndex = 23;
            this.lbl_PlaceNumber.Text = "Place Number :";
            // 
            // btn_RemovePrizes
            // 
            this.btn_RemovePrizes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_RemovePrizes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_RemovePrizes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemovePrizes.Location = new System.Drawing.Point(697, 116);
            this.btn_RemovePrizes.Name = "btn_RemovePrizes";
            this.btn_RemovePrizes.Size = new System.Drawing.Size(90, 44);
            this.btn_RemovePrizes.TabIndex = 16;
            this.btn_RemovePrizes.Text = "Remove Selected";
            this.btn_RemovePrizes.UseVisualStyleBackColor = true;
            // 
            // lbl_Prizes
            // 
            this.lbl_Prizes.AutoSize = true;
            this.lbl_Prizes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Prizes.Location = new System.Drawing.Point(341, 27);
            this.lbl_Prizes.Name = "lbl_Prizes";
            this.lbl_Prizes.Size = new System.Drawing.Size(58, 21);
            this.lbl_Prizes.TabIndex = 15;
            this.lbl_Prizes.Text = "Prizes :";
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.Controls.Add(this.btn_Cancel);
            this.pnl_Buttons.Controls.Add(this.btn_Save);
            this.pnl_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Buttons.Location = new System.Drawing.Point(0, 684);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Size = new System.Drawing.Size(881, 52);
            this.pnl_Buttons.TabIndex = 17;
            // 
            // btn_Save
            // 
            this.btn_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Location = new System.Drawing.Point(667, 18);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(90, 23);
            this.btn_Save.TabIndex = 17;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Location = new System.Drawing.Point(779, 18);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(90, 23);
            this.btn_Cancel.TabIndex = 18;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // bnt_CreatePrize
            // 
            this.bnt_CreatePrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.bnt_CreatePrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.bnt_CreatePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_CreatePrize.Location = new System.Drawing.Point(187, 259);
            this.bnt_CreatePrize.Name = "bnt_CreatePrize";
            this.bnt_CreatePrize.Size = new System.Drawing.Size(90, 23);
            this.bnt_CreatePrize.TabIndex = 32;
            this.bnt_CreatePrize.Text = "Create Prize";
            this.bnt_CreatePrize.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 736);
            this.Controls.Add(this.pnl_Buttons);
            this.Controls.Add(this.grp_Prizes);
            this.Controls.Add(this.grp_Teams);
            this.Controls.Add(this.grp_Details);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.grp_Details.ResumeLayout(false);
            this.grp_Details.PerformLayout();
            this.grp_Teams.ResumeLayout(false);
            this.grp_Teams.PerformLayout();
            this.grp_Prizes.ResumeLayout(false);
            this.grp_Prizes.PerformLayout();
            this.pnl_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_Teams;
        private System.Windows.Forms.Label lbl_TournamentName;
        private System.Windows.Forms.ComboBox cmb_TournamentTeams;
        private System.Windows.Forms.GroupBox grp_Details;
        private System.Windows.Forms.Label lbl_EntryFee;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_SelectTeam;
        private System.Windows.Forms.LinkLabel lnkLbl_CreateNew;
        private System.Windows.Forms.ListBox lbx_Prizes;
        private System.Windows.Forms.Label lbl_SelectedTeams;
        private System.Windows.Forms.GroupBox grp_Teams;
        private System.Windows.Forms.Button btn_DeleteTeam;
        private System.Windows.Forms.GroupBox grp_Prizes;
        private System.Windows.Forms.Button btn_RemovePrizes;
        private System.Windows.Forms.Label lbl_Prizes;
        private System.Windows.Forms.TextBox txt_EntryFee;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lbl_PrizePercentage;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbl_PlaceName;
        private System.Windows.Forms.TextBox txt_PrizeAmount;
        private System.Windows.Forms.Label lbl_PrizeAmount;
        private System.Windows.Forms.TextBox txt_PlaceNumber;
        private System.Windows.Forms.Label lbl_PlaceNumber;
        private System.Windows.Forms.Label lbl_Or;
        private System.Windows.Forms.Button bnt_CreatePrize;
        private System.Windows.Forms.Panel pnl_Buttons;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
    }
}