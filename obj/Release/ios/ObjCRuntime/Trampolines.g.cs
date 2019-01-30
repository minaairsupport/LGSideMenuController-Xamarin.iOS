//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;

namespace ObjCRuntime {
	
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::LGSideMenuController.LGSideMenuAnimationsBlock))]
		internal delegate void DLGSideMenuAnimationsBlock (IntPtr block, IntPtr arg0, IntPtr arg1, double arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDLGSideMenuAnimationsBlock {
			static internal readonly DLGSideMenuAnimationsBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DLGSideMenuAnimationsBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1, double arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::LGSideMenuController.LGSideMenuAnimationsBlock) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<global::LGSideMenuController.LGSideMenuController> (arg0),  Runtime.GetNSObject<UIView> (arg1), arg2);
			}
		} /* class SDLGSideMenuAnimationsBlock */
		
		internal class NIDLGSideMenuAnimationsBlock {
			IntPtr blockPtr;
			DLGSideMenuAnimationsBlock invoker;
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDLGSideMenuAnimationsBlock (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DLGSideMenuAnimationsBlock> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			~NIDLGSideMenuAnimationsBlock ()
			{
				Runtime.ReleaseBlockOnMainThread (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::LGSideMenuController.LGSideMenuAnimationsBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::LGSideMenuController.LGSideMenuAnimationsBlock;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDLGSideMenuAnimationsBlock ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::LGSideMenuController.LGSideMenuController arg0, global::UIKit.UIView arg1, double arg2)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2);
			}
		} /* class NIDLGSideMenuAnimationsBlock */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::LGSideMenuController.LGSideMenuCompletionHandler))]
		internal delegate void DLGSideMenuCompletionHandler (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDLGSideMenuCompletionHandler {
			static internal readonly DLGSideMenuCompletionHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DLGSideMenuCompletionHandler))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::LGSideMenuController.LGSideMenuCompletionHandler) (descriptor->Target);
				if (del != null)
					del ();
			}
		} /* class SDLGSideMenuCompletionHandler */
		
		internal class NIDLGSideMenuCompletionHandler {
			IntPtr blockPtr;
			DLGSideMenuCompletionHandler invoker;
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDLGSideMenuCompletionHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DLGSideMenuCompletionHandler> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			~NIDLGSideMenuCompletionHandler ()
			{
				Runtime.ReleaseBlockOnMainThread (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::LGSideMenuController.LGSideMenuCompletionHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::LGSideMenuController.LGSideMenuCompletionHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDLGSideMenuCompletionHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke ()
			{
				invoker (blockPtr);
			}
		} /* class NIDLGSideMenuCompletionHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::LGSideMenuController.LGSideMenuHandler))]
		internal delegate void DLGSideMenuHandler (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDLGSideMenuHandler {
			static internal readonly DLGSideMenuHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DLGSideMenuHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::LGSideMenuController.LGSideMenuHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<global::LGSideMenuController.LGSideMenuController> (arg0),  Runtime.GetNSObject<UIView> (arg1));
			}
		} /* class SDLGSideMenuHandler */
		
		internal class NIDLGSideMenuHandler {
			IntPtr blockPtr;
			DLGSideMenuHandler invoker;
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDLGSideMenuHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DLGSideMenuHandler> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			~NIDLGSideMenuHandler ()
			{
				Runtime.ReleaseBlockOnMainThread (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::LGSideMenuController.LGSideMenuHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::LGSideMenuController.LGSideMenuHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDLGSideMenuHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::LGSideMenuController.LGSideMenuController arg0, global::UIKit.UIView arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDLGSideMenuHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action))]
		internal delegate void DAction (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDAction {
			static internal readonly DAction Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DAction))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action) (descriptor->Target);
				if (del != null)
					del ();
			}
		} /* class SDAction */
		
		internal class NIDAction {
			IntPtr blockPtr;
			DAction invoker;
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDAction (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DAction> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			~NIDAction ()
			{
				Runtime.ReleaseBlockOnMainThread (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDAction ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke ()
			{
				invoker (blockPtr);
			}
		} /* class NIDAction */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<bool>))]
		internal delegate void DActionArity1V0 (IntPtr block, bool obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V0 {
			static internal readonly DActionArity1V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V0))]
			static unsafe void Invoke (IntPtr block, bool obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<bool>) (descriptor->Target);
				if (del != null)
					del (obj);
			}
		} /* class SDActionArity1V0 */
		
		internal class NIDActionArity1V0 {
			IntPtr blockPtr;
			DActionArity1V0 invoker;
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity1V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V0> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			~NIDActionArity1V0 ()
			{
				Runtime.ReleaseBlockOnMainThread (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<bool> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<bool>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (bool obj)
			{
				invoker (blockPtr, obj);
			}
		} /* class NIDActionArity1V0 */
	}
}
