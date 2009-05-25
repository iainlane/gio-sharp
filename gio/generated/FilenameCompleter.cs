// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class FilenameCompleter : GLib.Object {

		[Obsolete]
		protected FilenameCompleter(GLib.GType gtype) : base(gtype) {}
		public FilenameCompleter(IntPtr raw) : base(raw) {}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_filename_completer_new();

		public FilenameCompleter () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (FilenameCompleter)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = g_filename_completer_new();
		}

		[GLib.CDeclCallback]
		delegate void GotCompletionDataVMDelegate (IntPtr filename_completer);

		static GotCompletionDataVMDelegate GotCompletionDataVMCallback;

		static void gotcompletiondata_cb (IntPtr filename_completer)
		{
			try {
				FilenameCompleter filename_completer_managed = GLib.Object.GetObject (filename_completer, false) as FilenameCompleter;
				filename_completer_managed.OnGotCompletionData ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideGotCompletionData (GLib.GType gtype)
		{
			if (GotCompletionDataVMCallback == null)
				GotCompletionDataVMCallback = new GotCompletionDataVMDelegate (gotcompletiondata_cb);
			OverrideVirtualMethod (gtype, "got-completion-data", GotCompletionDataVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.FilenameCompleter), ConnectionMethod="OverrideGotCompletionData")]
		protected virtual void OnGotCompletionData ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("got-completion-data")]
		public event System.EventHandler GotCompletionData {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "got-completion-data");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "got-completion-data");
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_filename_completer_get_completion_suffix(IntPtr raw, IntPtr initial_text);

		public string GetCompletionSuffix(string initial_text) {
			IntPtr native_initial_text = GLib.Marshaller.StringToPtrGStrdup (initial_text);
			IntPtr raw_ret = g_filename_completer_get_completion_suffix(Handle, native_initial_text);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_initial_text);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_filename_completer_get_completions(IntPtr raw, IntPtr initial_text);

		public string GetCompletions(string initial_text) {
			IntPtr native_initial_text = GLib.Marshaller.StringToPtrGStrdup (initial_text);
			IntPtr raw_ret = g_filename_completer_get_completions(Handle, native_initial_text);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_initial_text);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_filename_completer_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_filename_completer_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_filename_completer_set_dirs_only(IntPtr raw, bool dirs_only);

		public bool DirsOnly { 
			set {
				g_filename_completer_set_dirs_only(Handle, value);
			}
		}

#endregion
	}
}
