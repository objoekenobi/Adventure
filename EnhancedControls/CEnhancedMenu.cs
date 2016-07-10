using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Dbasic.EnhancedControls
{
	public class CEnhancedMenu : MenuItem, IEnhancedControl, IEnabled, IText, IChecked
	{
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

		bool IEnabled.Enabled { get; set; }

		string IText.Text { get; set; }

		bool IChecked.Checked { get; set; }

		public CEnhancedMenu(b4p b4p)
		{
			this.b4p = b4p;
		}

		public void AddToObject(string parent)
		{
			object obj = this.b4p.htControls[(object)parent];
			if (obj is CEnhancedForm)
			{
				((CEnhancedForm)obj).AddMenu();
				((CEnhancedForm)obj).mainMenu1.MenuItems.Add((MenuItem)this);
			}
			else
				((Menu)obj).MenuItems.Add((MenuItem)this);
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

		private void ClickEvent(object sender, EventArgs e)
		{
			this.b4p.sender = this.name;
			string str = this.delClick();
		}
	}
}
