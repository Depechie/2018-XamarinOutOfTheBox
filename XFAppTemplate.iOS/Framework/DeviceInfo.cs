using System;
using UIKit;
using Xamarin.Forms;
using XFAppTemplate.Framework;
using XFAppTemplate.iOS.Framework;

[assembly: Dependency(typeof(DeviceInfo))]
namespace XFAppTemplate.iOS.Framework
{
	public class DeviceInfo : IDeviceInfo
	{
		public float StatusbarHeight => (float)UIApplication.SharedApplication.StatusBarFrame.Size.Height;
	}
}