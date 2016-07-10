using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Dbasic.EnhancedControls
{
	public class CEnhancedCombo : ComboBox, IEnhancedControl, IEnabled, IText
	{
		public string name;
		private b4p b4p;
		private b4p.del0 delGotFocus;
		private b4p.del0 delLostFocus;
		private b4p.del2 delIndexChanged;

		public string propName
		{
			get
			{
				return this.name;
			}
		}

		bool IEnabled.Enabled { get; set; }

		public CEnhancedCombo(b4p b4p)
		{
			this.b4p = b4p;
		}

		public void AddRunTimeEvent(string eventName, string subName)
		{
			try
			{
				switch (eventName)
				{
					case "gotfocus":
						this.delGotFocus = (b4p.del0)this.b4p.htSubs[(object)subName];
						this.GotFocus += new EventHandler(this.GotFocusEvent);
						break;
					case "lostfocus":
						this.delLostFocus = (b4p.del0)this.b4p.htSubs[(object)subName];
						this.LostFocus += new EventHandler(this.LostFocusEvent);
						break;
					case "selectionchanged":
						this.delIndexChanged = (b4p.del2)this.b4p.htSubs[(object)subName];
						this.SelectedIndexChanged += new EventHandler(this.SelectedIndexChangedEvent);
						break;
				}
			}
			catch
			{
				throw new Exception("Error assigning event to " + this.name.Remove(0, 1) + ".\nCheck the number of arguments of each event sub.");
			}
		}

		private void GotFocusEvent(object sender, EventArgs e)
		{
			this.b4p.sender = this.name;
			string str = this.delGotFocus();
		}

		private void LostFocusEvent(object sender, EventArgs e)
		{
			this.b4p.sender = this.name;
			string str = this.delLostFocus();
		}

		private void SelectedIndexChangedEvent(object sender, EventArgs e)
		{
			this.b4p.sender = this.name;
			string str = this.delIndexChanged(this.SelectedIndex.ToString((IFormatProvider)b4p.cul), this.SelectedIndex > -1 ? this.SelectedItem.ToString() : "");
		}

		public void AddEvents()
		{
			try
			{
				if (this.b4p.htSubs.Contains((object)(this.name + "_gotfocus")))
				{
					this.delGotFocus = (b4p.del0)this.b4p.htSubs[(object)(this.name + "_gotfocus")];
					this.GotFocus += new EventHandler(this.GotFocusEvent);
				}
				if (this.b4p.htSubs.Contains((object)(this.name + "_lostfocus")))
				{
					this.delLostFocus = (b4p.del0)this.b4p.htSubs[(object)(this.name + "_lostfocus")];
					this.LostFocus += new EventHandler(this.LostFocusEvent);
				}
				if (!this.b4p.htSubs.Contains((object)(this.name + "_selectionchanged")))
				{
					return;
				}
				this.delIndexChanged = (b4p.del2)this.b4p.htSubs[(object)(this.name + "_selectionchanged")];
				this.SelectedIndexChanged += new EventHandler(this.SelectedIndexChangedEvent);
			}
			catch
			{
				throw new Exception("Error assigning event to " + this.name.Remove(0, 1) + ".\nCheck the number of arguments of each event sub.");
			}
		}
	}
}
