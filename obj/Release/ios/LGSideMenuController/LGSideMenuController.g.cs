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
	[Register("LGSideMenuController", true)]
	public unsafe partial class LGSideMenuController : global::UIKit.UIViewController {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("LGSideMenuController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public LGSideMenuController () : base (NSObjectFlag.Empty)
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
		public LGSideMenuController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected LGSideMenuController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal LGSideMenuController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithRootViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public LGSideMenuController (global::UIKit.UIViewController rootViewController)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithRootViewController:"), rootViewController == null ? IntPtr.Zero : rootViewController.Handle), "initWithRootViewController:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithRootViewController:"), rootViewController == null ? IntPtr.Zero : rootViewController.Handle), "initWithRootViewController:");
			}
		}
		
		[Export ("initWithRootViewController:leftViewController:rightViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public LGSideMenuController (global::UIKit.UIViewController rootViewController, global::UIKit.UIViewController leftViewController, global::UIKit.UIViewController rightViewController)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithRootViewController:leftViewController:rightViewController:"), rootViewController == null ? IntPtr.Zero : rootViewController.Handle, leftViewController == null ? IntPtr.Zero : leftViewController.Handle, rightViewController == null ? IntPtr.Zero : rightViewController.Handle), "initWithRootViewController:leftViewController:rightViewController:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithRootViewController:leftViewController:rightViewController:"), rootViewController == null ? IntPtr.Zero : rootViewController.Handle, leftViewController == null ? IntPtr.Zero : leftViewController.Handle, rightViewController == null ? IntPtr.Zero : rightViewController.Handle), "initWithRootViewController:leftViewController:rightViewController:");
			}
		}
		
		[Export ("initWithRootView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public LGSideMenuController (global::UIKit.UIView rootView)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithRootView:"), rootView == null ? IntPtr.Zero : rootView.Handle), "initWithRootView:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithRootView:"), rootView == null ? IntPtr.Zero : rootView.Handle), "initWithRootView:");
			}
		}
		
		[Export ("initWithRootView:leftView:rightView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public LGSideMenuController (global::UIKit.UIView rootView, global::UIKit.UIView leftView, global::UIKit.UIView rightView)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithRootView:leftView:rightView:"), rootView == null ? IntPtr.Zero : rootView.Handle, leftView == null ? IntPtr.Zero : leftView.Handle, rightView == null ? IntPtr.Zero : rightView.Handle), "initWithRootView:leftView:rightView:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithRootView:leftView:rightView:"), rootView == null ? IntPtr.Zero : rootView.Handle, leftView == null ? IntPtr.Zero : leftView.Handle, rightView == null ? IntPtr.Zero : rightView.Handle), "initWithRootView:leftView:rightView:");
			}
		}
		
		[Export ("hideLeftView")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HideLeftView ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("hideLeftView"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hideLeftView"));
			}
		}
		
		[Export ("hideLeftView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HideLeftView (NSObject sender)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("hideLeftView:"), sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("hideLeftView:"), sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("hideLeftViewAnimated")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HideLeftViewAnimated ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("hideLeftViewAnimated"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hideLeftViewAnimated"));
			}
		}
		
		[Export ("hideLeftViewAnimated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HideLeftViewAnimated (NSObject sender)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("hideLeftViewAnimated:"), sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("hideLeftViewAnimated:"), sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("hideLeftViewAnimated:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HideLeftViewAnimated (bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDLGSideMenuCompletionHandler))]LGSideMenuCompletionHandler completionHandler)
		{
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlockUnsafe (Trampolines.SDLGSideMenuCompletionHandler.Handler, completionHandler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr (this.Handle, Selector.GetHandle ("hideLeftViewAnimated:completionHandler:"), animated, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("hideLeftViewAnimated:completionHandler:"), animated, (IntPtr) block_ptr_completionHandler);
			}
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("hideLeftViewAnimated:delay:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HideLeftViewAnimated (bool animated, double delay, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDLGSideMenuCompletionHandler))]LGSideMenuCompletionHandler completionHandler)
		{
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlockUnsafe (Trampolines.SDLGSideMenuCompletionHandler.Handler, completionHandler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_Double_IntPtr (this.Handle, Selector.GetHandle ("hideLeftViewAnimated:delay:completionHandler:"), animated, delay, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_Double_IntPtr (this.SuperHandle, Selector.GetHandle ("hideLeftViewAnimated:delay:completionHandler:"), animated, delay, (IntPtr) block_ptr_completionHandler);
			}
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("hideRightView")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HideRightView ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("hideRightView"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hideRightView"));
			}
		}
		
		[Export ("hideRightView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HideRightView (NSObject sender)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("hideRightView:"), sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("hideRightView:"), sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("hideRightViewAnimated")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HideRightViewAnimated ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("hideRightViewAnimated"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hideRightViewAnimated"));
			}
		}
		
		[Export ("hideRightViewAnimated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HideRightViewAnimated (NSObject sender)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("hideRightViewAnimated:"), sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("hideRightViewAnimated:"), sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("hideRightViewAnimated:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HideRightViewAnimated (bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDLGSideMenuCompletionHandler))]LGSideMenuCompletionHandler completionHandler)
		{
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlockUnsafe (Trampolines.SDLGSideMenuCompletionHandler.Handler, completionHandler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr (this.Handle, Selector.GetHandle ("hideRightViewAnimated:completionHandler:"), animated, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("hideRightViewAnimated:completionHandler:"), animated, (IntPtr) block_ptr_completionHandler);
			}
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("hideRightViewAnimated:delay:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HideRightViewAnimated (bool animated, double delay, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDLGSideMenuCompletionHandler))]LGSideMenuCompletionHandler completionHandler)
		{
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlockUnsafe (Trampolines.SDLGSideMenuCompletionHandler.Handler, completionHandler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_Double_IntPtr (this.Handle, Selector.GetHandle ("hideRightViewAnimated:delay:completionHandler:"), animated, delay, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_Double_IntPtr (this.SuperHandle, Selector.GetHandle ("hideRightViewAnimated:delay:completionHandler:"), animated, delay, (IntPtr) block_ptr_completionHandler);
			}
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("isLeftViewAlwaysVisibleForOrientation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsLeftViewAlwaysVisibleForOrientation (global::UIKit.UIInterfaceOrientation orientation)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("isLeftViewAlwaysVisibleForOrientation:"), (Int64)orientation);
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSend_int (this.Handle, Selector.GetHandle ("isLeftViewAlwaysVisibleForOrientation:"), (int)orientation);
				}
			} else {
				if (IntPtr.Size == 8) {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("isLeftViewAlwaysVisibleForOrientation:"), (Int64)orientation);
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("isLeftViewAlwaysVisibleForOrientation:"), (int)orientation);
				}
			}
		}
		
		[Export ("isRightViewAlwaysVisibleForOrientation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsRightViewAlwaysVisibleForOrientation (global::UIKit.UIInterfaceOrientation orientation)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("isRightViewAlwaysVisibleForOrientation:"), (Int64)orientation);
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSend_int (this.Handle, Selector.GetHandle ("isRightViewAlwaysVisibleForOrientation:"), (int)orientation);
				}
			} else {
				if (IntPtr.Size == 8) {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("isRightViewAlwaysVisibleForOrientation:"), (Int64)orientation);
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("isRightViewAlwaysVisibleForOrientation:"), (int)orientation);
				}
			}
		}
		
		[Export ("leftViewWillLayoutSubviewsWithSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LeftViewWillLayoutSubviewsWithSize (CGSize size)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_CGSize (this.Handle, Selector.GetHandle ("leftViewWillLayoutSubviewsWithSize:"), size);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_CGSize (this.SuperHandle, Selector.GetHandle ("leftViewWillLayoutSubviewsWithSize:"), size);
			}
		}
		
		[Export ("rightViewWillLayoutSubviewsWithSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RightViewWillLayoutSubviewsWithSize (CGSize size)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_CGSize (this.Handle, Selector.GetHandle ("rightViewWillLayoutSubviewsWithSize:"), size);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_CGSize (this.SuperHandle, Selector.GetHandle ("rightViewWillLayoutSubviewsWithSize:"), size);
			}
		}
		
		[Export ("rootViewWillLayoutSubviewsWithSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RootViewWillLayoutSubviewsWithSize (CGSize size)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_CGSize (this.Handle, Selector.GetHandle ("rootViewWillLayoutSubviewsWithSize:"), size);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_CGSize (this.SuperHandle, Selector.GetHandle ("rootViewWillLayoutSubviewsWithSize:"), size);
			}
		}
		
		[Export ("showLeftView")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowLeftView ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("showLeftView"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showLeftView"));
			}
		}
		
		[Export ("showLeftView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowLeftView (NSObject sender)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("showLeftView:"), sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("showLeftView:"), sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("showLeftViewAnimated")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowLeftViewAnimated ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("showLeftViewAnimated"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showLeftViewAnimated"));
			}
		}
		
		[Export ("showLeftViewAnimated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowLeftViewAnimated (NSObject sender)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("showLeftViewAnimated:"), sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("showLeftViewAnimated:"), sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("showLeftViewAnimated:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ShowLeftViewAnimated (bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDLGSideMenuCompletionHandler))]LGSideMenuCompletionHandler completionHandler)
		{
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlockUnsafe (Trampolines.SDLGSideMenuCompletionHandler.Handler, completionHandler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr (this.Handle, Selector.GetHandle ("showLeftViewAnimated:completionHandler:"), animated, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("showLeftViewAnimated:completionHandler:"), animated, (IntPtr) block_ptr_completionHandler);
			}
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("showLeftViewAnimated:delay:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ShowLeftViewAnimated (bool animated, double delay, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDLGSideMenuCompletionHandler))]LGSideMenuCompletionHandler completionHandler)
		{
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlockUnsafe (Trampolines.SDLGSideMenuCompletionHandler.Handler, completionHandler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_Double_IntPtr (this.Handle, Selector.GetHandle ("showLeftViewAnimated:delay:completionHandler:"), animated, delay, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_Double_IntPtr (this.SuperHandle, Selector.GetHandle ("showLeftViewAnimated:delay:completionHandler:"), animated, delay, (IntPtr) block_ptr_completionHandler);
			}
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("showRightView")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowRightView ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("showRightView"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showRightView"));
			}
		}
		
		[Export ("showRightView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowRightView (NSObject sender)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("showRightView:"), sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("showRightView:"), sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("showRightViewAnimated")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowRightViewAnimated ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("showRightViewAnimated"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showRightViewAnimated"));
			}
		}
		
		[Export ("showRightViewAnimated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowRightViewAnimated (NSObject sender)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("showRightViewAnimated:"), sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("showRightViewAnimated:"), sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("showRightViewAnimated:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ShowRightViewAnimated (bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDLGSideMenuCompletionHandler))]LGSideMenuCompletionHandler completionHandler)
		{
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlockUnsafe (Trampolines.SDLGSideMenuCompletionHandler.Handler, completionHandler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr (this.Handle, Selector.GetHandle ("showRightViewAnimated:completionHandler:"), animated, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("showRightViewAnimated:completionHandler:"), animated, (IntPtr) block_ptr_completionHandler);
			}
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("showRightViewAnimated:delay:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ShowRightViewAnimated (bool animated, double delay, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDLGSideMenuCompletionHandler))]LGSideMenuCompletionHandler completionHandler)
		{
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlockUnsafe (Trampolines.SDLGSideMenuCompletionHandler.Handler, completionHandler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_Double_IntPtr (this.Handle, Selector.GetHandle ("showRightViewAnimated:delay:completionHandler:"), animated, delay, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_Double_IntPtr (this.SuperHandle, Selector.GetHandle ("showRightViewAnimated:delay:completionHandler:"), animated, delay, (IntPtr) block_ptr_completionHandler);
			}
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("sideMenuControllerWithRootView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static LGSideMenuController SideMenuControllerWithRootView (global::UIKit.UIView rootView)
		{
			return  Runtime.GetNSObject<LGSideMenuController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("sideMenuControllerWithRootView:"), rootView == null ? IntPtr.Zero : rootView.Handle));
		}
		
		[Export ("sideMenuControllerWithRootView:leftView:rightView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static LGSideMenuController SideMenuControllerWithRootView (global::UIKit.UIView rootView, global::UIKit.UIView leftView, global::UIKit.UIView rightView)
		{
			return  Runtime.GetNSObject<LGSideMenuController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("sideMenuControllerWithRootView:leftView:rightView:"), rootView == null ? IntPtr.Zero : rootView.Handle, leftView == null ? IntPtr.Zero : leftView.Handle, rightView == null ? IntPtr.Zero : rightView.Handle));
		}
		
		[Export ("sideMenuControllerWithRootViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static LGSideMenuController SideMenuControllerWithRootViewController (global::UIKit.UIViewController rootViewController)
		{
			return  Runtime.GetNSObject<LGSideMenuController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("sideMenuControllerWithRootViewController:"), rootViewController == null ? IntPtr.Zero : rootViewController.Handle));
		}
		
		[Export ("sideMenuControllerWithRootViewController:leftViewController:rightViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static LGSideMenuController SideMenuControllerWithRootViewController (global::UIKit.UIViewController rootViewController, global::UIKit.UIViewController leftViewController, global::UIKit.UIViewController rightViewController)
		{
			return  Runtime.GetNSObject<LGSideMenuController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("sideMenuControllerWithRootViewController:leftViewController:rightViewController:"), rootViewController == null ? IntPtr.Zero : rootViewController.Handle, leftViewController == null ? IntPtr.Zero : leftViewController.Handle, rightViewController == null ? IntPtr.Zero : rightViewController.Handle));
		}
		
		[Export ("toggleLeftView")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToggleLeftView ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("toggleLeftView"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("toggleLeftView"));
			}
		}
		
		[Export ("toggleLeftView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToggleLeftView (NSObject sender)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("toggleLeftView:"), sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("toggleLeftView:"), sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("toggleLeftViewAnimated")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToggleLeftViewAnimated ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("toggleLeftViewAnimated"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("toggleLeftViewAnimated"));
			}
		}
		
		[Export ("toggleLeftViewAnimated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToggleLeftViewAnimated (NSObject sender)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("toggleLeftViewAnimated:"), sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("toggleLeftViewAnimated:"), sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("toggleLeftViewAnimated:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ToggleLeftViewAnimated (bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDLGSideMenuCompletionHandler))]LGSideMenuCompletionHandler completionHandler)
		{
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlockUnsafe (Trampolines.SDLGSideMenuCompletionHandler.Handler, completionHandler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr (this.Handle, Selector.GetHandle ("toggleLeftViewAnimated:completionHandler:"), animated, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("toggleLeftViewAnimated:completionHandler:"), animated, (IntPtr) block_ptr_completionHandler);
			}
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("toggleLeftViewAnimated:delay:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ToggleLeftViewAnimated (bool animated, double delay, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDLGSideMenuCompletionHandler))]LGSideMenuCompletionHandler completionHandler)
		{
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlockUnsafe (Trampolines.SDLGSideMenuCompletionHandler.Handler, completionHandler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_Double_IntPtr (this.Handle, Selector.GetHandle ("toggleLeftViewAnimated:delay:completionHandler:"), animated, delay, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_Double_IntPtr (this.SuperHandle, Selector.GetHandle ("toggleLeftViewAnimated:delay:completionHandler:"), animated, delay, (IntPtr) block_ptr_completionHandler);
			}
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("toggleRightView")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToggleRightView ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("toggleRightView"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("toggleRightView"));
			}
		}
		
		[Export ("toggleRightView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToggleRightView (NSObject sender)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("toggleRightView:"), sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("toggleRightView:"), sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("toggleRightViewAnimated")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToggleRightViewAnimated ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("toggleRightViewAnimated"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("toggleRightViewAnimated"));
			}
		}
		
		[Export ("toggleRightViewAnimated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ToggleRightViewAnimated (NSObject sender)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("toggleRightViewAnimated:"), sender == null ? IntPtr.Zero : sender.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("toggleRightViewAnimated:"), sender == null ? IntPtr.Zero : sender.Handle);
			}
		}
		
		[Export ("toggleRightViewAnimated:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ToggleRightViewAnimated (bool animated, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDLGSideMenuCompletionHandler))]LGSideMenuCompletionHandler completionHandler)
		{
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlockUnsafe (Trampolines.SDLGSideMenuCompletionHandler.Handler, completionHandler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr (this.Handle, Selector.GetHandle ("toggleRightViewAnimated:completionHandler:"), animated, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("toggleRightViewAnimated:completionHandler:"), animated, (IntPtr) block_ptr_completionHandler);
			}
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("toggleRightViewAnimated:delay:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ToggleRightViewAnimated (bool animated, double delay, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDLGSideMenuCompletionHandler))]LGSideMenuCompletionHandler completionHandler)
		{
			BlockLiteral *block_ptr_completionHandler;
			BlockLiteral block_completionHandler;
			if (completionHandler == null){
				block_ptr_completionHandler = null;
			} else {
				block_completionHandler = new BlockLiteral ();
				block_ptr_completionHandler = &block_completionHandler;
				block_completionHandler.SetupBlockUnsafe (Trampolines.SDLGSideMenuCompletionHandler.Handler, completionHandler);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_Double_IntPtr (this.Handle, Selector.GetHandle ("toggleRightViewAnimated:delay:completionHandler:"), animated, delay, (IntPtr) block_ptr_completionHandler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_Double_IntPtr (this.SuperHandle, Selector.GetHandle ("toggleRightViewAnimated:delay:completionHandler:"), animated, delay, (IntPtr) block_ptr_completionHandler);
			}
			if (block_ptr_completionHandler != null)
				block_ptr_completionHandler->CleanupBlock ();
			
		}
		
		[Export ("updateLayoutsAndStyles")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateLayoutsAndStyles ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updateLayoutsAndStyles"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("updateLayoutsAndStyles"));
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public LGSideMenuDelegate Delegate {
			get {
				return WeakDelegate as LGSideMenuDelegate;
			}
			set {
				var rvalue = value as NSObject;
				if (value != null && rvalue == null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual LGSideMenuHandler DidHideLeftView {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDLGSideMenuHandler))]
			[Export ("didHideLeftView", ArgumentSemantic.Copy)]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("didHideLeftView"));
				} else {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("didHideLeftView"));
				}
				return global::ObjCRuntime.Trampolines.NIDLGSideMenuHandler.Create (ret);
			}
			
			[Export ("setDidHideLeftView:", ArgumentSemantic.Copy)]
			set {
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlockUnsafe (Trampolines.SDLGSideMenuHandler.Handler, value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDidHideLeftView:"), (IntPtr) block_ptr_value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDidHideLeftView:"), (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual LGSideMenuHandler DidHideRightView {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDLGSideMenuHandler))]
			[Export ("didHideRightView", ArgumentSemantic.Copy)]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("didHideRightView"));
				} else {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("didHideRightView"));
				}
				return global::ObjCRuntime.Trampolines.NIDLGSideMenuHandler.Create (ret);
			}
			
			[Export ("setDidHideRightView:", ArgumentSemantic.Copy)]
			set {
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlockUnsafe (Trampolines.SDLGSideMenuHandler.Handler, value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDidHideRightView:"), (IntPtr) block_ptr_value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDidHideRightView:"), (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual LGSideMenuHandler DidShowLeftView {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDLGSideMenuHandler))]
			[Export ("didShowLeftView", ArgumentSemantic.Copy)]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("didShowLeftView"));
				} else {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("didShowLeftView"));
				}
				return global::ObjCRuntime.Trampolines.NIDLGSideMenuHandler.Create (ret);
			}
			
			[Export ("setDidShowLeftView:", ArgumentSemantic.Copy)]
			set {
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlockUnsafe (Trampolines.SDLGSideMenuHandler.Handler, value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDidShowLeftView:"), (IntPtr) block_ptr_value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDidShowLeftView:"), (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual LGSideMenuHandler DidShowRightView {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDLGSideMenuHandler))]
			[Export ("didShowRightView", ArgumentSemantic.Copy)]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("didShowRightView"));
				} else {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("didShowRightView"));
				}
				return global::ObjCRuntime.Trampolines.NIDLGSideMenuHandler.Create (ret);
			}
			
			[Export ("setDidShowRightView:", ArgumentSemantic.Copy)]
			set {
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlockUnsafe (Trampolines.SDLGSideMenuHandler.Handler, value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDidShowRightView:"), (IntPtr) block_ptr_value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDidShowRightView:"), (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual LGSideMenuAnimationsBlock HideLeftViewAnimations {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDLGSideMenuAnimationsBlock))]
			[Export ("hideLeftViewAnimations", ArgumentSemantic.Copy)]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("hideLeftViewAnimations"));
				} else {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hideLeftViewAnimations"));
				}
				return global::ObjCRuntime.Trampolines.NIDLGSideMenuAnimationsBlock.Create (ret);
			}
			
			[Export ("setHideLeftViewAnimations:", ArgumentSemantic.Copy)]
			set {
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlockUnsafe (Trampolines.SDLGSideMenuAnimationsBlock.Handler, value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setHideLeftViewAnimations:"), (IntPtr) block_ptr_value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setHideLeftViewAnimations:"), (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual LGSideMenuAnimationsBlock HideRightViewAnimations {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDLGSideMenuAnimationsBlock))]
			[Export ("hideRightViewAnimations", ArgumentSemantic.Copy)]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("hideRightViewAnimations"));
				} else {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hideRightViewAnimations"));
				}
				return global::ObjCRuntime.Trampolines.NIDLGSideMenuAnimationsBlock.Create (ret);
			}
			
			[Export ("setHideRightViewAnimations:", ArgumentSemantic.Copy)]
			set {
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlockUnsafe (Trampolines.SDLGSideMenuAnimationsBlock.Handler, value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setHideRightViewAnimations:"), (IntPtr) block_ptr_value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setHideRightViewAnimations:"), (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIView LeftView {
			[Export ("leftView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("leftView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftView")));
				}
				return ret;
			}
			
			[Export ("setLeftView:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLeftView:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLeftView:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LeftViewAlwaysVisibleForCurrentOrientation {
			[Export ("isLeftViewAlwaysVisibleForCurrentOrientation")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isLeftViewAlwaysVisibleForCurrentOrientation"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isLeftViewAlwaysVisibleForCurrentOrientation"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual LGSideMenuAlwaysVisibleOptions LeftViewAlwaysVisibleOptions {
			[Export ("leftViewAlwaysVisibleOptions", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (LGSideMenuAlwaysVisibleOptions) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("leftViewAlwaysVisibleOptions"));
				} else {
					return (LGSideMenuAlwaysVisibleOptions) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftViewAlwaysVisibleOptions"));
				}
			}
			
			[Export ("setLeftViewAlwaysVisibleOptions:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setLeftViewAlwaysVisibleOptions:"), (int)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setLeftViewAlwaysVisibleOptions:"), (int)value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double LeftViewAnimationDuration {
			[Export ("leftViewAnimationDuration")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("leftViewAnimationDuration"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftViewAnimationDuration"));
				}
			}
			
			[Export ("setLeftViewAnimationDuration:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setLeftViewAnimationDuration:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setLeftViewAnimationDuration:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat LeftViewBackgroundAlpha {
			[Export ("leftViewBackgroundAlpha")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("leftViewBackgroundAlpha"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftViewBackgroundAlpha"));
				}
			}
			
			[Export ("setLeftViewBackgroundAlpha:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setLeftViewBackgroundAlpha:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setLeftViewBackgroundAlpha:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIBlurEffect LeftViewBackgroundBlurEffect {
			[Export ("leftViewBackgroundBlurEffect", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIBlurEffect ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIBlurEffect> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("leftViewBackgroundBlurEffect")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIBlurEffect> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftViewBackgroundBlurEffect")));
				}
				return ret;
			}
			
			[Export ("setLeftViewBackgroundBlurEffect:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLeftViewBackgroundBlurEffect:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLeftViewBackgroundBlurEffect:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor LeftViewBackgroundColor {
			[Export ("leftViewBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("leftViewBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftViewBackgroundColor")));
				}
				return ret;
			}
			
			[Export ("setLeftViewBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLeftViewBackgroundColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLeftViewBackgroundColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIImage LeftViewBackgroundImage {
			[Export ("leftViewBackgroundImage", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("leftViewBackgroundImage")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftViewBackgroundImage")));
				}
				return ret;
			}
			
			[Export ("setLeftViewBackgroundImage:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLeftViewBackgroundImage:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLeftViewBackgroundImage:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat LeftViewBackgroundImageFinalScale {
			[Export ("leftViewBackgroundImageFinalScale")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("leftViewBackgroundImageFinalScale"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftViewBackgroundImageFinalScale"));
				}
			}
			
			[Export ("setLeftViewBackgroundImageFinalScale:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setLeftViewBackgroundImageFinalScale:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setLeftViewBackgroundImageFinalScale:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat LeftViewBackgroundImageInitialScale {
			[Export ("leftViewBackgroundImageInitialScale")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("leftViewBackgroundImageInitialScale"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftViewBackgroundImageInitialScale"));
				}
			}
			
			[Export ("setLeftViewBackgroundImageInitialScale:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setLeftViewBackgroundImageInitialScale:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setLeftViewBackgroundImageInitialScale:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIImageView LeftViewBackgroundView {
			[Export ("leftViewBackgroundView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIImageView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("leftViewBackgroundView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftViewBackgroundView")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIView LeftViewContainer {
			[Export ("leftViewContainer", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("leftViewContainer")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftViewContainer")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIViewController LeftViewController {
			[Export ("leftViewController", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("leftViewController")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftViewController")));
				}
				return ret;
			}
			
			[Export ("setLeftViewController:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLeftViewController:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLeftViewController:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat LeftViewCoverAlpha {
			[Export ("leftViewCoverAlpha")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("leftViewCoverAlpha"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftViewCoverAlpha"));
				}
			}
			
			[Export ("setLeftViewCoverAlpha:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setLeftViewCoverAlpha:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setLeftViewCoverAlpha:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIBlurEffect LeftViewCoverBlurEffect {
			[Export ("leftViewCoverBlurEffect", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIBlurEffect ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIBlurEffect> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("leftViewCoverBlurEffect")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIBlurEffect> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftViewCoverBlurEffect")));
				}
				return ret;
			}
			
			[Export ("setLeftViewCoverBlurEffect:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLeftViewCoverBlurEffect:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLeftViewCoverBlurEffect:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor LeftViewCoverColor {
			[Export ("leftViewCoverColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("leftViewCoverColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftViewCoverColor")));
				}
				return ret;
			}
			
			[Export ("setLeftViewCoverColor:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLeftViewCoverColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLeftViewCoverColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LeftViewDisabled {
			[Export ("isLeftViewDisabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isLeftViewDisabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isLeftViewDisabled"));
				}
			}
			
			[Export ("setLeftViewDisabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setLeftViewDisabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setLeftViewDisabled:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LeftViewEnabled {
			[Export ("isLeftViewEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isLeftViewEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isLeftViewEnabled"));
				}
			}
			
			[Export ("setLeftViewEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setLeftViewEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setLeftViewEnabled:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LeftViewHidden {
			[Export ("isLeftViewHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isLeftViewHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isLeftViewHidden"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LeftViewHidesOnTouch {
			[Export ("isLeftViewHidesOnTouch")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isLeftViewHidesOnTouch"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isLeftViewHidesOnTouch"));
				}
			}
			
			[Export ("setLeftViewHidesOnTouch:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setLeftViewHidesOnTouch:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setLeftViewHidesOnTouch:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat LeftViewInitialOffsetX {
			[Export ("leftViewInitialOffsetX")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("leftViewInitialOffsetX"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftViewInitialOffsetX"));
				}
			}
			
			[Export ("setLeftViewInitialOffsetX:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setLeftViewInitialOffsetX:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setLeftViewInitialOffsetX:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat LeftViewInitialScale {
			[Export ("leftViewInitialScale")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("leftViewInitialScale"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftViewInitialScale"));
				}
			}
			
			[Export ("setLeftViewInitialScale:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setLeftViewInitialScale:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setLeftViewInitialScale:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor LeftViewLayerBorderColor {
			[Export ("leftViewLayerBorderColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("leftViewLayerBorderColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftViewLayerBorderColor")));
				}
				return ret;
			}
			
			[Export ("setLeftViewLayerBorderColor:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLeftViewLayerBorderColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLeftViewLayerBorderColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat LeftViewLayerBorderWidth {
			[Export ("leftViewLayerBorderWidth")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("leftViewLayerBorderWidth"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftViewLayerBorderWidth"));
				}
			}
			
			[Export ("setLeftViewLayerBorderWidth:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setLeftViewLayerBorderWidth:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setLeftViewLayerBorderWidth:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor LeftViewLayerShadowColor {
			[Export ("leftViewLayerShadowColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("leftViewLayerShadowColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftViewLayerShadowColor")));
				}
				return ret;
			}
			
			[Export ("setLeftViewLayerShadowColor:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLeftViewLayerShadowColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLeftViewLayerShadowColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat LeftViewLayerShadowRadius {
			[Export ("leftViewLayerShadowRadius")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("leftViewLayerShadowRadius"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftViewLayerShadowRadius"));
				}
			}
			
			[Export ("setLeftViewLayerShadowRadius:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setLeftViewLayerShadowRadius:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setLeftViewLayerShadowRadius:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual LGSideMenuPresentationStyle LeftViewPresentationStyle {
			[Export ("leftViewPresentationStyle", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (LGSideMenuPresentationStyle) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("leftViewPresentationStyle"));
				} else {
					return (LGSideMenuPresentationStyle) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftViewPresentationStyle"));
				}
			}
			
			[Export ("setLeftViewPresentationStyle:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setLeftViewPresentationStyle:"), (int)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setLeftViewPresentationStyle:"), (int)value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LeftViewShowing {
			[Export ("isLeftViewShowing")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isLeftViewShowing"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isLeftViewShowing"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LeftViewStatusBarHidden {
			[Export ("isLeftViewStatusBarHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isLeftViewStatusBarHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isLeftViewStatusBarHidden"));
				}
			}
			
			[Export ("setLeftViewStatusBarHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setLeftViewStatusBarHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setLeftViewStatusBarHidden:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIStatusBarStyle LeftViewStatusBarStyle {
			[Export ("leftViewStatusBarStyle", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIStatusBarStyle ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (global::UIKit.UIStatusBarStyle) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("leftViewStatusBarStyle"));
					} else {
						ret = (global::UIKit.UIStatusBarStyle) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("leftViewStatusBarStyle"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (global::UIKit.UIStatusBarStyle) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftViewStatusBarStyle"));
					} else {
						ret = (global::UIKit.UIStatusBarStyle) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftViewStatusBarStyle"));
					}
				}
				return ret;
			}
			
			[Export ("setLeftViewStatusBarStyle:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setLeftViewStatusBarStyle:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setLeftViewStatusBarStyle:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setLeftViewStatusBarStyle:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setLeftViewStatusBarStyle:"), (int)value);
					}
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIStatusBarAnimation LeftViewStatusBarUpdateAnimation {
			[Export ("leftViewStatusBarUpdateAnimation", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIStatusBarAnimation ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (global::UIKit.UIStatusBarAnimation) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("leftViewStatusBarUpdateAnimation"));
					} else {
						ret = (global::UIKit.UIStatusBarAnimation) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("leftViewStatusBarUpdateAnimation"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (global::UIKit.UIStatusBarAnimation) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftViewStatusBarUpdateAnimation"));
					} else {
						ret = (global::UIKit.UIStatusBarAnimation) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftViewStatusBarUpdateAnimation"));
					}
				}
				return ret;
			}
			
			[Export ("setLeftViewStatusBarUpdateAnimation:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setLeftViewStatusBarUpdateAnimation:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setLeftViewStatusBarUpdateAnimation:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setLeftViewStatusBarUpdateAnimation:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setLeftViewStatusBarUpdateAnimation:"), (int)value);
					}
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LeftViewSwipeGestureDisabled {
			[Export ("isLeftViewSwipeGestureDisabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isLeftViewSwipeGestureDisabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isLeftViewSwipeGestureDisabled"));
				}
			}
			
			[Export ("setLeftViewSwipeGestureDisabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setLeftViewSwipeGestureDisabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setLeftViewSwipeGestureDisabled:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LeftViewSwipeGestureEnabled {
			[Export ("isLeftViewSwipeGestureEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isLeftViewSwipeGestureEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isLeftViewSwipeGestureEnabled"));
				}
			}
			
			[Export ("setLeftViewSwipeGestureEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setLeftViewSwipeGestureEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setLeftViewSwipeGestureEnabled:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual LGSideMenuSwipeGestureRange LeftViewSwipeGestureRange {
			[Export ("leftViewSwipeGestureRange", ArgumentSemantic.UnsafeUnretained)]
			get {
				LGSideMenuSwipeGestureRange ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.LGSideMenuSwipeGestureRange_objc_msgSend (this.Handle, Selector.GetHandle ("leftViewSwipeGestureRange"));
						} else {
							global::ApiDefinition.Messaging.LGSideMenuSwipeGestureRange_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("leftViewSwipeGestureRange"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.LGSideMenuSwipeGestureRange_objc_msgSend (this.Handle, Selector.GetHandle ("leftViewSwipeGestureRange"));
					} else {
						ret = global::ApiDefinition.Messaging.LGSideMenuSwipeGestureRange_objc_msgSend (this.Handle, Selector.GetHandle ("leftViewSwipeGestureRange"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.LGSideMenuSwipeGestureRange_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftViewSwipeGestureRange"));
						} else {
							global::ApiDefinition.Messaging.LGSideMenuSwipeGestureRange_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("leftViewSwipeGestureRange"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.LGSideMenuSwipeGestureRange_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftViewSwipeGestureRange"));
					} else {
						ret = global::ApiDefinition.Messaging.LGSideMenuSwipeGestureRange_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftViewSwipeGestureRange"));
					}
				}
				return ret;
			}
			
			[Export ("setLeftViewSwipeGestureRange:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_LGSideMenuSwipeGestureRange (this.Handle, Selector.GetHandle ("setLeftViewSwipeGestureRange:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_LGSideMenuSwipeGestureRange (this.SuperHandle, Selector.GetHandle ("setLeftViewSwipeGestureRange:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LeftViewVisible {
			[Export ("isLeftViewVisible")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isLeftViewVisible"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isLeftViewVisible"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat LeftViewWidth {
			[Export ("leftViewWidth")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("leftViewWidth"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftViewWidth"));
				}
			}
			
			[Export ("setLeftViewWidth:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setLeftViewWidth:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setLeftViewWidth:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIPanGestureRecognizer PanGesture {
			[Export ("panGesture", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIPanGestureRecognizer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIPanGestureRecognizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("panGesture")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIPanGestureRecognizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("panGesture")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIView RightView {
			[Export ("rightView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rightView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightView")));
				}
				return ret;
			}
			
			[Export ("setRightView:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRightView:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRightView:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RightViewAlwaysVisibleForCurrentOrientation {
			[Export ("isRightViewAlwaysVisibleForCurrentOrientation")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRightViewAlwaysVisibleForCurrentOrientation"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isRightViewAlwaysVisibleForCurrentOrientation"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual LGSideMenuAlwaysVisibleOptions RightViewAlwaysVisibleOptions {
			[Export ("rightViewAlwaysVisibleOptions", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (LGSideMenuAlwaysVisibleOptions) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewAlwaysVisibleOptions"));
				} else {
					return (LGSideMenuAlwaysVisibleOptions) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewAlwaysVisibleOptions"));
				}
			}
			
			[Export ("setRightViewAlwaysVisibleOptions:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setRightViewAlwaysVisibleOptions:"), (int)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setRightViewAlwaysVisibleOptions:"), (int)value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double RightViewAnimationDuration {
			[Export ("rightViewAnimationDuration")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewAnimationDuration"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewAnimationDuration"));
				}
			}
			
			[Export ("setRightViewAnimationDuration:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setRightViewAnimationDuration:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setRightViewAnimationDuration:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat RightViewBackgroundAlpha {
			[Export ("rightViewBackgroundAlpha")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewBackgroundAlpha"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewBackgroundAlpha"));
				}
			}
			
			[Export ("setRightViewBackgroundAlpha:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setRightViewBackgroundAlpha:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setRightViewBackgroundAlpha:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIBlurEffect RightViewBackgroundBlurEffect {
			[Export ("rightViewBackgroundBlurEffect", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIBlurEffect ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIBlurEffect> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewBackgroundBlurEffect")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIBlurEffect> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewBackgroundBlurEffect")));
				}
				return ret;
			}
			
			[Export ("setRightViewBackgroundBlurEffect:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRightViewBackgroundBlurEffect:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRightViewBackgroundBlurEffect:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor RightViewBackgroundColor {
			[Export ("rightViewBackgroundColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewBackgroundColor")));
				}
				return ret;
			}
			
			[Export ("setRightViewBackgroundColor:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRightViewBackgroundColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRightViewBackgroundColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIImage RightViewBackgroundImage {
			[Export ("rightViewBackgroundImage", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewBackgroundImage")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewBackgroundImage")));
				}
				return ret;
			}
			
			[Export ("setRightViewBackgroundImage:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRightViewBackgroundImage:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRightViewBackgroundImage:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat RightViewBackgroundImageFinalScale {
			[Export ("rightViewBackgroundImageFinalScale")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewBackgroundImageFinalScale"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewBackgroundImageFinalScale"));
				}
			}
			
			[Export ("setRightViewBackgroundImageFinalScale:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setRightViewBackgroundImageFinalScale:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setRightViewBackgroundImageFinalScale:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat RightViewBackgroundImageInitialScale {
			[Export ("rightViewBackgroundImageInitialScale")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewBackgroundImageInitialScale"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewBackgroundImageInitialScale"));
				}
			}
			
			[Export ("setRightViewBackgroundImageInitialScale:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setRightViewBackgroundImageInitialScale:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setRightViewBackgroundImageInitialScale:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIImageView RightViewBackgroundView {
			[Export ("rightViewBackgroundView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIImageView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewBackgroundView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewBackgroundView")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIView RightViewContainer {
			[Export ("rightViewContainer", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewContainer")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewContainer")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIViewController RightViewController {
			[Export ("rightViewController", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewController")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewController")));
				}
				return ret;
			}
			
			[Export ("setRightViewController:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRightViewController:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRightViewController:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat RightViewCoverAlpha {
			[Export ("rightViewCoverAlpha")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewCoverAlpha"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewCoverAlpha"));
				}
			}
			
			[Export ("setRightViewCoverAlpha:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setRightViewCoverAlpha:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setRightViewCoverAlpha:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIBlurEffect RightViewCoverBlurEffect {
			[Export ("rightViewCoverBlurEffect", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIBlurEffect ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIBlurEffect> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewCoverBlurEffect")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIBlurEffect> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewCoverBlurEffect")));
				}
				return ret;
			}
			
			[Export ("setRightViewCoverBlurEffect:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRightViewCoverBlurEffect:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRightViewCoverBlurEffect:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor RightViewCoverColor {
			[Export ("rightViewCoverColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewCoverColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewCoverColor")));
				}
				return ret;
			}
			
			[Export ("setRightViewCoverColor:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRightViewCoverColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRightViewCoverColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RightViewDisabled {
			[Export ("isRightViewDisabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRightViewDisabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isRightViewDisabled"));
				}
			}
			
			[Export ("setRightViewDisabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRightViewDisabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setRightViewDisabled:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RightViewEnabled {
			[Export ("isRightViewEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRightViewEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isRightViewEnabled"));
				}
			}
			
			[Export ("setRightViewEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRightViewEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setRightViewEnabled:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RightViewHidden {
			[Export ("isRightViewHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRightViewHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isRightViewHidden"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RightViewHidesOnTouch {
			[Export ("isRightViewHidesOnTouch")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRightViewHidesOnTouch"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isRightViewHidesOnTouch"));
				}
			}
			
			[Export ("setRightViewHidesOnTouch:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRightViewHidesOnTouch:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setRightViewHidesOnTouch:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat RightViewInitialOffsetX {
			[Export ("rightViewInitialOffsetX")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewInitialOffsetX"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewInitialOffsetX"));
				}
			}
			
			[Export ("setRightViewInitialOffsetX:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setRightViewInitialOffsetX:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setRightViewInitialOffsetX:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat RightViewInitialScale {
			[Export ("rightViewInitialScale")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewInitialScale"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewInitialScale"));
				}
			}
			
			[Export ("setRightViewInitialScale:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setRightViewInitialScale:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setRightViewInitialScale:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor RightViewLayerBorderColor {
			[Export ("rightViewLayerBorderColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewLayerBorderColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewLayerBorderColor")));
				}
				return ret;
			}
			
			[Export ("setRightViewLayerBorderColor:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRightViewLayerBorderColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRightViewLayerBorderColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat RightViewLayerBorderWidth {
			[Export ("rightViewLayerBorderWidth")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewLayerBorderWidth"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewLayerBorderWidth"));
				}
			}
			
			[Export ("setRightViewLayerBorderWidth:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setRightViewLayerBorderWidth:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setRightViewLayerBorderWidth:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor RightViewLayerShadowColor {
			[Export ("rightViewLayerShadowColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewLayerShadowColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewLayerShadowColor")));
				}
				return ret;
			}
			
			[Export ("setRightViewLayerShadowColor:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRightViewLayerShadowColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRightViewLayerShadowColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat RightViewLayerShadowRadius {
			[Export ("rightViewLayerShadowRadius")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewLayerShadowRadius"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewLayerShadowRadius"));
				}
			}
			
			[Export ("setRightViewLayerShadowRadius:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setRightViewLayerShadowRadius:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setRightViewLayerShadowRadius:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual LGSideMenuPresentationStyle RightViewPresentationStyle {
			[Export ("rightViewPresentationStyle", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (LGSideMenuPresentationStyle) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewPresentationStyle"));
				} else {
					return (LGSideMenuPresentationStyle) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewPresentationStyle"));
				}
			}
			
			[Export ("setRightViewPresentationStyle:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setRightViewPresentationStyle:"), (int)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setRightViewPresentationStyle:"), (int)value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RightViewShowing {
			[Export ("isRightViewShowing")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRightViewShowing"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isRightViewShowing"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RightViewStatusBarHidden {
			[Export ("isRightViewStatusBarHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRightViewStatusBarHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isRightViewStatusBarHidden"));
				}
			}
			
			[Export ("setRightViewStatusBarHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRightViewStatusBarHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setRightViewStatusBarHidden:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIStatusBarStyle RightViewStatusBarStyle {
			[Export ("rightViewStatusBarStyle", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIStatusBarStyle ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (global::UIKit.UIStatusBarStyle) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewStatusBarStyle"));
					} else {
						ret = (global::UIKit.UIStatusBarStyle) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewStatusBarStyle"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (global::UIKit.UIStatusBarStyle) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewStatusBarStyle"));
					} else {
						ret = (global::UIKit.UIStatusBarStyle) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewStatusBarStyle"));
					}
				}
				return ret;
			}
			
			[Export ("setRightViewStatusBarStyle:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setRightViewStatusBarStyle:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setRightViewStatusBarStyle:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setRightViewStatusBarStyle:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setRightViewStatusBarStyle:"), (int)value);
					}
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIStatusBarAnimation RightViewStatusBarUpdateAnimation {
			[Export ("rightViewStatusBarUpdateAnimation", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIStatusBarAnimation ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (global::UIKit.UIStatusBarAnimation) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewStatusBarUpdateAnimation"));
					} else {
						ret = (global::UIKit.UIStatusBarAnimation) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewStatusBarUpdateAnimation"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (global::UIKit.UIStatusBarAnimation) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewStatusBarUpdateAnimation"));
					} else {
						ret = (global::UIKit.UIStatusBarAnimation) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewStatusBarUpdateAnimation"));
					}
				}
				return ret;
			}
			
			[Export ("setRightViewStatusBarUpdateAnimation:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setRightViewStatusBarUpdateAnimation:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setRightViewStatusBarUpdateAnimation:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setRightViewStatusBarUpdateAnimation:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setRightViewStatusBarUpdateAnimation:"), (int)value);
					}
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RightViewSwipeGestureDisabled {
			[Export ("isRightViewSwipeGestureDisabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRightViewSwipeGestureDisabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isRightViewSwipeGestureDisabled"));
				}
			}
			
			[Export ("setRightViewSwipeGestureDisabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRightViewSwipeGestureDisabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setRightViewSwipeGestureDisabled:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RightViewSwipeGestureEnabled {
			[Export ("isRightViewSwipeGestureEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRightViewSwipeGestureEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isRightViewSwipeGestureEnabled"));
				}
			}
			
			[Export ("setRightViewSwipeGestureEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRightViewSwipeGestureEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setRightViewSwipeGestureEnabled:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual LGSideMenuSwipeGestureRange RightViewSwipeGestureRange {
			[Export ("rightViewSwipeGestureRange", ArgumentSemantic.UnsafeUnretained)]
			get {
				LGSideMenuSwipeGestureRange ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.LGSideMenuSwipeGestureRange_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewSwipeGestureRange"));
						} else {
							global::ApiDefinition.Messaging.LGSideMenuSwipeGestureRange_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("rightViewSwipeGestureRange"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.LGSideMenuSwipeGestureRange_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewSwipeGestureRange"));
					} else {
						ret = global::ApiDefinition.Messaging.LGSideMenuSwipeGestureRange_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewSwipeGestureRange"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.LGSideMenuSwipeGestureRange_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewSwipeGestureRange"));
						} else {
							global::ApiDefinition.Messaging.LGSideMenuSwipeGestureRange_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("rightViewSwipeGestureRange"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.LGSideMenuSwipeGestureRange_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewSwipeGestureRange"));
					} else {
						ret = global::ApiDefinition.Messaging.LGSideMenuSwipeGestureRange_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewSwipeGestureRange"));
					}
				}
				return ret;
			}
			
			[Export ("setRightViewSwipeGestureRange:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_LGSideMenuSwipeGestureRange (this.Handle, Selector.GetHandle ("setRightViewSwipeGestureRange:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_LGSideMenuSwipeGestureRange (this.SuperHandle, Selector.GetHandle ("setRightViewSwipeGestureRange:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RightViewVisible {
			[Export ("isRightViewVisible")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRightViewVisible"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isRightViewVisible"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat RightViewWidth {
			[Export ("rightViewWidth")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("rightViewWidth"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightViewWidth"));
				}
			}
			
			[Export ("setRightViewWidth:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setRightViewWidth:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setRightViewWidth:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIView RootView {
			[Export ("rootView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rootView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rootView")));
				}
				return ret;
			}
			
			[Export ("setRootView:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRootView:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRootView:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIView RootViewContainer {
			[Export ("rootViewContainer", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rootViewContainer")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rootViewContainer")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIViewController RootViewController {
			[Export ("rootViewController", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rootViewController")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rootViewController")));
				}
				return ret;
			}
			
			[Export ("setRootViewController:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRootViewController:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRootViewController:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat RootViewCoverAlphaForLeftView {
			[Export ("rootViewCoverAlphaForLeftView")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("rootViewCoverAlphaForLeftView"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rootViewCoverAlphaForLeftView"));
				}
			}
			
			[Export ("setRootViewCoverAlphaForLeftView:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setRootViewCoverAlphaForLeftView:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setRootViewCoverAlphaForLeftView:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat RootViewCoverAlphaForRightView {
			[Export ("rootViewCoverAlphaForRightView")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("rootViewCoverAlphaForRightView"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rootViewCoverAlphaForRightView"));
				}
			}
			
			[Export ("setRootViewCoverAlphaForRightView:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setRootViewCoverAlphaForRightView:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setRootViewCoverAlphaForRightView:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIBlurEffect RootViewCoverBlurEffectForLeftView {
			[Export ("rootViewCoverBlurEffectForLeftView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIBlurEffect ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIBlurEffect> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rootViewCoverBlurEffectForLeftView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIBlurEffect> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rootViewCoverBlurEffectForLeftView")));
				}
				return ret;
			}
			
			[Export ("setRootViewCoverBlurEffectForLeftView:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRootViewCoverBlurEffectForLeftView:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRootViewCoverBlurEffectForLeftView:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIBlurEffect RootViewCoverBlurEffectForRightView {
			[Export ("rootViewCoverBlurEffectForRightView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIBlurEffect ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIBlurEffect> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rootViewCoverBlurEffectForRightView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIBlurEffect> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rootViewCoverBlurEffectForRightView")));
				}
				return ret;
			}
			
			[Export ("setRootViewCoverBlurEffectForRightView:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRootViewCoverBlurEffectForRightView:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRootViewCoverBlurEffectForRightView:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor RootViewCoverColorForLeftView {
			[Export ("rootViewCoverColorForLeftView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rootViewCoverColorForLeftView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rootViewCoverColorForLeftView")));
				}
				return ret;
			}
			
			[Export ("setRootViewCoverColorForLeftView:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRootViewCoverColorForLeftView:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRootViewCoverColorForLeftView:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor RootViewCoverColorForRightView {
			[Export ("rootViewCoverColorForRightView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rootViewCoverColorForRightView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rootViewCoverColorForRightView")));
				}
				return ret;
			}
			
			[Export ("setRootViewCoverColorForRightView:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRootViewCoverColorForRightView:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRootViewCoverColorForRightView:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor RootViewLayerBorderColor {
			[Export ("rootViewLayerBorderColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rootViewLayerBorderColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rootViewLayerBorderColor")));
				}
				return ret;
			}
			
			[Export ("setRootViewLayerBorderColor:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRootViewLayerBorderColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRootViewLayerBorderColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat RootViewLayerBorderWidth {
			[Export ("rootViewLayerBorderWidth")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("rootViewLayerBorderWidth"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rootViewLayerBorderWidth"));
				}
			}
			
			[Export ("setRootViewLayerBorderWidth:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setRootViewLayerBorderWidth:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setRootViewLayerBorderWidth:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor RootViewLayerShadowColor {
			[Export ("rootViewLayerShadowColor", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rootViewLayerShadowColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rootViewLayerShadowColor")));
				}
				return ret;
			}
			
			[Export ("setRootViewLayerShadowColor:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRootViewLayerShadowColor:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRootViewLayerShadowColor:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat RootViewLayerShadowRadius {
			[Export ("rootViewLayerShadowRadius")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("rootViewLayerShadowRadius"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rootViewLayerShadowRadius"));
				}
			}
			
			[Export ("setRootViewLayerShadowRadius:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setRootViewLayerShadowRadius:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setRootViewLayerShadowRadius:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat RootViewScaleForLeftView {
			[Export ("rootViewScaleForLeftView")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("rootViewScaleForLeftView"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rootViewScaleForLeftView"));
				}
			}
			
			[Export ("setRootViewScaleForLeftView:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setRootViewScaleForLeftView:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setRootViewScaleForLeftView:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat RootViewScaleForRightView {
			[Export ("rootViewScaleForRightView")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("rootViewScaleForRightView"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rootViewScaleForRightView"));
				}
			}
			
			[Export ("setRootViewScaleForRightView:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setRootViewScaleForRightView:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setRootViewScaleForRightView:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RootViewShouldAutorotate {
			[Export ("rootViewShouldAutorotate")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("rootViewShouldAutorotate"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rootViewShouldAutorotate"));
				}
			}
			
			[Export ("setRootViewShouldAutorotate:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRootViewShouldAutorotate:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setRootViewShouldAutorotate:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RootViewStatusBarHidden {
			[Export ("isRootViewStatusBarHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRootViewStatusBarHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isRootViewStatusBarHidden"));
				}
			}
			
			[Export ("setRootViewStatusBarHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRootViewStatusBarHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setRootViewStatusBarHidden:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIStatusBarStyle RootViewStatusBarStyle {
			[Export ("rootViewStatusBarStyle", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIStatusBarStyle ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (global::UIKit.UIStatusBarStyle) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("rootViewStatusBarStyle"));
					} else {
						ret = (global::UIKit.UIStatusBarStyle) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("rootViewStatusBarStyle"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (global::UIKit.UIStatusBarStyle) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rootViewStatusBarStyle"));
					} else {
						ret = (global::UIKit.UIStatusBarStyle) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rootViewStatusBarStyle"));
					}
				}
				return ret;
			}
			
			[Export ("setRootViewStatusBarStyle:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setRootViewStatusBarStyle:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setRootViewStatusBarStyle:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setRootViewStatusBarStyle:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setRootViewStatusBarStyle:"), (int)value);
					}
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIStatusBarAnimation RootViewStatusBarUpdateAnimation {
			[Export ("rootViewStatusBarUpdateAnimation", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIStatusBarAnimation ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (global::UIKit.UIStatusBarAnimation) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("rootViewStatusBarUpdateAnimation"));
					} else {
						ret = (global::UIKit.UIStatusBarAnimation) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("rootViewStatusBarUpdateAnimation"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (global::UIKit.UIStatusBarAnimation) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rootViewStatusBarUpdateAnimation"));
					} else {
						ret = (global::UIKit.UIStatusBarAnimation) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rootViewStatusBarUpdateAnimation"));
					}
				}
				return ret;
			}
			
			[Export ("setRootViewStatusBarUpdateAnimation:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setRootViewStatusBarUpdateAnimation:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setRootViewStatusBarUpdateAnimation:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setRootViewStatusBarUpdateAnimation:"), (Int64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setRootViewStatusBarUpdateAnimation:"), (int)value);
					}
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldHideLeftViewAnimated {
			[Export ("shouldHideLeftViewAnimated")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldHideLeftViewAnimated"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldHideLeftViewAnimated"));
				}
			}
			
			[Export ("setShouldHideLeftViewAnimated:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldHideLeftViewAnimated:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShouldHideLeftViewAnimated:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldHideRightViewAnimated {
			[Export ("shouldHideRightViewAnimated")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldHideRightViewAnimated"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldHideRightViewAnimated"));
				}
			}
			
			[Export ("setShouldHideRightViewAnimated:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldHideRightViewAnimated:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShouldHideRightViewAnimated:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual LGSideMenuAnimationsBlock ShowLeftViewAnimations {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDLGSideMenuAnimationsBlock))]
			[Export ("showLeftViewAnimations", ArgumentSemantic.Copy)]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("showLeftViewAnimations"));
				} else {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showLeftViewAnimations"));
				}
				return global::ObjCRuntime.Trampolines.NIDLGSideMenuAnimationsBlock.Create (ret);
			}
			
			[Export ("setShowLeftViewAnimations:", ArgumentSemantic.Copy)]
			set {
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlockUnsafe (Trampolines.SDLGSideMenuAnimationsBlock.Handler, value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setShowLeftViewAnimations:"), (IntPtr) block_ptr_value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setShowLeftViewAnimations:"), (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual LGSideMenuAnimationsBlock ShowRightViewAnimations {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDLGSideMenuAnimationsBlock))]
			[Export ("showRightViewAnimations", ArgumentSemantic.Copy)]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("showRightViewAnimations"));
				} else {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showRightViewAnimations"));
				}
				return global::ObjCRuntime.Trampolines.NIDLGSideMenuAnimationsBlock.Create (ret);
			}
			
			[Export ("setShowRightViewAnimations:", ArgumentSemantic.Copy)]
			set {
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlockUnsafe (Trampolines.SDLGSideMenuAnimationsBlock.Handler, value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setShowRightViewAnimations:"), (IntPtr) block_ptr_value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setShowRightViewAnimations:"), (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual LGSideMenuSwipeGestureArea SwipeGestureArea {
			[Export ("swipeGestureArea", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (LGSideMenuSwipeGestureArea) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("swipeGestureArea"));
				} else {
					return (LGSideMenuSwipeGestureArea) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("swipeGestureArea"));
				}
			}
			
			[Export ("setSwipeGestureArea:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setSwipeGestureArea:"), (int)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setSwipeGestureArea:"), (int)value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UITapGestureRecognizer TapGesture {
			[Export ("tapGesture", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UITapGestureRecognizer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UITapGestureRecognizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("tapGesture")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UITapGestureRecognizer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("tapGesture")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual LGSideMenuHandler WillHideLeftView {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDLGSideMenuHandler))]
			[Export ("willHideLeftView", ArgumentSemantic.Copy)]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("willHideLeftView"));
				} else {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("willHideLeftView"));
				}
				return global::ObjCRuntime.Trampolines.NIDLGSideMenuHandler.Create (ret);
			}
			
			[Export ("setWillHideLeftView:", ArgumentSemantic.Copy)]
			set {
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlockUnsafe (Trampolines.SDLGSideMenuHandler.Handler, value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setWillHideLeftView:"), (IntPtr) block_ptr_value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setWillHideLeftView:"), (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual LGSideMenuHandler WillHideRightView {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDLGSideMenuHandler))]
			[Export ("willHideRightView", ArgumentSemantic.Copy)]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("willHideRightView"));
				} else {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("willHideRightView"));
				}
				return global::ObjCRuntime.Trampolines.NIDLGSideMenuHandler.Create (ret);
			}
			
			[Export ("setWillHideRightView:", ArgumentSemantic.Copy)]
			set {
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlockUnsafe (Trampolines.SDLGSideMenuHandler.Handler, value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setWillHideRightView:"), (IntPtr) block_ptr_value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setWillHideRightView:"), (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual LGSideMenuHandler WillShowLeftView {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDLGSideMenuHandler))]
			[Export ("willShowLeftView", ArgumentSemantic.Copy)]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("willShowLeftView"));
				} else {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("willShowLeftView"));
				}
				return global::ObjCRuntime.Trampolines.NIDLGSideMenuHandler.Create (ret);
			}
			
			[Export ("setWillShowLeftView:", ArgumentSemantic.Copy)]
			set {
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlockUnsafe (Trampolines.SDLGSideMenuHandler.Handler, value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setWillShowLeftView:"), (IntPtr) block_ptr_value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setWillShowLeftView:"), (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual LGSideMenuHandler WillShowRightView {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDLGSideMenuHandler))]
			[Export ("willShowRightView", ArgumentSemantic.Copy)]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("willShowRightView"));
				} else {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("willShowRightView"));
				}
				return global::ObjCRuntime.Trampolines.NIDLGSideMenuHandler.Create (ret);
			}
			
			[Export ("setWillShowRightView:", ArgumentSemantic.Copy)]
			set {
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlockUnsafe (Trampolines.SDLGSideMenuHandler.Handler, value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setWillShowRightView:"), (IntPtr) block_ptr_value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setWillShowRightView:"), (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class LGSideMenuController */
}
