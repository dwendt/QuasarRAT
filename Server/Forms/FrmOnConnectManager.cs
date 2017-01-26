using System;
using System.Linq;
using System.Windows.Forms;
using xServer.Core.Data;
using xServer.Core.Helper;
using xServer.Core.Networking;

namespace xServer.Forms
{
    public partial class FrmOnConnectManager : Form
    {
        private readonly QuasarServer _listenServer;

        public FrmOnConnectManager(QuasarServer listenServer)
        {
            this._listenServer = listenServer;
            InitializeComponent();
        }

        private void FrmOnConnectManager_Load(object sender, EventArgs e)
        {
            if (_listenServer != null)
            {
                this.Text = "On-Connection Action Manager";//WindowHelper.GetWindowTitle("On-Connection Action Manager", _connectClient);
                AddGroups();
                //new Core.Packets.ServerPackets.GetStartupItems().Execute(_connectClient);
            }
        }

        private void AddGroups()
        {
            lstOnConnectItems.Groups.Add(new ListViewGroup("Default Group"));
        }

        private void FrmOnConnectManager_FormClosing(object sender, FormClosingEventArgs e)
        {
//            if (_listenServer.Value != null)
//                _listenServer.Value.FrmStm = null;
        }

        #region "ContextMenuStrip"

        private void addEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmAddToAutostart())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    //if (_connectClient != null)
                    //{
                    //    new Core.Packets.ServerPackets.DoStartupItemAdd(AutostartItem.Name, AutostartItem.Path,
                    //        AutostartItem.Type).Execute(_connectClient);
                    //    lstStartupItems.Items.Clear();
                    //    new Core.Packets.ServerPackets.GetStartupItems().Execute(_connectClient);
                    //}
                }
            }
        }

        private void removeEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int modified = 0;
            foreach (ListViewItem item in lstOnConnectItems.SelectedItems)
            {
                if (_listenServer != null)
                {
                    //int type = lstOnConnectItems.Groups.Cast<ListViewGroup>().TakeWhile(t => t != item.Group).Count();
                    //new Core.Packets.ServerPackets.DoStartupItemRemove(item.Text, item.SubItems[1].Text, type).Execute(_connectClient);
                }
                modified++;
            }

            if (modified > 0 && _listenServer != null)
            {
                // re-add the list
                //lstOnConnectItems.Items.Clear();
                //new Core.Packets.ServerPackets.GetStartupItems().Execute(_connectClient);
            }
        }

        #endregion

        public void AddOnConnectItemToListview(ListViewItem lvi)
        {
            try
            {
                lstOnConnectItems.Invoke((MethodInvoker) delegate
                {
                    lstOnConnectItems.Items.Add(lvi);
                });
            }
            catch (InvalidOperationException)
            {
            }
        }

        public ListViewGroup GetGroup(int group)
        {
            ListViewGroup g = null;
            try
            {
                lstOnConnectItems.Invoke((MethodInvoker) delegate
                {
                    g = lstOnConnectItems.Groups[group];
                });
            }
            catch (InvalidOperationException)
            {
                return null;
            }
            return g;
        }
    }
}