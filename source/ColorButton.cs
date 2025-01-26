using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FolderBar_NS {
	public class ColorButton : Button {
		public ColorButton() {
			this.Click += new EventHandler(ColorButton_Click);
			UpdateColorBox();
		}

		private Color m_color;

		[CategoryAttribute("Property Changed"),
		 DescriptionAttribute("Color change event")]
		public EventHandler changed;

		private void UpdateColorBox() {
			Size imgSize = new Size(16, 16);
			Rectangle imgRect = new Rectangle(Point.Empty, imgSize);
			this.Image = new Bitmap(imgSize.Width, imgSize.Height);
			Graphics g = Graphics.FromImage(this.Image);
			g.FillRectangle(new SolidBrush(m_color), imgRect);
			g.DrawRectangle(Pens.Black, imgRect);
			imgRect.Inflate(-1, -1);
			g.DrawRectangle(Pens.White, imgRect);
		}

		private void ColorButton_Click(object sender, EventArgs e) {
			ColorDialog colorDialog = new ColorDialog();
			colorDialog.AllowFullOpen = true;
			colorDialog.AnyColor = true;
			colorDialog.FullOpen = true;

			colorDialog.Color = Color;
			if (colorDialog.ShowDialog() == DialogResult.OK) {
				Color = colorDialog.Color;
				if (changed != null)
					changed(this, EventArgs.Empty);
			}
		}

		[CategoryAttribute("Data"),
		 DescriptionAttribute("Color")]
		public Color Color {
			get { return m_color; }
			set { m_color = value; UpdateColorBox(); }
		}

	}
}
