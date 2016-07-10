using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Dbasic.EnhancedControls
{
	public class CEnhancedImage : PictureBox, IEnhancedControl, IImage, IEnabled
	{
		public string picFile = "";
		public string imageMode = "CNormalImage";
		public string name;
		private b4p b4p;
		private b4p.del0 delClick;

		public string propName
		{
			get
			{
				return this.name;
			}
		}

		public Bitmap MyBitmap
		{
			get
			{
				return (Bitmap)this.Image;
			}
			set
			{
				this.Image = (Image)value;
			}
		}

		bool IEnabled.Enabled { get; set; }

		public string MyImageMode
		{
			get
			{
				return this.imageMode;
			}
			set
			{
				switch (value.ToLower(b4p.cul))
				{
					case "cstretchimage":
						this.SizeMode = PictureBoxSizeMode.StretchImage;
						break;
					case "ccenterimage":
						this.SizeMode = PictureBoxSizeMode.CenterImage;
						break;
					default:
						this.SizeMode = PictureBoxSizeMode.Normal;
						break;
				}
				this.imageMode = value;
			}
		}

		public CEnhancedImage(b4p b4p)
		{
			this.b4p = b4p;
			this.SizeMode = PictureBoxSizeMode.Normal;
		}

		public void AddRunTimeEvent(string eventName, string subName)
		{
			try
			{
				switch (eventName)
				{
					case "click":
						this.delClick = (b4p.del0)this.b4p.htSubs[(object)subName];
						this.Click += new EventHandler(this.ClickEvent);
						break;
				}
			}
			catch
			{
				throw new Exception("Error assigning event to " + this.name.Remove(0, 1) + ".\nCheck the number of arguments of each event sub.");
			}
		}

		private void ClickEvent(object sender, EventArgs e)
		{
			this.b4p.sender = this.name;
			string str = this.delClick();
		}

		public void AddEvents()
		{
			try
			{
				if (!this.b4p.htSubs.Contains((object)(this.name + "_click")))
					return;
				this.delClick = (b4p.del0)this.b4p.htSubs[(object)(this.name + "_click")];
				this.Click += new EventHandler(this.ClickEvent);
			}
			catch
			{
				throw new Exception("Error assigning event to " + this.name.Remove(0, 1) + ".\nCheck the number of arguments of each event sub.");
			}
		}
	}
}
