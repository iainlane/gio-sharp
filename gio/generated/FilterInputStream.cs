// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class FilterInputStream : GLib.InputStream {

		[Obsolete]
		protected FilterInputStream(GLib.GType gtype) : base(gtype) {}
		public FilterInputStream(IntPtr raw) : base(raw) {}

		protected FilterInputStream() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_filter_input_stream_get_base_stream(IntPtr raw);

		[GLib.Property ("base-stream")]
		public GLib.InputStream BaseStream {
			get  {
				IntPtr raw_ret = g_filter_input_stream_get_base_stream(Handle);
				GLib.InputStream ret = GLib.Object.GetObject(raw_ret) as GLib.InputStream;
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_filter_input_stream_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_filter_input_stream_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
