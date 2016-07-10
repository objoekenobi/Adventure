using System;
using System.Windows.Forms;

namespace bDeviceInfo
{
	public class Class_bDeviceInfo : IDisposable
	{
		public void Dispose()
		{
		}

		public int GetDisplayHeight()
		{
			return Screen.PrimaryScreen.Bounds.Height;
		}

		public int GetDisplayWidth()
		{
			return Screen.PrimaryScreen.Bounds.Width;
		}

		public string GetOSVersionString()
		{
			return Environment.OSVersion.ToString();
		}
	}
}
