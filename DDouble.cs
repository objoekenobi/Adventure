using System;

namespace Dbasic
{
	public struct DDouble
	{
		private double d;

		public DDouble(double d)
		{
			this.d = d;
		}

		public static implicit operator double(DDouble m)
		{
			return m.d;
		}

		public static double operator *(double a, DDouble b)
		{
			return Math.Pow(a, (double)b);
		}
	}
}
