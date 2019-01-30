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
	[Register("LGSideMenuHelper", true)]
	public unsafe partial class LGSideMenuHelper : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("LGSideMenuHelper");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public LGSideMenuHelper () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected LGSideMenuHelper (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal LGSideMenuHelper (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("animateWithDuration:animations:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void AnimateWithDuration (double duration, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action animations, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completion)
		{
			if (animations == null)
				throw new ArgumentNullException ("animations");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_animations;
			BlockLiteral block_animations;
			block_animations = new BlockLiteral ();
			block_ptr_animations = &block_animations;
			block_animations.SetupBlockUnsafe (Trampolines.SDAction.Handler, animations);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V0.Handler, completion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_Double_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("animateWithDuration:animations:completion:"), duration, (IntPtr) block_ptr_animations, (IntPtr) block_ptr_completion);
			block_ptr_animations->CleanupBlock ();
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("imageView:setImageSafe:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ImageView (global::UIKit.UIImageView imageView, global::UIKit.UIImage image)
		{
			if (imageView == null)
				throw new ArgumentNullException ("imageView");
			if (image == null)
				throw new ArgumentNullException ("image");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("imageView:setImageSafe:"), imageView.Handle, image.Handle);
		}
		
		[Export ("statusBarAppearanceUpdateAnimated:viewController:duration:hidden:style:animation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void StatusBarAppearanceUpdateAnimated (bool animated, global::UIKit.UIViewController viewController, double duration, bool hidden, global::UIKit.UIStatusBarStyle style, global::UIKit.UIStatusBarAnimation animation)
		{
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr_Double_bool_Int64_Int64 (class_ptr, Selector.GetHandle ("statusBarAppearanceUpdateAnimated:viewController:duration:hidden:style:animation:"), animated, viewController.Handle, duration, hidden, (Int64)style, (Int64)animation);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr_Double_bool_int_int (class_ptr, Selector.GetHandle ("statusBarAppearanceUpdateAnimated:viewController:duration:hidden:style:animation:"), animated, viewController.Handle, duration, hidden, (int)style, (int)animation);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsNotRetina {
			[Export ("isNotRetina")]
			get {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isNotRetina"));
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsPad {
			[Export ("isPad")]
			get {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isPad"));
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsPhone {
			[Export ("isPhone")]
			get {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isPhone"));
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsViewControllerBasedStatusBarAppearance {
			[Export ("isViewControllerBasedStatusBarAppearance")]
			get {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isViewControllerBasedStatusBarAppearance"));
			}
			
		}
		
	} /* class LGSideMenuHelper */
}
