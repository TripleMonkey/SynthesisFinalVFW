namespace NigelKrajewski_Final
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxItems = new System.Windows.Forms.GroupBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.publisherComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.abel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripConnection = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripRetryImage = new System.Windows.Forms.ToolStripDropDownButton();
            this.retryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusDetails = new System.Windows.Forms.ToolStripStatusLabel();
            this.itemListView = new System.Windows.Forms.ListView();
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.labelChooseItem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStripConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxItems
            // 
            this.groupBoxItems.Controls.Add(this.label1);
            this.groupBoxItems.Controls.Add(this.updateButton);
            this.groupBoxItems.Controls.Add(this.publisherComboBox);
            this.groupBoxItems.Controls.Add(this.categoryComboBox);
            this.groupBoxItems.Controls.Add(this.numericPrice);
            this.groupBoxItems.Controls.Add(this.textBoxTitle);
            this.groupBoxItems.Controls.Add(this.label4);
            this.groupBoxItems.Controls.Add(this.abel);
            this.groupBoxItems.Controls.Add(this.priceLabel);
            this.groupBoxItems.Controls.Add(this.titleLabel);
            this.groupBoxItems.Location = new System.Drawing.Point(41, 592);
            this.groupBoxItems.Name = "groupBoxItems";
            this.groupBoxItems.Size = new System.Drawing.Size(699, 340);
            this.groupBoxItems.TabIndex = 3;
            this.groupBoxItems.TabStop = false;
            this.groupBoxItems.Text = "Edit Item";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(377, 246);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(302, 61);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "Update Item";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // publisherComboBox
            // 
            this.publisherComboBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.publisherComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.publisherComboBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.publisherComboBox.FormattingEnabled = true;
            this.publisherComboBox.Location = new System.Drawing.Point(131, 176);
            this.publisherComboBox.Name = "publisherComboBox";
            this.publisherComboBox.Size = new System.Drawing.Size(548, 33);
            this.publisherComboBox.TabIndex = 9;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(131, 112);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(548, 33);
            this.categoryComboBox.TabIndex = 8;
            // 
            // numericPrice
            // 
            this.numericPrice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.numericPrice.DecimalPlaces = 2;
            this.numericPrice.Enabled = false;
            this.numericPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numericPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericPrice.Location = new System.Drawing.Point(155, 249);
            this.numericPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(142, 31);
            this.numericPrice.TabIndex = 7;
            this.numericPrice.Tag = "";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxTitle.Enabled = false;
            this.textBoxTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxTitle.Location = new System.Drawing.Point(131, 57);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ReadOnly = true;
            this.textBoxTitle.Size = new System.Drawing.Size(548, 31);
            this.textBoxTitle.TabIndex = 4;
            this.textBoxTitle.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Publisher:";
            // 
            // abel
            // 
            this.abel.AutoSize = true;
            this.abel.Location = new System.Drawing.Point(18, 115);
            this.abel.Name = "abel";
            this.abel.Size = new System.Drawing.Size(105, 25);
            this.abel.TabIndex = 2;
            this.abel.Text = "Category:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(50, 251);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(73, 25);
            this.priceLabel.TabIndex = 1;
            this.priceLabel.Text = "Price: ";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(64, 60);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(59, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 40);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.TabStop = true;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(272, 44);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largeIconToolStripMenuItem,
            this.smallIconToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(86, 36);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // largeIconToolStripMenuItem
            // 
            this.largeIconToolStripMenuItem.Checked = true;
            this.largeIconToolStripMenuItem.CheckOnClick = true;
            this.largeIconToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
            this.largeIconToolStripMenuItem.Size = new System.Drawing.Size(259, 44);
            this.largeIconToolStripMenuItem.Text = "Large Icon";
            this.largeIconToolStripMenuItem.Click += new System.EventHandler(this.largeIconToolStripMenuItem_Click);
            // 
            // smallIconToolStripMenuItem
            // 
            this.smallIconToolStripMenuItem.CheckOnClick = true;
            this.smallIconToolStripMenuItem.Name = "smallIconToolStripMenuItem";
            this.smallIconToolStripMenuItem.Size = new System.Drawing.Size(259, 44);
            this.smallIconToolStripMenuItem.Text = "Small Icon";
            this.smallIconToolStripMenuItem.Click += new System.EventHandler(this.smallIconToolStripMenuItem_Click);
            // 
            // statusStripConnection
            // 
            this.statusStripConnection.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStripConnection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripRetryImage,
            this.toolStripStatusDetails});
            this.statusStripConnection.Location = new System.Drawing.Point(0, 964);
            this.statusStripConnection.Name = "statusStripConnection";
            this.statusStripConnection.Size = new System.Drawing.Size(794, 42);
            this.statusStripConnection.TabIndex = 5;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(216, 32);
            this.toolStripStatusLabel1.Text = "Connection failed. ";
            // 
            // toolStripRetryImage
            // 
            this.toolStripRetryImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRetryImage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.retryToolStripMenuItem});
            this.toolStripRetryImage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRetryImage.Image")));
            this.toolStripRetryImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRetryImage.Name = "toolStripRetryImage";
            this.toolStripRetryImage.Size = new System.Drawing.Size(54, 38);
            // 
            // retryToolStripMenuItem
            // 
            this.retryToolStripMenuItem.Name = "retryToolStripMenuItem";
            this.retryToolStripMenuItem.Size = new System.Drawing.Size(203, 44);
            this.retryToolStripMenuItem.Text = "Retry";
            this.retryToolStripMenuItem.Click += new System.EventHandler(this.retryToolStripMenuItem_Click);
            // 
            // toolStripStatusDetails
            // 
            this.toolStripStatusDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.toolStripStatusDetails.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusDetails.Name = "toolStripStatusDetails";
            this.toolStripStatusDetails.Size = new System.Drawing.Size(84, 32);
            this.toolStripStatusDetails.Text = "details";
            this.toolStripStatusDetails.Click += new System.EventHandler(this.toolStripStatusDetails_Click);
            // 
            // itemListView
            // 
            this.itemListView.HideSelection = false;
            this.itemListView.LargeImageList = this.imageListLarge;
            this.itemListView.Location = new System.Drawing.Point(41, 148);
            this.itemListView.MultiSelect = false;
            this.itemListView.Name = "itemListView";
            this.itemListView.Size = new System.Drawing.Size(699, 396);
            this.itemListView.SmallImageList = this.imageListSmall;
            this.itemListView.TabIndex = 6;
            this.itemListView.UseCompatibleStateImageBehavior = false;
            this.itemListView.DoubleClick += new System.EventHandler(this.itemListView_DoubleClick);
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "Comic.png");
            this.imageListLarge.Images.SetKeyName(1, "Card.png");
            this.imageListLarge.Images.SetKeyName(2, "Game.png");
            this.imageListLarge.Images.SetKeyName(3, "Video.png");
            this.imageListLarge.Images.SetKeyName(4, "Merc.png");
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "Comic.png");
            this.imageListSmall.Images.SetKeyName(1, "Card.png");
            this.imageListSmall.Images.SetKeyName(2, "Game.png");
            this.imageListSmall.Images.SetKeyName(3, "Video.png");
            this.imageListSmall.Images.SetKeyName(4, "Merc.png");
            // 
            // labelChooseItem
            // 
            this.labelChooseItem.AutoSize = true;
            this.labelChooseItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseItem.Location = new System.Drawing.Point(36, 88);
            this.labelChooseItem.Name = "labelChooseItem";
            this.labelChooseItem.Size = new System.Drawing.Size(291, 29);
            this.labelChooseItem.TabIndex = 7;
            this.labelChooseItem.Text = "Double click to view / edit:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 1006);
            this.Controls.Add(this.labelChooseItem);
            this.Controls.Add(this.itemListView);
            this.Controls.Add(this.statusStripConnection);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBoxItems);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxItems.ResumeLayout(false);
            this.groupBoxItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStripConnection.ResumeLayout(false);
            this.statusStripConnection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxItems;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label abel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripConnection;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripRetryImage;
        private System.Windows.Forms.ToolStripMenuItem retryToolStripMenuItem;
        private System.Windows.Forms.ListView itemListView;
        private System.Windows.Forms.ImageList imageListLarge;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.ComboBox publisherComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label labelChooseItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusDetails;
        private System.Windows.Forms.Label label1;
    }
}

