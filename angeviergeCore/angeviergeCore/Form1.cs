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
    public partial class MainForm : Form
    {
        

        MenuForm menuForm = new MenuForm();
        public MainForm()
        {
            InitializeComponent();
            SetStyle( ControlStyles.OptimizedDoubleBuffer
                     | ControlStyles.ResizeRedraw
                     | ControlStyles.Selectable
                     | ControlStyles.AllPaintingInWmPaint
                     | ControlStyles.UserPaint
                     | ControlStyles.SupportsTransparentBackColor,
                    true);

        }

        [DllImport("user32")]
        public static extern int SetParent(int hWndChild, int hWndNewParent);

        private void MainForm_Load(object sender, EventArgs e)
        {
            hideSearchForm();
            menuForm.MdiParent = this;
            menuForm.StartPosition = FormStartPosition.Manual;
            menuForm.Location = new Point(370, 200);
            menuForm.BringToFront();
            menuForm.Show();
            SetParent((int)menuForm.Handle, (int)this.Handle);
            searchFlowLayoutPanel.Parent = bgpicBox;
            searchEndPanel.Parent = bgpicBox;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void hideSearchForm() {
            searchPanel.Hide();
            deckPanel.Hide();
            cardFlame.Hide();
            cardTabControl.Hide();
            searchFlowLayoutPanel.Hide();
            searchEndPanel.Hide();
        }
        public void showSearchForm()
        {
            searchPanel.Show();
            deckPanel.Show();
            cardFlame.Show();
            cardTabControl.Show();
            searchFlowLayoutPanel.Show();
            searchEndPanel.Show();
        }

        private void exitDeckButton_Click(object sender, EventArgs e)
        {
            hideSearchForm();
            menuForm.showForm();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            CardInfoPanel panel = new CardInfoPanel();
            panel.Parent = searchFlowLayoutPanel;
            searchFlowLayoutPanel.Controls.Add(panel);
        }

        private void searchFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics,
                               this.searchFlowLayoutPanel.ClientRectangle,
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

        private void searchEndPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics,
                               this.searchEndPanel.ClientRectangle,
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
}
