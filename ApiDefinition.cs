using System;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MonoTouch.ALAlertBanner
{
    [BaseType(typeof(UIView))]
    public partial interface ALAlertBanner
    {
        [Export("style")]
        ALAlertBannerStyle Style { get; }

        [Export("position")]
        ALAlertBannerPosition Position { get; }

        [Export("state")]
        ALAlertBannerState State { get; }

        [Export("secondsToShow")]
        double SecondsToShow { get; set; }

        [Export("allowTapToDismiss")]
        bool AllowTapToDismiss { get; set; }

        [Export("showAnimationDuration")]
        double ShowAnimationDuration { get; set; }

        [Export("hideAnimationDuration")]
        double HideAnimationDuration { get; set; }

        [Export("bannerOpacity")]
        float BannerOpacity { get; set; }

        [Static, Export("alertBannerForView:style:position:title:")]
        ALAlertBanner AlertBannerForView(UIView view, ALAlertBannerStyle style, ALAlertBannerPosition position, string title);

        [Static, Export("alertBannerForView:style:position:title:subtitle:")]
        ALAlertBanner AlertBannerForView(UIView view, ALAlertBannerStyle style, ALAlertBannerPosition position, string title, string subtitle);
        // TODO System.Delegate produces a compile error
        //[Static, Export ("alertBannerForView:style:position:title:subtitle:tappedBlock:")]
        //ALAlertBanner AlertBannerForView (UIView view, ALAlertBannerStyle style, ALAlertBannerPosition position, string title, string subtitle, Delegate tappedBlock);
        [Export("show")]
        void Show();

        [Export("hide")]
        void Hide();

        [Static, Export("alertBannersInView:")]
        NSObject [] AlertBannersInView(UIView view);

        [Static, Export("hideAllAlertBanners")]
        void HideAllAlertBanners();

        [Static, Export("hideAlertBannersInView:")]
        void HideAlertBannersInView(UIView view);

        [Static, Export("forceHideAllAlertBannersInView:")]
        void ForceHideAllAlertBannersInView(UIView view);

        [Static, Export("setDefaultFontSizeForTitle:subtitle:")]
        void SetDefaultFontSizeForTitle(float titleSize, float subtitleSize);
    }

    [BaseType(typeof(NSObject))]
    public partial interface ALAlertBannerManager
    {
        [Static, Export("sharedManager")]
        ALAlertBannerManager SharedManager { get; }

        [Export("alertBannersInView:")]
        NSObject [] AlertBannersInView(UIView view);

        [Export("hideAllAlertBanners")]
        void HideAllAlertBanners();

        [Export("hideAlertBannersInView:")]
        void HideAlertBannersInView(UIView view);

        [Export("forceHideAllAlertBannersInView:")]
        void ForceHideAllAlertBannersInView(UIView view);
    }
}
