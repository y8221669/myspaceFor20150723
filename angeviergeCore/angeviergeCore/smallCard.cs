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
    // public delegate void Mydelegate(int tag);
    public delegate void deleteCardFromDeck(smallCard card);
    public partial class smallCard : UserControl
    {
        
        bool showtag = false;
        public int cardPosition;
        public int cardid;
        public MainForm owner;
        public smallCard()
        {
            InitializeComponent();
        }

        private void cardpicbox_Click(object sender, EventArgs e)
        {

        }

        private void smallpanel_MouseEnter(object sender, EventArgs e)
        {
            showtag = true;
            Refresh();
            Mydelegate dg = new Mydelegate(owner.showCardInfo);
            dg(cardid);
        }

        private void smallpanel_Paint(object sender, PaintEventArgs e)
        {
            if (!showtag)
            {
                ControlPaint.DrawBorder(e.Graphics,
                     this.smallpanel.ClientRectangle,
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
            }
            else
            {
                ControlPaint.DrawBorder(e.Graphics,
                                   this.smallpanel.ClientRectangle,
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

        private void smallpanel_MouseLeave(object sender, EventArgs e)
        {
            showtag = false;
            Refresh();
        }

        private void smallpanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                deleteCardFromDeck dcd = new deleteCardFromDeck(owner.deleteCardFromDeck);
                dcd(this);
            }
        }
    }
}
