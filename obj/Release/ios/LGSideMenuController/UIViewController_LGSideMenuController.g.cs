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
	public unsafe static partial class UIViewController_LGSideMenuController  {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("UIViewController");
		
		[Export ("sideMenuController")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static LGSideMenuController GetSideMenuController (this global::UIKit.UIViewController This)
		{
			return  Runtime.GetNSObject<LGSideMenuController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("sideMenuController")));
		}
		
		[Export ("hideLeftView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HideLeftView (this global::UIKit.UIViewController This, NSObject sender)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("hideLeftView:"), sender == null ? IntPtr.Zero : sender.Handle);
		}
		
		[Export ("hideLeftViewAnimated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HideLeftViewAnimated (this global::UIKit.UIViewController This, NSObject sender)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("hideLeftViewAnimated:"), sender == null ? IntPtr.Zero : sender.Handle);
		}
		
		[Export ("hideRightView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HideRightView (this global::UIKit.UIViewController This, NSObject sender)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("hideRightView:"), sender == null ? IntPtr.Zero : sender.Handle);
		}
		
		[Export ("hideRightViewAnimated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HideRightViewAnimated (this global::UIKit.UIViewController This, NSObject sender)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("hideRightViewAnimated:"), sender == null ? IntPtr.Zero : sender.Handle);
		}
		
		[Export ("showLeftView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ShowLeftView (this global::UIKit.UIViewController This, NSObject sender)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("showLeftView:"), sender == null ? IntPtr.Zero : sender.Handle);
		}
		
		[Export ("showLeftViewAnimated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ShowLeftViewAnimated (this global::UIKit.UIViewController This, NSObject sender)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("showLeftViewAnimated:"), sender == null ? IntPtr.Zero : sender.Handle);
		}
		
		[Export ("showRightView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ShowRightView (this global::UIKit.UIViewController This, NSObject sender)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("showRightView:"), sender == null ? IntPtr.Zero : sender.Handle);
		}
		
		[Export ("showRightViewAnimated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ShowRightViewAnimated (this global::UIKit.UIViewController This, NSObject sender)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("showRightViewAnimated:"), sender == null ? IntPtr.Zero : sender.Handle);
		}
		
		[Export ("toggleLeftView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ToggleLeftView (this global::UIKit.UIViewController This, NSObject sender)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("toggleLeftView:"), sender == null ? IntPtr.Zero : sender.Handle);
		}
		
		[Export ("toggleLeftViewAnimated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ToggleLeftViewAnimated (this global::UIKit.UIViewController This, NSObject sender)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("toggleLeftViewAnimated:"), sender == null ? IntPtr.Zero : sender.Handle);
		}
		
		[Export ("toggleRightView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ToggleRightView (this global::UIKit.UIViewController This, NSObject sender)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("toggleRightView:"), sender == null ? IntPtr.Zero : sender.Handle);
		}
		
		[Export ("toggleRightViewAnimated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ToggleRightViewAnimated (this global::UIKit.UIViewController This, NSObject sender)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("toggleRightViewAnimated:"), sender == null ? IntPtr.Zero : sender.Handle);
		}
		
	} /* class UIViewController_LGSideMenuController */
}
