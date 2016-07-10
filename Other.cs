using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace Dbasic
{
	public class Other
	{
		private int SND_ASYNC = 1;
		private int SND_FILENAME = 131072;
		private b4p b4p;

		public Other(b4p b4p)
		{
			this.b4p = b4p;
		}

		public double FileSearch(string al, string path, string pattern)
		{
			ArrayList arrayList = (ArrayList)this.b4p.htControls[(object)al];
			arrayList.AddRange((ICollection)Directory.GetFiles(Path.Combine(this.b4p.b4pdir, path), pattern));
			return (double)arrayList.Count;
		}

		public double DirSearch(string al, string path, string pattern)
		{
			ArrayList arrayList = (ArrayList)this.b4p.htControls[(object)al];
			arrayList.AddRange((ICollection)Directory.GetDirectories(Path.Combine(this.b4p.b4pdir, path), pattern));
			return (double)arrayList.Count;
		}

		[DllImport("WinMM.dll")]
		public static extern bool PlaySound(string fname, int Mod, int flag);

		public void Sound(string file)
		{
			Other.PlaySound(file, 0, this.SND_FILENAME | this.SND_ASYNC);
		}

		public string SubString(string original, int start, int count)
		{
			if (start + count > original.Length)
			{
				string str = new string(' ', start + count - original.Length);
				original += str;
			}
			return original.Substring(start, count);
		}

		public string IsNumber(string s)
		{
			try
			{
				double.Parse(s, (IFormatProvider)b4p.cul);
				return "true";
			}
			catch
			{
				return "false";
			}
		}

		public Bitmap GetBitmapFromResource(string res)
		{
			string[] names = this.GetType().Assembly.GetManifestResourceNames();
			string name = "Dbasic." + res.ToLower(b4p.cul).Replace(" ", "~").Replace("\\", ".").Replace("..", ".");
			return new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream(name));
		}

		public Bitmap GetBitmapFromString(object o)
		{
			if (!(o is string))
				return (Bitmap)o;
			if ((string)o == "")
				return (Bitmap)null;
			string str = Path.Combine(this.b4p.b4pdir, (string)o);
			if (File.Exists(str))
				return new Bitmap(str);
			int num = (int)MessageBox.Show("Missing file: \n" + str);
			return (Bitmap)null;
		}

		public IComparer GetComparar(int t)
		{
			switch (t)
			{
				case 0:
					if (this.b4p.caseCompare == null)
						this.b4p.caseCompare = new Comparer(b4p.cul);
					return (IComparer)this.b4p.caseCompare;
				case 1:
					if (this.b4p.caseNotCompare == null)
						this.b4p.caseNotCompare = new CaseInsensitiveComparer(b4p.cul);
					return (IComparer)this.b4p.caseNotCompare;
				default:
					if (this.b4p.numbersCompare == null)
						this.b4p.numbersCompare = new CCompareNumbers();
					return (IComparer)this.b4p.numbersCompare;
			}
		}

		public double DateTimeParse(string time, string format)
		{
			try
			{
				return (double)DateTime.ParseExact(time, format, (IFormatProvider)b4p.cul).Ticks;
			}
			catch
			{
				return 0.0;
			}
		}

		public string[] GetControls(string module, string s)
		{
			string[] strArray = (string[])null;
			if (s == "")
			{
				strArray = new string[this.b4p.htControls.Count];
				int num = 0;
				foreach (DictionaryEntry htControl in this.b4p.htControls)
				{
					strArray[num++] = Other.ReturnFullName(htControl.Key.ToString().Remove(0, 1));
				}
			}
			else
			{
				s = Other.FixRuntimeControlName(s, module);
				object obj = this.b4p.htControls[(object)("_" + s.ToLower(b4p.cul))];
				if (obj is Control)
				{
					Control control1 = (Control)obj;
					strArray = new string[control1.Controls.Count];
					int num = 0;
					foreach (Control control2 in (ArrangedElementCollection)control1.Controls)
					{
						if (control2 is IEnhancedControl)
						{
							strArray[num++] = Other.ReturnFullName(((IEnhancedControl)control2).propName.Remove(0, 1));
						}
					}
				}
				else if (obj is Menu)
				{
					Menu menu = (Menu)obj;
					strArray = new string[menu.MenuItems.Count];
					int num = 0;
					foreach (object menuItem in menu.MenuItems)
					{
						if (menuItem is IEnhancedControl)
						{
							strArray[num++] = Other.ReturnFullName(((IEnhancedControl)menuItem).propName.Remove(0, 1));
						}
					}
				}
			}
			return strArray;
		}

		public string ControlType(string module, string c)
		{
			c = Other.FixRuntimeControlName(c, module);
			string str = this.b4p.htControls[(object)("_" + c.ToLower(b4p.cul))].GetType().ToString();
			int num = -1;

			if (str.Length > 9)
			{
				num = str.IndexOf("Enhanced", 10);
			}

			if (num > -1)
			{
				str = str.Substring(num + 8);
				if (str == "Combo")
				{
					str = "ComboBox";
				}
				else if (str == "DateTime")
				{
					str = "Calendar";
				}
				else if (str == "Menu")
				{
					str = "MenuItem";
				}
			}

			return str;
		}

		public double GetDouble(FileStream fs, long pos)
		{
			byte[] buffer = new byte[8];
			fs.Seek(pos, SeekOrigin.Begin);
			fs.Read(buffer, 0, 8);
			return BitConverter.ToDouble(buffer, 0);
		}

		public string GetString(FileStream fs, long pos, int length)
		{
			byte[] numArray = new byte[length];
			fs.Seek(pos, SeekOrigin.Begin);
			fs.Read(numArray, 0, numArray.Length);
			return this.b4p.ae.GetString(numArray, 0, numArray.Length);
		}

		public double GetByte(FileStream fs, long pos)
		{
			fs.Seek(pos, SeekOrigin.Begin);
			return (double)fs.ReadByte();
		}

		public void Put(FileStream fs, long pos, object o)
		{
			fs.Seek(pos, SeekOrigin.Begin);
			byte[] buffer = !(o is string) ? BitConverter.GetBytes((double)o) : this.b4p.ae.GetBytes((string)o);
			fs.Write(buffer, 0, buffer.Length);
		}

		public string[] GetRGB(Color c)
		{
			return new string[3] { c.R.ToString(), c.G.ToString(), c.B.ToString() };
		}

		public void Shell(string file, string args)
		{
			if (File.Exists(Path.Combine(this.b4p.b4pdir, file)))
			{
				file = Path.Combine(this.b4p.b4pdir, file);
			}
			else if (File.Exists(Path.Combine(this.b4p.b4pdir, file + ".exe")))
			{
				file = Path.Combine(this.b4p.b4pdir, file + ".exe");
			}

			Process.Start(file, args);
		}

		public double GetDoubleFromObject(object o)
		{
			if (o == null)
			{
				return 0.0;
			}

			return double.Parse((string)Convert.ChangeType(o, typeof(string), (IFormatProvider)b4p.cul), (IFormatProvider)b4p.cul);
		}

		public string GetStringFromObject(object o)
		{
			if (o == null)
			{
				return "";
			}

			return (string)Convert.ChangeType(o, typeof(string), (IFormatProvider)b4p.cul);
		}

		public static string FixRuntimeControlName(string controlName, string moduleName)
		{
			controlName = controlName.ToLower(b4p.cul);
			if (controlName.IndexOf(".") > -1)
			{
				return "_" + controlName.Replace(".", "_");
			}

			return "_" + moduleName + "_" + controlName;
		}

		public static string ReturnFullName(string subName)
		{
			int length = subName.IndexOf("_", 1) - 1;
			return subName.Substring(1, length) + "." + subName.Substring(length + 2);
		}

		public static string UnfixModuleName(string subName)
		{
			return subName.Substring(subName.IndexOf("_", 1) + 1);
		}
	}
}
