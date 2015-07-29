using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace angeviergeCore
{
    public delegate void Mydelegate(int tag);
    public delegate void rigthDown(int tag);
    public partial class CardInfoPanel : Panel
    {
        bool showtag = false;
        public MainForm owner;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int wndproc);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        public const int GWL_STYLE = -16;
        public const int WS_DISABLED = 0x8000000;

        public static void SetControlEnabled(Control c, bool enabled)
        {
            if (enabled)
            { SetWindowLong(c.Handle, GWL_STYLE, (~WS_DISABLED) & GetWindowLong(c.Handle, GWL_STYLE)); }
            else
            { SetWindowLong(c.Handle, GWL_STYLE, WS_DISABLED + GetWindowLong(c.Handle, GWL_STYLE)); }
        }


        public CardInfoPanel()
        {
            InitializeComponent();

            SetControlEnabled(levelLabel, false);
            SetControlEnabled(powerAndDefendLabel, false);
            SetControlEnabled(colorAndsortLabel, false);
            SetControlEnabled(nameLabel, false);

            SetStyle(ControlStyles.UserPaint 
                | ControlStyles.AllPaintingInWmPaint 
                | ControlStyles.OptimizedDoubleBuffer 
                | ControlStyles.ResizeRedraw
                | ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            this.UpdateStyles();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (!showtag)
            {
                ControlPaint.DrawBorder(e.Graphics,
                     this.panel1.ClientRectangle,
                     Color.Transparent,
                     1,
                     ButtonBorderStyle.Solid,
                     Color.Transparent,
                     1,
                     ButtonBorderStyle.Solid,
                     Color.Transparent,
                     1,
                     ButtonBorderStyle.Solid,
                     Color.Transparent,
                     1,
                     ButtonBorderStyle.Solid);
            }else {
                ControlPaint.DrawBorder(e.Graphics,
                                   this.panel1.ClientRectangle,
                                   Color.White,
                                   1,
                                   ButtonBorderStyle.Solid,
                                   Color.White,
                                   1,
                                   ButtonBorderStyle.Solid,
                                   Color.White,
                                   1,
                                   ButtonBorderStyle.Solid,
                                   Color.White,
                                   1,
                                   ButtonBorderStyle.Solid);
            }
            
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            showtag = true;
            Refresh();
            Mydelegate dg = new Mydelegate(owner.showCardInfo);
            dg((int)Tag);
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            showtag = false;
            Refresh();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                rigthDown rd = new rigthDown(owner.addDeck);
                rd((int)Tag);
            }
        }
    }
}
