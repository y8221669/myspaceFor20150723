namespace angeviergeCore
{
    partial class smallCard
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.smallpanel = new System.Windows.Forms.Panel();
            this.cardpicbox = new System.Windows.Forms.PictureBox();
            this.smallpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardpicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // smallpanel
            // 
            this.smallpanel.BackColor = System.Drawing.Color.Transparent;
            this.smallpanel.Controls.Add(this.cardpicbox);
            this.smallpanel.Location = new System.Drawing.Point(0, 0);
            this.smallpanel.Name = "smallpanel";
            this.smallpanel.Size = new System.Drawing.Size(47, 64);
            this.smallpanel.TabIndex = 0;
            this.smallpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.smallpanel_Paint);
            this.smallpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.smallpanel_MouseDown);
            this.smallpanel.MouseEnter += new System.EventHandler(this.smallpanel_MouseEnter);
            this.smallpanel.MouseLeave += new System.EventHandler(this.smallpanel_MouseLeave);
            // 
            // cardpicbox
            // 
            this.cardpicbox.BackColor = System.Drawing.Color.Transparent;
            this.cardpicbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cardpicbox.Enabled = false;
            this.cardpicbox.Location = new System.Drawing.Point(1, 1);
            this.cardpicbox.Name = "cardpicbox";
            this.cardpicbox.Size = new System.Drawing.Size(45, 62);
            this.cardpicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardpicbox.TabIndex = 0;
            this.cardpicbox.TabStop = false;
            this.cardpicbox.Click += new System.EventHandler(this.cardpicbox_Click);
            // 
            // smallCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.smallpanel);
            this.Name = "smallCard";
            this.Size = new System.Drawing.Size(47, 64);
            this.smallpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cardpicbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel smallpanel;
        public System.Windows.Forms.PictureBox cardpicbox;
    }
}
