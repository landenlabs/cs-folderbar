using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.IO;

// Registry manipulation
using Microsoft.Win32;

namespace FolderBar_NS {
	// <summary>
	/// Enables or disables the autostart (with the OS) of the application.
	/// </summary>
	public static class AutoStarter {
		private const string RUN_LOCATION = @"Software\Microsoft\Windows\CurrentVersion\Run";
		private const string VALUE_NAME = "FolderBar";

		/// <summary>
		/// Set the autostart value for the assembly.
		/// </summary>
		public static void SetAutoStart() {
			RegistryKey key = Registry.CurrentUser.CreateSubKey(RUN_LOCATION);
			key.SetValue(VALUE_NAME, "\"" + Application.ExecutablePath + "\"" + " -autoStart");
			// key.SetValue(VALUE_NAME, Assembly.GetExecutingAssembly().Location);
		}

		/// <summary>
		/// Returns whether auto start is enabled.
		/// </summary>
		public static bool IsAutoStartEnabled {
			get {
				RegistryKey key = Registry.CurrentUser.OpenSubKey(RUN_LOCATION);
				if (key == null)
					return false;

				string value = (string)key.GetValue(VALUE_NAME);
				if (value == null)
					return false;
				return (value.Contains(Application.ExecutablePath));
			}
		}

		/// <summary>
		/// Unsets the autostart value for the assembly.
		/// </summary>
		public static void UnSetAutoStart() {
			RegistryKey key = Registry.CurrentUser.CreateSubKey(RUN_LOCATION);
			key.DeleteValue(VALUE_NAME);
		}
	}
}
