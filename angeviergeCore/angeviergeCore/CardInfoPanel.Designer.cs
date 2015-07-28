
namespace angeviergeCore
{
    partial class CardInfoPanel
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardInfoPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.levelLabel = new System.Windows.Forms.Label();
            this.powerAndDefendLabel = new System.Windows.Forms.Label();
            this.colorAndsortLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.cardPic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::angeviergeCore.Properties.Resources.bg_av_2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.levelLabel);
            this.panel1.Controls.Add(this.powerAndDefendLabel);
            this.panel1.Controls.Add(this.colorAndsortLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.cardPic);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 64);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.levelLabel.ForeColor = System.Drawing.Color.White;
            this.levelLabel.Location = new System.Drawing.Point(125, 23);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(14, 14);
            this.levelLabel.TabIndex = 4;
            this.levelLabel.Text = "4";
            // 
            // powerAndDefendLabel
            // 
            this.powerAndDefendLabel.AutoSize = true;
            this.powerAndDefendLabel.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.powerAndDefendLabel.ForeColor = System.Drawing.Color.White;
            this.powerAndDefendLabel.Location = new System.Drawing.Point(53, 40);
            this.powerAndDefendLabel.Name = "powerAndDefendLabel";
            this.powerAndDefendLabel.Size = new System.Drawing.Size(77, 14);
            this.powerAndDefendLabel.TabIndex = 3;
            this.powerAndDefendLabel.Text = "10000/4000";
            this.powerAndDefendLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // colorAndsortLabel
            // 
            this.colorAndsortLabel.AutoSize = true;
            this.colorAndsortLabel.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colorAndsortLabel.ForeColor = System.Drawing.Color.White;
            this.colorAndsortLabel.Location = new System.Drawing.Point(53, 23);
            this.colorAndsortLabel.Name = "colorAndsortLabel";
            this.colorAndsortLabel.Size = new System.Drawing.Size(42, 14);
            this.colorAndsortLabel.TabIndex = 2;
            this.colorAndsortLabel.Text = "黑/PG";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(54, 8);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(119, 12);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "真理的黑魔女 索菲娜";
            // 
            // cardPic
            // 
            this.cardPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cardPic.Image = ((System.Drawing.Image)(resources.GetObject("cardPic.Image")));
            this.cardPic.InitialImage = null;
            this.cardPic.Location = new System.Drawing.Point(3, 1);
            this.cardPic.Name = "cardPic";
            this.cardPic.Size = new System.Drawing.Size(45, 62);
            this.cardPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardPic.TabIndex = 0;
            this.cardPic.TabStop = false;
            // 
            // CardInfoPanel
            // 
          //  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
          //  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "CardInfoPanel";
            this.Size = new System.Drawing.Size(194, 68);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label powerAndDefendLabel;
        public System.Windows.Forms.Label colorAndsortLabel;
        public System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.PictureBox cardPic;
        public System.Windows.Forms.Label levelLabel;
        public int cardTag;
    }
}
