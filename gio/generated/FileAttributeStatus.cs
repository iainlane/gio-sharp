// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (GLib.FileAttributeStatusGType))]
	public enum FileAttributeStatus {

		Unset,
		Set,
		ErrorSetting,
	}

	internal class FileAttributeStatusGType {
		[DllImport ("libgio-2.0-0.dll")]
		static extern IntPtr g_file_attribute_status_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_file_attribute_status_get_type ());
			}
		}
	}
#endregion
}
