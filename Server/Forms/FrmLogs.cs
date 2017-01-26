using System;
using System.Diagnostics;
using System.Windows.Forms;
using xServer.Core.Data;
using xServer.Core.Storage;

namespace xServer.Forms
{
    public partial class FrmLogs : Form
    {
        public FrmLogs()
        {
            InitializeComponent();
            /*
            lblVersion.Text = "v" + Application.ProductVersion;
            rtxtContent.Text = Properties.Resources.TermsOfUse;

            lnkGithubPage.Links.Add(new LinkLabel.Link { LinkData = Settings.RepositoryURL });
            lnkCredits.Links.Add(new LinkLabel.Link { LinkData = Settings.RepositoryURL + "#credits" });
            */

            // Fetch logs from DB
            //rtxtContent.Text = "test lol";

            updateLog();
        }

        public void updateLog()
        {
            rtxtContent.Text = "";
            LogStore[] logs = Storage.getLogs();
            foreach (var entry in logs)
            {
                rtxtContent.Text += "[" + DateTimeOffset.FromUnixTimeSeconds(entry.ts).DateTime.ToLocalTime() + "] " + entry.msg + "\n";
            }
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogs_Load(object sender, EventArgs e)
        {

        }
    }
}