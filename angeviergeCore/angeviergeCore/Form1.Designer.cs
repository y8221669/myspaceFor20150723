namespace angeviergeCore
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cardFlame = new System.Windows.Forms.PictureBox();
            this.cardTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cardDescriptionText = new System.Windows.Forms.RichTextBox();
            this.CardNameText = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.deckPanel = new System.Windows.Forms.Panel();
            this.deckCleanButton = new System.Windows.Forms.Button();
            this.deckResetButton = new System.Windows.Forms.Button();
            this.deckUpsetButton = new System.Windows.Forms.Button();
            this.exitDeckButton = new System.Windows.Forms.Button();
            this.deckResaveButtom = new System.Windows.Forms.Button();
            this.deckSaveButton = new System.Windows.Forms.Button();
            this.deckNameBox = new System.Windows.Forms.TextBox();
            this.deckComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchKeyText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.singleComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.levelComboBox = new System.Windows.Forms.ComboBox();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchEndPanel = new System.Windows.Forms.Panel();
            this.searchSumLabel = new System.Windows.Forms.Label();
            this.bgpicBox = new System.Windows.Forms.PictureBox();
            this.deckFlowlayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.cardFlame)).BeginInit();
            this.cardTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.deckPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.searchEndPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bgpicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cardFlame
            // 
            this.cardFlame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardFlame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cardFlame.Location = new System.Drawing.Point(0, 0);
            this.cardFlame.Name = "cardFlame";
            this.cardFlame.Size = new System.Drawing.Size(200, 274);
            this.cardFlame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardFlame.TabIndex = 1;
            this.cardFlame.TabStop = false;
            // 
            // cardTabControl
            // 
            this.cardTabControl.Controls.Add(this.tabPage1);
            this.cardTabControl.Controls.Add(this.tabPage2);
            this.cardTabControl.Controls.Add(this.tabPage3);
            this.cardTabControl.Location = new System.Drawing.Point(0, 280);
            this.cardTabControl.Name = "cardTabControl";
            this.cardTabControl.SelectedIndex = 0;
            this.cardTabControl.Size = new System.Drawing.Size(300, 360);
            this.cardTabControl.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cardDescriptionText);
            this.tabPage1.Controls.Add(this.CardNameText);
            this.tabPage1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(292, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "卡片信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cardDescriptionText
            // 
            this.cardDescriptionText.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cardDescriptionText.Location = new System.Drawing.Point(8, 54);
            this.cardDescriptionText.Name = "cardDescriptionText";
            this.cardDescriptionText.ReadOnly = true;
            this.cardDescriptionText.Size = new System.Drawing.Size(278, 273);
            this.cardDescriptionText.TabIndex = 1;
            this.cardDescriptionText.Text = "";
            // 
            // CardNameText
            // 
            this.CardNameText.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CardNameText.Location = new System.Drawing.Point(8, 19);
            this.CardNameText.Name = "CardNameText";
            this.CardNameText.ReadOnly = true;
            this.CardNameText.Size = new System.Drawing.Size(278, 29);
            this.CardNameText.TabIndex = 0;
            this.CardNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(292, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "消息记录";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(292, 334);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "系统设定";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // deckPanel
            // 
            this.deckPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deckPanel.Controls.Add(this.deckCleanButton);
            this.deckPanel.Controls.Add(this.deckResetButton);
            this.deckPanel.Controls.Add(this.deckUpsetButton);
            this.deckPanel.Controls.Add(this.exitDeckButton);
            this.deckPanel.Controls.Add(this.deckResaveButtom);
            this.deckPanel.Controls.Add(this.deckSaveButton);
            this.deckPanel.Controls.Add(this.deckNameBox);
            this.deckPanel.Controls.Add(this.deckComboBox);
            this.deckPanel.Controls.Add(this.label1);
            this.deckPanel.Location = new System.Drawing.Point(339, 12);
            this.deckPanel.Name = "deckPanel";
            this.deckPanel.Size = new System.Drawing.Size(300, 122);
            this.deckPanel.TabIndex = 4;
            // 
            // deckCleanButton
            // 
            this.deckCleanButton.Location = new System.Drawing.Point(241, 87);
            this.deckCleanButton.Name = "deckCleanButton";
            this.deckCleanButton.Size = new System.Drawing.Size(55, 23);
            this.deckCleanButton.TabIndex = 8;
            this.deckCleanButton.Text = "清空";
            this.deckCleanButton.UseVisualStyleBackColor = true;
            // 
            // deckResetButton
            // 
            this.deckResetButton.Location = new System.Drawing.Point(180, 87);
            this.deckResetButton.Name = "deckResetButton";
            this.deckResetButton.Size = new System.Drawing.Size(55, 23);
            this.deckResetButton.TabIndex = 7;
            this.deckResetButton.Text = "排序";
            this.deckResetButton.UseVisualStyleBackColor = true;
            this.deckResetButton.Click += new System.EventHandler(this.deckResetButton_Click);
            // 
            // deckUpsetButton
            // 
            this.deckUpsetButton.Location = new System.Drawing.Point(119, 87);
            this.deckUpsetButton.Name = "deckUpsetButton";
            this.deckUpsetButton.Size = new System.Drawing.Size(55, 23);
            this.deckUpsetButton.TabIndex = 6;
            this.deckUpsetButton.Text = "打乱";
            this.deckUpsetButton.UseVisualStyleBackColor = true;
            this.deckUpsetButton.Click += new System.EventHandler(this.deckUpsetButton_Click);
            // 
            // exitDeckButton
            // 
            this.exitDeckButton.Location = new System.Drawing.Point(7, 87);
            this.exitDeckButton.Name = "exitDeckButton";
            this.exitDeckButton.Size = new System.Drawing.Size(75, 23);
            this.exitDeckButton.TabIndex = 5;
            this.exitDeckButton.Text = "退出编辑";
            this.exitDeckButton.UseVisualStyleBackColor = true;
            this.exitDeckButton.Click += new System.EventHandler(this.exitDeckButton_Click);
            // 
            // deckResaveButtom
            // 
            this.deckResaveButtom.Location = new System.Drawing.Point(222, 39);
            this.deckResaveButtom.Name = "deckResaveButtom";
            this.deckResaveButtom.Size = new System.Drawing.Size(75, 23);
            this.deckResaveButtom.TabIndex = 4;
            this.deckResaveButtom.Text = "另存";
            this.deckResaveButtom.UseVisualStyleBackColor = true;
            this.deckResaveButtom.Click += new System.EventHandler(this.deckResaveButtom_Click);
            // 
            // deckSaveButton
            // 
            this.deckSaveButton.Location = new System.Drawing.Point(222, 10);
            this.deckSaveButton.Name = "deckSaveButton";
            this.deckSaveButton.Size = new System.Drawing.Size(75, 23);
            this.deckSaveButton.TabIndex = 3;
            this.deckSaveButton.Text = "保存";
            this.deckSaveButton.UseVisualStyleBackColor = true;
            this.deckSaveButton.Click += new System.EventHandler(this.deckSaveButton_Click);
            // 
            // deckNameBox
            // 
            this.deckNameBox.Location = new System.Drawing.Point(88, 40);
            this.deckNameBox.Name = "deckNameBox";
            this.deckNameBox.Size = new System.Drawing.Size(121, 21);
            this.deckNameBox.TabIndex = 2;
            // 
            // deckComboBox
            // 
            this.deckComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deckComboBox.FormattingEnabled = true;
            this.deckComboBox.Location = new System.Drawing.Point(88, 13);
            this.deckComboBox.Name = "deckComboBox";
            this.deckComboBox.Size = new System.Drawing.Size(121, 20);
            this.deckComboBox.TabIndex = 1;
            this.deckComboBox.SelectedIndexChanged += new System.EventHandler(this.deckComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "卡组列表：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchPanel.Controls.Add(this.searchButton);
            this.searchPanel.Controls.Add(this.searchKeyText);
            this.searchPanel.Controls.Add(this.label6);
            this.searchPanel.Controls.Add(this.singleComboBox);
            this.searchPanel.Controls.Add(this.label5);
            this.searchPanel.Controls.Add(this.typeComboBox);
            this.searchPanel.Controls.Add(this.label4);
            this.searchPanel.Controls.Add(this.label3);
            this.searchPanel.Controls.Add(this.levelComboBox);
            this.searchPanel.Controls.Add(this.colorComboBox);
            this.searchPanel.Controls.Add(this.label2);
            this.searchPanel.Location = new System.Drawing.Point(645, 12);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(367, 122);
            this.searchPanel.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(265, 75);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "搜索";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchKeyText
            // 
            this.searchKeyText.Location = new System.Drawing.Point(80, 77);
            this.searchKeyText.Name = "searchKeyText";
            this.searchKeyText.Size = new System.Drawing.Size(159, 21);
            this.searchKeyText.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "关键字：";
            // 
            // singleComboBox
            // 
            this.singleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.singleComboBox.FormattingEnabled = true;
            this.singleComboBox.Location = new System.Drawing.Point(245, 46);
            this.singleComboBox.Name = "singleComboBox";
            this.singleComboBox.Size = new System.Drawing.Size(95, 20);
            this.singleComboBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "边框：";
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(80, 46);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(95, 20);
            this.typeComboBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "种类：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "等级：";
            // 
            // levelComboBox
            // 
            this.levelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.levelComboBox.FormattingEnabled = true;
            this.levelComboBox.Location = new System.Drawing.Point(245, 12);
            this.levelComboBox.Name = "levelComboBox";
            this.levelComboBox.Size = new System.Drawing.Size(96, 20);
            this.levelComboBox.TabIndex = 2;
            // 
            // colorComboBox
            // 
            this.colorComboBox.DisplayMember = "1";
            this.colorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(80, 13);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(95, 20);
            this.colorComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "颜色：";
            // 
            // searchFlowLayoutPanel
            // 
            this.searchFlowLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchFlowLayoutPanel.AutoScroll = true;
            this.searchFlowLayoutPanel.AutoScrollMinSize = new System.Drawing.Size(100, 0);
            this.searchFlowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.searchFlowLayoutPanel.BackgroundImage = global::angeviergeCore.Properties.Resources.bg_av_3;
            this.searchFlowLayoutPanel.Location = new System.Drawing.Point(781, 166);
            this.searchFlowLayoutPanel.Name = "searchFlowLayoutPanel";
            this.searchFlowLayoutPanel.Size = new System.Drawing.Size(231, 470);
            this.searchFlowLayoutPanel.TabIndex = 7;
            this.searchFlowLayoutPanel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.searchFlowLayoutPanel_Scroll);
            this.searchFlowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.searchFlowLayoutPanel_Paint);
            // 
            // searchEndPanel
            // 
            this.searchEndPanel.BackColor = System.Drawing.Color.Transparent;
            this.searchEndPanel.BackgroundImage = global::angeviergeCore.Properties.Resources.bg_av_3;
            this.searchEndPanel.Controls.Add(this.searchSumLabel);
            this.searchEndPanel.Location = new System.Drawing.Point(781, 138);
            this.searchEndPanel.Name = "searchEndPanel";
            this.searchEndPanel.Size = new System.Drawing.Size(114, 22);
            this.searchEndPanel.TabIndex = 8;
            this.searchEndPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.searchEndPanel_Paint);
            // 
            // searchSumLabel
            // 
            this.searchSumLabel.AutoSize = true;
            this.searchSumLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchSumLabel.ForeColor = System.Drawing.Color.White;
            this.searchSumLabel.Location = new System.Drawing.Point(5, 5);
            this.searchSumLabel.Name = "searchSumLabel";
            this.searchSumLabel.Size = new System.Drawing.Size(83, 12);
            this.searchSumLabel.TabIndex = 0;
            this.searchSumLabel.Text = "搜索结果：800";
            // 
            // bgpicBox
            // 
            this.bgpicBox.Image = global::angeviergeCore.Properties.Resources.凉宫;
            this.bgpicBox.Location = new System.Drawing.Point(0, 0);
            this.bgpicBox.Name = "bgpicBox";
            this.bgpicBox.Size = new System.Drawing.Size(1040, 680);
            this.bgpicBox.TabIndex = 10;
            this.bgpicBox.TabStop = false;
            // 
            // deckFlowlayoutPanel
            // 
            this.deckFlowlayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.deckFlowlayoutPanel.BackgroundImage = global::angeviergeCore.Properties.Resources.bg_av_3;
            this.deckFlowlayoutPanel.Location = new System.Drawing.Point(339, 138);
            this.deckFlowlayoutPanel.Name = "deckFlowlayoutPanel";
            this.deckFlowlayoutPanel.Size = new System.Drawing.Size(436, 498);
            this.deckFlowlayoutPanel.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::angeviergeCore.Properties.Resources.凉宫;
            this.ClientSize = new System.Drawing.Size(1024, 641);
            this.Controls.Add(this.deckFlowlayoutPanel);
            this.Controls.Add(this.searchEndPanel);
            this.Controls.Add(this.searchFlowLayoutPanel);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.deckPanel);
            this.Controls.Add(this.cardTabControl);
            this.Controls.Add(this.cardFlame);
            this.Controls.Add(this.bgpicBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Angevierge";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardFlame)).EndInit();
            this.cardTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.deckPanel.ResumeLayout(false);
            this.deckPanel.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.searchEndPanel.ResumeLayout(false);
            this.searchEndPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bgpicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cardFlame;
        private System.Windows.Forms.TabControl cardTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox cardDescriptionText;
        private System.Windows.Forms.TextBox CardNameText;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel deckPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deckCleanButton;
        private System.Windows.Forms.Button deckResetButton;
        private System.Windows.Forms.Button deckUpsetButton;
        private System.Windows.Forms.Button exitDeckButton;
        private System.Windows.Forms.Button deckResaveButtom;
        private System.Windows.Forms.Button deckSaveButton;
        private System.Windows.Forms.TextBox deckNameBox;
        private System.Windows.Forms.ComboBox deckComboBox;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchKeyText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox singleComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox levelComboBox;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel searchFlowLayoutPanel;
        private System.Windows.Forms.Panel searchEndPanel;
        private System.Windows.Forms.Label searchSumLabel;
        private System.Windows.Forms.PictureBox bgpicBox;
        private System.Windows.Forms.FlowLayoutPanel deckFlowlayoutPanel;
    }
}

