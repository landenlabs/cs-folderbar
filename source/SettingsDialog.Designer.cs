namespace FolderBar_NS
{
    partial class SettingsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsDialog));
            this.look = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.lookPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.viewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.centerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stretchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.okBtn = new System.Windows.Forms.Button();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.topLook = new FolderBar_NS.LookDialog();
            this.bottomLook = new FolderBar_NS.LookDialog();
            this.listLook = new FolderBar_NS.LookDialog();
            this.treeLook = new FolderBar_NS.LookDialog();
            this.leftLook = new FolderBar_NS.LookDialog();
            this.rightLook = new FolderBar_NS.LookDialog();
            this.mainLook = new FolderBar_NS.LookDialog();
            this.iconStyle = new FolderBar_NS.IconStyle();
            this.layoutFrameCk = new System.Windows.Forms.CheckBox();
            this.layoutFileBoxCk = new System.Windows.Forms.CheckBox();
            this.layoutStatusCk = new System.Windows.Forms.CheckBox();
            this.author = new System.Windows.Forms.Label();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.autoStartCk = new System.Windows.Forms.CheckBox();
            this.restartAllBtn = new System.Windows.Forms.Button();
            this.launchFBCk = new System.Windows.Forms.CheckBox();
            this.loadLookBtn = new System.Windows.Forms.Button();
            this.saveLookBtn = new System.Windows.Forms.Button();
            this.openLookDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveLookDialog = new System.Windows.Forms.SaveFileDialog();
            this.lookPanel.SuspendLayout();
            this.viewMenu.SuspendLayout();
            this.tableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // look
            // 
            this.look.BackColor = System.Drawing.Color.Transparent;
            this.look.BackgroundImage = global::FolderBar_NS.Properties.Resources.FolderBar200;
            this.look.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.look.Location = new System.Drawing.Point(3, 3);
            this.look.Name = "look";
            this.look.Size = new System.Drawing.Size(128, 128);
            this.look.TabIndex = 0;
            this.toolTip.SetToolTip(this.look, "FolderBar v1.2 - By Dennis Lang");
            this.look.Click += new System.EventHandler(this.look_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::FolderBar_NS.Properties.Resources.FolderBarLine200;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(3, 485);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 128);
            this.panel1.TabIndex = 1;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(376, 589);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(67, 24);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Close";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // lookPanel
            // 
            this.lookPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lookPanel.BackgroundImage")));
            this.lookPanel.Controls.Add(this.label2);
            this.lookPanel.Controls.Add(this.look);
            this.lookPanel.Controls.Add(this.panel1);
            this.lookPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lookPanel.Location = new System.Drawing.Point(0, 0);
            this.lookPanel.Name = "lookPanel";
            this.lookPanel.Size = new System.Drawing.Size(144, 620);
            this.lookPanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(110, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 348);
            this.label2.TabIndex = 16;
            this.label2.Text = "Dennis    Lang  ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Silver;
            this.title.Font = new System.Drawing.Font("Footlight MT Light", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.title.Location = new System.Drawing.Point(151, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(146, 36);
            this.title.TabIndex = 4;
            this.title.Text = "FolderBar";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // viewMenu
            // 
            this.viewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centerToolStripMenuItem,
            this.zoomToolStripMenuItem,
            this.stretchToolStripMenuItem,
            this.tileToolStripMenuItem,
            this.noneToolStripMenuItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(121, 114);
            // 
            // centerToolStripMenuItem
            // 
            this.centerToolStripMenuItem.Name = "centerToolStripMenuItem";
            this.centerToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.centerToolStripMenuItem.Text = "Center";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // stretchToolStripMenuItem
            // 
            this.stretchToolStripMenuItem.Name = "stretchToolStripMenuItem";
            this.stretchToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.stretchToolStripMenuItem.Text = "Stretch";
            // 
            // tileToolStripMenuItem
            // 
            this.tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            this.tileToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.tileToolStripMenuItem.Text = "Tile";
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.noneToolStripMenuItem.Text = "None";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "filebar.png";
            this.openFileDialog.Filter = "Png|*.png|Jpeg|*.jpg|Any|*.*";
            this.openFileDialog.Title = "Load Look Image";
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Location = new System.Drawing.Point(449, 589);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(65, 24);
            this.okBtn.TabIndex = 9;
            this.okBtn.Text = "Apply";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // tableLayout
            // 
            this.tableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayout.AutoScroll = true;
            this.tableLayout.BackColor = System.Drawing.Color.Silver;
            this.tableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayout.ColumnCount = 1;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Controls.Add(this.topLook, 0, 0);
            this.tableLayout.Controls.Add(this.bottomLook, 0, 1);
            this.tableLayout.Controls.Add(this.listLook, 0, 2);
            this.tableLayout.Controls.Add(this.treeLook, 0, 3);
            this.tableLayout.Controls.Add(this.leftLook, 0, 4);
            this.tableLayout.Controls.Add(this.rightLook, 0, 5);
            this.tableLayout.Controls.Add(this.mainLook, 0, 6);
            this.tableLayout.Controls.Add(this.iconStyle, 0, 7);
            this.tableLayout.Controls.Add(this.layoutFrameCk, 0, 8);
            this.tableLayout.Controls.Add(this.layoutFileBoxCk, 0, 9);
            this.tableLayout.Controls.Add(this.layoutStatusCk, 0, 10);
            this.tableLayout.Location = new System.Drawing.Point(161, 134);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 12;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayout.Size = new System.Drawing.Size(352, 449);
            this.tableLayout.TabIndex = 14;
            // 
            // topLook
            // 
            this.topLook.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.topLook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topLook.FgColor = System.Drawing.Color.Black;
            this.topLook.ImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.topLook.ImagePath = "";
            this.topLook.InsideFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.topLook.LengthLabel = " Height";
            this.topLook.LengthValue = 30;
            this.topLook.LengthVisible = true;
            this.topLook.Location = new System.Drawing.Point(6, 6);
            this.topLook.LookItem = ((FolderBar_NS.FolderBar.LookItem)(resources.GetObject("topLook.LookItem")));
            this.topLook.Name = "topLook";
            this.topLook.Size = new System.Drawing.Size(323, 160);
            this.topLook.TabIndex = 12;
            this.topLook.TabStop = false;
            this.topLook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.topLook.Title = "Top Look";
            this.topLook.ViewState = true;
            // 
            // bottomLook
            // 
            this.bottomLook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bottomLook.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.bottomLook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomLook.FgColor = System.Drawing.Color.Black;
            this.bottomLook.ImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.bottomLook.ImagePath = "";
            this.bottomLook.InsideFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bottomLook.LengthLabel = " Height";
            this.bottomLook.LengthValue = 30;
            this.bottomLook.LengthVisible = true;
            this.bottomLook.Location = new System.Drawing.Point(6, 175);
            this.bottomLook.LookItem = ((FolderBar_NS.FolderBar.LookItem)(resources.GetObject("bottomLook.LookItem")));
            this.bottomLook.Name = "bottomLook";
            this.bottomLook.Size = new System.Drawing.Size(323, 160);
            this.bottomLook.TabIndex = 13;
            this.bottomLook.TabStop = false;
            this.bottomLook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bottomLook.Title = "Bottom Look";
            this.bottomLook.ViewState = true;
            // 
            // listLook
            // 
            this.listLook.BgColor = System.Drawing.Color.LightBlue;
            this.listLook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLook.FgColor = System.Drawing.Color.Black;
            this.listLook.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.listLook.ImagePath = "";
            this.listLook.InsideFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.listLook.LengthLabel = "Opacity";
            this.listLook.LengthValue = 100;
            this.listLook.LengthVisible = true;
            this.listLook.Location = new System.Drawing.Point(6, 344);
            this.listLook.LookItem = ((FolderBar_NS.FolderBar.LookItem)(resources.GetObject("listLook.LookItem")));
            this.listLook.Name = "listLook";
            this.listLook.Size = new System.Drawing.Size(323, 160);
            this.listLook.TabIndex = 17;
            this.listLook.TabStop = false;
            this.listLook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.listLook.Title = "List";
            this.listLook.ViewState = true;
            // 
            // treeLook
            // 
            this.treeLook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.treeLook.BgColor = System.Drawing.Color.LightBlue;
            this.treeLook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeLook.FgColor = System.Drawing.Color.Black;
            this.treeLook.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.treeLook.ImagePath = "";
            this.treeLook.InsideFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.treeLook.LengthLabel = "Opacity";
            this.treeLook.LengthValue = 100;
            this.treeLook.LengthVisible = true;
            this.treeLook.Location = new System.Drawing.Point(6, 513);
            this.treeLook.LookItem = ((FolderBar_NS.FolderBar.LookItem)(resources.GetObject("treeLook.LookItem")));
            this.treeLook.Name = "treeLook";
            this.treeLook.Size = new System.Drawing.Size(323, 160);
            this.treeLook.TabIndex = 14;
            this.treeLook.TabStop = false;
            this.treeLook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.treeLook.Title = "Tree";
            this.treeLook.ViewState = true;
            // 
            // leftLook
            // 
            this.leftLook.BgColor = System.Drawing.Color.LightBlue;
            this.leftLook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftLook.FgColor = System.Drawing.Color.Black;
            this.leftLook.ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftLook.ImagePath = "";
            this.leftLook.InsideFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.leftLook.LengthLabel = "Width";
            this.leftLook.LengthValue = 30;
            this.leftLook.LengthVisible = true;
            this.leftLook.Location = new System.Drawing.Point(6, 682);
            this.leftLook.LookItem = ((FolderBar_NS.FolderBar.LookItem)(resources.GetObject("leftLook.LookItem")));
            this.leftLook.Name = "leftLook";
            this.leftLook.Size = new System.Drawing.Size(323, 160);
            this.leftLook.TabIndex = 16;
            this.leftLook.TabStop = false;
            this.leftLook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.leftLook.Title = "Left Look";
            this.leftLook.ViewState = true;
            // 
            // rightLook
            // 
            this.rightLook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rightLook.BgColor = System.Drawing.Color.LightBlue;
            this.rightLook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightLook.FgColor = System.Drawing.Color.Black;
            this.rightLook.ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightLook.ImagePath = "";
            this.rightLook.InsideFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rightLook.LengthLabel = "Width";
            this.rightLook.LengthValue = 30;
            this.rightLook.LengthVisible = true;
            this.rightLook.Location = new System.Drawing.Point(6, 851);
            this.rightLook.LookItem = ((FolderBar_NS.FolderBar.LookItem)(resources.GetObject("rightLook.LookItem")));
            this.rightLook.Name = "rightLook";
            this.rightLook.Size = new System.Drawing.Size(323, 160);
            this.rightLook.TabIndex = 15;
            this.rightLook.TabStop = false;
            this.rightLook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rightLook.Title = "Right Look";
            this.rightLook.ViewState = true;
            // 
            // mainLook
            // 
            this.mainLook.BackColor = System.Drawing.Color.Silver;
            this.mainLook.BgColor = System.Drawing.Color.LightBlue;
            this.mainLook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLook.FgColor = System.Drawing.Color.Black;
            this.mainLook.ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainLook.ImagePath = "";
            this.mainLook.InsideFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mainLook.LengthLabel = "Opacity";
            this.mainLook.LengthValue = 100;
            this.mainLook.LengthVisible = true;
            this.mainLook.Location = new System.Drawing.Point(6, 1020);
            this.mainLook.LookItem = ((FolderBar_NS.FolderBar.LookItem)(resources.GetObject("mainLook.LookItem")));
            this.mainLook.Name = "mainLook";
            this.mainLook.Size = new System.Drawing.Size(323, 160);
            this.mainLook.TabIndex = 17;
            this.mainLook.TabStop = false;
            this.mainLook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainLook.Title = "Main Background";
            this.mainLook.ViewState = true;
            // 
            // iconStyle
            // 
            this.iconStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.iconStyle.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.iconStyle.Depth = 32;
            this.iconStyle.IconHeight = 48;
            this.iconStyle.IconSize = new System.Drawing.Size(48, 48);
            this.iconStyle.IconWidth = 48;
            this.iconStyle.Location = new System.Drawing.Point(6, 1189);
            this.iconStyle.Name = "iconStyle";
            this.iconStyle.Size = new System.Drawing.Size(300, 154);
            this.iconStyle.TabIndex = 18;
            // 
            // layoutFrameCk
            // 
            this.layoutFrameCk.AutoSize = true;
            this.layoutFrameCk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutFrameCk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutFrameCk.Location = new System.Drawing.Point(6, 1352);
            this.layoutFrameCk.MinimumSize = new System.Drawing.Size(0, 20);
            this.layoutFrameCk.Name = "layoutFrameCk";
            this.layoutFrameCk.Size = new System.Drawing.Size(323, 20);
            this.layoutFrameCk.TabIndex = 20;
            this.layoutFrameCk.TabStop = false;
            this.layoutFrameCk.Text = "Frame";
            this.layoutFrameCk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layoutFileBoxCk
            // 
            this.layoutFileBoxCk.AutoSize = true;
            this.layoutFileBoxCk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutFileBoxCk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutFileBoxCk.Location = new System.Drawing.Point(6, 1381);
            this.layoutFileBoxCk.MinimumSize = new System.Drawing.Size(0, 20);
            this.layoutFileBoxCk.Name = "layoutFileBoxCk";
            this.layoutFileBoxCk.Size = new System.Drawing.Size(323, 20);
            this.layoutFileBoxCk.TabIndex = 21;
            this.layoutFileBoxCk.Text = "File Bar";
            this.layoutFileBoxCk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layoutStatusCk
            // 
            this.layoutStatusCk.AutoSize = true;
            this.layoutStatusCk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutStatusCk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutStatusCk.Location = new System.Drawing.Point(6, 1410);
            this.layoutStatusCk.MinimumSize = new System.Drawing.Size(0, 20);
            this.layoutStatusCk.Name = "layoutStatusCk";
            this.layoutStatusCk.Size = new System.Drawing.Size(323, 20);
            this.layoutStatusCk.TabIndex = 22;
            this.layoutStatusCk.Text = "Status Bar";
            this.layoutStatusCk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author.Location = new System.Drawing.Point(163, 45);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(161, 16);
            this.author.TabIndex = 15;
            this.author.Text = "Author:  Dennis Lang 2010";
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel.Location = new System.Drawing.Point(163, 61);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(294, 16);
            this.linkLabel.TabIndex = 16;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "https://landenlabs.com/index.html";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // autoStartCk
            // 
            this.autoStartCk.AutoSize = true;
            this.autoStartCk.Location = new System.Drawing.Point(166, 80);
            this.autoStartCk.Name = "autoStartCk";
            this.autoStartCk.Size = new System.Drawing.Size(70, 17);
            this.autoStartCk.TabIndex = 17;
            this.autoStartCk.Text = "AutoStart";
            this.toolTip.SetToolTip(this.autoStartCk, resources.GetString("autoStartCk.ToolTip"));
            this.autoStartCk.UseVisualStyleBackColor = true;
            // 
            // restartAllBtn
            // 
            this.restartAllBtn.Location = new System.Drawing.Point(239, 77);
            this.restartAllBtn.Margin = new System.Windows.Forms.Padding(0);
            this.restartAllBtn.Name = "restartAllBtn";
            this.restartAllBtn.Size = new System.Drawing.Size(75, 20);
            this.restartAllBtn.TabIndex = 18;
            this.restartAllBtn.Text = "RestartAll";
            this.toolTip.SetToolTip(this.restartAllBtn, "Restart previous FolderBar sessions.\r\nAll of the old sessions are saved in your A" +
                    "pplication Data directory.\r\n\r\nPress the folderbar button and select ProfileDir t" +
                    "o see old session files.\r\n");
            this.restartAllBtn.UseVisualStyleBackColor = true;
            this.restartAllBtn.Click += new System.EventHandler(this.restartAllBtn_Click);
            // 
            // launchFBCk
            // 
            this.launchFBCk.AutoSize = true;
            this.launchFBCk.Location = new System.Drawing.Point(326, 80);
            this.launchFBCk.Name = "launchFBCk";
            this.launchFBCk.Size = new System.Drawing.Size(78, 17);
            this.launchFBCk.TabIndex = 19;
            this.launchFBCk.Text = "Launch FB";
            this.toolTip.SetToolTip(this.launchFBCk, "Launch FolderBar when you click on a Folder icon instead of Explorer.\r\n\r\n\r\n");
            this.launchFBCk.UseVisualStyleBackColor = true;
            // 
            // loadLookBtn
            // 
            this.loadLookBtn.Location = new System.Drawing.Point(161, 103);
            this.loadLookBtn.Name = "loadLookBtn";
            this.loadLookBtn.Size = new System.Drawing.Size(68, 22);
            this.loadLookBtn.TabIndex = 20;
            this.loadLookBtn.Text = "Load Look";
            this.loadLookBtn.UseVisualStyleBackColor = true;
            this.loadLookBtn.Click += new System.EventHandler(this.loadLookBtn_Click);
            // 
            // saveLookBtn
            // 
            this.saveLookBtn.Location = new System.Drawing.Point(239, 103);
            this.saveLookBtn.Name = "saveLookBtn";
            this.saveLookBtn.Size = new System.Drawing.Size(68, 22);
            this.saveLookBtn.TabIndex = 21;
            this.saveLookBtn.Text = "Save Look";
            this.saveLookBtn.UseVisualStyleBackColor = true;
            this.saveLookBtn.Click += new System.EventHandler(this.saveLookBtn_Click);
            // 
            // openLookDialog
            // 
            this.openLookDialog.Filter = "Look|*.fbl";
            this.openLookDialog.Title = "Load Look Profile";
            // 
            // saveLookDialog
            // 
            this.saveLookDialog.DefaultExt = "fbl";
            this.saveLookDialog.Filter = "Look|*.fbl";
            this.saveLookDialog.Title = "Save Look Profile";
            // 
            // SettingsDialog
            // 
            this.AcceptButton = this.okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(528, 620);
            this.Controls.Add(this.saveLookBtn);
            this.Controls.Add(this.loadLookBtn);
            this.Controls.Add(this.launchFBCk);
            this.Controls.Add(this.restartAllBtn);
            this.Controls.Add(this.autoStartCk);
            this.Controls.Add(this.tableLayout);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.author);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.lookPanel);
            this.Controls.Add(this.cancelBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "FolderBar Settings";
            this.lookPanel.ResumeLayout(false);
            this.viewMenu.ResumeLayout(false);
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel look;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Panel lookPanel;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ContextMenuStrip viewMenu;
        private System.Windows.Forms.ToolStripMenuItem centerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stretchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.CheckBox layoutFrameCk;
        private System.Windows.Forms.CheckBox layoutFileBoxCk;
        private System.Windows.Forms.CheckBox layoutStatusCk;
        private LookDialog topLook;
        private LookDialog bottomLook;
        private LookDialog listLook;
        private LookDialog treeLook;
        private LookDialog leftLook;
        private LookDialog rightLook;
        private LookDialog mainLook;
        private IconStyle iconStyle;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox autoStartCk;
        private System.Windows.Forms.Button restartAllBtn;
        private System.Windows.Forms.CheckBox launchFBCk;
        private System.Windows.Forms.Button loadLookBtn;
        private System.Windows.Forms.Button saveLookBtn;
        private System.Windows.Forms.OpenFileDialog openLookDialog;
        private System.Windows.Forms.SaveFileDialog saveLookDialog;
    }
}