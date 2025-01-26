using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace FolderBar_NS {
	class ExtractIcon {
		public ExtractIcon() {
			// Populate file type and icon table.
			iconsInfo = RegisteredFileType.GetFileTypeAndIcon();
		}

		// Registered file type table.
		Dictionary<string, string> iconsInfo;

		// Cache of icon extension's  image index.
		Dictionary<string, int> extIcons = new Dictionary<string, int>();

		/// <summary>
		/// Get small and large icon associated with file extension or folder
		/// </summary>
		/// <param name="name"></param>
		/// <param name="folderIcon">true=get Folder or link icon</param>
		/// <param name="smallIcons"></param>
		/// <param name="largeIcons"></param>
		/// <returns></returns>
		public int GetIcon(string name, bool folderIcon, ImageList smallIcons, ImageList largeIcons) {
			int iconIndex;
			string ext = Path.GetExtension(name).ToLower();

			if (ext.Length > 0) {
				// Check if icon already loaded. Don't cache exe or lnk 
				if (!folderIcon && ext != ".exe" && ext != ".lnk"
					&& this.extIcons.TryGetValue(ext, out iconIndex))
					return iconIndex;

				// Get registered file icon
				iconIndex = GetRegIcon(ext, smallIcons, largeIcons);
				if (iconIndex != -1)
					return iconIndex;
			}

			// Get shell file icon
			return GetShellIcon(name, folderIcon, smallIcons, largeIcons);
		}

		/// <summary>
		///  Get registered icons.
		/// </summary>
		/// <param name="ext"></param>
		/// <param name="smallIcons"></param>
		/// <param name="largeIcons"></param>
		/// <returns></returns>
		public int GetRegIcon(string ext, ImageList smallIcons, ImageList largeIcons) {
			try {
				string fileAndParam;
				if (this.iconsInfo.TryGetValue(ext, out fileAndParam)) {
					if (String.IsNullOrEmpty(fileAndParam))
						return -1;

					int iconIdx = RegisteredFileType.ExtractIconFromFile(fileAndParam, smallIcons, largeIcons);
					if (iconIdx != -1 && ext != ".exe" && ext != ".lnk")
						this.extIcons.Add(ext, iconIdx);

					return iconIdx;
				}
			} catch (Exception ex) {
				// throw ex;
			}

			return -1;
		}


		/// <summary>
		/// Gets the Shell Icon for the given file...
		/// </summary>
		/// <param name="name">Path to file.</param>
		/// <param name="linkOverlay">Link Overlay</param>
		/// <returns>Icon</returns>
		public int GetShellIcon(string name, bool folderIcon, ImageList smallImages, ImageList largeImages) {
			int iconIndex;
			string ext = Path.GetExtension(name);

			// Check if icon already loaded. Don't cache exe or lnk 
			if (!folderIcon && ext != ".exe" && ext != ".lnk"
				&& this.extIcons.TryGetValue(ext, out iconIndex))
				return iconIndex;

			// Icon ico1 = Icon.ExtractAssociatedIcon(name);

			Shell32.SHFILEINFO shfi = new Shell32.SHFILEINFO();
			uint flags = Shell32.SHGFI_ICON | Shell32.SHGFI_USEFILEATTRIBUTES;
			uint dwAttr = Shell32.FILE_ATTRIBUTE_NORMAL;

			if (folderIcon) {
				flags = Shell32.SHGFI_ICON | Shell32.SHGFI_OPENICON;
				// flags += Shell32.SHGFI_LINKOVERLAY;
				// dwAttr = Shell32.FILE_ATTRIBUTE_DIRECTORY;
				dwAttr = 0;
			}
			if (ext == ".lnk")
				flags += Shell32.SHGFI_LINKOVERLAY;

			Shell32.SHGetFileInfo(name,
				dwAttr,
				ref shfi,
				(uint)System.Runtime.InteropServices.Marshal.SizeOf(shfi),
				flags + Shell32.SHGFI_SMALLICON);

			// Check if we already have folder icon.
			int iconKey = 0;
			if (folderIcon) {
				iconKey = shfi.iIcon;
				if (folderImageIndex.TryGetValue(iconKey, out iconIndex))
					return iconIndex;
			}

			// Clone  returned icon, Destroy original Icon
			Icon smallIcon = (System.Drawing.Icon)System.Drawing.Icon.FromHandle(shfi.hIcon).Clone();
			User32.DestroyIcon(shfi.hIcon);

			Shell32.SHGetFileInfo(name,
				dwAttr,
				ref shfi,
				(uint)System.Runtime.InteropServices.Marshal.SizeOf(shfi),
				flags + Shell32.SHGFI_LARGEICON);

			// Clone  returned icon, Destroy original Icon
			Icon largeIcon = (System.Drawing.Icon)System.Drawing.Icon.FromHandle(shfi.hIcon).Clone();
			User32.DestroyIcon(shfi.hIcon);

			// Add new image to lists
			iconIndex = smallImages.Images.Count;
			smallImages.Images.Add(smallIcon);
			largeImages.Images.Add(largeIcon);

			// Update image index database
			if (!folderIcon && ext != ".exe" && ext != ".lnk")
				this.extIcons.Add(ext, iconIndex);
			else if (folderIcon)
				folderImageIndex.Add(iconKey, iconIndex);

			return iconIndex;
		}

		Dictionary<int, int> folderImageIndex = new Dictionary<int, int>();
	}
}
