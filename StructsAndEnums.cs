using System;

namespace MonoTouch.ALAlertBanner
{
    public enum ALAlertBannerStyle
    {
        Success = 0,
        Failure,
        Notify,
        Warning
    }

    public enum ALAlertBannerPosition
    {
        Top = 0,
        Bottom,
        UnderNavBar
    }

    public enum ALAlertBannerState
    {
        Showing = 0,
        Hiding,
        MovingForward,
        MovingBackward,
        Visible,
        Hidden
    }
}
