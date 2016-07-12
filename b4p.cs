using bDeviceInfo;
using Dbasic.EnhancedControls;
using System;
using System.Collections;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Dbasic
{
	public class b4p
	{
		public static CultureInfo cul = new CultureInfo("en-US", false);
		public Color transColor = Color.Violet;
		public SolidBrush foreBrush = new SolidBrush(Color.Violet);
		public Hashtable htSubs = new Hashtable();
		public Hashtable htControls = new Hashtable();
		public ASCIIEncoding ae = new ASCIIEncoding();
		public string sender = "";
		public Hashtable htStreams = new Hashtable();
		private Random rnd = new Random();
		public int screenY = 268;
		public int screenX = 238;
		public string icon = "";
		private string var__main_l = "";
		private string var__main_x = "";
		private string var__main_imcarrying = "";
		private string var__main_html_look_prompt = "";
		private string var__main_html_lk_prompt_start = "";
		private string var__main_myadventure = "";
		private string var__main_althyper = "";
		private string var__main_txtexits = "";
		private string var__main_done_intro_look = "";
		private string var__main_html_look_text = "";
		private string var__main_html_prompt_end = "";
		private string var__main_computerexit = "";
		private string var__main_html_end = "";
		private string var__main_lighttime = "";
		private string var__main_loadedfile = "";
		private string var__main_seelmagain = "";
		private string var__main_html_exit_text = "";
		private string var__main_founditem = "";
		private string var__main_html_line = "";
		private string var__main_word2 = "";
		private string var__main_numitems = "";
		private string var__main_optionsfontsize = "";
		private string var__main_carryingtoomuch = "";
		private string var__main_html_mesg_background = "";
		private string var__main_carried = "";
		private string var__main_othernegget = "";
		private string var__main_nummessages = "";
		private string var__main_linkdrop = "";
		private string var__main_optionsrvsinfo = "";
		private string var__main_hyper = "";
		private string var__main_keyboardisoff = "";
		private string var__main_optionswarning = "";
		private string var__main_html_mesg_prompt = "";
		private string var__main_drop_verb = "";
		private string var__main_treasures = "";
		private string var__main_lastrefresh = "";
		private string var__main_carryingcanbe255 = "";
		private string var__main_html_look_start = "";
		private string var__main_optionslinkson = "";
		private string var__main_html_room_text = "";
		private string var__main_dropping = "";
		private string var__main_magicheader = "";
		private string var__main_getting = "";
		private string var__main_lookcleared = "";
		private string var__main_html_start = "";
		private string var__main_advversion = "";
		private string var__main_optionsfontbold = "";
		private string var__main_nountext = "";
		private string var__main_abcison = "";
		private string var__main_html_look_background = "";
		private string var__main_themecustom = "";
		private string var__main_optionstheme = "";
		private string var__main_llclear = "";
		private string var__main_currentsavedroom = "";
		private string var__main_checksum = "";
		private string var__main_nnum = "";
		private string var__main_html_look_hyperlink = "";
		private string var__main_currentcounter = "";
		private string var__main_openingother = "";
		private string var__main_myfiledata = "";
		private string var__main_optionslinks = "";
		private string var__main_sleeping = "";
		private string var__main_treasureroom = "";
		private string var__main_myroomtext = "";
		private string var__main_numrooms = "";
		private string var__main_magicfooter = "";
		private string var__main_html_exit_hyperlink = "";
		private string var__main_advno = "";
		private string var__main_html_look_end = "";
		private string var__main_lastmsghlcolor = "";
		private string var__main_linkget = "";
		private string var__main_myroomexits = "";
		private string var__main_html_exit_prompt = "";
		private string var__main_txtmsg = "";
		private string var__main_mymag = "";
		private string var__main_go_verb = "";
		private string var__main_html_mesg_start = "";
		private string var__main_cancel = "";
		private string var__main_myel = "";
		private string var__main_html_hyperlink = "";
		private string var__main_html_ex_prompt_start = "";
		private string var__main_html_exit_start = "";
		private string var__main_quickdropchk = "";
		private string var__main_lightoutbit = "";
		private string var__main_darkbit = "";
		private string var__main_llplayerroom = "";
		private string var__main_light_source = "";
		private string var__main_html_line_break = "";
		private string var__main_word1 = "";
		private string var__main_gamehastorch = "";
		private string var__main_html_exit_end = "";
		private string var__main_mylastword2 = "";
		private string var__main_getnoun = "";
		private string var__main_fontsize = "";
		private string var__main_wordlength = "";
		private string var__main_txtlook = "";
		private string var__main_get_verb = "";
		private string var__main_lldark = "";
		private string var__main_fontface = "";
		private string var__main_numactions = "";
		private string var__main_screentype = "";
		private string var__main_numwords = "";
		private string var__main_html_body_background = "";
		private string var__main_y = "";
		private string var__main_myfiledatapos = "";
		private string var__main_html_mesg_text = "";
		private string var__main_noun = "";
		private string var__main_lightrefill = "";
		private string var__main_vnum = "";
		private string var__main_optionsalthyperon = "";
		private string var__main_mykbdonoff = "";
		private string var__main_disablelinks = "";
		private string var__main_mylastword1 = "";
		private string var__main_initial_load = "";
		private string var__main_playerroom = "";
		private string var__main_html_mesg_hyperlink = "";
		private string var__main_destroyed = "";
		private string var__main_continuation = "";
		private string var__main_mygetdrop = "";
		private string var__main_secondcode = "";
		private string var__main_aname = "";
		private string var__main_optionsmyadv = "";
		private string var__main_html_exit_background = "";
		private string var__main_verb = "";
		private string var__main_html_mesg_end = "";
		private string var__main_maxcarry = "";
		public CEnhancedForm mainForm;
		public CEnhancedForm shownForm;
		public CEnhancedObject CEnhancedObject;
		public CaseInsensitiveComparer caseNotCompare;
		public Comparer caseCompare;
		public CCompareNumbers numbersCompare;
		public bool quitFlag;
		private Other Other;
		private string[] localVars;
		public string dateFormat;
		public string timeFormat;
		public string b4pdir;
		private string cPPC;
		public Thread tdRunning;
		public Exception lastError;
		public ArrayList alFormsDisplayOrder;
		private string[] var__main_args;
		private CEnhancedForm __main_fadventure;
		private CEnhancedImageButton __main_butabc123;
		private CEnhancedImageButton __main_butgo;
		private CEnhancedTimer __main_timer1;
		private OpenFileDialog __main_loaddialog1;
		private SaveFileDialog __main_savedialog1;
		private CEnhancedImageButton __main_buthelp;
		private CEnhancedImageButton __main_butinv;
		private CEnhancedImageButton __main_butelc;
		private CEnhancedImageButton __main_butmag;
		private CEnhancedImageButton __main_butgetdrop;
		private CEnhancedImageButton __main_butdel;
		private CEnhancedImageButton __main_butenter;
		private CEnhancedButton __main_butspace;
		private CEnhancedButton __main_butb;
		private CEnhancedButton __main_butm;
		private CEnhancedButton __main_butn;
		private CEnhancedButton __main_butx;
		private CEnhancedButton __main_butc;
		private CEnhancedButton __main_butv;
		private CEnhancedButton __main_butz;
		private CEnhancedButton __main_buta;
		private CEnhancedButton __main_buts;
		private CEnhancedButton __main_butd;
		private CEnhancedButton __main_buth;
		private CEnhancedButton __main_butg;
		private CEnhancedButton __main_butf;
		private CEnhancedButton __main_butk;
		private CEnhancedButton __main_butl;
		private CEnhancedButton __main_butj;
		private CEnhancedButton __main_butu;
		private CEnhancedButton __main_butp;
		private CEnhancedButton __main_buto;
		private CEnhancedButton __main_buti;
		private CEnhancedButton __main_butr;
		private CEnhancedButton __main_butt;
		private CEnhancedButton __main_buty;
		private CEnhancedButton __main_bute;
		private CEnhancedButton __main_butw;
		private CEnhancedButton __main_butq;
		private OpenFileDialog __main_opendialog1;
		private CEnhancedTextBox __main_mycmd;
		private CEnhancedMenu __main_menugame;
		private CEnhancedMenu __main_menunew;
		private CEnhancedMenu __main_menuload;
		private CEnhancedMenu __main_menusave;
		private CEnhancedMenu __main_menuoptions;
		private CEnhancedMenu __main_fabout;
		private CEnhancedMenu __main_faboutscott;
		private CEnhancedMenu __main_fengine;
		private CEnhancedForm __main_fselect;
		private CEnhancedLabel __main_advdesc;
		private CEnhancedImage __main_logo;
		private CEnhancedImage __main_imgpic;
		private CEnhancedButton __main_butother;
		private CEnhancedButton __main_butplay;
		private CEnhancedCombo __main_pdselect;
		private CEnhancedImage __main_backgnd;
		private CEnhancedForm __main_aboutengine;
		private CEnhancedTextBox __main_txtaboutengine;
		private CEnhancedForm __main_aboutsa;
		private CEnhancedTextBox __main_txtscott;
		private CEnhancedForm __main_foptions;
		private CEnhancedButton __main_kbdonoff;
		private CEnhancedCombo __main_fontbold;
		private CEnhancedLabel __main_labfontbold;
		private CEnhancedCombo __main_linkfix;
		private CEnhancedLabel __main_lablinkfix;
		private CEnhancedCombo __main_pdoptrvs;
		private CEnhancedLabel __main_laboptmsgs;
		private CEnhancedLabel __main_laboptlink;
		private CEnhancedCombo __main_pdlinks;
		private CEnhancedButton __main_butapply;
		private CEnhancedCombo __main_pdfontsize;
		private CEnhancedLabel __main_laboptfontsize;
		private CEnhancedLabel __main_labopttheme;
		private CEnhancedCombo __main_pdtheme;
		private ArrayList __main_arraylist1;
		private WebBrowser.WebBrowser __main_webby;
		private Class_bDeviceInfo __main_bdi;
		private object var__main_xroomtext;
		private object var__main_xroomexit;
		private object var__main_xitemtext;
		private object var__main_xitemloc;
		private object var__main_xiteminitloc;
		private object var__main_xitemautoget;
		private object var__main_xactionvocab;
		private object var__main_xactionverb;
		private object var__main_xactionnoun;
		private object var__main_xactioncondition;
		private object var__main_xactionaction;
		private object var__main_xnouns;
		private object var__main_xverbs;
		private object var__main_xmessages;
		private object var__main_xbitflags;
		private object var__main_llitemloc;
		private object var__main_param;
		private object var__main_act;
		private object var__main_exitnames;
		private object var__main_roomsaved;
		private object var__main_counters;
		private object var__main_starthere;
		private object var__main_startcarried;
		private int err__main_readmytheme;
		private int err__main_readoptionsfromfile;
		private int err__main_pdselect_selectionchanged;
		private int err__main_savemygame;
		private int err__main_loadfile;
		private int err__main_loadmygame;

		public b4p(string[] args)
		{
			try
			{
				this.CEnhancedObject = new CEnhancedObject(this);
				this.Other = new Other(this);
				this.dateFormat = "MM/dd/yyyy";
				this.timeFormat = "HH:mm";
				this.tdRunning = Thread.CurrentThread;
				this.b4pdir = Application.StartupPath;
				this.cPPC = "false";
				this.alFormsDisplayOrder = new ArrayList();
				this.var__main_args = args;
				this.initialize();
				this._globals();
				this.__main_app_start();
				if (this.shownForm == null)
					return;
				Application.Run((Form)this.shownForm);
			}
			catch (Exception ex)
			{
				int num = (int)MessageBox.Show("Error loading program.\n" + ex.Message, "Basic4ppc", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
			}
		}

		[STAThread]
		private static void Main(string[] args)
		{
			b4p b4p = new b4p(args);
		}

		private void AddRuntimeEvent(string name, string eventName, string subName)
		{
			if (this.htControls[(object)name] is IEnhancedControl)
				((IEnhancedControl)this.htControls[(object)name]).AddRunTimeEvent(eventName, subName);
			else
				this.CEnhancedObject.AddRunTimeEvent(this.htControls[(object)name], name, eventName, subName);
		}

		public bool CompareEqual(string lSide, string rSide)
		{
			if (lSide == "" && rSide == "0" || lSide == "0" && rSide == "")
				return true;
			return lSide == rSide;
		}

		public bool LCompareEqual(string lSide, string rSide)
		{
			if (lSide == "" && rSide == "0")
				return true;
			return lSide == rSide;
		}

		public bool RCompareEqual(string lSide, string rSide)
		{
			if (lSide == "0" && rSide == "")
				return true;
			return lSide == rSide;
		}

		public bool ShowError(Exception ex, string subName)
		{
			Cursor.Current = Cursors.Default;
			if (this.quitFlag)
				return true;
			ArrayList arrayList = new ArrayList();
			foreach (DictionaryEntry htControl in this.htControls)
			{
				object obj = htControl.Value;
				if (obj is System.Windows.Forms.Timer && ((System.Windows.Forms.Timer)obj).Enabled)
				{
					((System.Windows.Forms.Timer)obj).Enabled = false;
					arrayList.Add(obj);
				}
			}
			if (MessageBox.Show("An error occurred on sub " + subName + ".\r\n\r\n" + ex.Message + "\r\nContinue?", "Basic4ppc", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1) == DialogResult.No)
			{
				this.quitFlag = true;
				if (this.mainForm != null)
					this.mainForm.Close();
				return true;
			}
			foreach (System.Windows.Forms.Timer timer in arrayList)
				timer.Enabled = true;
			return false;
		}

		public void CloseProgram()
		{
			this.quitFlag = true;
			this.shownForm = (CEnhancedForm)null;
			if (this.CEnhancedObject.htShemotAzamim != null)
				this.CEnhancedObject.htShemotAzamim.Clear();
			foreach (DictionaryEntry htStream in this.htStreams)
				((IStream)htStream.Value).Close();
			this.htStreams.Clear();
			foreach (DictionaryEntry htControl in this.htControls)
			{
				object obj = htControl.Value;
				if (obj is CEnhancedForm && obj != this.mainForm)
					((Form)obj).Close();
				else if (obj is System.Windows.Forms.Timer)
					((System.Windows.Forms.Timer)obj).Enabled = false;
				try
				{
					if (obj != null)
					{
						if (obj is IDisposable)
						{
							((IDisposable)obj).Dispose();
						}
					}
				}
				catch
				{
				}
			}
			this.htControls.Clear();
			GC.Collect();
			Application.ExitThread();
			Cursor.Current = Cursors.Default;
		}

		private string _globals()
		{
			this.var__main_mykbdonoff = "Y";
			this.var__main_keyboardisoff = "N";
			this.var__main_secondcode = "0";
			this.var__main_hyper = "about:";
			this.var__main_althyper = "0";
			this.var__main_optionsalthyperon = "N";
			this.var__main_aname = "href";
			this.var__main_sleeping = "N";
			this.var__main_lastrefresh = "";
			this.var__main_openingother = "N";
			this.var__main_html_body_background = "#ffffa0";
			this.var__main_html_look_background = "#ffa0ff";
			this.var__main_html_exit_background = "#ffbf60";
			this.var__main_html_mesg_background = "#ffffa0";
			this.var__main_html_room_text = "#000000";
			this.var__main_html_look_text = "#000000";
			this.var__main_html_exit_text = "#000000";
			this.var__main_html_mesg_text = "#000000";
			this.var__main_html_exit_prompt = "#800000";
			this.var__main_html_mesg_prompt = "#800000";
			this.var__main_html_hyperlink = "#0000ff";
			this.var__main_html_hyperlink = "#0000ff";
			this.var__main_html_hyperlink = "#0000ff";
			this.var__main_html_line_break = "#808080";
			this.var__main_fontface = "MS Sans Serif";
			this.var__main_fontsize = "1";
			this.var__main_html_start = "<html><body bgcolor='" + this.var__main_html_body_background + "' topmargin='0' leftmargin='0' link='#0000ff' vlink='#0000ff' alink='#0000ff'>";
			this.var__main_html_look_start = "<table width='100%' cellspacing='0' cellpadding='2'><tr><td bgcolor='" + this.var__main_html_look_background + "'><font face='" + this.var__main_fontface + "' size='" + this.var__main_fontsize + "' color='" + this.var__main_html_look_text + "'>";
			this.var__main_html_look_end = "</td></tr></table>";
			this.var__main_html_exit_start = "<table width='100%' cellspacing='0' cellpadding='2'><tr><td bgcolor='" + this.var__main_html_exit_background + "'><font face='" + this.var__main_fontface + "' size='" + this.var__main_fontsize + "' color='" + this.var__main_html_exit_text + "'>";
			this.var__main_html_exit_end = "</td></tr></table>";
			this.var__main_html_mesg_start = "<table width='100%' cellspacing='0' cellpadding='2'><tr><td bgcolor='" + this.var__main_html_mesg_background + "'><font face='" + this.var__main_fontface + "' size='" + this.var__main_fontsize + "' color='" + this.var__main_html_mesg_text + "'>";
			this.var__main_html_mesg_end = "</font></td></tr></table>";
			this.var__main_html_lk_prompt_start = "<font color='" + this.var__main_html_look_prompt + "' face='" + this.var__main_fontface + "' size='" + this.var__main_fontsize + "'>";
			this.var__main_html_prompt_end = "</font>";
			this.var__main_html_line = "<table cellspacing='0' cellpadding='0' width='100%'><tr><td bgcolor='" + this.var__main_html_line_break + "' height='1'></td></tr></table>";
			this.var__main_html_end = "</body></html>";
			this.var__main_getting = "N";
			this.var__main_dropping = "N";
			this.var__main_disablelinks = "N";
			this.var__main_go_verb = "1";
			this.var__main_light_source = "9";
			this.var__main_get_verb = "10";
			this.var__main_drop_verb = "18";
			this.var__main_carried = "-1.0"; // .ToString((IFormatProvider) b4p.cul);
			this.var__main_destroyed = "0";
			this.var__main_darkbit = "15";
			this.var__main_lightoutbit = "16";
			this.var__main_carryingcanbe255 = "Y";
			this.var__main_xroomtext = (object)new string[0];
			this.var__main_xroomexit = (object)new string[0, 0];
			this.var__main_xitemtext = (object)new string[0];
			this.var__main_xitemloc = (object)new string[0];
			this.var__main_xiteminitloc = (object)new string[0];
			this.var__main_xitemautoget = (object)new string[0];
			this.var__main_xactionvocab = (object)new string[0];
			this.var__main_xactionverb = (object)new string[0];
			this.var__main_xactionnoun = (object)new string[0];
			this.var__main_xactioncondition = (object)new string[0];
			this.var__main_xactionaction = (object)new string[0];
			this.var__main_xnouns = (object)new string[0];
			this.var__main_xverbs = (object)new string[0];
			this.var__main_xmessages = (object)new string[0];
			this.var__main_xbitflags = (object)new string[256];
			this.var__main_llitemloc = (object)new string[0];
			this.var__main_param = (object)new string[32];
			this.var__main_act = (object)new string[4];
			this.var__main_exitnames = (object)new string[6];
			this.var__main_roomsaved = (object)new string[256];
			this.var__main_counters = (object)new string[256];
			this.var__main_screentype = "240x240";
			this.var__main_loadedfile = "false";
			this.var__main_abcison = "Y";
			this.var__main_quickdropchk = "N";
			this.var__main_optionsfontbold = "0";
			this.var__main_linkget = "0";
			this.var__main_linkdrop = "0";
			this.var__main_imcarrying = "0";
			this.var__main_themecustom = "4";
			this.var__main_starthere = (object)new string[0];
			this.var__main_startcarried = (object)new string[0];
			return "";
		}

		private string __main_buta_click()
		{
			try
			{
				this.__main_insertchar("A");
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_buta_click");
				return "";
			}
		}

		private string __main_saveoptionstofile()
		{
			try
			{
				this.htStreams.Add((object)"_main_inis", (object)new CStreamWriter(Path.Combine(this.b4pdir, this.b4pdir + "\\advpda.ini"), false, Encoding.ASCII));
				((TextWriter)this.htStreams[(object)"_main_inis"]).WriteLine(this.var__main_optionswarning);
				((TextWriter)this.htStreams[(object)"_main_inis"]).WriteLine(this.var__main_optionsmyadv);
				((TextWriter)this.htStreams[(object)"_main_inis"]).WriteLine(this.var__main_optionstheme);
				((TextWriter)this.htStreams[(object)"_main_inis"]).WriteLine(this.var__main_optionsfontsize);
				((TextWriter)this.htStreams[(object)"_main_inis"]).WriteLine(this.var__main_optionslinks);
				((TextWriter)this.htStreams[(object)"_main_inis"]).WriteLine(this.var__main_seelmagain);
				((TextWriter)this.htStreams[(object)"_main_inis"]).WriteLine(this.var__main_optionsrvsinfo);
				((TextWriter)this.htStreams[(object)"_main_inis"]).WriteLine(this.var__main_althyper);
				((TextWriter)this.htStreams[(object)"_main_inis"]).WriteLine(this.var__main_optionsfontbold);
				((TextWriter)this.htStreams[(object)"_main_inis"]).WriteLine(this.var__main_mykbdonoff);
				if (this.htStreams.Contains((object)"_main_inis"))
				{
					((IStream)this.htStreams[(object)"_main_inis"]).Close();
					this.htStreams.Remove((object)"_main_inis");
					GC.Collect();
				}
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_saveoptionstofile");
				return "";
			}
		}

		private string __main_right(string var__main_right_mystr, string var__main_right_length)
		{
			try
			{
				if (this.LCompareEqual(var__main_right_mystr, ""))
					return "";
				if ((var__main_right_length == "" ? 0.0 : double.Parse(var__main_right_length, (IFormatProvider)b4p.cul)) > (double)var__main_right_mystr.Length)
					var__main_right_length = var__main_right_mystr.Length.ToString((IFormatProvider)b4p.cul);
				return this.Other.SubString(var__main_right_mystr, (int)((double)var__main_right_mystr.Length - (var__main_right_length == "" ? 0.0 : double.Parse(var__main_right_length, (IFormatProvider)b4p.cul))), var__main_right_length == "" ? 0 : (int)double.Parse(var__main_right_length, (IFormatProvider)b4p.cul));
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_right");
				return "";
			}
		}

		private string __main_whichword(string var__main_myword, string var__main_mynorv)
		{
			string str1 = "";
			string str2 = "";
			string str3 = "";
			try
			{
				string str4 = "1";
				str3 = "1";
				str2 = "";
				str1 = "";
				string s = "1";
				double num1 = this.var__main_numwords == "" ? 0.0 : double.Parse(this.var__main_numwords, (IFormatProvider)b4p.cul);
				for (double num2 = double.Parse(s, (IFormatProvider)b4p.cul); num2 <= num1; s = (++num2).ToString((IFormatProvider)b4p.cul))
				{
					string str5 = "";
					if (string.Compare(var__main_mynorv, "Verbs", true, b4p.cul).ToString((IFormatProvider)b4p.cul) == "0")
					{
						string[] strArray = (string[])this.var__main_xverbs;
						int index = s == "" ? 0 : (int)double.Parse(s, (IFormatProvider)b4p.cul);
						string str6;
						str5 = (str6 = strArray[index]) == null ? "" : str6;
					}
					if (string.Compare(var__main_mynorv, "Nouns", true, b4p.cul).ToString((IFormatProvider)b4p.cul) == "0")
					{
						string[] strArray = (string[])this.var__main_xnouns;
						int index = s == "" ? 0 : (int)double.Parse(s, (IFormatProvider)b4p.cul);
						string str6;
						str5 = (str6 = strArray[index]) == null ? "" : str6;
					}
					if (string.Compare(this.__main_xleft(str5, "1"), "*", true, b4p.cul).ToString((IFormatProvider)b4p.cul) == "0")
						str5 = this.Other.SubString(str5, 1, (int)((double)str5.Length - 1.0));
					else
						str4 = s;
					string str7 = var__main_myword.ToUpper(b4p.cul);
					string str8 = str5.ToUpper(b4p.cul);
					if ((double)str7.Length > (this.var__main_wordlength == "" ? 0.0 : double.Parse(this.var__main_wordlength, (IFormatProvider)b4p.cul)))
						str7 = this.__main_xleft(str7, this.var__main_wordlength);
					if ((double)str8.Length > (this.var__main_wordlength == "" ? 0.0 : double.Parse(this.var__main_wordlength, (IFormatProvider)b4p.cul)))
						str8 = this.__main_xleft(str8, this.var__main_wordlength);
					if (string.Compare(str7, str8, true, b4p.cul).ToString((IFormatProvider)b4p.cul) == "0")
						return str4;
				}
				return "-1.0"; // .ToString((IFormatProvider)b4p.cul);
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_whichword");
				return "";
			}
		}

		private string __main_mycmd_keypress(string var__main_key)
		{
			try
			{
				if (!this.LCompareEqual(var__main_key, '\b'.ToString((IFormatProvider)b4p.cul)))
				{
					var__main_key = var__main_key.ToUpper(b4p.cul);
					Application.DoEvents();
					this.__main_mycmd.Focus();
					this.__main_mycmd.SelectionStart = (int)(double)this.__main_mycmd.Text.Length;
					if (this.LCompareEqual(var__main_key, '\r'.ToString((IFormatProvider)b4p.cul)) && (double)this.__main_trim(this.__main_mycmd.Text).Length > 0.0)
					{
						this.__main_addtxtmsg("");
						if (this.__main_checkinput() == "true")
						{
							this.__main_performcommand();
							if (this.LCompareEqual(this.var__main_gamehastorch, "Y"))
								this.__main_worklight();
							this.__main_autoactions();
							this.var__main_sleeping = "N";
							if (this.__main_redraw() == "true")
							{
								this.var__main_lookcleared = "0";
								this.__main_addtxtlook("");
								this.__main_addtxtexits("");
								this.__main_look();
							}
							else
								this.__main_look();
						}
						this.var__main_linkget = "0";
						this.var__main_linkdrop = "0";
						this.var__main_getting = "N";
						this.var__main_dropping = "N";
						this.__main_refreshweb();
						this.var__main_mygetdrop = "0";
						this.var__main_mymag = "0";
						this.var__main_myel = "0";
					}
				}
				if (this.LCompareEqual(var__main_key, '\r'.ToString((IFormatProvider)b4p.cul)))
					this.__main_mycmd.handled = true;
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_mycmd_keypress");
				return "";
			}
		}

		private string __main_buthelp_click()
		{
			try
			{
				if (this.LCompareEqual(this.var__main_sleeping, "Y"))
					return "";
				this.__main_mycmd.Text = "HELP";
				this.__main_mycmd_keypress('\r'.ToString((IFormatProvider)b4p.cul));
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_buthelp_click");
				return "";
			}
		}

		private string __main_hx2(string var__main_htmlreplace2)
		{
			try
			{
				return var__main_htmlreplace2.Replace("{BR}", "<br>");
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_hx2");
				return "";
			}
		}

		private string __main_getcommand(string var__main_notyet)
		{
			try
			{
				this.var__main_starthere = (object)new string[this.var__main_numitems == "" ? 0 : (int)double.Parse(this.var__main_numitems, (IFormatProvider)b4p.cul)];

				//if (this.LCompareEqual(this.var__main_nnum, -1.0.ToString((IFormatProvider)b4p.cul)))
				if (this.var__main_nnum == "-1.0")
				{
					this.__main_addtxtmsg("I can't do that.<br>");
					return "true";
				}

				//if (this.LCompareEqual(this.var__main_nnum, -2.0.ToString((IFormatProvider)b4p.cul)))
				if (this.var__main_nnum == "-2.0")
				{
					if (this.__main_isdark() == "true")
					{
						this.__main_addtxtmsg("It's too dark to see!<br>");
						return "true";
					}
					string lSide = "false";
					this.var__main_carryingtoomuch = "false";
					string rSide = this.var__main_playerroom;
					string original = "";
					string str1 = "0";
					double num1 = this.var__main_numitems == "" ? 0.0 : double.Parse(this.var__main_numitems, (IFormatProvider)b4p.cul);
					for (double num2 = double.Parse(str1, (IFormatProvider)b4p.cul); num2 <= num1; str1 = (++num2).ToString((IFormatProvider)b4p.cul))
					{
						if (this.__main_itemhere(str1) == "true")
						{
							string[] strArray = (string[])this.var__main_xitemautoget;
							int index = str1 == "" ? 0 : (int)double.Parse(str1, (IFormatProvider)b4p.cul);
							string str2;
							if ((double)((str2 = strArray[index]) == null ? "" : str2).Length > 0.0)
							{
								original += "Y";
								continue;
							}
						}
						original += "N";
					}
					string str3 = "0";
					double num3 = this.var__main_numitems == "" ? 0.0 : double.Parse(this.var__main_numitems, (IFormatProvider)b4p.cul);
					for (double num2 = double.Parse(str3, (IFormatProvider)b4p.cul); num2 <= num3; str3 = (++num2).ToString((IFormatProvider)b4p.cul))
					{
						if (this.Other.SubString(original, str3 == "" ? 0 : (int)double.Parse(str3, (IFormatProvider)b4p.cul), 1) == "Y" && this.__main_itemhere(str3) == "true")
						{
							string[] strArray1 = (string[])this.var__main_xitemloc;
							int index1 = str3 == "" ? 0 : (int)double.Parse(str3, (IFormatProvider)b4p.cul);
							string str2;
							if (this.CompareEqual((str2 = strArray1[index1]) == null ? "" : str2, this.var__main_playerroom))
							{
								lSide = "true";
								string[] strArray2 = (string[])this.var__main_xitemtext;
								int index2 = str3 == "" ? 0 : (int)double.Parse(str3, (IFormatProvider)b4p.cul);
								string str4;
								this.__main_addtxtmsg(this.__main_hx((str4 = strArray2[index2]) == null ? "" : str4) + ": ");
								this.var__main_getting = "Y";
								this.var__main_linkget = str3;
								string[] strArray3 = (string[])this.var__main_xitemautoget;
								int index3 = str3 == "" ? 0 : (int)double.Parse(str3, (IFormatProvider)b4p.cul);
								string str5;
								this.var__main_nnum = this.__main_whichword((str5 = strArray3[index3]) == null ? "" : str5, "Nouns");
								string[] strArray4 = (string[])this.var__main_xitemautoget;
								int index4 = str3 == "" ? 0 : (int)double.Parse(str3, (IFormatProvider)b4p.cul);
								string str6;
								this.var__main_getnoun = (str6 = strArray4[index4]) == null ? "" : str6;
								this.var__main_getting = "N";
								this.__main_performcommand();
								this.var__main_linkget = "0";
								if (!this.CompareEqual(this.var__main_playerroom, rSide) || this.__main_isdark() == "true" || this.LCompareEqual(this.var__main_carryingtoomuch, "true"))
									break;
							}
						}
					}
					if (this.LCompareEqual(lSide, "false"))
						this.__main_addtxtmsg("I don't see anything here!<br>");
					return "true";
				}
				this.var__main_linkget = "0";
				string str = this.__main_whichitem(this.var__main_nnum, this.var__main_playerroom);
				if (var__main_notyet.ToLower(b4p.cul) == "true" && (str == "" ? 0.0 : double.Parse(str, (IFormatProvider)b4p.cul)) < 0.0)
					return "false";
				if (this.__main_getitem(str) == "true")
				{
					if (this.__main_isdark().ToLower(b4p.cul) == "true")
						this.__main_addtxtmsg("It is dark but I felt around and got it.");
					else
						this.__main_addtxtmsg("OK<br>");
				}
				else if (this.LCompareEqual(this.var__main_othernegget, "false"))
					this.__main_addtxtmsg("I am carrying too much.<br>");
				return "true";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_getcommand");
				return "";
			}
		}

		private string __main_kbdonoff_click()
		{
			try
			{
				if (this.LCompareEqual(this.var__main_mykbdonoff, "Y"))
				{
					this.__main_kbdonoff.Text = "Kbd = N";
					this.var__main_mykbdonoff = "N";
				}
				else
				{
					this.__main_kbdonoff.Text = "Kbd = Y";
					this.var__main_mykbdonoff = "Y";
				}
				((int)MessageBox.Show("To take effect, you must restart AdvPDA after applying this setting.", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider)b4p.cul);
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_kbdonoff_click");
				return "";
			}
		}

		private string __main_menunew_click()
		{
			try
			{
				if (((int)MessageBox.Show("Exit current quest?\r\n\r\nAre you sure?", "New Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider)b4p.cul) == "6")
				{
					this.var__main_computerexit = "true";
					this.__main_fselect.show();
				}
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_menunew_click");
				return "";
			}
		}

		private string __main_buth_click()
		{
			try
			{
				if (this.LCompareEqual(this.var__main_sleeping, "Y") && this.__main_mycmd.Text.ToUpper(b4p.cul) == "H")
					return "";
				if (this.__main_mycmd.Text.ToUpper(b4p.cul) == "H")
					this.__main_mycmd_keypress('\r'.ToString((IFormatProvider)b4p.cul));
				else
					this.__main_insertchar("H");
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_buth_click");
				return "";
			}
		}

		private string __main_butq_click()
		{
			try
			{
				if (this.LCompareEqual(this.var__main_abcison, "Y"))
					this.__main_insertchar("Q");
				else
					this.__main_insertchar("1");
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_butq_click");
				return "";
			}
		}

		private string __main_checkinput()
		{
			try
			{
				this.var__main_vnum = "-1.0"; // .ToString((IFormatProvider)b4p.cul);
				this.var__main_nnum = "-1.0"; // .ToString((IFormatProvider)b4p.cul);
				string str1 = this.__main_trim(this.__main_mycmd.Text).ToUpper(b4p.cul);
				string str2;
				while (true)
				{
					bool flag;
					for (; !(str1 == "N"); str1 = "0")
					{
						if (str1 == "E")
						{
							str2 = "GO EAST";
							flag = true;
							goto label_23;
						}
						else if (str1 == "W")
						{
							str2 = "GO WEST";
							flag = true;
							goto label_23;
						}
						else if (str1 == "S")
						{
							str2 = "GO SOUTH";
							flag = true;
							goto label_23;
						}
						else if (str1 == "U")
						{
							str2 = "GO UP";
							flag = true;
							goto label_23;
						}
						else if (str1 == "D")
						{
							str2 = "GO DOWN";
							flag = true;
							goto label_23;
						}
						else if (str1 == "I")
						{
							str2 = "INVENTORY";
							flag = true;
							goto label_23;
						}
						else if (str1 == "H")
						{
							str2 = "HELP";
							flag = true;
							goto label_23;
						}
						else if (str1 == "L")
						{
							str2 = "LOOK";
							flag = true;
							goto label_23;
						}
						else if (!(str1 == ""))
						{
							str2 = this.__main_trim(this.__main_mycmd.Text).ToUpper(b4p.cul).Replace("  ", " ");
							flag = true;
							goto label_23;
						}
					}
					str2 = "GO NORTH";
					flag = true;
label_23:
					if (!flag && str1 == "")
						str1 = "0";
					else
						break;
				}
				if (this.LCompareEqual(str2, "NORTH"))
					str2 = "GO " + str2;
				if (this.LCompareEqual(str2, "WEST"))
					str2 = "GO " + str2;
				if (this.LCompareEqual(str2, "EAST"))
					str2 = "GO " + str2;
				if (this.LCompareEqual(str2, "SOUTH"))
					str2 = "GO " + str2;
				if (this.LCompareEqual(str2, "UP"))
					str2 = "GO " + str2;
				if (this.LCompareEqual(str2, "DOWN"))
					str2 = "GO " + str2;
				string str3 = "0";
				this.var__main_word1 = "";
				this.var__main_word2 = "";
				string s1 = "1";
				double num1 = (double)str2.Length;
				for (double num2 = double.Parse(s1, (IFormatProvider)b4p.cul); num2 <= num1; s1 = (++num2).ToString((IFormatProvider)b4p.cul))
				{
					if (this.Other.SubString(str2, (int)((s1 == "" ? 0.0 : double.Parse(s1, (IFormatProvider)b4p.cul)) - 1.0), 1) == " ")
						str3 = ((str3 == "" ? 0.0 : double.Parse(str3, (IFormatProvider)b4p.cul)) + 1.0).ToString((IFormatProvider)b4p.cul);
					if (this.LCompareEqual(str3, "0"))
						this.var__main_word1 = this.var__main_word1 + this.Other.SubString(str2, (int)((s1 == "" ? 0.0 : double.Parse(s1, (IFormatProvider)b4p.cul)) - 1.0), 1);
					if (this.LCompareEqual(str3, "1") && string.Compare(this.Other.SubString(str2, (int)((s1 == "" ? 0.0 : double.Parse(s1, (IFormatProvider)b4p.cul)) - 1.0), 1), " ", true, b4p.cul).ToString((IFormatProvider)b4p.cul) != "0")
						this.var__main_word2 = this.var__main_word2 + this.Other.SubString(str2, (int)((s1 == "" ? 0.0 : double.Parse(s1, (IFormatProvider)b4p.cul)) - 1.0), 1);
				}
				this.var__main_mylastword1 = this.var__main_word1;
				this.var__main_mylastword2 = this.var__main_word2;
				this.var__main_nountext = this.var__main_word2.ToLower(b4p.cul);
				this.var__main_imcarrying = "0";
				if (this.LCompareEqual(this.var__main_word1, "DROP"))
					this.var__main_imcarrying = this.__main_countcarrying();
				if (this.LCompareEqual(this.var__main_word1, "SAVE") && this.LCompareEqual(this.var__main_word2, ""))
				{
					this.var__main_word2 = "GAME";
					str3 = "1";
				}
				if ((str3 == "" ? 0.0 : double.Parse(str3, (IFormatProvider)b4p.cul)) > 1.0)
				{
					this.__main_addtxtmsg("Use 1 or 2 words only!<br>");
					this.__main_mycmd.Text = "";
					return "false";
				}
				if (this.LCompareEqual(str3, "1"))
				{
					this.var__main_vnum = this.__main_whichword(this.var__main_word1, "Verbs");
					this.var__main_nnum = this.__main_whichword(this.var__main_word2, "Nouns");
				}
				if (this.LCompareEqual(str3, "0"))
				{
					this.var__main_vnum = this.__main_whichword(this.var__main_word1, "Verbs");
				}

				//if (this.LCompareEqual(this.var__main_vnum, -1.0.ToString((IFormatProvider)b4p.cul)))
				if (this.var__main_vnum == "-1.0")
				{
					this.var__main_founditem = "-1.0"; // .ToString((IFormatProvider)b4p.cul);
					string s2 = "0";
					double num2 = this.var__main_numitems == "" ? 0.0 : double.Parse(this.var__main_numitems, (IFormatProvider)b4p.cul);
					for (double num3 = double.Parse(s2, (IFormatProvider)b4p.cul); num3 <= num2; s2 = (++num3).ToString((IFormatProvider)b4p.cul))
					{
						string[] strArray = (string[])this.var__main_xitemautoget;
						int index = s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul);
						string str4;
						if (this.CompareEqual((str4 = strArray[index]) == null ? "" : str4, this.var__main_word1))
							this.var__main_founditem = s2;
					}

					// if (this.LCompareEqual(this.var__main_founditem, -1.0.ToString((IFormatProvider)b4p.cul)))
					if (this.var__main_founditem == "-1.0")
					{
						this.__main_addtxtmsg("I don't know how to '" + this.__main_hx(this.var__main_word1) + "' something.<br>");
					}
					else
					{
						this.__main_addtxtmsg("Sorry, I don't understand you.");
					}

					this.__main_mycmd.Text = "";
					return "false";
				}

				// if (this.LCompareEqual(this.var__main_nnum, -1.0.ToString((IFormatProvider)b4p.cul)) && this.__main_xleft(this.var__main_word2, "3") == "ALL")
				if (this.var__main_nnum == "-1.0" && this.__main_xleft(this.var__main_word2, "3") == "ALL")
				{
					this.var__main_nnum = "-2.0"; // .ToString((IFormatProvider)b4p.cul);
				}

				// if ((this.var__main_vnum == "" ? 0.0 : double.Parse(this.var__main_vnum, (IFormatProvider)b4p.cul)) >= 0.0 && (this.LCompareEqual(this.var__main_nnum, -1.0.ToString((IFormatProvider)b4p.cul)) && (double)this.var__main_word2.Length > 0.0))
				if ((this.var__main_vnum == "" ? 0.0 : double.Parse(this.var__main_vnum, (IFormatProvider)b4p.cul)) >= 0.0 && (this.var__main_nnum == "-1.0" && (double)this.var__main_word2.Length > 0.0))
				{
					if (this.LCompareEqual(this.var__main_word1, "SAY"))
					{
						if (this.LCompareEqual(this.var__main_word2, 'X'.ToString((IFormatProvider)b4p.cul) + 'Y'.ToString((IFormatProvider)b4p.cul) + 'Z'.ToString((IFormatProvider)b4p.cul) + 'Z'.ToString((IFormatProvider)b4p.cul) + 'Y'.ToString((IFormatProvider)b4p.cul)))
							this.__main_addtxtmsg("I know not of such dark magic!<br>");
						else
							this.__main_addtxtmsg("OK ... '" + this.__main_hx(this.var__main_word2) + "' !!!<br>");
					}
					else
						this.__main_addtxtmsg("I'm not sure what you mean...");
					this.__main_mycmd.Text = "";
					return "false";
				}
				this.__main_mycmd.Text = "";
				return "true";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_checkinput");
				return "";
			}
		}

		private string __main_readmytheme(string var__main_themefile)
		{
			string str1 = "";
			string str2 = "";
			string original = "";
			string str3 = "";
			string s = "";
			string str4 = "";
			int num = 0;
			try
			{
				if (this.err__main_readmytheme > 0)
				{
					str4 = this.localVars[5];
					s = this.localVars[4];
					str3 = this.localVars[3];
					original = this.localVars[2];
					str2 = this.localVars[1];
					str1 = this.localVars[0];
					if (this.err__main_readmytheme == 1)
					{
						this.err__main_readmytheme = 0;
						((int)MessageBox.Show("Error whilst reading theme '" + this.b4pdir + "\\themes\\" + var__main_themefile + ".thm'", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider)b4p.cul);
						this.var__main_optionsmyadv = "0";
						this.var__main_optionstheme = "A Pastel Paradise";
						this.var__main_optionsfontsize = "1";
						return "";
					}
				}
				num = 1;
				this.htStreams.Add((object)"_main_thmr", (object)new CStreamReader(Path.Combine(this.b4pdir, this.b4pdir + "\\themes\\" + var__main_themefile + ".thm"), Encoding.ASCII));
				for (str4 = (str2 = ((TextReader)this.htStreams[(object)"_main_thmr"]).ReadLine()) == null ? "@eof@" : str2; !this.LCompareEqual(str4, "@eof@"); str4 = (str1 = ((TextReader)this.htStreams[(object)"_main_thmr"]).ReadLine()) == null ? "@eof@" : str1)
				{
					if ((double)str4.Length > 0.0)
					{
						s = str4.IndexOf("=", 0).ToString((IFormatProvider)b4p.cul);
						if ((s == "" ? 0.0 : double.Parse(s, (IFormatProvider)b4p.cul)) > 0.0)
						{
							str3 = this.Other.SubString(str4, 0, s == "" ? 0 : (int)double.Parse(s, (IFormatProvider)b4p.cul));
							original = this.Other.SubString(str4, (int)((s == "" ? 0.0 : double.Parse(s, (IFormatProvider)b4p.cul)) + 1.0), (int)((double)str4.Length - (s == "" ? 0.0 : double.Parse(s, (IFormatProvider)b4p.cul)) - 1.0));
							if (original.Length.ToString((IFormatProvider)b4p.cul) == "7" && this.Other.SubString(original, 0, 1) == "#")
							{
								if (str3.ToUpper(b4p.cul) == "HTML_BODY_BACKGROUND")
									this.var__main_html_body_background = original;
								if (str3.ToUpper(b4p.cul) == "HTML_LOOK_BACKGROUND")
									this.var__main_html_look_background = original;
								if (str3.ToUpper(b4p.cul) == "HTML_EXIT_BACKGROUND")
									this.var__main_html_exit_background = original;
								if (str3.ToUpper(b4p.cul) == "HTML_MESG_BACKGROUND")
									this.var__main_html_mesg_background = original;
								if (str3.ToUpper(b4p.cul) == "HTML_ROOM_TEXT")
									this.var__main_html_room_text = original;
								if (str3.ToUpper(b4p.cul) == "HTML_LOOK_TEXT")
									this.var__main_html_look_text = original;
								if (str3.ToUpper(b4p.cul) == "HTML_EXIT_TEXT")
									this.var__main_html_exit_text = original;
								if (str3.ToUpper(b4p.cul) == "HTML_MESG_TEXT")
									this.var__main_html_mesg_text = original;
								if (str3.ToUpper(b4p.cul) == "HTML_LOOK_PROMPT")
									this.var__main_html_look_prompt = original;
								if (str3.ToUpper(b4p.cul) == "HTML_EXIT_PROMPT")
									this.var__main_html_exit_prompt = original;
								if (str3.ToUpper(b4p.cul) == "HTML_LOOK_HYPERLINK")
									this.var__main_html_look_hyperlink = original;
								if (str3.ToUpper(b4p.cul) == "HTML_EXIT_HYPERLINK")
									this.var__main_html_exit_hyperlink = original;
								if (str3.ToUpper(b4p.cul) == "HTML_MESG_HYPERLINK")
									this.var__main_html_mesg_hyperlink = original;
								if (str3.ToUpper(b4p.cul) == "HTML_LINE_BREAK")
									this.var__main_html_line_break = original;
							}
						}
					}
				}
				if (this.htStreams.Contains((object)"_main_thmr"))
				{
					((IStream)this.htStreams[(object)"_main_thmr"]).Close();
					this.htStreams.Remove((object)"_main_thmr");
					GC.Collect();
				}
				return "";
			}
			catch (Exception ex)
			{
				if (num > 0)
				{
					this.lastError = ex;
					this.err__main_readmytheme = num;
					this.localVars = new string[6]
			 {
				str1,
				str2,
				original,
				str3,
				s,
				str4
			 };
					return this.__main_readmytheme(var__main_themefile);
				}
				this.ShowError(ex, "__main_readmytheme");
				return "";
			}
		}

		private string __main_butn_click()
		{
			try
			{
				if (this.LCompareEqual(this.var__main_sleeping, "Y") && this.__main_mycmd.Text.ToUpper(b4p.cul) == "N")
					return "";
				if (this.__main_mycmd.Text.ToUpper(b4p.cul) == "N")
					this.__main_mycmd_keypress('\r'.ToString((IFormatProvider)b4p.cul));
				else
					this.__main_insertchar("N");
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_butn_click");
				return "";
			}
		}

		private string __main_clearscreen()
		{
			try
			{
				this.__main_addtxtmsg("");
				this.__main_addtxtlook("");
				this.__main_addtxtexits("");
				this.var__main_llclear = "true";
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_clearscreen");
				return "";
			}
		}

		private string __main_treasurecheck(string var__main_tcheck)
		{
			try
			{
				if (this.__main_xleft(var__main_tcheck, "2") == "* " && this.__main_right(var__main_tcheck, "2") == " *")
					return "*" + this.Other.SubString(var__main_tcheck, 2, (int)((double)var__main_tcheck.Length - 4.0)) + "*";
				return var__main_tcheck;
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_treasurecheck");
				return "";
			}
		}

		private string __main_showsoftkeyboard(string var__main_sksh)
		{
			try
			{
				this.__main_butabc123.Visible = bool.Parse(var__main_sksh.ToLower(b4p.cul));
				this.__main_buta.Visible = bool.Parse(var__main_sksh.ToLower(b4p.cul));
				this.__main_butb.Visible = bool.Parse(var__main_sksh.ToLower(b4p.cul));
				this.__main_butc.Visible = bool.Parse(var__main_sksh.ToLower(b4p.cul));
				this.__main_butd.Visible = bool.Parse(var__main_sksh.ToLower(b4p.cul));
				this.__main_bute.Visible = bool.Parse(var__main_sksh.ToLower(b4p.cul));
				this.__main_butf.Visible = bool.Parse(var__main_sksh.ToLower(b4p.cul));
				this.__main_butg.Visible = bool.Parse(var__main_sksh.ToLower(b4p.cul));
				this.__main_buth.Visible = bool.Parse(var__main_sksh.ToLower(b4p.cul));
				this.__main_buti.Visible = bool.Parse(var__main_sksh.ToLower(b4p.cul));
				this.__main_butj.Visible = bool.Parse(var__main_sksh.ToLower(b4p.cul));
				this.__main_butk.Visible = bool.Parse(var__main_sksh.ToLower(b4p.cul));
				this.__main_butl.Visible = bool.Parse(var__main_sksh.ToLower(b4p.cul));
				this.__main_butm.Visible = bool.Parse(var__main_sksh.ToLower(b4p.cul));
				this.__main_butn.Visible = bool.Parse(var__main_sksh.ToLower(b4p.cul));
				this.__main_buto.Visible = bool.Parse(var__main_sksh.ToLower(b4p.cul));
				this.__main_butp.Visible = bool.Parse(var__main_sksh.ToLower(b4p.cul));
				this.__main_butq.Visible = bool.Parse(var__main_sksh.ToLower(b4p.cul));
				this.__main_butr.Visible = bool.Parse(var__main_sksh.ToLower(b4p.cul));
				this.__main_buts.Visible = bool.Parse(var__main_sksh.ToLower(b4p.cul));
				this.__main_butt.Visible = bool.Parse(var__main_sksh.ToLower(b4p.cul));
				this.__main_butu.Visible = bool.Parse(var__main_sksh.ToLower(b4p.cul));
				this.__main_butv.Visible = bool.Parse(var__main_sksh.ToLower(b4p.cul));
				this.__main_butw.Visible = bool.Parse(var__main_sksh.ToLower(b4p.cul));
				this.__main_butx.Visible = bool.Parse(var__main_sksh.ToLower(b4p.cul));
				this.__main_buty.Visible = bool.Parse(var__main_sksh.ToLower(b4p.cul));
				this.__main_butz.Visible = bool.Parse(var__main_sksh.ToLower(b4p.cul));
				this.__main_butdel.Visible = bool.Parse(var__main_sksh.ToLower(b4p.cul));
				this.__main_butenter.Visible = bool.Parse(var__main_sksh.ToLower(b4p.cul));
				this.__main_butspace.Visible = bool.Parse(var__main_sksh.ToLower(b4p.cul));
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_showsoftkeyboard");
				return "";
			}
		}

		private string __main_butspace_click()
		{
			try
			{
				this.__main_insertchar(" ");
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_butspace_click");
				return "";
			}
		}

		private string __main_butplay_click()
		{
			try
			{
				this.var__main_cancel = "false";
				this.__main_webby.DocumentText = "<html><body><img border='0' src='file://" + this.b4pdir + "/images/map.jpg'><br><img border='0' src='file://" + this.b4pdir + "/images/progress.gif'></body></html>";
				this.var__main_cancel = "true";
				this.__main_webby.CancelNavigate = bool.Parse("true".ToLower(b4p.cul));
				this.var__main_l = "1";
				double num1 = 5.0;
				for (double num2 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul); num2 <= num1; this.var__main_l = (num2 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul) + 1.0).ToString((IFormatProvider)b4p.cul))
				{
					Application.DoEvents();
					Thread.Sleep(100);
				}
				this.__main_fadventure.show();
				this.var__main_l = "1";
				double num3 = 5.0;
				for (double num2 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul); num2 <= num3; this.var__main_l = (num2 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul) + 1.0).ToString((IFormatProvider)b4p.cul))
				{
					Application.DoEvents();
					Thread.Sleep(100);
				}
				this.__main_mycmd.Text = "";
				this.__main_mycmd.Focus();
				this.__main_saveoptionstofile();
				this.__main_loadfile(this.var__main_myadventure);
				this.__main_refreshweb();
				this.__main_butenter.Enabled = bool.Parse("true".ToLower(b4p.cul));
				this.__main_butdel.Enabled = bool.Parse("true".ToLower(b4p.cul));
				this.__main_butgo.Enabled = bool.Parse("true".ToLower(b4p.cul));
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_butplay_click");
				return "";
			}
		}

		private string __main_butapply_click()
		{
			try
			{
				this.var__main_lastmsghlcolor = this.var__main_html_mesg_hyperlink;
				this.var__main_optionstheme = this.__main_pdtheme.Items[(int)(double)this.__main_pdtheme.SelectedIndex].ToString();
				this.var__main_optionsfontsize = ((double)this.__main_pdfontsize.SelectedIndex + 1.0).ToString((IFormatProvider)b4p.cul);
				this.var__main_optionslinks = this.__main_pdlinks.SelectedIndex.ToString((IFormatProvider)b4p.cul);
				this.var__main_optionsfontbold = this.__main_fontbold.SelectedIndex.ToString((IFormatProvider)b4p.cul);
				this.var__main_althyper = this.__main_linkfix.SelectedIndex.ToString((IFormatProvider)b4p.cul);
				if (this.LCompareEqual(this.var__main_althyper, "0"))
				{
					this.var__main_optionsalthyperon = "N";
					this.var__main_hyper = "about:";
					this.__main_linkfix.SelectedIndex = 0;
				}
				else
				{
					this.var__main_optionsalthyperon = "Y";
					this.var__main_hyper = "file:///advpda.htm%3F";
					this.__main_linkfix.SelectedIndex = 1;
					this.__main_createdummy();
				}
				if ((double)this.__main_bdi.GetOSVersionString().IndexOf("Windows NT", 0) > -1.0 || (double)this.__main_bdi.GetOSVersionString().IndexOf("Vista", 0) > -1.0)
				{
					this.var__main_optionsalthyperon = "N";
					this.var__main_hyper = "about:";
					this.__main_linkfix.SelectedIndex = 0;
				}
				this.var__main_optionslinkson = this.Other.SubString(this.__main_pdlinks.Items[(int)(double)this.__main_pdlinks.SelectedIndex].ToString(), 0, 1);
				this.var__main_optionsrvsinfo = this.Other.SubString(this.__main_pdoptrvs.Items[(int)(double)this.__main_pdoptrvs.SelectedIndex].ToString(), 0, 1);
				this.__main_readmytheme(this.__main_pdtheme.Items[(int)(double)this.__main_pdtheme.SelectedIndex].ToString());
				this.__main_html_stuff();
				this.__main_look();
				this.var__main_txtmsg = this.var__main_txtmsg.Replace(this.var__main_lastmsghlcolor, this.var__main_html_mesg_hyperlink);
				this.__main_refreshweb();
				this.__main_saveoptionstofile();
				this.__main_foptions.close();
				this.__main_fadventure.show();
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_butapply_click");
				return "";
			}
		}

		private string __main_butk_click()
		{
			try
			{
				this.__main_insertchar("K");
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_butk_click");
				return "";
			}
		}

		private string __main_butr_click()
		{
			try
			{
				if (this.LCompareEqual(this.var__main_abcison, "Y"))
					this.__main_insertchar("R");
				else
					this.__main_insertchar("4");
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_butr_click");
				return "";
			}
		}

		private string __main_timer1_tick()
		{
			try
			{
				this.__main_timer1.Enabled = bool.Parse("false".ToLower(b4p.cul));
				this.__main_mycmd_keypress('\r'.ToString((IFormatProvider)b4p.cul));
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_timer1_tick");
				return "";
			}
		}

		private string __main_hx(string var__main_htmlreplace)
		{
			try
			{
				string str = var__main_htmlreplace.Replace(">", "&gt;").Replace("<", "&lt;").Replace("{BR}", "<br>");
				if (this.LCompareEqual(this.var__main_optionsfontbold, "1"))
					str = "<b>" + str + "</b>";
				return str;
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_hx");
				return "";
			}
		}

		private string __main_createdummy()
		{
			try
			{
				this.htStreams.Add((object)"_main_c1", (object)new CStreamWriter(Path.Combine(this.b4pdir, "\\advpda.htm"), false, Encoding.ASCII));
				((TextWriter)this.htStreams[(object)"_main_c1"]).WriteLine(" ");
				if (this.htStreams.Contains((object)"_main_c1"))
				{
					((IStream)this.htStreams[(object)"_main_c1"]).Close();
					this.htStreams.Remove((object)"_main_c1");
					GC.Collect();
				}
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_createdummy");
				return "";
			}
		}

		private string __main_checkinvext(string var__main_cie)
		{
			try
			{
				return var__main_cie.Replace("</a>. which ", "</a> which ").Replace("</a>. that ", "</a> that ");
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_checkinvext");
				return "";
			}
		}

		private string __main_butabc123_click()
		{
			try
			{
				this.var__main_abcison = !this.LCompareEqual(this.var__main_abcison, "N") ? "N" : "Y";
				if (this.LCompareEqual(this.var__main_abcison, "Y"))
				{
					this.__main_butq.Text = "Q";
					this.__main_butw.Text = "W";
					this.__main_bute.Text = "E";
					this.__main_butr.Text = "R";
					this.__main_butt.Text = "T";
					this.__main_buty.Text = "Y";
					this.__main_butu.Text = "U";
					this.__main_buti.Text = "I";
					this.__main_buto.Text = "O";
					this.__main_butp.Text = "P";
				}
				else
				{
					this.__main_butq.Text = "1";
					this.__main_butw.Text = "2";
					this.__main_bute.Text = "3";
					this.__main_butr.Text = "4";
					this.__main_butt.Text = "5";
					this.__main_buty.Text = "6";
					this.__main_butu.Text = "7";
					this.__main_buti.Text = "8";
					this.__main_buto.Text = "9";
					this.__main_butp.Text = "0";
				}
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_butabc123_click");
				return "";
			}
		}

		private string __main_readoptionsfromfile()
		{
			string str1 = "";
			string str2 = "";
			string str3 = "";
			string str4 = "";
			string str5 = "";
			string str6 = "";
			string str7 = "";
			string lSide = "";
			string str8 = "";
			string str9 = "";
			string str10 = "";
			string str11 = "";
			int num = 0;
			try
			{
				if (this.err__main_readoptionsfromfile > 0)
				{
					str11 = this.localVars[11];
					str10 = this.localVars[10];
					str9 = this.localVars[9];
					str8 = this.localVars[8];
					lSide = this.localVars[7];
					str7 = this.localVars[6];
					str6 = this.localVars[5];
					str5 = this.localVars[4];
					str4 = this.localVars[3];
					str3 = this.localVars[2];
					str2 = this.localVars[1];
					str1 = this.localVars[0];
					if (this.err__main_readoptionsfromfile == 1)
					{
						this.err__main_readoptionsfromfile = 0;
						if (this.LCompareEqual(lSide, "Y") && this.htStreams.Contains((object)"_main_inir"))
						{
							((IStream)this.htStreams[(object)"_main_inir"]).Close();
							this.htStreams.Remove((object)"_main_inir");
							GC.Collect();
						}
						this.var__main_optionsmyadv = "0";
						this.var__main_optionstheme = "A Pastel Paradise";
						this.var__main_optionsfontsize = "1";
						this.var__main_optionsfontbold = "0";
						this.var__main_optionslinks = "0";
						this.var__main_optionslinkson = "Y";
						this.var__main_althyper = "0";
						this.var__main_optionsalthyperon = "N";
						this.var__main_hyper = "about:";
						this.__main_pdlinks.SelectedIndex = 0;
						this.var__main_optionsfontbold = "0";
						this.__main_fontbold.SelectedIndex = this.var__main_optionsfontbold == "" ? 0 : (int)double.Parse(this.var__main_optionsfontbold, (IFormatProvider)b4p.cul);
						this.var__main_seelmagain = "Y";
						if (this.LCompareEqual(this.var__main_disablelinks, "N"))
						{
							this.__main_pdlinks.SelectedIndex = this.var__main_optionslinks == "" ? 0 : (int)double.Parse(this.var__main_optionslinks, (IFormatProvider)b4p.cul);
						}
						else
						{
							this.var__main_optionslinkson = "N";
							this.var__main_optionslinks = "1";
							this.__main_pdlinks.SelectedIndex = 1;
							this.__main_pdlinks.Enabled = bool.Parse("false".ToLower(b4p.cul));
						}
						this.var__main_optionsrvsinfo = "N";
						this.__main_pdoptrvs.SelectedIndex = 1;
						return "";
					}
				}
				lSide = "N";
				num = 1;
				this.htStreams.Add((object)"_main_inir", (object)new CStreamReader(Path.Combine(this.b4pdir, this.b4pdir + "\\advpda.ini"), Encoding.ASCII));
				str4 = (str8 = ((TextReader)this.htStreams[(object)"_main_inir"]).ReadLine()) == null ? "@eof@" : str8;
				lSide = "Y";
				this.var__main_optionsmyadv = (str1 = ((TextReader)this.htStreams[(object)"_main_inir"]).ReadLine()) == null ? "@eof@" : str1;
				this.var__main_optionstheme = (str5 = ((TextReader)this.htStreams[(object)"_main_inir"]).ReadLine()) == null ? "@eof@" : str5;
				this.var__main_optionsfontsize = (str7 = ((TextReader)this.htStreams[(object)"_main_inir"]).ReadLine()) == null ? "@eof@" : str7;
				this.var__main_optionslinks = (str10 = ((TextReader)this.htStreams[(object)"_main_inir"]).ReadLine()) == null ? "@eof@" : str10;
				this.var__main_seelmagain = (str11 = ((TextReader)this.htStreams[(object)"_main_inir"]).ReadLine()) == null ? "@eof@" : str11;
				this.var__main_optionsrvsinfo = (str3 = ((TextReader)this.htStreams[(object)"_main_inir"]).ReadLine()) == null ? "@eof@" : str3;
				this.var__main_optionslinkson = !this.LCompareEqual(this.var__main_optionslinks, "0") ? "N" : "Y";
				this.var__main_althyper = (str6 = ((TextReader)this.htStreams[(object)"_main_inir"]).ReadLine()) == null ? "@eof@" : str6;
				if (this.LCompareEqual(this.var__main_althyper, "0"))
				{
					this.var__main_optionsalthyperon = "N";
					this.var__main_hyper = "about:";
					this.__main_linkfix.SelectedIndex = 0;
				}
				else
				{
					this.var__main_optionsalthyperon = "Y";
					this.var__main_hyper = "file:///advpda.htm%3F";
					this.__main_linkfix.SelectedIndex = 1;
				}
				this.var__main_optionsfontbold = (str9 = ((TextReader)this.htStreams[(object)"_main_inir"]).ReadLine()) == null ? "@eof@" : str9;
				this.__main_fontbold.SelectedIndex = this.var__main_optionsfontbold == "" ? 0 : (int)double.Parse(this.var__main_optionsfontbold, (IFormatProvider)b4p.cul);
				this.var__main_mykbdonoff = (str2 = ((TextReader)this.htStreams[(object)"_main_inir"]).ReadLine()) == null ? "@eof@" : str2;
				if (this.LCompareEqual(this.var__main_mykbdonoff, "Y"))
				{
					this.__main_kbdonoff.Text = "Kbd = Y";
				}
				else
				{
					this.__main_kbdonoff.Text = "Kbd = N";
					this.__main_showsoftkeyboard("false");
					this.var__main_keyboardisoff = "Y";
				}
				if (this.htStreams.Contains((object)"_main_inir"))
				{
					((IStream)this.htStreams[(object)"_main_inir"]).Close();
					this.htStreams.Remove((object)"_main_inir");
					GC.Collect();
				}
				if (this.LCompareEqual(this.var__main_disablelinks, "N"))
				{
					this.__main_pdlinks.SelectedIndex = this.var__main_optionslinks == "" ? 0 : (int)double.Parse(this.var__main_optionslinks, (IFormatProvider)b4p.cul);
				}
				else
				{
					this.var__main_optionslinks = "1";
					this.var__main_optionslinkson = "N";
					this.__main_pdlinks.SelectedIndex = 1;
					this.__main_pdlinks.Enabled = bool.Parse("false".ToLower(b4p.cul));
				}
				if (this.LCompareEqual(this.var__main_optionsrvsinfo, "Y"))
					this.__main_pdoptrvs.SelectedIndex = 0;
				else
					this.__main_pdoptrvs.SelectedIndex = 1;
				if (this.LCompareEqual(this.var__main_althyper, "1"))
					this.__main_createdummy();
				return "";
			}
			catch (Exception ex)
			{
				if (num > 0)
				{
					this.lastError = ex;
					this.err__main_readoptionsfromfile = num;
					this.localVars = new string[12]
			 {
				str1,
				str2,
				str3,
				str4,
				str5,
				str6,
				str7,
				lSide,
				str8,
				str9,
				str10,
				str11
			 };
					return this.__main_readoptionsfromfile();
				}
				this.ShowError(ex, "__main_readoptionsfromfile");
				return "";
			}
		}

		private string __main_movecommand()
		{
			try
			{
				// if (this.LCompareEqual(this.var__main_nnum, -1.0.ToString((IFormatProvider)b4p.cul)))
				if (this.var__main_nnum == "-1.0")
				{
					this.__main_addtxtmsg("I also need a direction.<br>");
					return "true";
				}
				if ((this.var__main_nnum == "" ? 0.0 : double.Parse(this.var__main_nnum, (IFormatProvider)b4p.cul)) < 1.0 || (this.var__main_nnum == "" ? 0.0 : double.Parse(this.var__main_nnum, (IFormatProvider)b4p.cul)) > 6.0)
					return "false";
				if (this.__main_isdark() == "true")
					this.__main_addtxtmsg("It's dangerous to move in the dark!<br>");
				string[,] strArray = (string[,])this.var__main_xroomexit;
				int index1 = this.var__main_playerroom == "" ? 0 : (int)double.Parse(this.var__main_playerroom, (IFormatProvider)b4p.cul);
				int index2 = (int)((this.var__main_nnum == "" ? 0.0 : double.Parse(this.var__main_nnum, (IFormatProvider)b4p.cul)) - 1.0);
				string str;
				string lSide = (str = strArray[index1, index2]) == null ? "" : str;
				if (!this.LCompareEqual(lSide, "0"))
				{
					this.var__main_playerroom = lSide;
					this.__main_addtxtmsg("OK<br>");
					this.var__main_llclear = "true";
					return "true";
				}
				if (this.__main_isdark() == "true")
				{
					this.__main_addtxtmsg("I fell and broke my neck!<br>");
					this.__main_killplayer();
					return "true";
				}
				this.__main_addtxtmsg("I can't go that way.<br>");
				return "true";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_movecommand");
				return "";
			}
		}

		private string __main_butgetdrop_click()
		{
			try
			{
				if (this.LCompareEqual(this.var__main_sleeping, "Y"))
					return "";
				this.var__main_mygetdrop = ((this.var__main_mygetdrop == "" ? 0.0 : double.Parse(this.var__main_mygetdrop, (IFormatProvider)b4p.cul)) + 1.0).ToString((IFormatProvider)b4p.cul);
				if (this.LCompareEqual(this.var__main_mygetdrop, "5"))
					this.var__main_mygetdrop = "1";
				bool flag = false;
				string str = this.var__main_mygetdrop;
				while (true)
				{
					if (str == "1")
					{
						this.__main_mycmd.Text = "GET ";
						flag = true;
					}
					else if (str == "2")
					{
						this.__main_mycmd.Text = "DROP ";
						flag = true;
					}
					else if (str == "3")
					{
						this.__main_mycmd.Text = "GET ALL";
						flag = true;
					}
					else if (str == "4")
					{
						this.__main_mycmd.Text = "DROP ALL";
						flag = true;
					}
					if (!flag && str == "")
						str = "0";
					else
						break;
				}
				this.__main_mycmd.Focus();
				this.__main_mycmd.SelectionStart = (int)(double)this.__main_mycmd.Text.Length;
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_butgetdrop_click");
				return "";
			}
		}

		private string __main_butf_click()
		{
			try
			{
				this.__main_insertchar("F");
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_butf_click");
				return "";
			}
		}

		private string __main_worklight()
		{
			try
			{
				// if (this.__main_itemdestroyed(this.var__main_light_source) == "false" && !this.LCompareEqual(this.var__main_lighttime, -1.0.ToString((IFormatProvider)b4p.cul)))
				if (this.__main_itemdestroyed(this.var__main_light_source) == "false" && this.var__main_lighttime != "-1.0")
				{
					this.var__main_lighttime = ((this.var__main_lighttime == "" ? 0.0 : double.Parse(this.var__main_lighttime, (IFormatProvider)b4p.cul)) - 1.0).ToString((IFormatProvider)b4p.cul);
					if ((this.var__main_lighttime == "" ? 0.0 : double.Parse(this.var__main_lighttime, (IFormatProvider)b4p.cul)) < 1.0)
					{
						this.__main_setflag(this.var__main_lightoutbit);
						if (this.__main_itemavailable(this.var__main_light_source).ToLower(b4p.cul) == "true")
						{
							this.__main_addtxtmsg("<br>The light has run out!<br>");
							this.__main_look();
						}
						((string[])this.var__main_xitemloc)[this.var__main_light_source == "" ? 0 : (int)double.Parse(this.var__main_light_source, (IFormatProvider)b4p.cul)] = this.var__main_destroyed;
					}
					else if ((this.var__main_lighttime == "" ? 0.0 : double.Parse(this.var__main_lighttime, (IFormatProvider)b4p.cul)) < 25.0 && this.__main_itemavailable(this.var__main_light_source).ToLower(b4p.cul) == "true")
					{
						this.__main_addtxtmsg("<br>The light runs out in " + this.var__main_lighttime + " turn");
						if ((this.var__main_lighttime == "" ? 0.0 : double.Parse(this.var__main_lighttime, (IFormatProvider)b4p.cul)) > 1.0)
							this.__main_addtxtmsg("s.<br>");
						else
							this.__main_addtxtmsg(".<br>");
					}
				}
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_worklight");
				return "";
			}
		}

		private string __main_butinv_click()
		{
			try
			{
				if (this.LCompareEqual(this.var__main_sleeping, "Y"))
					return "";
				this.__main_mycmd.Text = "INVENTORY";
				this.__main_mycmd_keypress('\r'.ToString((IFormatProvider)b4p.cul));
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_butinv_click");
				return "";
			}
		}

		private string __main_butgo_click()
		{
			try
			{
				if (this.LCompareEqual(this.var__main_sleeping, "Y"))
					return "";
				this.__main_mycmd_keypress('\r'.ToString((IFormatProvider)b4p.cul));
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_butgo_click");
				return "";
			}
		}

		private string __main_performcommand()
		{
			string str1 = "";
			string str2 = "";
			try
			{
				if (this.CompareEqual(this.var__main_vnum, this.var__main_go_verb) && this.__main_movecommand().ToLower(b4p.cul) == "true")
					return "";
				string lSide = "-1.0"; // .ToString((IFormatProvider)b4p.cul);
				string str3 = "0";
				double num1 = this.var__main_numactions == "" ? 0.0 : double.Parse(this.var__main_numactions, (IFormatProvider)b4p.cul);
				for (double num2 = double.Parse(str3, (IFormatProvider)b4p.cul); num2 <= num1; str3 = (++num2).ToString((IFormatProvider)b4p.cul))
				{
					str2 = "0";
					str1 = "0";
					string[] strArray = (string[])this.var__main_xactionvocab;
					int index = str3 == "" ? 0 : (int)double.Parse(str3, (IFormatProvider)b4p.cul);
					string str4;
					string s = (str4 = strArray[index]) == null ? "" : str4;
					string string1 = ((s == "" ? 0.0 : double.Parse(s, (IFormatProvider)b4p.cul)) % 150.0).ToString((IFormatProvider)b4p.cul);
					string string2 = Math.Floor((s == "" ? 0.0 : double.Parse(s, (IFormatProvider)b4p.cul)) / 150.0).ToString((IFormatProvider)b4p.cul);
					if (this.LCompareEqual(string2, "0") && this.LCompareEqual(string1, "0") || !this.LCompareEqual(this.var__main_continuation, "true"))
					{
						if (this.CompareEqual(this.var__main_vnum, string2) && (this.CompareEqual(this.var__main_nnum, string1) || this.LCompareEqual(string1, "0")) || this.LCompareEqual(this.var__main_continuation, "true"))
						{
							// if (this.LCompareEqual(lSide, -1.0.ToString((IFormatProvider)b4p.cul)))
							if (lSide == "-1.0")
							{
								lSide = "0";
							}

							if (this.__main_performactionline(str3) == "true")
							{
								lSide = "1";
								if (this.LCompareEqual(this.var__main_continuation, "false"))
									break;
							}
						}
					}
					else
						break;
				}
				this.var__main_continuation = "false";
				if (this.LCompareEqual(lSide, "1") || this.CompareEqual(this.var__main_vnum, this.var__main_get_verb) && this.__main_getcommand(!this.LCompareEqual(lSide, "0") ? "false" : "true") == "true" || this.CompareEqual(this.var__main_vnum, this.var__main_drop_verb) && this.__main_dropcommand(!this.LCompareEqual(lSide, "0") ? "false" : "true") == "true")
					return "";
				bool flag = false;
				string str5 = lSide;
				while (true)
				{
					// if (str5 == -1.0.ToString((IFormatProvider)b4p.cul))
					if (str5 == "-1.0")
					{
						this.__main_addtxtmsg("I don't understand you.<br>");
						flag = true;
					}
					else if (str5 == "0")
					{
						this.__main_addtxtmsg("I can't do that... YET!<br>");
						flag = true;
					}
					if (!flag && str5 == "")
						str5 = "0";
					else
						break;
				}
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_performcommand");
				return "";
			}
		}

		private string __main_quit()
		{
			try
			{
				if (this.__main_redraw() == "true")
					this.__main_look();
				this.__main_refreshweb();
				((int)MessageBox.Show("Your adventure is over.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider)b4p.cul);
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_quit");
				return "";
			}
		}

		private string __main_isdark()
		{
			try
			{
				return this.__main_getflag(this.var__main_darkbit) == "true" && this.__main_itemavailable(this.var__main_light_source) == "false" ? "true" : "false";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_isdark");
				return "";
			}
		}

		private string __main_butc_click()
		{
			try
			{
				this.__main_insertchar("C");
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_butc_click");
				return "";
			}
		}

		private string __main_countcarried()
		{
			string str1 = "";
			try
			{
				str1 = "0";
				string s1 = "0";
				string s2 = "0";
				double num1 = this.var__main_numitems == "" ? 0.0 : double.Parse(this.var__main_numitems, (IFormatProvider)b4p.cul);
				for (double num2 = double.Parse(s2, (IFormatProvider)b4p.cul); num2 <= num1; s2 = (++num2).ToString((IFormatProvider)b4p.cul))
				{
					string[] strArray1 = (string[])this.var__main_xitemloc;
					int index1 = s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul);
					string str2;
					if (this.CompareEqual((str2 = strArray1[index1]) == null ? "" : str2, this.var__main_carried))
						s1 = ((s1 == "" ? 0.0 : double.Parse(s1, (IFormatProvider)b4p.cul)) + 1.0).ToString((IFormatProvider)b4p.cul);
					string[] strArray2 = (string[])this.var__main_xitemloc;
					int index2 = s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul);
					string str3;
					if (this.CompareEqual((str3 = strArray2[index2]) == null ? "" : str3, this.var__main_carried))
					{
						string[] strArray3 = (string[])this.var__main_xitemautoget;
						int index3 = s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul);
						string str4;
						if (this.LCompareEqual((str4 = strArray3[index3]) == null ? "" : str4, ""))
						{
							string[] strArray4 = (string[])this.var__main_xitemtext;
							int index4 = s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul);
							string str5;
							if ((double)((str5 = strArray4[index4]) == null ? "" : str5).ToLower(b4p.cul).IndexOf("wearing", 0) <= 0.0)
							{
								string[] strArray5 = (string[])this.var__main_xitemtext;
								int index5 = s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul);
								string str6;
								if ((double)((str6 = strArray5[index5]) == null ? "" : str6).ToLower(b4p.cul).IndexOf("worn", 0) <= 0.0)
								{
									string[] strArray6 = (string[])this.var__main_xitemtext;
									int index6 = s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul);
									string str7;
									if ((double)((str7 = strArray6[index6]) == null ? "" : str7).ToLower(b4p.cul).IndexOf("activated", 0) <= 0.0)
									{
										Other other1 = this.Other;
										string[] strArray7 = (string[])this.var__main_xitemtext;
										int index7 = s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul);
										string str8;
										string lower1 = ((str8 = strArray7[index7]) == null ? "" : str8).ToLower(b4p.cul);
										int start1 = 0;
										int count1 = 6;
										if (!(other1.SubString(lower1, start1, count1) == "which "))
										{
											Other other2 = this.Other;
											string[] strArray8 = (string[])this.var__main_xitemtext;
											int index8 = s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul);
											string str9;
											string lower2 = ((str9 = strArray8[index8]) == null ? "" : str9).ToLower(b4p.cul);
											int start2 = 0;
											int count2 = 5;
											if (!(other2.SubString(lower2, start2, count2) == "that "))
											{
												Other other3 = this.Other;
												string[] strArray9 = (string[])this.var__main_xitemtext;
												int index9 = s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul);
												string str10;
												string lower3 = ((str10 = strArray9[index9]) == null ? "" : str10).ToLower(b4p.cul);
												int start3 = 0;
												int count3 = 5;
												if (!(other3.SubString(lower3, start3, count3) == "with "))
												{
													Other other4 = this.Other;
													string[] strArray10 = (string[])this.var__main_xitemtext;
													int index10 = s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul);
													string str11;
													string lower4 = ((str11 = strArray10[index10]) == null ? "" : str11).ToLower(b4p.cul);
													int start4 = 0;
													int count4 = 5;
													if (!(other4.SubString(lower4, start4, count4) == "they "))
													{
														Other other5 = this.Other;
														string[] strArray11 = (string[])this.var__main_xitemtext;
														int index11 = s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul);
														string str12;
														string lower5 = ((str12 = strArray11[index11]) == null ? "" : str12).ToLower(b4p.cul);
														int start5 = 0;
														int count5 = 8;
														if (!(other5.SubString(lower5, start5, count5) == "they're "))
														{
															Other other6 = this.Other;
															string[] strArray12 = (string[])this.var__main_xitemtext;
															int index12 = s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul);
															string str13;
															string lower6 = ((str13 = strArray12[index12]) == null ? "" : str13).ToLower(b4p.cul);
															int start6 = 0;
															int count6 = 8;
															if (!(other6.SubString(lower6, start6, count6) == "they`re "))
															{
																Other other7 = this.Other;
																string[] strArray13 = (string[])this.var__main_xitemtext;
																int index13 = s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul);
																string str14;
																string lower7 = ((str14 = strArray13[index13]) == null ? "" : str14).ToLower(b4p.cul);
																int start7 = 0;
																int count7 = 4;
																if (!(other7.SubString(lower7, start7, count7) == "i'm "))
																{
																	Other other8 = this.Other;
																	string[] strArray14 = (string[])this.var__main_xitemtext;
																	int index14 = s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul);
																	string str15;
																	string lower8 = ((str15 = strArray14[index14]) == null ? "" : str15).ToLower(b4p.cul);
																	int start8 = 0;
																	int count8 = 5;
																	if (!(other8.SubString(lower8, start8, count8) == "i am "))
																	{
																		Other other9 = this.Other;
																		string[] strArray15 = (string[])this.var__main_xitemtext;
																		int index15 = s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul);
																		string str16;
																		string lower9 = ((str16 = strArray15[index15]) == null ? "" : str16).ToLower(b4p.cul);
																		int start9 = 0;
																		int count9 = 3;
																		if (!(other9.SubString(lower9, start9, count9) == "it "))
																		{
																			Other other10 = this.Other;
																			string[] strArray16 = (string[])this.var__main_xitemtext;
																			int index16 = s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul);
																			string str17;
																			string lower10 = ((str17 = strArray16[index16]) == null ? "" : str17).ToLower(b4p.cul);
																			int start10 = 0;
																			int count10 = 5;
																			if (!(other10.SubString(lower10, start10, count10) == "it`s "))
																			{
																				Other other11 = this.Other;
																				string[] strArray17 = (string[])this.var__main_xitemtext;
																				int index17 = s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul);
																				string str18;
																				string lower11 = ((str18 = strArray17[index17]) == null ? "" : str18).ToLower(b4p.cul);
																				int start11 = 0;
																				int count11 = 3;
																				if (!(other11.SubString(lower11, start11, count11) == "im "))
																				{
																					Other other12 = this.Other;
																					string[] strArray18 = (string[])this.var__main_xitemtext;
																					int index18 = s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul);
																					string str19;
																					string lower12 = ((str19 = strArray18[index18]) == null ? "" : str19).ToLower(b4p.cul);
																					int start12 = 0;
																					int count12 = 4;
																					if (!(other12.SubString(lower12, start12, count12) == "its "))
																					{
																						Other other13 = this.Other;
																						string[] strArray19 = (string[])this.var__main_xitemtext;
																						int index19 = s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul);
																						string str20;
																						string lower13 = ((str20 = strArray19[index19]) == null ? "" : str20).ToLower(b4p.cul);
																						int start13 = 0;
																						int count13 = 5;
																						if (!(other13.SubString(lower13, start13, count13) == "it's "))
																						{
																							Other other14 = this.Other;
																							string[] strArray20 = (string[])this.var__main_xitemtext;
																							int index20 = s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul);
																							string str21;
																							string lower14 = ((str21 = strArray20[index20]) == null ? "" : str21).ToLower(b4p.cul);
																							int start14 = 0;
																							int count14 = 5;
																							if (!(other14.SubString(lower14, start14, count14) == "it`s "))
																								continue;
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
							s1 = ((s1 == "" ? 0.0 : double.Parse(s1, (IFormatProvider)b4p.cul)) - 1.0).ToString((IFormatProvider)b4p.cul);
						}
					}
				}
				return s1;
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_countcarried");
				return "";
			}
		}

		private string __main_readmystr()
		{
			string str = "";
			try
			{
				str = "";
				Application.DoEvents();
				this.var__main_myfiledatapos = ((this.var__main_myfiledatapos == "" ? 0.0 : double.Parse(this.var__main_myfiledatapos, (IFormatProvider)b4p.cul)) + 1.0).ToString((IFormatProvider)b4p.cul);
				if (string.Compare(this.Other.SubString(this.var__main_myfiledata, (int)((this.var__main_myfiledatapos == "" ? 0.0 : double.Parse(this.var__main_myfiledatapos, (IFormatProvider)b4p.cul)) - 1.0), 1), '"'.ToString((IFormatProvider)b4p.cul), true, b4p.cul).ToString((IFormatProvider)b4p.cul) != "0")
					this.__main_loaderror("Read String: Expected quotes. Found chr[" + ((int)this.Other.SubString(this.var__main_myfiledata, (int)((this.var__main_myfiledatapos == "" ? 0.0 : double.Parse(this.var__main_myfiledatapos, (IFormatProvider)b4p.cul)) - 1.0), 1)[0]).ToString((IFormatProvider)b4p.cul) + "] at pos: " + this.var__main_myfiledatapos + " {" + ((int)this.Other.SubString(this.var__main_myfiledata, this.var__main_myfiledatapos == "" ? 0 : (int)double.Parse(this.var__main_myfiledatapos, (IFormatProvider)b4p.cul), 1)[0]).ToString((IFormatProvider)b4p.cul) + "}");
				string @string = ((double)this.var__main_myfiledata.IndexOf('"'.ToString((IFormatProvider)b4p.cul), this.var__main_myfiledatapos == "" ? 0 : (int)double.Parse(this.var__main_myfiledatapos, (IFormatProvider)b4p.cul)) - (this.var__main_myfiledatapos == "" ? 0.0 : double.Parse(this.var__main_myfiledatapos, (IFormatProvider)b4p.cul))).ToString((IFormatProvider)b4p.cul);
				string var__main_cfsstr = this.Other.SubString(this.var__main_myfiledata, this.var__main_myfiledatapos == "" ? 0 : (int)double.Parse(this.var__main_myfiledatapos, (IFormatProvider)b4p.cul), @string == "" ? 0 : (int)double.Parse(@string, (IFormatProvider)b4p.cul));
				this.var__main_myfiledatapos = ((this.var__main_myfiledatapos == "" ? 0.0 : double.Parse(this.var__main_myfiledatapos, (IFormatProvider)b4p.cul)) + (@string == "" ? 0.0 : double.Parse(@string, (IFormatProvider)b4p.cul))).ToString((IFormatProvider)b4p.cul);
				this.var__main_myfiledatapos = ((this.var__main_myfiledatapos == "" ? 0.0 : double.Parse(this.var__main_myfiledatapos, (IFormatProvider)b4p.cul)) + 2.0).ToString((IFormatProvider)b4p.cul);
				return this.__main_checkforspelling(var__main_cfsstr);
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_readmystr");
				return "";
			}
		}

		private string __main_score()
		{
			try
			{
				string s1 = "0";
				string s2 = "0";
				double num1 = this.var__main_numitems == "" ? 0.0 : double.Parse(this.var__main_numitems, (IFormatProvider)b4p.cul);
				for (double num2 = double.Parse(s2, (IFormatProvider)b4p.cul); num2 <= num1; s2 = (++num2).ToString((IFormatProvider)b4p.cul))
				{
					string[] strArray1 = (string[])this.var__main_xitemloc;
					int index1 = s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul);
					string str1;
					if (this.CompareEqual((str1 = strArray1[index1]) == null ? "" : str1, this.var__main_treasureroom))
					{
						string[] strArray2 = (string[])this.var__main_xitemtext;
						int index2 = s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul);
						string str2;
						if (this.__main_xleft((str2 = strArray2[index2]) == null ? "" : str2, "1") == "*")
							s1 = ((s1 == "" ? 0.0 : double.Parse(s1, (IFormatProvider)b4p.cul)) + 1.0).ToString((IFormatProvider)b4p.cul);
					}
				}
				this.__main_addtxtmsg("I've stored " + s1 + " treasures.<br>");
				this.__main_addtxtmsg("On a scale of 0 to 100, that's " + Math.Floor((s1 == "" ? 0.0 : double.Parse(s1, (IFormatProvider)b4p.cul)) * 100.0 / (this.var__main_treasures == "" ? 0.0 : double.Parse(this.var__main_treasures, (IFormatProvider)b4p.cul))).ToString((IFormatProvider)b4p.cul) + ".<br>");
				if ((s1 == "" ? 0.0 : double.Parse(s1, (IFormatProvider)b4p.cul)) >= (this.var__main_treasures == "" ? 0.0 : double.Parse(this.var__main_treasures, (IFormatProvider)b4p.cul)))
				{
					this.__main_addtxtmsg("<br>YOU WON!");
					this.__main_refreshweb();
					((int)MessageBox.Show("Congratulations, you won!", "Well done!", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider)b4p.cul);
					this.__main_quit();
				}
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_score");
				return "";
			}
		}

		private string __main_checkforspelling(string var__main_cfsstr)
		{
			try
			{
				if ((double)var__main_cfsstr.Length < 3.0)
					return var__main_cfsstr;
				var__main_cfsstr = var__main_cfsstr.Replace("  ", " ");
				var__main_cfsstr = var__main_cfsstr.Replace(". " + '\n'.ToString((IFormatProvider)b4p.cul), "." + 'È'.ToString((IFormatProvider)b4p.cul));
				var__main_cfsstr = var__main_cfsstr.Replace("." + '\n'.ToString((IFormatProvider)b4p.cul), "." + 'È'.ToString((IFormatProvider)b4p.cul));
				var__main_cfsstr = var__main_cfsstr.Replace('\n'.ToString((IFormatProvider)b4p.cul), 'É'.ToString((IFormatProvider)b4p.cul));
				var__main_cfsstr = var__main_cfsstr.Replace('È'.ToString((IFormatProvider)b4p.cul), "{BR}");
				var__main_cfsstr = var__main_cfsstr.Replace(" " + 'É'.ToString((IFormatProvider)b4p.cul), 'É'.ToString((IFormatProvider)b4p.cul));
				var__main_cfsstr = var__main_cfsstr.Replace('É'.ToString((IFormatProvider)b4p.cul) + " ", 'É'.ToString((IFormatProvider)b4p.cul));
				var__main_cfsstr = var__main_cfsstr.Replace("." + 'É'.ToString((IFormatProvider)b4p.cul), ".{BR}");
				var__main_cfsstr = var__main_cfsstr.Replace("!" + 'É'.ToString((IFormatProvider)b4p.cul), "!{BR}");
				var__main_cfsstr = var__main_cfsstr.Replace("?" + 'É'.ToString((IFormatProvider)b4p.cul), "?{BR}");
				var__main_cfsstr = var__main_cfsstr.Replace('É'.ToString((IFormatProvider)b4p.cul), " ");
				var__main_cfsstr = var__main_cfsstr.Replace('`'.ToString((IFormatProvider)b4p.cul), "'");
				return var__main_cfsstr;
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_checkforspelling");
				return "";
			}
		}

		private string __main_menuoptions_click()
		{
			try
			{
				this.__main_readoptionsfromfile();
				this.__main_pdfontsize.SelectedIndex = (int)((this.var__main_optionsfontsize == "" ? 0.0 : double.Parse(this.var__main_optionsfontsize, (IFormatProvider)b4p.cul)) - 1.0);
				string s = "0";
				double num1 = (double)this.__main_pdtheme.Items.Count - 1.0;
				for (double num2 = double.Parse(s, (IFormatProvider)b4p.cul); num2 <= num1; s = (++num2).ToString((IFormatProvider)b4p.cul))
				{
					if (this.LCompareEqual(this.var__main_optionstheme, this.__main_pdtheme.Items[s == "" ? 0 : (int)double.Parse(s, (IFormatProvider)b4p.cul)].ToString()))
						this.__main_pdtheme.SelectedIndex = s == "" ? 0 : (int)double.Parse(s, (IFormatProvider)b4p.cul);
				}
				this.__main_foptions.show();
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_menuoptions_click");
				return "";
			}
		}

		private string __main_killplayer()
		{
			try
			{
				this.__main_addtxtmsg("I am DEAD!<br>");
				this.__main_clearflag(this.var__main_darkbit);
				this.var__main_playerroom = this.var__main_numrooms;
				this.__main_look();
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_killplayer");
				return "";
			}
		}

		private string __main_pdselect_selectionchanged(string var__main_selindex, string var__main_selvalue)
		{
			int num = 0;
			try
			{
				if (this.err__main_pdselect_selectionchanged > 0 && this.err__main_pdselect_selectionchanged == 1)
				{
					this.err__main_pdselect_selectionchanged = 0;
					this.__main_butplay.Enabled = bool.Parse("false".ToLower(b4p.cul));
					((int)MessageBox.Show("Could not locate this adventure's image. Please reinstall.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider)b4p.cul);
					if (this.mainForm != null)
						this.mainForm.Close();
					else
						this.CloseProgram();
					return "";
				}
				this.__main_butplay.Enabled = bool.Parse("true".ToLower(b4p.cul));
				this.var__main_myadventure = "adv";
				if ((var__main_selindex == "" ? 0.0 : double.Parse(var__main_selindex, (IFormatProvider)b4p.cul)) + 1.0 < 10.0)
					this.var__main_myadventure = this.var__main_myadventure + "0";
				this.var__main_myadventure = this.var__main_myadventure + ((var__main_selindex == "" ? 0.0 : double.Parse(var__main_selindex, (IFormatProvider)b4p.cul)) + 1.0).ToString((IFormatProvider)b4p.cul);
				num = 1;
				this.__main_imgpic.MyBitmap = this.Other.GetBitmapFromString((object)(this.b4pdir + "\\images\\scotts_games\\" + this.var__main_myadventure + ".gif"));
				this.var__main_myadventure = this.b4pdir + "\\data_scottadams\\" + this.var__main_myadventure + ".dat";
				if (this.LCompareEqual(var__main_selindex, "0"))
					this.__main_advdesc.Text = "Wander through enchanted lands trying to recover the 13 lost treasures. You'll encounter wild animals, magical beings, and other perils and puzzles. Can you rescue the Blue Ox from the quicksand or find your way out of the maze of pits? Happy Adventuring!";
				if (this.LCompareEqual(var__main_selindex, "1"))
					this.__main_advdesc.Text = "'Yo ho ho and a bottle of rum...' You'll meet up with the pirate and his daffy bird along with many strange sights as you attempt to go from your London flat to Treasure Island. Can you recover Long John Silver's lost treasures? Happy sailing, matey...";
				if (this.LCompareEqual(var__main_selindex, "2"))
					this.__main_advdesc.Text = "Time is of the essence as you race the clock to complete your mission - if you fail, the world's first automated nuclear reactor is doomed. So, tread lightly and don't forget your bomb detector! If you survive this challenging mission, consider yourself a true Adventurer.";
				if (this.LCompareEqual(var__main_selindex, "3"))
					this.__main_advdesc.Text = "Count Cristo has had a fiendish curse put on him by his enemies. There he lies, with you his only hope. Will you be able to rescue him or is he forever doomed? Beware the Voodoo man...";
				if (this.LCompareEqual(var__main_selindex, "4"))
					this.__main_advdesc.Text = "You wake up in a large brass bed in a castle somewhere in Transylvania. Who are you, what are you doing here, and why did the postman deliver a bottle of blood? You'll love this adventure, in fact, you might say it's Love at First Byte...";
				if (this.LCompareEqual(var__main_selindex, "5"))
					this.__main_advdesc.Text = "Marooned at the edge of the galaxy, you've stumbled on the ruins of an ancient alien civilization complete with fabulous treasures and unearthly technologies. Can you collect the treasures and return or will you end up marooned forever?";
				if (this.LCompareEqual(var__main_selindex, "6"))
					this.__main_advdesc.Text = "Can you find your way completely through the strangest Fun House in existence, or will you be kicked out when the park closes?";
				if (this.LCompareEqual(var__main_selindex, "7"))
					this.__main_advdesc.Text = "An Egyptian Treasure Hunt leads you into the dark recesses of a recently uncovered Pyramid. Will you recover all the treasures or more likely will you join its denizens for that long eternal sleep?";
				if (this.LCompareEqual(var__main_selindex, "8"))
					this.__main_advdesc.Text = "Explore a deserted western mining town in search of 13 treasures. From rattlesnakes to runaway horses, this Adventure's got them all! Just remember, Pardner, they don't call them Ghost Towns for nothing.";
				if (this.LCompareEqual(var__main_selindex, "9"))
					this.__main_advdesc.Text = "WARNING: for experienced adventurers only!\r\n\r\nA small island in a remote ocean holds an awesome secret. Will you be the first to uncover it?";
				if (this.LCompareEqual(var__main_selindex, "10"))
					this.__main_advdesc.Text = "After struggling through Part 1, you have the consolation of knowing its half over. This concludes this two part Adventure. You must have the password from Savage Island Part One to play this adventure!";
				if (this.LCompareEqual(var__main_selindex, "11"))
					this.__main_advdesc.Text = "The King lies near death in the royal palace - you have only three days to bring back the elixir needed to rejuvenate him. Journey through the lands of magic fountains, sacred temples, stormy seas, and gold, gold, gold! Can you find the elixir in time?";
				if (this.LCompareEqual(var__main_selindex, "12"))
					this.__main_advdesc.Text = "Tread carefully, O Beanwick! Would that I could assume this quest myself, but alas, I can only send with you these few spells. Claymorgue Castle harbours further spells, but beware: one unskilled in the arts cannot predict their outcome.";
				if (this.LCompareEqual(var__main_selindex, "13"))
					this.__main_advdesc.Text = "This game is as tricky and devious as the mind of Scott Adams gets. A treasure hunt in the same vein as its predecessor, it incorporates some of the more interesting effects Scott achieved using his system. Knowledge of 'Pirate Adventure' is essential.";
				if (this.LCompareEqual(var__main_selindex, "14"))
					this.__main_advdesc.Text = "Buckaroo Banzai, a neurosurgeon, rock star and more, must try to fix a jet car that can drive him into the 8th dimension.";
				this.var__main_optionsmyadv = var__main_selindex;
				return "";
			}
			catch (Exception ex)
			{
				if (num > 0)
				{
					this.lastError = ex;
					this.err__main_pdselect_selectionchanged = num;
					this.localVars = new string[0];
					return this.__main_pdselect_selectionchanged(var__main_selindex, var__main_selvalue);
				}
				this.ShowError(ex, "__main_pdselect_selectionchanged");
				return "";
			}
		}

		private string __main_butt_click()
		{
			try
			{
				if (this.LCompareEqual(this.var__main_abcison, "Y"))
					this.__main_insertchar("T");
				else
					this.__main_insertchar("5");
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_butt_click");
				return "";
			}
		}

		private string __main_addtxtlook(string var__main_atlook)
		{
			try
			{
				this.var__main_txtlook = !this.LCompareEqual(var__main_atlook, "") ? this.var__main_txtlook + var__main_atlook : "";
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_addtxtlook");
				return "";
			}
		}

		private string __main_clearflag(string var__main_myflag)
		{
			try
			{
				((string[])this.var__main_xbitflags)[var__main_myflag == "" ? 0 : (int)double.Parse(var__main_myflag, (IFormatProvider)b4p.cul)] = "0";
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_clearflag");
				return "";
			}
		}

		private string __main_removebrfromtxtmsg()
		{
			try
			{
				if ((double)this.var__main_txtmsg.Length > 3.0)
					this.var__main_txtmsg = this.Other.SubString(this.var__main_txtmsg, 0, (int)((double)this.var__main_txtmsg.Length - 4.0));
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_removebrfromtxtmsg");
				return "";
			}
		}

		private string __main_itemavailable(string var__main_myitem)
		{
			try
			{
				return this.__main_itemhere(var__main_myitem) == "true" || this.__main_itemcarried(var__main_myitem) == "true" ? "true" : "false";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_itemavailable");
				return "";
			}
		}

		private string __main_redraw()
		{
			try
			{
				if (this.LCompareEqual(this.var__main_llclear, "true") || !this.LCompareEqual(this.var__main_lldark, this.__main_isdark()))
					return "true";
				if (this.__main_isdark() == "true")
					return "false";
				if (!this.CompareEqual(this.var__main_llplayerroom, this.var__main_playerroom))
					return "true";
				string s = "0";
				double num1 = this.var__main_numitems == "" ? 0.0 : double.Parse(this.var__main_numitems, (IFormatProvider)b4p.cul);
				for (double num2 = double.Parse(s, (IFormatProvider)b4p.cul); num2 <= num1; s = (++num2).ToString((IFormatProvider)b4p.cul))
				{
					string[] strArray1 = (string[])this.var__main_llitemloc;
					int index1 = s == "" ? 0 : (int)double.Parse(s, (IFormatProvider)b4p.cul);
					string str1;
					string lSide = !this.CompareEqual((str1 = strArray1[index1]) == null ? "" : str1, this.var__main_playerroom) ? "false" : "true";
					string[] strArray2 = (string[])this.var__main_xitemloc;
					int index2 = s == "" ? 0 : (int)double.Parse(s, (IFormatProvider)b4p.cul);
					string str2;
					string rSide = !this.CompareEqual((str2 = strArray2[index2]) == null ? "" : str2, this.var__main_playerroom) ? "false" : "true";
					if (!this.CompareEqual(lSide, rSide))
						return "true";
				}
				return "false";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_redraw");
				return "";
			}
		}

		private string __main_butelc_click()
		{
			try
			{
				if (this.LCompareEqual(this.var__main_sleeping, "Y"))
					return "";
				this.var__main_myel = ((this.var__main_myel == "" ? 0.0 : double.Parse(this.var__main_myel, (IFormatProvider)b4p.cul)) + 1.0).ToString((IFormatProvider)b4p.cul);
				if (this.LCompareEqual(this.var__main_myel, "5"))
					this.var__main_myel = "1";
				bool flag = false;
				string str = this.var__main_myel;
				while (true)
				{
					if (str == "1")
					{
						this.__main_mycmd.Text = "GO ";
						flag = true;
					}
					else if (str == "2")
					{
						this.__main_mycmd.Text = "CLIMB ";
						flag = true;
					}
					else if (str == "3")
					{
						this.__main_mycmd.Text = "SWIM ";
						flag = true;
					}
					else if (str == "4")
					{
						this.__main_mycmd.Text = "ENTER ";
						flag = true;
					}
					if (!flag && str == "")
						str = "0";
					else
						break;
				}
				this.__main_mycmd.Focus();
				this.__main_mycmd.SelectionStart = (int)(double)this.__main_mycmd.Text.Length;
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_butelc_click");
				return "";
			}
		}

		private string __main_trim(string var__main_ttxt)
		{
			try
			{
				if ((double)var__main_ttxt.Length < 2.0)
					return var__main_ttxt;
				for (string str = this.Other.SubString(var__main_ttxt, 0, 1); (double)str[0] < 33.0; str = this.Other.SubString(var__main_ttxt, 0, 1))
					var__main_ttxt = this.Other.SubString(var__main_ttxt, 1, (int)((double)var__main_ttxt.Length - 1.0));
				for (string str = this.Other.SubString(var__main_ttxt, (int)((double)var__main_ttxt.Length - 1.0), 1); (double)str[0] < 33.0; str = this.Other.SubString(var__main_ttxt, (int)((double)var__main_ttxt.Length - 1.0), 1))
					var__main_ttxt = this.Other.SubString(var__main_ttxt, 0, (int)((double)var__main_ttxt.Length - 1.0));
				return var__main_ttxt;
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_trim");
				return "";
			}
		}

		private string __main_inventory()
		{
			try
			{
				string lSide = "";
				if ((double)this.var__main_txtmsg.IndexOf("I am now carrying nothing.<br>", 0) > -1.0 || (double)this.var__main_txtmsg.IndexOf("I am now carrying: ", 0) > -1.0)
				{
					Application.DoEvents();
				}
				else
				{
					string s = "0";
					double num1 = this.var__main_numitems == "" ? 0.0 : double.Parse(this.var__main_numitems, (IFormatProvider)b4p.cul);
					for (double num2 = double.Parse(s, (IFormatProvider)b4p.cul); num2 <= num1; s = (++num2).ToString((IFormatProvider)b4p.cul))
					{
						string[] strArray1 = (string[])this.var__main_xitemloc;
						int index1 = s == "" ? 0 : (int)double.Parse(s, (IFormatProvider)b4p.cul);
						string str1;
						if (this.CompareEqual((str1 = strArray1[index1]) == null ? "" : str1, this.var__main_carried))
						{
							string[] strArray2 = (string[])this.var__main_xitemautoget;
							int index2 = s == "" ? 0 : (int)double.Parse(s, (IFormatProvider)b4p.cul);
							string str2;
							if ((double)((str2 = strArray2[index2]) == null ? "" : str2).Length > 0.0)
							{
								if (this.LCompareEqual(this.var__main_optionslinkson, "Y") && !this.LCompareEqual(this.var__main_sleeping, "Y"))
								{
									string[] strArray3 = new string[12]
						{
						  lSide,
						  "<a ",
						  this.var__main_aname,
						  "='",
						  this.var__main_hyper,
						  "X",
						  s,
						  "c'><font color='",
						  this.var__main_html_mesg_hyperlink,
						  "'>",
						  null,
						  null
						};
									string[] strArray4 = strArray3;
									int index3 = 10;
									string[] strArray5 = (string[])this.var__main_xitemtext;
									int index4 = s == "" ? 0 : (int)double.Parse(s, (IFormatProvider)b4p.cul);
									string str3;
									string str4 = this.__main_hx(this.__main_treasurecheck((str3 = strArray5[index4]) == null ? "" : str3));
									strArray4[index3] = str4;
									strArray3[11] = "</font></a>. ";
									lSide = string.Concat(strArray3);
								}
								else
								{
									string[] strArray3 = new string[6]
						{
						  lSide,
						  "<font color='",
						  this.var__main_html_look_text,
						  "'>",
						  null,
						  null
						};
									string[] strArray4 = strArray3;
									int index3 = 4;
									string[] strArray5 = (string[])this.var__main_xitemtext;
									int index4 = s == "" ? 0 : (int)double.Parse(s, (IFormatProvider)b4p.cul);
									string str3;
									string str4 = this.__main_hx(this.__main_treasurecheck((str3 = strArray5[index4]) == null ? "" : str3));
									strArray4[index3] = str4;
									strArray3[5] = ". </font>";
									lSide = string.Concat(strArray3);
								}
							}
							else
							{
								string str3 = lSide;
								string[] strArray3 = (string[])this.var__main_xitemtext;
								int index3 = s == "" ? 0 : (int)double.Parse(s, (IFormatProvider)b4p.cul);
								string str4;
								string str5 = this.__main_treasurecheck((str4 = strArray3[index3]) == null ? "" : str4);
								string str6 = ". ";
								lSide = str3 + str5 + str6;
							}
						}
					}
					if (this.LCompareEqual(lSide, ""))
					{
						if (this.LCompareEqual(this.var__main_quickdropchk, "N"))
							this.__main_addtxtmsg("I am carrying: Nothing!<br>");
						if (this.LCompareEqual(this.var__main_quickdropchk, "Y") && !this.LCompareEqual(this.var__main_imcarrying, this.__main_countcarrying()))
							this.__main_addtxtmsg("I am now carrying nothing.<br>");
					}
					else
					{
						if (this.LCompareEqual(this.var__main_quickdropchk, "N"))
							this.__main_addtxtmsg("I am carrying: " + lSide + "<br>");
						if (this.LCompareEqual(this.var__main_quickdropchk, "Y") && !this.LCompareEqual(this.var__main_imcarrying, this.__main_countcarrying()))
							this.__main_addtxtmsg("I am now carrying: " + lSide + "<br>");
					}
				}
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_inventory");
				return "";
			}
		}

		private string __main_butm_click()
		{
			try
			{
				this.__main_insertchar("M");
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_butm_click");
				return "";
			}
		}

		private string __main_randompercent(string var__main_rndpc)
		{
			try
			{
				string @string = Math.Floor((double)this.rnd.Next(1, 101)).ToString((IFormatProvider)b4p.cul);
				return (@string == "" ? 0.0 : double.Parse(@string, (IFormatProvider)b4p.cul)) <= (var__main_rndpc == "" ? 0.0 : double.Parse(var__main_rndpc, (IFormatProvider)b4p.cul)) ? "true" : "false";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_randompercent");
				return "";
			}
		}

		private string __main_resetvars()
		{
			try
			{
				this.__main_addtxtmsg("");
				this.__main_addtxtlook("");
				this.__main_addtxtexits("");
				this.var__main_carryingtoomuch = "false";
				this.var__main_xactionvocab = (object)new string[(int)((this.var__main_numactions == "" ? 0.0 : double.Parse(this.var__main_numactions, (IFormatProvider)b4p.cul)) + 1.0)];
				this.var__main_xactionverb = (object)new string[(int)((this.var__main_numactions == "" ? 0.0 : double.Parse(this.var__main_numactions, (IFormatProvider)b4p.cul)) + 1.0)];
				this.var__main_xactionnoun = (object)new string[(int)((this.var__main_numactions == "" ? 0.0 : double.Parse(this.var__main_numactions, (IFormatProvider)b4p.cul)) + 1.0)];
				this.var__main_xactioncondition = (object)new string[(int)((this.var__main_numactions == "" ? 0.0 : double.Parse(this.var__main_numactions, (IFormatProvider)b4p.cul)) + 1.0), 5];
				this.var__main_xactionaction = (object)new string[(int)((this.var__main_numactions == "" ? 0.0 : double.Parse(this.var__main_numactions, (IFormatProvider)b4p.cul)) + 1.0), 2];
				this.var__main_xroomtext = (object)new string[(int)((this.var__main_numrooms == "" ? 0.0 : double.Parse(this.var__main_numrooms, (IFormatProvider)b4p.cul)) + 1.0)];
				this.var__main_xroomexit = (object)new string[(int)((this.var__main_numrooms == "" ? 0.0 : double.Parse(this.var__main_numrooms, (IFormatProvider)b4p.cul)) + 1.0), 6];
				this.var__main_xitemtext = (object)new string[(int)((this.var__main_numitems == "" ? 0.0 : double.Parse(this.var__main_numitems, (IFormatProvider)b4p.cul)) + 1.0)];
				this.var__main_xitemloc = (object)new string[(int)((this.var__main_numitems == "" ? 0.0 : double.Parse(this.var__main_numitems, (IFormatProvider)b4p.cul)) + 1.0)];
				this.var__main_llitemloc = (object)new string[(int)((this.var__main_numitems == "" ? 0.0 : double.Parse(this.var__main_numitems, (IFormatProvider)b4p.cul)) + 1.0)];
				this.var__main_xiteminitloc = (object)new string[(int)((this.var__main_numitems == "" ? 0.0 : double.Parse(this.var__main_numitems, (IFormatProvider)b4p.cul)) + 1.0)];
				this.var__main_xitemautoget = (object)new string[(int)((this.var__main_numitems == "" ? 0.0 : double.Parse(this.var__main_numitems, (IFormatProvider)b4p.cul)) + 1.0)];
				this.var__main_xnouns = (object)new string[(int)((this.var__main_numwords == "" ? 0.0 : double.Parse(this.var__main_numwords, (IFormatProvider)b4p.cul)) + 1.0)];
				this.var__main_xverbs = (object)new string[(int)((this.var__main_numwords == "" ? 0.0 : double.Parse(this.var__main_numwords, (IFormatProvider)b4p.cul)) + 1.0)];
				this.var__main_xmessages = (object)new string[(int)((this.var__main_nummessages == "" ? 0.0 : double.Parse(this.var__main_nummessages, (IFormatProvider)b4p.cul)) + 1.0)];
				this.var__main_x = "0";
				double num1 = this.var__main_numactions == "" ? 0.0 : double.Parse(this.var__main_numactions, (IFormatProvider)b4p.cul);
				for (double num2 = double.Parse(this.var__main_x, (IFormatProvider)b4p.cul); num2 <= num1; this.var__main_x = (num2 = double.Parse(this.var__main_x, (IFormatProvider)b4p.cul) + 1.0).ToString((IFormatProvider)b4p.cul))
				{
					((string[])this.var__main_xactionvocab)[this.var__main_x == "" ? 0 : (int)double.Parse(this.var__main_x, (IFormatProvider)b4p.cul)] = "0";
					((string[,])this.var__main_xactioncondition)[this.var__main_x == "" ? 0 : (int)double.Parse(this.var__main_x, (IFormatProvider)b4p.cul), 0] = "0";
					((string[,])this.var__main_xactioncondition)[this.var__main_x == "" ? 0 : (int)double.Parse(this.var__main_x, (IFormatProvider)b4p.cul), 1] = "0";
					((string[,])this.var__main_xactioncondition)[this.var__main_x == "" ? 0 : (int)double.Parse(this.var__main_x, (IFormatProvider)b4p.cul), 2] = "0";
					((string[,])this.var__main_xactioncondition)[this.var__main_x == "" ? 0 : (int)double.Parse(this.var__main_x, (IFormatProvider)b4p.cul), 3] = "0";
					((string[,])this.var__main_xactioncondition)[this.var__main_x == "" ? 0 : (int)double.Parse(this.var__main_x, (IFormatProvider)b4p.cul), 4] = "0";
					((string[,])this.var__main_xactionaction)[this.var__main_x == "" ? 0 : (int)double.Parse(this.var__main_x, (IFormatProvider)b4p.cul), 0] = "0";
					((string[,])this.var__main_xactionaction)[this.var__main_x == "" ? 0 : (int)double.Parse(this.var__main_x, (IFormatProvider)b4p.cul), 1] = "0";
				}
				this.var__main_l = "0";
				double num3 = (double)byte.MaxValue;
				for (double num2 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul); num2 <= num3; this.var__main_l = (num2 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul) + 1.0).ToString((IFormatProvider)b4p.cul))
					((string[])this.var__main_roomsaved)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul)] = "0";
				this.var__main_l = "0";
				double num4 = this.var__main_numwords == "" ? 0.0 : double.Parse(this.var__main_numwords, (IFormatProvider)b4p.cul);
				for (double num2 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul); num2 <= num4; this.var__main_l = (num2 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul) + 1.0).ToString((IFormatProvider)b4p.cul))
				{
					((string[])this.var__main_xverbs)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul)] = "";
					((string[])this.var__main_xnouns)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul)] = "";
				}
				this.var__main_l = "0";
				double num5 = this.var__main_numrooms == "" ? 0.0 : double.Parse(this.var__main_numrooms, (IFormatProvider)b4p.cul);
				for (double num2 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul); num2 <= num5; this.var__main_l = (num2 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul) + 1.0).ToString((IFormatProvider)b4p.cul))
				{
					this.var__main_x = "0";
					double num6 = 5.0;
					for (double num7 = double.Parse(this.var__main_x, (IFormatProvider)b4p.cul); num7 <= num6; this.var__main_x = (num7 = double.Parse(this.var__main_x, (IFormatProvider)b4p.cul) + 1.0).ToString((IFormatProvider)b4p.cul))
						((string[,])this.var__main_xroomexit)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul), this.var__main_x == "" ? 0 : (int)double.Parse(this.var__main_x, (IFormatProvider)b4p.cul)] = "0";
					((string[])this.var__main_xroomtext)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul)] = "";
				}
				this.var__main_l = "0";
				double num8 = this.var__main_nummessages == "" ? 0.0 : double.Parse(this.var__main_nummessages, (IFormatProvider)b4p.cul);
				for (double num2 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul); num2 <= num8; this.var__main_l = (num2 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul) + 1.0).ToString((IFormatProvider)b4p.cul))
					((string[])this.var__main_xmessages)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul)] = "";
				this.var__main_l = "0";
				double num9 = this.var__main_numitems == "" ? 0.0 : double.Parse(this.var__main_numitems, (IFormatProvider)b4p.cul);
				for (double num2 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul); num2 <= num9; this.var__main_l = (num2 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul) + 1.0).ToString((IFormatProvider)b4p.cul))
				{
					((string[])this.var__main_xitemtext)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul)] = "";
					((string[])this.var__main_xitemloc)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul)] = "0";
					((string[])this.var__main_xiteminitloc)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul)] = "0";
					((string[])this.var__main_xitemautoget)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul)] = "";
				}
				this.__main_clearscreen();
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_resetvars");
				return "";
			}
		}

		private string __main_butu_click()
		{
			try
			{
				if (this.__main_mycmd.Text.ToUpper(b4p.cul) == "U")
				{
					if (this.LCompareEqual(this.var__main_sleeping, "Y") && this.__main_mycmd.Text.ToUpper(b4p.cul) == "U")
						return "";
					this.__main_mycmd_keypress('\r'.ToString((IFormatProvider)b4p.cul));
				}
				else if (this.LCompareEqual(this.var__main_abcison, "Y"))
					this.__main_insertchar("U");
				else
					this.__main_insertchar("7");
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_butu_click");
				return "";
			}
		}

		private string __main_dropcommand(string var__main_notyet)
		{
			try
			{
				this.var__main_startcarried = (object)new string[this.var__main_numitems == "" ? 0 : (int)double.Parse(this.var__main_numitems, (IFormatProvider)b4p.cul)];

				// if (this.LCompareEqual(this.var__main_nnum, -1.0.ToString((IFormatProvider)b4p.cul)))
				if (this.var__main_nnum == "-1.0")
				{
					if (this.LCompareEqual(this.var__main_word1, "DROP"))
						this.__main_addtxtmsg("Drop what exactly?<br>");
					else
						this.__main_addtxtmsg("I'm not sure what you mean.");
					return "true";
				}

				// if (this.LCompareEqual(this.var__main_nnum, -2.0.ToString((IFormatProvider)b4p.cul)))
				if (this.var__main_nnum == "-2.0")
				{
					string lSide1 = this.__main_isdark();
					string rSide = this.var__main_playerroom;
					string str1 = "0";
					double num1 = this.var__main_numitems == "" ? 0.0 : double.Parse(this.var__main_numitems, (IFormatProvider)b4p.cul);
					for (double num2 = double.Parse(str1, (IFormatProvider)b4p.cul); num2 <= num1; str1 = (++num2).ToString((IFormatProvider)b4p.cul))
					{
						if (this.__main_itemcarried(str1) == "true")
						{
							string[] strArray1 = (string[])this.var__main_xitemautoget;
							int index1 = str1 == "" ? 0 : (int)double.Parse(str1, (IFormatProvider)b4p.cul);
							string str2;
							if ((double)((str2 = strArray1[index1]) == null ? "" : str2).Length > 0.0)
							{
								string[] strArray2 = (string[])this.var__main_xitemloc;
								int index2 = str1 == "" ? 0 : (int)double.Parse(str1, (IFormatProvider)b4p.cul);
								string str3;

								// if (this.LCompareEqual((str3 = strArray2[index2]) == null ? "" : str3, -1.0.ToString((IFormatProvider)b4p.cul)))
								if (this.LCompareEqual((str3 = strArray2[index2]) == null ? "" : str3, "-1.0"))
								{
									string[] strArray3 = (string[])this.var__main_xitemtext;
									int index3 = str1 == "" ? 0 : (int)double.Parse(str1, (IFormatProvider)b4p.cul);
									string str4;
									this.__main_addtxtmsg(this.__main_hx((str4 = strArray3[index3]) == null ? "" : str4) + ": ");
									this.var__main_linkdrop = str1;
									this.var__main_dropping = "Y";
									string[] strArray4 = (string[])this.var__main_xitemautoget;
									int index4 = str1 == "" ? 0 : (int)double.Parse(str1, (IFormatProvider)b4p.cul);
									string str5;
									this.var__main_nnum = this.__main_whichword((str5 = strArray4[index4]) == null ? "" : str5, "Nouns");
									string[] strArray5 = (string[])this.var__main_xitemautoget;
									int index5 = str1 == "" ? 0 : (int)double.Parse(str1, (IFormatProvider)b4p.cul);
									string str6;
									this.var__main_getnoun = (str6 = strArray5[index5]) == null ? "" : str6;
									this.var__main_dropping = "N";
									this.__main_performcommand();
									this.var__main_linkdrop = "0";
									if (!this.CompareEqual(this.var__main_playerroom, rSide) || !this.LCompareEqual(lSide1, this.__main_isdark()))
									{
										break;
									}
								}
							}
						}
					}
					string lSide2 = "0";
					string s = "0";
					double num3 = this.var__main_numitems == "" ? 0.0 : double.Parse(this.var__main_numitems, (IFormatProvider)b4p.cul);
					for (double num2 = double.Parse(s, (IFormatProvider)b4p.cul); num2 <= num3; s = (++num2).ToString((IFormatProvider)b4p.cul))
					{
						string[] strArray = (string[])this.var__main_xitemloc;
						int index = s == "" ? 0 : (int)double.Parse(s, (IFormatProvider)b4p.cul);
						string str2;
						if (this.CompareEqual((str2 = strArray[index]) == null ? "" : str2, this.var__main_carried))
							lSide2 = "1";
					}
					if (this.LCompareEqual(lSide2, "0"))
						this.__main_addtxtmsg("I'm not carrying anything!<br>");
					else
						this.__main_addtxtmsg("I still appear to be carrying something - try dropping individually for these items.<br>");
					return "true";
				}
				this.var__main_linkdrop = "0";
				string str = this.__main_whichitem(this.var__main_nnum, this.var__main_carried);
				if (var__main_notyet.ToLower(b4p.cul) == "true" && (str == "" ? 0.0 : double.Parse(str, (IFormatProvider)b4p.cul)) < 0.0)
					return "false";
				this.__main_dropitem(str);
				return "true";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_dropcommand");
				return "";
			}
		}

		private string __main_readitemtext()
		{
			try
			{
				Application.DoEvents();
				if (string.Compare(this.Other.SubString(this.var__main_myfiledata, this.var__main_myfiledatapos == "" ? 0 : (int)double.Parse(this.var__main_myfiledatapos, (IFormatProvider)b4p.cul), 1), '"'.ToString((IFormatProvider)b4p.cul), true, b4p.cul).ToString((IFormatProvider)b4p.cul) != "0")
					this.__main_loaderror("Read Item Text: Expected quotes. Found [" + this.Other.SubString(this.var__main_myfiledata, this.var__main_myfiledatapos == "" ? 0 : (int)double.Parse(this.var__main_myfiledatapos, (IFormatProvider)b4p.cul), 1) + "] {" + ((int)this.Other.SubString(this.var__main_myfiledata, this.var__main_myfiledatapos == "" ? 0 : (int)double.Parse(this.var__main_myfiledatapos, (IFormatProvider)b4p.cul), 1)[0]).ToString((IFormatProvider)b4p.cul) + "}");
				this.var__main_myfiledatapos = ((this.var__main_myfiledatapos == "" ? 0.0 : double.Parse(this.var__main_myfiledatapos, (IFormatProvider)b4p.cul)) + 1.0).ToString((IFormatProvider)b4p.cul);
				string @string = ((double)this.var__main_myfiledata.IndexOf('"'.ToString((IFormatProvider)b4p.cul), this.var__main_myfiledatapos == "" ? 0 : (int)double.Parse(this.var__main_myfiledatapos, (IFormatProvider)b4p.cul)) - (this.var__main_myfiledatapos == "" ? 0.0 : double.Parse(this.var__main_myfiledatapos, (IFormatProvider)b4p.cul))).ToString((IFormatProvider)b4p.cul);
				string var__main_cfsstr = this.Other.SubString(this.var__main_myfiledata, this.var__main_myfiledatapos == "" ? 0 : (int)double.Parse(this.var__main_myfiledatapos, (IFormatProvider)b4p.cul), @string == "" ? 0 : (int)double.Parse(@string, (IFormatProvider)b4p.cul));
				this.var__main_myfiledatapos = ((this.var__main_myfiledatapos == "" ? 0.0 : double.Parse(this.var__main_myfiledatapos, (IFormatProvider)b4p.cul)) + (@string == "" ? 0.0 : double.Parse(@string, (IFormatProvider)b4p.cul))).ToString((IFormatProvider)b4p.cul);
				this.var__main_myfiledatapos = ((this.var__main_myfiledatapos == "" ? 0.0 : double.Parse(this.var__main_myfiledatapos, (IFormatProvider)b4p.cul)) + 1.0).ToString((IFormatProvider)b4p.cul);
				return this.__main_checkforspelling(var__main_cfsstr);
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_readitemtext");
				return "";
			}
		}

		private string __main_savemygame()
		{
			string str1 = "";
			string s = "";
			string str2 = "";
			string str3 = "";
			string str4 = "";
			string str5 = "";
			int num1 = 0;
			try
			{
				if (this.err__main_savemygame > 0)
				{
					str5 = this.localVars[5];
					str4 = this.localVars[4];
					str3 = this.localVars[3];
					str2 = this.localVars[2];
					s = this.localVars[1];
					str1 = this.localVars[0];
					if (this.err__main_savemygame == 1)
					{
						this.err__main_savemygame = 0;
						((int)MessageBox.Show("Unable to save file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider)b4p.cul);
						return "";
					}
				}
				str2 = "";
				this.__main_savedialog1.Filter = "Save Files|*.sav";
				if (((int)this.__main_savedialog1.ShowDialog()).ToString((IFormatProvider)b4p.cul) != "2")
					str2 = this.__main_savedialog1.FileName;
				if (this.LCompareEqual(str2, ""))
				{
					this.__main_addtxtmsg("Save cancelled.");
					return "";
				}
				num1 = 1;
				this.htStreams.Add((object)"_main_c1", (object)new CStreamWriter(Path.Combine(this.b4pdir, str2), false, Encoding.ASCII));
				((TextWriter)this.htStreams[(object)"_main_c1"]).WriteLine(this.var__main_checksum);
				((TextWriter)this.htStreams[(object)"_main_c1"]).WriteLine(this.var__main_magicheader);
				((TextWriter)this.htStreams[(object)"_main_c1"]).WriteLine(this.var__main_advno);
				s = "0";
				double num2 = (double)byte.MaxValue;
				for (double num3 = double.Parse(s, (IFormatProvider)b4p.cul); num3 <= num2; s = (++num3).ToString((IFormatProvider)b4p.cul))
				{
					StreamWriter streamWriter1 = (StreamWriter)this.htStreams[(object)"_main_c1"];
					string[] strArray1 = (string[])this.var__main_counters;
					int index1 = s == "" ? 0 : (int)double.Parse(s, (IFormatProvider)b4p.cul);
					string str6 = (str3 = strArray1[index1]) == null ? "" : str3;
					streamWriter1.WriteLine(str6);
					StreamWriter streamWriter2 = (StreamWriter)this.htStreams[(object)"_main_c1"];
					string[] strArray2 = (string[])this.var__main_roomsaved;
					int index2 = s == "" ? 0 : (int)double.Parse(s, (IFormatProvider)b4p.cul);
					string str7 = (str4 = strArray2[index2]) == null ? "" : str4;
					streamWriter2.WriteLine(str7);
					StreamWriter streamWriter3 = (StreamWriter)this.htStreams[(object)"_main_c1"];
					string[] strArray3 = (string[])this.var__main_xbitflags;
					int index3 = s == "" ? 0 : (int)double.Parse(s, (IFormatProvider)b4p.cul);
					string str8 = (str5 = strArray3[index3]) == null ? "" : str5;
					streamWriter3.WriteLine(str8);
				}
				((TextWriter)this.htStreams[(object)"_main_c1"]).WriteLine(this.var__main_playerroom);
				((TextWriter)this.htStreams[(object)"_main_c1"]).WriteLine(this.var__main_currentcounter);
				((TextWriter)this.htStreams[(object)"_main_c1"]).WriteLine(this.var__main_currentsavedroom);
				((TextWriter)this.htStreams[(object)"_main_c1"]).WriteLine(this.var__main_lighttime);
				s = "0";
				double num4 = this.var__main_numitems == "" ? 0.0 : double.Parse(this.var__main_numitems, (IFormatProvider)b4p.cul);
				for (double num3 = double.Parse(s, (IFormatProvider)b4p.cul); num3 <= num4; s = (++num3).ToString((IFormatProvider)b4p.cul))
				{
					StreamWriter streamWriter = (StreamWriter)this.htStreams[(object)"_main_c1"];
					string[] strArray = (string[])this.var__main_xitemloc;
					int index = s == "" ? 0 : (int)double.Parse(s, (IFormatProvider)b4p.cul);
					string str6 = (str1 = strArray[index]) == null ? "" : str1;
					streamWriter.WriteLine(str6);
				}
				if (this.htStreams.Contains((object)"_main_c1"))
				{
					((IStream)this.htStreams[(object)"_main_c1"]).Close();
					this.htStreams.Remove((object)"_main_c1");
					GC.Collect();
				}
				this.__main_addtxtmsg("Game saved OK.");
				return "";
			}
			catch (Exception ex)
			{
				if (num1 > 0)
				{
					this.lastError = ex;
					this.err__main_savemygame = num1;
					this.localVars = new string[6]
			 {
				str1,
				s,
				str2,
				str3,
				str4,
				str5
			 };
					return this.__main_savemygame();
				}
				this.ShowError(ex, "__main_savemygame");
				return "";
			}
		}

		private string __main_butj_click()
		{
			try
			{
				this.__main_insertchar("J");
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_butj_click");
				return "";
			}
		}

		private string __main_filllamp()
		{
			try
			{
				this.var__main_lighttime = this.var__main_lightrefill;
				((string[])this.var__main_xitemloc)[this.var__main_light_source == "" ? 0 : (int)double.Parse(this.var__main_light_source, (IFormatProvider)b4p.cul)] = this.var__main_carried;
				this.__main_clearflag(this.var__main_lightoutbit);
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_filllamp");
				return "";
			}
		}

		private string __main_butmag_click()
		{
			try
			{
				if (this.LCompareEqual(this.var__main_sleeping, "Y"))
					return "";
				this.var__main_mymag = ((this.var__main_mymag == "" ? 0.0 : double.Parse(this.var__main_mymag, (IFormatProvider)b4p.cul)) + 1.0).ToString((IFormatProvider)b4p.cul);
				if (this.LCompareEqual(this.var__main_mymag, "4"))
					this.var__main_mymag = "1";
				if (this.LCompareEqual(this.var__main_mymag, "1"))
					this.__main_mycmd.Text = "EXAMINE ";
				if (this.LCompareEqual(this.var__main_mymag, "2"))
					this.__main_mycmd.Text = "READ ";
				if (this.LCompareEqual(this.var__main_mymag, "3"))
					this.__main_mycmd.Text = "LOOK ";
				this.__main_mycmd.Focus();
				this.__main_mycmd.SelectionStart = (int)(double)this.__main_mycmd.Text.Length;
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_butmag_click");
				return "";
			}
		}

		private string __main_addtxtmsg(string var__main_atmsg)
		{
			try
			{
				this.var__main_txtmsg = !this.LCompareEqual(var__main_atmsg, "") ? this.var__main_txtmsg + var__main_atmsg : "";
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_addtxtmsg");
				return "";
			}
		}

		private string __main_whichitem(string var__main_nounnum, string var__main_loc)
		{
			string str1 = "";
			try
			{
				this.var__main_secondcode = "0";
				string @string = "-1.0"; // .ToString((IFormatProvider)b4p.cul);
				if ((this.var__main_linkget == "" ? 0.0 : double.Parse(this.var__main_linkget, (IFormatProvider)b4p.cul)) > 0.0)
					this.var__main_secondcode = this.var__main_linkget;
				if ((this.var__main_linkdrop == "" ? 0.0 : double.Parse(this.var__main_linkdrop, (IFormatProvider)b4p.cul)) > 0.0)
					this.var__main_secondcode = this.var__main_linkdrop;
				if (this.LCompareEqual(this.var__main_secondcode, "0"))
				{
					string s = "0";
					double num1 = this.var__main_numitems == "" ? 0.0 : double.Parse(this.var__main_numitems, (IFormatProvider)b4p.cul);
					for (double num2 = double.Parse(s, (IFormatProvider)b4p.cul); num2 <= num1; s = (++num2).ToString((IFormatProvider)b4p.cul))
					{
						string[] strArray1 = (string[])this.var__main_xitemautoget;
						int index1 = s == "" ? 0 : (int)double.Parse(s, (IFormatProvider)b4p.cul);
						string str2;
						string lSide = (str2 = strArray1[index1]) == null ? "" : str2;
						string[] strArray2 = (string[])this.var__main_xnouns;
						int index2 = var__main_nounnum == "" ? 0 : (int)double.Parse(var__main_nounnum, (IFormatProvider)b4p.cul);
						string str3;
						string rSide = (str3 = strArray2[index2]) == null ? "" : str3;
						if (this.CompareEqual(lSide, rSide))
						{
							string[] strArray3 = (string[])this.var__main_xitemloc;
							int index3 = s == "" ? 0 : (int)double.Parse(s, (IFormatProvider)b4p.cul);
							string str4;
							if (this.CompareEqual((str4 = strArray3[index3]) == null ? "" : str4, this.var__main_playerroom))
								this.var__main_secondcode = s;
						}
					}
				}
				if ((this.var__main_secondcode == "" ? 0.0 : double.Parse(this.var__main_secondcode, (IFormatProvider)b4p.cul)) > 0.0)
				{
					string str2 = this.var__main_secondcode;
					double num1 = this.var__main_secondcode == "" ? 0.0 : double.Parse(this.var__main_secondcode, (IFormatProvider)b4p.cul);
					for (double num2 = double.Parse(str2, (IFormatProvider)b4p.cul); num2 <= num1; str2 = (++num2).ToString((IFormatProvider)b4p.cul))
					{
						str1 = "";
						string str3;

						// if (this.LCompareEqual(var__main_nounnum, -3.0.ToString((IFormatProvider)b4p.cul)))
						if (var__main_nounnum == "-3.0")
						{
							str3 = this.var__main_getnoun;
						}
						else
						{
							string[] strArray = (string[])this.var__main_xnouns;
							int index = var__main_nounnum == "" ? 0 : (int)double.Parse(var__main_nounnum, (IFormatProvider)b4p.cul);
							string str4;
							str3 = (str4 = strArray[index]) == null ? "" : str4;
						}
						string[] strArray1 = (string[])this.var__main_xitemautoget;
						int index1 = str2 == "" ? 0 : (int)double.Parse(str2, (IFormatProvider)b4p.cul);
						string str5;
						if ((double)((str5 = strArray1[index1]) == null ? "" : str5).Length > 0.0)
						{
							string[] strArray2 = (string[])this.var__main_xitemautoget;
							int index2 = str2 == "" ? 0 : (int)double.Parse(str2, (IFormatProvider)b4p.cul);
							string str4;
							if (this.__main_xleft(((str4 = strArray2[index2]) == null ? "" : str4).ToUpper(b4p.cul), this.var__main_wordlength) == this.__main_xleft(str3.ToUpper(b4p.cul), this.var__main_wordlength))
							{
								string[] strArray3 = (string[])this.var__main_xitemloc;
								int index3 = str2 == "" ? 0 : (int)double.Parse(str2, (IFormatProvider)b4p.cul);
								string str6;
								if (this.CompareEqual((str6 = strArray3[index3]) == null ? "" : str6, var__main_loc))
									return str2;
								if (this.__main_itemcarried(str2) == "true")
								{
									return "-3.0"; // .ToString((IFormatProvider)b4p.cul);
								}

								// if (this.LCompareEqual(@string, -1.0.ToString((IFormatProvider)b4p.cul)))
								if (@string == "-1.0")
								{
									@string = "-2.0"; // .ToString((IFormatProvider)b4p.cul);
								}
							}
						}
					}
				}
				else
				{
					string str2 = "0";
					double num1 = this.var__main_numitems == "" ? 0.0 : double.Parse(this.var__main_numitems, (IFormatProvider)b4p.cul);
					for (double num2 = double.Parse(str2, (IFormatProvider)b4p.cul); num2 <= num1; str2 = (++num2).ToString((IFormatProvider)b4p.cul))
					{
						str1 = "";
						string str3;

						// if (this.LCompareEqual(var__main_nounnum, -3.0.ToString((IFormatProvider)b4p.cul)))
						if (var__main_nounnum == "-3.0")
						{
							str3 = this.var__main_getnoun;
						}
						else
						{
							string[] strArray = (string[])this.var__main_xnouns;
							int index = var__main_nounnum == "" ? 0 : (int)double.Parse(var__main_nounnum, (IFormatProvider)b4p.cul);
							string str4;
							str3 = (str4 = strArray[index]) == null ? "" : str4;
						}
						string[] strArray1 = (string[])this.var__main_xitemautoget;
						int index1 = str2 == "" ? 0 : (int)double.Parse(str2, (IFormatProvider)b4p.cul);
						string str5;
						if ((double)((str5 = strArray1[index1]) == null ? "" : str5).Length > 0.0)
						{
							string[] strArray2 = (string[])this.var__main_xitemautoget;
							int index2 = str2 == "" ? 0 : (int)double.Parse(str2, (IFormatProvider)b4p.cul);
							string str4;
							if (this.__main_xleft(((str4 = strArray2[index2]) == null ? "" : str4).ToUpper(b4p.cul), this.var__main_wordlength) == this.__main_xleft(str3.ToUpper(b4p.cul), this.var__main_wordlength))
							{
								string[] strArray3 = (string[])this.var__main_xitemloc;
								int index3 = str2 == "" ? 0 : (int)double.Parse(str2, (IFormatProvider)b4p.cul);
								string str6;
								if (this.CompareEqual((str6 = strArray3[index3]) == null ? "" : str6, var__main_loc))
								{
									return str2;
								}

								if (this.__main_itemcarried(str2) == "true")
								{
									return "-3.0"; // .ToString((IFormatProvider)b4p.cul);
								}

								//if (this.LCompareEqual(@string, -1.0.ToString((IFormatProvider)b4p.cul)))
								if (@string == "-1.0")
								{
									@string = "-2.0"; // .ToString((IFormatProvider)b4p.cul);
								}
							}
						}
					}
				}
				return @string;
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_whichitem");
				return "";
			}
		}

		private string __main_html_stuff()
		{
			try
			{
				this.var__main_fontface = "MS Sans Serif";
				this.var__main_fontsize = this.var__main_optionsfontsize;
				this.var__main_html_start = "<html>";
				this.var__main_html_start = this.var__main_html_start + "<body bgcolor='" + this.var__main_html_body_background + "' topmargin='0' leftmargin='0' link='#0000ff' vlink='#0000ff' alink='#0000ff'>";
				this.var__main_html_look_start = "<table width='100%' cellspacing='0' cellpadding='2'><tr><td bgcolor='" + this.var__main_html_look_background + "'><font face='" + this.var__main_fontface + "' size='" + this.var__main_fontsize + "' color='" + this.var__main_html_look_text + "'>";
				this.var__main_html_look_end = "</font></td></tr></table>";
				this.var__main_html_exit_start = "<table width='100%' cellspacing='0' cellpadding='2'><tr><td bgcolor='" + this.var__main_html_exit_background + "'><font face='" + this.var__main_fontface + "' size='" + this.var__main_fontsize + "' color='" + this.var__main_html_exit_text + "'>";
				this.var__main_html_exit_end = "</font></td></tr></table>";
				this.var__main_html_mesg_start = "<table width='100%' cellspacing='0' cellpadding='2'><tr><td bgcolor='" + this.var__main_html_mesg_background + "'><font face='" + this.var__main_fontface + "' size='" + this.var__main_fontsize + "' color='" + this.var__main_html_mesg_text + "'>";
				this.var__main_html_mesg_end = "</font></td></tr></table>";
				this.var__main_html_lk_prompt_start = "<font color='" + this.var__main_html_look_prompt + "' face='" + this.var__main_fontface + "' size='" + this.var__main_fontsize + "'>";
				this.var__main_html_ex_prompt_start = "<font color='" + this.var__main_html_exit_prompt + "'>";
				this.var__main_html_prompt_end = "</font>";
				this.var__main_html_line = "<table cellspacing='0' cellpadding='0' width='100%'><tr><td bgcolor='" + this.var__main_html_line_break + "' height='1'></td></tr></table>";
				this.var__main_html_end = "</body></html>";
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_html_stuff");
				return "";
			}
		}

		private string __main_butother_click()
		{
			try
			{
				this.var__main_openingother = "Y";
				this.__main_opendialog1.Filter = "Data Files|*.dat";
				if (((int)this.__main_opendialog1.ShowDialog()).ToString((IFormatProvider)b4p.cul) != "2")
				{
					this.var__main_cancel = "false";
					this.__main_webby.DocumentText = "<html><body><img border='0' src='file://" + this.b4pdir + "/images/map.jpg'><br><img border='0' src='file://" + this.b4pdir + "/images/progress.gif'></body></html>";
					this.var__main_cancel = "true";
					this.__main_webby.CancelNavigate = bool.Parse("true".ToLower(b4p.cul));
					this.var__main_l = "1";
					double num1 = 5.0;
					for (double num2 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul); num2 <= num1; this.var__main_l = (num2 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul) + 1.0).ToString((IFormatProvider)b4p.cul))
					{
						Application.DoEvents();
						Thread.Sleep(100);
					}
					this.__main_fadventure.show();
					this.var__main_l = "1";
					double num3 = 5.0;
					for (double num2 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul); num2 <= num3; this.var__main_l = (num2 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul) + 1.0).ToString((IFormatProvider)b4p.cul))
					{
						Application.DoEvents();
						Thread.Sleep(100);
					}
					this.var__main_myadventure = this.__main_opendialog1.FileName;
					this.__main_mycmd.Text = "";
					this.__main_mycmd.Focus();
					this.__main_webby.CancelNavigate = bool.Parse("true".ToLower(b4p.cul));
					this.__main_loadfile(this.var__main_myadventure);
					this.__main_refreshweb();
					this.__main_butenter.Enabled = bool.Parse("true".ToLower(b4p.cul));
					this.__main_butdel.Enabled = bool.Parse("true".ToLower(b4p.cul));
					this.__main_butgo.Enabled = bool.Parse("true".ToLower(b4p.cul));
					this.var__main_openingother = "N";
				}
				else
					this.var__main_openingother = "N";
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_butother_click");
				return "";
			}
		}

		private string __main_addtxtexits(string var__main_atexits)
		{
			try
			{
				this.var__main_txtexits = !this.LCompareEqual(var__main_atexits, "") ? this.var__main_txtexits + var__main_atexits : "";
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_addtxtexits");
				return "";
			}
		}

		private string __main_faboutscott_click()
		{
			try
			{
				this.__main_aboutsa.show();
				this.__main_txtscott.SelectionStart = 0;
				this.__main_txtscott.SelectionLength = 0;
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_faboutscott_click");
				return "";
			}
		}

		private string __main_refreshweb()
		{
			try
			{
				if (!this.LCompareEqual(this.var__main_sleeping, "Y"))
				{
					this.var__main_quickdropchk = "Y";
					if (this.LCompareEqual(this.var__main_txtmsg, ""))
						this.var__main_txtmsg = "OK";
					if (this.LCompareEqual(this.var__main_mylastword1, "DROP") && double.Parse(this.__main_whichword(this.var__main_word2, "Nouns"), (IFormatProvider)b4p.cul) > 0.0)
						this.__main_inventory();
					this.var__main_quickdropchk = "N";
				}
				this.var__main_txtmsg = this.__main_trim(this.var__main_txtmsg);
				if ((double)this.var__main_txtmsg.Length > 2.0)
				{
					if ((double)this.var__main_txtmsg.Length > 4.0 && this.Other.SubString(this.var__main_txtmsg, (int)((double)this.var__main_txtmsg.Length - 4.0), 4).ToLower(b4p.cul) == "<br>" && (double)this.var__main_txtmsg.Length > 4.0)
						this.var__main_txtmsg = this.__main_xleft(this.var__main_txtmsg, ((double)this.var__main_txtmsg.Length - 4.0).ToString((IFormatProvider)b4p.cul));
					if ((double)this.var__main_txtmsg.Length > 4.0 && this.Other.SubString(this.var__main_txtmsg, (int)((double)this.var__main_txtmsg.Length - 4.0), 4).ToLower(b4p.cul) == "<br>" && (double)this.var__main_txtmsg.Length > 4.0)
						this.var__main_txtmsg = this.__main_xleft(this.var__main_txtmsg, ((double)this.var__main_txtmsg.Length - 4.0).ToString((IFormatProvider)b4p.cul));
					if (((double)this.__main_right(this.var__main_txtmsg, "1")[0] >= (double)"a"[0] && (double)this.__main_right(this.var__main_txtmsg, "1")[0] <= (double)"z"[0] || (double)this.__main_right(this.var__main_txtmsg, "1")[0] >= (double)"A"[0] && (double)this.__main_right(this.var__main_txtmsg, "1")[0] <= (double)"Z"[0] || ((int)this.__main_right(this.var__main_txtmsg, "1")[0]).ToString((IFormatProvider)b4p.cul) == ((int)"'"[0]).ToString((IFormatProvider)b4p.cul)) && this.__main_right(this.var__main_txtmsg, "2") != "OK")
						this.var__main_txtmsg = this.var__main_txtmsg + ".";
				}
				this.var__main_txtmsg = this.var__main_txtmsg + " ";
				this.var__main_txtmsg = this.var__main_txtmsg.Replace(".<br>0", " 0");
				this.var__main_txtmsg = this.var__main_txtmsg.Replace(".<br>1", " 1");
				this.var__main_txtmsg = this.var__main_txtmsg.Replace(".<br>2", " 2");
				this.var__main_txtmsg = this.var__main_txtmsg.Replace(".<br>3", " 3");
				this.var__main_txtmsg = this.var__main_txtmsg.Replace(".<br>4", " 4");
				this.var__main_txtmsg = this.var__main_txtmsg.Replace(".<br>5", " 5");
				this.var__main_txtmsg = this.var__main_txtmsg.Replace(".<br>6", " 6");
				this.var__main_txtmsg = this.var__main_txtmsg.Replace(".<br>7", " 7");
				this.var__main_txtmsg = this.var__main_txtmsg.Replace(".<br>8", " 8");
				this.var__main_txtmsg = this.var__main_txtmsg.Replace(".<br>9", " 9");
				this.var__main_lastrefresh = this.var__main_txtlook + this.var__main_txtexits + this.var__main_txtmsg;
				this.var__main_cancel = "false";
				Application.DoEvents();
				Application.DoEvents();
				if (this.LCompareEqual(this.var__main_optionsalthyperon, "Y"))
				{
					while (!(this.__main_webby.IsBusy.ToString((IFormatProvider)b4p.cul).ToLower(b4p.cul) == "false"))
						Application.DoEvents();
					Application.DoEvents();
					Application.DoEvents();
				}
				if ((double)this.var__main_txtmsg.Length > 0.0)
					this.var__main_txtmsg = this.__main_trim(this.var__main_txtmsg);
				if ((double)this.var__main_txtmsg.Length > 2.0 && this.__main_right(this.var__main_txtmsg, "1") == ",")
					this.var__main_txtmsg = this.Other.SubString(this.var__main_txtmsg, 0, (int)((double)this.var__main_txtmsg.Length - 1.0)) + ".";
				string str1;
				string str2;
				string str3;
				if (this.LCompareEqual(this.var__main_optionsfontbold, "0"))
				{
					str1 = this.__main_hx2(this.var__main_txtlook);
					str2 = this.var__main_txtexits;
					str3 = this.__main_checkinvext(this.var__main_txtmsg.Replace("<b>", "").Replace("</b>", ""));
				}
				else
				{
					str1 = this.__main_hx2(this.var__main_txtlook);
					str2 = this.var__main_txtexits;
					str3 = this.__main_checkinvext(this.var__main_txtmsg);
					if (this.LCompareEqual(this.var__main_optionsfontbold, "1"))
					{
						str1 = "<b>" + str1 + "</b>";
						str2 = "<b>" + str2 + "</b>";
						str3 = "<b>" + str3 + "</b>";
					}
				}
				string str4 = str3.Replace("[br]", "<br>");
				if (this.LCompareEqual(this.var__main_optionsrvsinfo, "N"))
					this.__main_webby.DocumentText = this.var__main_html_start + str1 + this.var__main_html_line + str2 + this.var__main_html_line + this.var__main_html_mesg_start + str4 + this.var__main_html_mesg_end + this.var__main_html_end;
				else
					this.__main_webby.DocumentText = this.var__main_html_start + this.var__main_html_mesg_start + str4 + this.var__main_html_mesg_end + this.var__main_html_line + str1 + this.var__main_html_line + str2 + this.var__main_html_end;
				Application.DoEvents();
				this.var__main_cancel = "true";
				this.__main_mycmd.Focus();
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_refreshweb");
				return "";
			}
		}

		private string __main_itemcarried(string var__main_myitem)
		{
			try
			{
				string[] strArray = (string[])this.var__main_xitemloc;
				int index = var__main_myitem == "" ? 0 : (int)double.Parse(var__main_myitem, (IFormatProvider)b4p.cul);
				string str;
				return this.CompareEqual((str = strArray[index]) == null ? "" : str, this.var__main_carried) ? "true" : "false";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_itemcarried");
				return "";
			}
		}

		private string __main_dropitem(string var__main_di)
		{
			try
			{
				string str = var__main_di;
				while (true)
				{
					bool flag;

					//for (; !(str == -1.0.ToString((IFormatProvider)b4p.cul)); str = "0")
					for (; !(str == "-1.0"); str = "0")
					{
						// if (str == -2.0.ToString((IFormatProvider)b4p.cul))
						if (str == "-2.0")
						{
							this.__main_addtxtmsg("I'm not carrying it!<br>");
							flag = true;
							goto label_15;
						}
						else if (!(str == ""))
						{
							if ((this.var__main_linkdrop == "" ? 0.0 : double.Parse(this.var__main_linkdrop, (IFormatProvider)b4p.cul)) > 0.0)
							{
								((string[])this.var__main_xitemloc)[this.var__main_linkdrop == "" ? 0 : (int)double.Parse(this.var__main_linkdrop, (IFormatProvider)b4p.cul)] = this.var__main_playerroom;
								this.var__main_linkdrop = "0";
							}
							else
								((string[])this.var__main_xitemloc)[var__main_di == "" ? 0 : (int)double.Parse(var__main_di, (IFormatProvider)b4p.cul)] = this.var__main_playerroom;
							if ((double)this.var__main_txtmsg.Length > 5.0)
							{
								if (this.__main_right(this.var__main_txtmsg, "6").ToUpper(b4p.cul) != "OK<BR>")
									this.__main_addtxtmsg("OK<br>");
							}
							else
								this.__main_addtxtmsg("OK<br>");
							flag = true;
							goto label_15;
						}
					}
					this.__main_addtxtmsg("It's beyond my power to do that.<br>");
					flag = true;
label_15:
					if (!flag && str == "")
						str = "0";
					else
						break;
				}
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_dropitem");
				return "";
			}
		}

		private string __main_iteminoriginalroom(string var__main_myitem)
		{
			try
			{
				string[] strArray1 = (string[])this.var__main_xitemloc;
				int index1 = var__main_myitem == "" ? 0 : (int)double.Parse(var__main_myitem, (IFormatProvider)b4p.cul);
				string str1;
				string lSide = (str1 = strArray1[index1]) == null ? "" : str1;
				string[] strArray2 = (string[])this.var__main_xiteminitloc;
				int index2 = var__main_myitem == "" ? 0 : (int)double.Parse(var__main_myitem, (IFormatProvider)b4p.cul);
				string str2;
				string rSide = (str2 = strArray2[index2]) == null ? "" : str2;
				return this.CompareEqual(lSide, rSide) ? "true" : "false";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_iteminoriginalroom");
				return "";
			}
		}

		private string __main_getflag(string var__main_myflag)
		{
			try
			{
				string[] strArray = (string[])this.var__main_xbitflags;
				int index = var__main_myflag == "" ? 0 : (int)double.Parse(var__main_myflag, (IFormatProvider)b4p.cul);
				string str;
				return this.LCompareEqual((str = strArray[index]) == null ? "" : str, "1") ? "true" : "false";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_getflag");
				return "";
			}
		}

		private string __main_menuload_click()
		{
			try
			{
				this.__main_loadmygame();
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_menuload_click");
				return "";
			}
		}

		private string __main_menusave_click()
		{
			try
			{
				if (this.LCompareEqual(this.var__main_sleeping, "Y"))
					return "";
				this.__main_savemygame();
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_menusave_click");
				return "";
			}
		}

		private string __main_loadthemes()
		{
			string str = "";
			try
			{
				str = "0";
				string string1 = this.Other.FileSearch("__main_arraylist1", this.b4pdir + "\\themes", "*.thm").ToString((IFormatProvider)b4p.cul);
				string string2 = (this.b4pdir + "\\themes").Length.ToString((IFormatProvider)b4p.cul);
				if (this.LCompareEqual(string1, "0"))
				{
					((int)MessageBox.Show("No themes found! Please reinstall the application!", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider)b4p.cul);
					return "";
				}
				string s1 = "0";
				double num1 = (string1 == "" ? 0.0 : double.Parse(string1, (IFormatProvider)b4p.cul)) - 1.0;
				for (double num2 = double.Parse(s1, (IFormatProvider)b4p.cul); num2 <= num1; s1 = (++num2).ToString((IFormatProvider)b4p.cul))
					this.__main_pdtheme.Items.Add((object)this.Other.SubString(this.__main_arraylist1[s1 == "" ? 0 : (int)double.Parse(s1, (IFormatProvider)b4p.cul)].ToString(), (int)((string2 == "" ? 0.0 : double.Parse(string2, (IFormatProvider)b4p.cul)) + 1.0), (int)((double)this.__main_arraylist1[s1 == "" ? 0 : (int)double.Parse(s1, (IFormatProvider)b4p.cul)].ToString().Length - (string2 == "" ? 0.0 : double.Parse(string2, (IFormatProvider)b4p.cul)) - 5.0)));
				string s2 = "0";
				double num3 = (string1 == "" ? 0.0 : double.Parse(string1, (IFormatProvider)b4p.cul)) - 1.0;
				for (double num2 = double.Parse(s2, (IFormatProvider)b4p.cul); num2 <= num3; s2 = (++num2).ToString((IFormatProvider)b4p.cul))
				{
					string string3 = ((s2 == "" ? 0.0 : double.Parse(s2, (IFormatProvider)b4p.cul)) + 1.0).ToString((IFormatProvider)b4p.cul);
					double num4 = (string1 == "" ? 0.0 : double.Parse(string1, (IFormatProvider)b4p.cul)) - 1.0;
					for (double num5 = double.Parse(string3, (IFormatProvider)b4p.cul); num5 <= num4; string3 = (++num5).ToString((IFormatProvider)b4p.cul))
					{
						if ((double)string.Compare(this.__main_pdtheme.Items[s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul)].ToString(), this.__main_pdtheme.Items[string3 == "" ? 0 : (int)double.Parse(string3, (IFormatProvider)b4p.cul)].ToString(), true, b4p.cul) > 0.0)
						{
							string string4 = this.__main_pdtheme.Items[s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul)].ToString();
							this.__main_pdtheme.Items[s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul)] = (object)this.__main_pdtheme.Items[string3 == "" ? 0 : (int)double.Parse(string3, (IFormatProvider)b4p.cul)].ToString();
							this.__main_pdtheme.Items[string3 == "" ? 0 : (int)double.Parse(string3, (IFormatProvider)b4p.cul)] = (object)string4;
						}
					}
				}
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_loadthemes");
				return "";
			}
		}

		private string __main_butdel_click()
		{
			try
			{
				if (this.__main_mycmd.SelectionStart.ToString((IFormatProvider)b4p.cul) == "0" && this.__main_mycmd.SelectionLength.ToString((IFormatProvider)b4p.cul) == "0")
					return "";
				string string1 = this.__main_mycmd.SelectionStart.ToString((IFormatProvider)b4p.cul);
				string string2 = this.__main_mycmd.SelectionLength.ToString((IFormatProvider)b4p.cul);
				if ((string2 == "" ? 0.0 : double.Parse(string2, (IFormatProvider)b4p.cul)) > 0.0)
				{
					string str = "";
					string s = "0";
					double num1 = (double)this.__main_mycmd.Text.Length - 1.0;
					for (double num2 = double.Parse(s, (IFormatProvider)b4p.cul); num2 <= num1; s = (++num2).ToString((IFormatProvider)b4p.cul))
					{
						if ((s == "" ? 0.0 : double.Parse(s, (IFormatProvider)b4p.cul)) < (string1 == "" ? 0.0 : double.Parse(string1, (IFormatProvider)b4p.cul)) || (s == "" ? 0.0 : double.Parse(s, (IFormatProvider)b4p.cul)) > (string1 == "" ? 0.0 : double.Parse(string1, (IFormatProvider)b4p.cul)) + (string2 == "" ? 0.0 : double.Parse(string2, (IFormatProvider)b4p.cul)) - 1.0)
							str += this.Other.SubString(this.__main_mycmd.Text, s == "" ? 0 : (int)double.Parse(s, (IFormatProvider)b4p.cul), 1);
					}
					this.__main_mycmd.Text = str;
					if ((string1 == "" ? 0.0 : double.Parse(string1, (IFormatProvider)b4p.cul)) > 0.0)
						this.__main_mycmd.SelectionStart = string1 == "" ? 0 : (int)double.Parse(string1, (IFormatProvider)b4p.cul);
					else
						this.__main_mycmd.SelectionStart = 0;
				}
				else
				{
					this.__main_mycmd.Text = this.Other.SubString(this.__main_mycmd.Text, 0, (int)((string1 == "" ? 0.0 : double.Parse(string1, (IFormatProvider)b4p.cul)) - 1.0)) + this.__main_right(this.__main_mycmd.Text, ((double)this.__main_mycmd.Text.Length - (string1 == "" ? 0.0 : double.Parse(string1, (IFormatProvider)b4p.cul))).ToString((IFormatProvider)b4p.cul));
					if ((string1 == "" ? 0.0 : double.Parse(string1, (IFormatProvider)b4p.cul)) > 0.0)
						this.__main_mycmd.SelectionStart = (int)((string1 == "" ? 0.0 : double.Parse(string1, (IFormatProvider)b4p.cul)) - 1.0);
					else
						this.__main_mycmd.SelectionStart = 0;
				}
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_butdel_click");
				return "";
			}
		}

		private string __main_resetgeneral()
		{
			try
			{
				((string[])this.var__main_exitnames)[0] = "North";
				((string[])this.var__main_exitnames)[1] = "South";
				((string[])this.var__main_exitnames)[2] = "East";
				((string[])this.var__main_exitnames)[3] = "West";
				((string[])this.var__main_exitnames)[4] = "Up";
				((string[])this.var__main_exitnames)[5] = "Down";
				this.var__main_gamehastorch = "Y";
				this.var__main_l = "0";
				double num1 = 29.0;
				for (double num2 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul); num2 <= num1; this.var__main_l = (num2 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul) + 1.0).ToString((IFormatProvider)b4p.cul))
					((string[])this.var__main_param)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul)] = "0";
				this.var__main_l = "0";
				double num3 = 3.0;
				for (double num2 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul); num2 <= num3; this.var__main_l = (num2 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul) + 1.0).ToString((IFormatProvider)b4p.cul))
					((string[])this.var__main_act)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul)] = "0";
				this.var__main_done_intro_look = "N";
				this.var__main_currentcounter = "0";
				this.var__main_currentsavedroom = "0";
				this.var__main_l = "0";
				double num4 = (double)byte.MaxValue;
				for (double num2 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul); num2 <= num4; this.var__main_l = (num2 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul) + 1.0).ToString((IFormatProvider)b4p.cul))
					((string[])this.var__main_counters)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul)] = "0";
				this.var__main_l = "0";
				double num5 = 40.0;
				for (double num2 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul); num2 <= num5; this.var__main_l = (num2 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul) + 1.0).ToString((IFormatProvider)b4p.cul))
					((string[])this.var__main_xbitflags)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul)] = "0";
				this.var__main_l = "0";
				double num6 = (double)byte.MaxValue;
				for (double num2 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul); num2 <= num6; this.var__main_l = (num2 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul) + 1.0).ToString((IFormatProvider)b4p.cul))
					((string[])this.var__main_roomsaved)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul)] = "0";
				this.var__main_myfiledatapos = "0";
				this.var__main_myfiledata = "";
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_resetgeneral");
				return "";
			}
		}

		private string __main_butw_click()
		{
			try
			{
				if (this.LCompareEqual(this.var__main_sleeping, "Y") && this.__main_mycmd.Text.ToUpper(b4p.cul) == "W")
					return "";
				if (this.__main_mycmd.Text.ToUpper(b4p.cul) == "W")
					this.__main_mycmd_keypress('\r'.ToString((IFormatProvider)b4p.cul));
				else if (this.LCompareEqual(this.var__main_abcison, "Y"))
					this.__main_insertchar("W");
				else
					this.__main_insertchar("2");
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_butw_click");
				return "";
			}
		}

		private string __main_countcarrying()
		{
			try
			{
				string s1 = "0";
				string s2 = "0";
				double num1 = this.var__main_numitems == "" ? 0.0 : double.Parse(this.var__main_numitems, (IFormatProvider)b4p.cul);
				for (double num2 = double.Parse(s2, (IFormatProvider)b4p.cul); num2 <= num1; s2 = (++num2).ToString((IFormatProvider)b4p.cul))
				{
					string[] strArray = (string[])this.var__main_xitemloc;
					int index = s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul);
					string str;
					if (this.CompareEqual((str = strArray[index]) == null ? "" : str, this.var__main_carried))
						s1 = ((s1 == "" ? 0.0 : double.Parse(s1, (IFormatProvider)b4p.cul)) + 1.0).ToString((IFormatProvider)b4p.cul);
				}
				return s1;
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_countcarrying");
				return "";
			}
		}

		private string __main_app_start()
		{
			try
			{
				this.__main_readoptionsfromfile();
				this.htControls.Remove((object)"__main_bdi");
				this.__main_bdi = new Class_bDeviceInfo();
				this.htControls.Add((object)"__main_bdi", (object)this.__main_bdi);
				if (!this.CEnhancedObject.htShemotAzamim.Contains((object)this.__main_bdi))
					this.CEnhancedObject.htShemotAzamim.Add((object)this.__main_bdi, (object)"__main_bdi");
				if (!this.LCompareEqual(this.var__main_seelmagain, "N") && ((double)this.__main_bdi.GetOSVersionString().IndexOf(" 2.", 0) > -1.0 || (double)this.__main_bdi.GetOSVersionString().IndexOf(" 4.", 0) > -1.0 || (double)this.__main_bdi.GetOSVersionString().IndexOf(" 3.", 0) > -1.0))
				{
					this.var__main_disablelinks = "Y";
					this.var__main_seelmagain = !(((int)MessageBox.Show("Your PDA does not support in-game links, but don't worry, these are optional for game play anyway.\r\n\r\nDo you want to see this message again?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider)b4p.cul) == "7") ? "Y" : "N";
				}
				this.__main_saveoptionstofile();
				this.__main_loadthemes();
				this.__main_screensizecheck();
				this.var__main_optionswarning = "' Do not change anything in this file.";
				this.var__main_optionsmyadv = "0";
				this.var__main_optionstheme = "";
				this.var__main_optionsfontsize = "1";
				this.var__main_optionslinks = "0";
				this.var__main_optionslinkson = "Y";
				this.var__main_optionsfontbold = "0";
				this.var__main_althyper = "0";
				this.var__main_optionsalthyperon = "N";
				this.__main_readoptionsfromfile();
				this.__main_readmytheme(this.var__main_optionstheme);
				this.__main_html_stuff();
				if (this.LCompareEqual(this.var__main_keyboardisoff, "Y"))
				{
					if (this.LCompareEqual(this.var__main_screentype, "320x320"))
					{
						this.htControls.Remove((object)"__main_webby");
						this.__main_webby = new WebBrowser.WebBrowser(this.CEnhancedObject.GetControlStringOrRef("main", (object)"FAdventure"), 0, 0, 320, 188);
						this.htControls.Add((object)"__main_webby", (object)this.__main_webby);
						if (!this.CEnhancedObject.htShemotAzamim.Contains((object)this.__main_webby))
							this.CEnhancedObject.htShemotAzamim.Add((object)this.__main_webby, (object)"__main_webby");
						this.__main_webby.Navigating += new EventHandler(this.CEnhancedObject.MetapelEruim);
					}
					if (this.LCompareEqual(this.var__main_screentype, "240x240"))
					{
						this.htControls.Remove((object)"__main_webby");
						this.__main_webby = new WebBrowser.WebBrowser(this.CEnhancedObject.GetControlStringOrRef("main", (object)"FAdventure"), 0, 0, 240, 165);
						this.htControls.Add((object)"__main_webby", (object)this.__main_webby);
						if (!this.CEnhancedObject.htShemotAzamim.Contains((object)this.__main_webby))
							this.CEnhancedObject.htShemotAzamim.Add((object)this.__main_webby, (object)"__main_webby");
						this.__main_webby.Navigating += new EventHandler(this.CEnhancedObject.MetapelEruim);
					}
					if (this.LCompareEqual(this.var__main_screentype, "320x240"))
					{
						this.htControls.Remove((object)"__main_webby");
						this.__main_webby = new WebBrowser.WebBrowser(this.CEnhancedObject.GetControlStringOrRef("main", (object)"FAdventure"), 0, 0, 320, 163);
						this.htControls.Add((object)"__main_webby", (object)this.__main_webby);
						if (!this.CEnhancedObject.htShemotAzamim.Contains((object)this.__main_webby))
							this.CEnhancedObject.htShemotAzamim.Add((object)this.__main_webby, (object)"__main_webby");
						this.__main_webby.Navigating += new EventHandler(this.CEnhancedObject.MetapelEruim);
					}
					if (this.LCompareEqual(this.var__main_screentype, "240x320"))
					{
						this.htControls.Remove((object)"__main_webby");
						this.__main_webby = new WebBrowser.WebBrowser(this.CEnhancedObject.GetControlStringOrRef("main", (object)"FAdventure"), 0, 0, 240, 240);
						this.htControls.Add((object)"__main_webby", (object)this.__main_webby);
						if (!this.CEnhancedObject.htShemotAzamim.Contains((object)this.__main_webby))
							this.CEnhancedObject.htShemotAzamim.Add((object)this.__main_webby, (object)"__main_webby");
						this.__main_webby.Navigating += new EventHandler(this.CEnhancedObject.MetapelEruim);
					}
					if (this.LCompareEqual(this.var__main_screentype, "640x480"))
					{
						this.htControls.Remove((object)"__main_webby");
						this.__main_webby = new WebBrowser.WebBrowser(this.CEnhancedObject.GetControlStringOrRef("main", (object)"FAdventure"), 0, 0, 640, 331);
						this.htControls.Add((object)"__main_webby", (object)this.__main_webby);
						if (!this.CEnhancedObject.htShemotAzamim.Contains((object)this.__main_webby))
							this.CEnhancedObject.htShemotAzamim.Add((object)this.__main_webby, (object)"__main_webby");
						this.__main_webby.Navigating += new EventHandler(this.CEnhancedObject.MetapelEruim);
					}
					if (this.LCompareEqual(this.var__main_screentype, "480x640"))
					{
						this.htControls.Remove((object)"__main_webby");
						this.__main_webby = new WebBrowser.WebBrowser(this.CEnhancedObject.GetControlStringOrRef("main", (object)"FAdventure"), 0, 0, 480, 483);
						this.htControls.Add((object)"__main_webby", (object)this.__main_webby);
						if (!this.CEnhancedObject.htShemotAzamim.Contains((object)this.__main_webby))
							this.CEnhancedObject.htShemotAzamim.Add((object)this.__main_webby, (object)"__main_webby");
						this.__main_webby.Navigating += new EventHandler(this.CEnhancedObject.MetapelEruim);
					}
					if (this.LCompareEqual(this.var__main_screentype, "800x480"))
					{
						this.htControls.Remove((object)"__main_webby");
						this.__main_webby = new WebBrowser.WebBrowser(this.CEnhancedObject.GetControlStringOrRef("main", (object)"FAdventure"), 0, 0, 800, 324);
						this.htControls.Add((object)"__main_webby", (object)this.__main_webby);
						if (!this.CEnhancedObject.htShemotAzamim.Contains((object)this.__main_webby))
							this.CEnhancedObject.htShemotAzamim.Add((object)this.__main_webby, (object)"__main_webby");
						this.__main_webby.Navigating += new EventHandler(this.CEnhancedObject.MetapelEruim);
					}
					if (this.LCompareEqual(this.var__main_screentype, "480x800"))
					{
						this.htControls.Remove((object)"__main_webby");
						this.__main_webby = new WebBrowser.WebBrowser(this.CEnhancedObject.GetControlStringOrRef("main", (object)"FAdventure"), 0, 0, 480, 640);
						this.htControls.Add((object)"__main_webby", (object)this.__main_webby);
						if (!this.CEnhancedObject.htShemotAzamim.Contains((object)this.__main_webby))
							this.CEnhancedObject.htShemotAzamim.Add((object)this.__main_webby, (object)"__main_webby");
						this.__main_webby.Navigating += new EventHandler(this.CEnhancedObject.MetapelEruim);
					}
				}
				if (this.LCompareEqual(this.var__main_keyboardisoff, "N"))
				{
					if (this.LCompareEqual(this.var__main_screentype, "320x320"))
					{
						this.htControls.Remove((object)"__main_webby");
						this.__main_webby = new WebBrowser.WebBrowser(this.CEnhancedObject.GetControlStringOrRef("main", (object)"FAdventure"), 0, 0, 320, 188);
						this.htControls.Add((object)"__main_webby", (object)this.__main_webby);
						if (!this.CEnhancedObject.htShemotAzamim.Contains((object)this.__main_webby))
							this.CEnhancedObject.htShemotAzamim.Add((object)this.__main_webby, (object)"__main_webby");
						this.__main_webby.Navigating += new EventHandler(this.CEnhancedObject.MetapelEruim);
					}
					if (this.LCompareEqual(this.var__main_screentype, "240x240"))
					{
						this.htControls.Remove((object)"__main_webby");
						this.__main_webby = new WebBrowser.WebBrowser(this.CEnhancedObject.GetControlStringOrRef("main", (object)"FAdventure"), 0, 0, 240, 165);
						this.htControls.Add((object)"__main_webby", (object)this.__main_webby);
						if (!this.CEnhancedObject.htShemotAzamim.Contains((object)this.__main_webby))
							this.CEnhancedObject.htShemotAzamim.Add((object)this.__main_webby, (object)"__main_webby");
						this.__main_webby.Navigating += new EventHandler(this.CEnhancedObject.MetapelEruim);
					}
					if (this.LCompareEqual(this.var__main_screentype, "320x240"))
					{
						this.htControls.Remove((object)"__main_webby");
						this.__main_webby = new WebBrowser.WebBrowser(this.CEnhancedObject.GetControlStringOrRef("main", (object)"FAdventure"), 0, 0, 320, 133);
						this.htControls.Add((object)"__main_webby", (object)this.__main_webby);
						if (!this.CEnhancedObject.htShemotAzamim.Contains((object)this.__main_webby))
							this.CEnhancedObject.htShemotAzamim.Add((object)this.__main_webby, (object)"__main_webby");
						this.__main_webby.Navigating += new EventHandler(this.CEnhancedObject.MetapelEruim);
					}
					if (this.LCompareEqual(this.var__main_screentype, "240x320"))
					{
						this.htControls.Remove((object)"__main_webby");
						this.__main_webby = new WebBrowser.WebBrowser(this.CEnhancedObject.GetControlStringOrRef("main", (object)"FAdventure"), 0, 0, 240, 188);
						this.htControls.Add((object)"__main_webby", (object)this.__main_webby);
						if (!this.CEnhancedObject.htShemotAzamim.Contains((object)this.__main_webby))
							this.CEnhancedObject.htShemotAzamim.Add((object)this.__main_webby, (object)"__main_webby");
						this.__main_webby.Navigating += new EventHandler(this.CEnhancedObject.MetapelEruim);
					}
					if (this.LCompareEqual(this.var__main_screentype, "640x480"))
					{
						this.htControls.Remove((object)"__main_webby");
						this.__main_webby = new WebBrowser.WebBrowser(this.CEnhancedObject.GetControlStringOrRef("main", (object)"FAdventure"), 0, 0, 640, 254);
						this.htControls.Add((object)"__main_webby", (object)this.__main_webby);
						if (!this.CEnhancedObject.htShemotAzamim.Contains((object)this.__main_webby))
							this.CEnhancedObject.htShemotAzamim.Add((object)this.__main_webby, (object)"__main_webby");
						this.__main_webby.Navigating += new EventHandler(this.CEnhancedObject.MetapelEruim);
					}
					if (this.LCompareEqual(this.var__main_screentype, "480x640"))
					{
						this.htControls.Remove((object)"__main_webby");
						this.__main_webby = new WebBrowser.WebBrowser(this.CEnhancedObject.GetControlStringOrRef("main", (object)"FAdventure"), 0, 0, 480, 377);
						this.htControls.Add((object)"__main_webby", (object)this.__main_webby);
						if (!this.CEnhancedObject.htShemotAzamim.Contains((object)this.__main_webby))
							this.CEnhancedObject.htShemotAzamim.Add((object)this.__main_webby, (object)"__main_webby");
						this.__main_webby.Navigating += new EventHandler(this.CEnhancedObject.MetapelEruim);
					}
					if (this.LCompareEqual(this.var__main_screentype, "800x480"))
					{
						this.htControls.Remove((object)"__main_webby");
						this.__main_webby = new WebBrowser.WebBrowser(this.CEnhancedObject.GetControlStringOrRef("main", (object)"FAdventure"), 0, 0, 800, 254);
						this.htControls.Add((object)"__main_webby", (object)this.__main_webby);
						if (!this.CEnhancedObject.htShemotAzamim.Contains((object)this.__main_webby))
							this.CEnhancedObject.htShemotAzamim.Add((object)this.__main_webby, (object)"__main_webby");
						this.__main_webby.Navigating += new EventHandler(this.CEnhancedObject.MetapelEruim);
					}
					if (this.LCompareEqual(this.var__main_screentype, "480x800"))
					{
						this.htControls.Remove((object)"__main_webby");
						this.__main_webby = new WebBrowser.WebBrowser(this.CEnhancedObject.GetControlStringOrRef("main", (object)"FAdventure"), 0, 0, 480, 537);
						this.htControls.Add((object)"__main_webby", (object)this.__main_webby);
						if (!this.CEnhancedObject.htShemotAzamim.Contains((object)this.__main_webby))
							this.CEnhancedObject.htShemotAzamim.Add((object)this.__main_webby, (object)"__main_webby");
						this.__main_webby.Navigating += new EventHandler(this.CEnhancedObject.MetapelEruim);
					}
				}
				this.var__main_computerexit = "false";
				this.var__main_myadventure = "";
				this.__main_fselect.show();
				this.__main_pdselect.SelectedIndex = this.var__main_optionsmyadv == "" ? 0 : (int)double.Parse(this.var__main_optionsmyadv, (IFormatProvider)b4p.cul);
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_app_start");
				return "";
			}
		}

		private string __main_butl_click()
		{
			try
			{
				if (this.LCompareEqual(this.var__main_sleeping, "Y") && this.__main_mycmd.Text.ToUpper(b4p.cul) == "L")
					return "";
				if (this.__main_mycmd.Text.ToUpper(b4p.cul) == "L")
					this.__main_mycmd_keypress('\r'.ToString((IFormatProvider)b4p.cul));
				else
					this.__main_insertchar("L");
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_butl_click");
				return "";
			}
		}

		private string __main_butenter_click()
		{
			try
			{
				if (this.LCompareEqual(this.var__main_sleeping, "Y"))
					return "";
				this.__main_mycmd_keypress('\r'.ToString((IFormatProvider)b4p.cul));
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_butenter_click");
				return "";
			}
		}

		private string __main_itemdestroyed(string var__main_myitem)
		{
			try
			{
				string[] strArray = (string[])this.var__main_xitemloc;
				int index = var__main_myitem == "" ? 0 : (int)double.Parse(var__main_myitem, (IFormatProvider)b4p.cul);
				string str;
				return this.CompareEqual((str = strArray[index]) == null ? "" : str, this.var__main_destroyed) ? "true" : "false";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_itemdestroyed");
				return "";
			}
		}

		private string __main_buty_click()
		{
			try
			{
				if (this.LCompareEqual(this.var__main_abcison, "Y"))
					this.__main_insertchar("Y");
				else
					this.__main_insertchar("6");
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_buty_click");
				return "";
			}
		}

		private string __main_loadfile(string var__main_mydatfile)
		{
			string str1 = "";
			string str2 = "";
			string lSide = "";
			string str3 = "";
			string str4 = "";
			string str5 = "";
			string original1 = "";
			string str6 = "";
			string str7 = "";
			string str8 = "";
			string str9 = "";
			string str10 = "";
			string str11 = "";
			string str12 = "";
			string str13 = "";
			string str14 = "";
			string str15 = "";
			string str16 = "";
			string str17 = "";
			int num1 = 0;
			try
			{
				if (this.err__main_loadfile > 0)
				{
					str17 = this.localVars[18];
					str16 = this.localVars[17];
					str15 = this.localVars[16];
					str14 = this.localVars[15];
					str13 = this.localVars[14];
					str12 = this.localVars[13];
					str11 = this.localVars[12];
					str10 = this.localVars[11];
					str9 = this.localVars[10];
					str8 = this.localVars[9];
					str7 = this.localVars[8];
					str6 = this.localVars[7];
					original1 = this.localVars[6];
					str5 = this.localVars[5];
					str4 = this.localVars[4];
					str3 = this.localVars[3];
					lSide = this.localVars[2];
					str2 = this.localVars[1];
					str1 = this.localVars[0];
					if (this.err__main_loadfile == 1)
					{
						this.err__main_loadfile = 0;
						if (this.LCompareEqual(this.var__main_openingother, "Y"))
							((int)MessageBox.Show("Error reading adventure file. (Correctly formatted?)", "", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider)b4p.cul);
						else
							((int)MessageBox.Show("Error reading adventure file. Please reinstall this application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider)b4p.cul);
						this.var__main_openingother = "N";
						if (this.mainForm != null)
							this.mainForm.Close();
						else
							this.CloseProgram();
						return "";
					}
				}
				this.__main_resetgeneral();
				this.__main_resetvars();
				this.var__main_initial_load = "1";
				this.var__main_myfiledata = "";
				str13 = "";
				this.var__main_txtlook = "";
				this.var__main_txtmsg = "";
				this.var__main_txtexits = "";
				this.var__main_mygetdrop = "0";
				this.var__main_mymag = "0";
				this.var__main_myel = "0";
				num1 = 1;
				this.htStreams.Add((object)"_main_myfo", (object)new CStreamReader(Path.Combine(this.b4pdir, var__main_mydatfile), Encoding.ASCII));
				this.var__main_myfiledata = ((TextReader)this.htStreams[(object)"_main_myfo"]).ReadToEnd();
				if (this.htStreams.Contains((object)"_main_myfo"))
				{
					((IStream)this.htStreams[(object)"_main_myfo"]).Close();
					this.htStreams.Remove((object)"_main_myfo");
					GC.Collect();
				}
				this.var__main_myfiledata = this.var__main_myfiledata.Replace('\r'.ToString((IFormatProvider)b4p.cul), "");
				this.var__main_magicheader = this.__main_readmyno();
				this.var__main_numitems = this.__main_readmyno();
				this.var__main_numactions = this.__main_readmyno();
				this.var__main_numwords = this.__main_readmyno();
				this.var__main_numrooms = this.__main_readmyno();
				if ((this.var__main_numrooms == "" ? 0.0 : double.Parse(this.var__main_numrooms, (IFormatProvider)b4p.cul)) > 254.0)
					this.var__main_carryingcanbe255 = "N";
				this.var__main_maxcarry = this.__main_readmyno();
				this.var__main_playerroom = this.__main_readmyno();
				this.var__main_treasures = this.__main_readmyno();
				this.var__main_wordlength = this.__main_readmyno();
				this.var__main_lighttime = this.__main_readmyno();
				if (this.LCompareEqual(this.var__main_lighttime, "0"))
					this.var__main_lighttime = "32000";
				this.var__main_lightrefill = this.var__main_lighttime;
				this.var__main_nummessages = this.__main_readmyno();
				this.var__main_treasureroom = this.__main_readmyno();
				this.var__main_checksum = "0";
				this.var__main_checksum = ((this.var__main_numitems == "" ? 0.0 : double.Parse(this.var__main_numitems, (IFormatProvider)b4p.cul)) + (this.var__main_numactions == "" ? 0.0 : double.Parse(this.var__main_numactions, (IFormatProvider)b4p.cul)) + (this.var__main_numwords == "" ? 0.0 : double.Parse(this.var__main_numwords, (IFormatProvider)b4p.cul)) + (this.var__main_numrooms == "" ? 0.0 : double.Parse(this.var__main_numrooms, (IFormatProvider)b4p.cul)) + (this.var__main_maxcarry == "" ? 0.0 : double.Parse(this.var__main_maxcarry, (IFormatProvider)b4p.cul)) + (this.var__main_playerroom == "" ? 0.0 : double.Parse(this.var__main_playerroom, (IFormatProvider)b4p.cul)) + (this.var__main_treasures == "" ? 0.0 : double.Parse(this.var__main_treasures, (IFormatProvider)b4p.cul)) + (this.var__main_nummessages == "" ? 0.0 : double.Parse(this.var__main_nummessages, (IFormatProvider)b4p.cul)) + (this.var__main_treasureroom == "" ? 0.0 : double.Parse(this.var__main_treasureroom, (IFormatProvider)b4p.cul))).ToString((IFormatProvider)b4p.cul);
				this.__main_resetvars();
				this.var__main_l = "0";
				double num2 = this.var__main_numactions == "" ? 0.0 : double.Parse(this.var__main_numactions, (IFormatProvider)b4p.cul);
				for (double num3 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul); num3 <= num2; this.var__main_l = (num3 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul) + 1.0).ToString((IFormatProvider)b4p.cul))
				{
					((string[])this.var__main_xactionvocab)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul)] = this.__main_readmyno();
					string[] strArray1 = (string[])this.var__main_xactionverb;
					int index1 = this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul);
					string[] strArray2 = (string[])this.var__main_xactionvocab;
					int index2 = this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul);
					string str18 = (str11 = strArray2[index2]) == null ? "" : str11;
					strArray1[index1] = str18;
					string[] strArray3 = (string[])this.var__main_xactionnoun;
					int index3 = this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul);
					string[] strArray4 = (string[])this.var__main_xactionverb;
					int index4 = this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul);
					string string1 = Math.Floor(((str9 = strArray4[index4]) == null ? 0.0 : double.Parse(str9 == "" ? "0" : str9, (IFormatProvider)b4p.cul)) % 150.0).ToString((IFormatProvider)b4p.cul);
					strArray3[index3] = string1;
					string[] strArray5 = (string[])this.var__main_xactionverb;
					int index5 = this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul);
					string[] strArray6 = (string[])this.var__main_xactionverb;
					int index6 = this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul);
					string string2 = Math.Floor(((str10 = strArray6[index6]) == null ? 0.0 : double.Parse(str10 == "" ? "0" : str10, (IFormatProvider)b4p.cul)) / 150.0).ToString((IFormatProvider)b4p.cul);
					strArray5[index5] = string2;
					((string[,])this.var__main_xactioncondition)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul), 0] = this.__main_readmyno();
					((string[,])this.var__main_xactioncondition)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul), 1] = this.__main_readmyno();
					((string[,])this.var__main_xactioncondition)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul), 2] = this.__main_readmyno();
					((string[,])this.var__main_xactioncondition)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul), 3] = this.__main_readmyno();
					((string[,])this.var__main_xactioncondition)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul), 4] = this.__main_readmyno();
					((string[,])this.var__main_xactionaction)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul), 0] = this.__main_readmyno();
					((string[,])this.var__main_xactionaction)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul), 1] = this.__main_readmyno();
				}
				this.var__main_l = "0";
				double num4 = this.var__main_numwords == "" ? 0.0 : double.Parse(this.var__main_numwords, (IFormatProvider)b4p.cul);
				for (double num3 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul); num3 <= num4; this.var__main_l = (num3 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul) + 1.0).ToString((IFormatProvider)b4p.cul))
				{
					((string[])this.var__main_xverbs)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul)] = this.__main_readmystr();
					((string[])this.var__main_xnouns)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul)] = this.__main_readmystr();
				}
				this.var__main_l = "0";
				double num5 = this.var__main_numrooms == "" ? 0.0 : double.Parse(this.var__main_numrooms, (IFormatProvider)b4p.cul);
				for (double num3 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul); num3 <= num5; this.var__main_l = (num3 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul) + 1.0).ToString((IFormatProvider)b4p.cul))
				{
					this.var__main_x = "0";
					double num6 = 5.0;
					for (double num7 = double.Parse(this.var__main_x, (IFormatProvider)b4p.cul); num7 <= num6; this.var__main_x = (num7 = double.Parse(this.var__main_x, (IFormatProvider)b4p.cul) + 1.0).ToString((IFormatProvider)b4p.cul))
						((string[,])this.var__main_xroomexit)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul), this.var__main_x == "" ? 0 : (int)double.Parse(this.var__main_x, (IFormatProvider)b4p.cul)] = this.__main_readmyno();
					((string[])this.var__main_xroomtext)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul)] = this.__main_readmystr();
				}
				this.var__main_l = "0";
				double num8 = this.var__main_nummessages == "" ? 0.0 : double.Parse(this.var__main_nummessages, (IFormatProvider)b4p.cul);
				for (double num3 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul); num3 <= num8; this.var__main_l = (num3 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul) + 1.0).ToString((IFormatProvider)b4p.cul))
				{
					((string[])this.var__main_xmessages)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul)] = this.__main_readmystr();
					string[] strArray1 = (string[])this.var__main_xmessages;
					int index1 = this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul);
					if ((double)((str17 = strArray1[index1]) == null ? "" : str17).IndexOf("&", 0) > -1.0)
					{
						lSide = "0";
						string[] strArray2 = (string[])this.var__main_xmessages;
						int index2 = this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul);
						if (((str15 = strArray2[index2]) == null ? "" : str15).IndexOf("&", 0).ToString((IFormatProvider)b4p.cul) == "0")
							lSide = "1";
						if (this.LCompareEqual(lSide, "0"))
						{
							string[] strArray3 = (string[])this.var__main_xmessages;
							int index3 = this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul);
							string[] strArray4 = (string[])this.var__main_xmessages;
							int index4 = this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul);
							string str18 = ((str16 = strArray4[index4]) == null ? "" : str16).Replace("&", " and ");
							strArray3[index3] = str18;
						}
						if (this.LCompareEqual(lSide, "1"))
						{
							string[] strArray3 = (string[])this.var__main_xmessages;
							int index3 = this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul);
							string[] strArray4 = (string[])this.var__main_xmessages;
							int index4 = this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul);
							string str18 = ((str1 = strArray4[index4]) == null ? "" : str1).Replace("&", "and ");
							strArray3[index3] = str18;
						}
						string[] strArray5 = (string[])this.var__main_xmessages;
						int index5 = this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul);
						string[] strArray6 = (string[])this.var__main_xmessages;
						int index6 = this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul);
						string str19 = ((str2 = strArray6[index6]) == null ? "" : str2).Replace("  ", " ");
						strArray5[index5] = str19;
						lSide = "0";
					}
				}
				this.var__main_l = "0";
				double num9 = this.var__main_numitems == "" ? 0.0 : double.Parse(this.var__main_numitems, (IFormatProvider)b4p.cul);
				for (double num3 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul); num3 <= num9; this.var__main_l = (num3 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul) + 1.0).ToString((IFormatProvider)b4p.cul))
				{
					((string[])this.var__main_xitemtext)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul)] = this.__main_readitemtext();
					((string[])this.var__main_xitemautoget)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul)] = "";
					string[] strArray1 = (string[])this.var__main_xitemtext;
					int index1 = this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul);
					if ((double)((str3 = strArray1[index1]) == null ? "" : str3).Length > 0.0)
					{
						Other other1 = this.Other;
						string[] strArray2 = (string[])this.var__main_xitemtext;
						int index2 = this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul);
						string original2 = (str4 = strArray2[index2]) == null ? "" : str4;
						string[] strArray3 = (string[])this.var__main_xitemtext;
						int index3 = this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul);
						int start1 = (int)((double)((str6 = strArray3[index3]) == null ? "" : str6).Length - 1.0);
						int count1 = 1;
						if (other1.SubString(original2, start1, count1) == "/")
						{
							original1 = "";
							string[] strArray4 = (string[])this.var__main_xitemtext;
							int index4 = this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul);
							if ((double)((str5 = strArray4[index4]) == null ? "" : str5).Length > 0.0)
							{
								Other other2 = this.Other;
								string[] strArray5 = (string[])this.var__main_xitemtext;
								int index5 = this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul);
								string original3 = (str8 = strArray5[index5]) == null ? "" : str8;
								int start2 = 0;
								string[] strArray6 = (string[])this.var__main_xitemtext;
								int index6 = this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul);
								int count2 = (int)((double)((str14 = strArray6[index6]) == null ? "" : str14).Length - 1.0);
								original1 = other2.SubString(original3, start2, count2);
							}
							((string[])this.var__main_xitemautoget)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul)] = this.__main_trim(this.Other.SubString(original1, (int)((double)original1.IndexOf("/", 0) + 1.0), (int)((double)original1.Length - (double)original1.IndexOf("/", 0))));
							((string[])this.var__main_xitemtext)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul)] = this.Other.SubString(original1, 0, (int)(double)original1.IndexOf("/", 0));
						}
					}
					((string[])this.var__main_xitemloc)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul)] = this.__main_readitemloc();
					if (this.LCompareEqual(this.var__main_carryingcanbe255, "Y"))
					{
						string[] strArray2 = (string[])this.var__main_xitemloc;
						int index2 = this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul);
						if (this.LCompareEqual((str7 = strArray2[index2]) == null ? "" : str7, "255"))
						{
							((string[])this.var__main_xitemloc)[this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul)] = "-1.0"; // .ToString((IFormatProvider)b4p.cul);
						}
					}
					string[] strArray7 = (string[])this.var__main_xiteminitloc;
					int index7 = this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul);
					string[] strArray8 = (string[])this.var__main_xitemloc;
					int index8 = this.var__main_l == "" ? 0 : (int)double.Parse(this.var__main_l, (IFormatProvider)b4p.cul);
					string str18 = (str12 = strArray8[index8]) == null ? "" : str12;
					strArray7[index7] = str18;
				}
				this.var__main_l = "0";
				double num10 = this.var__main_numactions == "" ? 0.0 : double.Parse(this.var__main_numactions, (IFormatProvider)b4p.cul);
				for (double num3 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul); num3 <= num10; this.var__main_l = (num3 = double.Parse(this.var__main_l, (IFormatProvider)b4p.cul) + 1.0).ToString((IFormatProvider)b4p.cul))
					this.__main_readmystr();
				this.var__main_advversion = this.__main_readmyno();
				this.var__main_advno = this.__main_readmyno();
				if ((this.var__main_lighttime == "" ? 0.0 : double.Parse(this.var__main_lighttime, (IFormatProvider)b4p.cul)) > 5000.0)
					this.var__main_gamehastorch = "N";
				this.__main_clearscreen();
				this.__main_look();
				this.__main_autoactions();
				this.var__main_initial_load = "0";
				if (this.__main_redraw() == "true")
					this.__main_look();
				if (this.LCompareEqual(this.var__main_txtlook, ""))
					this.__main_look();
				return "";
			}
			catch (Exception ex)
			{
				if (num1 > 0)
				{
					this.lastError = ex;
					this.err__main_loadfile = num1;
					this.localVars = new string[19]
			 {
				str1,
				str2,
				lSide,
				str3,
				str4,
				str5,
				original1,
				str6,
				str7,
				str8,
				str9,
				str10,
				str11,
				str12,
				str13,
				str14,
				str15,
				str16,
				str17
			 };
					return this.__main_loadfile(var__main_mydatfile);
				}
				this.ShowError(ex, "__main_loadfile");
				return "";
			}
		}

		private string __main_butp_click()
		{
			try
			{
				if (this.LCompareEqual(this.var__main_abcison, "Y"))
					this.__main_insertchar("P");
				else
					this.__main_insertchar("0");
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_butp_click");
				return "";
			}
		}

		private string __main_performactionline(string var__main_plct)
		{
			string str1 = "";
			string str2 = "";
			string str3 = "";
			string str4 = "";
			string str5 = "";
			string str6 = "";
			try
			{
				string s1 = "0";
				str5 = "0";
				str6 = "0";
				string s2 = "0";
				double num1 = 4.0;
				double num2 = double.Parse(s2, (IFormatProvider)b4p.cul);
				double num3;
				while (num2 <= num1)
				{
					str4 = "0";
					str2 = "0";
					string[,] strArray = (string[,])this.var__main_xactioncondition;
					int index1 = var__main_plct == "" ? 0 : (int)double.Parse(var__main_plct, (IFormatProvider)b4p.cul);
					int index2 = s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul);
					string str7;
					string s3 = (str7 = strArray[index1, index2]) == null ? "" : str7;
					num3 = Math.Floor((s3 == "" ? 0.0 : double.Parse(s3, (IFormatProvider)b4p.cul)) / 20.0);
					string string1 = num3.ToString((IFormatProvider)b4p.cul);
					num3 = (s3 == "" ? 0.0 : double.Parse(s3, (IFormatProvider)b4p.cul)) % 20.0;
					string string2 = num3.ToString((IFormatProvider)b4p.cul);
					bool flag = false;
					string str8 = string2;
					while (true)
					{
						if (str8 == "0")
						{
							((string[])this.var__main_param)[s1 == "" ? 0 : (int)double.Parse(s1, (IFormatProvider)b4p.cul)] = string1;
							num3 = (s1 == "" ? 0.0 : double.Parse(s1, (IFormatProvider)b4p.cul)) + 1.0;
							s1 = num3.ToString((IFormatProvider)b4p.cul);
							flag = true;
						}
						else if (str8 == "1")
						{
							if (!(this.__main_itemcarried(string1) == "false"))
								flag = true;
							else
								break;
						}
						else if (str8 == "2")
						{
							if (!(this.__main_itemhere(string1) == "false"))
								flag = true;
							else
								goto label_11;
						}
						else if (str8 == "3")
						{
							if (!(this.__main_itemavailable(string1) == "false"))
								flag = true;
							else
								goto label_15;
						}
						else if (str8 == "4")
						{
							if (!(this.__main_playerinroom(string1) == "false"))
								flag = true;
							else
								goto label_19;
						}
						else if (str8 == "5")
						{
							if (!(this.__main_itemhere(string1) == "true"))
								flag = true;
							else
								goto label_23;
						}
						else if (str8 == "6")
						{
							if (!(this.__main_itemcarried(string1) == "true"))
								flag = true;
							else
								goto label_27;
						}
						else if (str8 == "7")
						{
							if (!(this.__main_playerinroom(string1) == "true"))
								flag = true;
							else
								goto label_31;
						}
						else if (str8 == "8")
						{
							if (!(this.__main_getflag(string1) == "false"))
								flag = true;
							else
								goto label_35;
						}
						else if (str8 == "9")
						{
							if (!(this.__main_getflag(string1) == "true"))
								flag = true;
							else
								goto label_39;
						}
						else if (str8 == "10")
						{
							if (!(this.__main_countcarried() == "0"))
								flag = true;
							else
								goto label_43;
						}
						else if (str8 == "11")
						{
							if (double.Parse(this.__main_countcarried(), (IFormatProvider)b4p.cul) <= 0.0)
								flag = true;
							else
								goto label_47;
						}
						else if (str8 == "12")
						{
							if (!(this.__main_itemavailable(string1) == "true"))
								flag = true;
							else
								goto label_51;
						}
						else if (str8 == "13")
						{
							if (!(this.__main_itemdestroyed(string1) == "true"))
								flag = true;
							else
								goto label_55;
						}
						else if (str8 == "14")
						{
							if (!(this.__main_itemdestroyed(string1) == "false"))
								flag = true;
							else
								goto label_59;
						}
						else if (str8 == "15")
						{
							if ((this.var__main_currentcounter == "" ? 0.0 : double.Parse(this.var__main_currentcounter, (IFormatProvider)b4p.cul)) <= (string1 == "" ? 0.0 : double.Parse(string1, (IFormatProvider)b4p.cul)))
								flag = true;
							else
								goto label_63;
						}
						else if (str8 == "16")
						{
							if ((this.var__main_currentcounter == "" ? 0.0 : double.Parse(this.var__main_currentcounter, (IFormatProvider)b4p.cul)) > (string1 == "" ? 0.0 : double.Parse(string1, (IFormatProvider)b4p.cul)))
								flag = true;
							else
								goto label_67;
						}
						else if (str8 == "17")
						{
							if (!(this.__main_iteminoriginalroom(string1) == "false"))
								flag = true;
							else
								goto label_71;
						}
						else if (str8 == "18")
						{
							if (!(this.__main_iteminoriginalroom(string1) == "true"))
								flag = true;
							else
								goto label_75;
						}
						else if (str8 == "19")
						{
							if (this.CompareEqual(this.var__main_currentcounter, string1))
								flag = true;
							else
								goto label_79;
						}
						if (!flag && str8 == "")
							str8 = "0";
						else
							goto label_83;
					}
					return "false";
label_11:
					return "false";
label_15:
					return "false";
label_19:
					return "false";
label_23:
					return "false";
label_27:
					return "false";
label_31:
					return "false";
label_35:
					return "false";
label_39:
					return "false";
label_43:
					return "false";
label_47:
					return "false";
label_51:
					return "false";
label_55:
					return "false";
label_59:
					return "false";
label_63:
					return "false";
label_67:
					return "false";
label_71:
					return "false";
label_75:
					return "false";
label_79:
					return "false";
label_83:
					num3 = ++num2;
					s2 = num3.ToString((IFormatProvider)b4p.cul);
				}
				string[] strArray1 = (string[])this.var__main_act;
				int index3 = 0;
				string[,] strArray2 = (string[,])this.var__main_xactionaction;
				int index4 = var__main_plct == "" ? 0 : (int)double.Parse(var__main_plct, (IFormatProvider)b4p.cul);
				int index5 = 0;
				string str9;
				string str10 = (str9 = strArray2[index4, index5]) == null ? "" : str9;
				strArray1[index3] = str10;
				string[] strArray3 = (string[])this.var__main_act;
				int index6 = 2;
				string[,] strArray4 = (string[,])this.var__main_xactionaction;
				int index7 = var__main_plct == "" ? 0 : (int)double.Parse(var__main_plct, (IFormatProvider)b4p.cul);
				int index8 = 1;
				string str11;
				string str12 = (str11 = strArray4[index7, index8]) == null ? "" : str11;
				strArray3[index6] = str12;
				string[] strArray5 = (string[])this.var__main_act;
				int index9 = 1;
				string str13;
				num3 = ((str13 = ((string[])this.var__main_act)[0]) == null ? 0.0 : double.Parse(str13 == "" ? "0" : str13, (IFormatProvider)b4p.cul)) % 150.0;
				string string3 = num3.ToString((IFormatProvider)b4p.cul);
				strArray5[index9] = string3;
				string[] strArray6 = (string[])this.var__main_act;
				int index10 = 3;
				string str14;
				num3 = ((str14 = ((string[])this.var__main_act)[2]) == null ? 0.0 : double.Parse(str14 == "" ? "0" : str14, (IFormatProvider)b4p.cul)) % 150.0;
				string string4 = num3.ToString((IFormatProvider)b4p.cul);
				strArray6[index10] = string4;
				string[] strArray7 = (string[])this.var__main_act;
				int index11 = 0;
				string str15;
				num3 = Math.Floor(((str15 = ((string[])this.var__main_act)[0]) == null ? 0.0 : double.Parse(str15 == "" ? "0" : str15, (IFormatProvider)b4p.cul)) / 150.0);
				string string5 = num3.ToString((IFormatProvider)b4p.cul);
				strArray7[index11] = string5;
				string[] strArray8 = (string[])this.var__main_act;
				int index12 = 2;
				string str16;
				num3 = Math.Floor(((str16 = ((string[])this.var__main_act)[2]) == null ? 0.0 : double.Parse(str16 == "" ? "0" : str16, (IFormatProvider)b4p.cul)) / 150.0);
				string string6 = num3.ToString((IFormatProvider)b4p.cul);
				strArray8[index12] = string6;
				str5 = "0";
				string s4 = "0";
				string str17 = "0";
				string s5 = "0";
				double num4 = 3.0;
				double num5 = double.Parse(s5, (IFormatProvider)b4p.cul);
				while (num5 <= num4)
				{
					string[] strArray9 = (string[])this.var__main_act;
					int index1 = s5 == "" ? 0 : (int)double.Parse(s5, (IFormatProvider)b4p.cul);
					string str7;
					if (((str7 = strArray9[index1]) == null ? 0.0 : double.Parse(str7 == "" ? "0" : str7, (IFormatProvider)b4p.cul)) >= 1.0)
					{
						string[] strArray10 = (string[])this.var__main_act;
						int index2 = s5 == "" ? 0 : (int)double.Parse(s5, (IFormatProvider)b4p.cul);
						string str8;
						if (((str8 = strArray10[index2]) == null ? 0.0 : double.Parse(str8 == "" ? "0" : str8, (IFormatProvider)b4p.cul)) <= 51.0)
							goto label_89;
					}
					string[] strArray11 = (string[])this.var__main_act;
					int index13 = s5 == "" ? 0 : (int)double.Parse(s5, (IFormatProvider)b4p.cul);
					string str18;
					if (((str18 = strArray11[index13]) == null ? 0.0 : double.Parse(str18 == "" ? "0" : str18, (IFormatProvider)b4p.cul)) < 102.0)
					{
						string[] strArray10 = (string[])this.var__main_act;
						int index2 = s5 == "" ? 0 : (int)double.Parse(s5, (IFormatProvider)b4p.cul);
						string str8;
						string str19 = (str8 = strArray10[index2]) == null ? "" : str8;
						while (true)
						{
							bool flag;
							for (; !(str19 == "0"); str19 = "0")
							{
								if (str19 == "52")
								{
									string[] strArray12 = (string[])this.var__main_param;
									int index14 = s4 == "" ? 0 : (int)double.Parse(s4, (IFormatProvider)b4p.cul);
									string str20;
									if (this.__main_getitem((str20 = strArray12[index14]) == null ? "" : str20) == "false")
									{
										num3 = (s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider)b4p.cul)) + 1.0;
										str3 = num3.ToString((IFormatProvider)b4p.cul);
										return "false";
									}
									num3 = (s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider)b4p.cul)) + 1.0;
									s4 = num3.ToString((IFormatProvider)b4p.cul);
									flag = true;
									goto label_207;
								}
								else if (str19 == "53")
								{
									string[] strArray12 = (string[])this.var__main_xitemloc;
									string[] strArray13 = (string[])this.var__main_param;
									int index14 = s4 == "" ? 0 : (int)double.Parse(s4, (IFormatProvider)b4p.cul);
									string str20;
									int index15 = (str20 = strArray13[index14]) == null ? 0 : (int)double.Parse(str20 == "" ? "0" : str20, (IFormatProvider)b4p.cul);
									string str21 = this.var__main_playerroom;
									strArray12[index15] = str21;
									num3 = (s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider)b4p.cul)) + 1.0;
									s4 = num3.ToString((IFormatProvider)b4p.cul);
									if (this.LCompareEqual(this.var__main_word1, "DROP") && this.LCompareEqual(this.var__main_word2, "ALL"))
									{
										if ((double)this.var__main_txtmsg.Length > 5.0)
										{
											if (this.__main_right(this.var__main_txtmsg, "6").ToUpper(b4p.cul) != "OK<BR>")
												this.__main_addtxtmsg("OK<br>");
										}
										else
											this.__main_addtxtmsg("OK<br>");
									}
									flag = true;
									goto label_207;
								}
								else if (str19 == "54")
								{
									string[] strArray12 = (string[])this.var__main_param;
									int index14 = s4 == "" ? 0 : (int)double.Parse(s4, (IFormatProvider)b4p.cul);
									string str20;
									this.var__main_playerroom = (str20 = strArray12[index14]) == null ? "" : str20;
									num3 = (s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider)b4p.cul)) + 1.0;
									s4 = num3.ToString((IFormatProvider)b4p.cul);
									flag = true;
									goto label_207;
								}
								else if (str19 == "55")
								{
									string[] strArray12 = (string[])this.var__main_xitemloc;
									string[] strArray13 = (string[])this.var__main_param;
									int index14 = s4 == "" ? 0 : (int)double.Parse(s4, (IFormatProvider)b4p.cul);
									string str20;
									int index15 = (str20 = strArray13[index14]) == null ? 0 : (int)double.Parse(str20 == "" ? "0" : str20, (IFormatProvider)b4p.cul);
									string str21 = this.var__main_destroyed;
									strArray12[index15] = str21;
									num3 = (s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider)b4p.cul)) + 1.0;
									s4 = num3.ToString((IFormatProvider)b4p.cul);
									flag = true;
									goto label_207;
								}
								else if (str19 == "56")
								{
									this.__main_setflag(this.var__main_darkbit);
									flag = true;
									goto label_207;
								}
								else if (str19 == "57")
								{
									this.__main_clearflag(this.var__main_darkbit);
									flag = true;
									goto label_207;
								}
								else if (str19 == "58")
								{
									string[] strArray12 = (string[])this.var__main_param;
									int index14 = s4 == "" ? 0 : (int)double.Parse(s4, (IFormatProvider)b4p.cul);
									string str20;
									this.__main_setflag((str20 = strArray12[index14]) == null ? "" : str20);
									num3 = (s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider)b4p.cul)) + 1.0;
									s4 = num3.ToString((IFormatProvider)b4p.cul);
									flag = true;
									goto label_207;
								}
								else if (str19 == "59")
								{
									string[] strArray12 = (string[])this.var__main_xitemloc;
									string[] strArray13 = (string[])this.var__main_param;
									int index14 = s4 == "" ? 0 : (int)double.Parse(s4, (IFormatProvider)b4p.cul);
									string str20;
									int index15 = (str20 = strArray13[index14]) == null ? 0 : (int)double.Parse(str20 == "" ? "0" : str20, (IFormatProvider)b4p.cul);
									string str21 = this.var__main_destroyed;
									strArray12[index15] = str21;
									num3 = (s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider)b4p.cul)) + 1.0;
									s4 = num3.ToString((IFormatProvider)b4p.cul);
									flag = true;
									goto label_207;
								}
								else if (str19 == "60")
								{
									string[] strArray12 = (string[])this.var__main_param;
									int index14 = s4 == "" ? 0 : (int)double.Parse(s4, (IFormatProvider)b4p.cul);
									string str20;
									this.__main_clearflag((str20 = strArray12[index14]) == null ? "" : str20);
									num3 = (s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider)b4p.cul)) + 1.0;
									s4 = num3.ToString((IFormatProvider)b4p.cul);
									flag = true;
									goto label_207;
								}
								else if (str19 == "61")
								{
									this.__main_killplayer();
									flag = true;
									goto label_207;
								}
								else if (str19 == "62")
								{
									string[] strArray12 = (string[])this.var__main_xitemloc;
									string[] strArray13 = (string[])this.var__main_param;
									int index14 = s4 == "" ? 0 : (int)double.Parse(s4, (IFormatProvider)b4p.cul);
									string str20;
									int index15 = (str20 = strArray13[index14]) == null ? 0 : (int)double.Parse(str20 == "" ? "0" : str20, (IFormatProvider)b4p.cul);
									string[] strArray14 = (string[])this.var__main_param;
									int index16 = (int)((s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider)b4p.cul)) + 1.0);
									string str21;
									string str22 = (str21 = strArray14[index16]) == null ? "" : str21;
									strArray12[index15] = str22;
									num3 = (s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider)b4p.cul)) + 2.0;
									s4 = num3.ToString((IFormatProvider)b4p.cul);
									flag = true;
									goto label_207;
								}
								else if (str19 == "63")
								{
									this.__main_quit();
									flag = true;
									goto label_207;
								}
								else if (str19 == "64")
								{
									this.__main_look();
									flag = true;
									goto label_207;
								}
								else if (str19 == "65")
								{
									this.__main_score();
									flag = true;
									goto label_207;
								}
								else if (str19 == "66")
								{
									this.__main_inventory();
									flag = true;
									goto label_207;
								}
								else if (str19 == "67")
								{
									this.__main_setflag("0");
									flag = true;
									goto label_207;
								}
								else if (str19 == "68")
								{
									this.__main_clearflag("0");
									flag = true;
									goto label_207;
								}
								else if (str19 == "69")
								{
									this.__main_filllamp();
									flag = true;
									goto label_207;
								}
								else if (str19 == "70")
								{
									Application.DoEvents();
									flag = true;
									goto label_207;
								}
								else if (str19 == "71")
								{
									this.__main_savemygame();
									flag = true;
									goto label_207;
								}
								else if (str19 == "72")
								{
									string[] strArray12 = (string[])this.var__main_xitemloc;
									string[] strArray13 = (string[])this.var__main_param;
									int index14 = s4 == "" ? 0 : (int)double.Parse(s4, (IFormatProvider)b4p.cul);
									string str20;
									int index15 = (str20 = strArray13[index14]) == null ? 0 : (int)double.Parse(str20 == "" ? "0" : str20, (IFormatProvider)b4p.cul);
									string str21;
									string str22 = (str21 = strArray12[index15]) == null ? "" : str21;
									string[] strArray14 = (string[])this.var__main_xitemloc;
									string[] strArray15 = (string[])this.var__main_param;
									int index16 = s4 == "" ? 0 : (int)double.Parse(s4, (IFormatProvider)b4p.cul);
									string str23;
									int index17 = (str23 = strArray15[index16]) == null ? 0 : (int)double.Parse(str23 == "" ? "0" : str23, (IFormatProvider)b4p.cul);
									string[] strArray16 = (string[])this.var__main_xitemloc;
									string[] strArray17 = (string[])this.var__main_param;
									int index18 = (int)((s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider)b4p.cul)) + 1.0);
									string str24;
									int index19 = (str24 = strArray17[index18]) == null ? 0 : (int)double.Parse(str24 == "" ? "0" : str24, (IFormatProvider)b4p.cul);
									string str25;
									string str26 = (str25 = strArray16[index19]) == null ? "" : str25;
									strArray14[index17] = str26;
									string[] strArray18 = (string[])this.var__main_xitemloc;
									string[] strArray19 = (string[])this.var__main_param;
									int index20 = (int)((s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider)b4p.cul)) + 1.0);
									string str27;
									int index21 = (str27 = strArray19[index20]) == null ? 0 : (int)double.Parse(str27 == "" ? "0" : str27, (IFormatProvider)b4p.cul);
									string str28 = str22;
									strArray18[index21] = str28;
									num3 = (s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider)b4p.cul)) + 2.0;
									s4 = num3.ToString((IFormatProvider)b4p.cul);
									flag = true;
									goto label_207;
								}
								else if (str19 == "73")
								{
									this.var__main_continuation = "true";
									flag = true;
									goto label_207;
								}
								else if (str19 == "74")
								{
									string[] strArray12 = (string[])this.var__main_xitemloc;
									string[] strArray13 = (string[])this.var__main_param;
									int index14 = s4 == "" ? 0 : (int)double.Parse(s4, (IFormatProvider)b4p.cul);
									string str20;
									int index15 = (str20 = strArray13[index14]) == null ? 0 : (int)double.Parse(str20 == "" ? "0" : str20, (IFormatProvider)b4p.cul);
									string str21 = this.var__main_carried;
									strArray12[index15] = str21;
									num3 = (s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider)b4p.cul)) + 1.0;
									s4 = num3.ToString((IFormatProvider)b4p.cul);
									flag = true;
									goto label_207;
								}
								else if (str19 == "75")
								{
									string[] strArray12 = (string[])this.var__main_xitemloc;
									string[] strArray13 = (string[])this.var__main_param;
									int index14 = s4 == "" ? 0 : (int)double.Parse(s4, (IFormatProvider)b4p.cul);
									string str20;
									int index15 = (str20 = strArray13[index14]) == null ? 0 : (int)double.Parse(str20 == "" ? "0" : str20, (IFormatProvider)b4p.cul);
									string[] strArray14 = (string[])this.var__main_xitemloc;
									string[] strArray15 = (string[])this.var__main_param;
									int index16 = (int)((s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider)b4p.cul)) + 1.0);
									string str21;
									int index17 = (str21 = strArray15[index16]) == null ? 0 : (int)double.Parse(str21 == "" ? "0" : str21, (IFormatProvider)b4p.cul);
									string str22;
									string str23 = (str22 = strArray14[index17]) == null ? "" : str22;
									strArray12[index15] = str23;
									num3 = (s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider)b4p.cul)) + 2.0;
									s4 = num3.ToString((IFormatProvider)b4p.cul);
									flag = true;
									goto label_207;
								}
								else if (str19 == "76")
								{
									this.__main_look();
									flag = true;
									goto label_207;
								}
								else if (str19 == "77")
								{
									if ((this.var__main_currentcounter == "" ? 0.0 : double.Parse(this.var__main_currentcounter, (IFormatProvider)b4p.cul)) >= 0.0)
									{
										num3 = (this.var__main_currentcounter == "" ? 0.0 : double.Parse(this.var__main_currentcounter, (IFormatProvider)b4p.cul)) - 1.0;
										this.var__main_currentcounter = num3.ToString((IFormatProvider)b4p.cul);
									}
									flag = true;
									goto label_207;
								}
								else if (str19 == "78")
								{
									this.__main_addtxtmsg(this.__main_trim(this.var__main_currentcounter) + " ");
									flag = true;
									goto label_207;
								}
								else if (str19 == "79")
								{
									string[] strArray12 = (string[])this.var__main_param;
									int index14 = s4 == "" ? 0 : (int)double.Parse(s4, (IFormatProvider)b4p.cul);
									string str20;
									this.var__main_currentcounter = (str20 = strArray12[index14]) == null ? "" : str20;
									num3 = (s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider)b4p.cul)) + 1.0;
									s4 = num3.ToString((IFormatProvider)b4p.cul);
									flag = true;
									goto label_207;
								}
								else if (str19 == "80")
								{
									string str20 = this.var__main_playerroom;
									this.var__main_playerroom = this.var__main_currentsavedroom;
									this.var__main_currentsavedroom = str20;
									flag = true;
									goto label_207;
								}
								else if (str19 == "81")
								{
									string str20 = this.var__main_currentcounter;
									string[] strArray12 = (string[])this.var__main_counters;
									string[] strArray13 = (string[])this.var__main_param;
									int index14 = s4 == "" ? 0 : (int)double.Parse(s4, (IFormatProvider)b4p.cul);
									string str21;
									int index15 = (str21 = strArray13[index14]) == null ? 0 : (int)double.Parse(str21 == "" ? "0" : str21, (IFormatProvider)b4p.cul);
									string str22;
									this.var__main_currentcounter = (str22 = strArray12[index15]) == null ? "" : str22;
									string[] strArray14 = (string[])this.var__main_counters;
									string[] strArray15 = (string[])this.var__main_param;
									int index16 = s4 == "" ? 0 : (int)double.Parse(s4, (IFormatProvider)b4p.cul);
									string str23;
									int index17 = (str23 = strArray15[index16]) == null ? 0 : (int)double.Parse(str23 == "" ? "0" : str23, (IFormatProvider)b4p.cul);
									string str24 = str20;
									strArray14[index17] = str24;
									num3 = (s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider)b4p.cul)) + 1.0;
									s4 = num3.ToString((IFormatProvider)b4p.cul);
									flag = true;
									goto label_207;
								}
								else if (str19 == "82")
								{
									double num6 = this.var__main_currentcounter == "" ? 0.0 : double.Parse(this.var__main_currentcounter, (IFormatProvider)b4p.cul);
									string[] strArray12 = (string[])this.var__main_param;
									int index14 = s4 == "" ? 0 : (int)double.Parse(s4, (IFormatProvider)b4p.cul);
									string str20;
									double num7 = (str20 = strArray12[index14]) == null ? 0.0 : double.Parse(str20 == "" ? "0" : str20, (IFormatProvider)b4p.cul);
									num3 = num6 + num7;
									this.var__main_currentcounter = num3.ToString((IFormatProvider)b4p.cul);
									num3 = (s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider)b4p.cul)) + 1.0;
									s4 = num3.ToString((IFormatProvider)b4p.cul);
									flag = true;
									goto label_207;
								}
								else if (str19 == "83")
								{
									double num6 = this.var__main_currentcounter == "" ? 0.0 : double.Parse(this.var__main_currentcounter, (IFormatProvider)b4p.cul);
									string[] strArray12 = (string[])this.var__main_param;
									int index14 = s4 == "" ? 0 : (int)double.Parse(s4, (IFormatProvider)b4p.cul);
									string str20;
									double num7 = (str20 = strArray12[index14]) == null ? 0.0 : double.Parse(str20 == "" ? "0" : str20, (IFormatProvider)b4p.cul);
									num3 = num6 - num7;
									this.var__main_currentcounter = num3.ToString((IFormatProvider)b4p.cul);
									num3 = (s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider)b4p.cul)) + 1.0;
									s4 = num3.ToString((IFormatProvider)b4p.cul);
									if ((this.var__main_currentcounter == "" ? 0.0 : double.Parse(this.var__main_currentcounter, (IFormatProvider)b4p.cul)) < -1.0)
									{
										num3 = -1.0;
										this.var__main_currentcounter = num3.ToString((IFormatProvider)b4p.cul);
									}
									flag = true;
									goto label_207;
								}
								else if (str19 == "84")
								{
									this.__main_removebrfromtxtmsg();
									this.__main_addtxtmsg(this.__main_hx(this.var__main_nountext) + " ");
									flag = true;
									goto label_207;
								}
								else if (str19 == "85")
								{
									this.__main_removebrfromtxtmsg();
									this.__main_addtxtmsg(this.__main_hx(this.var__main_nountext) + "<br>");
									flag = true;
									goto label_207;
								}
								else if (str19 == "86")
								{
									this.__main_addtxtmsg("[br]");
									flag = true;
									goto label_207;
								}
								else if (str19 == "87")
								{
									string str20 = this.var__main_playerroom;
									string[] strArray12 = (string[])this.var__main_roomsaved;
									string[] strArray13 = (string[])this.var__main_param;
									int index14 = s4 == "" ? 0 : (int)double.Parse(s4, (IFormatProvider)b4p.cul);
									string str21;
									int index15 = (str21 = strArray13[index14]) == null ? 0 : (int)double.Parse(str21 == "" ? "0" : str21, (IFormatProvider)b4p.cul);
									string str22;
									this.var__main_playerroom = (str22 = strArray12[index15]) == null ? "" : str22;
									string[] strArray14 = (string[])this.var__main_roomsaved;
									string[] strArray15 = (string[])this.var__main_param;
									int index16 = s4 == "" ? 0 : (int)double.Parse(s4, (IFormatProvider)b4p.cul);
									string str23;
									int index17 = (str23 = strArray15[index16]) == null ? 0 : (int)double.Parse(str23 == "" ? "0" : str23, (IFormatProvider)b4p.cul);
									string str24 = str20;
									strArray14[index17] = str24;
									num3 = (s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider)b4p.cul)) + 1.0;
									s4 = num3.ToString((IFormatProvider)b4p.cul);
									flag = true;
									goto label_207;
								}
								else if (str19 == "88")
								{
									this.var__main_sleeping = "Y";
									if (!this.CompareEqual(this.var__main_txtlook + this.var__main_txtexits + this.var__main_txtmsg, this.var__main_lastrefresh))
										this.__main_refreshweb();
									string s3 = "1";
									double num6 = 12.0;
									double num7 = double.Parse(s3, (IFormatProvider)b4p.cul);
									while (num7 <= num6)
									{
										Thread.Sleep(100);
										Application.DoEvents();
										num3 = ++num7;
										str1 = num3.ToString((IFormatProvider)b4p.cul);
									}
									flag = true;
									goto label_207;
								}
								else if (str19 == "89")
								{
									num3 = (s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider)b4p.cul)) + 1.0;
									s4 = num3.ToString((IFormatProvider)b4p.cul);
									flag = true;
									goto label_207;
								}
								else if (!(str19 == ""))
								{
									string str20 = "Unknown action ";
									string[] strArray12 = (string[])this.var__main_act;
									int index14 = s5 == "" ? 0 : (int)double.Parse(s5, (IFormatProvider)b4p.cul);
									string str21;
									string str22 = (str21 = strArray12[index14]) == null ? "" : str21;
									string str23 = "<br>";
									this.__main_addtxtmsg(str20 + str22 + str23);
									num3 = (s4 == "" ? 0.0 : double.Parse(s4, (IFormatProvider)b4p.cul)) + 1.0;
									s4 = num3.ToString((IFormatProvider)b4p.cul);
									flag = true;
									goto label_207;
								}
							}
							str6 = "0";
							flag = true;
label_207:
							if (!flag && str19 == "")
								str19 = "0";
							else
								goto label_209;
						}
					}
label_89:
					string[] strArray20 = (string[])this.var__main_act;
					int index22 = s5 == "" ? 0 : (int)double.Parse(s5, (IFormatProvider)b4p.cul);
					string str29;
					string s6 = (str29 = strArray20[index22]) == null ? "" : str29;
					string[] strArray21 = (string[])this.var__main_act;
					int index23 = s5 == "" ? 0 : (int)double.Parse(s5, (IFormatProvider)b4p.cul);
					string str30;
					if (((str30 = strArray21[index23]) == null ? 0.0 : double.Parse(str30 == "" ? "0" : str30, (IFormatProvider)b4p.cul)) >= 102.0)
					{
						num3 = (s6 == "" ? 0.0 : double.Parse(s6, (IFormatProvider)b4p.cul)) - 50.0;
						s6 = num3.ToString((IFormatProvider)b4p.cul);
					}
					if ((this.LCompareEqual(this.var__main_word1, "DROP") || this.LCompareEqual(this.var__main_word1, "GET")) && this.LCompareEqual(this.var__main_word2, "ALL"))
					{
						string[] strArray10 = (string[])this.var__main_xmessages;
						int index2 = s6 == "" ? 0 : (int)double.Parse(s6, (IFormatProvider)b4p.cul);
						string str8;
						if (this.__main_trim((str8 = strArray10[index2]) == null ? "" : str8) == "O.K.")
						{
							Application.DoEvents();
							goto label_209;
						}
					}
					if ((str17 == "" ? 0.0 : double.Parse(str17, (IFormatProvider)b4p.cul)) > 0.0 && this.var__main_txtmsg.ToUpper(b4p.cul) != "OK<BR>" && this.var__main_txtmsg.ToUpper(b4p.cul) != "O.K.<BR>")
					{
						Other other1 = this.Other;
						string[] strArray10 = (string[])this.var__main_xmessages;
						int index2 = s6 == "" ? 0 : (int)double.Parse(s6, (IFormatProvider)b4p.cul);
						string str8;
						string original1 = (str8 = strArray10[index2]) == null ? "" : str8;
						int start1 = 0;
						int count1 = 1;
						if ((double)other1.SubString(original1, start1, count1)[0] >= (double)"a"[0])
						{
							Other other2 = this.Other;
							string[] strArray12 = (string[])this.var__main_xmessages;
							int index14 = s6 == "" ? 0 : (int)double.Parse(s6, (IFormatProvider)b4p.cul);
							string str19;
							string original2 = (str19 = strArray12[index14]) == null ? "" : str19;
							int start2 = 0;
							int count2 = 1;
							if ((double)other2.SubString(original2, start2, count2)[0] <= (double)"z"[0])
								goto label_100;
						}
						Other other3 = this.Other;
						string[] strArray13 = (string[])this.var__main_xmessages;
						int index15 = s6 == "" ? 0 : (int)double.Parse(s6, (IFormatProvider)b4p.cul);
						string str20;
						string original3 = (str20 = strArray13[index15]) == null ? "" : str20;
						int start3 = 0;
						int count3 = 1;
						if ((double)other3.SubString(original3, start3, count3)[0] >= (double)"0"[0])
						{
							Other other2 = this.Other;
							string[] strArray12 = (string[])this.var__main_xmessages;
							int index14 = s6 == "" ? 0 : (int)double.Parse(s6, (IFormatProvider)b4p.cul);
							string str19;
							string original2 = (str19 = strArray12[index14]) == null ? "" : str19;
							int start2 = 0;
							int count2 = 1;
							if ((double)other2.SubString(original2, start2, count2)[0] <= (double)"9"[0])
								goto label_100;
						}
						Other other4 = this.Other;
						string[] strArray14 = (string[])this.var__main_xmessages;
						int index16 = s6 == "" ? 0 : (int)double.Parse(s6, (IFormatProvider)b4p.cul);
						string str21;
						string original4 = (str21 = strArray14[index16]) == null ? "" : str21;
						int start4 = 0;
						int count4 = 1;
						if ((double)other4.SubString(original4, start4, count4)[0] < (double)","[0])
							goto label_102;
label_100:
						if (this.Other.SubString(this.var__main_txtmsg, (int)((double)this.var__main_txtmsg.Length - 4.0), 4).ToLower(b4p.cul) == "<br>")
						{
							string var__main_left_mystr = this.var__main_txtmsg;
							num3 = (double)this.var__main_txtmsg.Length - 4.0;
							string string1 = num3.ToString((IFormatProvider)b4p.cul);
							this.var__main_txtmsg = this.__main_xleft(var__main_left_mystr, string1) + " ";
						}
					}
label_102:
					if (this.__main_right(this.var__main_txtmsg, "4").ToLower(b4p.cul) == "<br>" && (double)this.var__main_txtmsg.Length > 4.0)
					{
						string var__main_left_mystr = this.var__main_txtmsg;
						num3 = (double)this.var__main_txtmsg.Length - 4.0;
						string string1 = num3.ToString((IFormatProvider)b4p.cul);
						this.var__main_txtmsg = this.__main_xleft(var__main_left_mystr, string1);
						if (((double)this.__main_right(this.var__main_txtmsg, "1")[0] < (double)"a"[0] || (double)this.__main_right(this.var__main_txtmsg, "1")[0] > (double)"z"[0]) && ((double)this.__main_right(this.var__main_txtmsg, "1")[0] < (double)"A"[0] || (double)this.__main_right(this.var__main_txtmsg, "1")[0] > (double)"Z"[0]))
						{
							int num6 = (int)this.__main_right(this.var__main_txtmsg, "1")[0];
							string string2 = num6.ToString((IFormatProvider)b4p.cul);
							num6 = (int)"'"[0];
							string string7 = num6.ToString((IFormatProvider)b4p.cul);
							if (!(string2 == string7))
							{
								this.var__main_txtmsg = this.var__main_txtmsg + "<br>";
								goto label_107;
							}
						}
						this.var__main_txtmsg = this.var__main_txtmsg + ".<br>";
					}
label_107:
					string[] strArray22 = (string[])this.var__main_xmessages;
					int index24 = s6 == "" ? 0 : (int)double.Parse(s6, (IFormatProvider)b4p.cul);
					string str31;
					this.__main_addtxtmsg(this.__main_hx((str31 = strArray22[index24]) == null ? "" : str31) + "<br>");
					num3 = (str17 == "" ? 0.0 : double.Parse(str17, (IFormatProvider)b4p.cul)) + 1.0;
					str17 = num3.ToString((IFormatProvider)b4p.cul);
					this.var__main_txtmsg = this.var__main_txtmsg.Replace("  ", " ");
					if (this.LCompareEqual(str17, "1"))
						this.var__main_txtmsg = this.Other.SubString(this.var__main_txtmsg, 0, 1).ToUpper(b4p.cul) + this.Other.SubString(this.var__main_txtmsg, 1, (int)((double)this.var__main_txtmsg.Length - 1.0));
label_209:
					num3 = ++num5;
					s5 = num3.ToString((IFormatProvider)b4p.cul);
				}
				return "true";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_performactionline");
				return "";
			}
		}

		private string __main_buto_click()
		{
			try
			{
				if (this.LCompareEqual(this.var__main_abcison, "Y"))
					this.__main_insertchar("O");
				else
					this.__main_insertchar("9");
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_buto_click");
				return "";
			}
		}

		private string __main_butv_click()
		{
			try
			{
				this.__main_insertchar("V");
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_butv_click");
				return "";
			}
		}

		private string __main_autoactions()
		{
			try
			{
				string str1 = "0";
				double num1 = this.var__main_numactions == "" ? 0.0 : double.Parse(this.var__main_numactions, (IFormatProvider)b4p.cul);
				for (double num2 = double.Parse(str1, (IFormatProvider)b4p.cul); num2 <= num1; str1 = (++num2).ToString((IFormatProvider)b4p.cul))
				{
					string[] strArray1 = (string[])this.var__main_xactionverb;
					int index1 = str1 == "" ? 0 : (int)double.Parse(str1, (IFormatProvider)b4p.cul);
					string str2;
					if (this.LCompareEqual((str2 = strArray1[index1]) == null ? "" : str2, "0"))
					{
						string[] strArray2 = (string[])this.var__main_xactionnoun;
						int index2 = str1 == "" ? 0 : (int)double.Parse(str1, (IFormatProvider)b4p.cul);
						string str3;
						if (this.LCompareEqual((str3 = strArray2[index2]) == null ? "" : str3, "0"))
							goto label_5;
					}
					this.var__main_continuation = "false";
label_5:
					string[] strArray3 = (string[])this.var__main_xactionverb;
					int index3 = str1 == "" ? 0 : (int)double.Parse(str1, (IFormatProvider)b4p.cul);
					string str4;
					if (this.LCompareEqual((str4 = strArray3[index3]) == null ? "" : str4, "0"))
					{
						string[] strArray2 = (string[])this.var__main_xactionnoun;
						int index2 = str1 == "" ? 0 : (int)double.Parse(str1, (IFormatProvider)b4p.cul);
						string str3;
						if (this.__main_randompercent((str3 = strArray2[index2]) == null ? "" : str3) == "true")
							goto label_8;
					}
					if (!this.LCompareEqual(this.var__main_continuation, "true"))
						continue;
label_8:
					this.__main_performactionline(str1);
				}
				this.var__main_continuation = "false";
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_autoactions");
				return "";
			}
		}

		private string __main_look()
		{
			try
			{
				this.__main_addtxtlook("");
				this.__main_addtxtexits("");
				if (this.LCompareEqual(this.var__main_initial_load, "1") && this.LCompareEqual(this.var__main_done_intro_look, "Y"))
					return "";
				if (this.LCompareEqual(this.var__main_initial_load, "1"))
					this.var__main_done_intro_look = "Y";
				this.var__main_myroomtext = this.var__main_html_look_start;
				if (this.__main_isdark() == "true")
				{
					this.__main_sendlook(this.var__main_myroomtext + "<b><font color='" + this.var__main_html_room_text + "'>It's too dark to see!</font></b>" + this.var__main_html_look_end);
					this.__main_sendlook(this.var__main_html_line);
				}
				else
				{
					this.var__main_myroomtext = this.var__main_myroomtext + "<b><font color='" + this.var__main_html_room_text + "'>";
					string[] strArray1 = (string[])this.var__main_xroomtext;
					int index1 = this.var__main_playerroom == "" ? 0 : (int)double.Parse(this.var__main_playerroom, (IFormatProvider)b4p.cul);
					string str1;
					if (this.__main_xleft((str1 = strArray1[index1]) == null ? "" : str1, "1") == "*")
					{
						string str2 = this.var__main_myroomtext;
						Other other = this.Other;
						string[] strArray2 = (string[])this.var__main_xroomtext;
						int index2 = this.var__main_playerroom == "" ? 0 : (int)double.Parse(this.var__main_playerroom, (IFormatProvider)b4p.cul);
						string str3;
						string original = (str3 = strArray2[index2]) == null ? "" : str3;
						int start = 1;
						string[] strArray3 = (string[])this.var__main_xroomtext;
						int index3 = this.var__main_playerroom == "" ? 0 : (int)double.Parse(this.var__main_playerroom, (IFormatProvider)b4p.cul);
						string str4;
						int count = (int)((double)((str4 = strArray3[index3]) == null ? "" : str4).Length - 1.0);
						string str5 = other.SubString(original, start, count);
						this.var__main_myroomtext = str2 + str5;
					}
					else
					{
						string[] strArray2 = (string[])this.var__main_xroomtext;
						int index2 = this.var__main_playerroom == "" ? 0 : (int)double.Parse(this.var__main_playerroom, (IFormatProvider)b4p.cul);
						string str2;
						if (!(this.__main_xleft((str2 = strArray2[index2]) == null ? "" : str2, "1").ToUpper(b4p.cul) == "A"))
						{
							string[] strArray3 = (string[])this.var__main_xroomtext;
							int index3 = this.var__main_playerroom == "" ? 0 : (int)double.Parse(this.var__main_playerroom, (IFormatProvider)b4p.cul);
							string str3;
							if (!(this.__main_xleft((str3 = strArray3[index3]) == null ? "" : str3, "1").ToUpper(b4p.cul) == "E"))
							{
								string[] strArray4 = (string[])this.var__main_xroomtext;
								int index4 = this.var__main_playerroom == "" ? 0 : (int)double.Parse(this.var__main_playerroom, (IFormatProvider)b4p.cul);
								string str4;
								if (!(this.__main_xleft((str4 = strArray4[index4]) == null ? "" : str4, "1").ToUpper(b4p.cul) == "I"))
								{
									string[] strArray5 = (string[])this.var__main_xroomtext;
									int index5 = this.var__main_playerroom == "" ? 0 : (int)double.Parse(this.var__main_playerroom, (IFormatProvider)b4p.cul);
									string str5;
									if (!(this.__main_xleft((str5 = strArray5[index5]) == null ? "" : str5, "1").ToUpper(b4p.cul) == "O"))
									{
										string[] strArray6 = (string[])this.var__main_xroomtext;
										int index6 = this.var__main_playerroom == "" ? 0 : (int)double.Parse(this.var__main_playerroom, (IFormatProvider)b4p.cul);
										string str6;
										if (!(this.__main_xleft((str6 = strArray6[index6]) == null ? "" : str6, "1").ToUpper(b4p.cul) == "U"))
										{
											string str7 = this.var__main_myroomtext;
											string str8 = "I'm in a ";
											string[] strArray7 = (string[])this.var__main_xroomtext;
											int index7 = this.var__main_playerroom == "" ? 0 : (int)double.Parse(this.var__main_playerroom, (IFormatProvider)b4p.cul);
											string str9;
											string str10 = (str9 = strArray7[index7]) == null ? "" : str9;
											this.var__main_myroomtext = str7 + str8 + str10;
											goto label_16;
										}
									}
								}
							}
						}
						string str11 = this.var__main_myroomtext;
						string str12 = "I'm in an ";
						string[] strArray8 = (string[])this.var__main_xroomtext;
						int index8 = this.var__main_playerroom == "" ? 0 : (int)double.Parse(this.var__main_playerroom, (IFormatProvider)b4p.cul);
						string str13;
						string str14 = (str13 = strArray8[index8]) == null ? "" : str13;
						this.var__main_myroomtext = str11 + str12 + str14;
					}
label_16:
					this.var__main_myroomtext = this.__main_trim(this.var__main_myroomtext);
					if (this.__main_right(this.var__main_myroomtext, "1") != "." && this.__main_right(this.var__main_myroomtext, "1") != "!" && this.__main_right(this.var__main_myroomtext, "1") != "?")
						this.var__main_myroomtext = this.var__main_myroomtext + ".";
					this.var__main_myroomtext = this.var__main_myroomtext + "</font></b></font>";
					this.var__main_myroomtext = this.var__main_myroomtext + "<br>";
					this.var__main_myroomtext = this.var__main_myroomtext + this.var__main_html_lk_prompt_start + this.__main_hx("I can see: ") + this.var__main_html_prompt_end;
					string str15 = "";
					string s1 = "0";
					double num1 = this.var__main_numitems == "" ? 0.0 : double.Parse(this.var__main_numitems, (IFormatProvider)b4p.cul);
					for (double num2 = double.Parse(s1, (IFormatProvider)b4p.cul); num2 <= num1; s1 = (++num2).ToString((IFormatProvider)b4p.cul))
					{
						string[] strArray2 = (string[])this.var__main_xitemloc;
						int index2 = s1 == "" ? 0 : (int)double.Parse(s1, (IFormatProvider)b4p.cul);
						string str2;
						if (this.CompareEqual((str2 = strArray2[index2]) == null ? "" : str2, this.var__main_playerroom))
						{
							string[] strArray3 = (string[])this.var__main_xitemautoget;
							int index3 = s1 == "" ? 0 : (int)double.Parse(s1, (IFormatProvider)b4p.cul);
							string str3;
							if ((double)((str3 = strArray3[index3]) == null ? "" : str3).Length > 0.0)
							{
								if (this.LCompareEqual(this.var__main_optionslinkson, "Y") && !this.LCompareEqual(this.var__main_sleeping, "Y"))
								{
									string[] strArray4 = new string[16]
						{
						  str15 + "<a " + this.var__main_aname + "='" + this.var__main_hyper + "X" + s1 + "i'>",
						  "<font face='",
						  this.var__main_fontface,
						  "' size='",
						  this.var__main_fontsize,
						  "' color='",
						  this.var__main_html_look_hyperlink,
						  "'>",
						  null,
						  null,
						  null,
						  null,
						  null,
						  null,
						  null,
						  null
						};
									string[] strArray5 = strArray4;
									int index4 = 8;
									string[] strArray6 = (string[])this.var__main_xitemtext;
									int index5 = s1 == "" ? 0 : (int)double.Parse(s1, (IFormatProvider)b4p.cul);
									string str4;
									string str5 = this.__main_hx(this.__main_treasurecheck((str4 = strArray6[index5]) == null ? "" : str4));
									strArray5[index4] = str5;
									strArray4[9] = "</font></a><font face='";
									strArray4[10] = this.var__main_fontface;
									strArray4[11] = "' size='";
									strArray4[12] = this.var__main_fontsize;
									strArray4[13] = "' color='";
									strArray4[14] = this.var__main_html_look_text;
									strArray4[15] = "'>. </font>";
									str15 = string.Concat(strArray4);
								}
								else
								{
									string[] strArray4 = new string[10]
						{
						  str15,
						  "<font face='",
						  this.var__main_fontface,
						  "' size='",
						  this.var__main_fontsize,
						  "' color='",
						  this.var__main_html_look_text,
						  "'>",
						  null,
						  null
						};
									string[] strArray5 = strArray4;
									int index4 = 8;
									string[] strArray6 = (string[])this.var__main_xitemtext;
									int index5 = s1 == "" ? 0 : (int)double.Parse(s1, (IFormatProvider)b4p.cul);
									string str4;
									string str5 = this.__main_hx(this.__main_treasurecheck((str4 = strArray6[index5]) == null ? "" : str4));
									strArray5[index4] = str5;
									strArray4[9] = ". </font>";
									str15 = string.Concat(strArray4);
								}
							}
							else
							{
								string[] strArray4 = new string[10]
					 {
						str15,
						"<font face='",
						this.var__main_fontface,
						"' size='",
						this.var__main_fontsize,
						"' color='",
						this.var__main_html_look_text,
						"'>",
						null,
						null
					 };
								string[] strArray5 = strArray4;
								int index4 = 8;
								string[] strArray6 = (string[])this.var__main_xitemtext;
								int index5 = s1 == "" ? 0 : (int)double.Parse(s1, (IFormatProvider)b4p.cul);
								string str4;
								string str5 = this.__main_hx(this.__main_treasurecheck((str4 = strArray6[index5]) == null ? "" : str4));
								strArray5[index4] = str5;
								strArray4[9] = ". </font>";
								str15 = string.Concat(strArray4);
							}
						}
					}
					if (this.LCompareEqual(str15, ""))
						this.var__main_myroomtext = this.var__main_myroomtext + "<font face='" + this.var__main_fontface + "' size='" + this.var__main_fontsize + "' color='" + this.var__main_html_look_text + "'> nothing special.</font><br>";
					else
						this.var__main_myroomtext = this.var__main_myroomtext + this.__main_xleft(str15, ((double)str15.Length - 1.0).ToString((IFormatProvider)b4p.cul)) + "<br>";
					this.var__main_myroomtext = this.var__main_myroomtext + this.var__main_html_look_end;
					this.__main_sendlook(this.var__main_myroomtext);
					this.var__main_myroomexits = this.var__main_html_ex_prompt_start + this.__main_hx("Obvious exits: ") + this.var__main_html_prompt_end;
					string lSide = "";
					string s2 = "0";
					double num3 = 1.0;
					for (double num2 = double.Parse(s2, (IFormatProvider)b4p.cul); num2 <= num3; s2 = (++num2).ToString((IFormatProvider)b4p.cul))
					{
						string[,] strArray2 = (string[,])this.var__main_xroomexit;
						int index2 = this.var__main_playerroom == "" ? 0 : (int)double.Parse(this.var__main_playerroom, (IFormatProvider)b4p.cul);
						int index3 = s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul);
						string str2;
						if (!this.LCompareEqual((str2 = strArray2[index2, index3]) == null ? "" : str2, "0"))
						{
							if (this.LCompareEqual(this.var__main_optionslinkson, "Y") && !this.LCompareEqual(this.var__main_sleeping, "Y"))
							{
								string[] strArray3 = new string[11];
								strArray3[0] = lSide;
								strArray3[1] = "<a ";
								strArray3[2] = this.var__main_aname;
								strArray3[3] = "='";
								strArray3[4] = this.var__main_hyper;
								string[] strArray4 = strArray3;
								int index4 = 5;
								Other other = this.Other;
								string[] strArray5 = (string[])this.var__main_exitnames;
								int index5 = s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul);
								string str3;
								string original = (str3 = strArray5[index5]) == null ? "" : str3;
								int start = 0;
								int count = 1;
								string upper = other.SubString(original, start, count).ToUpper(b4p.cul);
								strArray4[index4] = upper;
								strArray3[6] = "x'><font color='";
								strArray3[7] = this.var__main_html_exit_hyperlink;
								strArray3[8] = "'>";
								string[] strArray6 = strArray3;
								int index6 = 9;
								string[] strArray7 = (string[])this.var__main_exitnames;
								int index7 = s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul);
								string str4;
								string str5 = this.__main_hx((str4 = strArray7[index7]) == null ? "" : str4);
								strArray6[index6] = str5;
								strArray3[10] = "</font></a>, ";
								lSide = string.Concat(strArray3);
							}
							else
							{
								string[] strArray3 = new string[6]
					 {
						lSide,
						"<font color='",
						this.var__main_html_exit_text,
						"'>",
						null,
						null
					 };
								string[] strArray4 = strArray3;
								int index4 = 4;
								string[] strArray5 = (string[])this.var__main_exitnames;
								int index5 = s2 == "" ? 0 : (int)double.Parse(s2, (IFormatProvider)b4p.cul);
								string str3;
								string str4 = this.__main_hx((str3 = strArray5[index5]) == null ? "" : str3);
								strArray4[index4] = str4;
								strArray3[5] = "</font>, ";
								lSide = string.Concat(strArray3);
							}
						}
					}
					string s3 = "3";
					double num4 = -1.0;
					double num5 = 2.0;
					double num6 = double.Parse(s3, (IFormatProvider)b4p.cul);
					while ((num4 > 0.0 ? (num6 <= num5 ? 1 : 0) : (num6 >= num5 ? 1 : 0)) != 0)
					{
						string[,] strArray2 = (string[,])this.var__main_xroomexit;
						int index2 = this.var__main_playerroom == "" ? 0 : (int)double.Parse(this.var__main_playerroom, (IFormatProvider)b4p.cul);
						int index3 = s3 == "" ? 0 : (int)double.Parse(s3, (IFormatProvider)b4p.cul);
						string str2;
						if (!this.LCompareEqual((str2 = strArray2[index2, index3]) == null ? "" : str2, "0"))
						{
							if (this.LCompareEqual(this.var__main_optionslinkson, "Y") && !this.LCompareEqual(this.var__main_sleeping, "Y"))
							{
								string[] strArray3 = new string[11];
								strArray3[0] = lSide;
								strArray3[1] = "<a ";
								strArray3[2] = this.var__main_aname;
								strArray3[3] = "='";
								strArray3[4] = this.var__main_hyper;
								string[] strArray4 = strArray3;
								int index4 = 5;
								Other other = this.Other;
								string[] strArray5 = (string[])this.var__main_exitnames;
								int index5 = s3 == "" ? 0 : (int)double.Parse(s3, (IFormatProvider)b4p.cul);
								string str3;
								string original = (str3 = strArray5[index5]) == null ? "" : str3;
								int start = 0;
								int count = 1;
								string upper = other.SubString(original, start, count).ToUpper(b4p.cul);
								strArray4[index4] = upper;
								strArray3[6] = "x'><font color='";
								strArray3[7] = this.var__main_html_exit_hyperlink;
								strArray3[8] = "'>";
								string[] strArray6 = strArray3;
								int index6 = 9;
								string[] strArray7 = (string[])this.var__main_exitnames;
								int index7 = s3 == "" ? 0 : (int)double.Parse(s3, (IFormatProvider)b4p.cul);
								string str4;
								string str5 = this.__main_hx((str4 = strArray7[index7]) == null ? "" : str4);
								strArray6[index6] = str5;
								strArray3[10] = "</font></a>, ";
								lSide = string.Concat(strArray3);
							}
							else
							{
								string[] strArray3 = new string[6]
					 {
						lSide,
						"<font color='",
						this.var__main_html_exit_text,
						"'>",
						null,
						null
					 };
								string[] strArray4 = strArray3;
								int index4 = 4;
								string[] strArray5 = (string[])this.var__main_exitnames;
								int index5 = s3 == "" ? 0 : (int)double.Parse(s3, (IFormatProvider)b4p.cul);
								string str3;
								string str4 = this.__main_hx((str3 = strArray5[index5]) == null ? "" : str3);
								strArray4[index4] = str4;
								strArray3[5] = "</font>, ";
								lSide = string.Concat(strArray3);
							}
						}
						s3 = (num6 += num4).ToString((IFormatProvider)b4p.cul);
					}
					string s4 = "4";
					double num7 = 5.0;
					for (double num2 = double.Parse(s4, (IFormatProvider)b4p.cul); num2 <= num7; s4 = (++num2).ToString((IFormatProvider)b4p.cul))
					{
						string[,] strArray2 = (string[,])this.var__main_xroomexit;
						int index2 = this.var__main_playerroom == "" ? 0 : (int)double.Parse(this.var__main_playerroom, (IFormatProvider)b4p.cul);
						int index3 = s4 == "" ? 0 : (int)double.Parse(s4, (IFormatProvider)b4p.cul);
						string str2;
						if (!this.LCompareEqual((str2 = strArray2[index2, index3]) == null ? "" : str2, "0"))
						{
							if (this.LCompareEqual(this.var__main_optionslinkson, "Y") && !this.LCompareEqual(this.var__main_sleeping, "Y"))
							{
								string[] strArray3 = new string[11];
								strArray3[0] = lSide;
								strArray3[1] = "<a ";
								strArray3[2] = this.var__main_aname;
								strArray3[3] = "='";
								strArray3[4] = this.var__main_hyper;
								string[] strArray4 = strArray3;
								int index4 = 5;
								Other other = this.Other;
								string[] strArray5 = (string[])this.var__main_exitnames;
								int index5 = s4 == "" ? 0 : (int)double.Parse(s4, (IFormatProvider)b4p.cul);
								string str3;
								string original = (str3 = strArray5[index5]) == null ? "" : str3;
								int start = 0;
								int count = 1;
								string upper = other.SubString(original, start, count).ToUpper(b4p.cul);
								strArray4[index4] = upper;
								strArray3[6] = "x'><font color='";
								strArray3[7] = this.var__main_html_exit_hyperlink;
								strArray3[8] = "'>";
								string[] strArray6 = strArray3;
								int index6 = 9;
								string[] strArray7 = (string[])this.var__main_exitnames;
								int index7 = s4 == "" ? 0 : (int)double.Parse(s4, (IFormatProvider)b4p.cul);
								string str4;
								string str5 = this.__main_hx((str4 = strArray7[index7]) == null ? "" : str4);
								strArray6[index6] = str5;
								strArray3[10] = "</font></a>, ";
								lSide = string.Concat(strArray3);
							}
							else
							{
								string[] strArray3 = new string[6]
					 {
						lSide,
						"<font color='",
						this.var__main_html_exit_text,
						"'>",
						null,
						null
					 };
								string[] strArray4 = strArray3;
								int index4 = 4;
								string[] strArray5 = (string[])this.var__main_exitnames;
								int index5 = s4 == "" ? 0 : (int)double.Parse(s4, (IFormatProvider)b4p.cul);
								string str3;
								string str4 = this.__main_hx((str3 = strArray5[index5]) == null ? "" : str3);
								strArray4[index4] = str4;
								strArray3[5] = "</font>, ";
								lSide = string.Concat(strArray3);
							}
						}
					}
					double num8;
					if (this.LCompareEqual(lSide, ""))
					{
						this.var__main_myroomexits = this.var__main_myroomexits + this.__main_hx("None.") + "<br>";
					}
					else
					{
						string str2 = this.var__main_myroomexits;
						string var__main_left_mystr = lSide;
						num8 = (double)lSide.Length - 2.0;
						string @string = num8.ToString((IFormatProvider)b4p.cul);
						string str3 = this.__main_xleft(var__main_left_mystr, @string);
						string str4 = this.__main_hx(".");
						string str5 = "<br>";
						this.var__main_myroomexits = str2 + str3 + str4 + str5;
					}
					this.var__main_myroomexits = this.var__main_html_exit_start + this.var__main_myroomexits + this.var__main_html_exit_end;
					this.__main_addtxtexits(this.var__main_myroomexits);
					this.var__main_llplayerroom = this.var__main_playerroom;
					string s5 = "0";
					double num9 = this.var__main_numitems == "" ? 0.0 : double.Parse(this.var__main_numitems, (IFormatProvider)b4p.cul);
					double num10 = double.Parse(s5, (IFormatProvider)b4p.cul);
					while (num10 <= num9)
					{
						string[] strArray2 = (string[])this.var__main_llitemloc;
						int index2 = s5 == "" ? 0 : (int)double.Parse(s5, (IFormatProvider)b4p.cul);
						string[] strArray3 = (string[])this.var__main_xitemloc;
						int index3 = s5 == "" ? 0 : (int)double.Parse(s5, (IFormatProvider)b4p.cul);
						string str2;
						string str3 = (str2 = strArray3[index3]) == null ? "" : str2;
						strArray2[index2] = str3;
						num8 = ++num10;
						s5 = num8.ToString((IFormatProvider)b4p.cul);
					}
					this.var__main_lldark = this.__main_isdark();
					this.var__main_llclear = "false";
				}
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_look");
				return "";
			}
		}

		private string __main_webby_navigating()
		{
			try
			{
				if (this.LCompareEqual(this.var__main_cancel, "true"))
				{
					this.__main_webby.CancelNavigate = bool.Parse("true".ToLower(b4p.cul));
					if (this.__main_webby.NavigatingURL == this.var__main_hyper.ToUpper(b4p.cul) || this.__main_webby.NavigatingURL == "")
					{
						Application.DoEvents();
					}
					else
					{
						if (this.__main_right(this.__main_webby.NavigatingURL, "1") == "x")
							this.__main_mycmd.Text = this.Other.SubString(this.__main_webby.NavigatingURL, (int)(double)this.var__main_hyper.Length, (int)((double)this.__main_webby.NavigatingURL.Length - ((double)this.var__main_hyper.Length + 1.0)));
						if (this.__main_right(this.__main_webby.NavigatingURL, "1") == "i")
						{
							if (this.__main_trim(this.__main_mycmd.Text) == "")
							{
								this.var__main_linkget = (0.0 + double.Parse(this.Other.SubString(this.__main_webby.NavigatingURL, (int)((double)this.var__main_hyper.Length + 1.0), (int)((double)this.__main_webby.NavigatingURL.Length - ((double)this.var__main_hyper.Length + 2.0))), (IFormatProvider)b4p.cul)).ToString((IFormatProvider)b4p.cul);
								CEnhancedTextBox cenhancedTextBox = this.__main_mycmd;
								string str1 = "GET ";
								string[] strArray = (string[])this.var__main_xitemautoget;
								int index = this.var__main_linkget == "" ? 0 : (int)double.Parse(this.var__main_linkget, (IFormatProvider)b4p.cul);
								string str2;
								string str3 = (str2 = strArray[index]) == null ? "" : str2;
								string str4 = str1 + str3;
								cenhancedTextBox.Text = str4;
							}
							else
							{
								this.var__main_linkget = (0.0 + double.Parse(this.Other.SubString(this.__main_webby.NavigatingURL, (int)((double)this.var__main_hyper.Length + 1.0), (int)((double)this.__main_webby.NavigatingURL.Length - ((double)this.var__main_hyper.Length + 2.0))), (IFormatProvider)b4p.cul)).ToString((IFormatProvider)b4p.cul);
								CEnhancedTextBox cenhancedTextBox = this.__main_mycmd;
								string str1 = this.__main_trim(this.__main_mycmd.Text);
								string str2 = " ";
								string[] strArray = (string[])this.var__main_xitemautoget;
								int index = this.var__main_linkget == "" ? 0 : (int)double.Parse(this.var__main_linkget, (IFormatProvider)b4p.cul);
								string str3;
								string str4 = (str3 = strArray[index]) == null ? "" : str3;
								string str5 = str1 + str2 + str4;
								cenhancedTextBox.Text = str5;
							}
						}
						if (this.__main_right(this.__main_webby.NavigatingURL, "1") == "c")
						{
							if (this.__main_trim(this.__main_mycmd.Text) == "")
							{
								this.var__main_linkdrop = (0.0 + double.Parse(this.Other.SubString(this.__main_webby.NavigatingURL, (int)((double)this.var__main_hyper.Length + 1.0), (int)((double)this.__main_webby.NavigatingURL.Length - ((double)this.var__main_hyper.Length + 2.0))), (IFormatProvider)b4p.cul)).ToString((IFormatProvider)b4p.cul);
								CEnhancedTextBox cenhancedTextBox = this.__main_mycmd;
								string str1 = "DROP ";
								string[] strArray = (string[])this.var__main_xitemautoget;
								int index = this.var__main_linkdrop == "" ? 0 : (int)double.Parse(this.var__main_linkdrop, (IFormatProvider)b4p.cul);
								string str2;
								string str3 = (str2 = strArray[index]) == null ? "" : str2;
								string str4 = str1 + str3;
								cenhancedTextBox.Text = str4;
							}
							else
							{
								this.var__main_linkdrop = (0.0 + double.Parse(this.Other.SubString(this.__main_webby.NavigatingURL, (int)((double)this.var__main_hyper.Length + 1.0), (int)((double)this.__main_webby.NavigatingURL.Length - ((double)this.var__main_hyper.Length + 2.0))), (IFormatProvider)b4p.cul)).ToString((IFormatProvider)b4p.cul);
								CEnhancedTextBox cenhancedTextBox = this.__main_mycmd;
								string str1 = this.__main_trim(this.__main_mycmd.Text);
								string str2 = " ";
								string[] strArray = (string[])this.var__main_xitemautoget;
								int index = this.var__main_linkdrop == "" ? 0 : (int)double.Parse(this.var__main_linkdrop, (IFormatProvider)b4p.cul);
								string str3;
								string str4 = this.__main_trim((str3 = strArray[index]) == null ? "" : str3);
								string str5 = str1 + str2 + str4;
								cenhancedTextBox.Text = str5;
							}
						}
						Application.DoEvents();
						this.__main_timer1.Enabled = bool.Parse("true".ToLower(b4p.cul));
					}
				}
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_webby_navigating");
				return "";
			}
		}

		private string __main_buts_click()
		{
			try
			{
				if (this.LCompareEqual(this.var__main_sleeping, "Y") && this.__main_mycmd.Text.ToUpper(b4p.cul) == "S")
					return "";
				if (this.__main_mycmd.Text.ToUpper(b4p.cul) == "S")
					this.__main_mycmd_keypress('\r'.ToString((IFormatProvider)b4p.cul));
				else
					this.__main_insertchar("S");
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_buts_click");
				return "";
			}
		}

		private string __main_xleft(string var__main_left_mystr, string var__main_left_length)
		{
			try
			{
				if (this.LCompareEqual(var__main_left_mystr, ""))
					return "";
				return this.Other.SubString(var__main_left_mystr, 0, var__main_left_length == "" ? 0 : (int)double.Parse(var__main_left_length, (IFormatProvider)b4p.cul));
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_xleft");
				return "";
			}
		}

		private string __main_butd_click()
		{
			try
			{
				if (this.LCompareEqual(this.var__main_sleeping, "Y") && this.__main_mycmd.Text.ToUpper(b4p.cul) == "D")
					return "";
				if (this.__main_mycmd.Text.ToUpper(b4p.cul) == "D")
					this.__main_mycmd_keypress('\r'.ToString((IFormatProvider)b4p.cul));
				else
					this.__main_insertchar("D");
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_butd_click");
				return "";
			}
		}

		private string __main_fadventure_close()
		{
			try
			{
				if (this.LCompareEqual(this.var__main_computerexit, "false") && ((int)MessageBox.Show("Exit current quest?\r\n\r\nAre you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider)b4p.cul) == "7")
					this.__main_fadventure.cancelClose = true;
				this.var__main_computerexit = "false";
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_fadventure_close");
				return "";
			}
		}

		private string __main_setflag(string var__main_myflag)
		{
			try
			{
				((string[])this.var__main_xbitflags)[var__main_myflag == "" ? 0 : (int)double.Parse(var__main_myflag, (IFormatProvider)b4p.cul)] = "1";
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_setflag");
				return "";
			}
		}

		private string __main_expandoptions()
		{
			try
			{
				this.__main_laboptfontsize.Top = 30;
				this.__main_laboptfontsize.Left = 20;
				this.__main_laboptfontsize.Width = 130;
				this.__main_laboptfontsize.Height = 40;
				this.__main_pdfontsize.Top = 26;
				this.__main_pdfontsize.Left = 148;
				this.__main_pdfontsize.Width = 100;
				this.__main_pdfontsize.Height = 44;
				this.__main_butapply.Top = 214;
				this.__main_butapply.Left = 352;
				this.__main_butapply.Width = 110;
				this.__main_butapply.Height = 50;
				this.__main_labopttheme.Top = 90;
				this.__main_labopttheme.Left = 20;
				this.__main_labopttheme.Width = 100;
				this.__main_labopttheme.Height = 40;
				this.__main_pdtheme.Top = 88;
				this.__main_pdtheme.Left = 150;
				this.__main_pdtheme.Width = 310;
				this.__main_pdtheme.Height = 42;
				this.__main_laboptlink.Top = 148;
				this.__main_laboptlink.Left = 20;
				this.__main_laboptlink.Width = 130;
				this.__main_laboptlink.Height = 40;
				this.__main_pdlinks.Top = 148;
				this.__main_pdlinks.Left = 150;
				this.__main_pdlinks.Width = 100;
				this.__main_pdlinks.Height = 44;
				this.__main_laboptmsgs.Top = 210;
				this.__main_laboptmsgs.Left = 20;
				this.__main_laboptmsgs.Width = 230;
				this.__main_laboptmsgs.Height = 40;
				this.__main_pdoptrvs.Top = 210;
				this.__main_pdoptrvs.Left = 148;
				this.__main_pdoptrvs.Width = 100;
				this.__main_pdoptrvs.Height = 44;
				this.__main_lablinkfix.Top = 150;
				this.__main_lablinkfix.Left = 260;
				this.__main_lablinkfix.Width = 100;
				this.__main_lablinkfix.Height = 50;
				this.__main_linkfix.Top = 150;
				this.__main_linkfix.Left = 360;
				this.__main_linkfix.Width = 100;
				this.__main_linkfix.Height = 44;
				this.__main_labfontbold.Top = 30;
				this.__main_labfontbold.Left = 280;
				this.__main_labfontbold.Width = 70;
				this.__main_labfontbold.Height = 40;
				this.__main_fontbold.Top = 30;
				this.__main_fontbold.Left = 360;
				this.__main_fontbold.Width = 100;
				this.__main_fontbold.Height = 44;
				this.__main_kbdonoff.Top = 210;
				this.__main_kbdonoff.Left = 250;
				this.__main_kbdonoff.Width = 100;
				this.__main_kbdonoff.Height = 44;
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_expandoptions");
				return "";
			}
		}

		private string __main_screensizecheck()
		{
			try
			{
				string s = "0";
				this.var__main_screentype = "240x240";
				string string1 = this.screenX.ToString((IFormatProvider)b4p.cul);
				string string2 = this.screenY.ToString((IFormatProvider)b4p.cul);
				if ((string1 == "" ? 0.0 : double.Parse(string1, (IFormatProvider)b4p.cul)) > 500.0 && (string1 == "" ? 0.0 : double.Parse(string1, (IFormatProvider)b4p.cul)) < 650.0 && ((string2 == "" ? 0.0 : double.Parse(string2, (IFormatProvider)b4p.cul)) > 400.0 && (string2 == "" ? 0.0 : double.Parse(string2, (IFormatProvider)b4p.cul)) < 490.0))
					this.var__main_screentype = "640x480";
				if ((string1 == "" ? 0.0 : double.Parse(string1, (IFormatProvider)b4p.cul)) > 400.0 && (string1 == "" ? 0.0 : double.Parse(string1, (IFormatProvider)b4p.cul)) < 490.0 && ((string2 == "" ? 0.0 : double.Parse(string2, (IFormatProvider)b4p.cul)) > 500.0 && (string2 == "" ? 0.0 : double.Parse(string2, (IFormatProvider)b4p.cul)) < 650.0))
					this.var__main_screentype = "480x640";
				if ((string1 == "" ? 0.0 : double.Parse(string1, (IFormatProvider)b4p.cul)) > 180.0 && (string1 == "" ? 0.0 : double.Parse(string1, (IFormatProvider)b4p.cul)) < 250.0 && ((string2 == "" ? 0.0 : double.Parse(string2, (IFormatProvider)b4p.cul)) > 250.0 && (string2 == "" ? 0.0 : double.Parse(string2, (IFormatProvider)b4p.cul)) < 330.0))
					this.var__main_screentype = "240x320";
				if ((string1 == "" ? 0.0 : double.Parse(string1, (IFormatProvider)b4p.cul)) > 250.0 && (string1 == "" ? 0.0 : double.Parse(string1, (IFormatProvider)b4p.cul)) < 330.0 && ((string2 == "" ? 0.0 : double.Parse(string2, (IFormatProvider)b4p.cul)) > 180.0 && (string2 == "" ? 0.0 : double.Parse(string2, (IFormatProvider)b4p.cul)) < 250.0))
					this.var__main_screentype = "320x240";
				if ((string1 == "" ? 0.0 : double.Parse(string1, (IFormatProvider)b4p.cul)) > 250.0 && (string1 == "" ? 0.0 : double.Parse(string1, (IFormatProvider)b4p.cul)) < 330.0 && ((string2 == "" ? 0.0 : double.Parse(string2, (IFormatProvider)b4p.cul)) > 250.0 && (string2 == "" ? 0.0 : double.Parse(string2, (IFormatProvider)b4p.cul)) < 330.0))
					this.var__main_screentype = "320x320";
				if ((string1 == "" ? 0.0 : double.Parse(string1, (IFormatProvider)b4p.cul)) > 730.0 && (string1 == "" ? 0.0 : double.Parse(string1, (IFormatProvider)b4p.cul)) < 820.0 && ((string2 == "" ? 0.0 : double.Parse(string2, (IFormatProvider)b4p.cul)) > 400.0 && (string2 == "" ? 0.0 : double.Parse(string2, (IFormatProvider)b4p.cul)) < 490.0))
					this.var__main_screentype = "800x480";
				if ((string1 == "" ? 0.0 : double.Parse(string1, (IFormatProvider)b4p.cul)) > 400.0 && (string1 == "" ? 0.0 : double.Parse(string1, (IFormatProvider)b4p.cul)) < 490.0 && ((string2 == "" ? 0.0 : double.Parse(string2, (IFormatProvider)b4p.cul)) > 730.0 && (string2 == "" ? 0.0 : double.Parse(string2, (IFormatProvider)b4p.cul)) < 820.0))
					this.var__main_screentype = "480x800";
				if (this.LCompareEqual(this.var__main_screentype, "320x320"))
				{
					this.__main_mycmd.Left = (int)((double)this.__main_mycmd.Left + 40.0);
					this.__main_butgo.Left = (int)((double)this.__main_butgo.Left + 40.0);
					this.__main_butgetdrop.Left = (int)((double)this.__main_butgetdrop.Left + 40.0);
					this.__main_butelc.Left = (int)((double)this.__main_butelc.Left + 40.0);
					this.__main_butmag.Left = (int)((double)this.__main_butmag.Left + 40.0);
					this.__main_butinv.Left = (int)((double)this.__main_butinv.Left + 40.0);
					this.__main_buthelp.Left = (int)((double)this.__main_buthelp.Left + 40.0);
					this.__main_butabc123.Left = (int)((double)this.__main_butabc123.Left + 40.0);
					this.__main_buta.Left = (int)((double)this.__main_buta.Left + 40.0);
					this.__main_butb.Left = (int)((double)this.__main_butb.Left + 40.0);
					this.__main_butc.Left = (int)((double)this.__main_butc.Left + 40.0);
					this.__main_butd.Left = (int)((double)this.__main_butd.Left + 40.0);
					this.__main_bute.Left = (int)((double)this.__main_bute.Left + 40.0);
					this.__main_butf.Left = (int)((double)this.__main_butf.Left + 40.0);
					this.__main_butg.Left = (int)((double)this.__main_butg.Left + 40.0);
					this.__main_buth.Left = (int)((double)this.__main_buth.Left + 40.0);
					this.__main_buti.Left = (int)((double)this.__main_buti.Left + 40.0);
					this.__main_butj.Left = (int)((double)this.__main_butj.Left + 40.0);
					this.__main_butk.Left = (int)((double)this.__main_butk.Left + 40.0);
					this.__main_butl.Left = (int)((double)this.__main_butl.Left + 40.0);
					this.__main_butm.Left = (int)((double)this.__main_butm.Left + 40.0);
					this.__main_butn.Left = (int)((double)this.__main_butn.Left + 40.0);
					this.__main_buto.Left = (int)((double)this.__main_buto.Left + 40.0);
					this.__main_butp.Left = (int)((double)this.__main_butp.Left + 40.0);
					this.__main_butq.Left = (int)((double)this.__main_butq.Left + 40.0);
					this.__main_butr.Left = (int)((double)this.__main_butr.Left + 40.0);
					this.__main_buts.Left = (int)((double)this.__main_buts.Left + 40.0);
					this.__main_butt.Left = (int)((double)this.__main_butt.Left + 40.0);
					this.__main_butu.Left = (int)((double)this.__main_butu.Left + 40.0);
					this.__main_butv.Left = (int)((double)this.__main_butv.Left + 40.0);
					this.__main_butw.Left = (int)((double)this.__main_butw.Left + 40.0);
					this.__main_butx.Left = (int)((double)this.__main_butx.Left + 40.0);
					this.__main_buty.Left = (int)((double)this.__main_buty.Left + 40.0);
					this.__main_butz.Left = (int)((double)this.__main_butz.Left + 40.0);
					this.__main_butdel.Left = (int)((double)this.__main_butdel.Left + 40.0);
					this.__main_butenter.Left = (int)((double)this.__main_butenter.Left + 40.0);
					this.__main_butspace.Left = (int)((double)this.__main_butspace.Left + 40.0);
				}
				if (this.LCompareEqual(this.var__main_screentype, "320x240"))
				{
					this.__main_txtaboutengine.Height = 179;
					this.__main_txtaboutengine.Width = 311;
					this.__main_txtscott.Height = 179;
					this.__main_txtscott.Width = 311;
					this.__main_mycmd.Top = 134;
					this.__main_mycmd.Width = (int)((double)this.__main_mycmd.Width - 8.0);
					this.__main_mycmd.Font = new Font(this.__main_mycmd.Font.Name, 7f, this.__main_mycmd.Font.Style);
					this.__main_mycmd.Height = (int)((double)this.__main_mycmd.Height - 4.0);
					this.__main_mycmd.Left = 238;
					this.__main_butgo.Visible = bool.Parse("false".ToLower(b4p.cul));
					this.__main_butgetdrop.Top = 152;
					this.__main_butgetdrop.Left = 238;
					this.__main_butelc.Top = 152;
					this.__main_butelc.Left = 269;
					this.__main_butmag.Top = 152;
					this.__main_butmag.Left = 295;
					this.__main_butinv.Top = 170;
					this.__main_butinv.Left = (int)byte.MaxValue;
					this.__main_buthelp.Top = 170;
					this.__main_buthelp.Left = 282;
					if (this.LCompareEqual(this.var__main_keyboardisoff, "Y"))
					{
						this.__main_mycmd.Top = 166;
						this.__main_mycmd.Left = 2;
						this.__main_mycmd.Width = 150;
						this.__main_mycmd.Font = new Font(this.__main_mycmd.Font.Name, 9f, this.__main_mycmd.Font.Style);
						this.__main_butgetdrop.Top = 166;
						this.__main_butgetdrop.Left = 170;
						this.__main_butelc.Top = 166;
						this.__main_butelc.Left = 200;
						this.__main_butmag.Top = 166;
						this.__main_butmag.Left = 230;
						this.__main_butinv.Top = 166;
						this.__main_butinv.Left = 260;
						this.__main_buthelp.Top = 166;
						this.__main_buthelp.Left = 290;
					}
					this.__main_advdesc.Height = 113;
					this.__main_butplay.Left = 275;
					this.__main_advdesc.Top = (int)((double)this.__main_advdesc.Top + 25.0);
					this.__main_advdesc.Width = 220;
					this.__main_pdselect.Top = 50;
					this.__main_pdselect.Left = 116;
					this.__main_logo.Height = 42;
					this.__main_butabc123.Top = (int)((double)this.__main_butabc123.Top - 77.0);
					this.__main_buta.Top = (int)((double)this.__main_buta.Top - 77.0);
					this.__main_butb.Top = (int)((double)this.__main_butb.Top - 77.0);
					this.__main_butc.Top = (int)((double)this.__main_butc.Top - 77.0);
					this.__main_butd.Top = (int)((double)this.__main_butd.Top - 77.0);
					this.__main_bute.Top = (int)((double)this.__main_bute.Top - 77.0);
					this.__main_butf.Top = (int)((double)this.__main_butf.Top - 77.0);
					this.__main_butg.Top = (int)((double)this.__main_butg.Top - 77.0);
					this.__main_buth.Top = (int)((double)this.__main_buth.Top - 77.0);
					this.__main_buti.Top = (int)((double)this.__main_buti.Top - 77.0);
					this.__main_butj.Top = (int)((double)this.__main_butj.Top - 77.0);
					this.__main_butk.Top = (int)((double)this.__main_butk.Top - 77.0);
					this.__main_butl.Top = (int)((double)this.__main_butl.Top - 77.0);
					this.__main_butm.Top = (int)((double)this.__main_butm.Top - 77.0);
					this.__main_butn.Top = (int)((double)this.__main_butn.Top - 77.0);
					this.__main_buto.Top = (int)((double)this.__main_buto.Top - 77.0);
					this.__main_butp.Top = (int)((double)this.__main_butp.Top - 77.0);
					this.__main_butq.Top = (int)((double)this.__main_butq.Top - 77.0);
					this.__main_butr.Top = (int)((double)this.__main_butr.Top - 77.0);
					this.__main_buts.Top = (int)((double)this.__main_buts.Top - 77.0);
					this.__main_butt.Top = (int)((double)this.__main_butt.Top - 77.0);
					this.__main_butu.Top = (int)((double)this.__main_butu.Top - 77.0);
					this.__main_butv.Top = (int)((double)this.__main_butv.Top - 77.0);
					this.__main_butw.Top = (int)((double)this.__main_butw.Top - 77.0);
					this.__main_butx.Top = (int)((double)this.__main_butx.Top - 77.0);
					this.__main_buty.Top = (int)((double)this.__main_buty.Top - 77.0);
					this.__main_butz.Top = (int)((double)this.__main_butz.Top - 77.0);
					this.__main_butdel.Top = (int)((double)this.__main_butdel.Top - 77.0);
					this.__main_butenter.Top = (int)((double)this.__main_butenter.Top - 77.0);
					this.__main_butspace.Top = (int)((double)this.__main_butspace.Top - 77.0);
					this.__main_showsoftkeyboard("true");
				}
				if (this.LCompareEqual(this.var__main_screentype, "240x320"))
				{
					if (this.LCompareEqual(this.var__main_keyboardisoff, "Y"))
						s = "53";
					this.__main_txtaboutengine.Height = 260;
					this.__main_txtscott.Height = 260;
					this.__main_mycmd.Top = (int)(190.0 + (s == "" ? 0.0 : double.Parse(s, (IFormatProvider)b4p.cul)));
					this.__main_butgo.Top = (int)(191.0 + (s == "" ? 0.0 : double.Parse(s, (IFormatProvider)b4p.cul)));
					this.__main_butgetdrop.Top = (int)(190.0 + (s == "" ? 0.0 : double.Parse(s, (IFormatProvider)b4p.cul)));
					this.__main_butmag.Top = (int)(190.0 + (s == "" ? 0.0 : double.Parse(s, (IFormatProvider)b4p.cul)));
					this.__main_butinv.Top = (int)(190.0 + (s == "" ? 0.0 : double.Parse(s, (IFormatProvider)b4p.cul)));
					this.__main_buthelp.Top = (int)(190.0 + (s == "" ? 0.0 : double.Parse(s, (IFormatProvider)b4p.cul)));
					this.__main_butelc.Top = (int)(190.0 + (s == "" ? 0.0 : double.Parse(s, (IFormatProvider)b4p.cul)));
					this.__main_advdesc.Height = 220;
					this.__main_advdesc.Left = 133;
					this.__main_advdesc.Width = 105;
					this.__main_backgnd.Height = 162;
					this.__main_backgnd.Width = 122;
					this.__main_imgpic.Height = 160;
					this.__main_imgpic.Width = 120;
					this.__main_pdselect.Top = 50;
					this.__main_pdselect.Width = 125;
					this.__main_logo.Height = 42;
					this.__main_butother.Top = 240;
					this.__main_butother.Width = 122;
					this.__main_butother.Text = "Open other...";
					this.__main_showsoftkeyboard("true");
				}
				if (this.LCompareEqual(this.var__main_screentype, "640x480"))
				{
					this.__main_txtaboutengine.Height = 365;
					this.__main_txtaboutengine.Width = 631;
					this.__main_txtscott.Height = 365;
					this.__main_txtscott.Width = 631;
					this.__main_mycmd.Top = 257;
					this.__main_mycmd.Width = 154;
					this.__main_mycmd.Height = 40;
					this.__main_mycmd.Left = 480;
					this.__main_mycmd.Font = new Font(this.__main_mycmd.Font.Name, 7f, this.__main_mycmd.Font.Style);
					this.__main_butgo.Visible = bool.Parse("false".ToLower(b4p.cul));
					this.__main_butgetdrop.Top = 294;
					this.__main_butgetdrop.Left = 476;
					this.__main_butgetdrop.Width = 54;
					this.__main_butgetdrop.Height = 42;
					this.__main_butelc.Top = 294;
					this.__main_butelc.Left = 538;
					this.__main_butelc.Width = 40;
					this.__main_butelc.Height = 42;
					this.__main_butmag.Top = 294;
					this.__main_butmag.Left = 590;
					this.__main_butmag.Width = 42;
					this.__main_butmag.Height = 42;
					this.__main_butinv.Top = 334;
					this.__main_butinv.Left = 510;
					this.__main_butinv.Width = 42;
					this.__main_butinv.Height = 42;
					this.__main_buthelp.Top = 334;
					this.__main_buthelp.Left = 560;
					this.__main_buthelp.Width = 44;
					this.__main_buthelp.Height = 42;
					this.__main_butplay.Left = 550;
					this.__main_butplay.Top = 10;
					this.__main_butplay.Width = 80;
					this.__main_butplay.Height = 80;
					this.__main_advdesc.Top = 150;
					this.__main_advdesc.Left = 220;
					this.__main_advdesc.Height = 226;
					this.__main_advdesc.Width = 380;
					this.__main_backgnd.Top = 148;
					this.__main_backgnd.Height = 220;
					this.__main_backgnd.Width = 184;
					this.__main_imgpic.Top = 150;
					this.__main_imgpic.Height = 216;
					this.__main_imgpic.Width = 180;
					this.__main_pdselect.Top = 100;
					this.__main_pdselect.Left = 220;
					this.__main_pdselect.Width = 380;
					this.__main_pdselect.Height = 40;
					if (this.LCompareEqual(this.var__main_keyboardisoff, "Y"))
					{
						this.__main_mycmd.Top = 335;
						this.__main_mycmd.Left = 30;
						this.__main_mycmd.Width = 280;
						this.__main_mycmd.Font = new Font(this.__main_mycmd.Font.Name, 9f, this.__main_mycmd.Font.Style);
						this.__main_butgetdrop.Top = 335;
						this.__main_butgetdrop.Left = 330;
						this.__main_butelc.Top = 335;
						this.__main_butelc.Left = 390;
						this.__main_butmag.Top = 335;
						this.__main_butmag.Left = 450;
						this.__main_butinv.Top = 335;
						this.__main_butinv.Left = 510;
						this.__main_buthelp.Top = 335;
						this.__main_buthelp.Left = 570;
					}
					this.__main_logo.Height = 84;
					this.__main_logo.Width = 374;
					this.__main_butother.Top = 90;
					this.__main_butother.Width = 184;
					this.__main_butother.Height = 50;
					this.__main_butother.Left = 5;
					this.__main_butother.Text = "Open other...";
					this.__main_butabc123.Top = 300;
					this.__main_butabc123.Left = 6;
					this.__main_butabc123.Width = 32;
					this.__main_butabc123.Height = 72;
					this.__main_butq.Top = 265;
					this.__main_butq.Left = 2;
					this.__main_butq.Width = 40;
					this.__main_butq.Height = 36;
					this.__main_butw.Top = 265;
					this.__main_butw.Left = 42;
					this.__main_butw.Width = 40;
					this.__main_butw.Height = 36;
					this.__main_bute.Top = 265;
					this.__main_bute.Left = 82;
					this.__main_bute.Width = 40;
					this.__main_bute.Height = 36;
					this.__main_butr.Top = 265;
					this.__main_butr.Left = 122;
					this.__main_butr.Width = 40;
					this.__main_butr.Height = 36;
					this.__main_butt.Top = 265;
					this.__main_butt.Left = 162;
					this.__main_butt.Width = 40;
					this.__main_butt.Height = 36;
					this.__main_buty.Top = 265;
					this.__main_buty.Left = 202;
					this.__main_buty.Width = 40;
					this.__main_buty.Height = 36;
					this.__main_butu.Top = 265;
					this.__main_butu.Left = 242;
					this.__main_butu.Width = 40;
					this.__main_butu.Height = 36;
					this.__main_buti.Top = 265;
					this.__main_buti.Left = 282;
					this.__main_buti.Width = 40;
					this.__main_buti.Height = 36;
					this.__main_buto.Top = 265;
					this.__main_buto.Left = 322;
					this.__main_buto.Width = 40;
					this.__main_buto.Height = 36;
					this.__main_butp.Top = 265;
					this.__main_butp.Left = 362;
					this.__main_butp.Width = 40;
					this.__main_butp.Height = 36;
					this.__main_butdel.Top = 265;
					this.__main_butdel.Left = 402;
					this.__main_butdel.Width = 72;
					this.__main_butdel.Height = 36;
					this.__main_buta.Top = 300;
					this.__main_buta.Left = 42;
					this.__main_buta.Width = 40;
					this.__main_buta.Height = 36;
					this.__main_buts.Top = 300;
					this.__main_buts.Left = 82;
					this.__main_buts.Width = 40;
					this.__main_buts.Height = 36;
					this.__main_butd.Top = 300;
					this.__main_butd.Left = 122;
					this.__main_butd.Width = 40;
					this.__main_butd.Height = 36;
					this.__main_butf.Top = 300;
					this.__main_butf.Left = 162;
					this.__main_butf.Width = 40;
					this.__main_butf.Height = 36;
					this.__main_butg.Top = 300;
					this.__main_butg.Left = 202;
					this.__main_butg.Width = 40;
					this.__main_butg.Height = 36;
					this.__main_buth.Top = 300;
					this.__main_buth.Left = 242;
					this.__main_buth.Width = 40;
					this.__main_buth.Height = 36;
					this.__main_butj.Top = 300;
					this.__main_butj.Left = 282;
					this.__main_butj.Width = 40;
					this.__main_butj.Height = 36;
					this.__main_butk.Top = 300;
					this.__main_butk.Left = 322;
					this.__main_butk.Width = 40;
					this.__main_butk.Height = 36;
					this.__main_butl.Top = 300;
					this.__main_butl.Left = 362;
					this.__main_butl.Width = 40;
					this.__main_butl.Height = 36;
					this.__main_butenter.Top = 300;
					this.__main_butenter.Left = 402;
					this.__main_butenter.Width = 72;
					this.__main_butenter.Height = 72;
					this.__main_butz.Top = 336;
					this.__main_butz.Left = 42;
					this.__main_butz.Width = 40;
					this.__main_butz.Height = 36;
					this.__main_butx.Top = 336;
					this.__main_butx.Left = 82;
					this.__main_butx.Width = 40;
					this.__main_butx.Height = 36;
					this.__main_butc.Top = 336;
					this.__main_butc.Left = 122;
					this.__main_butc.Width = 40;
					this.__main_butc.Height = 36;
					this.__main_butv.Top = 336;
					this.__main_butv.Left = 242;
					this.__main_butv.Width = 40;
					this.__main_butv.Height = 36;
					this.__main_butb.Top = 336;
					this.__main_butb.Left = 282;
					this.__main_butb.Width = 40;
					this.__main_butb.Height = 36;
					this.__main_butn.Top = 336;
					this.__main_butn.Left = 322;
					this.__main_butn.Width = 40;
					this.__main_butn.Height = 36;
					this.__main_butm.Top = 336;
					this.__main_butm.Left = 362;
					this.__main_butm.Width = 40;
					this.__main_butm.Height = 36;
					this.__main_butspace.Top = 336;
					this.__main_butspace.Left = 162;
					this.__main_butspace.Width = 80;
					this.__main_butspace.Height = 36;
					this.__main_showsoftkeyboard("true");
					this.__main_expandoptions();
				}
				if (this.LCompareEqual(this.var__main_screentype, "480x640"))
				{
					this.__main_txtaboutengine.Height = 520;
					this.__main_txtaboutengine.Width = 468;
					this.__main_txtscott.Height = 520;
					this.__main_txtscott.Width = 468;
					this.__main_butplay.Left = 390;
					this.__main_butplay.Top = 10;
					this.__main_butplay.Width = 80;
					this.__main_butplay.Height = 80;
					this.__main_advdesc.Top = 100;
					this.__main_advdesc.Left = 266;
					this.__main_advdesc.Height = 490;
					this.__main_advdesc.Width = 210;
					this.__main_backgnd.Top = 148;
					this.__main_backgnd.Left = 12;
					this.__main_backgnd.Height = 324;
					this.__main_backgnd.Width = 244;
					this.__main_imgpic.Top = 150;
					this.__main_imgpic.Left = 14;
					this.__main_imgpic.Height = 320;
					this.__main_imgpic.Width = 240;
					this.__main_pdselect.Top = 100;
					this.__main_pdselect.Left = 9;
					this.__main_pdselect.Width = 249;
					this.__main_pdselect.Height = 40;
					this.__main_logo.Height = 84;
					this.__main_logo.Width = 374;
					this.__main_logo.Top = 10;
					this.__main_logo.Left = 10;
					this.__main_butother.Top = 480;
					this.__main_butother.Width = 244;
					this.__main_butother.Height = 50;
					this.__main_butother.Left = 13;
					this.__main_butother.Text = "Open other...";
					this.__main_butabc123.Top = 460;
					this.__main_butabc123.Left = 6;
					this.__main_butabc123.Width = 32;
					this.__main_butabc123.Height = 72;
					this.__main_mycmd.Top = 385;
					this.__main_mycmd.Left = 2;
					this.__main_mycmd.Width = 180;
					this.__main_mycmd.Height = 40;
					this.__main_butgo.Top = 385;
					this.__main_butgo.Left = 184;
					this.__main_butgo.Width = 36;
					this.__main_butgo.Height = 36;
					this.__main_butgetdrop.Top = 382;
					this.__main_butgetdrop.Left = 224;
					this.__main_butgetdrop.Width = 54;
					this.__main_butgetdrop.Height = 42;
					this.__main_butelc.Top = 382;
					this.__main_butelc.Left = 284;
					this.__main_butelc.Width = 40;
					this.__main_butelc.Height = 42;
					this.__main_butmag.Top = 382;
					this.__main_butmag.Left = 330;
					this.__main_butmag.Width = 42;
					this.__main_butmag.Height = 42;
					this.__main_butinv.Top = 382;
					this.__main_butinv.Left = 380;
					this.__main_butinv.Width = 42;
					this.__main_butinv.Height = 42;
					this.__main_buthelp.Top = 382;
					this.__main_buthelp.Left = 424;
					this.__main_buthelp.Width = 44;
					this.__main_buthelp.Height = 42;
					if (this.LCompareEqual(this.var__main_keyboardisoff, "Y"))
					{
						this.__main_mycmd.Top = 490;
						this.__main_mycmd.Left = 2;
						this.__main_mycmd.Width = 180;
						this.__main_mycmd.Height = 40;
						this.__main_butgo.Top = 490;
						this.__main_butgo.Left = 184;
						this.__main_butgo.Width = 36;
						this.__main_butgo.Height = 36;
						this.__main_butgetdrop.Top = 487;
						this.__main_butgetdrop.Left = 224;
						this.__main_butgetdrop.Width = 54;
						this.__main_butgetdrop.Height = 42;
						this.__main_butelc.Top = 487;
						this.__main_butelc.Left = 284;
						this.__main_butelc.Width = 40;
						this.__main_butelc.Height = 42;
						this.__main_butmag.Top = 487;
						this.__main_butmag.Left = 330;
						this.__main_butmag.Width = 42;
						this.__main_butmag.Height = 42;
						this.__main_butinv.Top = 487;
						this.__main_butinv.Left = 380;
						this.__main_butinv.Width = 42;
						this.__main_butinv.Height = 42;
						this.__main_buthelp.Top = 487;
						this.__main_buthelp.Left = 424;
						this.__main_buthelp.Width = 44;
						this.__main_buthelp.Height = 42;
					}
					this.__main_butq.Top = 425;
					this.__main_butq.Left = 2;
					this.__main_butq.Width = 40;
					this.__main_butq.Height = 36;
					this.__main_butw.Top = 425;
					this.__main_butw.Left = 42;
					this.__main_butw.Width = 40;
					this.__main_butw.Height = 36;
					this.__main_bute.Top = 425;
					this.__main_bute.Left = 82;
					this.__main_bute.Width = 40;
					this.__main_bute.Height = 36;
					this.__main_butr.Top = 425;
					this.__main_butr.Left = 122;
					this.__main_butr.Width = 40;
					this.__main_butr.Height = 36;
					this.__main_butt.Top = 425;
					this.__main_butt.Left = 162;
					this.__main_butt.Width = 40;
					this.__main_butt.Height = 36;
					this.__main_buty.Top = 425;
					this.__main_buty.Left = 202;
					this.__main_buty.Width = 40;
					this.__main_buty.Height = 36;
					this.__main_butu.Top = 425;
					this.__main_butu.Left = 242;
					this.__main_butu.Width = 40;
					this.__main_butu.Height = 36;
					this.__main_buti.Top = 425;
					this.__main_buti.Left = 282;
					this.__main_buti.Width = 40;
					this.__main_buti.Height = 36;
					this.__main_buto.Top = 425;
					this.__main_buto.Left = 322;
					this.__main_buto.Width = 40;
					this.__main_buto.Height = 36;
					this.__main_butp.Top = 425;
					this.__main_butp.Left = 362;
					this.__main_butp.Width = 40;
					this.__main_butp.Height = 36;
					this.__main_butdel.Top = 425;
					this.__main_butdel.Left = 404;
					this.__main_butdel.Width = 72;
					this.__main_butdel.Height = 36;
					this.__main_buta.Top = 460;
					this.__main_buta.Left = 42;
					this.__main_buta.Width = 40;
					this.__main_buta.Height = 36;
					this.__main_buts.Top = 460;
					this.__main_buts.Left = 82;
					this.__main_buts.Width = 40;
					this.__main_buts.Height = 36;
					this.__main_butd.Top = 460;
					this.__main_butd.Left = 122;
					this.__main_butd.Width = 40;
					this.__main_butd.Height = 36;
					this.__main_butf.Top = 460;
					this.__main_butf.Left = 162;
					this.__main_butf.Width = 40;
					this.__main_butf.Height = 36;
					this.__main_butg.Top = 460;
					this.__main_butg.Left = 202;
					this.__main_butg.Width = 40;
					this.__main_butg.Height = 36;
					this.__main_buth.Top = 460;
					this.__main_buth.Left = 242;
					this.__main_buth.Width = 40;
					this.__main_buth.Height = 36;
					this.__main_butj.Top = 460;
					this.__main_butj.Left = 282;
					this.__main_butj.Width = 40;
					this.__main_butj.Height = 36;
					this.__main_butk.Top = 460;
					this.__main_butk.Left = 322;
					this.__main_butk.Width = 40;
					this.__main_butk.Height = 36;
					this.__main_butl.Top = 460;
					this.__main_butl.Left = 362;
					this.__main_butl.Width = 40;
					this.__main_butl.Height = 36;
					this.__main_butenter.Top = 460;
					this.__main_butenter.Left = 404;
					this.__main_butenter.Width = 72;
					this.__main_butenter.Height = 72;
					this.__main_butz.Top = 496;
					this.__main_butz.Left = 42;
					this.__main_butz.Width = 40;
					this.__main_butz.Height = 36;
					this.__main_butx.Top = 496;
					this.__main_butx.Left = 82;
					this.__main_butx.Width = 40;
					this.__main_butx.Height = 36;
					this.__main_butc.Top = 496;
					this.__main_butc.Left = 122;
					this.__main_butc.Width = 40;
					this.__main_butc.Height = 36;
					this.__main_butv.Top = 496;
					this.__main_butv.Left = 242;
					this.__main_butv.Width = 40;
					this.__main_butv.Height = 36;
					this.__main_butb.Top = 496;
					this.__main_butb.Left = 282;
					this.__main_butb.Width = 40;
					this.__main_butb.Height = 36;
					this.__main_butn.Top = 496;
					this.__main_butn.Left = 322;
					this.__main_butn.Width = 40;
					this.__main_butn.Height = 36;
					this.__main_butm.Top = 496;
					this.__main_butm.Left = 362;
					this.__main_butm.Width = 40;
					this.__main_butm.Height = 36;
					this.__main_butspace.Top = 496;
					this.__main_butspace.Left = 162;
					this.__main_butspace.Width = 80;
					this.__main_butspace.Height = 36;
					this.__main_showsoftkeyboard("true");
					this.__main_expandoptions();
				}
				if (this.LCompareEqual(this.var__main_screentype, "800x480"))
				{
					this.__main_txtaboutengine.Height = 365;
					this.__main_txtaboutengine.Width = 791;
					this.__main_txtscott.Height = 365;
					this.__main_txtscott.Width = 791;
					this.__main_mycmd.Top = 257;
					this.__main_mycmd.Width = 154;
					this.__main_mycmd.Height = 40;
					this.__main_mycmd.Left = 560;
					this.__main_mycmd.Font = new Font(this.__main_mycmd.Font.Name, 7f, this.__main_mycmd.Font.Style);
					this.__main_butgo.Visible = bool.Parse("false".ToLower(b4p.cul));
					this.__main_butgetdrop.Top = 294;
					this.__main_butgetdrop.Left = 566;
					this.__main_butgetdrop.Width = 54;
					this.__main_butgetdrop.Height = 42;
					this.__main_butelc.Top = 294;
					this.__main_butelc.Left = 618;
					this.__main_butelc.Width = 40;
					this.__main_butelc.Height = 42;
					this.__main_butmag.Top = 294;
					this.__main_butmag.Left = 670;
					this.__main_butmag.Width = 42;
					this.__main_butmag.Height = 42;
					this.__main_butinv.Top = 334;
					this.__main_butinv.Left = 590;
					this.__main_butinv.Width = 42;
					this.__main_butinv.Height = 42;
					this.__main_buthelp.Top = 334;
					this.__main_buthelp.Left = 650;
					this.__main_buthelp.Width = 44;
					this.__main_buthelp.Height = 42;
					if (this.LCompareEqual(this.var__main_keyboardisoff, "Y"))
					{
						this.__main_mycmd.Top = 334;
						this.__main_mycmd.Width = 154;
						this.__main_mycmd.Height = 40;
						this.__main_mycmd.Left = 170;
						this.__main_mycmd.Font = new Font(this.__main_mycmd.Font.Name, 7f, this.__main_mycmd.Font.Style);
						this.__main_butgetdrop.Top = 334;
						this.__main_butgetdrop.Left = 350;
						this.__main_butgetdrop.Width = 54;
						this.__main_butgetdrop.Height = 42;
						this.__main_butelc.Top = 334;
						this.__main_butelc.Left = 400;
						this.__main_butelc.Width = 40;
						this.__main_butelc.Height = 42;
						this.__main_butmag.Top = 334;
						this.__main_butmag.Left = 450;
						this.__main_butmag.Width = 42;
						this.__main_butmag.Height = 42;
						this.__main_butinv.Top = 334;
						this.__main_butinv.Left = 500;
						this.__main_butinv.Width = 42;
						this.__main_butinv.Height = 42;
						this.__main_buthelp.Top = 334;
						this.__main_buthelp.Left = 550;
						this.__main_buthelp.Width = 44;
						this.__main_buthelp.Height = 42;
					}
					this.__main_butplay.Left = 630;
					this.__main_butplay.Top = 10;
					this.__main_butplay.Width = 80;
					this.__main_butplay.Height = 80;
					this.__main_advdesc.Top = 150;
					this.__main_advdesc.Left = 300;
					this.__main_advdesc.Height = 226;
					this.__main_advdesc.Width = 380;
					this.__main_backgnd.Top = 148;
					this.__main_backgnd.Height = 220;
					this.__main_backgnd.Width = 184;
					this.__main_backgnd.Left = (int)((double)this.__main_backgnd.Left + 80.0);
					this.__main_imgpic.Top = 150;
					this.__main_imgpic.Height = 216;
					this.__main_imgpic.Width = 180;
					this.__main_imgpic.Left = (int)((double)this.__main_imgpic.Left + 80.0);
					this.__main_pdselect.Top = 100;
					this.__main_pdselect.Left = 300;
					this.__main_pdselect.Width = 380;
					this.__main_pdselect.Height = 40;
					this.__main_logo.Height = 84;
					this.__main_logo.Width = 374;
					this.__main_logo.Left = (int)((double)this.__main_logo.Left + 80.0);
					this.__main_butother.Top = 90;
					this.__main_butother.Width = 184;
					this.__main_butother.Height = 50;
					this.__main_butother.Left = 85;
					this.__main_butother.Text = "Open other...";
					this.__main_butq.Top = 265;
					this.__main_butq.Left = 82;
					this.__main_butq.Width = 40;
					this.__main_butq.Height = 36;
					this.__main_butw.Top = 265;
					this.__main_butw.Left = 122;
					this.__main_butw.Width = 40;
					this.__main_butw.Height = 36;
					this.__main_bute.Top = 265;
					this.__main_bute.Left = 162;
					this.__main_bute.Width = 40;
					this.__main_bute.Height = 36;
					this.__main_butr.Top = 265;
					this.__main_butr.Left = 202;
					this.__main_butr.Width = 40;
					this.__main_butr.Height = 36;
					this.__main_butt.Top = 265;
					this.__main_butt.Left = 242;
					this.__main_butt.Width = 40;
					this.__main_butt.Height = 36;
					this.__main_buty.Top = 265;
					this.__main_buty.Left = 282;
					this.__main_buty.Width = 40;
					this.__main_buty.Height = 36;
					this.__main_butu.Top = 265;
					this.__main_butu.Left = 322;
					this.__main_butu.Width = 40;
					this.__main_butu.Height = 36;
					this.__main_buti.Top = 265;
					this.__main_buti.Left = 362;
					this.__main_buti.Width = 40;
					this.__main_buti.Height = 36;
					this.__main_buto.Top = 265;
					this.__main_buto.Left = 402;
					this.__main_buto.Width = 40;
					this.__main_buto.Height = 36;
					this.__main_butp.Top = 265;
					this.__main_butp.Left = 442;
					this.__main_butp.Width = 40;
					this.__main_butp.Height = 36;
					this.__main_butdel.Top = 265;
					this.__main_butdel.Left = 482;
					this.__main_butdel.Width = 72;
					this.__main_butdel.Height = 36;
					this.__main_butabc123.Top = 300;
					this.__main_butabc123.Left = 86;
					this.__main_butabc123.Width = 32;
					this.__main_butabc123.Height = 72;
					this.__main_buta.Top = 300;
					this.__main_buta.Left = 122;
					this.__main_buta.Width = 40;
					this.__main_buta.Height = 36;
					this.__main_buts.Top = 300;
					this.__main_buts.Left = 162;
					this.__main_buts.Width = 40;
					this.__main_buts.Height = 36;
					this.__main_butd.Top = 300;
					this.__main_butd.Left = 202;
					this.__main_butd.Width = 40;
					this.__main_butd.Height = 36;
					this.__main_butf.Top = 300;
					this.__main_butf.Left = 242;
					this.__main_butf.Width = 40;
					this.__main_butf.Height = 36;
					this.__main_butg.Top = 300;
					this.__main_butg.Left = 282;
					this.__main_butg.Width = 40;
					this.__main_butg.Height = 36;
					this.__main_buth.Top = 300;
					this.__main_buth.Left = 322;
					this.__main_buth.Width = 40;
					this.__main_buth.Height = 36;
					this.__main_butj.Top = 300;
					this.__main_butj.Left = 362;
					this.__main_butj.Width = 40;
					this.__main_butj.Height = 36;
					this.__main_butk.Top = 300;
					this.__main_butk.Left = 402;
					this.__main_butk.Width = 40;
					this.__main_butk.Height = 36;
					this.__main_butl.Top = 300;
					this.__main_butl.Left = 442;
					this.__main_butl.Width = 40;
					this.__main_butl.Height = 36;
					this.__main_butenter.Top = 300;
					this.__main_butenter.Left = 482;
					this.__main_butenter.Width = 72;
					this.__main_butenter.Height = 72;
					this.__main_butz.Top = 336;
					this.__main_butz.Left = 122;
					this.__main_butz.Width = 40;
					this.__main_butz.Height = 36;
					this.__main_butx.Top = 336;
					this.__main_butx.Left = 162;
					this.__main_butx.Width = 40;
					this.__main_butx.Height = 36;
					this.__main_butc.Top = 336;
					this.__main_butc.Left = 202;
					this.__main_butc.Width = 40;
					this.__main_butc.Height = 36;
					this.__main_butv.Top = 336;
					this.__main_butv.Left = 322;
					this.__main_butv.Width = 40;
					this.__main_butv.Height = 36;
					this.__main_butb.Top = 336;
					this.__main_butb.Left = 362;
					this.__main_butb.Width = 40;
					this.__main_butb.Height = 36;
					this.__main_butn.Top = 336;
					this.__main_butn.Left = 402;
					this.__main_butn.Width = 40;
					this.__main_butn.Height = 36;
					this.__main_butm.Top = 336;
					this.__main_butm.Left = 442;
					this.__main_butm.Width = 40;
					this.__main_butm.Height = 36;
					this.__main_butspace.Top = 336;
					this.__main_butspace.Left = 242;
					this.__main_butspace.Width = 80;
					this.__main_butspace.Height = 36;
					this.__main_showsoftkeyboard("true");
					this.__main_expandoptions();
				}
				if (this.LCompareEqual(this.var__main_screentype, "480x800"))
				{
					if (this.LCompareEqual(this.var__main_keyboardisoff, "Y"))
						s = "106";
					this.__main_txtaboutengine.Height = 684;
					this.__main_txtaboutengine.Width = 468;
					this.__main_txtscott.Height = 684;
					this.__main_txtscott.Width = 468;
					this.__main_butplay.Left = 390;
					this.__main_butplay.Top = 10;
					this.__main_butplay.Width = 80;
					this.__main_butplay.Height = 80;
					this.__main_advdesc.Top = 100;
					this.__main_advdesc.Left = 266;
					this.__main_advdesc.Height = 490;
					this.__main_advdesc.Width = 210;
					this.__main_backgnd.Top = 148;
					this.__main_backgnd.Left = 12;
					this.__main_backgnd.Height = 324;
					this.__main_backgnd.Width = 244;
					this.__main_imgpic.Top = 150;
					this.__main_imgpic.Left = 14;
					this.__main_imgpic.Height = 320;
					this.__main_imgpic.Width = 240;
					this.__main_pdselect.Top = 100;
					this.__main_pdselect.Left = 9;
					this.__main_pdselect.Width = 249;
					this.__main_pdselect.Height = 40;
					this.__main_logo.Height = 84;
					this.__main_logo.Width = 374;
					this.__main_logo.Top = 10;
					this.__main_logo.Left = 10;
					this.__main_butother.Top = 480;
					this.__main_butother.Width = 244;
					this.__main_butother.Height = 50;
					this.__main_butother.Left = 13;
					this.__main_butother.Text = "Open other...";
					this.__main_mycmd.Top = (int)(543.0 + (s == "" ? 0.0 : double.Parse(s, (IFormatProvider)b4p.cul)));
					this.__main_mycmd.Left = 2;
					this.__main_mycmd.Width = 180;
					this.__main_mycmd.Height = 40;
					this.__main_butgo.Top = (int)(543.0 + (s == "" ? 0.0 : double.Parse(s, (IFormatProvider)b4p.cul)));
					this.__main_butgo.Left = 184;
					this.__main_butgo.Width = 36;
					this.__main_butgo.Height = 36;
					this.__main_butgetdrop.Top = (int)(541.0 + (s == "" ? 0.0 : double.Parse(s, (IFormatProvider)b4p.cul)));
					this.__main_butgetdrop.Left = 224;
					this.__main_butgetdrop.Width = 54;
					this.__main_butgetdrop.Height = 42;
					this.__main_butelc.Top = (int)(541.0 + (s == "" ? 0.0 : double.Parse(s, (IFormatProvider)b4p.cul)));
					this.__main_butelc.Left = 284;
					this.__main_butelc.Width = 40;
					this.__main_butelc.Height = 42;
					this.__main_butmag.Top = (int)(541.0 + (s == "" ? 0.0 : double.Parse(s, (IFormatProvider)b4p.cul)));
					this.__main_butmag.Left = 330;
					this.__main_butmag.Width = 42;
					this.__main_butmag.Height = 42;
					this.__main_butinv.Top = (int)(541.0 + (s == "" ? 0.0 : double.Parse(s, (IFormatProvider)b4p.cul)));
					this.__main_butinv.Left = 380;
					this.__main_butinv.Width = 42;
					this.__main_butinv.Height = 42;
					this.__main_buthelp.Top = (int)(541.0 + (s == "" ? 0.0 : double.Parse(s, (IFormatProvider)b4p.cul)));
					this.__main_buthelp.Left = 424;
					this.__main_buthelp.Width = 44;
					this.__main_buthelp.Height = 42;
					this.__main_butq.Top = 584;
					this.__main_butq.Left = 2;
					this.__main_butq.Width = 40;
					this.__main_butq.Height = 36;
					this.__main_butw.Top = 584;
					this.__main_butw.Left = 42;
					this.__main_butw.Width = 40;
					this.__main_butw.Height = 36;
					this.__main_butw.Top = 584;
					this.__main_butw.Left = 42;
					this.__main_butw.Width = 40;
					this.__main_butw.Height = 36;
					this.__main_bute.Top = 584;
					this.__main_bute.Left = 82;
					this.__main_bute.Width = 40;
					this.__main_bute.Height = 36;
					this.__main_butr.Top = 584;
					this.__main_butr.Left = 122;
					this.__main_butr.Width = 40;
					this.__main_butr.Height = 36;
					this.__main_butt.Top = 584;
					this.__main_butt.Left = 162;
					this.__main_butt.Width = 40;
					this.__main_butt.Height = 36;
					this.__main_buty.Top = 584;
					this.__main_buty.Left = 202;
					this.__main_buty.Width = 40;
					this.__main_buty.Height = 36;
					this.__main_butu.Top = 584;
					this.__main_butu.Left = 242;
					this.__main_butu.Width = 40;
					this.__main_butu.Height = 36;
					this.__main_buti.Top = 584;
					this.__main_buti.Left = 282;
					this.__main_buti.Width = 40;
					this.__main_buti.Height = 36;
					this.__main_buto.Top = 584;
					this.__main_buto.Left = 322;
					this.__main_buto.Width = 40;
					this.__main_buto.Height = 36;
					this.__main_butp.Top = 584;
					this.__main_butp.Left = 362;
					this.__main_butp.Width = 40;
					this.__main_butp.Height = 36;
					this.__main_butdel.Top = 584;
					this.__main_butdel.Left = 404;
					this.__main_butdel.Width = 72;
					this.__main_butdel.Height = 36;
					this.__main_butabc123.Top = 620;
					this.__main_butabc123.Left = 6;
					this.__main_butabc123.Width = 32;
					this.__main_butabc123.Height = 72;
					this.__main_buta.Top = 620;
					this.__main_buta.Left = 42;
					this.__main_buta.Width = 40;
					this.__main_buta.Height = 36;
					this.__main_buts.Top = 620;
					this.__main_buts.Left = 82;
					this.__main_buts.Width = 40;
					this.__main_buts.Height = 36;
					this.__main_butd.Top = 620;
					this.__main_butd.Left = 122;
					this.__main_butd.Width = 40;
					this.__main_butd.Height = 36;
					this.__main_butf.Top = 620;
					this.__main_butf.Left = 162;
					this.__main_butf.Width = 40;
					this.__main_butf.Height = 36;
					this.__main_butg.Top = 620;
					this.__main_butg.Left = 202;
					this.__main_butg.Width = 40;
					this.__main_butg.Height = 36;
					this.__main_buth.Top = 620;
					this.__main_buth.Left = 242;
					this.__main_buth.Width = 40;
					this.__main_buth.Height = 36;
					this.__main_butj.Top = 620;
					this.__main_butj.Left = 282;
					this.__main_butj.Width = 40;
					this.__main_butj.Height = 36;
					this.__main_butk.Top = 620;
					this.__main_butk.Left = 322;
					this.__main_butk.Width = 40;
					this.__main_butk.Height = 36;
					this.__main_butl.Top = 620;
					this.__main_butl.Left = 362;
					this.__main_butl.Width = 40;
					this.__main_butl.Height = 36;
					this.__main_butenter.Top = 620;
					this.__main_butenter.Left = 404;
					this.__main_butenter.Width = 72;
					this.__main_butenter.Height = 72;
					this.__main_butz.Top = 656;
					this.__main_butz.Left = 42;
					this.__main_butz.Width = 40;
					this.__main_butz.Height = 36;
					this.__main_butx.Top = 656;
					this.__main_butx.Left = 82;
					this.__main_butx.Width = 40;
					this.__main_butx.Height = 36;
					this.__main_butc.Top = 656;
					this.__main_butc.Left = 122;
					this.__main_butc.Width = 40;
					this.__main_butc.Height = 36;
					this.__main_butv.Top = 656;
					this.__main_butv.Left = 242;
					this.__main_butv.Width = 40;
					this.__main_butv.Height = 36;
					this.__main_butb.Top = 656;
					this.__main_butb.Left = 282;
					this.__main_butb.Width = 40;
					this.__main_butb.Height = 36;
					this.__main_butn.Top = 656;
					this.__main_butn.Left = 322;
					this.__main_butn.Width = 40;
					this.__main_butn.Height = 36;
					this.__main_butm.Top = 656;
					this.__main_butm.Left = 362;
					this.__main_butm.Width = 40;
					this.__main_butm.Height = 36;
					this.__main_butspace.Top = 656;
					this.__main_butspace.Left = 162;
					this.__main_butspace.Width = 80;
					this.__main_butspace.Height = 36;
					this.__main_showsoftkeyboard("true");
					this.__main_expandoptions();
				}
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_screensizecheck");
				return "";
			}
		}

		private string __main_sendlook(string var__main_mylk)
		{
			try
			{
				if (this.LCompareEqual(this.var__main_lookcleared, "0"))
					this.__main_addtxtlook("");
				this.var__main_lookcleared = ((this.var__main_lookcleared == "" ? 0.0 : double.Parse(this.var__main_lookcleared, (IFormatProvider)b4p.cul)) + 1.0).ToString((IFormatProvider)b4p.cul);
				this.__main_addtxtlook(var__main_mylk);
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_sendlook");
				return "";
			}
		}

		private string __main_loaderror(string var__main_lemsg)
		{
			try
			{
				((int)MessageBox.Show(var__main_lemsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider)b4p.cul);
				if (this.mainForm != null)
					this.mainForm.Close();
				else
					this.CloseProgram();
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_loaderror");
				return "";
			}
		}

		private string __main_readitemloc()
		{
			string str = "";
			try
			{
				Application.DoEvents();
				str = "";
				if (this.Other.SubString(this.var__main_myfiledata, this.var__main_myfiledatapos == "" ? 0 : (int)double.Parse(this.var__main_myfiledatapos, (IFormatProvider)b4p.cul), 1) == '\n'.ToString((IFormatProvider)b4p.cul))
					this.var__main_myfiledatapos = ((this.var__main_myfiledatapos == "" ? 0.0 : double.Parse(this.var__main_myfiledatapos, (IFormatProvider)b4p.cul)) + 1.0).ToString((IFormatProvider)b4p.cul);
				string @string = ((double)this.var__main_myfiledata.IndexOf('\n'.ToString((IFormatProvider)b4p.cul), this.var__main_myfiledatapos == "" ? 0 : (int)double.Parse(this.var__main_myfiledatapos, (IFormatProvider)b4p.cul)) - (this.var__main_myfiledatapos == "" ? 0.0 : double.Parse(this.var__main_myfiledatapos, (IFormatProvider)b4p.cul))).ToString((IFormatProvider)b4p.cul);
				string var__main_ttxt = this.Other.SubString(this.var__main_myfiledata, this.var__main_myfiledatapos == "" ? 0 : (int)double.Parse(this.var__main_myfiledatapos, (IFormatProvider)b4p.cul), @string == "" ? 0 : (int)double.Parse(@string, (IFormatProvider)b4p.cul));
				this.var__main_myfiledatapos = ((this.var__main_myfiledatapos == "" ? 0.0 : double.Parse(this.var__main_myfiledatapos, (IFormatProvider)b4p.cul)) + (@string == "" ? 0.0 : double.Parse(@string, (IFormatProvider)b4p.cul)) + 1.0).ToString((IFormatProvider)b4p.cul);
				return Math.Floor(double.Parse(this.__main_trim(var__main_ttxt), (IFormatProvider)b4p.cul)).ToString((IFormatProvider)b4p.cul);
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_readitemloc");
				return "";
			}
		}

		private string __main_butg_click()
		{
			try
			{
				this.__main_insertchar("G");
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_butg_click");
				return "";
			}
		}

		private string __main_loadmygame()
		{
			string str1 = "";
			string str2 = "";
			string str3 = "";
			string s = "";
			string str4 = "";
			string str5 = "";
			string str6 = "";
			string lSide1 = "";
			string lSide2 = "";
			string str7 = "";
			string str8 = "";
			string str9 = "";
			string str10 = "";
			string lSide3 = "";
			string str11 = "";
			string str12 = "";
			int num1 = 0;
			try
			{
				if (this.err__main_loadmygame > 0)
				{
					str12 = this.localVars[15];
					str11 = this.localVars[14];
					lSide3 = this.localVars[13];
					str10 = this.localVars[12];
					str9 = this.localVars[11];
					str8 = this.localVars[10];
					str7 = this.localVars[9];
					lSide2 = this.localVars[8];
					lSide1 = this.localVars[7];
					str6 = this.localVars[6];
					str5 = this.localVars[5];
					str4 = this.localVars[4];
					s = this.localVars[3];
					str3 = this.localVars[2];
					str2 = this.localVars[1];
					str1 = this.localVars[0];
					if (this.err__main_loadmygame == 1)
					{
						this.err__main_loadmygame = 0;
						((int)MessageBox.Show("Unable to load file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider)b4p.cul);
						return "";
					}
				}
				str8 = "";
				this.__main_loaddialog1.Filter = "Save Files|*.sav";
				if (((int)this.__main_loaddialog1.ShowDialog()).ToString((IFormatProvider)b4p.cul) != "2")
					str8 = this.__main_loaddialog1.FileName;
				if (this.LCompareEqual(str8, ""))
					return "";
				num1 = 1;
				this.htStreams.Add((object)"_main_d1", (object)new CStreamReader(Path.Combine(this.b4pdir, str8), Encoding.ASCII));
				lSide3 = (str2 = ((TextReader)this.htStreams[(object)"_main_d1"]).ReadLine()) == null ? "@eof@" : str2;
				lSide1 = (str5 = ((TextReader)this.htStreams[(object)"_main_d1"]).ReadLine()) == null ? "@eof@" : str5;
				lSide2 = (str7 = ((TextReader)this.htStreams[(object)"_main_d1"]).ReadLine()) == null ? "@eof@" : str7;
				if (!this.CompareEqual(lSide1, this.var__main_magicheader) || !this.CompareEqual(lSide2, this.var__main_advno) || !this.CompareEqual(lSide3, this.var__main_checksum))
				{
					((int)MessageBox.Show("Save file not from this adventure.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)).ToString((IFormatProvider)b4p.cul);
					if (this.htStreams.Contains((object)"_main_d1"))
					{
						((IStream)this.htStreams[(object)"_main_d1"]).Close();
						this.htStreams.Remove((object)"_main_d1");
						GC.Collect();
					}
					return "";
				}
				s = "0";
				double num2 = (double)byte.MaxValue;
				for (double num3 = double.Parse(s, (IFormatProvider)b4p.cul); num3 <= num2; s = (++num3).ToString((IFormatProvider)b4p.cul))
				{
					((string[])this.var__main_counters)[s == "" ? 0 : (int)double.Parse(s, (IFormatProvider)b4p.cul)] = (str12 = ((TextReader)this.htStreams[(object)"_main_d1"]).ReadLine()) == null ? "@eof@" : str12;
					((string[])this.var__main_roomsaved)[s == "" ? 0 : (int)double.Parse(s, (IFormatProvider)b4p.cul)] = (str3 = ((TextReader)this.htStreams[(object)"_main_d1"]).ReadLine()) == null ? "@eof@" : str3;
					((string[])this.var__main_xbitflags)[s == "" ? 0 : (int)double.Parse(s, (IFormatProvider)b4p.cul)] = (str4 = ((TextReader)this.htStreams[(object)"_main_d1"]).ReadLine()) == null ? "@eof@" : str4;
				}
				this.var__main_playerroom = (str9 = ((TextReader)this.htStreams[(object)"_main_d1"]).ReadLine()) == null ? "@eof@" : str9;
				this.var__main_currentcounter = (str11 = ((TextReader)this.htStreams[(object)"_main_d1"]).ReadLine()) == null ? "@eof@" : str11;
				this.var__main_currentsavedroom = (str1 = ((TextReader)this.htStreams[(object)"_main_d1"]).ReadLine()) == null ? "@eof@" : str1;
				this.var__main_lighttime = (str6 = ((TextReader)this.htStreams[(object)"_main_d1"]).ReadLine()) == null ? "@eof@" : str6;
				s = "0";
				double num4 = this.var__main_numitems == "" ? 0.0 : double.Parse(this.var__main_numitems, (IFormatProvider)b4p.cul);
				for (double num3 = double.Parse(s, (IFormatProvider)b4p.cul); num3 <= num4; s = (++num3).ToString((IFormatProvider)b4p.cul))
					((string[])this.var__main_xitemloc)[s == "" ? 0 : (int)double.Parse(s, (IFormatProvider)b4p.cul)] = (str10 = ((TextReader)this.htStreams[(object)"_main_d1"]).ReadLine()) == null ? "@eof@" : str10;
				if (this.htStreams.Contains((object)"_main_d1"))
				{
					((IStream)this.htStreams[(object)"_main_d1"]).Close();
					this.htStreams.Remove((object)"_main_d1");
					GC.Collect();
				}
				this.__main_mycmd.Text = "LOOK";
				this.__main_mycmd_keypress('\r'.ToString((IFormatProvider)b4p.cul));
				return "";
			}
			catch (Exception ex)
			{
				if (num1 > 0)
				{
					this.lastError = ex;
					this.err__main_loadmygame = num1;
					this.localVars = new string[16]
			 {
				str1,
				str2,
				str3,
				s,
				str4,
				str5,
				str6,
				lSide1,
				lSide2,
				str7,
				str8,
				str9,
				str10,
				lSide3,
				str11,
				str12
			 };
					return this.__main_loadmygame();
				}
				this.ShowError(ex, "__main_loadmygame");
				return "";
			}
		}

		private string __main_butx_click()
		{
			try
			{
				this.__main_insertchar("X");
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_butx_click");
				return "";
			}
		}

		private string __main_fengine_click()
		{
			try
			{
				this.__main_aboutengine.show();
				this.__main_txtaboutengine.SelectionStart = 0;
				this.__main_txtaboutengine.SelectionLength = 0;
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_fengine_click");
				return "";
			}
		}

		private string __main_bute_click()
		{
			try
			{
				if (this.LCompareEqual(this.var__main_sleeping, "Y") && this.__main_mycmd.Text.ToUpper(b4p.cul) == "E")
					return "";
				if (this.__main_mycmd.Text.ToUpper(b4p.cul) == "E")
					this.__main_mycmd_keypress('\r'.ToString((IFormatProvider)b4p.cul));
				else if (this.LCompareEqual(this.var__main_abcison, "Y"))
					this.__main_insertchar("E");
				else
					this.__main_insertchar("3");
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_bute_click");
				return "";
			}
		}

		private string __main_butb_click()
		{
			try
			{
				this.__main_insertchar("B");
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_butb_click");
				return "";
			}
		}

		private string __main_butz_click()
		{
			try
			{
				this.__main_insertchar("Z");
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_butz_click");
				return "";
			}
		}

		private string __main_itemhere(string var__main_myitem)
		{
			try
			{
				string[] strArray = (string[])this.var__main_xitemloc;
				int index = var__main_myitem == "" ? 0 : (int)double.Parse(var__main_myitem, (IFormatProvider)b4p.cul);
				string str;
				return this.CompareEqual((str = strArray[index]) == null ? "" : str, this.var__main_playerroom) ? "true" : "false";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_itemhere");
				return "";
			}
		}

		private string __main_buti_click()
		{
			try
			{
				if (this.__main_mycmd.Text.ToUpper(b4p.cul) == "I")
				{
					if (this.LCompareEqual(this.var__main_sleeping, "Y") && this.__main_mycmd.Text.ToUpper(b4p.cul) == "I")
						return "";
					this.__main_mycmd_keypress('\r'.ToString((IFormatProvider)b4p.cul));
				}
				else if (this.LCompareEqual(this.var__main_abcison, "Y"))
					this.__main_insertchar("I");
				else
					this.__main_insertchar("8");
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_buti_click");
				return "";
			}
		}

		private string __main_playerinroom(string var__main_myroom)
		{
			try
			{
				return this.CompareEqual(this.var__main_playerroom, var__main_myroom) ? "true" : "false";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_playerinroom");
				return "";
			}
		}

		private string __main_getitem(string var__main_myitem)
		{
			try
			{
				this.var__main_othernegget = "false";
				if (double.Parse(this.__main_countcarried(), (IFormatProvider)b4p.cul) >= (this.var__main_maxcarry == "" ? 0.0 : double.Parse(this.var__main_maxcarry, (IFormatProvider)b4p.cul)))
				{
					this.var__main_carryingtoomuch = "true";
					return "false";
				}

				// if (this.LCompareEqual(var__main_myitem, -1.0.ToString((IFormatProvider)b4p.cul)))
				if (var__main_myitem == "-1.0")
				{
					this.__main_addtxtmsg("It's beyond my power to do that!<br>");
					this.var__main_othernegget = "true";
					return "false";
				}

				// if (this.LCompareEqual(var__main_myitem, -2.0.ToString((IFormatProvider)b4p.cul)))
				if (var__main_myitem == "-2.0")
				{
					this.__main_addtxtmsg("Don't see it here!<br>");
					this.var__main_othernegget = "true";
					return "false";
				}

				//if (this.LCompareEqual(var__main_myitem, -3.0.ToString((IFormatProvider)b4p.cul)))
				if (var__main_myitem == "-3.0")
				{
					this.__main_addtxtmsg("I already have it.<br>");
					this.var__main_othernegget = "true";
					return "false";
				}
				if ((this.var__main_linkget == "" ? 0.0 : double.Parse(this.var__main_linkget, (IFormatProvider)b4p.cul)) > 0.0)
				{
					((string[])this.var__main_xitemloc)[this.var__main_linkget == "" ? 0 : (int)double.Parse(this.var__main_linkget, (IFormatProvider)b4p.cul)] = this.var__main_carried;
					this.var__main_linkget = "0";
				}
				else
					((string[])this.var__main_xitemloc)[var__main_myitem == "" ? 0 : (int)double.Parse(var__main_myitem, (IFormatProvider)b4p.cul)] = this.var__main_carried;
				return "true";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_getitem");
				return "";
			}
		}

		private string __main_insertchar(string var__main_mychar)
		{
			try
			{
				if ((double)this.__main_mycmd.SelectionLength > 0.0)
					this.__main_butdel_click();
				string @string = this.__main_mycmd.SelectionStart.ToString((IFormatProvider)b4p.cul);
				this.__main_mycmd.Text = this.__main_mycmd.Text.Insert(@string == "" ? 0 : (int)double.Parse(@string, (IFormatProvider)b4p.cul), var__main_mychar);
				this.__main_mycmd.Focus();
				this.__main_mycmd.SelectionStart = (int)((@string == "" ? 0.0 : double.Parse(@string, (IFormatProvider)b4p.cul)) + 1.0);
				this.__main_mycmd.SelectionLength = 0;
				return "";
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_insertchar");
				return "";
			}
		}

		private string __main_readmyno()
		{
			try
			{
				Application.DoEvents();
				string @string = ((double)this.var__main_myfiledata.IndexOf('\n'.ToString((IFormatProvider)b4p.cul), this.var__main_myfiledatapos == "" ? 0 : (int)double.Parse(this.var__main_myfiledatapos, (IFormatProvider)b4p.cul)) - (this.var__main_myfiledatapos == "" ? 0.0 : double.Parse(this.var__main_myfiledatapos, (IFormatProvider)b4p.cul))).ToString((IFormatProvider)b4p.cul);
				string var__main_ttxt = this.Other.SubString(this.var__main_myfiledata, this.var__main_myfiledatapos == "" ? 0 : (int)double.Parse(this.var__main_myfiledatapos, (IFormatProvider)b4p.cul), @string == "" ? 0 : (int)double.Parse(@string, (IFormatProvider)b4p.cul));
				this.var__main_myfiledatapos = ((this.var__main_myfiledatapos == "" ? 0.0 : double.Parse(this.var__main_myfiledatapos, (IFormatProvider)b4p.cul)) + (@string == "" ? 0.0 : double.Parse(@string, (IFormatProvider)b4p.cul)) + 1.0).ToString((IFormatProvider)b4p.cul);
				return this.__main_trim(var__main_ttxt);
			}
			catch (Exception ex)
			{
				this.ShowError(ex, "__main_readmyno");
				return "";
			}
		}

		private void initialize()
		{
			this.htSubs.Add((object)"__main_readmyno", (object)new b4p.del0(this.__main_readmyno));
			this.htSubs.Add((object)"__main_insertchar", (object)new b4p.del1(this.__main_insertchar));
			this.htSubs.Add((object)"__main_getitem", (object)new b4p.del1(this.__main_getitem));
			this.htSubs.Add((object)"__main_playerinroom", (object)new b4p.del1(this.__main_playerinroom));
			this.htSubs.Add((object)"__main_buti_click", (object)new b4p.del0(this.__main_buti_click));
			this.htSubs.Add((object)"__main_itemhere", (object)new b4p.del1(this.__main_itemhere));
			this.htSubs.Add((object)"__main_butz_click", (object)new b4p.del0(this.__main_butz_click));
			this.htSubs.Add((object)"__main_butb_click", (object)new b4p.del0(this.__main_butb_click));
			this.htSubs.Add((object)"__main_bute_click", (object)new b4p.del0(this.__main_bute_click));
			this.htSubs.Add((object)"__main_fengine_click", (object)new b4p.del0(this.__main_fengine_click));
			this.htSubs.Add((object)"__main_butx_click", (object)new b4p.del0(this.__main_butx_click));
			this.htSubs.Add((object)"__main_loadmygame", (object)new b4p.del0(this.__main_loadmygame));
			this.htSubs.Add((object)"__main_butg_click", (object)new b4p.del0(this.__main_butg_click));
			this.htSubs.Add((object)"__main_readitemloc", (object)new b4p.del0(this.__main_readitemloc));
			this.htSubs.Add((object)"__main_loaderror", (object)new b4p.del1(this.__main_loaderror));
			this.htSubs.Add((object)"__main_sendlook", (object)new b4p.del1(this.__main_sendlook));
			this.htSubs.Add((object)"__main_screensizecheck", (object)new b4p.del0(this.__main_screensizecheck));
			this.htSubs.Add((object)"__main_expandoptions", (object)new b4p.del0(this.__main_expandoptions));
			this.htSubs.Add((object)"__main_setflag", (object)new b4p.del1(this.__main_setflag));
			this.htSubs.Add((object)"__main_fadventure_close", (object)new b4p.del0(this.__main_fadventure_close));
			this.htSubs.Add((object)"__main_butd_click", (object)new b4p.del0(this.__main_butd_click));
			this.htSubs.Add((object)"__main_xleft", (object)new b4p.del2(this.__main_xleft));
			this.htSubs.Add((object)"__main_buts_click", (object)new b4p.del0(this.__main_buts_click));
			this.htSubs.Add((object)"__main_webby_navigating", (object)new b4p.del0(this.__main_webby_navigating));
			this.htSubs.Add((object)"__main_look", (object)new b4p.del0(this.__main_look));
			this.htSubs.Add((object)"__main_autoactions", (object)new b4p.del0(this.__main_autoactions));
			this.htSubs.Add((object)"__main_butv_click", (object)new b4p.del0(this.__main_butv_click));
			this.htSubs.Add((object)"__main_buto_click", (object)new b4p.del0(this.__main_buto_click));
			this.htSubs.Add((object)"__main_performactionline", (object)new b4p.del1(this.__main_performactionline));
			this.htSubs.Add((object)"__main_butp_click", (object)new b4p.del0(this.__main_butp_click));
			this.htSubs.Add((object)"__main_loadfile", (object)new b4p.del1(this.__main_loadfile));
			this.htSubs.Add((object)"__main_buty_click", (object)new b4p.del0(this.__main_buty_click));
			this.htSubs.Add((object)"__main_itemdestroyed", (object)new b4p.del1(this.__main_itemdestroyed));
			this.htSubs.Add((object)"__main_butenter_click", (object)new b4p.del0(this.__main_butenter_click));
			this.htSubs.Add((object)"__main_butl_click", (object)new b4p.del0(this.__main_butl_click));
			this.htSubs.Add((object)"__main_app_start", (object)new b4p.del0(this.__main_app_start));
			this.htSubs.Add((object)"__main_countcarrying", (object)new b4p.del0(this.__main_countcarrying));
			this.htSubs.Add((object)"__main_butw_click", (object)new b4p.del0(this.__main_butw_click));
			this.htSubs.Add((object)"__main_resetgeneral", (object)new b4p.del0(this.__main_resetgeneral));
			this.htSubs.Add((object)"__main_butdel_click", (object)new b4p.del0(this.__main_butdel_click));
			this.htSubs.Add((object)"__main_loadthemes", (object)new b4p.del0(this.__main_loadthemes));
			this.htSubs.Add((object)"__main_menusave_click", (object)new b4p.del0(this.__main_menusave_click));
			this.htSubs.Add((object)"__main_menuload_click", (object)new b4p.del0(this.__main_menuload_click));
			this.htSubs.Add((object)"__main_getflag", (object)new b4p.del1(this.__main_getflag));
			this.htSubs.Add((object)"__main_iteminoriginalroom", (object)new b4p.del1(this.__main_iteminoriginalroom));
			this.htSubs.Add((object)"__main_dropitem", (object)new b4p.del1(this.__main_dropitem));
			this.htSubs.Add((object)"__main_itemcarried", (object)new b4p.del1(this.__main_itemcarried));
			this.htSubs.Add((object)"__main_refreshweb", (object)new b4p.del0(this.__main_refreshweb));
			this.htSubs.Add((object)"__main_faboutscott_click", (object)new b4p.del0(this.__main_faboutscott_click));
			this.htSubs.Add((object)"__main_addtxtexits", (object)new b4p.del1(this.__main_addtxtexits));
			this.htSubs.Add((object)"__main_butother_click", (object)new b4p.del0(this.__main_butother_click));
			this.htSubs.Add((object)"__main_html_stuff", (object)new b4p.del0(this.__main_html_stuff));
			this.htSubs.Add((object)"__main_whichitem", (object)new b4p.del2(this.__main_whichitem));
			this.htSubs.Add((object)"__main_addtxtmsg", (object)new b4p.del1(this.__main_addtxtmsg));
			this.htSubs.Add((object)"__main_butmag_click", (object)new b4p.del0(this.__main_butmag_click));
			this.htSubs.Add((object)"__main_filllamp", (object)new b4p.del0(this.__main_filllamp));
			this.htSubs.Add((object)"__main_butj_click", (object)new b4p.del0(this.__main_butj_click));
			this.htSubs.Add((object)"__main_savemygame", (object)new b4p.del0(this.__main_savemygame));
			this.htSubs.Add((object)"__main_readitemtext", (object)new b4p.del0(this.__main_readitemtext));
			this.htSubs.Add((object)"__main_dropcommand", (object)new b4p.del1(this.__main_dropcommand));
			this.htSubs.Add((object)"__main_butu_click", (object)new b4p.del0(this.__main_butu_click));
			this.htSubs.Add((object)"__main_resetvars", (object)new b4p.del0(this.__main_resetvars));
			this.htSubs.Add((object)"__main_randompercent", (object)new b4p.del1(this.__main_randompercent));
			this.htSubs.Add((object)"__main_butm_click", (object)new b4p.del0(this.__main_butm_click));
			this.htSubs.Add((object)"__main_inventory", (object)new b4p.del0(this.__main_inventory));
			this.htSubs.Add((object)"__main_trim", (object)new b4p.del1(this.__main_trim));
			this.htSubs.Add((object)"__main_butelc_click", (object)new b4p.del0(this.__main_butelc_click));
			this.htSubs.Add((object)"__main_redraw", (object)new b4p.del0(this.__main_redraw));
			this.htSubs.Add((object)"__main_itemavailable", (object)new b4p.del1(this.__main_itemavailable));
			this.htSubs.Add((object)"__main_removebrfromtxtmsg", (object)new b4p.del0(this.__main_removebrfromtxtmsg));
			this.htSubs.Add((object)"__main_clearflag", (object)new b4p.del1(this.__main_clearflag));
			this.htSubs.Add((object)"__main_addtxtlook", (object)new b4p.del1(this.__main_addtxtlook));
			this.htSubs.Add((object)"__main_butt_click", (object)new b4p.del0(this.__main_butt_click));
			this.htSubs.Add((object)"__main_pdselect_selectionchanged", (object)new b4p.del2(this.__main_pdselect_selectionchanged));
			this.htSubs.Add((object)"__main_killplayer", (object)new b4p.del0(this.__main_killplayer));
			this.htSubs.Add((object)"__main_menuoptions_click", (object)new b4p.del0(this.__main_menuoptions_click));
			this.htSubs.Add((object)"__main_checkforspelling", (object)new b4p.del1(this.__main_checkforspelling));
			this.htSubs.Add((object)"__main_score", (object)new b4p.del0(this.__main_score));
			this.htSubs.Add((object)"__main_readmystr", (object)new b4p.del0(this.__main_readmystr));
			this.htSubs.Add((object)"__main_countcarried", (object)new b4p.del0(this.__main_countcarried));
			this.htSubs.Add((object)"__main_butc_click", (object)new b4p.del0(this.__main_butc_click));
			this.htSubs.Add((object)"__main_isdark", (object)new b4p.del0(this.__main_isdark));
			this.htSubs.Add((object)"__main_quit", (object)new b4p.del0(this.__main_quit));
			this.htSubs.Add((object)"__main_performcommand", (object)new b4p.del0(this.__main_performcommand));
			this.htSubs.Add((object)"__main_butgo_click", (object)new b4p.del0(this.__main_butgo_click));
			this.htSubs.Add((object)"__main_butinv_click", (object)new b4p.del0(this.__main_butinv_click));
			this.htSubs.Add((object)"__main_worklight", (object)new b4p.del0(this.__main_worklight));
			this.htSubs.Add((object)"__main_butf_click", (object)new b4p.del0(this.__main_butf_click));
			this.htSubs.Add((object)"__main_butgetdrop_click", (object)new b4p.del0(this.__main_butgetdrop_click));
			this.htSubs.Add((object)"__main_movecommand", (object)new b4p.del0(this.__main_movecommand));
			this.htSubs.Add((object)"__main_readoptionsfromfile", (object)new b4p.del0(this.__main_readoptionsfromfile));
			this.htSubs.Add((object)"__main_butabc123_click", (object)new b4p.del0(this.__main_butabc123_click));
			this.htSubs.Add((object)"__main_checkinvext", (object)new b4p.del1(this.__main_checkinvext));
			this.htSubs.Add((object)"__main_createdummy", (object)new b4p.del0(this.__main_createdummy));
			this.htSubs.Add((object)"__main_hx", (object)new b4p.del1(this.__main_hx));
			this.htSubs.Add((object)"__main_timer1_tick", (object)new b4p.del0(this.__main_timer1_tick));
			this.htSubs.Add((object)"__main_butr_click", (object)new b4p.del0(this.__main_butr_click));
			this.htSubs.Add((object)"__main_butk_click", (object)new b4p.del0(this.__main_butk_click));
			this.htSubs.Add((object)"__main_butapply_click", (object)new b4p.del0(this.__main_butapply_click));
			this.htSubs.Add((object)"__main_butplay_click", (object)new b4p.del0(this.__main_butplay_click));
			this.htSubs.Add((object)"__main_butspace_click", (object)new b4p.del0(this.__main_butspace_click));
			this.htSubs.Add((object)"__main_showsoftkeyboard", (object)new b4p.del1(this.__main_showsoftkeyboard));
			this.htSubs.Add((object)"__main_treasurecheck", (object)new b4p.del1(this.__main_treasurecheck));
			this.htSubs.Add((object)"__main_clearscreen", (object)new b4p.del0(this.__main_clearscreen));
			this.htSubs.Add((object)"__main_butn_click", (object)new b4p.del0(this.__main_butn_click));
			this.htSubs.Add((object)"__main_readmytheme", (object)new b4p.del1(this.__main_readmytheme));
			this.htSubs.Add((object)"__main_checkinput", (object)new b4p.del0(this.__main_checkinput));
			this.htSubs.Add((object)"__main_butq_click", (object)new b4p.del0(this.__main_butq_click));
			this.htSubs.Add((object)"__main_buth_click", (object)new b4p.del0(this.__main_buth_click));
			this.htSubs.Add((object)"__main_menunew_click", (object)new b4p.del0(this.__main_menunew_click));
			this.htSubs.Add((object)"__main_kbdonoff_click", (object)new b4p.del0(this.__main_kbdonoff_click));
			this.htSubs.Add((object)"__main_getcommand", (object)new b4p.del1(this.__main_getcommand));
			this.htSubs.Add((object)"__main_hx2", (object)new b4p.del1(this.__main_hx2));
			this.htSubs.Add((object)"__main_buthelp_click", (object)new b4p.del0(this.__main_buthelp_click));
			this.htSubs.Add((object)"__main_mycmd_keypress", (object)new b4p.del1(this.__main_mycmd_keypress));
			this.htSubs.Add((object)"__main_whichword", (object)new b4p.del2(this.__main_whichword));
			this.htSubs.Add((object)"__main_right", (object)new b4p.del2(this.__main_right));
			this.htSubs.Add((object)"__main_saveoptionstofile", (object)new b4p.del0(this.__main_saveoptionstofile));
			this.htSubs.Add((object)"__main_buta_click", (object)new b4p.del0(this.__main_buta_click));
			this.screenX = 238;
			this.screenY = 268;
			this.icon = "Dbasic.Resources.advpda.ico";
			this.__main_fadventure = new CEnhancedForm(this);
			this.__main_fadventure.name = "__main_fadventure";
			this.__main_fadventure.Text = "Adventure PDA";
			this.__main_fadventure.BackColor = Color.FromArgb(-16744193);
			this.__main_fadventure.graphics.FillRectangle((Brush)new SolidBrush(this.__main_fadventure.BackColor), 0, 0, this.__main_fadventure.Width, this.__main_fadventure.Height);
			this.__main_fadventure.AddEvents();
			this.htControls.Add((object)"__main_fadventure", (object)this.__main_fadventure);
			this.__main_butabc123 = new CEnhancedImageButton(this);
			this.__main_butabc123.name = "__main_butabc123";
			this.__main_butabc123.Left = 3;
			this.__main_butabc123.Top = 229;
			this.__main_butabc123.Width = 16;
			this.__main_butabc123.Height = 36;
			this.__main_butabc123.Text = "";
			this.__main_butabc123.BackColor = Color.FromArgb(-2830136);
			this.__main_butabc123.ForeColor = Color.FromArgb(-16777216);
			this.__main_butabc123.imageMode = "cStretchImage";
			this.__main_butabc123.Transparent = true;
			this.__main_butabc123.Enabled = true;
			this.__main_butabc123.Visible = false;
			this.__main_butabc123.MyBitmap = this.Other.GetBitmapFromResource("b4p.images\\abc123.bmp");
			this.__main_butabc123.Font = new Font(this.__main_butabc123.Font.Name, 9f, this.__main_butabc123.Font.Style);
			this.__main_butabc123.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_butabc123);
			this.htControls.Add((object)"__main_butabc123", (object)this.__main_butabc123);
			this.__main_butgo = new CEnhancedImageButton(this);
			this.__main_butgo.name = "__main_butgo";
			this.__main_butgo.Left = 92;
			this.__main_butgo.Top = 168;
			this.__main_butgo.Width = 18;
			this.__main_butgo.Height = 18;
			this.__main_butgo.Text = "";
			this.__main_butgo.BackColor = Color.FromArgb(-16777216);
			this.__main_butgo.ForeColor = Color.FromArgb(-16777216);
			this.__main_butgo.imageMode = "cStretchImage";
			this.__main_butgo.Transparent = false;
			this.__main_butgo.Enabled = true;
			this.__main_butgo.Visible = true;
			this.__main_butgo.MyBitmap = this.Other.GetBitmapFromResource("b4p.images\\butenter2.bmp");
			this.__main_butgo.Font = new Font(this.__main_butgo.Font.Name, 9f, this.__main_butgo.Font.Style);
			this.__main_butgo.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_butgo);
			this.htControls.Add((object)"__main_butgo", (object)this.__main_butgo);
			this.__main_timer1 = new CEnhancedTimer(this);
			this.__main_timer1.name = "__main_timer1";
			this.__main_timer1.Enabled = false;
			this.__main_timer1.Interval = 100;
			this.__main_timer1.AddEvents();
			this.htControls.Add((object)"__main_timer1", (object)this.__main_timer1);
			this.__main_loaddialog1 = new OpenFileDialog();
			this.__main_loaddialog1.Filter = "Save Files|*.sav";
			this.htControls.Add((object)"__main_loaddialog1", (object)this.__main_loaddialog1);
			this.__main_savedialog1 = new SaveFileDialog();
			this.__main_savedialog1.Filter = "Save Files|*.sav";
			this.htControls.Add((object)"__main_savedialog1", (object)this.__main_savedialog1);
			this.__main_buthelp = new CEnhancedImageButton(this);
			this.__main_buthelp.name = "__main_buthelp";
			this.__main_buthelp.Left = 214;
			this.__main_buthelp.Top = 167;
			this.__main_buthelp.Width = 22;
			this.__main_buthelp.Height = 21;
			this.__main_buthelp.Text = "";
			this.__main_buthelp.BackColor = Color.FromArgb(-2830136);
			this.__main_buthelp.ForeColor = Color.FromArgb(-16777216);
			this.__main_buthelp.imageMode = "cStretchImage";
			this.__main_buthelp.Transparent = true;
			this.__main_buthelp.Enabled = true;
			this.__main_buthelp.Visible = true;
			this.__main_buthelp.MyBitmap = this.Other.GetBitmapFromResource("b4p.images\\help.bmp");
			this.__main_buthelp.Font = new Font(this.__main_buthelp.Font.Name, 9f, this.__main_buthelp.Font.Style);
			this.__main_buthelp.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_buthelp);
			this.htControls.Add((object)"__main_buthelp", (object)this.__main_buthelp);
			this.__main_butinv = new CEnhancedImageButton(this);
			this.__main_butinv.name = "__main_butinv";
			this.__main_butinv.Left = 190;
			this.__main_butinv.Top = 167;
			this.__main_butinv.Width = 21;
			this.__main_butinv.Height = 21;
			this.__main_butinv.Text = "";
			this.__main_butinv.BackColor = Color.FromArgb(-2830136);
			this.__main_butinv.ForeColor = Color.FromArgb(-16777216);
			this.__main_butinv.imageMode = "cStretchImage";
			this.__main_butinv.Transparent = true;
			this.__main_butinv.Enabled = true;
			this.__main_butinv.Visible = true;
			this.__main_butinv.MyBitmap = this.Other.GetBitmapFromResource("b4p.images\\inv.bmp");
			this.__main_butinv.Font = new Font(this.__main_butinv.Font.Name, 9f, this.__main_butinv.Font.Style);
			this.__main_butinv.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_butinv);
			this.htControls.Add((object)"__main_butinv", (object)this.__main_butinv);
			this.__main_butelc = new CEnhancedImageButton(this);
			this.__main_butelc.name = "__main_butelc";
			this.__main_butelc.Left = 142;
			this.__main_butelc.Top = 167;
			this.__main_butelc.Width = 20;
			this.__main_butelc.Height = 21;
			this.__main_butelc.Text = "";
			this.__main_butelc.BackColor = Color.FromArgb(-2830136);
			this.__main_butelc.ForeColor = Color.FromArgb(-16777216);
			this.__main_butelc.imageMode = "cStretchImage";
			this.__main_butelc.Transparent = true;
			this.__main_butelc.Enabled = true;
			this.__main_butelc.Visible = true;
			this.__main_butelc.MyBitmap = this.Other.GetBitmapFromResource("b4p.images\\move.bmp");
			this.__main_butelc.Font = new Font(this.__main_butelc.Font.Name, 9f, this.__main_butelc.Font.Style);
			this.__main_butelc.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_butelc);
			this.htControls.Add((object)"__main_butelc", (object)this.__main_butelc);
			this.__main_butmag = new CEnhancedImageButton(this);
			this.__main_butmag.name = "__main_butmag";
			this.__main_butmag.Left = 165;
			this.__main_butmag.Top = 167;
			this.__main_butmag.Width = 21;
			this.__main_butmag.Height = 21;
			this.__main_butmag.Text = "";
			this.__main_butmag.BackColor = Color.FromArgb(-2830136);
			this.__main_butmag.ForeColor = Color.FromArgb(-16777216);
			this.__main_butmag.imageMode = "cStretchImage";
			this.__main_butmag.Transparent = true;
			this.__main_butmag.Enabled = true;
			this.__main_butmag.Visible = true;
			this.__main_butmag.MyBitmap = this.Other.GetBitmapFromResource("b4p.images\\magglass.bmp");
			this.__main_butmag.Font = new Font(this.__main_butmag.Font.Name, 9f, this.__main_butmag.Font.Style);
			this.__main_butmag.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_butmag);
			this.htControls.Add((object)"__main_butmag", (object)this.__main_butmag);
			this.__main_butgetdrop = new CEnhancedImageButton(this);
			this.__main_butgetdrop.name = "__main_butgetdrop";
			this.__main_butgetdrop.Left = 112;
			this.__main_butgetdrop.Top = 167;
			this.__main_butgetdrop.Width = 27;
			this.__main_butgetdrop.Height = 21;
			this.__main_butgetdrop.Text = "";
			this.__main_butgetdrop.BackColor = Color.FromArgb(-2830136);
			this.__main_butgetdrop.ForeColor = Color.FromArgb(-16777216);
			this.__main_butgetdrop.imageMode = "cStretchImage";
			this.__main_butgetdrop.Transparent = true;
			this.__main_butgetdrop.Enabled = true;
			this.__main_butgetdrop.Visible = true;
			this.__main_butgetdrop.MyBitmap = this.Other.GetBitmapFromResource("b4p.images\\\\getdrop.bmp");
			this.__main_butgetdrop.Font = new Font(this.__main_butgetdrop.Font.Name, 9f, this.__main_butgetdrop.Font.Style);
			this.__main_butgetdrop.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_butgetdrop);
			this.htControls.Add((object)"__main_butgetdrop", (object)this.__main_butgetdrop);
			this.__main_butdel = new CEnhancedImageButton(this);
			this.__main_butdel.name = "__main_butdel";
			this.__main_butdel.Left = 202;
			this.__main_butdel.Top = 211;
			this.__main_butdel.Width = 36;
			this.__main_butdel.Height = 18;
			this.__main_butdel.Text = "";
			this.__main_butdel.BackColor = Color.FromArgb(-16777216);
			this.__main_butdel.ForeColor = Color.FromArgb(-16777216);
			this.__main_butdel.imageMode = "cStretchImage";
			this.__main_butdel.Transparent = false;
			this.__main_butdel.Enabled = false;
			this.__main_butdel.Visible = false;
			this.__main_butdel.MyBitmap = this.Other.GetBitmapFromResource("b4p.images\\butdel.bmp");
			this.__main_butdel.Font = new Font(this.__main_butdel.Font.Name, 9f, this.__main_butdel.Font.Style);
			this.__main_butdel.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_butdel);
			this.htControls.Add((object)"__main_butdel", (object)this.__main_butdel);
			this.__main_butenter = new CEnhancedImageButton(this);
			this.__main_butenter.name = "__main_butenter";
			this.__main_butenter.Left = 202;
			this.__main_butenter.Top = 229;
			this.__main_butenter.Width = 36;
			this.__main_butenter.Height = 36;
			this.__main_butenter.Text = "";
			this.__main_butenter.BackColor = Color.FromArgb(-8323200);
			this.__main_butenter.ForeColor = Color.FromArgb(-16777216);
			this.__main_butenter.imageMode = "cStretchImage";
			this.__main_butenter.Transparent = false;
			this.__main_butenter.Enabled = false;
			this.__main_butenter.Visible = false;
			this.__main_butenter.MyBitmap = this.Other.GetBitmapFromResource("b4p.images\\butenter.bmp");
			this.__main_butenter.Font = new Font(this.__main_butenter.Font.Name, 9f, this.__main_butenter.Font.Style);
			this.__main_butenter.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_butenter);
			this.htControls.Add((object)"__main_butenter", (object)this.__main_butenter);
			this.__main_butspace = new CEnhancedButton(this);
			this.__main_butspace.name = "__main_butspace";
			this.__main_butspace.Left = 81;
			this.__main_butspace.Top = 247;
			this.__main_butspace.Width = 40;
			this.__main_butspace.Height = 18;
			this.__main_butspace.Text = "__";
			this.__main_butspace.BackColor = Color.FromArgb(-71);
			this.__main_butspace.ForeColor = Color.FromArgb(-16777216);
			this.__main_butspace.Enabled = true;
			this.__main_butspace.Visible = false;
			this.__main_butspace.Font = new Font(this.__main_butspace.Font.Name, 10f, this.__main_butspace.Font.Style);
			this.__main_butspace.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_butspace);
			this.htControls.Add((object)"__main_butspace", (object)this.__main_butspace);
			this.__main_butb = new CEnhancedButton(this);
			this.__main_butb.name = "__main_butb";
			this.__main_butb.Left = 141;
			this.__main_butb.Top = 247;
			this.__main_butb.Width = 20;
			this.__main_butb.Height = 18;
			this.__main_butb.Text = "B";
			this.__main_butb.BackColor = Color.FromArgb(-71);
			this.__main_butb.ForeColor = Color.FromArgb(-16760704);
			this.__main_butb.Enabled = true;
			this.__main_butb.Visible = false;
			this.__main_butb.Font = new Font(this.__main_butb.Font.Name, 10f, this.__main_butb.Font.Style);
			this.__main_butb.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_butb);
			this.htControls.Add((object)"__main_butb", (object)this.__main_butb);
			this.__main_butm = new CEnhancedButton(this);
			this.__main_butm.name = "__main_butm";
			this.__main_butm.Left = 181;
			this.__main_butm.Top = 247;
			this.__main_butm.Width = 20;
			this.__main_butm.Height = 18;
			this.__main_butm.Text = "M";
			this.__main_butm.BackColor = Color.FromArgb(-71);
			this.__main_butm.ForeColor = Color.FromArgb(-16760704);
			this.__main_butm.Enabled = true;
			this.__main_butm.Visible = false;
			this.__main_butm.Font = new Font(this.__main_butm.Font.Name, 10f, this.__main_butm.Font.Style);
			this.__main_butm.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_butm);
			this.htControls.Add((object)"__main_butm", (object)this.__main_butm);
			this.__main_butn = new CEnhancedButton(this);
			this.__main_butn.name = "__main_butn";
			this.__main_butn.Left = 161;
			this.__main_butn.Top = 247;
			this.__main_butn.Width = 20;
			this.__main_butn.Height = 18;
			this.__main_butn.Text = "N";
			this.__main_butn.BackColor = Color.FromArgb(-71);
			this.__main_butn.ForeColor = Color.FromArgb(-16760704);
			this.__main_butn.Enabled = true;
			this.__main_butn.Visible = false;
			this.__main_butn.Font = new Font(this.__main_butn.Font.Name, 10f, this.__main_butn.Font.Style);
			this.__main_butn.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_butn);
			this.htControls.Add((object)"__main_butn", (object)this.__main_butn);
			this.__main_butx = new CEnhancedButton(this);
			this.__main_butx.name = "__main_butx";
			this.__main_butx.Left = 41;
			this.__main_butx.Top = 247;
			this.__main_butx.Width = 20;
			this.__main_butx.Height = 18;
			this.__main_butx.Text = "X";
			this.__main_butx.BackColor = Color.FromArgb(-71);
			this.__main_butx.ForeColor = Color.FromArgb(-16760704);
			this.__main_butx.Enabled = true;
			this.__main_butx.Visible = false;
			this.__main_butx.Font = new Font(this.__main_butx.Font.Name, 10f, this.__main_butx.Font.Style);
			this.__main_butx.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_butx);
			this.htControls.Add((object)"__main_butx", (object)this.__main_butx);
			this.__main_butc = new CEnhancedButton(this);
			this.__main_butc.name = "__main_butc";
			this.__main_butc.Left = 61;
			this.__main_butc.Top = 247;
			this.__main_butc.Width = 20;
			this.__main_butc.Height = 18;
			this.__main_butc.Text = "C";
			this.__main_butc.BackColor = Color.FromArgb(-71);
			this.__main_butc.ForeColor = Color.FromArgb(-16760704);
			this.__main_butc.Enabled = true;
			this.__main_butc.Visible = false;
			this.__main_butc.Font = new Font(this.__main_butc.Font.Name, 10f, this.__main_butc.Font.Style);
			this.__main_butc.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_butc);
			this.htControls.Add((object)"__main_butc", (object)this.__main_butc);
			this.__main_butv = new CEnhancedButton(this);
			this.__main_butv.name = "__main_butv";
			this.__main_butv.Left = 121;
			this.__main_butv.Top = 247;
			this.__main_butv.Width = 20;
			this.__main_butv.Height = 18;
			this.__main_butv.Text = "V";
			this.__main_butv.BackColor = Color.FromArgb(-71);
			this.__main_butv.ForeColor = Color.FromArgb(-16760704);
			this.__main_butv.Enabled = true;
			this.__main_butv.Visible = false;
			this.__main_butv.Font = new Font(this.__main_butv.Font.Name, 10f, this.__main_butv.Font.Style);
			this.__main_butv.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_butv);
			this.htControls.Add((object)"__main_butv", (object)this.__main_butv);
			this.__main_butz = new CEnhancedButton(this);
			this.__main_butz.name = "__main_butz";
			this.__main_butz.Left = 21;
			this.__main_butz.Top = 247;
			this.__main_butz.Width = 20;
			this.__main_butz.Height = 18;
			this.__main_butz.Text = "Z";
			this.__main_butz.BackColor = Color.FromArgb(-71);
			this.__main_butz.ForeColor = Color.FromArgb(-16760704);
			this.__main_butz.Enabled = true;
			this.__main_butz.Visible = false;
			this.__main_butz.Font = new Font(this.__main_butz.Font.Name, 10f, this.__main_butz.Font.Style);
			this.__main_butz.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_butz);
			this.htControls.Add((object)"__main_butz", (object)this.__main_butz);
			this.__main_buta = new CEnhancedButton(this);
			this.__main_buta.name = "__main_buta";
			this.__main_buta.Left = 21;
			this.__main_buta.Top = 229;
			this.__main_buta.Width = 20;
			this.__main_buta.Height = 18;
			this.__main_buta.Text = "A";
			this.__main_buta.BackColor = Color.FromArgb(-71);
			this.__main_buta.ForeColor = Color.FromArgb(-16760704);
			this.__main_buta.Enabled = true;
			this.__main_buta.Visible = false;
			this.__main_buta.Font = new Font(this.__main_buta.Font.Name, 10f, this.__main_buta.Font.Style);
			this.__main_buta.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_buta);
			this.htControls.Add((object)"__main_buta", (object)this.__main_buta);
			this.__main_buts = new CEnhancedButton(this);
			this.__main_buts.name = "__main_buts";
			this.__main_buts.Left = 41;
			this.__main_buts.Top = 229;
			this.__main_buts.Width = 20;
			this.__main_buts.Height = 18;
			this.__main_buts.Text = "S";
			this.__main_buts.BackColor = Color.FromArgb(-71);
			this.__main_buts.ForeColor = Color.FromArgb(-16760704);
			this.__main_buts.Enabled = true;
			this.__main_buts.Visible = false;
			this.__main_buts.Font = new Font(this.__main_buts.Font.Name, 10f, this.__main_buts.Font.Style);
			this.__main_buts.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_buts);
			this.htControls.Add((object)"__main_buts", (object)this.__main_buts);
			this.__main_butd = new CEnhancedButton(this);
			this.__main_butd.name = "__main_butd";
			this.__main_butd.Left = 61;
			this.__main_butd.Top = 229;
			this.__main_butd.Width = 20;
			this.__main_butd.Height = 18;
			this.__main_butd.Text = "D";
			this.__main_butd.BackColor = Color.FromArgb(-71);
			this.__main_butd.ForeColor = Color.FromArgb(-16760704);
			this.__main_butd.Enabled = true;
			this.__main_butd.Visible = false;
			this.__main_butd.Font = new Font(this.__main_butd.Font.Name, 10f, this.__main_butd.Font.Style);
			this.__main_butd.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_butd);
			this.htControls.Add((object)"__main_butd", (object)this.__main_butd);
			this.__main_buth = new CEnhancedButton(this);
			this.__main_buth.name = "__main_buth";
			this.__main_buth.Left = 121;
			this.__main_buth.Top = 229;
			this.__main_buth.Width = 20;
			this.__main_buth.Height = 18;
			this.__main_buth.Text = "H";
			this.__main_buth.BackColor = Color.FromArgb(-71);
			this.__main_buth.ForeColor = Color.FromArgb(-16760704);
			this.__main_buth.Enabled = true;
			this.__main_buth.Visible = false;
			this.__main_buth.Font = new Font(this.__main_buth.Font.Name, 10f, this.__main_buth.Font.Style);
			this.__main_buth.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_buth);
			this.htControls.Add((object)"__main_buth", (object)this.__main_buth);
			this.__main_butg = new CEnhancedButton(this);
			this.__main_butg.name = "__main_butg";
			this.__main_butg.Left = 101;
			this.__main_butg.Top = 229;
			this.__main_butg.Width = 20;
			this.__main_butg.Height = 18;
			this.__main_butg.Text = "G";
			this.__main_butg.BackColor = Color.FromArgb(-71);
			this.__main_butg.ForeColor = Color.FromArgb(-16760704);
			this.__main_butg.Enabled = true;
			this.__main_butg.Visible = false;
			this.__main_butg.Font = new Font(this.__main_butg.Font.Name, 10f, this.__main_butg.Font.Style);
			this.__main_butg.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_butg);
			this.htControls.Add((object)"__main_butg", (object)this.__main_butg);
			this.__main_butf = new CEnhancedButton(this);
			this.__main_butf.name = "__main_butf";
			this.__main_butf.Left = 81;
			this.__main_butf.Top = 229;
			this.__main_butf.Width = 20;
			this.__main_butf.Height = 18;
			this.__main_butf.Text = "F";
			this.__main_butf.BackColor = Color.FromArgb(-71);
			this.__main_butf.ForeColor = Color.FromArgb(-16760704);
			this.__main_butf.Enabled = true;
			this.__main_butf.Visible = false;
			this.__main_butf.Font = new Font(this.__main_butf.Font.Name, 10f, this.__main_butf.Font.Style);
			this.__main_butf.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_butf);
			this.htControls.Add((object)"__main_butf", (object)this.__main_butf);
			this.__main_butk = new CEnhancedButton(this);
			this.__main_butk.name = "__main_butk";
			this.__main_butk.Left = 161;
			this.__main_butk.Top = 229;
			this.__main_butk.Width = 20;
			this.__main_butk.Height = 18;
			this.__main_butk.Text = "K";
			this.__main_butk.BackColor = Color.FromArgb(-71);
			this.__main_butk.ForeColor = Color.FromArgb(-16760704);
			this.__main_butk.Enabled = true;
			this.__main_butk.Visible = false;
			this.__main_butk.Font = new Font(this.__main_butk.Font.Name, 10f, this.__main_butk.Font.Style);
			this.__main_butk.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_butk);
			this.htControls.Add((object)"__main_butk", (object)this.__main_butk);
			this.__main_butl = new CEnhancedButton(this);
			this.__main_butl.name = "__main_butl";
			this.__main_butl.Left = 181;
			this.__main_butl.Top = 229;
			this.__main_butl.Width = 20;
			this.__main_butl.Height = 18;
			this.__main_butl.Text = "L";
			this.__main_butl.BackColor = Color.FromArgb(-71);
			this.__main_butl.ForeColor = Color.FromArgb(-16760704);
			this.__main_butl.Enabled = true;
			this.__main_butl.Visible = false;
			this.__main_butl.Font = new Font(this.__main_butl.Font.Name, 10f, this.__main_butl.Font.Style);
			this.__main_butl.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_butl);
			this.htControls.Add((object)"__main_butl", (object)this.__main_butl);
			this.__main_butj = new CEnhancedButton(this);
			this.__main_butj.name = "__main_butj";
			this.__main_butj.Left = 141;
			this.__main_butj.Top = 229;
			this.__main_butj.Width = 20;
			this.__main_butj.Height = 18;
			this.__main_butj.Text = "J";
			this.__main_butj.BackColor = Color.FromArgb(-71);
			this.__main_butj.ForeColor = Color.FromArgb(-16760704);
			this.__main_butj.Enabled = true;
			this.__main_butj.Visible = false;
			this.__main_butj.Font = new Font(this.__main_butj.Font.Name, 10f, this.__main_butj.Font.Style);
			this.__main_butj.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_butj);
			this.htControls.Add((object)"__main_butj", (object)this.__main_butj);
			this.__main_butu = new CEnhancedButton(this);
			this.__main_butu.name = "__main_butu";
			this.__main_butu.Left = 121;
			this.__main_butu.Top = 211;
			this.__main_butu.Width = 20;
			this.__main_butu.Height = 18;
			this.__main_butu.Text = "U";
			this.__main_butu.BackColor = Color.FromArgb(-71);
			this.__main_butu.ForeColor = Color.FromArgb(-16760704);
			this.__main_butu.Enabled = true;
			this.__main_butu.Visible = false;
			this.__main_butu.Font = new Font(this.__main_butu.Font.Name, 10f, this.__main_butu.Font.Style);
			this.__main_butu.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_butu);
			this.htControls.Add((object)"__main_butu", (object)this.__main_butu);
			this.__main_butp = new CEnhancedButton(this);
			this.__main_butp.name = "__main_butp";
			this.__main_butp.Left = 181;
			this.__main_butp.Top = 211;
			this.__main_butp.Width = 20;
			this.__main_butp.Height = 18;
			this.__main_butp.Text = "P";
			this.__main_butp.BackColor = Color.FromArgb(-71);
			this.__main_butp.ForeColor = Color.FromArgb(-16760704);
			this.__main_butp.Enabled = true;
			this.__main_butp.Visible = false;
			this.__main_butp.Font = new Font(this.__main_butp.Font.Name, 10f, this.__main_butp.Font.Style);
			this.__main_butp.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_butp);
			this.htControls.Add((object)"__main_butp", (object)this.__main_butp);
			this.__main_buto = new CEnhancedButton(this);
			this.__main_buto.name = "__main_buto";
			this.__main_buto.Left = 161;
			this.__main_buto.Top = 211;
			this.__main_buto.Width = 20;
			this.__main_buto.Height = 18;
			this.__main_buto.Text = "O";
			this.__main_buto.BackColor = Color.FromArgb(-71);
			this.__main_buto.ForeColor = Color.FromArgb(-16760704);
			this.__main_buto.Enabled = true;
			this.__main_buto.Visible = false;
			this.__main_buto.Font = new Font(this.__main_buto.Font.Name, 10f, this.__main_buto.Font.Style);
			this.__main_buto.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_buto);
			this.htControls.Add((object)"__main_buto", (object)this.__main_buto);
			this.__main_buti = new CEnhancedButton(this);
			this.__main_buti.name = "__main_buti";
			this.__main_buti.Left = 141;
			this.__main_buti.Top = 211;
			this.__main_buti.Width = 20;
			this.__main_buti.Height = 18;
			this.__main_buti.Text = "I";
			this.__main_buti.BackColor = Color.FromArgb(-71);
			this.__main_buti.ForeColor = Color.FromArgb(-16760704);
			this.__main_buti.Enabled = true;
			this.__main_buti.Visible = false;
			this.__main_buti.Font = new Font(this.__main_buti.Font.Name, 10f, this.__main_buti.Font.Style);
			this.__main_buti.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_buti);
			this.htControls.Add((object)"__main_buti", (object)this.__main_buti);
			this.__main_butr = new CEnhancedButton(this);
			this.__main_butr.name = "__main_butr";
			this.__main_butr.Left = 61;
			this.__main_butr.Top = 211;
			this.__main_butr.Width = 20;
			this.__main_butr.Height = 18;
			this.__main_butr.Text = "R";
			this.__main_butr.BackColor = Color.FromArgb(-71);
			this.__main_butr.ForeColor = Color.FromArgb(-16760704);
			this.__main_butr.Enabled = true;
			this.__main_butr.Visible = false;
			this.__main_butr.Font = new Font(this.__main_butr.Font.Name, 10f, this.__main_butr.Font.Style);
			this.__main_butr.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_butr);
			this.htControls.Add((object)"__main_butr", (object)this.__main_butr);
			this.__main_butt = new CEnhancedButton(this);
			this.__main_butt.name = "__main_butt";
			this.__main_butt.Left = 81;
			this.__main_butt.Top = 211;
			this.__main_butt.Width = 20;
			this.__main_butt.Height = 18;
			this.__main_butt.Text = "T";
			this.__main_butt.BackColor = Color.FromArgb(-71);
			this.__main_butt.ForeColor = Color.FromArgb(-16760704);
			this.__main_butt.Enabled = true;
			this.__main_butt.Visible = false;
			this.__main_butt.Font = new Font(this.__main_butt.Font.Name, 10f, this.__main_butt.Font.Style);
			this.__main_butt.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_butt);
			this.htControls.Add((object)"__main_butt", (object)this.__main_butt);
			this.__main_buty = new CEnhancedButton(this);
			this.__main_buty.name = "__main_buty";
			this.__main_buty.Left = 101;
			this.__main_buty.Top = 211;
			this.__main_buty.Width = 20;
			this.__main_buty.Height = 18;
			this.__main_buty.Text = "Y";
			this.__main_buty.BackColor = Color.FromArgb(-71);
			this.__main_buty.ForeColor = Color.FromArgb(-16760704);
			this.__main_buty.Enabled = true;
			this.__main_buty.Visible = false;
			this.__main_buty.Font = new Font(this.__main_buty.Font.Name, 10f, this.__main_buty.Font.Style);
			this.__main_buty.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_buty);
			this.htControls.Add((object)"__main_buty", (object)this.__main_buty);
			this.__main_bute = new CEnhancedButton(this);
			this.__main_bute.name = "__main_bute";
			this.__main_bute.Left = 41;
			this.__main_bute.Top = 211;
			this.__main_bute.Width = 20;
			this.__main_bute.Height = 18;
			this.__main_bute.Text = "E";
			this.__main_bute.BackColor = Color.FromArgb(-71);
			this.__main_bute.ForeColor = Color.FromArgb(-16760704);
			this.__main_bute.Enabled = true;
			this.__main_bute.Visible = false;
			this.__main_bute.Font = new Font(this.__main_bute.Font.Name, 10f, this.__main_bute.Font.Style);
			this.__main_bute.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_bute);
			this.htControls.Add((object)"__main_bute", (object)this.__main_bute);
			this.__main_butw = new CEnhancedButton(this);
			this.__main_butw.name = "__main_butw";
			this.__main_butw.Left = 21;
			this.__main_butw.Top = 211;
			this.__main_butw.Width = 20;
			this.__main_butw.Height = 18;
			this.__main_butw.Text = "W";
			this.__main_butw.BackColor = Color.FromArgb(-71);
			this.__main_butw.ForeColor = Color.FromArgb(-16760704);
			this.__main_butw.Enabled = true;
			this.__main_butw.Visible = false;
			this.__main_butw.Font = new Font(this.__main_butw.Font.Name, 10f, this.__main_butw.Font.Style);
			this.__main_butw.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_butw);
			this.htControls.Add((object)"__main_butw", (object)this.__main_butw);
			this.__main_butq = new CEnhancedButton(this);
			this.__main_butq.name = "__main_butq";
			this.__main_butq.Left = 1;
			this.__main_butq.Top = 211;
			this.__main_butq.Width = 20;
			this.__main_butq.Height = 18;
			this.__main_butq.Text = "Q";
			this.__main_butq.BackColor = Color.FromArgb(-71);
			this.__main_butq.ForeColor = Color.FromArgb(-16760704);
			this.__main_butq.Enabled = true;
			this.__main_butq.Visible = false;
			this.__main_butq.Font = new Font(this.__main_butq.Font.Name, 10f, this.__main_butq.Font.Style);
			this.__main_butq.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_butq);
			this.htControls.Add((object)"__main_butq", (object)this.__main_butq);
			this.__main_opendialog1 = new OpenFileDialog();
			this.__main_opendialog1.Filter = "Data Files|*.DAT";
			this.htControls.Add((object)"__main_opendialog1", (object)this.__main_opendialog1);
			this.__main_mycmd = new CEnhancedTextBox(this);
			this.__main_mycmd.name = "__main_mycmd";
			this.__main_mycmd.Left = 1;
			this.__main_mycmd.Top = 167;
			this.__main_mycmd.Width = 90;
			this.__main_mycmd.Height = 20;
			this.__main_mycmd.Text = "";
			this.__main_mycmd.BackColor = Color.FromArgb(-2236963);
			this.__main_mycmd.ForeColor = Color.FromArgb(-16777216);
			this.__main_mycmd.Enabled = true;
			this.__main_mycmd.Visible = true;
			this.__main_mycmd.Font = new Font(this.__main_mycmd.Font.Name, 8f, this.__main_mycmd.Font.Style);
			this.__main_mycmd.multiline = false;
			this.__main_mycmd.AddEvents();
			this.__main_fadventure.Controls.Add((Control)this.__main_mycmd);
			this.htControls.Add((object)"__main_mycmd", (object)this.__main_mycmd);
			this.__main_menugame = new CEnhancedMenu(this);
			this.__main_menugame.name = "__main_menugame";
			this.__main_menugame.Text = "Game";
			this.__main_menugame.Enabled = true;
			this.__main_menugame.Checked = false;
			this.__main_menugame.AddToObject("__main_fadventure");
			this.__main_menugame.AddEvents();
			this.htControls.Add((object)"__main_menugame", (object)this.__main_menugame);
			this.__main_menunew = new CEnhancedMenu(this);
			this.__main_menunew.name = "__main_menunew";
			this.__main_menunew.Text = "New";
			this.__main_menunew.Enabled = true;
			this.__main_menunew.Checked = false;
			this.__main_menunew.AddToObject("__main_menugame");
			this.__main_menunew.AddEvents();
			this.htControls.Add((object)"__main_menunew", (object)this.__main_menunew);
			this.__main_menuload = new CEnhancedMenu(this);
			this.__main_menuload.name = "__main_menuload";
			this.__main_menuload.Text = "Load";
			this.__main_menuload.Enabled = true;
			this.__main_menuload.Checked = false;
			this.__main_menuload.AddToObject("__main_menugame");
			this.__main_menuload.AddEvents();
			this.htControls.Add((object)"__main_menuload", (object)this.__main_menuload);
			this.__main_menusave = new CEnhancedMenu(this);
			this.__main_menusave.name = "__main_menusave";
			this.__main_menusave.Text = "Save";
			this.__main_menusave.Enabled = true;
			this.__main_menusave.Checked = false;
			this.__main_menusave.AddToObject("__main_menugame");
			this.__main_menusave.AddEvents();
			this.htControls.Add((object)"__main_menusave", (object)this.__main_menusave);
			this.__main_menuoptions = new CEnhancedMenu(this);
			this.__main_menuoptions.name = "__main_menuoptions";
			this.__main_menuoptions.Text = "Options";
			this.__main_menuoptions.Enabled = true;
			this.__main_menuoptions.Checked = false;
			this.__main_menuoptions.AddToObject("__main_menugame");
			this.__main_menuoptions.AddEvents();
			this.htControls.Add((object)"__main_menuoptions", (object)this.__main_menuoptions);
			this.__main_fabout = new CEnhancedMenu(this);
			this.__main_fabout.name = "__main_fabout";
			this.__main_fabout.Text = "About";
			this.__main_fabout.Enabled = true;
			this.__main_fabout.Checked = false;
			this.__main_fabout.AddToObject("__main_fadventure");
			this.__main_fabout.AddEvents();
			this.htControls.Add((object)"__main_fabout", (object)this.__main_fabout);
			this.__main_faboutscott = new CEnhancedMenu(this);
			this.__main_faboutscott.name = "__main_faboutscott";
			this.__main_faboutscott.Text = "Scott Adams Games";
			this.__main_faboutscott.Enabled = true;
			this.__main_faboutscott.Checked = false;
			this.__main_faboutscott.AddToObject("__main_fabout");
			this.__main_faboutscott.AddEvents();
			this.htControls.Add((object)"__main_faboutscott", (object)this.__main_faboutscott);
			this.__main_fengine = new CEnhancedMenu(this);
			this.__main_fengine.name = "__main_fengine";
			this.__main_fengine.Text = "The Game Engine";
			this.__main_fengine.Enabled = true;
			this.__main_fengine.Checked = false;
			this.__main_fengine.AddToObject("__main_fabout");
			this.__main_fengine.AddEvents();
			this.htControls.Add((object)"__main_fengine", (object)this.__main_fengine);
			this.__main_fselect = new CEnhancedForm(this);
			this.__main_fselect.name = "__main_fselect";
			this.__main_fselect.Text = "Select Quest";
			this.__main_fselect.BackColor = Color.FromArgb(-16744193);
			this.__main_fselect.graphics.FillRectangle((Brush)new SolidBrush(this.__main_fselect.BackColor), 0, 0, this.__main_fselect.Width, this.__main_fselect.Height);
			this.__main_fselect.AddEvents();
			this.htControls.Add((object)"__main_fselect", (object)this.__main_fselect);
			this.__main_advdesc = new CEnhancedLabel(this);
			this.__main_advdesc.name = "__main_advdesc";
			this.__main_advdesc.Left = 100;
			this.__main_advdesc.Top = 49;
			this.__main_advdesc.Width = 135;
			this.__main_advdesc.Height = 138;
			this.__main_advdesc.Text = "";
			this.__main_advdesc.BackColor = Color.FromArgb(-16744193);
			this.__main_advdesc.ForeColor = Color.FromArgb(-1);
			this.__main_advdesc.Enabled = true;
			this.__main_advdesc.Visible = true;
			this.__main_advdesc.Font = new Font(this.__main_advdesc.Font.Name, 8f, this.__main_advdesc.Font.Style);
			this.__main_fselect.Controls.Add((Control)this.__main_advdesc);
			this.htControls.Add((object)"__main_advdesc", (object)this.__main_advdesc);
			this.__main_logo = new CEnhancedImage(this);
			this.__main_logo.name = "__main_logo";
			this.__main_logo.Left = 5;
			this.__main_logo.Top = 5;
			this.__main_logo.Width = 187;
			this.__main_logo.Height = 20;
			this.__main_logo.BackColor = Color.FromArgb(-16744193);
			this.__main_logo.Enabled = true;
			this.__main_logo.Visible = true;
			this.__main_logo.MyImageMode = "cStretchImage";
			this.__main_logo.MyBitmap = this.Other.GetBitmapFromResource("b4p.images\\head.bmp");
			this.__main_logo.AddEvents();
			this.__main_fselect.Controls.Add((Control)this.__main_logo);
			this.htControls.Add((object)"__main_logo", (object)this.__main_logo);
			this.__main_imgpic = new CEnhancedImage(this);
			this.__main_imgpic.name = "__main_imgpic";
			this.__main_imgpic.Left = 7;
			this.__main_imgpic.Top = 77;
			this.__main_imgpic.Width = 90;
			this.__main_imgpic.Height = 108;
			this.__main_imgpic.BackColor = Color.FromArgb(-657956);
			this.__main_imgpic.Enabled = true;
			this.__main_imgpic.Visible = true;
			this.__main_imgpic.MyImageMode = "cStretchImage";
			this.__main_imgpic.AddEvents();
			this.__main_fselect.Controls.Add((Control)this.__main_imgpic);
			this.htControls.Add((object)"__main_imgpic", (object)this.__main_imgpic);
			this.__main_butother = new CEnhancedButton(this);
			this.__main_butother.name = "__main_butother";
			this.__main_butother.Left = 7;
			this.__main_butother.Top = 48;
			this.__main_butother.Width = 90;
			this.__main_butother.Height = 25;
			this.__main_butother.Text = "Other...";
			this.__main_butother.BackColor = Color.FromArgb(-77);
			this.__main_butother.ForeColor = Color.FromArgb(-16777216);
			this.__main_butother.Enabled = true;
			this.__main_butother.Visible = true;
			this.__main_butother.Font = new Font(this.__main_butother.Font.Name, 9f, this.__main_butother.Font.Style);
			this.__main_butother.AddEvents();
			this.__main_fselect.Controls.Add((Control)this.__main_butother);
			this.htControls.Add((object)"__main_butother", (object)this.__main_butother);
			this.__main_butplay = new CEnhancedButton(this);
			this.__main_butplay.name = "__main_butplay";
			this.__main_butplay.Left = 195;
			this.__main_butplay.Top = 5;
			this.__main_butplay.Width = 40;
			this.__main_butplay.Height = 40;
			this.__main_butplay.Text = "Play";
			this.__main_butplay.BackColor = Color.FromArgb(-8323200);
			this.__main_butplay.ForeColor = Color.FromArgb(-16777216);
			this.__main_butplay.Enabled = false;
			this.__main_butplay.Visible = true;
			this.__main_butplay.Font = new Font(this.__main_butplay.Font.Name, 9f, this.__main_butplay.Font.Style);
			this.__main_butplay.AddEvents();
			this.__main_fselect.Controls.Add((Control)this.__main_butplay);
			this.htControls.Add((object)"__main_butplay", (object)this.__main_butplay);
			this.__main_pdselect = new CEnhancedCombo(this);
			this.__main_pdselect.name = "__main_pdselect";
			this.__main_pdselect.Left = 5;
			this.__main_pdselect.Top = 25;
			this.__main_pdselect.Width = 185;
			this.__main_pdselect.Height = 20;
			this.__main_pdselect.Text = "";
			this.__main_pdselect.BackColor = Color.FromArgb(-1);
			this.__main_pdselect.ForeColor = Color.FromArgb(-16777216);
			this.__main_pdselect.Enabled = true;
			this.__main_pdselect.Visible = true;
			this.__main_pdselect.Font = new Font(this.__main_pdselect.Font.Name, 8f, this.__main_pdselect.Font.Style);
			this.__main_pdselect.Items.Add((object)"Adventureland");
			this.__main_pdselect.Items.Add((object)"Pirate Adventure");
			this.__main_pdselect.Items.Add((object)"Mission Impossible");
			this.__main_pdselect.Items.Add((object)"Voodoo Castle");
			this.__main_pdselect.Items.Add((object)"The Count");
			this.__main_pdselect.Items.Add((object)"Strange Odyssey");
			this.__main_pdselect.Items.Add((object)"Mystery Fun House");
			this.__main_pdselect.Items.Add((object)"Pyramid of Doom");
			this.__main_pdselect.Items.Add((object)"Ghost Town");
			this.__main_pdselect.Items.Add((object)"Savage Island One");
			this.__main_pdselect.Items.Add((object)"Savage Island Two");
			this.__main_pdselect.Items.Add((object)"Golden Voyage");
			this.__main_pdselect.Items.Add((object)"Claymorgue Castle");
			this.__main_pdselect.Items.Add((object)"Return to Pirates Isle");
			this.__main_pdselect.Items.Add((object)"Buckaroo Banzai");
			this.__main_fselect.Controls.Add((Control)this.__main_pdselect);
			this.htControls.Add((object)"__main_pdselect", (object)this.__main_pdselect);
			this.__main_pdselect.AddEvents();
			this.__main_backgnd = new CEnhancedImage(this);
			this.__main_backgnd.name = "__main_backgnd";
			this.__main_backgnd.Left = 6;
			this.__main_backgnd.Top = 76;
			this.__main_backgnd.Width = 92;
			this.__main_backgnd.Height = 110;
			this.__main_backgnd.BackColor = Color.FromArgb(-16777216);
			this.__main_backgnd.Enabled = true;
			this.__main_backgnd.Visible = true;
			this.__main_backgnd.MyImageMode = "cCenterImage";
			this.__main_backgnd.AddEvents();
			this.__main_fselect.Controls.Add((Control)this.__main_backgnd);
			this.htControls.Add((object)"__main_backgnd", (object)this.__main_backgnd);
			this.__main_aboutengine = new CEnhancedForm(this);
			this.__main_aboutengine.name = "__main_aboutengine";
			this.__main_aboutengine.Text = "Game Engine";
			this.__main_aboutengine.BackColor = Color.FromArgb(-16744193);
			this.__main_aboutengine.graphics.FillRectangle((Brush)new SolidBrush(this.__main_aboutengine.BackColor), 0, 0, this.__main_aboutengine.Width, this.__main_aboutengine.Height);
			this.__main_aboutengine.AddEvents();
			this.htControls.Add((object)"__main_aboutengine", (object)this.__main_aboutengine);
			this.__main_txtaboutengine = new CEnhancedTextBox(this);
			this.__main_txtaboutengine.name = "__main_txtaboutengine";
			this.__main_txtaboutengine.Left = 5;
			this.__main_txtaboutengine.Top = 5;
			this.__main_txtaboutengine.Width = 230;
			this.__main_txtaboutengine.Height = 180;
			this.__main_txtaboutengine.Text = "This engine (v1.17) has been developed for Windows Mobile PDAs with .NET 2 framework. \r\n\r\nPlease read the text files supplied if you wish to know more about the engine.\r\n\r\nThe message board for this game is... http://games.groups.yahoo.com/group/adventurepda/\r\n\r\nMany thanks to Scott Adams, the father of personal computer adventuring, for permission to create this engine and to Robert Schneck and Alan Cox whose drivers under C have been a great help.\r\n\r\nThis engine is dedicated to the good old days of vintage computing! YOHO!";
			this.__main_txtaboutengine.BackColor = Color.FromArgb((int)sbyte.MinValue);
			this.__main_txtaboutengine.ForeColor = Color.FromArgb(-16777088);
			this.__main_txtaboutengine.Enabled = true;
			this.__main_txtaboutengine.Visible = true;
			this.__main_txtaboutengine.Font = new Font(this.__main_txtaboutengine.Font.Name, 8f, this.__main_txtaboutengine.Font.Style);
			this.__main_txtaboutengine.multiline = true;
			this.__main_txtaboutengine.AddEvents();
			this.__main_aboutengine.Controls.Add((Control)this.__main_txtaboutengine);
			this.htControls.Add((object)"__main_txtaboutengine", (object)this.__main_txtaboutengine);
			this.__main_aboutsa = new CEnhancedForm(this);
			this.__main_aboutsa.name = "__main_aboutsa";
			this.__main_aboutsa.Text = "Scott Adams";
			this.__main_aboutsa.BackColor = Color.FromArgb(-16744193);
			this.__main_aboutsa.graphics.FillRectangle((Brush)new SolidBrush(this.__main_aboutsa.BackColor), 0, 0, this.__main_aboutsa.Width, this.__main_aboutsa.Height);
			this.__main_aboutsa.AddEvents();
			this.htControls.Add((object)"__main_aboutsa", (object)this.__main_aboutsa);
			this.__main_txtscott = new CEnhancedTextBox(this);
			this.__main_txtscott.name = "__main_txtscott";
			this.__main_txtscott.Left = 5;
			this.__main_txtscott.Top = 5;
			this.__main_txtscott.Width = 230;
			this.__main_txtscott.Height = 180;
			this.__main_txtscott.Text = "The Scott Adams original text adventure games (data files) are copyrighted by Scott Adams and are shareware but the contribution is strictly voluntary and the amount is left to your own discretion.\r\n\r\nPlease note that international cheques (in small amounts) are usually more expensive to cash than their face value is worth so please do not send same.\r\n\r\nPlease send any payments to:\r\n\r\nScott Adams, 706 Walnut Dell Road,\r\nPlatteville WI 53818-9775, USA\r\n\r\nHomepage: http://www.msadams.com\r\nEmail: msadams@msadams.com";
			this.__main_txtscott.BackColor = Color.FromArgb((int)sbyte.MinValue);
			this.__main_txtscott.ForeColor = Color.FromArgb(-16777088);
			this.__main_txtscott.Enabled = true;
			this.__main_txtscott.Visible = true;
			this.__main_txtscott.Font = new Font(this.__main_txtscott.Font.Name, 8f, this.__main_txtscott.Font.Style);
			this.__main_txtscott.multiline = true;
			this.__main_txtscott.AddEvents();
			this.__main_aboutsa.Controls.Add((Control)this.__main_txtscott);
			this.htControls.Add((object)"__main_txtscott", (object)this.__main_txtscott);
			this.__main_foptions = new CEnhancedForm(this);
			this.__main_foptions.name = "__main_foptions";
			this.__main_foptions.Text = "Options";
			this.__main_foptions.BackColor = Color.FromArgb(-16744193);
			this.__main_foptions.graphics.FillRectangle((Brush)new SolidBrush(this.__main_foptions.BackColor), 0, 0, this.__main_foptions.Width, this.__main_foptions.Height);
			this.__main_foptions.AddEvents();
			this.htControls.Add((object)"__main_foptions", (object)this.__main_foptions);
			this.__main_kbdonoff = new CEnhancedButton(this);
			this.__main_kbdonoff.name = "__main_kbdonoff";
			this.__main_kbdonoff.Left = (int)sbyte.MaxValue;
			this.__main_kbdonoff.Top = 103;
			this.__main_kbdonoff.Width = 55;
			this.__main_kbdonoff.Height = 25;
			this.__main_kbdonoff.Text = "Kbd=Y";
			this.__main_kbdonoff.BackColor = Color.FromArgb(-2830136);
			this.__main_kbdonoff.ForeColor = Color.FromArgb(-16777216);
			this.__main_kbdonoff.Enabled = true;
			this.__main_kbdonoff.Visible = true;
			this.__main_kbdonoff.Font = new Font(this.__main_kbdonoff.Font.Name, 8f, this.__main_kbdonoff.Font.Style);
			this.__main_kbdonoff.AddEvents();
			this.__main_foptions.Controls.Add((Control)this.__main_kbdonoff);
			this.htControls.Add((object)"__main_kbdonoff", (object)this.__main_kbdonoff);
			this.__main_fontbold = new CEnhancedCombo(this);
			this.__main_fontbold.name = "__main_fontbold";
			this.__main_fontbold.Left = 180;
			this.__main_fontbold.Top = 15;
			this.__main_fontbold.Width = 50;
			this.__main_fontbold.Height = 22;
			this.__main_fontbold.Text = "";
			this.__main_fontbold.BackColor = Color.FromArgb((int)sbyte.MinValue);
			this.__main_fontbold.ForeColor = Color.FromArgb(-16777216);
			this.__main_fontbold.Enabled = true;
			this.__main_fontbold.Visible = true;
			this.__main_fontbold.Font = new Font(this.__main_fontbold.Font.Name, 9f, this.__main_fontbold.Font.Style);
			this.__main_fontbold.Items.Add((object)"No");
			this.__main_fontbold.Items.Add((object)"Yes");
			this.__main_foptions.Controls.Add((Control)this.__main_fontbold);
			this.htControls.Add((object)"__main_fontbold", (object)this.__main_fontbold);
			this.__main_fontbold.AddEvents();
			this.__main_labfontbold = new CEnhancedLabel(this);
			this.__main_labfontbold.name = "__main_labfontbold";
			this.__main_labfontbold.Left = 140;
			this.__main_labfontbold.Top = 15;
			this.__main_labfontbold.Width = 35;
			this.__main_labfontbold.Height = 20;
			this.__main_labfontbold.Text = "Bold";
			this.__main_labfontbold.BackColor = Color.FromArgb(-16744193);
			this.__main_labfontbold.ForeColor = Color.FromArgb(-1);
			this.__main_labfontbold.Enabled = true;
			this.__main_labfontbold.Visible = true;
			this.__main_labfontbold.Font = new Font(this.__main_labfontbold.Font.Name, 9f, this.__main_labfontbold.Font.Style);
			this.__main_foptions.Controls.Add((Control)this.__main_labfontbold);
			this.htControls.Add((object)"__main_labfontbold", (object)this.__main_labfontbold);
			this.__main_linkfix = new CEnhancedCombo(this);
			this.__main_linkfix.name = "__main_linkfix";
			this.__main_linkfix.Left = 180;
			this.__main_linkfix.Top = 75;
			this.__main_linkfix.Width = 50;
			this.__main_linkfix.Height = 22;
			this.__main_linkfix.Text = "";
			this.__main_linkfix.BackColor = Color.FromArgb((int)sbyte.MinValue);
			this.__main_linkfix.ForeColor = Color.FromArgb(-16777216);
			this.__main_linkfix.Enabled = true;
			this.__main_linkfix.Visible = true;
			this.__main_linkfix.Font = new Font(this.__main_linkfix.Font.Name, 9f, this.__main_linkfix.Font.Style);
			this.__main_linkfix.Items.Add((object)"No");
			this.__main_linkfix.Items.Add((object)"Yes");
			this.__main_foptions.Controls.Add((Control)this.__main_linkfix);
			this.htControls.Add((object)"__main_linkfix", (object)this.__main_linkfix);
			this.__main_linkfix.AddEvents();
			this.__main_lablinkfix = new CEnhancedLabel(this);
			this.__main_lablinkfix.name = "__main_lablinkfix";
			this.__main_lablinkfix.Left = 130;
			this.__main_lablinkfix.Top = 75;
			this.__main_lablinkfix.Width = 50;
			this.__main_lablinkfix.Height = 25;
			this.__main_lablinkfix.Text = "Linkfix";
			this.__main_lablinkfix.BackColor = Color.FromArgb(-16744193);
			this.__main_lablinkfix.ForeColor = Color.FromArgb(-1);
			this.__main_lablinkfix.Enabled = true;
			this.__main_lablinkfix.Visible = true;
			this.__main_lablinkfix.Font = new Font(this.__main_lablinkfix.Font.Name, 9f, this.__main_lablinkfix.Font.Style);
			this.__main_foptions.Controls.Add((Control)this.__main_lablinkfix);
			this.htControls.Add((object)"__main_lablinkfix", (object)this.__main_lablinkfix);
			this.__main_pdoptrvs = new CEnhancedCombo(this);
			this.__main_pdoptrvs.name = "__main_pdoptrvs";
			this.__main_pdoptrvs.Left = 75;
			this.__main_pdoptrvs.Top = 105;
			this.__main_pdoptrvs.Width = 50;
			this.__main_pdoptrvs.Height = 22;
			this.__main_pdoptrvs.Text = "";
			this.__main_pdoptrvs.BackColor = Color.FromArgb((int)sbyte.MinValue);
			this.__main_pdoptrvs.ForeColor = Color.FromArgb(-16777216);
			this.__main_pdoptrvs.Enabled = true;
			this.__main_pdoptrvs.Visible = true;
			this.__main_pdoptrvs.Font = new Font(this.__main_pdoptrvs.Font.Name, 9f, this.__main_pdoptrvs.Font.Style);
			this.__main_pdoptrvs.Items.Add((object)"Yes");
			this.__main_pdoptrvs.Items.Add((object)"No");
			this.__main_foptions.Controls.Add((Control)this.__main_pdoptrvs);
			this.htControls.Add((object)"__main_pdoptrvs", (object)this.__main_pdoptrvs);
			this.__main_pdoptrvs.AddEvents();
			this.__main_laboptmsgs = new CEnhancedLabel(this);
			this.__main_laboptmsgs.name = "__main_laboptmsgs";
			this.__main_laboptmsgs.Left = 10;
			this.__main_laboptmsgs.Top = 105;
			this.__main_laboptmsgs.Width = 75;
			this.__main_laboptmsgs.Height = 20;
			this.__main_laboptmsgs.Text = "Msgs@Top";
			this.__main_laboptmsgs.BackColor = Color.FromArgb(-16744193);
			this.__main_laboptmsgs.ForeColor = Color.FromArgb(-1);
			this.__main_laboptmsgs.Enabled = true;
			this.__main_laboptmsgs.Visible = true;
			this.__main_laboptmsgs.Font = new Font(this.__main_laboptmsgs.Font.Name, 9f, this.__main_laboptmsgs.Font.Style);
			this.__main_foptions.Controls.Add((Control)this.__main_laboptmsgs);
			this.htControls.Add((object)"__main_laboptmsgs", (object)this.__main_laboptmsgs);
			this.__main_laboptlink = new CEnhancedLabel(this);
			this.__main_laboptlink.name = "__main_laboptlink";
			this.__main_laboptlink.Left = 10;
			this.__main_laboptlink.Top = 74;
			this.__main_laboptlink.Width = 65;
			this.__main_laboptlink.Height = 20;
			this.__main_laboptlink.Text = "Hyperlinks";
			this.__main_laboptlink.BackColor = Color.FromArgb(-16744193);
			this.__main_laboptlink.ForeColor = Color.FromArgb(-1);
			this.__main_laboptlink.Enabled = true;
			this.__main_laboptlink.Visible = true;
			this.__main_laboptlink.Font = new Font(this.__main_laboptlink.Font.Name, 9f, this.__main_laboptlink.Font.Style);
			this.__main_foptions.Controls.Add((Control)this.__main_laboptlink);
			this.htControls.Add((object)"__main_laboptlink", (object)this.__main_laboptlink);
			this.__main_pdlinks = new CEnhancedCombo(this);
			this.__main_pdlinks.name = "__main_pdlinks";
			this.__main_pdlinks.Left = 75;
			this.__main_pdlinks.Top = 74;
			this.__main_pdlinks.Width = 50;
			this.__main_pdlinks.Height = 22;
			this.__main_pdlinks.Text = "";
			this.__main_pdlinks.BackColor = Color.FromArgb((int)sbyte.MinValue);
			this.__main_pdlinks.ForeColor = Color.FromArgb(-16777216);
			this.__main_pdlinks.Enabled = true;
			this.__main_pdlinks.Visible = true;
			this.__main_pdlinks.Font = new Font(this.__main_pdlinks.Font.Name, 9f, this.__main_pdlinks.Font.Style);
			this.__main_pdlinks.Items.Add((object)"Yes");
			this.__main_pdlinks.Items.Add((object)"No");
			this.__main_foptions.Controls.Add((Control)this.__main_pdlinks);
			this.htControls.Add((object)"__main_pdlinks", (object)this.__main_pdlinks);
			this.__main_pdlinks.AddEvents();
			this.__main_butapply = new CEnhancedButton(this);
			this.__main_butapply.name = "__main_butapply";
			this.__main_butapply.Left = 185;
			this.__main_butapply.Top = 103;
			this.__main_butapply.Width = 50;
			this.__main_butapply.Height = 25;
			this.__main_butapply.Text = "Apply";
			this.__main_butapply.BackColor = Color.FromArgb(-2830136);
			this.__main_butapply.ForeColor = Color.FromArgb(-16777216);
			this.__main_butapply.Enabled = true;
			this.__main_butapply.Visible = true;
			this.__main_butapply.Font = new Font(this.__main_butapply.Font.Name, 8f, this.__main_butapply.Font.Style);
			this.__main_butapply.AddEvents();
			this.__main_foptions.Controls.Add((Control)this.__main_butapply);
			this.htControls.Add((object)"__main_butapply", (object)this.__main_butapply);
			this.__main_pdfontsize = new CEnhancedCombo(this);
			this.__main_pdfontsize.name = "__main_pdfontsize";
			this.__main_pdfontsize.Left = 74;
			this.__main_pdfontsize.Top = 13;
			this.__main_pdfontsize.Width = 50;
			this.__main_pdfontsize.Height = 22;
			this.__main_pdfontsize.Text = "";
			this.__main_pdfontsize.BackColor = Color.FromArgb((int)sbyte.MinValue);
			this.__main_pdfontsize.ForeColor = Color.FromArgb(-16777216);
			this.__main_pdfontsize.Enabled = true;
			this.__main_pdfontsize.Visible = true;
			this.__main_pdfontsize.Font = new Font(this.__main_pdfontsize.Font.Name, 9f, this.__main_pdfontsize.Font.Style);
			this.__main_pdfontsize.Items.Add((object)"1");
			this.__main_pdfontsize.Items.Add((object)"2");
			this.__main_pdfontsize.Items.Add((object)"3");
			this.__main_pdfontsize.Items.Add((object)"4");
			this.__main_pdfontsize.Items.Add((object)"5");
			this.__main_foptions.Controls.Add((Control)this.__main_pdfontsize);
			this.htControls.Add((object)"__main_pdfontsize", (object)this.__main_pdfontsize);
			this.__main_pdfontsize.AddEvents();
			this.__main_laboptfontsize = new CEnhancedLabel(this);
			this.__main_laboptfontsize.name = "__main_laboptfontsize";
			this.__main_laboptfontsize.Left = 10;
			this.__main_laboptfontsize.Top = 15;
			this.__main_laboptfontsize.Width = 65;
			this.__main_laboptfontsize.Height = 20;
			this.__main_laboptfontsize.Text = "Font Size";
			this.__main_laboptfontsize.BackColor = Color.FromArgb(-16744193);
			this.__main_laboptfontsize.ForeColor = Color.FromArgb(-1);
			this.__main_laboptfontsize.Enabled = true;
			this.__main_laboptfontsize.Visible = true;
			this.__main_laboptfontsize.Font = new Font(this.__main_laboptfontsize.Font.Name, 9f, this.__main_laboptfontsize.Font.Style);
			this.__main_foptions.Controls.Add((Control)this.__main_laboptfontsize);
			this.htControls.Add((object)"__main_laboptfontsize", (object)this.__main_laboptfontsize);
			this.__main_labopttheme = new CEnhancedLabel(this);
			this.__main_labopttheme.name = "__main_labopttheme";
			this.__main_labopttheme.Left = 10;
			this.__main_labopttheme.Top = 45;
			this.__main_labopttheme.Width = 50;
			this.__main_labopttheme.Height = 20;
			this.__main_labopttheme.Text = "Theme";
			this.__main_labopttheme.BackColor = Color.FromArgb(-16744193);
			this.__main_labopttheme.ForeColor = Color.FromArgb(-1);
			this.__main_labopttheme.Enabled = true;
			this.__main_labopttheme.Visible = true;
			this.__main_labopttheme.Font = new Font(this.__main_labopttheme.Font.Name, 9f, this.__main_labopttheme.Font.Style);
			this.__main_foptions.Controls.Add((Control)this.__main_labopttheme);
			this.htControls.Add((object)"__main_labopttheme", (object)this.__main_labopttheme);
			this.__main_pdtheme = new CEnhancedCombo(this);
			this.__main_pdtheme.name = "__main_pdtheme";
			this.__main_pdtheme.Left = 75;
			this.__main_pdtheme.Top = 44;
			this.__main_pdtheme.Width = 155;
			this.__main_pdtheme.Height = 22;
			this.__main_pdtheme.Text = "";
			this.__main_pdtheme.BackColor = Color.FromArgb((int)sbyte.MinValue);
			this.__main_pdtheme.ForeColor = Color.FromArgb(-16777216);
			this.__main_pdtheme.Enabled = true;
			this.__main_pdtheme.Visible = true;
			this.__main_pdtheme.Font = new Font(this.__main_pdtheme.Font.Name, 9f, this.__main_pdtheme.Font.Style);
			this.__main_foptions.Controls.Add((Control)this.__main_pdtheme);
			this.htControls.Add((object)"__main_pdtheme", (object)this.__main_pdtheme);
			this.__main_pdtheme.AddEvents();
			this.__main_arraylist1 = new ArrayList();
			this.htControls.Add((object)"__main_arraylist1", (object)this.__main_arraylist1);
		}

		public delegate string del0();

		public delegate string del1(string a);

		public delegate string del2(string a, string b);

		public delegate string del3(string a, string b, string c);
	}
}
