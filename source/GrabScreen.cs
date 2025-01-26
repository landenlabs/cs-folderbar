using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing;
using System.Drawing.Drawing2D;

using System.Runtime.InteropServices;
using System.Collections;
using System.Runtime.InteropServices.ComTypes;
using System.Globalization;
using System.Reflection;

namespace FolderBar_NS {
	class GrabScreen {
		/// <summary>
		/// Capture image of dialog (screen shot)
		/// </summary>
		/// <returns></returns>
		static public Bitmap GrabScreenImage(Form mainForm, Rectangle rect) {
			int color = Screen.PrimaryScreen.BitsPerPixel;
			PixelFormat pFormat;

			switch (color) {
				case 8:
				case 16:
					pFormat = PixelFormat.Format16bppRgb565;
					break;

				case 24:
					pFormat = PixelFormat.Format24bppRgb;
					break;

				case 32:
					pFormat = PixelFormat.Format32bppArgb;
					break;

				default:
					pFormat = PixelFormat.Format32bppArgb;
					break;
			}

			mainForm.Visible = false;
			Application.DoEvents();
			Bitmap bitmap = new Bitmap(rect.Width, rect.Height, pFormat);
			Graphics g = Graphics.FromImage(bitmap);
			g.Clear(Color.Transparent);
			// g.CompositingMode = CompositingMode.SourceCopy;
			g.CopyFromScreen(rect.Left, rect.Top, 0, 0, rect.Size);

			g.Dispose();

			mainForm.Visible = true;

			return bitmap;
		}

		static public Image PrintScreen() {
			keybd_event(0x2c, 0, 0, IntPtr.Zero);
			Application.DoEvents();
			Image image = Clipboard.GetImage();
			return image;
		}

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern IntPtr keybd_event(int key, int dummy, int flags, IntPtr info);

		static public Image CaptureScreen(Rectangle screenRect) {
			uint intReturn = 0;
			NativeWIN32.INPUT structInput;
			structInput = new NativeWIN32.INPUT();
			structInput.type = (uint)1;
			structInput.ki.wScan = 0;
			structInput.ki.time = 0;
			structInput.ki.dwFlags = 0;
			structInput.ki.dwExtraInfo = 0;

			//Press Alt Key 
			structInput.ki.wVk = (ushort)NativeWIN32.VK.MENU;
			intReturn = NativeWIN32.SendInput((uint)1, ref structInput, Marshal.SizeOf(structInput));

			// Key down the actual key-code 
			structInput.ki.wVk = (ushort)NativeWIN32.VK.SNAPSHOT;
			//vk; 
			intReturn = NativeWIN32.SendInput((uint)1, ref structInput, Marshal.SizeOf(structInput));

			// Key up the actual key-code 
			structInput.ki.dwFlags = NativeWIN32.KEYEVENTF_KEYUP;
			structInput.ki.wVk = (ushort)NativeWIN32.VK.SNAPSHOT;//vk; 
			intReturn = NativeWIN32.SendInput((uint)1, ref structInput, Marshal.SizeOf(structInput));

			//Keyup Alt 
			structInput.ki.dwFlags = NativeWIN32.KEYEVENTF_KEYUP;
			structInput.ki.wVk = (ushort)NativeWIN32.VK.MENU;
			intReturn = NativeWIN32.SendInput((uint)1, ref structInput, Marshal.SizeOf(structInput));

			System.Windows.Forms.IDataObject data = Clipboard.GetDataObject();

			if (data.GetDataPresent(DataFormats.Bitmap)) {
				Bitmap image = (Bitmap)data.GetData(DataFormats.Bitmap, true);
				image.Save("c:\\fullScreen" + ".png", System.Drawing.Imaging.ImageFormat.Png);

				Bitmap cutImage = new Bitmap(image, screenRect.Size);
				Graphics g = Graphics.FromImage(cutImage);
				g.Clear(Color.Transparent);
				g.DrawImageUnscaledAndClipped(image, screenRect);
				g.Dispose();

				cutImage.Save("c:\\folderBar" + ".png", System.Drawing.Imaging.ImageFormat.Png);

				// image.Save("image" + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);   
				// image.Save("image" + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
				// image.Save("image" + ".gif", System.Drawing.Imaging.ImageFormat.Gif);
				return cutImage;
			} else {
				// Console.WriteLine("The Data In Clipboard is not in an image format");
			}

			return null;
		}

		public class NativeWIN32 {
			public const ushort KEYEVENTF_KEYUP = 0x0002;

			public enum VK : ushort {
				SHIFT = 0x10,
				CONTROL = 0x11,
				MENU = 0x12,
				ESCAPE = 0x1B,
				BACK = 0x08,
				TAB = 0x09,
				RETURN = 0x0D,
				PRIOR = 0x21,
				NEXT = 0x22,
				END = 0x23,
				HOME = 0x24,
				LEFT = 0x25,
				UP = 0x26,
				RIGHT = 0x27,
				DOWN = 0x28,
				SELECT = 0x29,
				PRINT = 0x2A,
				EXECUTE = 0x2B,
				SNAPSHOT = 0x2C,
				INSERT = 0x2D,
				DELETE = 0x2E,
				HELP = 0x2F,
				NUMPAD0 = 0x60,
				NUMPAD1 = 0x61,
				NUMPAD2 = 0x62,
				NUMPAD3 = 0x63,
				NUMPAD4 = 0x64,
				NUMPAD5 = 0x65,
				NUMPAD6 = 0x66,
				NUMPAD7 = 0x67,
				NUMPAD8 = 0x68,
				NUMPAD9 = 0x69,
				MULTIPLY = 0x6A,
				ADD = 0x6B,
				SEPARATOR = 0x6C,
				SUBTRACT = 0x6D,
				DECIMAL = 0x6E,
				DIVIDE = 0x6F,
				F1 = 0x70,
				F2 = 0x71,
				F3 = 0x72,
				F4 = 0x73,
				F5 = 0x74,
				F6 = 0x75,
				F7 = 0x76,
				F8 = 0x77,
				F9 = 0x78,
				F10 = 0x79,
				F11 = 0x7A,
				F12 = 0x7B,
				OEM_1 = 0xBA,   // ',:' for US  
				OEM_PLUS = 0xBB,   // '+' any country  
				OEM_COMMA = 0xBC,   // ',' any country  
				OEM_MINUS = 0xBD,   // '-' any country  
				OEM_PERIOD = 0xBE,   // '.' any country  
				OEM_2 = 0xBF,   // '/?' for US  
				OEM_3 = 0xC0,   // '`~' for US  
				MEDIA_NEXT_TRACK = 0xB0,
				MEDIA_PREV_TRACK = 0xB1,
				MEDIA_STOP = 0xB2,
				MEDIA_PLAY_PAUSE = 0xB3,
				LWIN = 0x5B,
				RWIN = 0x5C
			}

			public struct KEYBDINPUT {
				public ushort wVk;
				public ushort wScan;
				public uint dwFlags;
				public long time;
				public uint dwExtraInfo;
			};

			[StructLayout(LayoutKind.Explicit, Size = 28)]
			public struct INPUT {
				[FieldOffset(0)]
				public uint type;
				[FieldOffset(4)]
				public KEYBDINPUT ki;
			};

			[DllImport("user32.dll")]
			public static extern uint SendInput(uint nInputs, ref INPUT pInputs, int cbSize);
		}
	}
}
