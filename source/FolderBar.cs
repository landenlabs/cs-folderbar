using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

// Persistant settings using Serialization
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

// Registry manipulation
using Microsoft.Win32;

using System.Drawing.Imaging;


namespace FolderBar_NS {
	/// <summary>
	/// Light weight File Explorer/Bar .
	/// Win7 lacks XP's file tool bars.
	/// 
	/// Author: Dennis Lang  2010       
	/// https://landenlabs.com/
	/// </summary>
	public partial class FolderBar : Form {
		public FolderBar(string[] cmdLineArgs) {
			InitializeComponent();

			this.Text = ProductNameAndVersion();

			LoadTree();

			settings.topLook.font = topLookBtn.Font;
			settings.botLook.font = botLookBtn.Font;

			string settingFile = null;

			int argIdx = 0;
			if (cmdLineArgs.Length > argIdx) {
				if (string.CompareOrdinal("-noSave", cmdLineArgs[0]) == 0) {
					saveMode = SaveMode.DontSave;
					argIdx++;
				}
			}

			if (cmdLineArgs.Length > argIdx) {
				string extn = Path.GetExtension(cmdLineArgs[argIdx]);
				if (extn == ".fb") {
					settingFile = cmdLineArgs[0];
				} else if (string.CompareOrdinal("-autoStart", cmdLineArgs[argIdx]) == 0) {
					RestoreAllSettings();
					saveMode = SaveMode.DontSave;
					this.Visible = false;
					return;
				} else {
					startDir = settings.homeDir = cmdLineArgs[argIdx];
				}
			}

			RestoreSettings(settingFile);
		}

		#region ==== Data 

		string startDir = Environment.CurrentDirectory;
		enum SaveMode { DontSave, PromptSave, Save };
		SaveMode saveMode = SaveMode.Save;
		ExtractIcon extractIcon = new ExtractIcon();

		[Serializable]
		public class LookItem {
			public LookItem() {
				path = string.Empty;
				length = 30;
				imageLayout = ImageLayout.Zoom;

				text = string.Empty;
				textAlign = ContentAlignment.MiddleCenter;

				fgColor = Color.Black;
				bgColor = Color.White;
			}

			public string path;
			public int length;
			public ImageLayout imageLayout = ImageLayout.Zoom;

			public string text;
			public ContentAlignment textAlign = ContentAlignment.MiddleCenter;
			public Font font;

			public Color fgColor;
			public Color bgColor;

			public bool visible;
		}



		[Serializable]
		public class IconItem {
			public IconItem() {
				size = new Size(48, 48);
				colorDepth = ColorDepth.Depth32Bit;
			}

			public Size size;
			public ColorDepth colorDepth;
		}

		[Serializable]
		public class Settings {
			public Settings() {
				homeDir = System.Environment.CurrentDirectory;
				listLook.length = 100;
				treeLook.length = 100;
			}

			public Size size = new Size(400, 400);
			public Point location = new Point(100, 100);

			public string dateFmt = "G";
			public string sizeFmt = "#,##0";
			public string baseDir = "c:";
			public string homeDir;
			public string lookDir;  // where look images are stored

			public View view = View.List;
			public bool launchFB = false;
			public bool locked = false;
			public bool treeVisible = false;
			public bool listVisible = true;
			public bool statusVisible = true;
			public bool fileVisible = true;
			public bool frameVisible = true;

			public LookItem topLook = new LookItem();
			public LookItem botLook = new LookItem();
			public LookItem treeLook = new LookItem();
			public LookItem listLook = new LookItem();
			public LookItem leftLook = new LookItem();
			public LookItem rightLook = new LookItem();
			public LookItem mainLook = new LookItem();  // main background.
			public IconItem iconItem = new IconItem();

			// [NonSerialized]
		};

		public Settings settings = new Settings();

		const string FolderTypeStr = "Folder";
		const string SettingsDir = @"\FolderBar";
		const string SettingsFileFmt = @"\{0}.fb";
		const string SettingsExtn = ".fb";
		string ourName = "default";

		internal class DirStats {
			public DirStats() { folderCnt = fileCnt = 0; totalSize = 0; }
			public UInt32 folderCnt;
			public UInt32 fileCnt;
			public UInt64 totalSize;
		};

		DirStats dirStats = new DirStats();

		#endregion

		#region ==== Basic UI's
		public static string ProductNameAndVersion() {
			string appName = Application.ProductName;
			string appVern = Application.ProductVersion;
			return appName + " v" + appVern.Substring(0, 3); //  Get part of versoin string "n.n"
		}

		protected override void OnClosing(CancelEventArgs e) {
			SaveSettings();
			base.OnClosing(e);
		}

		float treePercent = 0;
		protected override void OnResizeBegin(EventArgs e) {
			base.OnResizeBegin(e);
			treePercent = Math.Max(0.5f, treeMain.Width / (float)treeMain.Parent.Width);
		}

		protected override void OnResizeEnd(EventArgs e) {
			base.OnResizeEnd(e);
			treeMain.Width = (int)(treeMain.Parent.Width * treePercent);
			BlendBackground(true);
		}

		TimeSpan blendQuickTime = new TimeSpan(0, 0, 29);
		protected override void OnMove(EventArgs e) {
			base.OnMove(e);
			blendTime = DateTime.Now - blendQuickTime;
		}
		#endregion

		#region ==== Setting file management
		private string SettingsFile() {
			string justDir;

			try {
				DirectoryInfo dirInfo = new DirectoryInfo(settings.homeDir);
				justDir = dirInfo.Parent.FullName + @"\" + dirInfo.Name;
			} catch {
				justDir = settings.homeDir;
			}
			ourName = justDir.Replace('\\', '_').Replace(':', '_');

			string appPath = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string ourDir = appPath + SettingsDir;
			try {
				Directory.CreateDirectory(ourDir);
			} catch { }

			string ourFile = ourDir + string.Format(SettingsFileFmt, this.ourName);
			return ourFile;
		}

		private void SaveSettings() {
			settings.size = this.Size;
			settings.location = this.Location;

			settings.locked = this.lockedMenu.Checked;
			settings.view = this.listView.View;
			settings.homeDir = this.filePathBox.Text;

			settings.treeVisible = treeMain.Visible;
			settings.listVisible = listView.Visible;
			settings.fileVisible = fileRowPanel.Visible;
			settings.statusVisible = status.Visible;
			settings.topLook.visible = topLookBtn.Visible;
			settings.botLook.visible = botLookBtn.Visible;
			settings.leftLook.visible = leftLookBtn.Visible;
			settings.rightLook.visible = rightLookBtn.Visible;

			if (saveMode == SaveMode.DontSave)
				return;
			if (saveMode == SaveMode.Save && startDir != settings.homeDir)
				saveMode = SaveMode.PromptSave;
			if (saveMode == SaveMode.PromptSave &&
				MessageBox.Show("Save Settings ?", "Save", MessageBoxButtons.YesNo) == DialogResult.No)
				return;

			string ourFile = SettingsFile();

			try {
				Stream stream = File.OpenWrite(ourFile);
				BinaryFormatter bFormatter = new BinaryFormatter();
				bFormatter.Serialize(stream, settings);
				stream.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}

			UpdateRegistry();
		}

		private void UpdateRegistry() {
			// add ".fb" extension association to the registry
			string appName = "FolderBar";

			try {
				// using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(SettingsExtn))
				using (RegistryKey key = Registry.CurrentUser.CreateSubKey(SettingsExtn)) {
					key.SetValue(null, appName);
				}

				// using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(appName))
				using (RegistryKey key = Registry.CurrentUser.CreateSubKey(appName)) {
					RegistryKey subKey = key.CreateSubKey("shell").CreateSubKey("open").CreateSubKey("command");
					// string appPath = Application.StartupPath;
					// string cmdLine = Environment.CommandLine;
					subKey.SetValue(null, Application.ExecutablePath + " \"%1\" %*");
				}
			} catch (Exception ex) {
				MessageBox.Show("Unable to set FolderBar registry\n" + ex.Message);
			}

			try {
				if (settingsDialog != null && settingsDialog.AutoStart) {
					AutoStarter.SetAutoStart();
				}
			} catch (Exception ex) {
				MessageBox.Show("Unable to set FolderBar Autostart\n" + ex.Message);
			}
		}

		public void RestoreAllSettings() {
			string appPath = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string ourDir = appPath + SettingsDir;

			DirectoryInfo dirInfo = new DirectoryInfo(ourDir);
			FileInfo[] files = dirInfo.GetFiles();
			foreach (FileInfo fileInfo in files) {
				Launch(fileInfo.FullName);
			}
		}

		public const string FolderBarLookEnv = "FolderBarLook";
		public void RestoreSettings(string ourFile) {
			if (ourFile == null)
				ourFile = SettingsFile();

			settings.lookDir = string.Empty; //  Path.GetDirectoryName(Application.ExecutablePath) + @"\FolderBarLook";
			string envValue = null;
			try {
				envValue = Environment.GetEnvironmentVariable(FolderBarLookEnv);
			} catch { }
			if (envValue != null && envValue.Length != 0) {
				settings.lookDir = envValue;
			}

			settings.size = this.Size;
			settings.location = this.Location;
			settings.iconItem.size = largeIcons.ImageSize;
			settings.iconItem.colorDepth = largeIcons.ColorDepth;

			try {
				if (File.Exists(ourFile)) {
					Stream stream = File.OpenRead(ourFile);
					try {
						BinaryFormatter bFormatter = new BinaryFormatter();
						settings = (Settings)bFormatter.Deserialize(stream);
					} catch (Exception ex) {
						MessageBox.Show(string.Format("Unable to load {0}, error {1}", ourFile, ex.Message));
					}
					stream.Close();
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}

			if (settings.lookDir != null && settings.lookDir.Length > 0) {
				Environment.SetEnvironmentVariable(FolderBarLookEnv, settings.lookDir);
			}

			if (settings.topLook == null)
				settings.topLook = new LookItem();
			if (settings.botLook == null)
				settings.botLook = new LookItem();
			if (settings.leftLook == null)
				settings.leftLook = new LookItem();
			if (settings.rightLook == null)
				settings.rightLook = new LookItem();
			if (settings.listLook == null)
				settings.listLook = new LookItem();
			if (settings.treeLook == null)
				settings.treeLook = new LookItem();
			if (settings.mainLook == null)
				settings.mainLook = new LookItem();
			if (settings.iconItem == null)
				settings.iconItem = new IconItem();

			this.StartPosition = FormStartPosition.Manual;
			this.Size = settings.size;
			this.Location = settings.location;

			this.lockedMenu.Checked = settings.locked;
			layoutBtn.BackColor = lockedMenu.Checked ? Color.Red : Color.White;

			this.listView.View = settings.view;
			string viewStr = Enum.GetName(typeof(View), settings.view);
			foreach (ToolStripMenuItem toolItem in viewMenu.DropDownItems) {
				toolItem.Checked = false;
				if (toolItem.Text == viewStr)
					toolItem.Checked = true;
			}

			this.treeMain.Visible = this.splitter.Visible = layoutTreeMenu.Checked = settings.treeVisible;
			this.listView.Visible = layoutListMenu.Checked = settings.listVisible;
			this.fileRowPanel.Visible = layoutFileMenu.Checked = settings.fileVisible;
			this.status.Visible = settings.statusVisible;

			layoutTopLookMenu.Checked = settings.topLook.visible;
			layoutBottomLookMenu.Checked = settings.botLook.visible;
			layoutLeftLookMenu.Checked = settings.leftLook.visible;
			layoutRightLookMenu.Checked = settings.rightLook.visible;

			SetLook(topLookBtn, settings.topLook, layoutTopLookMenu.Checked);
			SetLook(botLookBtn, settings.botLook, layoutBottomLookMenu.Checked);

			SetSide(leftLookBtn, settings.leftLook, layoutLeftLookMenu.Checked);
			SetSide(rightLookBtn, settings.rightLook, layoutRightLookMenu.Checked);

			SetTree(treeMain, settings.treeLook, layoutTreeMenu.Checked);
			SetList(listView, settings.listLook, layoutListMenu.Checked);
			this.Opacity = settings.listLook.length / 100f;

			SetForm(this, settings.mainLook, true);
			SetIconStyle(settings.iconItem);

			startDir = settings.homeDir;
			ViewPath(settings.homeDir);
		}

		private void SetIconStyle(IconItem iconItem) {
			if (largeIcons.ImageSize != iconItem.size ||
				largeIcons.ColorDepth != iconItem.colorDepth) {

				ImageList newImageList = new ImageList();
				newImageList.ColorDepth = iconItem.colorDepth;
				newImageList.ImageSize = iconItem.size;

				for (int imageIdx = 0; imageIdx < largeIcons.Images.Count; imageIdx++) {
					newImageList.Images.Add(largeIcons.Images[imageIdx]);
					newImageList.Images.SetKeyName(imageIdx, largeIcons.Images.Keys[imageIdx]);
				}

				largeIcons = newImageList;
				listView.LargeImageList = largeIcons;
			}
		}

		SettingsDialog settingsDialog;
		private void settingsMenu_Click(object sender, EventArgs e) {
			if (settingsDialog == null) {
				settingsDialog = new SettingsDialog(this);
				settingsDialog.changed += new EventHandler(settingsApplyHandler);
				settingsDialog.restart += new EventHandler(restartHandler);
			}

			settingsDialog.Settings = settings;
			settingsDialog.Show();
			settingsDialog.Settings = settings;
		}

		private void restartHandler(object sender, EventArgs e) {
			RestoreAllSettings();
		}

		private void settingsApplyHandler(object sender, EventArgs e) {
			settings = settingsDialog.Settings;
			SetLook(topLookBtn, settings.topLook, layoutTopLookMenu.Checked = settings.topLook.visible);
			SetLook(botLookBtn, settings.botLook, layoutBottomLookMenu.Checked = settings.botLook.visible);

			SetSide(leftLookBtn, settings.leftLook, layoutLeftLookMenu.Checked = settings.leftLook.visible);
			SetSide(rightLookBtn, settings.rightLook, layoutRightLookMenu.Checked = settings.rightLook.visible);

			SetList(listView, settings.listLook, layoutListMenu.Checked = settings.listLook.visible);
			SetTree(treeMain, settings.treeLook, layoutTreeMenu.Checked = settings.treeLook.visible);

			SetForm(this, settings.mainLook, true);
			SetIconStyle(settings.iconItem);

			this.Opacity = settings.listLook.length / 100f;
		}
		#endregion

		#region ==== Set Look Panels (Top/Bottom, Side, List and Tree)

		/// <summary>
		/// Set Top or Bottom button panels
		/// </summary>
		private void SetLook(Button look, LookItem lookItem, bool visible) {
			look.Height = lookItem.length;
			look.Text = string.Format(lookItem.text,
				Path.GetPathRoot(settings.homeDir),
				Path.GetDirectoryName(settings.homeDir),
				settings.homeDir);

			look.Font = lookItem.font;
			look.TextAlign = lookItem.textAlign;
			look.BackColor = lookItem.bgColor;
			look.ForeColor = lookItem.fgColor;

			look.Visible = lookItem.visible = visible;

			look.BackgroundImageLayout = lookItem.imageLayout;
			look.BackgroundImage = null;

			if (lookItem.visible && lookItem.path.Length > 0) {
				try {
					string expandedPath = ExpandPath(lookItem.path);
					look.BackgroundImage = new Bitmap(expandedPath);
				} catch { }
			}
		}

		private void SetSide(Button look, LookItem lookItem, bool visible) {
			look.Width = lookItem.length;
			look.MinimumSize = look.MaximumSize = new Size(lookItem.length, 0);

			look.Text = string.Format(lookItem.text,
				Path.GetPathRoot(settings.homeDir),
				Path.GetDirectoryName(settings.homeDir),
				settings.homeDir);
			look.Font = lookItem.font;
			look.TextAlign = lookItem.textAlign;
			look.BackColor = lookItem.bgColor;
			look.ForeColor = lookItem.fgColor;

			look.Visible = lookItem.visible = visible;

			look.BackgroundImageLayout = lookItem.imageLayout;
			look.BackgroundImage = null;

			if (lookItem.visible && lookItem.path.Length > 0) {
				try {
					string expandedPath = ExpandPath(lookItem.path);
					look.BackgroundImage = new Bitmap(expandedPath);
				} catch { }
			}
		}

		private void SetList(ListView look, LookItem lookItem, bool visible) {
			look.MinimumSize = look.MinimumSize = new Size(lookItem.length, 0);

			look.Font = lookItem.font;
			look.BackColor = lookItem.bgColor;
			look.ForeColor = lookItem.fgColor;

			look.Visible = lookItem.visible = visible;

			look.BackgroundImageTiled = lookItem.imageLayout == ImageLayout.Tile;
			look.BackgroundImageLayout = lookItem.imageLayout;
			look.BackgroundImage = null;

			if (lookItem.visible && lookItem.path.Length > 0) {
				try {
					string expandedPath = ExpandPath(lookItem.path);
					look.BackgroundImage = new Bitmap(expandedPath);
				} catch { }
			}
		}

		private void SetTree(TreeView look, LookItem lookItem, bool visible) {
			look.MinimumSize = look.MinimumSize = new Size(lookItem.length, 0);

			look.Font = lookItem.font;
			look.BackColor = lookItem.bgColor;
			look.ForeColor = lookItem.fgColor;

			look.Visible = lookItem.visible = visible;

			look.BackgroundImageLayout = lookItem.imageLayout;
			look.BackgroundImage = null;

			if (lookItem.visible && lookItem.path.Length > 0) {
				try {
					string expandedPath = ExpandPath(lookItem.path);
					look.BackgroundImage = new Bitmap(expandedPath);
				} catch { }
			}
		}

		Bitmap mainBgImage = null;
		DateTime blendTime = DateTime.MinValue;
		TimeSpan blendTimeSpan = new TimeSpan(0, 0, 30);
		private void BlendBackground(bool force) {
			if (mainBgImage != null && (force || (DateTime.Now - blendTime) > blendTimeSpan)) {
				// blendTime = DateTime.Now;
				blendTime = DateTime.MaxValue;

				if (mainBgImage.PixelFormat == System.Drawing.Imaging.PixelFormat.Format32bppArgb) {
					int frameWidth = (this.Width - this.DisplayRectangle.Width) / 2;
					int frameHeight = (this.Height - this.DisplayRectangle.Height) - frameWidth;
					if (this.FormBorderStyle == FormBorderStyle.None)
						frameHeight = (this.Height - this.DisplayRectangle.Height) / 2;

					Point ul = new Point(this.Location.X + frameWidth, this.Location.Y + frameHeight);
					Bitmap bg = GrabScreen.GrabScreenImage(this, new Rectangle(ul, this.DisplayRectangle.Size));
					Graphics g = Graphics.FromImage(bg);
					g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
					g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
					g.DrawImage(mainBgImage, new Rectangle(Point.Empty, bg.Size));
					g.Dispose();
					this.BackgroundImage = bg;
				}
			}
		}

#if false
        private void DrawImage(Graphics g, Bitmap image)
        {
            float brightness = 1.0f;    // no change in brightness
            float contrast = 2.0f;      // twice the contrast
            float gamma = 1.0f;         // no change in gamma

            float adjBrightness = brightness - 1.0f;
            // create matrix that will brighten and contrast the image
            float[][] ptsArray ={
                    new float[] {contrast, 0, 0, 0, 0}, // scale red
                    new float[] {0, contrast, 0, 0, 0}, // scale green
                    new float[] {0, 0, contrast, 0, 0}, // scale blue
                    new float[] {0, 0, 0, 1.0f, 0},     // don't scale alpha
                    new float[] {adjBrightness, adjBrightness, adjBrightness, 0, 1}};

            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.ClearColorMatrix();
            imageAttributes.SetColorMatrix(new ColorMatrix(ptsArray), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            imageAttributes.SetGamma(gamma, ColorAdjustType.Bitmap);

            Rectangle rect = new Rectangle(Point.Empty, image.Size);
            g.DrawImage(image, rect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
        }
#endif

		private void SetForm(Form look, LookItem lookItem, bool visible) {
			look.Font = lookItem.font;
			look.BackColor = lookItem.bgColor;
			look.ForeColor = lookItem.fgColor;

			look.Visible = lookItem.visible = visible;

			look.BackgroundImageLayout = lookItem.imageLayout;
			look.BackgroundImage = null;

			if (lookItem.visible && lookItem.path.Length > 0) {
				try {
					string expandedPath = ExpandPath(lookItem.path);
					mainBgImage = new Bitmap(expandedPath);
					look.BackgroundImage = mainBgImage;
					BlendBackground(true);
				} catch { }
			}

			// Push opacity into all four sides
			int opacity = lookItem.length * 255 / 100;
			if (opacity == 0) {
				this.leftLookBtn.BackColor = Color.Transparent;
				this.rightLookBtn.BackColor = Color.Transparent;
				this.topLookBtn.BackColor = Color.Transparent;
				this.botLookBtn.BackColor = Color.Transparent;
			} else {
				this.leftLookBtn.BackColor = Color.FromArgb(opacity, this.leftLookBtn.BackColor);
				this.rightLookBtn.BackColor = Color.FromArgb(opacity, this.rightLookBtn.BackColor);
				this.topLookBtn.BackColor = Color.FromArgb(opacity, this.topLookBtn.BackColor);
				this.botLookBtn.BackColor = Color.FromArgb(opacity, this.botLookBtn.BackColor);
			}

			this.settings.leftLook.bgColor = this.leftLookBtn.BackColor;
			this.settings.rightLook.bgColor = this.rightLookBtn.BackColor;
			this.settings.topLook.bgColor = this.topLookBtn.BackColor;
			this.settings.botLook.bgColor = this.botLookBtn.BackColor;
		}

		#endregion

		#region ==== Tree Navigation

		private void LoadTree() {
			TreeNode rootDesktop = new TreeNode("Desktop", 2, 2);
			this.treeMain.Nodes.Add(rootDesktop);
			rootDesktop.Name = "Desktop";
			rootDesktop.Nodes.Add("");
			TreeNode myComputer = new TreeNode("My Computer", 4, 4);
			myComputer.Name = "My Computer";
			this.treeMain.Nodes.Add(myComputer);

			DriveInfo[] diList = DriveInfo.GetDrives();
			foreach (DriveInfo drive in diList) {
				if (drive.DriveType != DriveType.Fixed)
					continue;
				if (drive.IsReady == false)
					continue;

				TreeNode driveNode = new TreeNode(drive.Name);
				driveNode.Name = drive.Name;
				switch (drive.DriveType) {
					case DriveType.CDRom:
						driveNode.SelectedImageIndex = 1;
						driveNode.ImageIndex = 1;
						break;
					case DriveType.Network:
						driveNode.SelectedImageIndex = 5;
						driveNode.ImageIndex = 5;
						break;
					case DriveType.Removable:
						driveNode.SelectedImageIndex = 0;
						driveNode.ImageIndex = 0;
						break;
					default:
						driveNode.SelectedImageIndex = 3;
						driveNode.ImageIndex = 3;
						break;
				}
				driveNode.Nodes.Add("");  // dummy entry to force plus sign
				myComputer.Nodes.Add(driveNode);
			}

			this.treeMain.BeforeExpand += new TreeViewCancelEventHandler(treeMain_BeforeExpand);
			this.treeMain.MouseDown += new MouseEventHandler(treeMain_MouseDown);
		}

		void treeMain_MouseDown(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Right) {
				this.treeMain.SelectedNode = this.treeMain.GetNodeAt(e.X, e.Y);

				if (this.treeMain.SelectedNode.Tag != null) {
					ShellContextMenu ctxMnu = new ShellContextMenu();
					FileInfo[] arrFI = new FileInfo[1];
					arrFI[0] = new FileInfo(this.treeMain.SelectedNode.Tag.ToString());
					ctxMnu.ShowContextMenu(arrFI, this.PointToScreen(new Point(e.X, e.Y)));
				} else {
					ShellContextMenu ctxMnu = new ShellContextMenu();
					DirectoryInfo[] dir = new DirectoryInfo[1];
					dir[0] = new DirectoryInfo(GetFolderPath(this.treeMain.SelectedNode));
					ctxMnu.ShowContextMenu(dir, this.PointToScreen(new Point(e.X, e.Y)));
				}
			}
		}

		private void treeMain_BeforeExpand(object sender, TreeViewCancelEventArgs e) {
			if (e.Node.Text != "My Computer") {
				this.EnumerateDirectory(e.Node);
				if (this.filePathBox.Focused == false) {
					// this.filePathBox.Text = GetFolderPath(e.Node);
					LoadList(e.Node);
				}
			}
		}

		TreeNode viewNode;
		private void ViewPath(string path) {
			settings.homeDir = path;

			SetLook(topLookBtn, settings.topLook, layoutTopLookMenu.Checked);
			SetLook(botLookBtn, settings.botLook, layoutBottomLookMenu.Checked);
			SetSide(leftLookBtn, settings.leftLook, layoutLeftLookMenu.Checked);
			SetSide(rightLookBtn, settings.rightLook, layoutRightLookMenu.Checked);

			viewNode = this.treeMain.Nodes[1];
			ViewPath(path,
				this.treeMain.Nodes[1].Nodes,
				this.treeMain.Nodes[1].FullPath.Length + 1);

			treeMain.TopNode = viewNode;
			LoadList(treeMain.TopNode);

			// Update combo if new directory tree
			string dirPath = Path.GetDirectoryName(path);
			foreach (string dir in comboBox.Items) {
				if (dir == dirPath)
					return;
			}

			this.comboBox.Items.Clear();
			string subDir;
			while ((subDir = Path.GetDirectoryName(path)) != null) {
				this.comboBox.Items.Add(subDir);
				path = subDir;
			}
		}

		private void ViewPath(string path, TreeNodeCollection nodes, int skip) {
			foreach (TreeNode node in nodes) {
				string nodePath = Path.GetFullPath(node.FullPath.Substring(skip));
				status.Text = nodePath;

				if (0 == string.Compare(path, 0, nodePath, 0, nodePath.Length, true)) {
					if (node.Nodes.Count == 1)    // dummy entry 1 means more files
					{
						EnumerateDirectory(node);
					}

					viewNode = node;

					if (nodePath.Length == path.Length) {
						return;
					}

					node.Expand();  // enumerate call above because expand appears to be async/threaded.
					if (node.Nodes.Count >= 1)  // dummy entry 1 means more files.
					{
						ViewPath(path, node.Nodes, skip);
						return;
					}
				}
			}
		}

		private void LoadList(TreeNode node) {
			if (this.filePathBox.Focused == false) {
				this.doPathChange++;
				this.filePathBox.Text = GetFolderPath(node);
				this.doPathChange--;
			}

			this.dirStats = new DirStats();
			this.listView.Items.Clear();
			this.listView.BeginUpdate();

			foreach (TreeNode childNode in node.Nodes) {
				if (childNode.Tag != null) {
					// file
					string filePath = (string)childNode.Tag;
					try {
						FileInfo fileInfo = new FileInfo(filePath);
						AddList(fileInfo, childNode.ImageIndex);
					} catch { }
				} else {
					// directory
					string dirPath = GetFolderPath(childNode);
					try {
						DirectoryInfo subDirInfo = new DirectoryInfo(dirPath);
						int folderIconIdx = childNode.ImageIndex;    // 6
						AddList(subDirInfo, folderIconIdx);
					} catch { }
				}
			}

			this.listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			this.listView.EndUpdate();
		}

		private void EnumerateDirectory(TreeNode parentNode) {
			DirectoryInfo dirInfo;
			string path = GetFolderPath(parentNode);
			parentNode.Nodes.Clear();

			dirInfo = new DirectoryInfo(path);
			DirectoryInfo[] dirs = dirInfo.GetDirectories();
			Array.Sort(dirs, new DirectorySorter());
			foreach (DirectoryInfo subDirInfo in dirs) {
				int folderIconIdx = 6;
				bool isFolder = true;
				folderIconIdx = extractIcon.GetIcon(subDirInfo.FullName, isFolder, smallIcons, largeIcons);

				TreeNode node = new TreeNode(subDirInfo.Name, folderIconIdx, folderIconIdx);
				node.Name = subDirInfo.Name;
				node.Nodes.Add("");
				parentNode.Nodes.Add(node);
			}

			FileInfo[] files = dirInfo.GetFiles();
			Array.Sort(files, new FileSorter());
			foreach (FileInfo fileInfo in files) {
				int imgIndex = extractIcon.GetIcon(fileInfo.FullName, false, smallIcons, largeIcons);
				TreeNode node = new TreeNode(fileInfo.Name, imgIndex, imgIndex);
				node.Name = fileInfo.Name;
				node.Tag = fileInfo.FullName;
				parentNode.Nodes.Add(node);
			}
		}

		private static string GetFolderPath(TreeNode parentNode) {
			string[] pathSplit = parentNode.FullPath.Split('\\');
			string path = "";
			if (pathSplit[0] == "Desktop") {
				path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
				for (int a = 1; a < pathSplit.Length; a++) {
					if (pathSplit[a].Trim() != string.Empty) {
						path += pathSplit[a] + "\\";
					}
				}
			} else {
				for (int a = 1; a < pathSplit.Length; a++) {
					if (pathSplit[a].Trim() != string.Empty) {
						path += pathSplit[a] + "\\";
					}
				}
			}

			return path;
		}
		#endregion

		#region ==== List View
		string ToString(FileAttributes fattr) {
			string sattr = string.Empty;
			UInt32 fattrBits = (UInt32)fattr;

			if ((fattrBits & (UInt32)FileAttributes.System) != 0) sattr += "S";
			if ((fattrBits & (UInt32)FileAttributes.Hidden) != 0) sattr += "H";
			if ((fattrBits & (UInt32)FileAttributes.ReadOnly) != 0) sattr += "R";
			if ((fattrBits & (UInt32)FileAttributes.Compressed) != 0) sattr += "C";
			if ((fattrBits & (UInt32)FileAttributes.ReparsePoint) != 0) sattr += "L";
			return sattr;
		}

		private void AddList(DirectoryInfo dirInfo) {
			string dirPath = dirInfo.Root.FullName;
			try {
				if (dirInfo != null && dirInfo.Parent != null) {
					dirPath = dirInfo.Parent.FullName;
				}
			} catch (Exception ex) { }

			ListViewItem dirItem = listView.Items.Add("... ");
			dirItem.SubItems.Add(dirPath);
			dirItem.SubItems.Add(FolderTypeStr);
			dirItem.SubItems.Add("");       // size
			dirItem.SubItems.Add("");
			dirItem.SubItems.Add("");
			dirItem.SubItems.Add("");
			dirItem.SubItems.Add("owner");
			dirItem.ImageIndex = 6;
		}

		private void AddList(DirectoryInfo dirInfo, int imageIdx) {
			if (listView.Items.Count == 0)
				AddList(dirInfo.Parent);
			ListViewItem dirItem = listView.Items.Add(dirInfo.Name);
			dirItem.SubItems.Add(dirInfo.FullName);
			dirItem.SubItems.Add(FolderTypeStr);
			dirItem.SubItems.Add("");       // size
			dirItem.SubItems.Add(ToString(dirInfo.Attributes));
			dirItem.SubItems.Add(dirInfo.LastAccessTime.ToString(settings.dateFmt));
			dirItem.SubItems.Add(dirInfo.CreationTime.ToString(settings.dateFmt));
			dirItem.SubItems.Add("owner");
			dirItem.ImageIndex = imageIdx;

			dirStats.folderCnt++;
		}

		private void AddList(FileInfo fileInfo, int imageIdx) {
			if (listView.Items.Count == 0)
				AddList(fileInfo.Directory);

			string name = fileInfo.Name;
			if (fileInfo.Extension == ".lnk")
				name = Path.GetFileNameWithoutExtension(fileInfo.Name);

			ListViewItem fileItem = listView.Items.Add(name);
			fileItem.SubItems.Add(fileInfo.FullName);
			fileItem.SubItems.Add(fileInfo.Extension);
			fileItem.SubItems.Add(fileInfo.Length.ToString(settings.sizeFmt));    // size
			fileItem.SubItems.Add(ToString(fileInfo.Attributes));
			fileItem.SubItems.Add(fileInfo.LastWriteTime.ToString(settings.dateFmt));
			fileItem.SubItems.Add(fileInfo.CreationTime.ToString(settings.dateFmt));
			fileItem.SubItems.Add("owner?");
			fileItem.ImageIndex = imageIdx;

			dirStats.fileCnt++;
			dirStats.totalSize += (ulong)fileInfo.Length;
		}

		private void filePathBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
			if (e.KeyCode == Keys.Tab)
				e.IsInputKey = true;

			if (e.Control && e.KeyCode == Keys.F)
				filePathBox.Visible = false;
		}

		int doPathChange = 0;
		private void filePathBox_TextChanged(object sender, EventArgs e) {
			if (filePathBox.Text.Length > 2 && doPathChange == 0) {
				doPathChange++;
				string root = Path.GetPathRoot(filePathBox.Text);
				string adjPath = (root.Length < 2) ? settings.baseDir : string.Empty;
				ViewPath(adjPath + filePathBox.Text);
				doPathChange--;
			}
		}

		private void listView_SelectedIndexChanged(object sender, EventArgs e) {
			if (listView.SelectedItems.Count > 0) {
				status.Text = listView.SelectedItems[0].SubItems[1].Text;
				toolTip.Show(this.status.Text, this.status, 5000);
				Clipboard.SetText(status.Text);
			} else {
				status.Text = string.Format("Folders:{0} Files:{1} TotSize:{2:#,##0}",
					dirStats.folderCnt, dirStats.fileCnt, dirStats.totalSize);
			}
		}

		private void listView_MouseClick(object sender, MouseEventArgs e) {
			ListViewHitTestInfo hitInfo = listView.HitTest(e.Location);

			if (hitInfo.Item != null) {
				string fullPath = hitInfo.Item.SubItems[1].Text;


				if (e.Button == MouseButtons.Right) {
					WatchDir(Path.GetDirectoryName(fullPath));

					bool doFolder = (hitInfo.Item.SubItems[2].Text == FolderTypeStr);

					List<FileInfo> fileInfoList = new List<FileInfo>();
					List<DirectoryInfo> dirInfoList = new List<DirectoryInfo>();

					foreach (ListViewItem fileItem in listView.SelectedItems) {
						fullPath = fileItem.SubItems[1].Text;
						bool isFolder = (fileItem.SubItems[2].Text == FolderTypeStr);
						if (isFolder == doFolder) {
							if (isFolder) {

								DirectoryInfo dirInfo = new DirectoryInfo(fullPath);
								dirInfoList.Add(dirInfo);
							} else {
								FileInfo fileInfo = new FileInfo(fullPath);
								fileInfoList.Add(fileInfo);
							}
						} else {
							fileItem.Selected = false;
						}
					}

					ShellContextMenu ctxMnu = new ShellContextMenu();

					if (doFolder) {
						// DirectoryInfo[] dirArray = new DirectoryInfo[1] { new DirectoryInfo(fullPath) };
						DirectoryInfo[] dirArray = dirInfoList.ToArray();
						ctxMnu.ShowContextMenu(dirArray, listView.PointToScreen(e.Location));
					} else {
						// FileInfo[] fileArray = new FileInfo[1] { new FileInfo(fullPath) };
						FileInfo[] fileArray = fileInfoList.ToArray();
						ctxMnu.ShowContextMenu(fileArray, listView.PointToScreen(e.Location));
					}
				} else if (e.Button == MouseButtons.Left) {
					if (lockedMenu.Checked || hitInfo.Item.SubItems[2].Text != FolderTypeStr) {
						if (settings.launchFB && hitInfo.Item.SubItems[2].Text == FolderTypeStr)
							LaunchFolderBar(fullPath);

						Launch(fullPath);
					} else
						ViewPath(fullPath);
				}
			}
		}

		private void listView_KeyUp(object sender, KeyEventArgs e) {
			if (e.Control) {
				switch (e.KeyCode) {
					case Keys.A:
						foreach (ListViewItem fileItem in this.listView.Items)
							fileItem.Selected = true;
						break;
					case Keys.F:    // filter
						filePathBox.Visible = false;
						break;
				}
				return;
			}

			switch (e.KeyCode) {
				case Keys.Left:
					break;
			}
		}

		private void listView_MouseEnter(object sender, EventArgs e) {
			this.Opacity = 1.0;
		}

		private void listView_MouseLeave(object sender, EventArgs e) {
			this.Opacity = this.settings.listLook.length / 100f;
		}

		private void Launch(string filepath) {
			System.Environment.CurrentDirectory = Path.GetDirectoryName(filepath);
			try {
				System.Diagnostics.Process.Start(filepath);
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void LaunchFolderBar(string filepath) {
			System.Environment.CurrentDirectory = Path.GetDirectoryName(filepath);
			try {
				System.Diagnostics.Process.Start(Application.ExecutablePath, filepath);
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void LaunchExplorer(string filepath) {
			string dir = Path.GetDirectoryName(filepath);
			System.Diagnostics.Process.Start("explorer.exe", dir);
		}

		private void LaunchCmd(string filepath) {
			string dir = Path.GetDirectoryName(filepath);
			System.Diagnostics.Process.Start("cmd.exe", "/k cd \"" + dir + "\"");
		}
		#endregion

		#region ==== Context Menu

		private void hideFrame_Click(object sender, EventArgs e) {
			if (System.Windows.Forms.Control.ModifierKeys == Keys.Control) {
				if (this.FormBorderStyle == FormBorderStyle.Sizable)
					this.FormBorderStyle = FormBorderStyle.None;
				else
					this.FormBorderStyle = FormBorderStyle.Sizable;
			}
		}

		private void treeVisible_Click(object sender, EventArgs e) {
			string viewPath = filePathBox.Text;
			treeMain.Visible = splitter.Visible = !treeMain.Visible;
			ViewPath(viewPath);
		}

		private void view_Click(object sender, EventArgs e) {
			ToolStripDropDownItem dropItem = (ToolStripDropDownItem)sender;
			ToolStripDropDownMenu dropMenu = dropItem.DropDown.OwnerItem.Owner as ToolStripDropDownMenu;

			foreach (ToolStripDropDownItem item in dropMenu.Items) {
				System.Windows.Forms.ToolStripMenuItem itemBtn =
					(System.Windows.Forms.ToolStripMenuItem)item;
				if (dropItem != item) {
					itemBtn.Checked = false;
				}
			}

			switch (dropItem.Text) {
				case "List":
					listView.View = View.List;
					break;
				case "Details":
					listView.View = View.Details;
					break;
				case "LargeIcon":
					listView.View = View.LargeIcon;
					break;
				case "Tile32":
					listView.View = View.Tile;
					listView.TileSize = new Size(32, 32);
					break;
				case "Tile48":
					listView.View = View.Tile;
					listView.TileSize = new Size(48, 48);
					break;
			}
		}

		private void layout_Click(object sender, EventArgs e) {
			ToolStripDropDownItem dropItem = (ToolStripDropDownItem)sender;
			ToolStripDropDownMenu dropMenu = dropItem.DropDown.OwnerItem.Owner as ToolStripDropDownMenu;

			switch (dropItem.Text) {
				case "Frame":
					if (layoutFrameMenu.Checked)
						this.FormBorderStyle = FormBorderStyle.Sizable;
					else
						this.FormBorderStyle = FormBorderStyle.None;
					break;
				case "Tree Navigation":
					treeMain.Visible = splitter.Visible = layoutTreeMenu.Checked;
					break;
				case "File Navigation":
					fileRowPanel.Visible = layoutFileMenu.Checked;
					break;
				case "Status":
					status.Visible = layoutStatusMenu.Checked;
					break;
				case "List View":
					this.listView.Visible = layoutListMenu.Checked;
					break;
				case "Top Look":
					this.topLookBtn.Visible = layoutTopLookMenu.Checked;
					break;
				case "Bottom Look":
					this.botLookBtn.Visible = layoutBottomLookMenu.Checked;
					break;
				case "Left Look":
					this.leftLookBtn.Visible = layoutLeftLookMenu.Checked;
					break;
				case "Right Look":
					this.rightLookBtn.Visible = layoutRightLookMenu.Checked;
					break;
			}
		}

		private void saveExit_Click(object sender, EventArgs e) {
			saveMode = SaveMode.Save;
			this.Close();
		}
		private void exit_Click(object sender, EventArgs e) {
			saveMode = SaveMode.DontSave;
			this.Close();
		}

		private void lockedMenu_Click(object sender, EventArgs e) {
			layoutBtn.BackColor = lockedMenu.Checked ?
				Color.Red : Color.White;
		}

		private void dupMenu_Click(object sender, EventArgs e) {
			System.Diagnostics.Process.Start(Application.ExecutablePath, settings.homeDir);
		}

		private void setRegistryMenu_Click(object sender, EventArgs e) {
			UpdateRegistry();
		}

		#endregion

		#region ==== Misc Panel buttons and UIs
		private void backBtn_Click(object sender, EventArgs e) {
			if (treeMain != null && treeMain.TopNode != null) {
				TreeNode newTop = treeMain.TopNode.Parent;

				if (newTop != null &&
					newTop != this.treeMain.Nodes[1]) {
					treeMain.TopNode = newTop;
					ViewPath(GetFolderPath(newTop));
				}
			}
		}

		private void comboBox_SelectedIndexChanged(object sender, EventArgs e) {
			ViewPath((string)comboBox.SelectedItem);
		}

		private void profilesToolStripMenuItem_Click(object sender, EventArgs e) {
			ViewPath(Path.GetDirectoryName(SettingsFile()));
		}

		private void topLookBtn_MouseLeave(object sender, EventArgs e) {
			this.Cursor = Cursors.Default;
		}

		private void topLookBtn_MouseEnter(object sender, EventArgs e) {
			this.Cursor = Cursors.Cross;
			lastLoc = Point.Empty;
		}

		Point lastLoc = Point.Empty;
		private void topLookBtn_MouseMove(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Left) {
				Point mouseLoc = System.Windows.Forms.Control.MousePosition;

				if (lastLoc != Point.Empty) {
					Point delta = new Point(mouseLoc.X - lastLoc.X, mouseLoc.Y - lastLoc.Y);
					if (Math.Abs(delta.X) < 5 && Math.Abs(delta.Y) < 5)
						return;
					this.Location = new Point(Location.X + delta.X, Location.Y + delta.Y);
				}
				lastLoc = mouseLoc;
				return;
			}

			lastLoc = Point.Empty;
		}

		private void filePathBox_DoubleClick(object sender, EventArgs e) {
			filePathBox.SelectAll();
		}

		private void filterBox_KeyUp(object sender, KeyEventArgs e) {
			if (e.Control) {
				switch (e.KeyCode) {
					case Keys.P:        // path
						filePathBox.Visible = true;
						break;
					case Keys.R:        // refresh
						RefreshViewers();
						break;
				}
				return;
			}

			switch (e.KeyCode) {
				case Keys.Escape:
					filePathBox.Visible = true;
					break;

				case Keys.Enter:
					if (filterBox.Text.Length == 0) {
						RefreshViewers();
					} else {
						// to filter
						foreach (ListViewItem fileItem in listView.Items) {
							if (fileItem.Text.Contains(filterBox.Text) == false) {
								listView.Items.Remove(fileItem);
							}
						}
					}
					break;
			}
		}
		#endregion

		#region ==== Refresh
		private void refreshMenu_Click(object sender, EventArgs e) {
			RefreshViewers();
		}

		private void RefreshViewers() {
			refresh = false;
			EnumerateDirectory(treeMain.TopNode);
			LoadList(treeMain.TopNode);
		}

		private void timer_Tick(object sender, EventArgs e) {
			if (refresh) {
				RefreshViewers();
				// timer.Enabled = false;
			}

			if (mainBgImage != null) {
				BlendBackground(false);
			}

		}

		#region ==== Watcher 

		bool refresh = false;
		System.IO.FileSystemWatcher watcher;
		private void WatchDir(string dirPath) {
			if (watcher != null) {
				watcher.EnableRaisingEvents = false;
				watcher.Changed -= new FileSystemEventHandler(OnChanged);
				watcher.Created -= new FileSystemEventHandler(OnChanged);
				watcher.Deleted -= new FileSystemEventHandler(OnChanged);
				watcher.Renamed -= new RenamedEventHandler(OnChanged);
			}

			watcher = new System.IO.FileSystemWatcher();
			watcher.Filter = string.Empty;
			watcher.Path = dirPath;
			watcher.IncludeSubdirectories = false;
			watcher.NotifyFilter =
					NotifyFilters.LastAccess
					| NotifyFilters.LastWrite
					| NotifyFilters.FileName
					| NotifyFilters.DirectoryName;

			// watcher.Changed += new FileSystemEventHandler(OnChanged);
			watcher.Created += new FileSystemEventHandler(OnChanged);
			watcher.Deleted += new FileSystemEventHandler(OnChanged);
			watcher.Renamed += new RenamedEventHandler(OnChanged);
			watcher.EnableRaisingEvents = true;
		}

		/// <summary>
		/// File system event handlers
		/// </summary>
		private void OnChanged(object sender, FileSystemEventArgs e) {
			FileSystemWatcher watcher = (FileSystemWatcher)sender;
			watcher.EnableRaisingEvents = false;
			refresh = true;
		}
		#endregion

		private void saveSettingsMenu_Click(object sender, EventArgs e) {
			SaveSettings();
		}

		private void updateBackgrdMenu_Click(object sender, EventArgs e) {
			BlendBackground(true);
		}

		#endregion


		static public string ExpandPath(string filePath) {
			string path = Environment.ExpandEnvironmentVariables(filePath);
			string[] envNames = path.Split('%');

			if (envNames.Length > 1 && envNames[1].Length > 0) {
				string envName = "%" + envNames[1] + "%";
				string envPath = Environment.GetEnvironmentVariable(envNames[1]);
				if (envPath != null && envPath.Length > 0) {
					return path.Replace(envName, envPath);
				}
			}

			return path;
		}


	}
}