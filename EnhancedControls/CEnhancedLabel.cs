using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Dbasic.EnhancedControls
{
	public class CEnhancedLabel : Label, IEnhancedControl, IEnabled, IText
	{
		public string name;
		private b4p b4p;

		public string propName
		{
			get
			{
				return this.name;
			}
		}

		bool IEnabled.Enabled { get; set; }

		public CEnhancedLabel(b4p b4p)
		{
			this.b4p = b4p;
		}

		void IEnhancedControl.AddRunTimeEvent(string eventName, string subName)
		{
		}
	}
}
