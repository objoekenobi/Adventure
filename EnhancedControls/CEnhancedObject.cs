using System;
using System.Collections;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Dbasic.EnhancedControls
{
	public class CEnhancedObject
	{
		public Hashtable htShemotAzamim = new Hashtable();
		private b4p b4p;
		private object eventObject;
		private EventHandler doMethod;

		public CEnhancedObject(b4p b4p)
		{
			this.b4p = b4p;
			this.doMethod = new EventHandler(this.MetapelEruim2);
		}

		public Control GetControlStringOrRef(string module, object o)
		{
			if (o is string)
				return (Control)this.b4p.htControls[(object)("_" + Other.FixRuntimeControlName(o.ToString().ToLower(b4p.cul), module))];
			return (Control)o;
		}

		public void AddRunTimeEvent(object o, string name, string eventName, string subName)
		{
			EventInfo @event = o.GetType().GetEvent(eventName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
			this.b4p.htSubs.Remove((object)(name + "_" + eventName));
			this.b4p.htSubs.Add((object)(name + "_" + eventName), this.b4p.htSubs[(object)subName]);
			if (@event == null)
				throw new Exception("Event does not exist in object.");
			@event.AddEventHandler(o, (Delegate)new EventHandler(this.MetapelEruim));
		}

		public void AddEventsForUnknownControls(object o, string name)
		{
			foreach (EventInfo @event in o.GetType().GetEvents(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public))
			{
				if (this.b4p.htSubs.Contains((object)(name + "_" + @event.Name.ToLower(b4p.cul))))
					@event.AddEventHandler(o, (Delegate)new EventHandler(this.MetapelEruim));
			}
		}

		public void MetapelEruim(object sender, EventArgs e)
		{
			try
			{
				if (this.b4p.tdRunning != null && this.b4p.tdRunning != Thread.CurrentThread)
				{
					this.eventObject = sender;
					if (this.b4p.mainForm == null)
						return;
					this.b4p.mainForm.Invoke((Delegate)this.doMethod);
				}
				else
				{
					object[] objArray = (object[])sender;
					string str1 = (string)this.htShemotAzamim[objArray[0]];
					this.b4p.sender = str1;
					string str2 = ((b4p.del0)this.b4p.htSubs[(object)(str1 + "_" + ((string)objArray[1]).ToLower(b4p.cul))])();
				}
			}
			catch
			{
			}
		}

		private void MetapelEruim2(object sender, EventArgs e)
		{
			try
			{
				object[] objArray = (object[])this.eventObject;
				this.eventObject = (object)null;
				string str1 = (string)this.htShemotAzamim[objArray[0]];
				this.b4p.sender = str1;
				string str2 = ((b4p.del0)this.b4p.htSubs[(object)(str1 + "_" + ((string)objArray[1]).ToLower(b4p.cul))])();
			}
			catch
			{
			}
		}
	}
}
