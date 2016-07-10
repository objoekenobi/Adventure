using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Dbasic.EnhancedControls
{
	public class CEnhancedForm : Form, IEnhancedControl, IImage, IEnabled, IText
	{
		public ImageAttributes imageAttr = new ImageAttributes();
		private SolidBrush brush = new SolidBrush(Color.Black);
		private Pen pen = new Pen(Color.Black);
		public Graphics graphics;
		public MainMenu mainMenu1;
		public string name;
		public Bitmap bitmap;
		public Rectangle destRect;
		public bool activeState;
		public bool cancelClose;
		public bool hideEventAdded;
		public Bitmap foreBitmap;
		public Graphics foreGraphics;
		public bool foreLayer;
		private b4p b4p;
		private b4p.del1 delKeyDown;
		private b4p.del2 delMouseDown;
		private b4p.del2 delMouseMove;
		private b4p.del2 delMouseUp;
		private b4p.del0 delClose;
		private b4p.del0 delShow;

		public string propName
		{
			get
			{
				return this.name;
			}
		}

		public Bitmap MyBitmap
		{
			get
			{
				return this.bitmap;
			}
			set
			{
				if (value == null)
				{
					this.graphics.FillRectangle((Brush)new SolidBrush(this.BackColor), 0, 0, this.Width, this.Height);
				}
				else
				{
					Rectangle srcRect = new Rectangle(0, 0, value.Width, value.Height);
					this.graphics.DrawImage((Image)value, this.destRect, srcRect, GraphicsUnit.Pixel);
				}
				this.Refresh();
			}
		}

		public override Color BackColor
		{
			get
			{
				return base.BackColor;
			}
			set
			{
				base.BackColor = value;
				this.graphics.FillRectangle((Brush)new SolidBrush(this.BackColor), 0, 0, this.Width, this.Height);
				this.Refresh();
			}
		}

		public bool ForeLayer
		{
			get
			{
				return this.foreLayer;
			}
			set
			{
				this.foreLayer = value;
				if (!this.foreLayer || this.foreBitmap != null)
					return;
				this.foreBitmap = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
				this.foreGraphics = Graphics.FromImage((Image)this.foreBitmap);
				this.foreGraphics.FillRectangle((Brush)this.b4p.foreBrush, this.destRect);
				this.imageAttr.SetColorKey(this.b4p.transColor, this.b4p.transColor);
			}
		}

		string IEnhancedControl.propName
		{
			get
			{
				return this.name;
			}
		}

		bool IEnabled.Enabled { get; set; }

		public CEnhancedForm(b4p b4p)
		{
			this.b4p = b4p;
			this.InitializeComponent();
			try
			{
				if (b4p.icon != "")
				{
					this.Icon = new Icon(Assembly.GetExecutingAssembly().GetManifestResourceStream(b4p.icon));
				}
			}
			catch
			{
			}
			this.ClientSize = new Size(b4p.screenX, b4p.screenY);
			this.MaximumSize = new Size(b4p.screenX + 7, b4p.screenY + 34);
			this.MinimumSize = this.MaximumSize;
			this.Name = "CEnhancedForm";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.destRect = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
			this.bitmap = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
			this.graphics = Graphics.FromImage((Image)this.bitmap);
		}

		public void show()
		{
			if (this.b4p.mainForm == null)
			{
				this.b4p.mainForm = this;
			}

			this.b4p.shownForm = this;
			this.MinimizeBox = false;
			if (!this.hideEventAdded)
			{
				this.Closing += new CancelEventHandler(this.HideForm);
				this.hideEventAdded = true;
			}

			if (this.b4p.htSubs.Contains((object)(this.name + "_show")))
			{
				this.ShowEvent();
			}

			if (this.b4p.alFormsDisplayOrder.Count > 0 && this.b4p.alFormsDisplayOrder[this.b4p.alFormsDisplayOrder.Count - 1] == this)
				return;
			this.Show();
			if (this.b4p.alFormsDisplayOrder.Count > 0)
				((Control)this.b4p.alFormsDisplayOrder[this.b4p.alFormsDisplayOrder.Count - 1]).Hide();
			if (this == this.b4p.mainForm)
				this.b4p.alFormsDisplayOrder.Clear();
			else
				this.b4p.alFormsDisplayOrder.Remove((object)this);
			this.b4p.alFormsDisplayOrder.Add((object)this);
			this.activeState = true;
		}

		public void AddMenu()
		{
			if (!(this.MaximumSize == new Size(this.b4p.screenX + 7, this.b4p.screenY + 34)))
			{
				return;
			}

			this.MaximumSize = new Size(0, 0);
			this.MinimumSize = new Size(0, 0);
			this.ClientSize = new Size(this.b4p.screenX, this.b4p.screenY + 20);
			this.MaximumSize = new Size(this.b4p.screenX + 7, this.b4p.screenY + 54);
			this.MinimumSize = new Size(this.b4p.screenX + 7, this.b4p.screenY + 54);
			this.destRect = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
			Bitmap bitmap = this.bitmap;
			this.bitmap = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
			this.graphics = Graphics.FromImage((Image)this.bitmap);
			this.graphics.DrawImage((Image)bitmap, this.destRect);
		}

		public void close()
		{
			if (this != this.b4p.mainForm && !this.b4p.alFormsDisplayOrder.Contains((object)this))
				return;
			this.Close();
		}

		private void HideForm(object sender, CancelEventArgs e)
		{
			if (this == this.b4p.mainForm)
			{
				if (!this.b4p.quitFlag)
				{
					if (this.b4p.htSubs.Contains((object)(this.b4p.mainForm.name + "_close")))
						this.CloseEvent();
					if (!this.b4p.quitFlag && this.b4p.mainForm.cancelClose)
					{
						e.Cancel = true;
						return;
					}
				}
				if (this.b4p.mainForm != null)
					this.b4p.CloseProgram();
			}
			if (this.b4p.quitFlag)
				return;
			if (this.b4p.htSubs.Contains((object)(this.name + "_close")))
				this.CloseEvent();
			if (this.cancelClose)
			{
				e.Cancel = true;
			}
			else
			{
				e.Cancel = true;
				this.Hide();
				this.b4p.alFormsDisplayOrder.Remove((object)this);
				((Control)this.b4p.alFormsDisplayOrder[this.b4p.alFormsDisplayOrder.Count - 1]).Show();
			}
		}

		private void InitializeComponent()
		{
			this.mainMenu1 = new MainMenu();
			this.SuspendLayout();
			this.AutoScaleMode = AutoScaleMode.Inherit;
			this.ClientSize = new Size(240, 266);
			this.Menu = this.mainMenu1;
			this.MinimizeBox = false;
			this.Name = "CEnhancedForm";
			this.ResumeLayout(false);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.DrawImage((Image)this.bitmap, 0, 0);
			if (!this.foreLayer)
				return;
			e.Graphics.DrawImage((Image)this.foreBitmap, this.destRect, 0, 0, this.bitmap.Width, this.bitmap.Height, GraphicsUnit.Pixel, this.imageAttr);
		}

		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
		}

		protected override void Dispose(bool disposing)
		{
			if (this.bitmap != null)
				this.bitmap.Dispose();
			if (this.foreBitmap != null)
				this.foreBitmap.Dispose();
			base.Dispose(disposing);
		}

		private void KeyDownEvent(object sender, KeyEventArgs e)
		{
			this.b4p.sender = this.name;
			string str = this.delKeyDown(((int)e.KeyCode).ToString((IFormatProvider)b4p.cul));
		}

		private void MouseDownEvent(object sender, MouseEventArgs e)
		{
			this.b4p.sender = this.name;
			string str = this.delMouseDown(e.X.ToString((IFormatProvider)b4p.cul), e.Y.ToString((IFormatProvider)b4p.cul));
		}

		private void MouseMoveEvent(object sender, MouseEventArgs e)
		{
			this.b4p.sender = this.name;
			string str = this.delMouseMove(e.X.ToString((IFormatProvider)b4p.cul), e.Y.ToString((IFormatProvider)b4p.cul));
		}

		private void MouseUpEvent(object sender, MouseEventArgs e)
		{
			this.b4p.sender = this.name;
			string str = this.delMouseUp(e.X.ToString((IFormatProvider)b4p.cul), e.Y.ToString((IFormatProvider)b4p.cul));
		}

		private void ShowEvent()
		{
			this.delShow = (b4p.del0)this.b4p.htSubs[(object)(this.name + "_show")];
			this.b4p.sender = this.name;
			string str = this.delShow();
		}

		private void CloseEvent()
		{
			this.cancelClose = false;
			this.delClose = (b4p.del0)this.b4p.htSubs[(object)(this.name + "_close")];
			this.b4p.sender = this.name;
			string str = this.delClose();
		}

		public void AddEvents()
		{
			try
			{
				if (this.b4p.htSubs.Contains((object)(this.name + "_mousedown")))
				{
					this.delMouseDown = (b4p.del2)this.b4p.htSubs[(object)(this.name + "_mousedown")];
					this.MouseDown += new MouseEventHandler(this.MouseDownEvent);
				}
				if (this.b4p.htSubs.Contains((object)(this.name + "_mousemove")))
				{
					this.delMouseMove = (b4p.del2)this.b4p.htSubs[(object)(this.name + "_mousemove")];
					this.MouseMove += new MouseEventHandler(this.MouseMoveEvent);
				}
				if (this.b4p.htSubs.Contains((object)(this.name + "_mouseup")))
				{
					this.delMouseUp = (b4p.del2)this.b4p.htSubs[(object)(this.name + "_mouseup")];
					this.MouseUp += new MouseEventHandler(this.MouseUpEvent);
				}
				if (!this.b4p.htSubs.Contains((object)(this.name + "_keypress")))
					return;
				this.delKeyDown = (b4p.del1)this.b4p.htSubs[(object)(this.name + "_keypress")];
				this.KeyDown += new KeyEventHandler(this.KeyDownEvent);
			}
			catch
			{
				throw new Exception("Error assigning event to " + this.name.Remove(0, 1) + ".\nCheck the number of arguments of each event sub.");
			}
		}

		public void AddRunTimeEvent(string eventName, string subName)
		{
			try
			{
				switch (eventName)
				{
					case "mousedown":
						this.delMouseDown = (b4p.del2)this.b4p.htSubs[(object)subName];
						this.MouseDown += new MouseEventHandler(this.MouseDownEvent);
						break;
					case "mousemove":
						this.delMouseMove = (b4p.del2)this.b4p.htSubs[(object)subName];
						this.MouseMove += new MouseEventHandler(this.MouseMoveEvent);
						break;
					case "mouseup":
						this.delMouseUp = (b4p.del2)this.b4p.htSubs[(object)subName];
						this.MouseUp += new MouseEventHandler(this.MouseUpEvent);
						break;
					case "keypress":
						this.delKeyDown = (b4p.del1)this.b4p.htSubs[(object)subName];
						this.KeyDown += new KeyEventHandler(this.KeyDownEvent);
						break;
				}
			}
			catch
			{
				throw new Exception("Error assigning event to " + this.name.Remove(0, 1) + ".\nCheck the number of arguments of each event sub.");
			}
		}

		public void circle(Graphics g, int x1, int y1, int r, Color color, bool fill)
		{
			Rectangle rc = new Rectangle(x1 - r, y1 - r, 2 * r + 1, 2 * r + 1);
			if (fill)
			{
				this.brush.Color = color;
				g.FillEllipse((Brush)this.brush, x1 - r, y1 - r, 2 * r, 2 * r);
			}
			else
			{
				this.pen.Color = color;
				g.DrawEllipse(this.pen, x1 - r, y1 - r, 2 * r, 2 * r);
			}
			++rc.Height;
			++rc.Width;
			this.Invalidate(rc);
		}

		public void line(Graphics g, int x1, int y1, int x2, int y2, Color color, bool box, bool fill)
		{
			Rectangle rectangle = new Rectangle(Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x2 - x1), Math.Abs(y2 - y1));
			if (box)
			{
				if (!fill)
				{
					this.pen.Color = color;
					g.DrawRectangle(this.pen, rectangle);
				}
				else
				{
					this.brush.Color = color;
					g.FillRectangle((Brush)this.brush, rectangle);
				}
			}
			else
			{
				this.pen.Color = color;
				g.DrawLine(this.pen, x1, y1, x2, y2);
			}
			++rectangle.Height;
			++rectangle.Width;
			this.Invalidate(rectangle);
		}

		public void drawString(Graphics g, string s, double fontSize, int x1, int y1, int x2, int y2, Color col)
		{
			Rectangle rc = new Rectangle(Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x2 - x1), Math.Abs(y2 - y1));
			this.brush.Color = col;
			g.DrawString(s, new Font(this.Font.Name, (float)fontSize, this.Font.Style), (Brush)this.brush, (RectangleF)rc);
			++rc.Height;
			++rc.Width;
			this.Invalidate(rc);
		}

		public void drawImage(Graphics g, Bitmap bitmap, int x1, int y1)
		{
			Rectangle rc = new Rectangle(x1, y1, bitmap.Width, bitmap.Height);
			g.DrawImage((Image)bitmap, x1, y1, new Rectangle(0, 0, bitmap.Width, bitmap.Height), GraphicsUnit.Pixel);
			++rc.Height;
			++rc.Width;
			this.Invalidate(rc);
		}

		public void drawImage(Graphics g, Bitmap bitmap, int x1, int y1, int x2, int y2)
		{
			Rectangle rectangle = new Rectangle(Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x2 - x1), Math.Abs(y2 - y1));
			g.DrawImage((Image)bitmap, rectangle, new Rectangle(0, 0, bitmap.Width, bitmap.Height), GraphicsUnit.Pixel);
			++rectangle.Height;
			++rectangle.Width;
			this.Invalidate(rectangle);
		}

		public void polygon(Graphics g, string[,] xy, int start, int count, Color col, bool fill)
		{
			Point[] points = new Point[count];
			int val1_1;
			int num1 = val1_1 = points[0].X = (int)double.Parse(xy[start, 0], (IFormatProvider)b4p.cul);
			int val1_2;
			int num2 = val1_2 = points[0].Y = (int)double.Parse(xy[start, 1], (IFormatProvider)b4p.cul);
			for (int index = 1; index < count; ++index)
			{
				num1 = Math.Min(num1, points[index].X = (int)double.Parse(xy[start + index, 0], (IFormatProvider)b4p.cul));
				val1_1 = Math.Max(val1_1, points[index].X);
				num2 = Math.Min(num2, points[index].Y = (int)double.Parse(xy[start + index, 1], (IFormatProvider)b4p.cul));
				val1_2 = Math.Max(val1_2, points[index].Y);
			}
			Rectangle rc = new Rectangle(num1, num2, val1_1 - num1 + 1, val1_2 - num2 + 1);
			if (fill)
			{
				this.brush.Color = col;
				g.FillPolygon((Brush)this.brush, points);
			}
			else
			{
				this.pen.Color = col;
				g.DrawPolygon(this.pen, points);
			}
			this.Invalidate(rc);
		}

		public void polygon(Graphics g, string[] x, int startX, string[] y, int startY, int count, Color col, bool fill)
		{
			Point[] points = new Point[count];
			int val1_1;
			int num1 = val1_1 = points[0].X = (int)double.Parse(x[startX], (IFormatProvider)b4p.cul);
			int val1_2;
			int num2 = val1_2 = points[0].Y = (int)double.Parse(y[startY], (IFormatProvider)b4p.cul);
			for (int index = 1; index < count; ++index)
			{
				num1 = Math.Min(num1, points[index].X = (int)double.Parse(x[startX + index], (IFormatProvider)b4p.cul));
				val1_1 = Math.Max(val1_1, points[index].X);
				num2 = Math.Min(num2, points[index].Y = (int)double.Parse(y[startY + index], (IFormatProvider)b4p.cul));
				val1_2 = Math.Max(val1_2, points[index].Y);
			}
			Rectangle rc = new Rectangle(num1, num2, val1_1 - num1 + 1, val1_2 - num2 + 1);
			if (fill)
			{
				this.brush.Color = col;
				g.FillPolygon((Brush)this.brush, points);
			}
			else
			{
				this.pen.Color = col;
				g.DrawPolygon(this.pen, points);
			}
			this.Invalidate(rc);
		}
	}
}
