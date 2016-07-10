namespace Dbasic
{
	public interface IEnhancedControl
	{
		string propName { get; }

		void AddRunTimeEvent(string eventName, string subName);
	}
}
