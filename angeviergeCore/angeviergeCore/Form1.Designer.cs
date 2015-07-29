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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cardFlame = new System.Windows.Forms.PictureBox();
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
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.descriptionLable = new System.Windows.Forms.Label();
            this.effectLable = new System.Windows.Forms.Label();
            this.CardNameText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cardFlame)).BeginInit();
            this.deckPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.searchEndPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bgpicBox)).BeginInit();
            this.descriptionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardFlame
            // 
            this.cardFlame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardFlame.BackColor = System.Drawing.Color.Transparent;
            this.cardFlame.BackgroundImage = global::angeviergeCore.Properties.Resources.bg_av_4;
            this.cardFlame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardFlame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cardFlame.Location = new System.Drawing.Point(0, 0);
            this.cardFlame.Name = "cardFlame";
            this.cardFlame.Size = new System.Drawing.Size(200, 274);
            this.cardFlame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardFlame.TabIndex = 1;
            this.cardFlame.TabStop = false;
            // 
            // deckPanel
            // 
            this.deckPanel.BackColor = System.Drawing.Color.LightGray;
            this.deckPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.deckPanel.Controls.Add(this.deckCleanButton);
            this.deckPanel.Controls.Add(this.deckResetButton);
            this.deckPanel.Controls.Add(this.deckUpsetButton);
            this.deckPanel.Controls.Add(this.exitDeckButton);
            this.deckPanel.Controls.Add(this.deckResaveButtom);
            this.deckPanel.Controls.Add(this.deckSaveButton);
            this.deckPanel.Controls.Add(this.deckNameBox);
            this.deckPanel.Controls.Add(this.deckComboBox);
            this.deckPanel.Controls.Add(this.label1);
            this.deckPanel.Location = new System.Drawing.Point(339, 4);
            this.deckPanel.Name = "deckPanel";
            this.deckPanel.Size = new System.Drawing.Size(300, 130);
            this.deckPanel.TabIndex = 4;
            // 
            // deckCleanButton
            // 
            this.deckCleanButton.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deckCleanButton.Location = new System.Drawing.Point(238, 87);
            this.deckCleanButton.Name = "deckCleanButton";
            this.deckCleanButton.Size = new System.Drawing.Size(55, 23);
            this.deckCleanButton.TabIndex = 8;
            this.deckCleanButton.Text = "清空";
            this.deckCleanButton.UseVisualStyleBackColor = true;
            // 
            // deckResetButton
            // 
            this.deckResetButton.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deckResetButton.Location = new System.Drawing.Point(177, 87);
            this.deckResetButton.Name = "deckResetButton";
            this.deckResetButton.Size = new System.Drawing.Size(55, 23);
            this.deckResetButton.TabIndex = 7;
            this.deckResetButton.Text = "排序";
            this.deckResetButton.UseVisualStyleBackColor = true;
            this.deckResetButton.Click += new System.EventHandler(this.deckResetButton_Click);
            // 
            // deckUpsetButton
            // 
            this.deckUpsetButton.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deckUpsetButton.Location = new System.Drawing.Point(116, 87);
            this.deckUpsetButton.Name = "deckUpsetButton";
            this.deckUpsetButton.Size = new System.Drawing.Size(55, 23);
            this.deckUpsetButton.TabIndex = 6;
            this.deckUpsetButton.Text = "打乱";
            this.deckUpsetButton.UseVisualStyleBackColor = true;
            this.deckUpsetButton.Visible = false;
            this.deckUpsetButton.Click += new System.EventHandler(this.deckUpsetButton_Click);
            // 
            // exitDeckButton
            // 
            this.exitDeckButton.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exitDeckButton.Location = new System.Drawing.Point(4, 87);
            this.exitDeckButton.Name = "exitDeckButton";
            this.exitDeckButton.Size = new System.Drawing.Size(75, 23);
            this.exitDeckButton.TabIndex = 5;
            this.exitDeckButton.Text = "退出编辑";
            this.exitDeckButton.UseVisualStyleBackColor = true;
            this.exitDeckButton.Visible = false;
            this.exitDeckButton.Click += new System.EventHandler(this.exitDeckButton_Click);
            // 
            // deckResaveButtom
            // 
            this.deckResaveButtom.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deckResaveButtom.Location = new System.Drawing.Point(219, 39);
            this.deckResaveButtom.Name = "deckResaveButtom";
            this.deckResaveButtom.Size = new System.Drawing.Size(75, 23);
            this.deckResaveButtom.TabIndex = 4;
            this.deckResaveButtom.Text = "另存";
            this.deckResaveButtom.UseVisualStyleBackColor = true;
            this.deckResaveButtom.Click += new System.EventHandler(this.deckResaveButtom_Click);
            // 
            // deckSaveButton
            // 
            this.deckSaveButton.BackColor = System.Drawing.SystemColors.Control;
            this.deckSaveButton.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deckSaveButton.Location = new System.Drawing.Point(219, 10);
            this.deckSaveButton.Name = "deckSaveButton";
            this.deckSaveButton.Size = new System.Drawing.Size(75, 23);
            this.deckSaveButton.TabIndex = 3;
            this.deckSaveButton.Text = "保存";
            this.deckSaveButton.UseVisualStyleBackColor = false;
            this.deckSaveButton.Click += new System.EventHandler(this.deckSaveButton_Click);
            // 
            // deckNameBox
            // 
            this.deckNameBox.Location = new System.Drawing.Point(85, 40);
            this.deckNameBox.Name = "deckNameBox";
            this.deckNameBox.Size = new System.Drawing.Size(121, 21);
            this.deckNameBox.TabIndex = 2;
            // 
            // deckComboBox
            // 
            this.deckComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deckComboBox.FormattingEnabled = true;
            this.deckComboBox.Location = new System.Drawing.Point(85, 13);
            this.deckComboBox.Name = "deckComboBox";
            this.deckComboBox.Size = new System.Drawing.Size(121, 20);
            this.deckComboBox.TabIndex = 1;
            this.deckComboBox.SelectedIndexChanged += new System.EventHandler(this.deckComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "卡组列表：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.LightGray;
            this.searchPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.searchPanel.Location = new System.Drawing.Point(645, 4);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(367, 130);
            this.searchPanel.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.label6.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.label5.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.label4.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(32, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "种类：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.label2.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.searchFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.searchEndPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.searchSumLabel.Location = new System.Drawing.Point(5, 3);
            this.searchSumLabel.Name = "searchSumLabel";
            this.searchSumLabel.Size = new System.Drawing.Size(89, 12);
            this.searchSumLabel.TabIndex = 0;
            this.searchSumLabel.Text = "搜索结果：    ";
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
            this.deckFlowlayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.deckFlowlayoutPanel.Location = new System.Drawing.Point(339, 138);
            this.deckFlowlayoutPanel.Name = "deckFlowlayoutPanel";
            this.deckFlowlayoutPanel.Size = new System.Drawing.Size(436, 498);
            this.deckFlowlayoutPanel.TabIndex = 12;
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionPanel.BackgroundImage = global::angeviergeCore.Properties.Resources.bg_av_4;
            this.descriptionPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.descriptionPanel.Controls.Add(this.descriptionLable);
            this.descriptionPanel.Controls.Add(this.effectLable);
            this.descriptionPanel.Controls.Add(this.CardNameText);
            this.descriptionPanel.Location = new System.Drawing.Point(0, 280);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Size = new System.Drawing.Size(333, 356);
            this.descriptionPanel.TabIndex = 14;
            // 
            // descriptionLable
            // 
            this.descriptionLable.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.descriptionLable.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.descriptionLable.Location = new System.Drawing.Point(18, 39);
            this.descriptionLable.Name = "descriptionLable";
            this.descriptionLable.Size = new System.Drawing.Size(298, 31);
            this.descriptionLable.TabIndex = 2;
            // 
            // effectLable
            // 
            this.effectLable.BackColor = System.Drawing.Color.Transparent;
            this.effectLable.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.effectLable.Location = new System.Drawing.Point(17, 87);
            this.effectLable.Name = "effectLable";
            this.effectLable.Size = new System.Drawing.Size(300, 253);
            this.effectLable.TabIndex = 1;
            // 
            // CardNameText
            // 
            this.CardNameText.BackColor = System.Drawing.Color.Transparent;
            this.CardNameText.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CardNameText.Location = new System.Drawing.Point(16, 11);
            this.CardNameText.Name = "CardNameText";
            this.CardNameText.Size = new System.Drawing.Size(301, 25);
            this.CardNameText.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::angeviergeCore.Properties.Resources.凉宫;
            this.ClientSize = new System.Drawing.Size(1024, 641);
            this.Controls.Add(this.descriptionPanel);
            this.Controls.Add(this.deckFlowlayoutPanel);
            this.Controls.Add(this.searchEndPanel);
            this.Controls.Add(this.searchFlowLayoutPanel);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.deckPanel);
            this.Controls.Add(this.cardFlame);
            this.Controls.Add(this.bgpicBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Angevierge";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardFlame)).EndInit();
            this.deckPanel.ResumeLayout(false);
            this.deckPanel.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.searchEndPanel.ResumeLayout(false);
            this.searchEndPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bgpicBox)).EndInit();
            this.descriptionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cardFlame;
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
        private System.Windows.Forms.Panel descriptionPanel;
        private System.Windows.Forms.Label CardNameText;
        private System.Windows.Forms.Label effectLable;
        private System.Windows.Forms.Label descriptionLable;
    }
}

