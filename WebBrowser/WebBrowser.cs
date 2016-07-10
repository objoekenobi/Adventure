// Decompiled with JetBrains decompiler
// Type: WebBrowser.WebBrowser
// Assembly: 1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A8A5940D-AE1C-4046-96E6-69660C4C2B62
// Assembly location: C:\Users\jobrien\Downloads\advpda\advpc.exe

using System;
using System.Windows.Forms;

namespace WebBrowser
{
  public class WebBrowser : IDisposable
  {
    private string NavURL = "";
    private System.Windows.Forms.WebBrowser wb;
    private object[] eventObject;
    private bool CancelNav;

    public double DLLVersion
    {
      get
      {
        return 1.1;
      }
    }

    public bool CancelNavigate
    {
      set
      {
        this.CancelNav = value;
      }
    }

    public Control ControlRef
    {
      get
      {
        return (Control) this.wb;
      }
    }

    public string DocumentText
    {
      set
      {
        this.wb.DocumentText = value;
      }
    }

    public int Height
    {
      get
      {
        return this.wb.Height;
      }
      set
      {
        this.wb.Height = value;
      }
    }

    public bool IsBusy
    {
      get
      {
        return this.wb.IsBusy;
      }
    }

    public bool IsOffline
    {
      get
      {
        return this.wb.IsOffline;
      }
    }

    public string NavigatingURL
    {
      get
      {
        return this.NavURL;
      }
    }

    public string URL
    {
      get
      {
        return this.wb.Url.ToString();
      }
      set
      {
        this.wb.Url = new Uri(value);
      }
    }

    public int Width
    {
      get
      {
        return this.wb.Width;
      }
      set
      {
        this.wb.Width = value;
      }
    }

    public int Left
    {
      get
      {
        return this.wb.Left;
      }
      set
      {
        this.wb.Left = value;
      }
    }

    public int Top
    {
      get
      {
        return this.wb.Top;
      }
      set
      {
        this.wb.Top = value;
      }
    }

    public bool Visible
    {
      get
      {
        return this.wb.Visible;
      }
      set
      {
        this.wb.Visible = value;
      }
    }

    public event EventHandler DocumentCompleted;

    public event EventHandler GotFocus;

    public event EventHandler LostFocus;

    public event EventHandler Navigated;

    public event EventHandler Navigating;

    public WebBrowser(Control FormName, int Left, int Top, int Width, int Height)
    {
      this.wb = new System.Windows.Forms.WebBrowser();
      this.wb.Left = Left;
      this.wb.Top = Top;
      this.wb.Width = Width;
      this.wb.Height = Height;
      FormName.Controls.Add((Control) this.wb);
      this.eventObject = new object[2]
      {
        (object) this,
        (object) " "
      };
      this.wb.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.DocumentCompletedEvent);
      this.wb.GotFocus += new EventHandler(this.GotFocusEvent);
      this.wb.LostFocus += new EventHandler(this.LostFocusEvent);
      this.wb.Navigated += new WebBrowserNavigatedEventHandler(this.NavigatedEvent);
      this.wb.Navigating += new WebBrowserNavigatingEventHandler(this.NavigatingEvent);
    }

    public void Navigate(string UrlStr)
    {
      this.wb.Navigate(new Uri(UrlStr));
    }

    public void GoBack()
    {
      this.wb.GoBack();
    }

    public void GoForward()
    {
      this.wb.GoForward();
    }

    public void Stop()
    {
      this.wb.Stop();
    }

    private void DocumentCompletedEvent(object sender, EventArgs e)
    {
      if (this.DocumentCompleted == null)
        return;
      this.eventObject[1] = (object) "DocumentCompleted";
      this.DocumentCompleted((object) this.eventObject, (EventArgs) null);
    }

    private void GotFocusEvent(object sender, EventArgs e)
    {
      if (this.GotFocus == null)
        return;
      this.eventObject[1] = (object) "GotFocus";
      this.GotFocus((object) this.eventObject, (EventArgs) null);
    }

    private void LostFocusEvent(object sender, EventArgs e)
    {
      if (this.LostFocus == null)
        return;
      this.eventObject[1] = (object) "LostFocus";
      this.LostFocus((object) this.eventObject, (EventArgs) null);
    }

    private void NavigatedEvent(object sender, EventArgs e)
    {
      if (this.Navigated == null)
        return;
      this.eventObject[1] = (object) "Navigated";
      this.Navigated((object) this.eventObject, (EventArgs) null);
    }

    private void NavigatingEvent(object sender, WebBrowserNavigatingEventArgs e)
    {
      this.CancelNav = false;
      this.NavURL = !(e.Url == (Uri) null) ? e.Url.ToString() : "Unavailable on WM2003";
      if (this.Navigating != null)
      {
        this.eventObject[1] = (object) "Navigating";
        this.Navigating((object) this.eventObject, (EventArgs) null);
      }
      if (!this.CancelNav)
        return;
      e.Cancel = true;
    }

    public void Dispose()
    {
      this.DocumentCompleted = (EventHandler) null;
      this.GotFocus = (EventHandler) null;
      this.LostFocus = (EventHandler) null;
      this.Navigated = (EventHandler) null;
      this.Navigating = (EventHandler) null;
      this.wb.DocumentCompleted -= new WebBrowserDocumentCompletedEventHandler(this.DocumentCompletedEvent);
      this.wb.GotFocus -= new EventHandler(this.GotFocusEvent);
      this.wb.LostFocus -= new EventHandler(this.LostFocusEvent);
      this.wb.Navigated -= new WebBrowserNavigatedEventHandler(this.NavigatedEvent);
      this.wb.Navigating -= new WebBrowserNavigatingEventHandler(this.NavigatingEvent);
      this.wb.Dispose();
    }
  }
}
