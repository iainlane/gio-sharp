// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class InputStream : GLib.Object {

		[Obsolete]
		protected InputStream(GLib.GType gtype) : base(gtype) {}
		public InputStream(IntPtr raw) : base(raw) {}

		protected InputStream() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern bool g_input_stream_has_pending(IntPtr raw);

		public bool HasPending { 
			get {
				bool raw_ret = g_input_stream_has_pending(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern unsafe bool g_input_stream_set_pending(IntPtr raw, out IntPtr error);

		public unsafe bool SetPending() {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_input_stream_set_pending(Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern unsafe bool g_input_stream_read_all(IntPtr raw, byte[] buffer, UIntPtr count, out UIntPtr bytes_read, IntPtr cancellable, out IntPtr error);

		public unsafe bool ReadAll(byte[] buffer, ulong count, out ulong bytes_read, GLib.Cancellable cancellable) {
			UIntPtr native_bytes_read;
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_input_stream_read_all(Handle, buffer, new UIntPtr (count), out native_bytes_read, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			bool ret = raw_ret;
			bytes_read = (ulong) native_bytes_read;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern unsafe IntPtr g_input_stream_read_finish(IntPtr raw, IntPtr result, out IntPtr error);

		public unsafe long ReadFinish(GLib.AsyncResult result) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_input_stream_read_finish(Handle, result == null ? IntPtr.Zero : result.Handle, out error);
			long ret = (long) raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern unsafe bool g_input_stream_close_finish(IntPtr raw, IntPtr result, out IntPtr error);

		public unsafe bool CloseFinish(GLib.AsyncResult result) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_input_stream_close_finish(Handle, result == null ? IntPtr.Zero : result.Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern unsafe bool g_input_stream_close(IntPtr raw, IntPtr cancellable, out IntPtr error);

		public unsafe bool Close(GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_input_stream_close(Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern unsafe IntPtr g_input_stream_skip_finish(IntPtr raw, IntPtr result, out IntPtr error);

		public unsafe long SkipFinish(GLib.AsyncResult result) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_input_stream_skip_finish(Handle, result == null ? IntPtr.Zero : result.Handle, out error);
			long ret = (long) raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern bool g_input_stream_is_closed(IntPtr raw);

		public bool IsClosed { 
			get {
				bool raw_ret = g_input_stream_is_closed(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern unsafe IntPtr g_input_stream_read(IntPtr raw, byte[] buffer, UIntPtr count, IntPtr cancellable, out IntPtr error);

		public unsafe long Read(byte[] buffer, ulong count, GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_input_stream_read(Handle, buffer, new UIntPtr (count), cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			long ret = (long) raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern unsafe IntPtr g_input_stream_skip(IntPtr raw, UIntPtr count, IntPtr cancellable, out IntPtr error);

		public unsafe long Skip(ulong count, GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_input_stream_skip(Handle, new UIntPtr (count), cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			long ret = (long) raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_input_stream_close_async(IntPtr raw, int io_priority, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public void CloseAsync(int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_input_stream_close_async(Handle, io_priority, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_input_stream_read_async(IntPtr raw, byte[] buffer, UIntPtr count, int io_priority, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public void ReadAsync(byte[] buffer, ulong count, int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_input_stream_read_async(Handle, buffer, new UIntPtr (count), io_priority, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_input_stream_skip_async(IntPtr raw, UIntPtr count, int io_priority, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public void SkipAsync(ulong count, int io_priority, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_input_stream_skip_async(Handle, new UIntPtr (count), io_priority, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern void g_input_stream_clear_pending(IntPtr raw);

		public void ClearPending() {
			g_input_stream_clear_pending(Handle);
		}

		[DllImport("libgio-2.0-0.dll")]
		static extern IntPtr g_input_stream_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_input_stream_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
