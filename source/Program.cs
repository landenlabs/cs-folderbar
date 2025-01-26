using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FolderBar_NS {
	static class Program {
		/// <summary>
		/// Light weight File Explorer/Bar .
		/// Win7 lacks XP's file tool bars.
		/// 
		/// Run with no arguments or
		/// with directory path or
		/// with previously saved profile.fb
		/// 
		/// Author: Dennis Lang  2010       
		/// https://landenlabs.com/
		/// </summary>
		[STAThread]
		static void Main(string[] cmdLineArgs) {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FolderBar(cmdLineArgs));
		}
	}
}