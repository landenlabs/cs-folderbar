using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FolderBar_NS {
	public partial class IconStyle : UserControl {
		public IconStyle() {
			InitializeComponent();
		}

		[CategoryAttribute("Appearance"),
		DescriptionAttribute("Depth")]
		public int Depth {
			get { return depth8.Checked ? 8 : (depth24.Checked ? 24 : 32); }
			set {
				depth8.Checked = depth24.Checked = depth32.Checked = false;
				if (value <= 8)
					depth8.Checked = true;
				else if (value <= 24)
					depth24.Checked = true;
				else
					depth32.Checked = true;
			}
		}

		[CategoryAttribute("Appearance"),
		DescriptionAttribute("ColorDepth")]
		public ColorDepth ColorDepth {
			get { return depth8.Checked ? ColorDepth.Depth8Bit : (depth24.Checked ? ColorDepth.Depth24Bit : ColorDepth.Depth32Bit); }
			set {
				depth8.Checked = depth24.Checked = depth32.Checked = false;
				switch (value) {
					case ColorDepth.Depth4Bit:
					case ColorDepth.Depth8Bit:
						depth8.Checked = true;
						break;
					case ColorDepth.Depth16Bit:
					case ColorDepth.Depth24Bit:
						depth24.Checked = true;
						break;
					case ColorDepth.Depth32Bit:
						depth32.Checked = true;
						break;
				}
			}
		}

		[CategoryAttribute("Appearance"),
		DescriptionAttribute("IconWidth")]
		public int IconWidth {
			get { return (int)this.widthNum.Value; }
			set { this.widthNum.Value = value; }
		}

		[CategoryAttribute("Appearance"),
		DescriptionAttribute("IconHeight")]
		public int IconHeight {
			get { return (int)this.heightNum.Value; }
			set { this.heightNum.Value = value; }
		}

		[CategoryAttribute("Appearance"),
		DescriptionAttribute("IconSize")]
		public Size IconSize {
			get { return new Size(IconWidth, IconHeight); }
			set { IconWidth = value.Width; IconHeight = value.Height; }
		}


	}
}
