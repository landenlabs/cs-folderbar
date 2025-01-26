using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


// Persistant settings using Serialization
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

// Access PathUnExpandEnvStrings
using System.Runtime.InteropServices;

namespace FolderBar_NS {
	public partial class SettingsDialog : Form {
		public SettingsDialog(Form _ownerForm) {
			ownerForm = _ownerForm;

			InitializeComponent();
			this.Text = FolderBar.ProductNameAndVersion() + " Settings";
			this.toolTip.SetToolTip(this.look, FolderBar.ProductNameAndVersion()
				+ "- By Dennis Lang");
		}

		Form ownerForm;
		[CategoryAttribute("Behavior"),
		DescriptionAttribute("Setting change event")]
		public EventHandler changed;

		public EventHandler restart;

		[CategoryAttribute("Property"),
		DescriptionAttribute("AutoStart FolderBar on login")]
		public bool AutoStart {
			get { return autoStartCk.Checked; }
			set { autoStartCk.Checked = value; }
		}

		[CategoryAttribute("Property"),
		DescriptionAttribute("Launch FolderBar")]
		public bool LaunchFB {
			get { return launchFBCk.Checked; }
			set { launchFBCk.Checked = value; }
		}

		public FolderBar.Settings Settings {
			get {
				FolderBar.Settings settings = new FolderBar.Settings();

				settings.lookDir = Environment.GetEnvironmentVariable(FolderBar.FolderBarLookEnv);

				// Make all "look" images relative to Look directory.
				if (settings.lookDir != null && settings.lookDir.Length > 0) {
					string envName = string.Format("%{0}%", FolderBar.FolderBarLookEnv);
					string envPath = settings.lookDir;

					topLook.ImagePath = topLook.ImagePath.Replace(envPath, envName);
					bottomLook.ImagePath = bottomLook.ImagePath.Replace(envPath, envName);
					listLook.ImagePath = listLook.ImagePath.Replace(envPath, envName);
					treeLook.ImagePath = treeLook.ImagePath.Replace(envPath, envName);
					leftLook.ImagePath = leftLook.ImagePath.Replace(envPath, envName);
					rightLook.ImagePath = rightLook.ImagePath.Replace(envPath, envName);
					mainLook.ImagePath = mainLook.ImagePath.Replace(envPath, envName);

				}

				settings.topLook = topLook.LookItem;
				settings.botLook = bottomLook.LookItem;
				settings.listLook = listLook.LookItem;
				settings.treeLook = treeLook.LookItem;
				settings.leftLook = leftLook.LookItem;
				settings.rightLook = rightLook.LookItem;
				settings.mainLook = mainLook.LookItem;
				settings.iconItem.size = iconStyle.IconSize;
				settings.iconItem.colorDepth = iconStyle.ColorDepth;
				settings.fileVisible = layoutFileBoxCk.Checked;
				settings.statusVisible = layoutStatusCk.Checked;
				settings.frameVisible = layoutFrameCk.Checked;

				settings.launchFB = LaunchFB;

				return settings;
			}

			set {
				topLook.LookItem = value.topLook;
				bottomLook.LookItem = value.botLook;
				listLook.LookItem = value.listLook;
				treeLook.LookItem = value.treeLook;
				leftLook.LookItem = value.leftLook;
				rightLook.LookItem = value.rightLook;
				mainLook.LookItem = value.mainLook;
				iconStyle.IconSize = value.iconItem.size;
				iconStyle.ColorDepth = value.iconItem.colorDepth;

				layoutFileBoxCk.Checked = value.fileVisible;
				layoutStatusCk.Checked = value.statusVisible;
				layoutFrameCk.Checked = value.frameVisible;

				LaunchFB = value.launchFB;
			}
		}

		private void applyBtn_Click(object sender, EventArgs e) {
			if (changed != null)
				changed(this, EventArgs.Empty);
		}

		private void cancelBtn_Click(object sender, EventArgs e) {
			this.Close();
		}

		protected override void OnClosing(CancelEventArgs e) {
			e.Cancel = true;
			base.OnClosing(e);
			this.Visible = false;
		}

		private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			System.Diagnostics.Process.Start(this.linkLabel.Text);
		}

		private void look_Click(object sender, EventArgs e) {
			System.Diagnostics.Process.Start(this.linkLabel.Text);
		}

		private void restartAllBtn_Click(object sender, EventArgs e) {
			if (restart != null)
				restart(this, EventArgs.Empty);
		}

		static bool ArrayEqual(byte[] a1, int offset1, byte[] a2, int len) {
			int offset2 = 0;
			while (len-- > 0)
				if (a1[offset1++] != a2[offset2++])
					return false;
			return true;
		}

		private void loadLookBtn_Click(object sender, EventArgs e) {
			if (openLookDialog.ShowDialog() == DialogResult.OK) {
				string filename = openLookDialog.FileName;
				FolderBar.Settings settings;
				try {
					Stream stream = File.OpenRead(filename);
					try {
						Image image = Bitmap.FromStream(stream);

						// Calculate size of image in stream to set position for
						// our settings.
						MemoryStream memStream = new MemoryStream();
						image.Save(memStream, System.Drawing.Imaging.ImageFormat.Png);
						long pos = memStream.Position;
						stream.Position = pos;

						// Due to some changes in how PNG is loaded the legacy saved settings files are not directly 
						// after the PNG. Thee following code searches for the start of the binary serialized data. 

						byte[] buffer = new byte[4196];
						byte[] HEADER = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00, 0xff, 0xff, 0xff, 0xff, 0x01, 0x00, 0x00, 0x00 };
						int readLen = stream.Read(buffer, 0, buffer.Length);
						for (int idx = 0; idx < readLen - HEADER.Length; idx++) {
							if (ArrayEqual(buffer, idx, HEADER, HEADER.Length)) {
								stream.Position = pos + idx;
								break;
							}
						}

						/*
						   Binary serialization starts with
						     It consists of SerializationHeaderRecord
								RecordTypeEnum (1 byte)  00 represents the RecordTypeEnumeration which is SerializationHeaderRecord
								RootId (4 bytes)         01 00 00 00 represents the RootId
								HeaderId (4 bytes)       FF FF FF FF represents the HeaderId
								MajorVersion (4 bytes)   01 00 00 00 represents the MajorVersion
								MinorVersion (4 bytes)   00 00 00 00 represents the MinorVersion

						     Then the BinaryRecordHeader
								RecordTypeEnum (1 byte)  0C RecordTypeEnumeration
								LibraryId (4 bytes)      02 00 00 00 represents the LibraryId which is 2 in our case.
								LibraryName              (LengthPrefixedString byte, then string)
					
						       00 
						       01 00 00 00 
						       FF FF FF FF 
						       01 00 00 00 
						       00 00 00 00

						       0C 
							   02 00 00 00
						       40 = 64 characters
							   46 6F 6C 64 65 72 42 61 72 2C 20 56 65 72 73 69
						       6F 6E 3D 31 2E 34 2E 30 2E 30 2C 20 43 75 6C 74
							   75 72 65 3D 6E 65 75 74 72 61 6C 2C 20 50 75 62
						       6C 69 63 4B 65 79 54 6F 6B 65 6E 3D 6E 75 6C 6C
						       
						       @FolderBar, Version=1.4.0.0, Culture=neutral, PublicKeyToken=null
							    1234567890123456789012345678901234567890123456789012345678901234  
						                 1         2         3         4         5         6       
						 */
						BinaryFormatter bFormatter = new BinaryFormatter();
						bFormatter.AssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple;

						Object obj = bFormatter.Deserialize(stream);
						settings = (FolderBar.Settings)obj;
						Settings = settings;

						Environment.SetEnvironmentVariable(FolderBar.FolderBarLookEnv,
							Path.GetDirectoryName(filename));
					} catch (Exception ex) {
						MessageBox.Show(string.Format("Unable to load look {0}, error {1}", filename, ex.Message));
					}
					stream.Close();
				} catch (Exception ex) {
					MessageBox.Show(ex.Message);
				}

			}
		}

		private void saveLookBtn_Click(object sender, EventArgs e) {
			if (saveLookDialog.ShowDialog() == DialogResult.OK) {
				string FileName = saveLookDialog.FileName;
				try {
					Stream stream = File.OpenWrite(FileName);
					this.Visible = false;
					Bitmap lookImage = new Bitmap(this.ownerForm.Width, this.ownerForm.Height);
					this.ownerForm.DrawToBitmap(lookImage, new Rectangle(Point.Empty, lookImage.Size));
					lookImage.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
					this.Visible = true;

					long pos = stream.Position;

					// Make all "look" images relative to Look directory.
					string lookPath = Environment.GetEnvironmentVariable(FolderBar.FolderBarLookEnv);
					if (lookPath == null || lookPath.Length == 0)
						Environment.SetEnvironmentVariable(FolderBar.FolderBarLookEnv,
						Path.GetDirectoryName(FileName));

					// Pull settings again to get updated paths.
					FolderBar.Settings settings = Settings;
#if false
                    // ToDo - save look images with look profile
                    List<Image> lookImageList = new List<Image>();
                    lookImageList.Add(topLook.PreviewImage);
                    lookImageList.Add(bottomLook.PreviewImage); 
                    lookImageList.Add(listLook.PreviewImage); 
                    lookImageList.Add(treeLook.PreviewImage); 
                    lookImageList.Add(leftLook.PreviewImage); 
                    lookImageList.Add(rightLook.PreviewImage);
                    lookImageList.Add(mainLook.PreviewImage); 
#endif

					BinaryFormatter bFormatter = new BinaryFormatter();
					bFormatter.Serialize(stream, settings);

					stream.Close();
				} catch (Exception ex) {
					MessageBox.Show(ex.Message);
				}
			}
		}


		[DllImport("shlwapi.dll", CharSet = CharSet.Auto)]
		static extern bool PathUnExpandEnvStrings(string pszPath, [Out] StringBuilder pszBuf, int cchBuf);

		static public string PathUnExpand(string inString) {
			StringBuilder sb = new StringBuilder(4096);
			bool b = PathUnExpandEnvStrings(inString, sb, sb.Capacity);
			return (b ? sb.ToString() : inString);
		}


	}
}
