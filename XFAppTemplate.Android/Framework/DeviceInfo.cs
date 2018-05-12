using System;
using Xamarin.Forms;
using XFAppTemplate.Droid.Framework;
using XFAppTemplate.Framework;

[assembly: Dependency(typeof(DeviceInfo))]
namespace XFAppTemplate.Droid.Framework
{
	public class DeviceInfo : IDeviceInfo
    {
        public float StatusbarHeight => 0;
    }
}