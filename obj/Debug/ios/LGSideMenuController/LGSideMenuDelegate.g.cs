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
	[Protocol (Name = "LGSideMenuDelegate", WrapperType = typeof (LGSideMenuDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillShowLeftView", Selector = "willShowLeftView:sideMenuController:", ParameterType = new Type [] { typeof (UIView), typeof (global::LGSideMenuController.LGSideMenuController) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidShowLeftView", Selector = "didShowLeftView:sideMenuController:", ParameterType = new Type [] { typeof (UIView), typeof (global::LGSideMenuController.LGSideMenuController) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillHideLeftView", Selector = "willHideLeftView:sideMenuController:", ParameterType = new Type [] { typeof (UIView), typeof (global::LGSideMenuController.LGSideMenuController) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidHideLeftView", Selector = "didHideLeftView:sideMenuController:", ParameterType = new Type [] { typeof (UIView), typeof (global::LGSideMenuController.LGSideMenuController) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillShowRightView", Selector = "willShowRightView:sideMenuController:", ParameterType = new Type [] { typeof (UIView), typeof (global::LGSideMenuController.LGSideMenuController) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidShowRightView", Selector = "didShowRightView:sideMenuController:", ParameterType = new Type [] { typeof (UIView), typeof (global::LGSideMenuController.LGSideMenuController) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillHideRightView", Selector = "willHideRightView:sideMenuController:", ParameterType = new Type [] { typeof (UIView), typeof (global::LGSideMenuController.LGSideMenuController) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidHideRightView", Selector = "didHideRightView:sideMenuController:", ParameterType = new Type [] { typeof (UIView), typeof (global::LGSideMenuController.LGSideMenuController) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShowAnimationsForLeftView", Selector = "showAnimationsForLeftView:sideMenuController:duration:", ParameterType = new Type [] { typeof (UIView), typeof (global::LGSideMenuController.LGSideMenuController), typeof (double) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HideAnimationsForLeftView", Selector = "hideAnimationsForLeftView:sideMenuController:duration:", ParameterType = new Type [] { typeof (UIView), typeof (global::LGSideMenuController.LGSideMenuController), typeof (double) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShowAnimationsForRightView", Selector = "showAnimationsForRightView:sideMenuController:duration:", ParameterType = new Type [] { typeof (UIView), typeof (global::LGSideMenuController.LGSideMenuController), typeof (double) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HideAnimationsForRightView", Selector = "hideAnimationsForRightView:sideMenuController:duration:", ParameterType = new Type [] { typeof (UIView), typeof (global::LGSideMenuController.LGSideMenuController), typeof (double) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShowAnimationsBlockForLeftView", Selector = "showAnimationsBlockForLeftView:sideMenuController:duration:", ParameterType = new Type [] { typeof (UIView), typeof (global::LGSideMenuController.LGSideMenuController), typeof (double) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HideAnimationsBlockForLeftView", Selector = "hideAnimationsBlockForLeftView:sideMenuController:duration:", ParameterType = new Type [] { typeof (UIView), typeof (global::LGSideMenuController.LGSideMenuController), typeof (double) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShowAnimationsBlockForRightView", Selector = "showAnimationsBlockForRightView:sideMenuController:duration:", ParameterType = new Type [] { typeof (UIView), typeof (global::LGSideMenuController.LGSideMenuController), typeof (double) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HideAnimationsBlockForRightView", Selector = "hideAnimationsBlockForRightView:sideMenuController:duration:", ParameterType = new Type [] { typeof (UIView), typeof (global::LGSideMenuController.LGSideMenuController), typeof (double) }, ParameterByRef = new bool [] { false, false, false })]
	public interface ILGSideMenuDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class LGSideMenuDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillShowLeftView (this ILGSideMenuDelegate This, global::UIKit.UIView leftView, LGSideMenuController sideMenuController)
		{
			if (leftView == null)
				throw new ArgumentNullException ("leftView");
			if (sideMenuController == null)
				throw new ArgumentNullException ("sideMenuController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("willShowLeftView:sideMenuController:"), leftView.Handle, sideMenuController.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidShowLeftView (this ILGSideMenuDelegate This, global::UIKit.UIView leftView, LGSideMenuController sideMenuController)
		{
			if (leftView == null)
				throw new ArgumentNullException ("leftView");
			if (sideMenuController == null)
				throw new ArgumentNullException ("sideMenuController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("didShowLeftView:sideMenuController:"), leftView.Handle, sideMenuController.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillHideLeftView (this ILGSideMenuDelegate This, global::UIKit.UIView leftView, LGSideMenuController sideMenuController)
		{
			if (leftView == null)
				throw new ArgumentNullException ("leftView");
			if (sideMenuController == null)
				throw new ArgumentNullException ("sideMenuController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("willHideLeftView:sideMenuController:"), leftView.Handle, sideMenuController.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidHideLeftView (this ILGSideMenuDelegate This, global::UIKit.UIView leftView, LGSideMenuController sideMenuController)
		{
			if (leftView == null)
				throw new ArgumentNullException ("leftView");
			if (sideMenuController == null)
				throw new ArgumentNullException ("sideMenuController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("didHideLeftView:sideMenuController:"), leftView.Handle, sideMenuController.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillShowRightView (this ILGSideMenuDelegate This, global::UIKit.UIView rightView, LGSideMenuController sideMenuController)
		{
			if (rightView == null)
				throw new ArgumentNullException ("rightView");
			if (sideMenuController == null)
				throw new ArgumentNullException ("sideMenuController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("willShowRightView:sideMenuController:"), rightView.Handle, sideMenuController.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidShowRightView (this ILGSideMenuDelegate This, global::UIKit.UIView rightView, LGSideMenuController sideMenuController)
		{
			if (rightView == null)
				throw new ArgumentNullException ("rightView");
			if (sideMenuController == null)
				throw new ArgumentNullException ("sideMenuController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("didShowRightView:sideMenuController:"), rightView.Handle, sideMenuController.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillHideRightView (this ILGSideMenuDelegate This, global::UIKit.UIView rightView, LGSideMenuController sideMenuController)
		{
			if (rightView == null)
				throw new ArgumentNullException ("rightView");
			if (sideMenuController == null)
				throw new ArgumentNullException ("sideMenuController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("willHideRightView:sideMenuController:"), rightView.Handle, sideMenuController.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidHideRightView (this ILGSideMenuDelegate This, global::UIKit.UIView rightView, LGSideMenuController sideMenuController)
		{
			if (rightView == null)
				throw new ArgumentNullException ("rightView");
			if (sideMenuController == null)
				throw new ArgumentNullException ("sideMenuController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("didHideRightView:sideMenuController:"), rightView.Handle, sideMenuController.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ShowAnimationsForLeftView (this ILGSideMenuDelegate This, global::UIKit.UIView leftView, LGSideMenuController sideMenuController, double duration)
		{
			if (leftView == null)
				throw new ArgumentNullException ("leftView");
			if (sideMenuController == null)
				throw new ArgumentNullException ("sideMenuController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_Double (This.Handle, Selector.GetHandle ("showAnimationsForLeftView:sideMenuController:duration:"), leftView.Handle, sideMenuController.Handle, duration);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HideAnimationsForLeftView (this ILGSideMenuDelegate This, global::UIKit.UIView leftView, LGSideMenuController sideMenuController, double duration)
		{
			if (leftView == null)
				throw new ArgumentNullException ("leftView");
			if (sideMenuController == null)
				throw new ArgumentNullException ("sideMenuController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_Double (This.Handle, Selector.GetHandle ("hideAnimationsForLeftView:sideMenuController:duration:"), leftView.Handle, sideMenuController.Handle, duration);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ShowAnimationsForRightView (this ILGSideMenuDelegate This, global::UIKit.UIView rightView, LGSideMenuController sideMenuController, double duration)
		{
			if (rightView == null)
				throw new ArgumentNullException ("rightView");
			if (sideMenuController == null)
				throw new ArgumentNullException ("sideMenuController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_Double (This.Handle, Selector.GetHandle ("showAnimationsForRightView:sideMenuController:duration:"), rightView.Handle, sideMenuController.Handle, duration);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HideAnimationsForRightView (this ILGSideMenuDelegate This, global::UIKit.UIView rightView, LGSideMenuController sideMenuController, double duration)
		{
			if (rightView == null)
				throw new ArgumentNullException ("rightView");
			if (sideMenuController == null)
				throw new ArgumentNullException ("sideMenuController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_Double (This.Handle, Selector.GetHandle ("hideAnimationsForRightView:sideMenuController:duration:"), rightView.Handle, sideMenuController.Handle, duration);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ShowAnimationsBlockForLeftView (this ILGSideMenuDelegate This, global::UIKit.UIView leftView, LGSideMenuController sideMenuController, double duration)
		{
			if (leftView == null)
				throw new ArgumentNullException ("leftView");
			if (sideMenuController == null)
				throw new ArgumentNullException ("sideMenuController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_Double (This.Handle, Selector.GetHandle ("showAnimationsBlockForLeftView:sideMenuController:duration:"), leftView.Handle, sideMenuController.Handle, duration);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HideAnimationsBlockForLeftView (this ILGSideMenuDelegate This, global::UIKit.UIView leftView, LGSideMenuController sideMenuController, double duration)
		{
			if (leftView == null)
				throw new ArgumentNullException ("leftView");
			if (sideMenuController == null)
				throw new ArgumentNullException ("sideMenuController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_Double (This.Handle, Selector.GetHandle ("hideAnimationsBlockForLeftView:sideMenuController:duration:"), leftView.Handle, sideMenuController.Handle, duration);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ShowAnimationsBlockForRightView (this ILGSideMenuDelegate This, global::UIKit.UIView rightView, LGSideMenuController sideMenuController, double duration)
		{
			if (rightView == null)
				throw new ArgumentNullException ("rightView");
			if (sideMenuController == null)
				throw new ArgumentNullException ("sideMenuController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_Double (This.Handle, Selector.GetHandle ("showAnimationsBlockForRightView:sideMenuController:duration:"), rightView.Handle, sideMenuController.Handle, duration);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HideAnimationsBlockForRightView (this ILGSideMenuDelegate This, global::UIKit.UIView rightView, LGSideMenuController sideMenuController, double duration)
		{
			if (rightView == null)
				throw new ArgumentNullException ("rightView");
			if (sideMenuController == null)
				throw new ArgumentNullException ("sideMenuController");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_Double (This.Handle, Selector.GetHandle ("hideAnimationsBlockForRightView:sideMenuController:duration:"), rightView.Handle, sideMenuController.Handle, duration);
		}
		
	}
	
	internal sealed class LGSideMenuDelegateWrapper : BaseWrapper, ILGSideMenuDelegate {
		[Preserve (Conditional = true)]
		public LGSideMenuDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace LGSideMenuController {
	[Protocol()]
	[Register("LGSideMenuDelegate", false)]
	[Model]
	public unsafe partial class LGSideMenuDelegate : NSObject, ILGSideMenuDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public LGSideMenuDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected LGSideMenuDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal LGSideMenuDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("didHideLeftView:sideMenuController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidHideLeftView (global::UIKit.UIView leftView, LGSideMenuController sideMenuController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didHideRightView:sideMenuController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidHideRightView (global::UIKit.UIView rightView, LGSideMenuController sideMenuController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didShowLeftView:sideMenuController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidShowLeftView (global::UIKit.UIView leftView, LGSideMenuController sideMenuController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didShowRightView:sideMenuController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidShowRightView (global::UIKit.UIView rightView, LGSideMenuController sideMenuController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("hideAnimationsBlockForLeftView:sideMenuController:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HideAnimationsBlockForLeftView (global::UIKit.UIView leftView, LGSideMenuController sideMenuController, double duration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("hideAnimationsBlockForRightView:sideMenuController:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HideAnimationsBlockForRightView (global::UIKit.UIView rightView, LGSideMenuController sideMenuController, double duration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("hideAnimationsForLeftView:sideMenuController:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HideAnimationsForLeftView (global::UIKit.UIView leftView, LGSideMenuController sideMenuController, double duration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("hideAnimationsForRightView:sideMenuController:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HideAnimationsForRightView (global::UIKit.UIView rightView, LGSideMenuController sideMenuController, double duration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("showAnimationsBlockForLeftView:sideMenuController:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowAnimationsBlockForLeftView (global::UIKit.UIView leftView, LGSideMenuController sideMenuController, double duration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("showAnimationsBlockForRightView:sideMenuController:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowAnimationsBlockForRightView (global::UIKit.UIView rightView, LGSideMenuController sideMenuController, double duration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("showAnimationsForLeftView:sideMenuController:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowAnimationsForLeftView (global::UIKit.UIView leftView, LGSideMenuController sideMenuController, double duration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("showAnimationsForRightView:sideMenuController:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowAnimationsForRightView (global::UIKit.UIView rightView, LGSideMenuController sideMenuController, double duration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("willHideLeftView:sideMenuController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillHideLeftView (global::UIKit.UIView leftView, LGSideMenuController sideMenuController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("willHideRightView:sideMenuController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillHideRightView (global::UIKit.UIView rightView, LGSideMenuController sideMenuController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("willShowLeftView:sideMenuController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillShowLeftView (global::UIKit.UIView leftView, LGSideMenuController sideMenuController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("willShowRightView:sideMenuController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillShowRightView (global::UIKit.UIView rightView, LGSideMenuController sideMenuController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class LGSideMenuDelegate */
}
