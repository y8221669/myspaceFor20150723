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
    public partial class CardInfoPanel : UserControl
    {
        bool showtag = false;

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
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            if (!showtag) {
                showtag = true;
                BackgroundImage = Properties.Resources.bg_av_3;
            }
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            if (showtag)
            {
                showtag = false;
                BackgroundImage = null;
            }
        }
    }
}
