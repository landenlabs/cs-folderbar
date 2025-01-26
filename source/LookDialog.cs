using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FolderBar_NS {
	public partial class LookDialog : UserControl {
		public LookDialog() {
			InitializeComponent();

			imageLayoutCombo.Items.Clear();
			foreach (string s in Enum.GetNames(typeof(ImageLayout))) {
				imageLayoutCombo.Items.Add(s);
			}
			imageLayoutCombo.Text = Enum.GetName(typeof(ImageLayout), previewBtn.BackgroundImageLayout);

			textLayoutCombo.Items.Clear();
			foreach (string s in Enum.GetNames(typeof(ContentAlignment))) {
				textLayoutCombo.Items.Add(s);
			}
			textLayoutCombo.Text = Enum.GetName(typeof(ContentAlignment), previewBtn.TextAlign);

			fgColorBtn.Color = Color.Black;
			bgColorBtn.Color = Color.LightBlue;

			previewBtn.ForeColor = fgColorBtn.Color;
			previewBtn.BackColor = bgColorBtn.Color;

			fgColorBtn.changed += new EventHandler(fgChanged);
			bgColorBtn.changed += new EventHandler(bgChanged);

			ViewState = checkBox.Checked;
		}

		private void fgChanged(object sender, EventArgs e) {
			previewBtn.ForeColor = fgColorBtn.Color;
		}
		private void bgChanged(object sender, EventArgs e) {
			previewBtn.BackColor = bgColorBtn.Color;
		}

		const string titlePrefix = "____";

		[CategoryAttribute("Data"),
		   DescriptionAttribute("Title")]
		public string Title {
			get { return group.Text.Substring(titlePrefix.Length); }
			set { group.Text = titlePrefix + value; }
		}
		[CategoryAttribute("Data"),
		 DescriptionAttribute("TextAlign")]
		public ContentAlignment TextAlign {
			get { return previewBtn.TextAlign; }
			set { previewBtn.TextAlign = value; }
		}
		[CategoryAttribute("Data"),
		DescriptionAttribute("InsideFont")]
		public Font InsideFont {
			get { return previewBtn.Font; }
			set { previewBtn.Font = value; }
		}
		[CategoryAttribute("Data"),
		DescriptionAttribute("ImageLayout")]
		public ImageLayout ImageLayout {
			get { return previewBtn.BackgroundImageLayout; }
			set { previewBtn.BackgroundImageLayout = value; }
		}

		[CategoryAttribute("Data"),
			DescriptionAttribute("LookItem")]
		public FolderBar.LookItem LookItem {
			get {
				FolderBar.LookItem lookItem = new FolderBar.LookItem();
				lookItem.length = (int)lengthNum.Value;
				lookItem.imageLayout = previewBtn.BackgroundImageLayout;
				lookItem.path = imageBox.Text;

				lookItem.text = previewBtn.Text;
				lookItem.textAlign = previewBtn.TextAlign;
				lookItem.font = previewBtn.Font;

				lookItem.fgColor = previewBtn.ForeColor;
				lookItem.bgColor = previewBtn.BackColor;
				lookItem.visible = ViewState;

				return lookItem;
			}
			set {
				FolderBar.LookItem lookItem = value;
				if (lookItem == null)
					return;

				lengthNum.Value = lookItem.length;
				previewBtn.BackgroundImageLayout = lookItem.imageLayout;
				imageBox.Text = lookItem.path;

				LoadImage(lookItem.path);

				try {
					previewBtn.Text = textBox.Text = lookItem.text;
					previewBtn.TextAlign = lookItem.textAlign;
					previewBtn.Font = lookItem.font;
				} catch { }

				fgColorBtn.Color = previewBtn.ForeColor = lookItem.fgColor;
				bgColorBtn.Color = previewBtn.BackColor = lookItem.bgColor;
				ViewState = lookItem.visible;
			}
		}


		[CategoryAttribute("Data"),
		  DescriptionAttribute("ImagePath")]
		public string ImagePath {
			get { return imageBox.Text; }
			set { imageBox.Text = value; }
		}

		[CategoryAttribute("Data"),
		 DescriptionAttribute("Image")]
		public Image PreviewImage {
			get { return previewBtn.BackgroundImage; }
			set { previewBtn.BackgroundImage = value; }
		}

		[CategoryAttribute("Appearance"),
		  DescriptionAttribute("LengthLabel")]
		public string LengthLabel {
			get { return lengthLabel.Text; }
			set { lengthLabel.Text = value; }
		}

		[CategoryAttribute("Appearance"),
		 DescriptionAttribute("LengthVisible")]
		public bool LengthVisible {
			get { return lengthLabel.Visible; }
			set { lengthNum.Visible = lengthLabel.Visible = value; }
		}

		[CategoryAttribute("Appearance"),
		 DescriptionAttribute("LengthValue")]
		public int LengthValue {
			get { return (int)lengthNum.Value; }
			set { lengthNum.Value = value; }
		}

		[CategoryAttribute("Appearance"),
		DescriptionAttribute("FgColor")]
		public Color FgColor {
			get { return previewBtn.ForeColor; }
			set { previewBtn.ForeColor = fgColorBtn.Color = value; }
		}

		[CategoryAttribute("Appearance"),
		DescriptionAttribute("BgColor")]
		public Color BgColor {
			get { return previewBtn.BackColor; }
			set { previewBtn.BackColor = bgColorBtn.Color = value; }
		}

		[CategoryAttribute("Appearance"),
		 DescriptionAttribute("ViewState")]
		public bool ViewState {
			set {
				checkBox.Checked = group.Visible = value;
				checkBox.Text = (group.Visible) ? string.Empty : Title;
				this.Height = group.Visible ? 160 : checkBox.Height + 10;
			}
			get { return checkBox.Checked; }
		}

		private void LoadImage(string imagePath) {
			if (imagePath.Length > 0) {
				try {
					string expandedPath = FolderBar.ExpandPath(imagePath);
					Bitmap image = new Bitmap(expandedPath);
					imageBox.Text = imagePath;
					previewBtn.BackgroundImage = image;

					string envPath = Environment.GetEnvironmentVariable(FolderBar.FolderBarLookEnv);
					if (envPath == null || envPath.Length == 0) {
						Environment.SetEnvironmentVariable(FolderBar.FolderBarLookEnv,
							Path.GetDirectoryName(imagePath));
					}
				} catch (Exception ex) {
					// previewBtn.Text = ex.Message;
					previewBtn.BackgroundImage = null;
				}
			} else {
				previewBtn.BackgroundImage = null;
			}
		}

		private void loadImageBtn_Click(object sender, EventArgs e) {
			openFileDialog.FileName = FolderBar.ExpandPath(imageBox.Text);
			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				LoadImage(openFileDialog.FileName);
			}
		}

		private void imageBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
			if (e.KeyCode == Keys.Tab)
				e.IsInputKey = true;
		}

		private void imageBox_KeyUp(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				LoadImage(imageBox.Text);
			}
		}

		private void textBox_TextChanged(object sender, EventArgs e) {
			previewBtn.Text = textBox.Text;
		}

		private void fontBtn_Click(object sender, EventArgs e) {
			fontDialog.Font = previewBtn.Font;
			if (fontDialog.ShowDialog() == DialogResult.OK) {
				previewBtn.Font = fontDialog.Font;
			}
		}

		private void textLayoutCombo_SelectedIndexChanged(object sender, EventArgs e) {
			previewBtn.TextAlign =
				(ContentAlignment)Enum.Parse(typeof(ContentAlignment), textLayoutCombo.Text);
		}

		private void imageLayoutCombo_SelectedIndexChanged(object sender, EventArgs e) {
			previewBtn.BackgroundImageLayout =
				(ImageLayout)Enum.Parse(typeof(ImageLayout), imageLayoutCombo.Text);
		}

		private void checkBox_CheckedChanged(object sender, EventArgs e) {
			if (group.Visible != checkBox.Checked)
				ViewState = checkBox.Checked;
		}



	}
}
