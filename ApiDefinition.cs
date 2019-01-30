using System;
using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace LGSideMenuController
{

    [BaseType(typeof(UIView))]
    interface LGSideMenuBorderView
    {
        // @property (assign, nonatomic) UIRectCorner roundedCorners;
        [Export("roundedCorners", ArgumentSemantic.Assign)]
        UIRectCorner RoundedCorners { get; set; }

        // @property (assign, nonatomic) CGFloat cornerRadius;
        [Export("cornerRadius")]
        nfloat CornerRadius { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable strokeColor;
        [NullAllowed, Export("strokeColor", ArgumentSemantic.Strong)]
        UIColor StrokeColor { get; set; }

        // @property (assign, nonatomic) CGFloat strokeWidth;
        [Export("strokeWidth")]
        nfloat StrokeWidth { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable shadowColor;
        [NullAllowed, Export("shadowColor", ArgumentSemantic.Strong)]
        UIColor ShadowColor { get; set; }

        // @property (assign, nonatomic) CGFloat shadowBlur;
        [Export("shadowBlur")]
        nfloat ShadowBlur { get; set; }
    }

    [Static]
    partial interface Constants
    {
        // extern NSString *const _Nonnull LGSideMenuWillShowLeftViewNotification;
        [Field("LGSideMenuWillShowLeftViewNotification", "__Internal")]
        NSString LGSideMenuWillShowLeftViewNotification { get; }

        // extern NSString *const _Nonnull LGSideMenuDidShowLeftViewNotification;
        [Field("LGSideMenuDidShowLeftViewNotification", "__Internal")]
        NSString LGSideMenuDidShowLeftViewNotification { get; }

        // extern NSString *const _Nonnull LGSideMenuWillHideLeftViewNotification;
        [Field("LGSideMenuWillHideLeftViewNotification", "__Internal")]
        NSString LGSideMenuWillHideLeftViewNotification { get; }

        // extern NSString *const _Nonnull LGSideMenuDidHideLeftViewNotification;
        [Field("LGSideMenuDidHideLeftViewNotification", "__Internal")]
        NSString LGSideMenuDidHideLeftViewNotification { get; }

        // extern NSString *const _Nonnull LGSideMenuWillShowRightViewNotification;
        [Field("LGSideMenuWillShowRightViewNotification", "__Internal")]
        NSString LGSideMenuWillShowRightViewNotification { get; }

        // extern NSString *const _Nonnull LGSideMenuDidShowRightViewNotification;
        [Field("LGSideMenuDidShowRightViewNotification", "__Internal")]
        NSString LGSideMenuDidShowRightViewNotification { get; }

        // extern NSString *const _Nonnull LGSideMenuWillHideRightViewNotification;
        [Field("LGSideMenuWillHideRightViewNotification", "__Internal")]
        NSString LGSideMenuWillHideRightViewNotification { get; }

        // extern NSString *const _Nonnull LGSideMenuDidHideRightViewNotification;
        [Field("LGSideMenuDidHideRightViewNotification", "__Internal")]
        NSString LGSideMenuDidHideRightViewNotification { get; }

        // extern NSString *const _Nonnull LGSideMenuShowLeftViewAnimationsNotification;
        [Field("LGSideMenuShowLeftViewAnimationsNotification", "__Internal")]
        NSString LGSideMenuShowLeftViewAnimationsNotification { get; }

        // extern NSString *const _Nonnull LGSideMenuHideLeftViewAnimationsNotification;
        [Field("LGSideMenuHideLeftViewAnimationsNotification", "__Internal")]
        NSString LGSideMenuHideLeftViewAnimationsNotification { get; }

        // extern NSString *const _Nonnull LGSideMenuShowRightViewAnimationsNotification;
        [Field("LGSideMenuShowRightViewAnimationsNotification", "__Internal")]
        NSString LGSideMenuShowRightViewAnimationsNotification { get; }

        // extern NSString *const _Nonnull LGSideMenuHideRightViewAnimationsNotification;
        [Field("LGSideMenuHideRightViewAnimationsNotification", "__Internal")]
        NSString LGSideMenuHideRightViewAnimationsNotification { get; }

        // extern NSString *const _Nonnull kLGSideMenuView;
        [Field("kLGSideMenuView", "__Internal")]
        NSString kLGSideMenuView { get; }

        // extern NSString *const _Nonnull kLGSideMenuAnimationDuration;
        [Field("kLGSideMenuAnimationDuration", "__Internal")]
        NSString kLGSideMenuAnimationDuration { get; }
    }

    // typedef void (^ _Nullable)() LGSideMenuCompletionHandler;
    delegate void LGSideMenuCompletionHandler();

    // typedef void (^ _Nullable)(LGSideMenuController * _Nonnull, UIView * _Nonnull) LGSideMenuHandler;
    delegate void LGSideMenuHandler(LGSideMenuController arg0, UIView arg1);

    // typedef void (^ _Nullable)(LGSideMenuController * _Nonnull, UIView * _Nonnull, NSTimeInterval) LGSideMenuAnimationsBlock;
    delegate void LGSideMenuAnimationsBlock(LGSideMenuController arg0, UIView arg1, double arg2);

    // @interface LGSideMenuController : UIViewController
    [BaseType(typeof(UIViewController))]
    interface LGSideMenuController
    {
        // @property (nonatomic, strong) UIViewController * _Nullable rootViewController;
        [NullAllowed, Export("rootViewController", ArgumentSemantic.Strong)]
        UIViewController RootViewController { get; set; }

        // @property (nonatomic, strong) UIViewController * _Nullable leftViewController;
        [NullAllowed, Export("leftViewController", ArgumentSemantic.Strong)]
        UIViewController LeftViewController { get; set; }

        // @property (nonatomic, strong) UIViewController * _Nullable rightViewController;
        [NullAllowed, Export("rightViewController", ArgumentSemantic.Strong)]
        UIViewController RightViewController { get; set; }

        // @property (nonatomic, strong) UIView * _Nullable rootView;
        [NullAllowed, Export("rootView", ArgumentSemantic.Strong)]
        UIView RootView { get; set; }

        // @property (nonatomic, strong) UIView * _Nullable leftView;
        [NullAllowed, Export("leftView", ArgumentSemantic.Strong)]
        UIView LeftView { get; set; }

        // @property (nonatomic, strong) UIView * _Nullable rightView;
        [NullAllowed, Export("rightView", ArgumentSemantic.Strong)]
        UIView RightView { get; set; }

        // @property (readonly, nonatomic, strong) UIView * _Nullable rootViewContainer;
        [NullAllowed, Export("rootViewContainer", ArgumentSemantic.Strong)]
        UIView RootViewContainer { get; }

        // @property (readonly, nonatomic, strong) UIView * _Nullable leftViewContainer;
        [NullAllowed, Export("leftViewContainer", ArgumentSemantic.Strong)]
        UIView LeftViewContainer { get; }

        // @property (readonly, nonatomic, strong) UIView * _Nullable rightViewContainer;
        [NullAllowed, Export("rightViewContainer", ArgumentSemantic.Strong)]
        UIView RightViewContainer { get; }

        // @property (readonly, nonatomic, strong) UIImageView * _Nullable leftViewBackgroundView;
        [NullAllowed, Export("leftViewBackgroundView", ArgumentSemantic.Strong)]
        UIImageView LeftViewBackgroundView { get; }

        // @property (readonly, nonatomic, strong) UIImageView * _Nullable rightViewBackgroundView;
        [NullAllowed, Export("rightViewBackgroundView", ArgumentSemantic.Strong)]
        UIImageView RightViewBackgroundView { get; }

        // @property (readonly, nonatomic, strong) UITapGestureRecognizer * _Nonnull tapGesture;
        [Export("tapGesture", ArgumentSemantic.Strong)]
        UITapGestureRecognizer TapGesture { get; }

        // @property (readonly, nonatomic, strong) UIPanGestureRecognizer * _Nonnull panGesture;
        [Export("panGesture", ArgumentSemantic.Strong)]
        UIPanGestureRecognizer PanGesture { get; }

        // @property (assign, nonatomic) CGFloat leftViewWidth;
        [Export("leftViewWidth")]
        nfloat LeftViewWidth { get; set; }

        // @property (assign, nonatomic) CGFloat rightViewWidth;
        [Export("rightViewWidth")]
        nfloat RightViewWidth { get; set; }

        // @property (assign, nonatomic) LGSideMenuPresentationStyle leftViewPresentationStyle;
        [Export("leftViewPresentationStyle", ArgumentSemantic.Assign)]
        LGSideMenuPresentationStyle LeftViewPresentationStyle { get; set; }

        // @property (assign, nonatomic) LGSideMenuPresentationStyle rightViewPresentationStyle;
        [Export("rightViewPresentationStyle", ArgumentSemantic.Assign)]
        LGSideMenuPresentationStyle RightViewPresentationStyle { get; set; }

        // @property (assign, nonatomic) LGSideMenuAlwaysVisibleOptions leftViewAlwaysVisibleOptions;
        [Export("leftViewAlwaysVisibleOptions", ArgumentSemantic.Assign)]
        LGSideMenuAlwaysVisibleOptions LeftViewAlwaysVisibleOptions { get; set; }

        // @property (assign, nonatomic) LGSideMenuAlwaysVisibleOptions rightViewAlwaysVisibleOptions;
        [Export("rightViewAlwaysVisibleOptions", ArgumentSemantic.Assign)]
        LGSideMenuAlwaysVisibleOptions RightViewAlwaysVisibleOptions { get; set; }

        // @property (getter = isLeftViewHidesOnTouch, assign, nonatomic) BOOL leftViewHidesOnTouch;
        [Export("leftViewHidesOnTouch")]
        bool LeftViewHidesOnTouch { [Bind("isLeftViewHidesOnTouch")] get; set; }

        // @property (getter = isRightViewHidesOnTouch, assign, nonatomic) BOOL rightViewHidesOnTouch;
        [Export("rightViewHidesOnTouch")]
        bool RightViewHidesOnTouch { [Bind("isRightViewHidesOnTouch")] get; set; }

        // @property (getter = isLeftViewSwipeGestureEnabled, assign, nonatomic) BOOL leftViewSwipeGestureEnabled;
        [Export("leftViewSwipeGestureEnabled")]
        bool LeftViewSwipeGestureEnabled { [Bind("isLeftViewSwipeGestureEnabled")] get; set; }

        // @property (getter = isRightViewSwipeGestureEnabled, assign, nonatomic) BOOL rightViewSwipeGestureEnabled;
        [Export("rightViewSwipeGestureEnabled")]
        bool RightViewSwipeGestureEnabled { [Bind("isRightViewSwipeGestureEnabled")] get; set; }

        // @property (getter = isLeftViewSwipeGestureDisabled, assign, nonatomic) BOOL leftViewSwipeGestureDisabled;
        [Export("leftViewSwipeGestureDisabled")]
        bool LeftViewSwipeGestureDisabled { [Bind("isLeftViewSwipeGestureDisabled")] get; set; }

        // @property (getter = isRightViewSwipeGestureDisabled, assign, nonatomic) BOOL rightViewSwipeGestureDisabled;
        [Export("rightViewSwipeGestureDisabled")]
        bool RightViewSwipeGestureDisabled { [Bind("isRightViewSwipeGestureDisabled")] get; set; }

        // @property (assign, nonatomic) LGSideMenuSwipeGestureArea swipeGestureArea;
        [Export("swipeGestureArea", ArgumentSemantic.Assign)]
        LGSideMenuSwipeGestureArea SwipeGestureArea { get; set; }

        // @property (assign, nonatomic) LGSideMenuSwipeGestureRange leftViewSwipeGestureRange;
        [Export("leftViewSwipeGestureRange", ArgumentSemantic.Assign)]
        LGSideMenuSwipeGestureRange LeftViewSwipeGestureRange { get; set; }

        // @property (assign, nonatomic) LGSideMenuSwipeGestureRange rightViewSwipeGestureRange;
        [Export("rightViewSwipeGestureRange", ArgumentSemantic.Assign)]
        LGSideMenuSwipeGestureRange RightViewSwipeGestureRange { get; set; }

        // @property (assign, nonatomic) NSTimeInterval leftViewAnimationDuration;
        [Export("leftViewAnimationDuration")]
        double LeftViewAnimationDuration { get; set; }

        // @property (assign, nonatomic) NSTimeInterval rightViewAnimationDuration;
        [Export("rightViewAnimationDuration")]
        double RightViewAnimationDuration { get; set; }

        // @property (assign, nonatomic) BOOL shouldHideLeftViewAnimated;
        [Export("shouldHideLeftViewAnimated")]
        bool ShouldHideLeftViewAnimated { get; set; }

        // @property (assign, nonatomic) BOOL shouldHideRightViewAnimated;
        [Export("shouldHideRightViewAnimated")]
        bool ShouldHideRightViewAnimated { get; set; }

        // @property (getter = isLeftViewEnabled, assign, nonatomic) BOOL leftViewEnabled;
        [Export("leftViewEnabled")]
        bool LeftViewEnabled { [Bind("isLeftViewEnabled")] get; set; }

        // @property (getter = isRightViewEnabled, assign, nonatomic) BOOL rightViewEnabled;
        [Export("rightViewEnabled")]
        bool RightViewEnabled { [Bind("isRightViewEnabled")] get; set; }

        // @property (getter = isLeftViewDisabled, assign, nonatomic) BOOL leftViewDisabled;
        [Export("leftViewDisabled")]
        bool LeftViewDisabled { [Bind("isLeftViewDisabled")] get; set; }

        // @property (getter = isRightViewDisabled, assign, nonatomic) BOOL rightViewDisabled;
        [Export("rightViewDisabled")]
        bool RightViewDisabled { [Bind("isRightViewDisabled")] get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable leftViewBackgroundColor;
        [NullAllowed, Export("leftViewBackgroundColor", ArgumentSemantic.Strong)]
        UIColor LeftViewBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable rightViewBackgroundColor;
        [NullAllowed, Export("rightViewBackgroundColor", ArgumentSemantic.Strong)]
        UIColor RightViewBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable leftViewBackgroundImage;
        [NullAllowed, Export("leftViewBackgroundImage", ArgumentSemantic.Strong)]
        UIImage LeftViewBackgroundImage { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable rightViewBackgroundImage;
        [NullAllowed, Export("rightViewBackgroundImage", ArgumentSemantic.Strong)]
        UIImage RightViewBackgroundImage { get; set; }

        // @property (nonatomic, strong) UIBlurEffect * _Nullable leftViewBackgroundBlurEffect;
        [NullAllowed, Export("leftViewBackgroundBlurEffect", ArgumentSemantic.Strong)]
        UIBlurEffect LeftViewBackgroundBlurEffect { get; set; }

        // @property (nonatomic, strong) UIBlurEffect * _Nullable rightViewBackgroundBlurEffect;
        [NullAllowed, Export("rightViewBackgroundBlurEffect", ArgumentSemantic.Strong)]
        UIBlurEffect RightViewBackgroundBlurEffect { get; set; }

        // @property (assign, nonatomic) CGFloat leftViewBackgroundAlpha;
        [Export("leftViewBackgroundAlpha")]
        nfloat LeftViewBackgroundAlpha { get; set; }

        // @property (assign, nonatomic) CGFloat rightViewBackgroundAlpha;
        [Export("rightViewBackgroundAlpha")]
        nfloat RightViewBackgroundAlpha { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable rootViewLayerBorderColor;
        [NullAllowed, Export("rootViewLayerBorderColor", ArgumentSemantic.Strong)]
        UIColor RootViewLayerBorderColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable leftViewLayerBorderColor;
        [NullAllowed, Export("leftViewLayerBorderColor", ArgumentSemantic.Strong)]
        UIColor LeftViewLayerBorderColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable rightViewLayerBorderColor;
        [NullAllowed, Export("rightViewLayerBorderColor", ArgumentSemantic.Strong)]
        UIColor RightViewLayerBorderColor { get; set; }

        // @property (assign, nonatomic) CGFloat rootViewLayerBorderWidth;
        [Export("rootViewLayerBorderWidth")]
        nfloat RootViewLayerBorderWidth { get; set; }

        // @property (assign, nonatomic) CGFloat leftViewLayerBorderWidth;
        [Export("leftViewLayerBorderWidth")]
        nfloat LeftViewLayerBorderWidth { get; set; }

        // @property (assign, nonatomic) CGFloat rightViewLayerBorderWidth;
        [Export("rightViewLayerBorderWidth")]
        nfloat RightViewLayerBorderWidth { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable rootViewLayerShadowColor;
        [NullAllowed, Export("rootViewLayerShadowColor", ArgumentSemantic.Strong)]
        UIColor RootViewLayerShadowColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable leftViewLayerShadowColor;
        [NullAllowed, Export("leftViewLayerShadowColor", ArgumentSemantic.Strong)]
        UIColor LeftViewLayerShadowColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable rightViewLayerShadowColor;
        [NullAllowed, Export("rightViewLayerShadowColor", ArgumentSemantic.Strong)]
        UIColor RightViewLayerShadowColor { get; set; }

        // @property (assign, nonatomic) CGFloat rootViewLayerShadowRadius;
        [Export("rootViewLayerShadowRadius")]
        nfloat RootViewLayerShadowRadius { get; set; }

        // @property (assign, nonatomic) CGFloat leftViewLayerShadowRadius;
        [Export("leftViewLayerShadowRadius")]
        nfloat LeftViewLayerShadowRadius { get; set; }

        // @property (assign, nonatomic) CGFloat rightViewLayerShadowRadius;
        [Export("rightViewLayerShadowRadius")]
        nfloat RightViewLayerShadowRadius { get; set; }

        // @property (nonatomic, strong) UIBlurEffect * _Nullable rootViewCoverBlurEffectForLeftView;
        [NullAllowed, Export("rootViewCoverBlurEffectForLeftView", ArgumentSemantic.Strong)]
        UIBlurEffect RootViewCoverBlurEffectForLeftView { get; set; }

        // @property (nonatomic, strong) UIBlurEffect * _Nullable rootViewCoverBlurEffectForRightView;
        [NullAllowed, Export("rootViewCoverBlurEffectForRightView", ArgumentSemantic.Strong)]
        UIBlurEffect RootViewCoverBlurEffectForRightView { get; set; }

        // @property (nonatomic, strong) UIBlurEffect * _Nullable leftViewCoverBlurEffect;
        [NullAllowed, Export("leftViewCoverBlurEffect", ArgumentSemantic.Strong)]
        UIBlurEffect LeftViewCoverBlurEffect { get; set; }

        // @property (nonatomic, strong) UIBlurEffect * _Nullable rightViewCoverBlurEffect;
        [NullAllowed, Export("rightViewCoverBlurEffect", ArgumentSemantic.Strong)]
        UIBlurEffect RightViewCoverBlurEffect { get; set; }

        // @property (assign, nonatomic) CGFloat rootViewCoverAlphaForLeftView;
        [Export("rootViewCoverAlphaForLeftView")]
        nfloat RootViewCoverAlphaForLeftView { get; set; }

        // @property (assign, nonatomic) CGFloat rootViewCoverAlphaForRightView;
        [Export("rootViewCoverAlphaForRightView")]
        nfloat RootViewCoverAlphaForRightView { get; set; }

        // @property (assign, nonatomic) CGFloat leftViewCoverAlpha;
        [Export("leftViewCoverAlpha")]
        nfloat LeftViewCoverAlpha { get; set; }

        // @property (assign, nonatomic) CGFloat rightViewCoverAlpha;
        [Export("rightViewCoverAlpha")]
        nfloat RightViewCoverAlpha { get; set; }

        // @property (assign, nonatomic) BOOL rootViewShouldAutorotate;
        [Export("rootViewShouldAutorotate")]
        bool RootViewShouldAutorotate { get; set; }

        // @property (getter = isRootViewStatusBarHidden, assign, nonatomic) BOOL rootViewStatusBarHidden;
        [Export("rootViewStatusBarHidden")]
        bool RootViewStatusBarHidden { [Bind("isRootViewStatusBarHidden")] get; set; }

        // @property (getter = isLeftViewStatusBarHidden, assign, nonatomic) BOOL leftViewStatusBarHidden;
        [Export("leftViewStatusBarHidden")]
        bool LeftViewStatusBarHidden { [Bind("isLeftViewStatusBarHidden")] get; set; }

        // @property (getter = isRightViewStatusBarHidden, assign, nonatomic) BOOL rightViewStatusBarHidden;
        [Export("rightViewStatusBarHidden")]
        bool RightViewStatusBarHidden { [Bind("isRightViewStatusBarHidden")] get; set; }

        // @property (assign, nonatomic) UIStatusBarStyle rootViewStatusBarStyle;
        [Export("rootViewStatusBarStyle", ArgumentSemantic.Assign)]
        UIStatusBarStyle RootViewStatusBarStyle { get; set; }

        // @property (assign, nonatomic) UIStatusBarStyle leftViewStatusBarStyle;
        [Export("leftViewStatusBarStyle", ArgumentSemantic.Assign)]
        UIStatusBarStyle LeftViewStatusBarStyle { get; set; }

        // @property (assign, nonatomic) UIStatusBarStyle rightViewStatusBarStyle;
        [Export("rightViewStatusBarStyle", ArgumentSemantic.Assign)]
        UIStatusBarStyle RightViewStatusBarStyle { get; set; }

        // @property (assign, nonatomic) UIStatusBarAnimation rootViewStatusBarUpdateAnimation;
        [Export("rootViewStatusBarUpdateAnimation", ArgumentSemantic.Assign)]
        UIStatusBarAnimation RootViewStatusBarUpdateAnimation { get; set; }

        // @property (assign, nonatomic) UIStatusBarAnimation leftViewStatusBarUpdateAnimation;
        [Export("leftViewStatusBarUpdateAnimation", ArgumentSemantic.Assign)]
        UIStatusBarAnimation LeftViewStatusBarUpdateAnimation { get; set; }

        // @property (assign, nonatomic) UIStatusBarAnimation rightViewStatusBarUpdateAnimation;
        [Export("rightViewStatusBarUpdateAnimation", ArgumentSemantic.Assign)]
        UIStatusBarAnimation RightViewStatusBarUpdateAnimation { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable rootViewCoverColorForLeftView;
        [NullAllowed, Export("rootViewCoverColorForLeftView", ArgumentSemantic.Strong)]
        UIColor RootViewCoverColorForLeftView { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable rootViewCoverColorForRightView;
        [NullAllowed, Export("rootViewCoverColorForRightView", ArgumentSemantic.Strong)]
        UIColor RootViewCoverColorForRightView { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable leftViewCoverColor;
        [NullAllowed, Export("leftViewCoverColor", ArgumentSemantic.Strong)]
        UIColor LeftViewCoverColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable rightViewCoverColor;
        [NullAllowed, Export("rightViewCoverColor", ArgumentSemantic.Strong)]
        UIColor RightViewCoverColor { get; set; }

        // @property (assign, nonatomic) CGFloat rootViewScaleForLeftView;
        [Export("rootViewScaleForLeftView")]
        nfloat RootViewScaleForLeftView { get; set; }

        // @property (assign, nonatomic) CGFloat rootViewScaleForRightView;
        [Export("rootViewScaleForRightView")]
        nfloat RootViewScaleForRightView { get; set; }

        // @property (assign, nonatomic) CGFloat leftViewInitialScale;
        [Export("leftViewInitialScale")]
        nfloat LeftViewInitialScale { get; set; }

        // @property (assign, nonatomic) CGFloat rightViewInitialScale;
        [Export("rightViewInitialScale")]
        nfloat RightViewInitialScale { get; set; }

        // @property (assign, nonatomic) CGFloat leftViewInitialOffsetX;
        [Export("leftViewInitialOffsetX")]
        nfloat LeftViewInitialOffsetX { get; set; }

        // @property (assign, nonatomic) CGFloat rightViewInitialOffsetX;
        [Export("rightViewInitialOffsetX")]
        nfloat RightViewInitialOffsetX { get; set; }

        // @property (assign, nonatomic) CGFloat leftViewBackgroundImageInitialScale;
        [Export("leftViewBackgroundImageInitialScale")]
        nfloat LeftViewBackgroundImageInitialScale { get; set; }

        // @property (assign, nonatomic) CGFloat rightViewBackgroundImageInitialScale;
        [Export("rightViewBackgroundImageInitialScale")]
        nfloat RightViewBackgroundImageInitialScale { get; set; }

        // @property (assign, nonatomic) CGFloat leftViewBackgroundImageFinalScale;
        [Export("leftViewBackgroundImageFinalScale")]
        nfloat LeftViewBackgroundImageFinalScale { get; set; }

        // @property (assign, nonatomic) CGFloat rightViewBackgroundImageFinalScale;
        [Export("rightViewBackgroundImageFinalScale")]
        nfloat RightViewBackgroundImageFinalScale { get; set; }

        // @property (readonly, getter = isLeftViewShowing, assign, nonatomic) BOOL leftViewShowing;
        [Export("leftViewShowing")]
        bool LeftViewShowing { [Bind("isLeftViewShowing")] get; }

        // @property (readonly, getter = isRightViewShowing, assign, nonatomic) BOOL rightViewShowing;
        [Export("rightViewShowing")]
        bool RightViewShowing { [Bind("isRightViewShowing")] get; }

        // @property (readonly, getter = isLeftViewHidden, assign, nonatomic) BOOL leftViewHidden;
        [Export("leftViewHidden")]
        bool LeftViewHidden { [Bind("isLeftViewHidden")] get; }

        // @property (readonly, getter = isRightViewHidden, assign, nonatomic) BOOL rightViewHidden;
        [Export("rightViewHidden")]
        bool RightViewHidden { [Bind("isRightViewHidden")] get; }

        // @property (readonly, getter = isLeftViewVisible, assign, nonatomic) BOOL leftViewVisible;
        [Export("leftViewVisible")]
        bool LeftViewVisible { [Bind("isLeftViewVisible")] get; }

        // @property (readonly, getter = isRightViewVisible, assign, nonatomic) BOOL rightViewVisible;
        [Export("rightViewVisible")]
        bool RightViewVisible { [Bind("isRightViewVisible")] get; }

        // @property (readonly, getter = isLeftViewAlwaysVisibleForCurrentOrientation, assign, nonatomic) BOOL leftViewAlwaysVisibleForCurrentOrientation;
        [Export("leftViewAlwaysVisibleForCurrentOrientation")]
        bool LeftViewAlwaysVisibleForCurrentOrientation { [Bind("isLeftViewAlwaysVisibleForCurrentOrientation")] get; }

        // @property (readonly, getter = isRightViewAlwaysVisibleForCurrentOrientation, assign, nonatomic) BOOL rightViewAlwaysVisibleForCurrentOrientation;
        [Export("rightViewAlwaysVisibleForCurrentOrientation")]
        bool RightViewAlwaysVisibleForCurrentOrientation { [Bind("isRightViewAlwaysVisibleForCurrentOrientation")] get; }

        // @property (copy, nonatomic) LGSideMenuHandler _Nullable willShowLeftView;
        [NullAllowed, Export("willShowLeftView", ArgumentSemantic.Copy)]
        LGSideMenuHandler WillShowLeftView { get; set; }

        // @property (copy, nonatomic) LGSideMenuHandler _Nullable didShowLeftView;
        [NullAllowed, Export("didShowLeftView", ArgumentSemantic.Copy)]
        LGSideMenuHandler DidShowLeftView { get; set; }

        // @property (copy, nonatomic) LGSideMenuHandler _Nullable willHideLeftView;
        [NullAllowed, Export("willHideLeftView", ArgumentSemantic.Copy)]
        LGSideMenuHandler WillHideLeftView { get; set; }

        // @property (copy, nonatomic) LGSideMenuHandler _Nullable didHideLeftView;
        [NullAllowed, Export("didHideLeftView", ArgumentSemantic.Copy)]
        LGSideMenuHandler DidHideLeftView { get; set; }

        // @property (copy, nonatomic) LGSideMenuHandler _Nullable willShowRightView;
        [NullAllowed, Export("willShowRightView", ArgumentSemantic.Copy)]
        LGSideMenuHandler WillShowRightView { get; set; }

        // @property (copy, nonatomic) LGSideMenuHandler _Nullable didShowRightView;
        [NullAllowed, Export("didShowRightView", ArgumentSemantic.Copy)]
        LGSideMenuHandler DidShowRightView { get; set; }

        // @property (copy, nonatomic) LGSideMenuHandler _Nullable willHideRightView;
        [NullAllowed, Export("willHideRightView", ArgumentSemantic.Copy)]
        LGSideMenuHandler WillHideRightView { get; set; }

        // @property (copy, nonatomic) LGSideMenuHandler _Nullable didHideRightView;
        [NullAllowed, Export("didHideRightView", ArgumentSemantic.Copy)]
        LGSideMenuHandler DidHideRightView { get; set; }

        // @property (copy, nonatomic) LGSideMenuAnimationsBlock _Nullable showLeftViewAnimations;
        [NullAllowed, Export("showLeftViewAnimations", ArgumentSemantic.Copy)]
        LGSideMenuAnimationsBlock ShowLeftViewAnimations { get; set; }

        // @property (copy, nonatomic) LGSideMenuAnimationsBlock _Nullable hideLeftViewAnimations;
        [NullAllowed, Export("hideLeftViewAnimations", ArgumentSemantic.Copy)]
        LGSideMenuAnimationsBlock HideLeftViewAnimations { get; set; }

        // @property (copy, nonatomic) LGSideMenuAnimationsBlock _Nullable showRightViewAnimations;
        [NullAllowed, Export("showRightViewAnimations", ArgumentSemantic.Copy)]
        LGSideMenuAnimationsBlock ShowRightViewAnimations { get; set; }

        // @property (copy, nonatomic) LGSideMenuAnimationsBlock _Nullable hideRightViewAnimations;
        [NullAllowed, Export("hideRightViewAnimations", ArgumentSemantic.Copy)]
        LGSideMenuAnimationsBlock HideRightViewAnimations { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        LGSideMenuDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<LGSideMenuDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(instancetype _Nonnull)initWithRootViewController:(UIViewController * _Nullable)rootViewController;
        [Export("initWithRootViewController:")]
        IntPtr Constructor([NullAllowed] UIViewController rootViewController);

        // +(instancetype _Nonnull)sideMenuControllerWithRootViewController:(UIViewController * _Nullable)rootViewController;
        [Static]
        [Export("sideMenuControllerWithRootViewController:")]
        LGSideMenuController SideMenuControllerWithRootViewController([NullAllowed] UIViewController rootViewController);

        // -(instancetype _Nonnull)initWithRootViewController:(UIViewController * _Nullable)rootViewController leftViewController:(UIViewController * _Nullable)leftViewController rightViewController:(UIViewController * _Nullable)rightViewController;
        [Export("initWithRootViewController:leftViewController:rightViewController:")]
        IntPtr Constructor([NullAllowed] UIViewController rootViewController, [NullAllowed] UIViewController leftViewController, [NullAllowed] UIViewController rightViewController);

        // +(instancetype _Nonnull)sideMenuControllerWithRootViewController:(UIViewController * _Nullable)rootViewController leftViewController:(UIViewController * _Nullable)leftViewController rightViewController:(UIViewController * _Nullable)rightViewController;
        [Static]
        [Export("sideMenuControllerWithRootViewController:leftViewController:rightViewController:")]
        LGSideMenuController SideMenuControllerWithRootViewController([NullAllowed] UIViewController rootViewController, [NullAllowed] UIViewController leftViewController, [NullAllowed] UIViewController rightViewController);

        // -(instancetype _Nonnull)initWithRootView:(UIView * _Nullable)rootView;
        [Export("initWithRootView:")]
        IntPtr Constructor([NullAllowed] UIView rootView);

        // +(instancetype _Nonnull)sideMenuControllerWithRootView:(UIView * _Nullable)rootView;
        [Static]
        [Export("sideMenuControllerWithRootView:")]
        LGSideMenuController SideMenuControllerWithRootView([NullAllowed] UIView rootView);

        // -(instancetype _Nonnull)initWithRootView:(UIView * _Nullable)rootView leftView:(UIView * _Nullable)leftView rightView:(UIView * _Nullable)rightView;
        [Export("initWithRootView:leftView:rightView:")]
        IntPtr Constructor([NullAllowed] UIView rootView, [NullAllowed] UIView leftView, [NullAllowed] UIView rightView);

        // +(instancetype _Nonnull)sideMenuControllerWithRootView:(UIView * _Nullable)rootView leftView:(UIView * _Nullable)leftView rightView:(UIView * _Nullable)rightView;
        [Static]
        [Export("sideMenuControllerWithRootView:leftView:rightView:")]
        LGSideMenuController SideMenuControllerWithRootView([NullAllowed] UIView rootView, [NullAllowed] UIView leftView, [NullAllowed] UIView rightView);

        // -(void)rootViewWillLayoutSubviewsWithSize:(CGSize)size;
        [Export("rootViewWillLayoutSubviewsWithSize:")]
        void RootViewWillLayoutSubviewsWithSize(CGSize size);

        // -(void)leftViewWillLayoutSubviewsWithSize:(CGSize)size;
        [Export("leftViewWillLayoutSubviewsWithSize:")]
        void LeftViewWillLayoutSubviewsWithSize(CGSize size);

        // -(void)rightViewWillLayoutSubviewsWithSize:(CGSize)size;
        [Export("rightViewWillLayoutSubviewsWithSize:")]
        void RightViewWillLayoutSubviewsWithSize(CGSize size);

        // -(BOOL)isLeftViewAlwaysVisibleForOrientation:(UIInterfaceOrientation)orientation;
        [Export("isLeftViewAlwaysVisibleForOrientation:")]
        bool IsLeftViewAlwaysVisibleForOrientation(UIInterfaceOrientation orientation);

        // -(BOOL)isRightViewAlwaysVisibleForOrientation:(UIInterfaceOrientation)orientation;
        [Export("isRightViewAlwaysVisibleForOrientation:")]
        bool IsRightViewAlwaysVisibleForOrientation(UIInterfaceOrientation orientation);

        // -(void)showLeftView;
        [Export("showLeftView")]
        void ShowLeftView();

        // -(void)hideLeftView;
        [Export("hideLeftView")]
        void HideLeftView();

        // -(void)toggleLeftView;
        [Export("toggleLeftView")]
        void ToggleLeftView();

        // -(void)showLeftView:(id _Nullable)sender __attribute__((ibaction));
        [Export("showLeftView:")]
        void ShowLeftView([NullAllowed] NSObject sender);

        // -(void)hideLeftView:(id _Nullable)sender __attribute__((ibaction));
        [Export("hideLeftView:")]
        void HideLeftView([NullAllowed] NSObject sender);

        // -(void)toggleLeftView:(id _Nullable)sender __attribute__((ibaction));
        [Export("toggleLeftView:")]
        void ToggleLeftView([NullAllowed] NSObject sender);

        // -(void)showLeftViewAnimated;
        [Export("showLeftViewAnimated")]
        void ShowLeftViewAnimated();

        // -(void)hideLeftViewAnimated;
        [Export("hideLeftViewAnimated")]
        void HideLeftViewAnimated();

        // -(void)toggleLeftViewAnimated;
        [Export("toggleLeftViewAnimated")]
        void ToggleLeftViewAnimated();

        // -(void)showLeftViewAnimated:(id _Nullable)sender __attribute__((ibaction));
        [Export("showLeftViewAnimated:")]
        void ShowLeftViewAnimated([NullAllowed] NSObject sender);

        // -(void)hideLeftViewAnimated:(id _Nullable)sender __attribute__((ibaction));
        [Export("hideLeftViewAnimated:")]
        void HideLeftViewAnimated([NullAllowed] NSObject sender);

        // -(void)toggleLeftViewAnimated:(id _Nullable)sender __attribute__((ibaction));
        [Export("toggleLeftViewAnimated:")]
        void ToggleLeftViewAnimated([NullAllowed] NSObject sender);

        // -(void)showLeftViewAnimated:(BOOL)animated completionHandler:(LGSideMenuCompletionHandler)completionHandler;
        [Export("showLeftViewAnimated:completionHandler:")]
        void ShowLeftViewAnimated(bool animated, [NullAllowed] LGSideMenuCompletionHandler completionHandler);

        // -(void)hideLeftViewAnimated:(BOOL)animated completionHandler:(LGSideMenuCompletionHandler)completionHandler;
        [Export("hideLeftViewAnimated:completionHandler:")]
        void HideLeftViewAnimated(bool animated, [NullAllowed] LGSideMenuCompletionHandler completionHandler);

        // -(void)toggleLeftViewAnimated:(BOOL)animated completionHandler:(LGSideMenuCompletionHandler)completionHandler;
        [Export("toggleLeftViewAnimated:completionHandler:")]
        void ToggleLeftViewAnimated(bool animated, [NullAllowed] LGSideMenuCompletionHandler completionHandler);

        // -(void)showLeftViewAnimated:(BOOL)animated delay:(NSTimeInterval)delay completionHandler:(LGSideMenuCompletionHandler)completionHandler;
        [Export("showLeftViewAnimated:delay:completionHandler:")]
        void ShowLeftViewAnimated(bool animated, double delay, [NullAllowed] LGSideMenuCompletionHandler completionHandler);

        // -(void)hideLeftViewAnimated:(BOOL)animated delay:(NSTimeInterval)delay completionHandler:(LGSideMenuCompletionHandler)completionHandler;
        [Export("hideLeftViewAnimated:delay:completionHandler:")]
        void HideLeftViewAnimated(bool animated, double delay, [NullAllowed] LGSideMenuCompletionHandler completionHandler);

        // -(void)toggleLeftViewAnimated:(BOOL)animated delay:(NSTimeInterval)delay completionHandler:(LGSideMenuCompletionHandler)completionHandler;
        [Export("toggleLeftViewAnimated:delay:completionHandler:")]
        void ToggleLeftViewAnimated(bool animated, double delay, [NullAllowed] LGSideMenuCompletionHandler completionHandler);

        // -(void)showRightView;
        [Export("showRightView")]
        void ShowRightView();

        // -(void)hideRightView;
        [Export("hideRightView")]
        void HideRightView();

        // -(void)toggleRightView;
        [Export("toggleRightView")]
        void ToggleRightView();

        // -(void)showRightView:(id _Nullable)sender __attribute__((ibaction));
        [Export("showRightView:")]
        void ShowRightView([NullAllowed] NSObject sender);

        // -(void)hideRightView:(id _Nullable)sender __attribute__((ibaction));
        [Export("hideRightView:")]
        void HideRightView([NullAllowed] NSObject sender);

        // -(void)toggleRightView:(id _Nullable)sender __attribute__((ibaction));
        [Export("toggleRightView:")]
        void ToggleRightView([NullAllowed] NSObject sender);

        // -(void)showRightViewAnimated;
        [Export("showRightViewAnimated")]
        void ShowRightViewAnimated();

        // -(void)hideRightViewAnimated;
        [Export("hideRightViewAnimated")]
        void HideRightViewAnimated();

        // -(void)toggleRightViewAnimated;
        [Export("toggleRightViewAnimated")]
        void ToggleRightViewAnimated();

        // -(void)showRightViewAnimated:(id _Nullable)sender __attribute__((ibaction));
        [Export("showRightViewAnimated:")]
        void ShowRightViewAnimated([NullAllowed] NSObject sender);

        // -(void)hideRightViewAnimated:(id _Nullable)sender __attribute__((ibaction));
        [Export("hideRightViewAnimated:")]
        void HideRightViewAnimated([NullAllowed] NSObject sender);

        // -(void)toggleRightViewAnimated:(id _Nullable)sender __attribute__((ibaction));
        [Export("toggleRightViewAnimated:")]
        void ToggleRightViewAnimated([NullAllowed] NSObject sender);

        // -(void)showRightViewAnimated:(BOOL)animated completionHandler:(LGSideMenuCompletionHandler)completionHandler;
        [Export("showRightViewAnimated:completionHandler:")]
        void ShowRightViewAnimated(bool animated, [NullAllowed] LGSideMenuCompletionHandler completionHandler);

        // -(void)hideRightViewAnimated:(BOOL)animated completionHandler:(LGSideMenuCompletionHandler)completionHandler;
        [Export("hideRightViewAnimated:completionHandler:")]
        void HideRightViewAnimated(bool animated, [NullAllowed] LGSideMenuCompletionHandler completionHandler);

        // -(void)toggleRightViewAnimated:(BOOL)animated completionHandler:(LGSideMenuCompletionHandler)completionHandler;
        [Export("toggleRightViewAnimated:completionHandler:")]
        void ToggleRightViewAnimated(bool animated, [NullAllowed] LGSideMenuCompletionHandler completionHandler);

        // -(void)showRightViewAnimated:(BOOL)animated delay:(NSTimeInterval)delay completionHandler:(LGSideMenuCompletionHandler)completionHandler;
        [Export("showRightViewAnimated:delay:completionHandler:")]
        void ShowRightViewAnimated(bool animated, double delay, [NullAllowed] LGSideMenuCompletionHandler completionHandler);

        // -(void)hideRightViewAnimated:(BOOL)animated delay:(NSTimeInterval)delay completionHandler:(LGSideMenuCompletionHandler)completionHandler;
        [Export("hideRightViewAnimated:delay:completionHandler:")]
        void HideRightViewAnimated(bool animated, double delay, [NullAllowed] LGSideMenuCompletionHandler completionHandler);

        // -(void)toggleRightViewAnimated:(BOOL)animated delay:(NSTimeInterval)delay completionHandler:(LGSideMenuCompletionHandler)completionHandler;
        [Export("toggleRightViewAnimated:delay:completionHandler:")]
        void ToggleRightViewAnimated(bool animated, double delay, [NullAllowed] LGSideMenuCompletionHandler completionHandler);

        // -(void)updateLayoutsAndStyles;
        [Export("updateLayoutsAndStyles")]
        void UpdateLayoutsAndStyles();
    }

    // @protocol LGSideMenuDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface LGSideMenuDelegate
    {
        // @optional -(void)willShowLeftView:(UIView * _Nonnull)leftView sideMenuController:(LGSideMenuController * _Nonnull)sideMenuController;
        [Export("willShowLeftView:sideMenuController:")]
        void WillShowLeftView(UIView leftView, LGSideMenuController sideMenuController);

        // @optional -(void)didShowLeftView:(UIView * _Nonnull)leftView sideMenuController:(LGSideMenuController * _Nonnull)sideMenuController;
        [Export("didShowLeftView:sideMenuController:")]
        void DidShowLeftView(UIView leftView, LGSideMenuController sideMenuController);

        // @optional -(void)willHideLeftView:(UIView * _Nonnull)leftView sideMenuController:(LGSideMenuController * _Nonnull)sideMenuController;
        [Export("willHideLeftView:sideMenuController:")]
        void WillHideLeftView(UIView leftView, LGSideMenuController sideMenuController);

        // @optional -(void)didHideLeftView:(UIView * _Nonnull)leftView sideMenuController:(LGSideMenuController * _Nonnull)sideMenuController;
        [Export("didHideLeftView:sideMenuController:")]
        void DidHideLeftView(UIView leftView, LGSideMenuController sideMenuController);

        // @optional -(void)willShowRightView:(UIView * _Nonnull)rightView sideMenuController:(LGSideMenuController * _Nonnull)sideMenuController;
        [Export("willShowRightView:sideMenuController:")]
        void WillShowRightView(UIView rightView, LGSideMenuController sideMenuController);

        // @optional -(void)didShowRightView:(UIView * _Nonnull)rightView sideMenuController:(LGSideMenuController * _Nonnull)sideMenuController;
        [Export("didShowRightView:sideMenuController:")]
        void DidShowRightView(UIView rightView, LGSideMenuController sideMenuController);

        // @optional -(void)willHideRightView:(UIView * _Nonnull)rightView sideMenuController:(LGSideMenuController * _Nonnull)sideMenuController;
        [Export("willHideRightView:sideMenuController:")]
        void WillHideRightView(UIView rightView, LGSideMenuController sideMenuController);

        // @optional -(void)didHideRightView:(UIView * _Nonnull)rightView sideMenuController:(LGSideMenuController * _Nonnull)sideMenuController;
        [Export("didHideRightView:sideMenuController:")]
        void DidHideRightView(UIView rightView, LGSideMenuController sideMenuController);

        // @optional -(void)showAnimationsForLeftView:(UIView * _Nonnull)leftView sideMenuController:(LGSideMenuController * _Nonnull)sideMenuController duration:(NSTimeInterval)duration;
        [Export("showAnimationsForLeftView:sideMenuController:duration:")]
        void ShowAnimationsForLeftView(UIView leftView, LGSideMenuController sideMenuController, double duration);

        // @optional -(void)hideAnimationsForLeftView:(UIView * _Nonnull)leftView sideMenuController:(LGSideMenuController * _Nonnull)sideMenuController duration:(NSTimeInterval)duration;
        [Export("hideAnimationsForLeftView:sideMenuController:duration:")]
        void HideAnimationsForLeftView(UIView leftView, LGSideMenuController sideMenuController, double duration);

        // @optional -(void)showAnimationsForRightView:(UIView * _Nonnull)rightView sideMenuController:(LGSideMenuController * _Nonnull)sideMenuController duration:(NSTimeInterval)duration;
        [Export("showAnimationsForRightView:sideMenuController:duration:")]
        void ShowAnimationsForRightView(UIView rightView, LGSideMenuController sideMenuController, double duration);

        // @optional -(void)hideAnimationsForRightView:(UIView * _Nonnull)rightView sideMenuController:(LGSideMenuController * _Nonnull)sideMenuController duration:(NSTimeInterval)duration;
        [Export("hideAnimationsForRightView:sideMenuController:duration:")]
        void HideAnimationsForRightView(UIView rightView, LGSideMenuController sideMenuController, double duration);

        // @optional -(void)showAnimationsBlockForLeftView:(UIView * _Nonnull)leftView sideMenuController:(LGSideMenuController * _Nonnull)sideMenuController duration:(NSTimeInterval)duration __attribute__((deprecated("use showAnimationsForRightView:sideMenuController:duration: instead")));
        [Export("showAnimationsBlockForLeftView:sideMenuController:duration:")]
        void ShowAnimationsBlockForLeftView(UIView leftView, LGSideMenuController sideMenuController, double duration);

        // @optional -(void)hideAnimationsBlockForLeftView:(UIView * _Nonnull)leftView sideMenuController:(LGSideMenuController * _Nonnull)sideMenuController duration:(NSTimeInterval)duration __attribute__((deprecated("use hideAnimationsForLeftView:sideMenuController:duration: instead")));
        [Export("hideAnimationsBlockForLeftView:sideMenuController:duration:")]
        void HideAnimationsBlockForLeftView(UIView leftView, LGSideMenuController sideMenuController, double duration);

        // @optional -(void)showAnimationsBlockForRightView:(UIView * _Nonnull)rightView sideMenuController:(LGSideMenuController * _Nonnull)sideMenuController duration:(NSTimeInterval)duration __attribute__((deprecated("use showAnimationsForRightView:sideMenuController:duration: instead")));
        [Export("showAnimationsBlockForRightView:sideMenuController:duration:")]
        void ShowAnimationsBlockForRightView(UIView rightView, LGSideMenuController sideMenuController, double duration);

        // @optional -(void)hideAnimationsBlockForRightView:(UIView * _Nonnull)rightView sideMenuController:(LGSideMenuController * _Nonnull)sideMenuController duration:(NSTimeInterval)duration __attribute__((deprecated("use hideAnimationsForRightView:sideMenuController:duration: instead")));
        [Export("hideAnimationsBlockForRightView:sideMenuController:duration:")]
        void HideAnimationsBlockForRightView(UIView rightView, LGSideMenuController sideMenuController, double duration);
    }

    //[Static]
    partial interface Constants
    {
        // extern NSString *const _Nonnull LGSideMenuControllerWillDismissLeftViewNotification __attribute__((deprecated("use LGSideMenuWillHideLeftViewNotification instead")));
        [Field("LGSideMenuControllerWillDismissLeftViewNotification", "__Internal")]
        NSString LGSideMenuControllerWillDismissLeftViewNotification { get; }

        // extern NSString *const _Nonnull LGSideMenuControllerDidDismissLeftViewNotification __attribute__((deprecated("use LGSideMenuDidHideLeftViewNotification instead")));
        [Field("LGSideMenuControllerDidDismissLeftViewNotification", "__Internal")]
        NSString LGSideMenuControllerDidDismissLeftViewNotification { get; }

        // extern NSString *const _Nonnull LGSideMenuControllerWillDismissRightViewNotification __attribute__((deprecated("use LGSideMenuWillHideRightViewNotification instead")));
        [Field("LGSideMenuControllerWillDismissRightViewNotification", "__Internal")]
        NSString LGSideMenuControllerWillDismissRightViewNotification { get; }

        // extern NSString *const _Nonnull LGSideMenuControllerDidDismissRightViewNotification __attribute__((deprecated("use LGSideMenuDidHideRightViewNotification instead")));
        [Field("LGSideMenuControllerDidDismissRightViewNotification", "__Internal")]
        NSString LGSideMenuControllerDidDismissRightViewNotification { get; }

        // extern NSString *const _Nonnull kLGSideMenuControllerWillShowLeftViewNotification __attribute__((deprecated("use LGSideMenuWillShowLeftViewNotification instead")));
        [Field("kLGSideMenuControllerWillShowLeftViewNotification", "__Internal")]
        NSString kLGSideMenuControllerWillShowLeftViewNotification { get; }

        // extern NSString *const _Nonnull kLGSideMenuControllerWillHideLeftViewNotification __attribute__((deprecated("use LGSideMenuWillHideLeftViewNotification instead")));
        [Field("kLGSideMenuControllerWillHideLeftViewNotification", "__Internal")]
        NSString kLGSideMenuControllerWillHideLeftViewNotification { get; }

        // extern NSString *const _Nonnull kLGSideMenuControllerDidShowLeftViewNotification __attribute__((deprecated("use LGSideMenuDidShowLeftViewNotification instead")));
        [Field("kLGSideMenuControllerDidShowLeftViewNotification", "__Internal")]
        NSString kLGSideMenuControllerDidShowLeftViewNotification { get; }

        // extern NSString *const _Nonnull kLGSideMenuControllerDidHideLeftViewNotification __attribute__((deprecated("use LGSideMenuDidHideLeftViewNotification instead")));
        [Field("kLGSideMenuControllerDidHideLeftViewNotification", "__Internal")]
        NSString kLGSideMenuControllerDidHideLeftViewNotification { get; }

        // extern NSString *const _Nonnull kLGSideMenuControllerWillShowRightViewNotification __attribute__((deprecated("use LGSideMenuWillShowRightViewNotification instead")));
        [Field("kLGSideMenuControllerWillShowRightViewNotification", "__Internal")]
        NSString kLGSideMenuControllerWillShowRightViewNotification { get; }

        // extern NSString *const _Nonnull kLGSideMenuControllerWillHideRightViewNotification __attribute__((deprecated("use LGSideMenuWillHideRightViewNotification instead")));
        [Field("kLGSideMenuControllerWillHideRightViewNotification", "__Internal")]
        NSString kLGSideMenuControllerWillHideRightViewNotification { get; }

        // extern NSString *const _Nonnull kLGSideMenuControllerDidShowRightViewNotification __attribute__((deprecated("use LGSideMenuDidShowRightViewNotification instead")));
        [Field("kLGSideMenuControllerDidShowRightViewNotification", "__Internal")]
        NSString kLGSideMenuControllerDidShowRightViewNotification { get; }

        // extern NSString *const _Nonnull kLGSideMenuControllerDidHideRightViewNotification __attribute__((deprecated("use LGSideMenuDidHideRightViewNotification instead")));
        [Field("kLGSideMenuControllerDidHideRightViewNotification", "__Internal")]
        NSString kLGSideMenuControllerDidHideRightViewNotification { get; }

        // extern NSString *const _Nonnull LGSideMenuControllerWillShowLeftViewNotification __attribute__((deprecated("use LGSideMenuWillShowLeftViewNotification instead")));
        [Field("LGSideMenuControllerWillShowLeftViewNotification", "__Internal")]
        NSString LGSideMenuControllerWillShowLeftViewNotification { get; }

        // extern NSString *const _Nonnull LGSideMenuControllerDidShowLeftViewNotification __attribute__((deprecated("use LGSideMenuDidShowLeftViewNotification instead")));
        [Field("LGSideMenuControllerDidShowLeftViewNotification", "__Internal")]
        NSString LGSideMenuControllerDidShowLeftViewNotification { get; }

        // extern NSString *const _Nonnull LGSideMenuControllerWillHideLeftViewNotification __attribute__((deprecated("use LGSideMenuWillHideLeftViewNotification instead")));
        [Field("LGSideMenuControllerWillHideLeftViewNotification", "__Internal")]
        NSString LGSideMenuControllerWillHideLeftViewNotification { get; }

        // extern NSString *const _Nonnull LGSideMenuControllerDidHideLeftViewNotification __attribute__((deprecated("use LGSideMenuDidHideLeftViewNotification instead")));
        [Field("LGSideMenuControllerDidHideLeftViewNotification", "__Internal")]
        NSString LGSideMenuControllerDidHideLeftViewNotification { get; }

        // extern NSString *const _Nonnull LGSideMenuControllerWillShowRightViewNotification __attribute__((deprecated("use LGSideMenuWillShowRightViewNotification instead")));
        [Field("LGSideMenuControllerWillShowRightViewNotification", "__Internal")]
        NSString LGSideMenuControllerWillShowRightViewNotification { get; }

        // extern NSString *const _Nonnull LGSideMenuControllerDidShowRightViewNotification __attribute__((deprecated("use LGSideMenuDidShowRightViewNotification instead")));
        [Field("LGSideMenuControllerDidShowRightViewNotification", "__Internal")]
        NSString LGSideMenuControllerDidShowRightViewNotification { get; }

        // extern NSString *const _Nonnull LGSideMenuControllerWillHideRightViewNotification __attribute__((deprecated("use LGSideMenuWillHideRightViewNotification instead")));
        [Field("LGSideMenuControllerWillHideRightViewNotification", "__Internal")]
        NSString LGSideMenuControllerWillHideRightViewNotification { get; }

        // extern NSString *const _Nonnull LGSideMenuControllerDidHideRightViewNotification __attribute__((deprecated("use LGSideMenuDidHideRightViewNotification instead")));
        [Field("LGSideMenuControllerDidHideRightViewNotification", "__Internal")]
        NSString LGSideMenuControllerDidHideRightViewNotification { get; }
    }

    // @interface Deprecated (LGSideMenuController)
    //[Category]
    //[BaseType(typeof(LGSideMenuController))]
    //interface LGSideMenuController_Deprecated
    //{
    //    // @property (getter = isShouldShowLeftView, assign, nonatomic) BOOL shouldShowLeftView __attribute__((deprecated("use leftViewEnabled instead")));
    //    [Export("shouldShowLeftView")]
    //    bool ShouldShowLeftView { [Bind("isShouldShowLeftView")] get; set; }

    //    // @property (getter = isShouldShowRightView, assign, nonatomic) BOOL shouldShowRightView __attribute__((deprecated("use rightViewEnabled instead")));
    //    [Export("shouldShowRightView")]
    //    bool ShouldShowRightView { [Bind("isShouldShowRightView")] get; set; }

    //    // @property (readonly, getter = isLeftViewAlwaysVisible, assign, nonatomic) BOOL leftViewAlwaysVisible __attribute__((deprecated("use leftViewAlwaysVisibleForCurrentOrientation instead")));
    //    [Export("leftViewAlwaysVisible")]
    //    bool LeftViewAlwaysVisible { [Bind("isLeftViewAlwaysVisible")] get; }

    //    // @property (readonly, getter = isRightViewAlwaysVisible, assign, nonatomic) BOOL rightViewAlwaysVisible __attribute__((deprecated("use rightViewAlwaysVisibleForCurrentOrientation instead")));
    //    [Export("rightViewAlwaysVisible")]
    //    bool RightViewAlwaysVisible { [Bind("isRightViewAlwaysVisible")] get; }

    //    // @property (assign, nonatomic) NSTimeInterval leftViewAnimationSpeed __attribute__((deprecated("use leftViewAnimationDuration instead")));
    //    [Export("leftViewAnimationSpeed")]
    //    double LeftViewAnimationSpeed { get; set; }

    //    // @property (assign, nonatomic) NSTimeInterval rightViewAnimationSpeed __attribute__((deprecated("use rightViewAnimationDuration instead")));
    //    [Export("rightViewAnimationSpeed")]
    //    double RightViewAnimationSpeed { get; set; }

    //    // @property (copy, nonatomic) LGSideMenuAnimationsBlock _Nullable showLeftViewAnimationsBlock __attribute__((deprecated("use showLeftViewAnimations instead")));
    //    [NullAllowed, Export("showLeftViewAnimationsBlock", ArgumentSemantic.Copy)]
    //    LGSideMenuAnimationsBlock ShowLeftViewAnimationsBlock { get; set; }

    //    // @property (copy, nonatomic) LGSideMenuAnimationsBlock _Nullable hideLeftViewAnimationsBlock __attribute__((deprecated("use hideLeftViewAnimations instead")));
    //    [NullAllowed, Export("hideLeftViewAnimationsBlock", ArgumentSemantic.Copy)]
    //    LGSideMenuAnimationsBlock HideLeftViewAnimationsBlock { get; set; }

    //    // @property (copy, nonatomic) LGSideMenuAnimationsBlock _Nullable showRightViewAnimationsBlock __attribute__((deprecated("use showRightViewAnimations instead")));
    //    [NullAllowed, Export("showRightViewAnimationsBlock", ArgumentSemantic.Copy)]
    //    LGSideMenuAnimationsBlock ShowRightViewAnimationsBlock { get; set; }

    //    // @property (copy, nonatomic) LGSideMenuAnimationsBlock _Nullable hideRightViewAnimationsBlock __attribute__((deprecated("use hideRightViewAnimations instead")));
    //    [NullAllowed, Export("hideRightViewAnimationsBlock", ArgumentSemantic.Copy)]
    //    LGSideMenuAnimationsBlock HideRightViewAnimationsBlock { get; set; }

    //    // -(void)showHideLeftViewAnimated:(BOOL)animated completionHandler:(LGSideMenuCompletionHandler)completionHandler __attribute__((deprecated("use toggleLeftViewAnimated:completionHandler instead")));
    //    [Export("showHideLeftViewAnimated:completionHandler:")]
    //    void ShowHideLeftViewAnimated(bool animated, [NullAllowed] LGSideMenuCompletionHandler completionHandler);

    //    // -(void)showHideRightViewAnimated:(BOOL)animated completionHandler:(LGSideMenuCompletionHandler)completionHandler __attribute__((deprecated("use toggleRightViewAnimated:completionHandler instead")));
    //    [Export("showHideRightViewAnimated:completionHandler:")]
    //    void ShowHideRightViewAnimated(bool animated, [NullAllowed] LGSideMenuCompletionHandler completionHandler);

    //    // -(BOOL)isLeftViewAlwaysVisibleForInterfaceOrientation:(UIInterfaceOrientation)interfaceOrientation __attribute__((deprecated("use isLeftViewAlwaysVisibleForOrientation instead")));
    //    [Export("isLeftViewAlwaysVisibleForInterfaceOrientation:")]
    //    bool IsLeftViewAlwaysVisibleForInterfaceOrientation(UIInterfaceOrientation interfaceOrientation);

    //    // -(BOOL)isRightViewAlwaysVisibleForInterfaceOrientation:(UIInterfaceOrientation)interfaceOrientation __attribute__((deprecated("use isRightViewAlwaysVisibleForOrientation instead")));
    //    [Export("isRightViewAlwaysVisibleForInterfaceOrientation:")]
    //    bool IsRightViewAlwaysVisibleForInterfaceOrientation(UIInterfaceOrientation interfaceOrientation);

    //    // -(void)setLeftViewEnabledWithWidth:(CGFloat)width presentationStyle:(LGSideMenuPresentationStyle)presentationStyle alwaysVisibleOptions:(LGSideMenuAlwaysVisibleOptions)alwaysVisibleOptions __attribute__((deprecated("")));
    //    [Export("setLeftViewEnabledWithWidth:presentationStyle:alwaysVisibleOptions:")]
    //    void SetLeftViewEnabledWithWidth(nfloat width, LGSideMenuPresentationStyle presentationStyle, LGSideMenuAlwaysVisibleOptions alwaysVisibleOptions);

    //    // -(void)setRightViewEnabledWithWidth:(CGFloat)width presentationStyle:(LGSideMenuPresentationStyle)presentationStyle alwaysVisibleOptions:(LGSideMenuAlwaysVisibleOptions)alwaysVisibleOptions __attribute__((deprecated("")));
    //    [Export("setRightViewEnabledWithWidth:presentationStyle:alwaysVisibleOptions:")]
    //    void SetRightViewEnabledWithWidth(nfloat width, LGSideMenuPresentationStyle presentationStyle, LGSideMenuAlwaysVisibleOptions alwaysVisibleOptions);
    //}

    // @interface LGSideMenuGesturesHandler : NSObject <UIGestureRecognizerDelegate>
    [BaseType(typeof(NSObject))]
    interface LGSideMenuGesturesHandler : IUIGestureRecognizerDelegate
    {
        // @property (assign, nonatomic) LGSideMenuController * _Nonnull sideMenuController;
        [Export("sideMenuController", ArgumentSemantic.Assign)]
        LGSideMenuController SideMenuController { get; }

        // @property (nonatomic, weak) UIView * _Nullable rootViewContainer;
        [NullAllowed, Export("rootViewContainer", ArgumentSemantic.Weak)]
        UIView RootViewContainer { get; set; }

        // @property (nonatomic, weak) UIView * _Nullable leftViewContainer;
        [NullAllowed, Export("leftViewContainer", ArgumentSemantic.Weak)]
        UIView LeftViewContainer { get; set; }

        // @property (nonatomic, weak) UIView * _Nullable rightViewContainer;
        [NullAllowed, Export("rightViewContainer", ArgumentSemantic.Weak)]
        UIView RightViewContainer { get; set; }

        // @property (nonatomic, weak) UIView * _Nullable rootViewCoverView;
        [NullAllowed, Export("rootViewCoverView", ArgumentSemantic.Weak)]
        UIView RootViewCoverView { get; set; }

        // @property (getter = isAnimating, assign, nonatomic) BOOL animating;
        [Export("animating")]
        bool Animating { [Bind("isAnimating")] get; set; }

        // -(instancetype _Nonnull)initWithSideMenuController:(LGSideMenuController * _Nonnull)sideMenuController;
        [Export("initWithSideMenuController:")]
        IntPtr Constructor(LGSideMenuController sideMenuController);
    }

    // @interface LGSideMenuHelper : NSObject
    [BaseType(typeof(NSObject))]
    interface LGSideMenuHelper
    {
        // +(void)animateWithDuration:(NSTimeInterval)duration animations:(void (^)())animations completion:(void (^)(BOOL))completion;
        [Static]
        [Export("animateWithDuration:animations:completion:")]
        void AnimateWithDuration(double duration, Action animations, Action<bool> completion);

        // +(void)statusBarAppearanceUpdateAnimated:(BOOL)animated viewController:(UIViewController *)viewController duration:(NSTimeInterval)duration hidden:(BOOL)hidden style:(UIStatusBarStyle)style animation:(UIStatusBarAnimation)animation;
        [Static]
        [Export("statusBarAppearanceUpdateAnimated:viewController:duration:hidden:style:animation:")]
        void StatusBarAppearanceUpdateAnimated(bool animated, UIViewController viewController, double duration, bool hidden, UIStatusBarStyle style, UIStatusBarAnimation animation);

        // +(void)imageView:(UIImageView *)imageView setImageSafe:(UIImage *)image;
        [Static]
        [Export("imageView:setImageSafe:")]
        void ImageView(UIImageView imageView, UIImage image);

        // +(BOOL)isViewControllerBasedStatusBarAppearance;
        [Static]
        [Export("isViewControllerBasedStatusBarAppearance")]
        bool IsViewControllerBasedStatusBarAppearance { get; }

        // +(BOOL)isNotRetina;
        [Static]
        [Export("isNotRetina")]
        bool IsNotRetina { get; }

        // +(BOOL)isPhone;
        [Static]
        [Export("isPhone")]
        bool IsPhone { get; }

        // +(BOOL)isPad;
        [Static]
        [Export("isPad")]
        bool IsPad { get; }
    }

    // @interface LGSideMenuSegue : UIStoryboardSegue
    [BaseType(typeof(UIStoryboardSegue))]
    interface LGSideMenuSegue
    {
    }

    // @interface LGSideMenuView : UIView
    [BaseType(typeof(UIView))]
    interface LGSideMenuView
    {
        // -(instancetype _Nonnull)initWithLayoutSubviewsHandler:(void (^ _Nonnull)())layoutSubviewsHandler;
        [Export("initWithLayoutSubviewsHandler:")]
        IntPtr Constructor(Action layoutSubviewsHandler);
    }

    // @interface LGSideMenuController (UIViewController)
    [Category]
    [BaseType(typeof(UIViewController))]
    interface UIViewController_LGSideMenuController
    {
        // @property (readonly, nonatomic, weak) LGSideMenuController * _Nullable sideMenuController;
        [NullAllowed, Export("sideMenuController", ArgumentSemantic.Retain)]
        LGSideMenuController GetSideMenuController(); 

        // -(void)showLeftView:(id _Nullable)sender __attribute__((ibaction));
        [Export("showLeftView:")]
        void ShowLeftView([NullAllowed] NSObject sender);

        // -(void)hideLeftView:(id _Nullable)sender __attribute__((ibaction));
        [Export("hideLeftView:")]
        void HideLeftView([NullAllowed] NSObject sender);

        // -(void)toggleLeftView:(id _Nullable)sender __attribute__((ibaction));
        [Export("toggleLeftView:")]
        void ToggleLeftView([NullAllowed] NSObject sender);

        // -(void)showLeftViewAnimated:(id _Nullable)sender __attribute__((ibaction));
        [Export("showLeftViewAnimated:")]
        void ShowLeftViewAnimated([NullAllowed] NSObject sender);

        // -(void)hideLeftViewAnimated:(id _Nullable)sender __attribute__((ibaction));
        [Export("hideLeftViewAnimated:")]
        void HideLeftViewAnimated([NullAllowed] NSObject sender);

        // -(void)toggleLeftViewAnimated:(id _Nullable)sender __attribute__((ibaction));
        [Export("toggleLeftViewAnimated:")]
        void ToggleLeftViewAnimated([NullAllowed] NSObject sender);

        // -(void)showRightView:(id _Nullable)sender __attribute__((ibaction));
        [Export("showRightView:")]
        void ShowRightView([NullAllowed] NSObject sender);

        // -(void)hideRightView:(id _Nullable)sender __attribute__((ibaction));
        [Export("hideRightView:")]
        void HideRightView([NullAllowed] NSObject sender);

        // -(void)toggleRightView:(id _Nullable)sender __attribute__((ibaction));
        [Export("toggleRightView:")]
        void ToggleRightView([NullAllowed] NSObject sender);

        // -(void)showRightViewAnimated:(id _Nullable)sender __attribute__((ibaction));
        [Export("showRightViewAnimated:")]
        void ShowRightViewAnimated([NullAllowed] NSObject sender);

        // -(void)hideRightViewAnimated:(id _Nullable)sender __attribute__((ibaction));
        [Export("hideRightViewAnimated:")]
        void HideRightViewAnimated([NullAllowed] NSObject sender);

        // -(void)toggleRightViewAnimated:(id _Nullable)sender __attribute__((ibaction));
        [Export("toggleRightViewAnimated:")]
        void ToggleRightViewAnimated([NullAllowed] NSObject sender);
    }

    // @interface LGSideMenuControllerDeprecated (UIViewController)
    [Category]
    [BaseType(typeof(UIViewController))]
    interface UIViewController_LGSideMenuControllerDeprecated
    {
        // -(void)openLeftView:(id _Nullable)sender __attribute__((deprecated(""))) __attribute__((ibaction));
        [Export("openLeftView:")]
        void OpenLeftView([NullAllowed] NSObject sender);

        // -(void)openRightView:(id _Nullable)sender __attribute__((deprecated(""))) __attribute__((ibaction));
        [Export("openRightView:")]
        void OpenRightView([NullAllowed] NSObject sender);
    }

    //[Static]
    partial interface Constants
    {
        // extern double LGSideMenuControllerVersionNumber;
        [Field("LGSideMenuControllerVersionNumber", "__Internal")]
        double LGSideMenuControllerVersionNumber { get; }

        // extern const unsigned char [] LGSideMenuControllerVersionString;
        [Field("LGSideMenuControllerVersionString", "__Internal")]
       NSString LGSideMenuControllerVersionString { get; }
    }

}
