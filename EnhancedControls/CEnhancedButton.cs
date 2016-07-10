using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Dbasic.EnhancedControls
{
	public class CEnhancedButton : Button, IEnhancedControl, IEnabled, IText
	{
		public string name;
		private b4p b4p;
		private b4p.del1 delKeyPress;
		private b4p.del0 delClick;

		public string propName
		{
			get
			{
				return this.name;
			}
		}

		bool IEnabled.Enabled { get; set; }

		public CEnhancedButton(b4p b4p)
		{
			this.b4p = b4p;
		}

		public void AddEvents()
		{
			try
			{
				if (this.b4p.htSubs.Contains((object)(this.name + "_click")))
				{
					this.delClick = (b4p.del0)this.b4p.htSubs[(object)(this.name + "_click")];
					this.Click += new EventHandler(this.ClickEvent);
				}
				if (!this.b4p.htSubs.Contains((object)(this.name + "_keypress")))
				{
					return;
				}

				this.delKeyPress = (b4p.del1)this.b4p.htSubs[(object)(this.name + "_keypress")];
				this.KeyPress += new KeyPressEventHandler(this.KeyPressEvent);
			}
			catch
			{
				throw new Exception("Error assigning event to " + this.name.Remove(0, 1) + ".\nCheck the number of arguments of each event sub.");
			}
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
					case "keypress":
						this.delKeyPress = (b4p.del1)this.b4p.htSubs[(object)subName];
						this.KeyPress += new KeyPressEventHandler(this.KeyPressEvent);
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

		private void KeyPressEvent(object sender, KeyPressEventArgs e)
		{
			this.b4p.sender = this.name;
			string str = this.delKeyPress(e.KeyChar.ToString((IFormatProvider)b4p.cul));
		}
	}
}
