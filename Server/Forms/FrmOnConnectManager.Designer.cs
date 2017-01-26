namespace xServer.Forms
{
    partial class FrmOnConnectManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOnConnectManager));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstOnConnectItems = new xServer.Controls.AeroListView();
            this.hName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEntryToolStripMenuItem,
            this.removeEntryToolStripMenuItem});
            this.contextMenuStrip.Name = "ctxtMenu";
            this.contextMenuStrip.Size = new System.Drawing.Size(148, 48);
            // 
            // addEntryToolStripMenuItem
            // 
            this.addEntryToolStripMenuItem.Image = global::xServer.Properties.Resources.application_add;
            this.addEntryToolStripMenuItem.Name = "addEntryToolStripMenuItem";
            this.addEntryToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.addEntryToolStripMenuItem.Text = "Add Entry";
            this.addEntryToolStripMenuItem.Click += new System.EventHandler(this.addEntryToolStripMenuItem_Click);
            // 
            // removeEntryToolStripMenuItem
            // 
            this.removeEntryToolStripMenuItem.Image = global::xServer.Properties.Resources.application_delete;
            this.removeEntryToolStripMenuItem.Name = "removeEntryToolStripMenuItem";
            this.removeEntryToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.removeEntryToolStripMenuItem.Text = "Remove Entry";
            this.removeEntryToolStripMenuItem.Click += new System.EventHandler(this.removeEntryToolStripMenuItem_Click);
            // 
            // lstOnConnectItems
            // 
            this.lstOnConnectItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstOnConnectItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hName,
            this.hPath});
            this.lstOnConnectItems.ContextMenuStrip = this.contextMenuStrip;
            this.lstOnConnectItems.FullRowSelect = true;
            this.lstOnConnectItems.GridLines = true;
            this.lstOnConnectItems.Location = new System.Drawing.Point(12, 12);
            this.lstOnConnectItems.Name = "lstOnConnectItems";
            this.lstOnConnectItems.Size = new System.Drawing.Size(653, 349);
            this.lstOnConnectItems.TabIndex = 0;
            this.lstOnConnectItems.UseCompatibleStateImageBehavior = false;
            this.lstOnConnectItems.View = System.Windows.Forms.View.Details;
            // 
            // hName
            // 
            this.hName.Text = "Name";
            this.hName.Width = 187;
            // 
            // hApplyTo
            // 
            this.hPath.Text = "Apply To (* for all)";
            this.hPath.Width = 460;
            // 
            // FrmOnConnectManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(677, 373);
            this.Controls.Add(this.lstOnConnectItems);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "FrmOnConnectManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "On-Connection Action Manager []";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmOnConnectManager_FormClosing);
            this.Load += new System.EventHandler(this.FrmOnConnectManager_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader hName;
        private System.Windows.Forms.ColumnHeader hPath;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeEntryToolStripMenuItem;
        private Controls.AeroListView lstOnConnectItems;

    }
}