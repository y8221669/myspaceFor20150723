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
        private List<Card> nowDeck = new List<Card>(54);
        private bool mousetag = true;
        private cardOperation co = new cardOperation();
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
            deckFlowlayoutPanel.Parent = bgpicBox;         
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
            deckFlowlayoutPanel.Hide();
        }
        public void showSearchForm()
        {
            searchPanel.Show();
            deckPanel.Show();
            cardFlame.Show();
            cardTabControl.Show();
            searchFlowLayoutPanel.Show();
            searchEndPanel.Show();
            deckFlowlayoutPanel.Show();
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
            List<Card> list = co.selectCard(color,level,type,single,keyword);
            int sum = list.Count;
            addCardPanel(list);
            searchSumLabel.Text = "搜索结果：" + sum;
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
            colorComboBox.Items.Add(new ComboxItem("", -1));
            colorComboBox.Items.Add(new ComboxItem("红", 0));
            colorComboBox.Items.Add(new ComboxItem("蓝", 1));
            colorComboBox.Items.Add(new ComboxItem("黑", 2));
            colorComboBox.Items.Add(new ComboxItem("白", 3));
            colorComboBox.Items.Add(new ComboxItem("绿", 4));
            levelComboBox.Items.Add(new ComboxItem("", -1));
            levelComboBox.Items.Add(new ComboxItem("0", 0));
            levelComboBox.Items.Add(new ComboxItem("1", 1));
            levelComboBox.Items.Add(new ComboxItem("2", 2));
            levelComboBox.Items.Add(new ComboxItem("3", 3));
            levelComboBox.Items.Add(new ComboxItem("4", 4));
            levelComboBox.Items.Add(new ComboxItem("Boost", 5));
            typeComboBox.Items.Add(new ComboxItem("", -1));
            typeComboBox.Items.Add(new ComboxItem("PG", 0));
            typeComboBox.Items.Add(new ComboxItem("AC", 1));
            singleComboBox.Items.Add(new ComboxItem("", -1));
            singleComboBox.Items.Add(new ComboxItem("Ω", 0));
            singleComboBox.Items.Add(new ComboxItem("Σ", 1));
            singleComboBox.Items.Add(new ComboxItem("∀∀", 2));
            singleComboBox.Items.Add(new ComboxItem("无", 3));

            List<string> list = co.GetFiles();
            foreach(string text in list)
            {
                deckComboBox.Items.Add(text);
            }
        }
        private void addCardPanel(List<Card> cardlist)
        {
            searchFlowLayoutPanel.Controls.Clear();
            foreach (Card card in cardlist)
            {
                CardInfoPanel panel = new CardInfoPanel();
                panel.Parent = searchFlowLayoutPanel;
                panel.Tag = card.cardTag;
                panel.owner = this;
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
                panel.powerAndDefendLabel.Text = card.power.ToString() + "/" + card.guard.ToString();
                panel.nameLabel.Text = card.name;
                string picname =  "../pic/"+ card.number+ ".png";
                panel.cardPic.Image = Image.FromFile(@picname);
                searchFlowLayoutPanel.Controls.Add(panel);
                
            }          
        }
        public void addDeck(int tag)
        {
            int singleNum = 0, beginNum = 0,same = 0;
            foreach (Card temp in nowDeck)
            {
                if (temp.single == 0|| temp.single == 1)
                {
                    singleNum ++;
                }
                if(temp.single == 2)
                {
                    beginNum++;
                }
                if(temp.cardTag == tag)
                {
                    same++;
                }
            }
            Card card = co.selectFromTag(tag);

            if ((card.single == 0 || card.single == 1) && singleNum >= 16)
                return;
            if (card.single == 2 && beginNum >= 4)
                return;
            if (nowDeck.Count >= 54)
                return;
            if (same >= 4)
                return;

            smallCard small = new smallCard();
            string picname = "../pic/" + card.number + ".png";
            small.cardpicbox.Image = Image.FromFile(@picname);
            small.cardPosition = nowDeck.Count;
            small.owner = this;
            small.cardid = card.cardTag;
            Console.WriteLine(small.cardPosition);        
            deckFlowlayoutPanel.Controls.Add(small);

            nowDeck.Add(card);
        }
        public void showCardInfo(int tag)
        {
            Card card = co.selectFromTag(tag);
            string picname = "../pic/" + card.number + ".png";
            cardFlame.Image = Image.FromFile(@picname);
            CardNameText.Text = card.name;
            string[] sArray = card.effect.Split('/');
            StringBuilder sb = new StringBuilder();
            foreach (string temp in sArray)
            {
                sb.Append(temp + Environment.NewLine);
            }
            string effectText = sb.ToString();
            cardDescriptionText.Text = card.introduction+ Environment.NewLine + effectText;
            cardDescriptionText.SelectionStart = card.introduction.Length - 1;
            cardDescriptionText.SelectionLength = effectText.Length;
            cardDescriptionText.SelectionFont = new System.Drawing.Font("黑体 ", 10.5F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,
                ((System.Byte)(0)));
        }
        public void deleteCardFromDeck(smallCard small)
        {
            deckFlowlayoutPanel.Controls.Remove(small);
            nowDeck.RemoveAt(small.cardPosition);
        }

        private void deckResetButton_Click(object sender, EventArgs e)
        {
            nowDeck = nowDeck.OrderBy(Card => Card.type).ToList();
            nowDeck = nowDeck.OrderBy(Card => Card.level).ToList();
            deckFlowlayoutPanel.Controls.Clear();
            foreach (Card card in nowDeck)
            {
                smallCard small = new smallCard();
                string picname = "../pic/" + card.number + ".png";
                small.cardpicbox.Image = Image.FromFile(@picname);
                small.cardPosition = nowDeck.Count;
                small.owner = this;
                small.cardid = card.cardTag;
                Console.WriteLine(small.cardPosition);
                deckFlowlayoutPanel.Controls.Add(small);
            }
        }

        private void deckSaveButton_Click(object sender, EventArgs e)
        {
            if (deckComboBox.Text == null || deckComboBox.Text == "")
            {
                MessageBox.Show("请新建卡组！");
            }
            else
            {
                co.saveDeck(nowDeck, deckComboBox.Text);
            }
            
        }

        private void deckResaveButtom_Click(object sender, EventArgs e)
        {
            if(deckNameBox.Text==null|| deckNameBox.Text == "")
            {
                MessageBox.Show("卡组名不能为空！");
            }
            else
            {
                foreach (string name in deckComboBox.Items)
                {
                    if(deckNameBox.Text == name)
                    {
                        MessageBox.Show("卡组名已存在！");
                    }
                    return;
                }
                co.saveDeck(nowDeck, deckNameBox.Text);
                deckComboBox.Items.Add(deckNameBox.Text);
                deckComboBox.Text = deckNameBox.Text;
            }
            
        }

        private void deckComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            nowDeck = co.openDeck(deckComboBox.Text);
            deckFlowlayoutPanel.Controls.Clear();
            foreach (Card card in nowDeck)
            {
                smallCard small = new smallCard();
                string picname = "../pic/" + card.number + ".png";
                small.cardpicbox.Image = Image.FromFile(@picname);
                small.cardPosition = nowDeck.Count;
                small.owner = this;
                small.cardid = card.cardTag;
                Console.WriteLine(small.cardPosition);
                deckFlowlayoutPanel.Controls.Add(small);
            }
        }
    }
}
