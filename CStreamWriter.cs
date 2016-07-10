using System.IO;
using System.Text;

namespace Dbasic
{
	public class CStreamWriter : StreamWriter, IStream
	{
		public CStreamWriter(string path, bool append, Encoding encoding)
			: base(path, append, encoding) { }
	}
}
