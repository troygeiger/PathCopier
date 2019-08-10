using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PathCopier
{
    public partial class frmPopup : Form
    {
		
        private const int SW_SHOWNOACTIVATE = 4;
		string File;

        [DllImport("user32")]
        private static extern int ShowWindow(IntPtr hwnd, int CmdShow);

        [DllImport("user32")]
        private static extern int SetWindowPos(IntPtr hwnd, int hWndInsertAfter, int X, int Y, int cx, int cy, int wFlags);

        const int HWND_TOPMOST = -1;
        const int HWND_NOTOPMOST = -2;
        const int SWP_NOMOVE = 0x2;
        const int SWP_NOSIZE = 0x1;
        const int SWP_NOACTIVATE = 0x10;

        
        [DllImport("user32.dll", SetLastError=true)]
        static extern bool CloseClipboard();
        
        
        
        
        

        public void MakeAlwaysOnTop(bool SetOnTop)
        {
            int lflag;
            if (SetOnTop)
            {
                lflag = HWND_TOPMOST;
            }
            else
            {
                lflag = HWND_NOTOPMOST;
            }
            SetWindowPos(this.Handle, lflag, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_NOACTIVATE);

        }

        private bool confmode;

        public bool ConfigurationMode
        {
            get { return confmode; }
            set { confmode = value; }
        }

        public Color GradientTopColor { get; set; }

        public Color GradientBottomColor { get; set; }

        public Color TextColor { get; set; }

        public Color OutlineColor { get; set; }

        public frmPopup()
        {
            this.GradientTopColor = Settings.GradientTopColor;
            this.GradientBottomColor = Settings.GradientBottomColor;
            this.TextColor = Settings.TextColor;
            this.OutlineColor = Settings.OutlineColor;

            InitializeComponent();
			
			
        }

        public bool Popup(string[] args)
        {
            GraphicsPath GP = new GraphicsPath();

            
            //string[] args = Environment.GetCommandLineArgs();

            if (confmode)
            {
                args = new string[] { "This will display the path that will be copied" };
            }
			
            //string[] args = new string[1] { "Hello World.pdf" };
            if (args.Length > 0)
            {
				if (string.IsNullOrEmpty(File))
					File = System.IO.Path.GetFullPath(args[0]);
				else
					File += "\r\n" + args[0];
                
                try {
                	Clipboard.SetText(File, TextDataFormat.Text);
                } catch (Exception ex) {
                	MessageBox.Show(ex.Message, "Error");
                	return false;
                }
                
                
                
                string display = "Copied " + args[0] + " To Clipboard.";//System.IO.Path.GetFileName(File);
                Size TxtSize = TextRenderer.MeasureText(File, this.Font);
                if (TxtSize.Width > (Screen.PrimaryScreen.WorkingArea.Width / 2)) { TxtSize.Width = Screen.PrimaryScreen.WorkingArea.Width / 2; }
                Bitmap bmp = new Bitmap(TxtSize.Width + 10, 24);
                // Bitmap bmp = new Bitmap(TxtSize.Width - (TxtSize.Width / 2), 24);
                Rectangle bnds = new Rectangle(new Point(), bmp.Size);
                this.Size = bnds.Size;
                this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Right - bnds.Width - 5, Screen.PrimaryScreen.WorkingArea.Bottom - bnds.Height - 5);
                GP.AddArc(new Rectangle(0, 0, 16, 16), 180, 90);
                GP.AddArc(new Rectangle(bnds.Right - 17, 0, 16, 16), 270, 90);
                GP.AddArc(new Rectangle(bnds.Right - 17, bnds.Bottom - 17, 16, 16), 0, 90);
                GP.AddArc(new Rectangle(0, bnds.Bottom - 17, 16, 16), 90, 90);
                GP.CloseFigure();

                Graphics G = Graphics.FromImage(bmp);
                LinearGradientBrush lbg = new LinearGradientBrush(bnds, this.GradientTopColor, this.GradientBottomColor, LinearGradientMode.Vertical);
                G.FillPath(lbg, GP);
                StringFormat SF = StringFormat.GenericTypographic;
                SF.Alignment = StringAlignment.Center;
                SF.FormatFlags = StringFormatFlags.NoWrap;
                SF.Trimming = StringTrimming.EllipsisPath;
                SF.LineAlignment = StringAlignment.Center;
                bnds.X += 5;
                bnds.Width -= 10;
                SolidBrush TextBrush = new SolidBrush(this.TextColor );
				G.DrawString(display, this.Font, TextBrush, bnds, SF);
                Pen P = new Pen(this.OutlineColor, 1);
                TextBrush.Dispose();
                P.Alignment = PenAlignment.Inset;
                G.DrawPath(P, GP);
                G.Dispose();
                P.Dispose();
                this.BackgroundImage = bmp;
                ShowWindow(this.Handle, SW_SHOWNOACTIVATE);
                MakeAlwaysOnTop(true);
                if (!confmode) DelayFade.Start();
                return true;

            }
            else
            {
                this.Close();
            }
            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            FadeOut.Start();
        }

        private void DelayFade_Tick(object sender, EventArgs e)
        {
            DelayFade.Stop();
            FadeOut.Start();
        }

        private void FadeOut_Tick(object sender, EventArgs e)
        {
            this.Opacity -= .1;
            if (this.Opacity == 0.0f) { this.Close(); Application.Exit(); }
        }
    }
}