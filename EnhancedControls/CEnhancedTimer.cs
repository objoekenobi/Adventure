using System;
using System.Windows.Forms;

namespace Dbasic.EnhancedControls
{
	public class CEnhancedTimer : Timer, IEnhancedControl, IEnabled
	{
		public string name;
		private b4p b4p;
		private b4p.del0 delTick;

		public string propName
		{
			get
			{
				return this.name;
			}
		}

		string IEnhancedControl.propName
		{
			get
			{
				return this.name;
			}
		}

		public CEnhancedTimer(b4p b4p)
		{
			this.b4p = b4p;
		}

		public void AddEvents()
		{
			try
			{
				if (!this.b4p.htSubs.Contains((object)(this.name + "_tick")))
					return;
				this.delTick = (b4p.del0)this.b4p.htSubs[(object)(this.name + "_tick")];
				this.Tick += new EventHandler(this.TickEvent);
			}
			catch
			{
				throw new Exception("Error assigning event to " + this.name.Remove(0, 1) + ".\nCheck the number of arguments of each event sub.");
			}
		}

		public void AddRunTimeEvent(string eventName, string subName)
		{
			switch (eventName)
			{
				case "tick":
					this.delTick = (b4p.del0)this.b4p.htSubs[(object)subName];
					this.Tick += new EventHandler(this.TickEvent);
					break;
			}
		}

		private void TickEvent(object sender, EventArgs e)
		{
			this.b4p.sender = this.name;
			string str = this.delTick();
		}
	}
}
