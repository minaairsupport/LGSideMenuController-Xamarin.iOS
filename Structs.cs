using System;

namespace LGSideMenuController
{
//[Native]
public enum LGSideMenuAlwaysVisibleOptions : int
{
    None = 0,
    Landscape = 1 << 1,
    Portrait = 1 << 2,
    Pad = 1 << 3,
    Phone = 1 << 4,
    PadLandscape = 1 << 5,
    PadPortrait = 1 << 6,
    PhoneLandscape = 1 << 7,
    PhonePortrait = 1 << 8,
    All = 1 << 9
}


public enum LGSideMenuPresentationStyle : int
{
    lideAbove = 0,
    lideBelow = 1,
    caleFromBig = 2,
    caleFromLittle = 3
}


public enum LGSideMenuSwipeGestureArea : int
{
    Borders = 0,
    Full = 1
}

public struct LGSideMenuSwipeGestureRange
{
    public nfloat left;

    public nfloat right;
}

//static class CFunctions
//{
//    // extern LGSideMenuSwipeGestureRange LGSideMenuSwipeGestureRangeMake (CGFloat left, CGFloat right);
//    [DllImport ("__Internal")]
//    //[Verify (PlatformInvoke)]
//    static extern LGSideMenuSwipeGestureRange LGSideMenuSwipeGestureRangeMake (nfloat left, nfloat right);
//}
}
