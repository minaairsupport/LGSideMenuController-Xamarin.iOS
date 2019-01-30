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

namespace LGSideMenuController {
	[Register("LGSideMenuView", true)]
	public unsafe partial class LGSideMenuView : global::UIKit.UIView {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("LGSideMenuView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public LGSideMenuView () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public LGSideMenuView (NSCoder coder) : base (NSObjectFlag.Empty)
		{

			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected LGSideMenuView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal LGSideMenuView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithLayoutSubviewsHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe LGSideMenuView ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action layoutSubviewsHandler)
			: base (NSObjectFlag.Empty)
		{
			if (layoutSubviewsHandler == null)
				throw new ArgumentNullException ("layoutSubviewsHandler");
			BlockLiteral *block_ptr_layoutSubviewsHandler;
			BlockLiteral block_layoutSubviewsHandler;
			block_layoutSubviewsHandler = new BlockLiteral ();
			block_ptr_layoutSubviewsHandler = &block_layoutSubviewsHandler;
			block_layoutSubviewsHandler.SetupBlockUnsafe (Trampolines.SDAction.Handler, layoutSubviewsHandler);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithLayoutSubviewsHandler:"), (IntPtr) block_ptr_layoutSubviewsHandler), "initWithLayoutSubviewsHandler:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithLayoutSubviewsHandler:"), (IntPtr) block_ptr_layoutSubviewsHandler), "initWithLayoutSubviewsHandler:");
			}
			block_ptr_layoutSubviewsHandler->CleanupBlock ();
			
		}
		
		public partial class LGSideMenuViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal LGSideMenuViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new LGSideMenuViewAppearance Appearance {
			get { return new LGSideMenuViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new LGSideMenuViewAppearance GetAppearance<T> () where T: LGSideMenuView {
			return new LGSideMenuViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new LGSideMenuViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new LGSideMenuViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new LGSideMenuViewAppearance GetAppearance (UITraitCollection traits) {
			return new LGSideMenuViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new LGSideMenuViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new LGSideMenuViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new LGSideMenuViewAppearance GetAppearance<T> (UITraitCollection traits) where T: LGSideMenuView {
			return new LGSideMenuViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new LGSideMenuViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: LGSideMenuView{
			return new LGSideMenuViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class LGSideMenuView */
}
