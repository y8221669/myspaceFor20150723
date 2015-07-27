using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace angeviergeCore
{
    public partial class MenuForm : Form
    {
        [DllImport("user32")]
        private static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }
        private void tickets_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        public void hideForm() {
            AnimateWindow(this.Handle, 200, 0x10010);
        }
        public void showForm()
        {
            AnimateWindow(this.Handle, 200, 0x20010);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideForm();
            MainForm p = (MainForm)MdiParent;
            p.showSearchForm();
        }
    }
}
