using System.IO;
using System.Text;

namespace Dbasic
{
	public class CStreamReader : StreamReader, IStream
	{
		public CStreamReader(string path, Encoding encoding)
			: base(path, encoding) { }
	}
}
