namespace FolderBar_NS
{
    partial class FolderBar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderBar));
			this.smallIcons = new System.Windows.Forms.ImageList(this.components);
			this.treeMain = new System.Windows.Forms.TreeView();
			this.panel = new System.Windows.Forms.Panel();
			this.listView = new System.Windows.Forms.ListView();
			this.cold_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cold_full = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cold_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cold_size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cold_a = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cold_mdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cold_cdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cold_owner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.largeIcons = new System.Windows.Forms.ImageList(this.components);
			this.splitter = new System.Windows.Forms.Splitter();
			this.filePathBox = new System.Windows.Forms.TextBox();
			this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.viewListMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.viewDetailMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.viewLiconMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.layoutMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.layoutFrameMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.layoutFileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.layoutTreeMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.layoutListMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.layoutStatusMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.layoutTopLookMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.layoutBottomLookMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.layoutLeftLookMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.layoutRightLookMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.lockedMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.profileDirMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.updateBackgrdMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.dupMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.setRegistryMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.saveSettingsMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.saveExitMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.status = new System.Windows.Forms.TextBox();
			this.comboBox = new System.Windows.Forms.ComboBox();
			this.layoutBtn = new System.Windows.Forms.Button();
			this.centerRowTable = new System.Windows.Forms.TableLayoutPanel();
			this.fileRowPanel = new System.Windows.Forms.Panel();
			this.filterBox = new System.Windows.Forms.TextBox();
			this.filterLbl = new System.Windows.Forms.Label();
			this.backBtn = new System.Windows.Forms.Button();
			this.botLookBtn = new System.Windows.Forms.Button();
			this.topLookBtn = new System.Windows.Forms.Button();
			this.centerColTable = new System.Windows.Forms.TableLayoutPanel();
			this.leftLookBtn = new System.Windows.Forms.Button();
			this.rightLookBtn = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.panel.SuspendLayout();
			this.contextMenu.SuspendLayout();
			this.centerRowTable.SuspendLayout();
			this.fileRowPanel.SuspendLayout();
			this.centerColTable.SuspendLayout();
			this.SuspendLayout();
			// 
			// smallIcons
			// 
			this.smallIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallIcons.ImageStream")));
			this.smallIcons.TransparentColor = System.Drawing.Color.Transparent;
			this.smallIcons.Images.SetKeyName(0, "RemovableDrive.png");
			this.smallIcons.Images.SetKeyName(1, "CDRom.png");
			this.smallIcons.Images.SetKeyName(2, "Desktop.png");
			this.smallIcons.Images.SetKeyName(3, "Drive.png");
			this.smallIcons.Images.SetKeyName(4, "MyComputer.png");
			this.smallIcons.Images.SetKeyName(5, "NetworkDrive.png");
			this.smallIcons.Images.SetKeyName(6, "Folder.png");
			// 
			// treeMain
			// 
			this.treeMain.AllowDrop = true;
			this.treeMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
			this.treeMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.treeMain.Dock = System.Windows.Forms.DockStyle.Left;
			this.treeMain.ImageIndex = 6;
			this.treeMain.ImageList = this.smallIcons;
			this.treeMain.Location = new System.Drawing.Point(0, 0);
			this.treeMain.Name = "treeMain";
			this.treeMain.SelectedImageIndex = 0;
			this.treeMain.Size = new System.Drawing.Size(113, 401);
			this.treeMain.TabIndex = 3;
			// 
			// panel
			// 
			this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel.BackColor = System.Drawing.SystemColors.Control;
			this.panel.Controls.Add(this.listView);
			this.panel.Controls.Add(this.splitter);
			this.panel.Controls.Add(this.treeMain);
			this.panel.Location = new System.Drawing.Point(0, 24);
			this.panel.Margin = new System.Windows.Forms.Padding(0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(408, 401);
			this.panel.TabIndex = 4;
			// 
			// listView
			// 
			this.listView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
			this.listView.BackgroundImageTiled = true;
			this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cold_name,
            this.cold_full,
            this.cold_type,
            this.cold_size,
            this.cold_a,
            this.cold_mdate,
            this.cold_cdate,
            this.cold_owner});
			this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView.FullRowSelect = true;
			this.listView.HideSelection = false;
			this.listView.HoverSelection = true;
			this.listView.LargeImageList = this.largeIcons;
			this.listView.Location = new System.Drawing.Point(118, 0);
			this.listView.Margin = new System.Windows.Forms.Padding(0);
			this.listView.Name = "listView";
			this.listView.Size = new System.Drawing.Size(290, 401);
			this.listView.SmallImageList = this.smallIcons;
			this.listView.TabIndex = 5;
			this.listView.TileSize = new System.Drawing.Size(32, 32);
			this.listView.UseCompatibleStateImageBehavior = false;
			this.listView.View = System.Windows.Forms.View.Details;
			this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
			this.listView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listView_KeyUp);
			this.listView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseClick);
			this.listView.MouseEnter += new System.EventHandler(this.listView_MouseEnter);
			this.listView.MouseLeave += new System.EventHandler(this.listView_MouseLeave);
			// 
			// cold_name
			// 
			this.cold_name.Text = "Name";
			this.cold_name.Width = 120;
			// 
			// cold_full
			// 
			this.cold_full.Text = "FullName";
			this.cold_full.Width = 0;
			// 
			// cold_type
			// 
			this.cold_type.Text = "Type";
			// 
			// cold_size
			// 
			this.cold_size.Text = "Size";
			// 
			// cold_a
			// 
			this.cold_a.Text = "Attribute";
			// 
			// cold_mdate
			// 
			this.cold_mdate.Text = "Date Modified";
			// 
			// cold_cdate
			// 
			this.cold_cdate.Text = "Date Created";
			// 
			// cold_owner
			// 
			this.cold_owner.Text = "Owner";
			// 
			// largeIcons
			// 
			this.largeIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeIcons.ImageStream")));
			this.largeIcons.TransparentColor = System.Drawing.Color.Transparent;
			this.largeIcons.Images.SetKeyName(0, "removable.gif");
			this.largeIcons.Images.SetKeyName(1, "cdrom.jpg");
			this.largeIcons.Images.SetKeyName(2, "desktop.png");
			this.largeIcons.Images.SetKeyName(3, "drives.gif");
			this.largeIcons.Images.SetKeyName(4, "My Computer Icon.jpg");
			this.largeIcons.Images.SetKeyName(5, "network.png");
			this.largeIcons.Images.SetKeyName(6, "folderBlue2.png");
			// 
			// splitter
			// 
			this.splitter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.splitter.Location = new System.Drawing.Point(113, 0);
			this.splitter.Margin = new System.Windows.Forms.Padding(0);
			this.splitter.MinExtra = 0;
			this.splitter.MinSize = 0;
			this.splitter.Name = "splitter";
			this.splitter.Size = new System.Drawing.Size(5, 401);
			this.splitter.TabIndex = 4;
			this.splitter.TabStop = false;
			// 
			// filePathBox
			// 
			this.filePathBox.AllowDrop = true;
			this.filePathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.filePathBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.filePathBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
			this.filePathBox.BackColor = System.Drawing.SystemColors.Window;
			this.filePathBox.ContextMenuStrip = this.contextMenu;
			this.filePathBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.filePathBox.Location = new System.Drawing.Point(74, 0);
			this.filePathBox.Margin = new System.Windows.Forms.Padding(0);
			this.filePathBox.Name = "filePathBox";
			this.filePathBox.Size = new System.Drawing.Size(334, 22);
			this.filePathBox.TabIndex = 5;
			this.filePathBox.TextChanged += new System.EventHandler(this.filePathBox_TextChanged);
			this.filePathBox.DoubleClick += new System.EventHandler(this.filePathBox_DoubleClick);
			this.filePathBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.filePathBox_PreviewKeyDown);
			// 
			// contextMenu
			// 
			this.contextMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contextMenu.BackgroundImage")));
			this.contextMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMenu,
            this.layoutMenu,
            this.settingsMenu,
            this.lockedMenu,
            this.profileDirMenu,
            this.refreshMenu,
            this.updateBackgrdMenu,
            this.dupMenu,
            this.setRegistryMenu,
            this.saveSettingsMenu,
            this.saveExitMenu,
            this.exitMenu});
			this.contextMenu.Name = "contextMenuStrip1";
			this.contextMenu.ShowImageMargin = false;
			this.contextMenu.Size = new System.Drawing.Size(134, 268);
			// 
			// viewMenu
			// 
			this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewListMenu,
            this.viewDetailMenu,
            this.viewLiconMenu});
			this.viewMenu.Name = "viewMenu";
			this.viewMenu.Size = new System.Drawing.Size(133, 22);
			this.viewMenu.Text = "View";
			// 
			// viewListMenu
			// 
			this.viewListMenu.CheckOnClick = true;
			this.viewListMenu.Name = "viewListMenu";
			this.viewListMenu.Size = new System.Drawing.Size(126, 22);
			this.viewListMenu.Text = "List";
			this.viewListMenu.Click += new System.EventHandler(this.view_Click);
			// 
			// viewDetailMenu
			// 
			this.viewDetailMenu.Checked = true;
			this.viewDetailMenu.CheckOnClick = true;
			this.viewDetailMenu.CheckState = System.Windows.Forms.CheckState.Checked;
			this.viewDetailMenu.Name = "viewDetailMenu";
			this.viewDetailMenu.Size = new System.Drawing.Size(126, 22);
			this.viewDetailMenu.Text = "Details";
			this.viewDetailMenu.Click += new System.EventHandler(this.view_Click);
			// 
			// viewLiconMenu
			// 
			this.viewLiconMenu.CheckOnClick = true;
			this.viewLiconMenu.Name = "viewLiconMenu";
			this.viewLiconMenu.Size = new System.Drawing.Size(126, 22);
			this.viewLiconMenu.Text = "LargeIcon";
			this.viewLiconMenu.Click += new System.EventHandler(this.view_Click);
			// 
			// layoutMenu
			// 
			this.layoutMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layoutFrameMenu,
            this.layoutFileMenu,
            this.layoutTreeMenu,
            this.layoutListMenu,
            this.layoutStatusMenu,
            this.layoutTopLookMenu,
            this.layoutBottomLookMenu,
            this.layoutLeftLookMenu,
            this.layoutRightLookMenu});
			this.layoutMenu.Name = "layoutMenu";
			this.layoutMenu.Size = new System.Drawing.Size(133, 22);
			this.layoutMenu.Text = " Layout";
			// 
			// layoutFrameMenu
			// 
			this.layoutFrameMenu.Checked = true;
			this.layoutFrameMenu.CheckOnClick = true;
			this.layoutFrameMenu.CheckState = System.Windows.Forms.CheckState.Checked;
			this.layoutFrameMenu.Name = "layoutFrameMenu";
			this.layoutFrameMenu.Size = new System.Drawing.Size(156, 22);
			this.layoutFrameMenu.Text = "Frame";
			this.layoutFrameMenu.Click += new System.EventHandler(this.layout_Click);
			// 
			// layoutFileMenu
			// 
			this.layoutFileMenu.Checked = true;
			this.layoutFileMenu.CheckOnClick = true;
			this.layoutFileMenu.CheckState = System.Windows.Forms.CheckState.Checked;
			this.layoutFileMenu.Name = "layoutFileMenu";
			this.layoutFileMenu.Size = new System.Drawing.Size(156, 22);
			this.layoutFileMenu.Text = "File Navigation";
			this.layoutFileMenu.Click += new System.EventHandler(this.layout_Click);
			// 
			// layoutTreeMenu
			// 
			this.layoutTreeMenu.Checked = true;
			this.layoutTreeMenu.CheckOnClick = true;
			this.layoutTreeMenu.CheckState = System.Windows.Forms.CheckState.Checked;
			this.layoutTreeMenu.Name = "layoutTreeMenu";
			this.layoutTreeMenu.Size = new System.Drawing.Size(156, 22);
			this.layoutTreeMenu.Text = "Tree Navigation";
			this.layoutTreeMenu.Click += new System.EventHandler(this.layout_Click);
			// 
			// layoutListMenu
			// 
			this.layoutListMenu.Checked = true;
			this.layoutListMenu.CheckOnClick = true;
			this.layoutListMenu.CheckState = System.Windows.Forms.CheckState.Checked;
			this.layoutListMenu.Name = "layoutListMenu";
			this.layoutListMenu.Size = new System.Drawing.Size(156, 22);
			this.layoutListMenu.Text = "List View";
			this.layoutListMenu.Click += new System.EventHandler(this.layout_Click);
			// 
			// layoutStatusMenu
			// 
			this.layoutStatusMenu.Checked = true;
			this.layoutStatusMenu.CheckOnClick = true;
			this.layoutStatusMenu.CheckState = System.Windows.Forms.CheckState.Checked;
			this.layoutStatusMenu.Name = "layoutStatusMenu";
			this.layoutStatusMenu.Size = new System.Drawing.Size(156, 22);
			this.layoutStatusMenu.Text = "Status";
			this.layoutStatusMenu.Click += new System.EventHandler(this.layout_Click);
			// 
			// layoutTopLookMenu
			// 
			this.layoutTopLookMenu.Checked = true;
			this.layoutTopLookMenu.CheckOnClick = true;
			this.layoutTopLookMenu.CheckState = System.Windows.Forms.CheckState.Checked;
			this.layoutTopLookMenu.Name = "layoutTopLookMenu";
			this.layoutTopLookMenu.Size = new System.Drawing.Size(156, 22);
			this.layoutTopLookMenu.Text = "Top Look";
			this.layoutTopLookMenu.Click += new System.EventHandler(this.layout_Click);
			// 
			// layoutBottomLookMenu
			// 
			this.layoutBottomLookMenu.Checked = true;
			this.layoutBottomLookMenu.CheckOnClick = true;
			this.layoutBottomLookMenu.CheckState = System.Windows.Forms.CheckState.Checked;
			this.layoutBottomLookMenu.Name = "layoutBottomLookMenu";
			this.layoutBottomLookMenu.Size = new System.Drawing.Size(156, 22);
			this.layoutBottomLookMenu.Text = "Bottom Look";
			this.layoutBottomLookMenu.Click += new System.EventHandler(this.layout_Click);
			// 
			// layoutLeftLookMenu
			// 
			this.layoutLeftLookMenu.Checked = true;
			this.layoutLeftLookMenu.CheckOnClick = true;
			this.layoutLeftLookMenu.CheckState = System.Windows.Forms.CheckState.Checked;
			this.layoutLeftLookMenu.Name = "layoutLeftLookMenu";
			this.layoutLeftLookMenu.Size = new System.Drawing.Size(156, 22);
			this.layoutLeftLookMenu.Text = "Left Look";
			// 
			// layoutRightLookMenu
			// 
			this.layoutRightLookMenu.Checked = true;
			this.layoutRightLookMenu.CheckOnClick = true;
			this.layoutRightLookMenu.CheckState = System.Windows.Forms.CheckState.Checked;
			this.layoutRightLookMenu.Name = "layoutRightLookMenu";
			this.layoutRightLookMenu.Size = new System.Drawing.Size(156, 22);
			this.layoutRightLookMenu.Text = "Right Look";
			// 
			// settingsMenu
			// 
			this.settingsMenu.Name = "settingsMenu";
			this.settingsMenu.Size = new System.Drawing.Size(133, 22);
			this.settingsMenu.Text = "Settings";
			this.settingsMenu.Click += new System.EventHandler(this.settingsMenu_Click);
			// 
			// lockedMenu
			// 
			this.lockedMenu.CheckOnClick = true;
			this.lockedMenu.Name = "lockedMenu";
			this.lockedMenu.Size = new System.Drawing.Size(133, 22);
			this.lockedMenu.Text = "Locked";
			this.lockedMenu.Click += new System.EventHandler(this.lockedMenu_Click);
			// 
			// profileDirMenu
			// 
			this.profileDirMenu.Name = "profileDirMenu";
			this.profileDirMenu.Size = new System.Drawing.Size(133, 22);
			this.profileDirMenu.Text = "Profile Dir";
			this.profileDirMenu.Click += new System.EventHandler(this.profilesToolStripMenuItem_Click);
			// 
			// refreshMenu
			// 
			this.refreshMenu.Name = "refreshMenu";
			this.refreshMenu.Size = new System.Drawing.Size(133, 22);
			this.refreshMenu.Text = "Refresh";
			this.refreshMenu.Click += new System.EventHandler(this.refreshMenu_Click);
			// 
			// updateBackgrdMenu
			// 
			this.updateBackgrdMenu.Name = "updateBackgrdMenu";
			this.updateBackgrdMenu.Size = new System.Drawing.Size(133, 22);
			this.updateBackgrdMenu.Text = "Update Backgrd";
			this.updateBackgrdMenu.Click += new System.EventHandler(this.updateBackgrdMenu_Click);
			// 
			// dupMenu
			// 
			this.dupMenu.Name = "dupMenu";
			this.dupMenu.Size = new System.Drawing.Size(133, 22);
			this.dupMenu.Text = "Dup Folderbar";
			this.dupMenu.ToolTipText = "Open another FolderBar starting with current settings.";
			this.dupMenu.Click += new System.EventHandler(this.dupMenu_Click);
			// 
			// setRegistryMenu
			// 
			this.setRegistryMenu.Name = "setRegistryMenu";
			this.setRegistryMenu.Size = new System.Drawing.Size(133, 22);
			this.setRegistryMenu.Text = "Set Registry";
			this.setRegistryMenu.ToolTipText = "Set .fb extension assocciated to FolderBar\r\nSet auto login startup if enabled in " +
    "Setting Dialog\r\n";
			this.setRegistryMenu.Click += new System.EventHandler(this.setRegistryMenu_Click);
			// 
			// saveSettingsMenu
			// 
			this.saveSettingsMenu.Name = "saveSettingsMenu";
			this.saveSettingsMenu.Size = new System.Drawing.Size(133, 22);
			this.saveSettingsMenu.Text = "Save Settings";
			this.saveSettingsMenu.Click += new System.EventHandler(this.saveSettingsMenu_Click);
			// 
			// saveExitMenu
			// 
			this.saveExitMenu.Name = "saveExitMenu";
			this.saveExitMenu.Size = new System.Drawing.Size(133, 22);
			this.saveExitMenu.Text = "Save & Exit";
			this.saveExitMenu.ToolTipText = "Save Settings and Exit";
			this.saveExitMenu.Click += new System.EventHandler(this.exit_Click);
			// 
			// exitMenu
			// 
			this.exitMenu.Name = "exitMenu";
			this.exitMenu.Size = new System.Drawing.Size(133, 22);
			this.exitMenu.Text = "Exit";
			this.exitMenu.Click += new System.EventHandler(this.exit_Click);
			// 
			// status
			// 
			this.status.BackColor = System.Drawing.SystemColors.Window;
			this.status.ContextMenuStrip = this.contextMenu;
			this.status.Dock = System.Windows.Forms.DockStyle.Fill;
			this.status.Location = new System.Drawing.Point(0, 425);
			this.status.Margin = new System.Windows.Forms.Padding(0);
			this.status.Name = "status";
			this.status.ReadOnly = true;
			this.status.Size = new System.Drawing.Size(408, 20);
			this.status.TabIndex = 6;
			this.status.Text = "status";
			// 
			// comboBox
			// 
			this.comboBox.ContextMenuStrip = this.contextMenu;
			this.comboBox.DropDownHeight = 300;
			this.comboBox.DropDownWidth = 400;
			this.comboBox.FormattingEnabled = true;
			this.comboBox.IntegralHeight = false;
			this.comboBox.Location = new System.Drawing.Point(26, 2);
			this.comboBox.Margin = new System.Windows.Forms.Padding(0);
			this.comboBox.Name = "comboBox";
			this.comboBox.Size = new System.Drawing.Size(22, 21);
			this.comboBox.TabIndex = 7;
			this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
			// 
			// layoutBtn
			// 
			this.layoutBtn.BackColor = System.Drawing.Color.White;
			this.layoutBtn.BackgroundImage = global::FolderBar_NS.Properties.Resources.FolderBar641;
			this.layoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.layoutBtn.ContextMenuStrip = this.contextMenu;
			this.layoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.layoutBtn.Location = new System.Drawing.Point(0, 0);
			this.layoutBtn.Margin = new System.Windows.Forms.Padding(0);
			this.layoutBtn.Name = "layoutBtn";
			this.layoutBtn.Size = new System.Drawing.Size(24, 24);
			this.layoutBtn.TabIndex = 8;
			this.toolTip.SetToolTip(this.layoutBtn, "Toggle Tree panel, right clidk for menu");
			this.layoutBtn.UseVisualStyleBackColor = false;
			this.layoutBtn.Click += new System.EventHandler(this.treeVisible_Click);
			// 
			// centerRowTable
			// 
			this.centerRowTable.AutoSize = true;
			this.centerRowTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.centerRowTable.BackColor = System.Drawing.Color.White;
			this.centerRowTable.ColumnCount = 1;
			this.centerRowTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.centerRowTable.Controls.Add(this.panel, 0, 1);
			this.centerRowTable.Controls.Add(this.fileRowPanel, 0, 0);
			this.centerRowTable.Controls.Add(this.status, 0, 2);
			this.centerRowTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.centerRowTable.Location = new System.Drawing.Point(20, 0);
			this.centerRowTable.Margin = new System.Windows.Forms.Padding(0);
			this.centerRowTable.Name = "centerRowTable";
			this.centerRowTable.RowCount = 3;
			this.centerRowTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.centerRowTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.centerRowTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.centerRowTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.centerRowTable.Size = new System.Drawing.Size(408, 445);
			this.centerRowTable.TabIndex = 12;
			// 
			// fileRowPanel
			// 
			this.fileRowPanel.AutoSize = true;
			this.fileRowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.fileRowPanel.Controls.Add(this.filePathBox);
			this.fileRowPanel.Controls.Add(this.filterBox);
			this.fileRowPanel.Controls.Add(this.filterLbl);
			this.fileRowPanel.Controls.Add(this.backBtn);
			this.fileRowPanel.Controls.Add(this.layoutBtn);
			this.fileRowPanel.Controls.Add(this.comboBox);
			this.fileRowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fileRowPanel.Location = new System.Drawing.Point(0, 0);
			this.fileRowPanel.Margin = new System.Windows.Forms.Padding(0);
			this.fileRowPanel.Name = "fileRowPanel";
			this.fileRowPanel.Size = new System.Drawing.Size(408, 24);
			this.fileRowPanel.TabIndex = 5;
			// 
			// filterBox
			// 
			this.filterBox.AllowDrop = true;
			this.filterBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.filterBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.filterBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
			this.filterBox.BackColor = System.Drawing.SystemColors.Window;
			this.filterBox.ContextMenuStrip = this.contextMenu;
			this.filterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.filterBox.Location = new System.Drawing.Point(128, 0);
			this.filterBox.Margin = new System.Windows.Forms.Padding(0);
			this.filterBox.Name = "filterBox";
			this.filterBox.Size = new System.Drawing.Size(280, 22);
			this.filterBox.TabIndex = 11;
			this.filterBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.filterBox_KeyUp);
			// 
			// filterLbl
			// 
			this.filterLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.filterLbl.ForeColor = System.Drawing.Color.Red;
			this.filterLbl.Location = new System.Drawing.Point(74, 1);
			this.filterLbl.Margin = new System.Windows.Forms.Padding(0);
			this.filterLbl.Name = "filterLbl";
			this.filterLbl.Size = new System.Drawing.Size(54, 20);
			this.filterLbl.TabIndex = 10;
			this.filterLbl.Text = "Filter:";
			this.filterLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// backBtn
			// 
			this.backBtn.BackgroundImage = global::FolderBar_NS.Properties.Resources.uparrow24;
			this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.backBtn.FlatAppearance.BorderSize = 0;
			this.backBtn.Location = new System.Drawing.Point(50, 0);
			this.backBtn.Margin = new System.Windows.Forms.Padding(0);
			this.backBtn.Name = "backBtn";
			this.backBtn.Size = new System.Drawing.Size(24, 24);
			this.backBtn.TabIndex = 9;
			this.toolTip.SetToolTip(this.backBtn, "Up Directory");
			this.backBtn.UseVisualStyleBackColor = true;
			this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
			// 
			// botLookBtn
			// 
			this.botLookBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.botLookBtn.BackColor = System.Drawing.Color.Transparent;
			this.botLookBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.botLookBtn.ContextMenuStrip = this.contextMenu;
			this.botLookBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.botLookBtn.FlatAppearance.BorderSize = 0;
			this.botLookBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.botLookBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.botLookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.botLookBtn.Location = new System.Drawing.Point(0, 475);
			this.botLookBtn.Name = "botLookBtn";
			this.botLookBtn.Size = new System.Drawing.Size(448, 30);
			this.botLookBtn.TabIndex = 0;
			this.botLookBtn.Text = "--";
			this.botLookBtn.UseVisualStyleBackColor = false;
			this.botLookBtn.MouseEnter += new System.EventHandler(this.topLookBtn_MouseEnter);
			this.botLookBtn.MouseLeave += new System.EventHandler(this.topLookBtn_MouseLeave);
			this.botLookBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topLookBtn_MouseMove);
			// 
			// topLookBtn
			// 
			this.topLookBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.topLookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
			this.topLookBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.topLookBtn.ContextMenuStrip = this.contextMenu;
			this.topLookBtn.Dock = System.Windows.Forms.DockStyle.Top;
			this.topLookBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.topLookBtn.FlatAppearance.BorderSize = 0;
			this.topLookBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.topLookBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.topLookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.topLookBtn.Location = new System.Drawing.Point(0, 0);
			this.topLookBtn.Name = "topLookBtn";
			this.topLookBtn.Size = new System.Drawing.Size(448, 30);
			this.topLookBtn.TabIndex = 6;
			this.topLookBtn.Text = "--";
			this.topLookBtn.UseVisualStyleBackColor = false;
			this.topLookBtn.Click += new System.EventHandler(this.hideFrame_Click);
			this.topLookBtn.MouseEnter += new System.EventHandler(this.topLookBtn_MouseEnter);
			this.topLookBtn.MouseLeave += new System.EventHandler(this.topLookBtn_MouseLeave);
			this.topLookBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topLookBtn_MouseMove);
			// 
			// centerColTable
			// 
			this.centerColTable.BackColor = System.Drawing.Color.Transparent;
			this.centerColTable.ColumnCount = 3;
			this.centerColTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.centerColTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.centerColTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.centerColTable.Controls.Add(this.centerRowTable, 1, 0);
			this.centerColTable.Controls.Add(this.leftLookBtn, 0, 0);
			this.centerColTable.Controls.Add(this.rightLookBtn, 2, 0);
			this.centerColTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.centerColTable.Location = new System.Drawing.Point(0, 30);
			this.centerColTable.Name = "centerColTable";
			this.centerColTable.RowCount = 1;
			this.centerColTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.centerColTable.Size = new System.Drawing.Size(448, 445);
			this.centerColTable.TabIndex = 13;
			// 
			// leftLookBtn
			// 
			this.leftLookBtn.AutoSize = true;
			this.leftLookBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.leftLookBtn.BackColor = System.Drawing.Color.Transparent;
			this.leftLookBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.leftLookBtn.FlatAppearance.BorderSize = 0;
			this.leftLookBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.leftLookBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.leftLookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.leftLookBtn.Location = new System.Drawing.Point(0, 0);
			this.leftLookBtn.Margin = new System.Windows.Forms.Padding(0);
			this.leftLookBtn.MaximumSize = new System.Drawing.Size(20, 0);
			this.leftLookBtn.MinimumSize = new System.Drawing.Size(20, 0);
			this.leftLookBtn.Name = "leftLookBtn";
			this.leftLookBtn.Size = new System.Drawing.Size(20, 445);
			this.leftLookBtn.TabIndex = 13;
			this.leftLookBtn.UseVisualStyleBackColor = false;
			this.leftLookBtn.MouseEnter += new System.EventHandler(this.topLookBtn_MouseEnter);
			this.leftLookBtn.MouseLeave += new System.EventHandler(this.topLookBtn_MouseLeave);
			this.leftLookBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topLookBtn_MouseMove);
			// 
			// rightLookBtn
			// 
			this.rightLookBtn.AutoSize = true;
			this.rightLookBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.rightLookBtn.BackColor = System.Drawing.Color.Transparent;
			this.rightLookBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rightLookBtn.FlatAppearance.BorderSize = 0;
			this.rightLookBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.rightLookBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.rightLookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rightLookBtn.Location = new System.Drawing.Point(428, 0);
			this.rightLookBtn.Margin = new System.Windows.Forms.Padding(0);
			this.rightLookBtn.MaximumSize = new System.Drawing.Size(20, 0);
			this.rightLookBtn.MinimumSize = new System.Drawing.Size(20, 0);
			this.rightLookBtn.Name = "rightLookBtn";
			this.rightLookBtn.Size = new System.Drawing.Size(20, 445);
			this.rightLookBtn.TabIndex = 14;
			this.rightLookBtn.UseVisualStyleBackColor = false;
			this.rightLookBtn.MouseEnter += new System.EventHandler(this.topLookBtn_MouseEnter);
			this.rightLookBtn.MouseLeave += new System.EventHandler(this.topLookBtn_MouseLeave);
			this.rightLookBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topLookBtn_MouseMove);
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 2000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// FolderBar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(448, 505);
			this.Controls.Add(this.centerColTable);
			this.Controls.Add(this.topLookBtn);
			this.Controls.Add(this.botLookBtn);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimizeBox = false;
			this.Name = "FolderBar";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "FolderBar";
			this.TransparencyKey = System.Drawing.Color.Lime;
			this.Click += new System.EventHandler(this.hideFrame_Click);
			this.panel.ResumeLayout(false);
			this.contextMenu.ResumeLayout(false);
			this.centerRowTable.ResumeLayout(false);
			this.centerRowTable.PerformLayout();
			this.fileRowPanel.ResumeLayout(false);
			this.fileRowPanel.PerformLayout();
			this.centerColTable.ResumeLayout(false);
			this.centerColTable.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList smallIcons;
        private System.Windows.Forms.TreeView treeMain;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.TextBox filePathBox;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.ColumnHeader cold_name;
        private System.Windows.Forms.ColumnHeader cold_size;
        private System.Windows.Forms.ColumnHeader cold_type;
        private System.Windows.Forms.ColumnHeader cold_mdate;
        private System.Windows.Forms.ColumnHeader cold_cdate;
        private System.Windows.Forms.ColumnHeader cold_a;
        private System.Windows.Forms.ColumnHeader cold_owner;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.ColumnHeader cold_full;
        private System.Windows.Forms.Button layoutBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem viewListMenu;
        private System.Windows.Forms.ToolStripMenuItem viewDetailMenu;
        private System.Windows.Forms.ToolStripMenuItem layoutMenu;
        private System.Windows.Forms.ToolStripMenuItem layoutTreeMenu;
        private System.Windows.Forms.ToolStripMenuItem layoutFileMenu;
        private System.Windows.Forms.ToolStripMenuItem layoutListMenu;
        private System.Windows.Forms.ToolStripMenuItem layoutTopLookMenu;
        private System.Windows.Forms.ToolStripMenuItem layoutBottomLookMenu;
        private System.Windows.Forms.ToolStripMenuItem settingsMenu;
        private System.Windows.Forms.ToolStripMenuItem saveExitMenu;
        private System.Windows.Forms.TableLayoutPanel centerRowTable;
        private System.Windows.Forms.Panel fileRowPanel;
        private System.Windows.Forms.ToolStripMenuItem lockedMenu;
        private System.Windows.Forms.ToolStripMenuItem layoutStatusMenu;
        private System.Windows.Forms.ToolStripMenuItem viewLiconMenu;
        private System.Windows.Forms.Button botLookBtn;
        private System.Windows.Forms.Button topLookBtn;
        private System.Windows.Forms.TableLayoutPanel centerColTable;
        private System.Windows.Forms.Button leftLookBtn;
        private System.Windows.Forms.Button rightLookBtn;
        private System.Windows.Forms.ToolStripMenuItem layoutLeftLookMenu;
        private System.Windows.Forms.ToolStripMenuItem layoutRightLookMenu;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem profileDirMenu;
        private System.Windows.Forms.ImageList largeIcons;
        private System.Windows.Forms.ToolStripMenuItem refreshMenu;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label filterLbl;
        private System.Windows.Forms.TextBox filterBox;
        private System.Windows.Forms.ToolStripMenuItem layoutFrameMenu;
        private System.Windows.Forms.ToolStripMenuItem dupMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.ToolStripMenuItem setRegistryMenu;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsMenu;
        private System.Windows.Forms.ToolStripMenuItem updateBackgrdMenu;
    }
}

