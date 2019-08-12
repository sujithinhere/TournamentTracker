using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournamentTrackerUI
{
    public partial class TournamentTrackerMainForm : Form
    {
        public TournamentTrackerMainForm()
        {
            InitializeComponent();
        }

        private void tournamentViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form tournamentViewerFrm = new TournamentViewerForm();
            tournamentViewerFrm.ShowDialog(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form createTournamentfrm = new CreateTournamentForm();
            createTournamentfrm.ShowDialog();
        }
    }
}
