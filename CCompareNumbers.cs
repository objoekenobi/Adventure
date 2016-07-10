using System;
using System.Collections;

namespace Dbasic
{
	public class CCompareNumbers : IComparer
	{
		public int Compare(object x, object y)
		{
			return double.Parse(x.ToString(), (IFormatProvider)b4p.cul).CompareTo(double.Parse(y.ToString(), (IFormatProvider)b4p.cul));
		}
	}
}
