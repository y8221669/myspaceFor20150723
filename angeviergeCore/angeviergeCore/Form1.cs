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

        private bool mousetag = true;
        MenuForm menuForm = new MenuForm();
        public MainForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle( ControlStyles.OptimizedDoubleBuffer
                     | ControlStyles.ResizeRedraw
                     | ControlStyles.Selectable
                     | ControlStyles.AllPaintingInWmPaint
                     | ControlStyles.UserPaint
                     | ControlStyles.SupportsTransparentBackColor,
                    true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            UpdateStyles();
            searchFlowLayoutPanel.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance
                | System.Reflection.BindingFlags.NonPublic).SetValue(searchFlowLayoutPanel, true, null);
            comboboxInit();
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
            /* CardInfoPanel panel = new CardInfoPanel();
             panel.Parent = searchFlowLayoutPanel;
             searchFlowLayoutPanel.Controls.Add(panel);*/
            int color, level, type, single;
            if (colorComboBox.SelectedItem!=null){
                color=((ComboxItem)colorComboBox.SelectedItem).Value;
            }else{
                color = -1;
            }
            if (levelComboBox.SelectedItem != null){
                level = ((ComboxItem)levelComboBox.SelectedItem).Value;
            } else{
                level = -1;
            }
            if (typeComboBox.SelectedItem != null){
                type = ((ComboxItem)typeComboBox.SelectedItem).Value;
            }else{
                type = -1;
            }
            if (singleComboBox.SelectedItem != null)
            {
                single = ((ComboxItem)singleComboBox.SelectedItem).Value;
            }
            else
            {
                single = -1;
            }
            string keyword = searchKeyText.Text;
            sqliteHelper helper = new sqliteHelper();
            helper.createSQL("card");
            List<Card> list = helper.selectCard(color,level,type,single,keyword);
            addCardPanel(list);
        }

        private void searchFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            if (mousetag ==true) {
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

        private void searchFlowLayoutPanel_Scroll(object sender, ScrollEventArgs e)
        {
            mousetag = false;
            if (e.OldValue == e.NewValue) {
                mousetag = true;
                searchFlowLayoutPanel.Invalidate();
            }
        }

        private void deckUpsetButton_Click(object sender, EventArgs e)
        {
            
        }
        private void comboboxInit() {
            colorComboBox.Items.Add(new ComboxItem("红", 0));
            colorComboBox.Items.Add(new ComboxItem("蓝", 1));
            colorComboBox.Items.Add(new ComboxItem("黑", 2));
            colorComboBox.Items.Add(new ComboxItem("白", 3));
            colorComboBox.Items.Add(new ComboxItem("绿", 4));
            typeComboBox.Items.Add(new ComboxItem("PG", 0));
            typeComboBox.Items.Add(new ComboxItem("AC", 1));
            singleComboBox.Items.Add(new ComboxItem("Ω", 0));
            singleComboBox.Items.Add(new ComboxItem("Σ", 1));
            singleComboBox.Items.Add(new ComboxItem("∀∀", 2));
            singleComboBox.Items.Add(new ComboxItem("无", 3));
        }
        private void addCardPanel(List<Card> cardlist)
        {
            foreach (Card card in cardlist)
            {
                CardInfoPanel panel = new CardInfoPanel();
                panel.Parent = searchFlowLayoutPanel;
                if(card.type == 0)
                {
                    switch (card.color)
                    {
                        case 0:
                            panel.colorAndsortLabel.Text = "红/PG";
                            break;
                        case 1:
                            panel.colorAndsortLabel.Text = "蓝/PG";
                            break;
                        case 2:
                            panel.colorAndsortLabel.Text = "白/PG";
                            break;
                        case 3:
                            panel.colorAndsortLabel.Text = "黑/PG";
                            break;
                        case 4:
                            panel.colorAndsortLabel.Text = "绿/PG";
                            break;
                    }
                }
                else
                {
                    switch (card.color)
                    {
                        case 0:
                            panel.colorAndsortLabel.Text = "红/AC";
                            break;
                        case 1:
                            panel.colorAndsortLabel.Text = "蓝/C";
                            break;
                        case 2:
                            panel.colorAndsortLabel.Text = "白/AC";
                            break;
                        case 3:
                            panel.colorAndsortLabel.Text = "黑/AC";
                            break;
                        case 4:
                            panel.colorAndsortLabel.Text = "绿/AC";
                            break;
                    }
                }
                panel.levelLabel.Text = card.level.ToString();
                panel.powerAndDefendLabel.Text = card.power.ToString() + "/" + card.grand.ToString();
                panel.nameLabel.Text = card.name;
                string picname =  "../pic/"+ card.number+ ".png";
                panel.cardPic.Image = Image.FromFile(@picname);
                searchFlowLayoutPanel.Controls.Add(panel);
            }
           
        }
    }
}
