// This file has been autogenerated from parsing an Objective-C header file added in Xcode.

using System;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Tapit;

namespace TapitExample
{
	public partial class SecondViewController : UIViewController
	{
		
		TapItInterstitialAd interstitialAd;
		public SecondViewController (IntPtr handle) : base (handle)
		{
		}

		partial void loadInterstitial (NSObject sender)
		{
			interstitialAd = new TapItInterstitialAd();
			interstitialAd.ControlType = TapItInterstitialControlType.Lightbox;
			interstitialAd.Animated = true;
		}
		partial void showInterstitial (NSObject sender)
		{
			interstitialAd.PresentFromViewController(this);
		}
	}
}
