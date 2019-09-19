namespace C19_Ex01_Itsik_201016151_Zahi_204185490
{
    public partial class Form1
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
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LoginBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
            this.AlbumsListLabel = new System.Windows.Forms.Label();
            this.AlbumsListBox = new System.Windows.Forms.ListBox();
            this.flowLayoutPanelPicturs = new System.Windows.Forms.FlowLayoutPanel();
            this.panelFriendData = new System.Windows.Forms.Panel();
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailLabel1 = new System.Windows.Forms.Label();
            this.firstNameLabel1 = new System.Windows.Forms.Label();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.lastNameLabel1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelFriendsList = new System.Windows.Forms.Label();
            this.userBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.userBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.labelOptionalForRelatioship = new System.Windows.Forms.Label();
            this.listBoxOptionalForRelationship = new System.Windows.Forms.ListBox();
            this.buttonGoogleFriend = new System.Windows.Forms.Button();
            this.webBrowserGoogleFriend = new System.Windows.Forms.WebBrowser();
            this.labelFeeds = new System.Windows.Forms.Label();
            this.listBoxFeeds = new System.Windows.Forms.ListBox();
            emailLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelFriendData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingNavigator)).BeginInit();
            this.userBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(22, 121);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(127, 32);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(80, 17);
            firstNameLabel.TabIndex = 4;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(127, 3);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(80, 17);
            lastNameLabel.TabIndex = 8;
            lastNameLabel.Text = "Last Name:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(127, 61);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(75, 17);
            nameLabel.TabIndex = 10;
            nameLabel.Text = "Full Name:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(22, 98);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(64, 17);
            birthdayLabel.TabIndex = 0;
            birthdayLabel.Text = "Birthday:";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LoginBtn.Location = new System.Drawing.Point(1127, 41);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(146, 31);
            this.LoginBtn.TabIndex = 0;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LogoutBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogoutBtn.Location = new System.Drawing.Point(1164, 730);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(120, 42);
            this.LogoutBtn.TabIndex = 1;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Visible = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click_);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 117);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // checkBoxRememberUser
            // 
            this.checkBoxRememberUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxRememberUser.AutoSize = true;
            this.checkBoxRememberUser.Location = new System.Drawing.Point(1136, 78);
            this.checkBoxRememberUser.Name = "checkBoxRememberUser";
            this.checkBoxRememberUser.Size = new System.Drawing.Size(122, 21);
            this.checkBoxRememberUser.TabIndex = 4;
            this.checkBoxRememberUser.Text = "Remember Me";
            this.checkBoxRememberUser.UseVisualStyleBackColor = true;
            // 
            // AlbumsListLabel
            // 
            this.AlbumsListLabel.AutoSize = true;
            this.AlbumsListLabel.Font = new System.Drawing.Font("Oswald", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumsListLabel.Location = new System.Drawing.Point(12, 150);
            this.AlbumsListLabel.Name = "AlbumsListLabel";
            this.AlbumsListLabel.Size = new System.Drawing.Size(104, 25);
            this.AlbumsListLabel.TabIndex = 6;
            this.AlbumsListLabel.Text = "Albums List:";
            this.AlbumsListLabel.Visible = false;
            // 
            // AlbumsListBox
            // 
            this.AlbumsListBox.FormattingEnabled = true;
            this.AlbumsListBox.ItemHeight = 16;
            this.AlbumsListBox.Location = new System.Drawing.Point(12, 179);
            this.AlbumsListBox.Name = "AlbumsListBox";
            this.AlbumsListBox.Size = new System.Drawing.Size(183, 196);
            this.AlbumsListBox.TabIndex = 7;
            this.AlbumsListBox.Visible = false;
            this.AlbumsListBox.SelectedIndexChanged += new System.EventHandler(this.AlbumsListBox_SelectedIndexChanged);
            // 
            // flowLayoutPanelPicturs
            // 
            this.flowLayoutPanelPicturs.AutoScroll = true;
            this.flowLayoutPanelPicturs.Location = new System.Drawing.Point(12, 381);
            this.flowLayoutPanelPicturs.Name = "flowLayoutPanelPicturs";
            this.flowLayoutPanelPicturs.Size = new System.Drawing.Size(453, 355);
            this.flowLayoutPanelPicturs.TabIndex = 9;
            this.flowLayoutPanelPicturs.Visible = false;
            // 
            // panelFriendData
            // 
            this.panelFriendData.Controls.Add(birthdayLabel);
            this.panelFriendData.Controls.Add(this.birthdayLabel1);
            this.panelFriendData.Controls.Add(emailLabel);
            this.panelFriendData.Controls.Add(this.emailLabel1);
            this.panelFriendData.Controls.Add(firstNameLabel);
            this.panelFriendData.Controls.Add(this.firstNameLabel1);
            this.panelFriendData.Controls.Add(this.imageNormalPictureBox);
            this.panelFriendData.Controls.Add(lastNameLabel);
            this.panelFriendData.Controls.Add(this.lastNameLabel1);
            this.panelFriendData.Controls.Add(nameLabel);
            this.panelFriendData.Controls.Add(this.nameLabel1);
            this.panelFriendData.Location = new System.Drawing.Point(471, 381);
            this.panelFriendData.Name = "panelFriendData";
            this.panelFriendData.Size = new System.Drawing.Size(355, 195);
            this.panelFriendData.TabIndex = 10;
            this.panelFriendData.Visible = false;
            // 
            // birthdayLabel1
            // 
            this.birthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "BirthDay", true));
            this.birthdayLabel1.Location = new System.Drawing.Point(127, 98);
            this.birthdayLabel1.Name = "birthdayLabel1";
            this.birthdayLabel1.Size = new System.Drawing.Size(100, 23);
            this.birthdayLabel1.TabIndex = 1;
            this.birthdayLabel1.Text = "label1";
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // emailLabel1
            // 
            this.emailLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Email", true));
            this.emailLabel1.Location = new System.Drawing.Point(127, 121);
            this.emailLabel1.Name = "emailLabel1";
            this.emailLabel1.Size = new System.Drawing.Size(100, 23);
            this.emailLabel1.TabIndex = 3;
            this.emailLabel1.Text = "label1";
            // 
            // firstNameLabel1
            // 
            this.firstNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "FirstName", true));
            this.firstNameLabel1.Location = new System.Drawing.Point(232, 32);
            this.firstNameLabel1.Name = "firstNameLabel1";
            this.firstNameLabel1.Size = new System.Drawing.Size(100, 23);
            this.firstNameLabel1.TabIndex = 5;
            this.firstNameLabel1.Text = "label1";
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(3, 3);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(103, 92);
            this.imageNormalPictureBox.TabIndex = 7;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // lastNameLabel1
            // 
            this.lastNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "LastName", true));
            this.lastNameLabel1.Location = new System.Drawing.Point(232, 3);
            this.lastNameLabel1.Name = "lastNameLabel1";
            this.lastNameLabel1.Size = new System.Drawing.Size(100, 23);
            this.lastNameLabel1.TabIndex = 9;
            this.lastNameLabel1.Text = "label1";
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(232, 61);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameLabel1.TabIndex = 11;
            this.nameLabel1.Text = "label1";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // labelFriendsList
            // 
            this.labelFriendsList.AutoSize = true;
            this.labelFriendsList.Font = new System.Drawing.Font("Oswald", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelFriendsList.Location = new System.Drawing.Point(466, 150);
            this.labelFriendsList.Name = "labelFriendsList";
            this.labelFriendsList.Size = new System.Drawing.Size(105, 25);
            this.labelFriendsList.TabIndex = 11;
            this.labelFriendsList.Text = "Friends List:";
            this.labelFriendsList.Visible = false;
            // 
            // userBindingNavigator
            // 
            this.userBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.userBindingNavigator.BindingSource = this.userBindingSource;
            this.userBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.userBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.userBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.userBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.userBindingNavigatorSaveItem});
            this.userBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.userBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.userBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.userBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.userBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.userBindingNavigator.Name = "userBindingNavigator";
            this.userBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.userBindingNavigator.Size = new System.Drawing.Size(1296, 27);
            this.userBindingNavigator.TabIndex = 12;
            this.userBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // userBindingNavigatorSaveItem
            // 
            this.userBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userBindingNavigatorSaveItem.Enabled = false;
            this.userBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("userBindingNavigatorSaveItem.Image")));
            this.userBindingNavigatorSaveItem.Name = "userBindingNavigatorSaveItem";
            this.userBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.userBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.DataSource = this.eventBindingSource;
            this.listBoxFriends.DisplayMember = "Name";
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(471, 179);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(183, 196);
            this.listBoxFriends.TabIndex = 13;
            this.listBoxFriends.Visible = false;
            // 
            // labelOptionalForRelatioship
            // 
            this.labelOptionalForRelatioship.AutoSize = true;
            this.labelOptionalForRelatioship.Font = new System.Drawing.Font("Oswald", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelOptionalForRelatioship.Location = new System.Drawing.Point(831, 150);
            this.labelOptionalForRelatioship.Name = "labelOptionalForRelatioship";
            this.labelOptionalForRelatioship.Size = new System.Drawing.Size(431, 25);
            this.labelOptionalForRelatioship.TabIndex = 14;
            this.labelOptionalForRelatioship.Text = "Online and Optional friends for relationship just for me:";
            this.labelOptionalForRelatioship.Visible = false;
            // 
            // listBoxOptionalForRelationship
            // 
            this.listBoxOptionalForRelationship.FormattingEnabled = true;
            this.listBoxOptionalForRelationship.ItemHeight = 16;
            this.listBoxOptionalForRelationship.Location = new System.Drawing.Point(836, 179);
            this.listBoxOptionalForRelationship.Name = "listBoxOptionalForRelationship";
            this.listBoxOptionalForRelationship.Size = new System.Drawing.Size(180, 196);
            this.listBoxOptionalForRelationship.TabIndex = 15;
            this.listBoxOptionalForRelationship.Visible = false;
            // 
            // buttonGoogleFriend
            // 
            this.buttonGoogleFriend.Location = new System.Drawing.Point(832, 381);
            this.buttonGoogleFriend.Name = "buttonGoogleFriend";
            this.buttonGoogleFriend.Size = new System.Drawing.Size(267, 53);
            this.buttonGoogleFriend.TabIndex = 16;
            this.buttonGoogleFriend.Text = "Google selected Friend:";
            this.buttonGoogleFriend.UseVisualStyleBackColor = true;
            this.buttonGoogleFriend.Visible = false;
            this.buttonGoogleFriend.Click += new System.EventHandler(this.buttonGoogleFriend_Click);
            // 
            // webBrowserGoogleFriend
            // 
            this.webBrowserGoogleFriend.Location = new System.Drawing.Point(836, 442);
            this.webBrowserGoogleFriend.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserGoogleFriend.Name = "webBrowserGoogleFriend";
            this.webBrowserGoogleFriend.Size = new System.Drawing.Size(426, 283);
            this.webBrowserGoogleFriend.TabIndex = 17;
            this.webBrowserGoogleFriend.Visible = false;
            // 
            // labelFeeds
            // 
            this.labelFeeds.AutoSize = true;
            this.labelFeeds.Font = new System.Drawing.Font("Oswald", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelFeeds.Location = new System.Drawing.Point(472, 588);
            this.labelFeeds.Name = "labelFeeds";
            this.labelFeeds.Size = new System.Drawing.Size(61, 25);
            this.labelFeeds.TabIndex = 18;
            this.labelFeeds.Text = "Feeds:";
            this.labelFeeds.Visible = false;
            // 
            // listBoxFeeds
            // 
            this.listBoxFeeds.DisplayMember = "Name";
            this.listBoxFeeds.FormattingEnabled = true;
            this.listBoxFeeds.ItemHeight = 16;
            this.listBoxFeeds.Location = new System.Drawing.Point(474, 616);
            this.listBoxFeeds.Name = "listBoxFeeds";
            this.listBoxFeeds.Size = new System.Drawing.Size(356, 148);
            this.listBoxFeeds.TabIndex = 19;
            this.listBoxFeeds.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1296, 784);
            this.Controls.Add(this.listBoxFeeds);
            this.Controls.Add(this.labelFeeds);
            this.Controls.Add(this.webBrowserGoogleFriend);
            this.Controls.Add(this.buttonGoogleFriend);
            this.Controls.Add(this.listBoxOptionalForRelationship);
            this.Controls.Add(this.labelOptionalForRelatioship);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.userBindingNavigator);
            this.Controls.Add(this.labelFriendsList);
            this.Controls.Add(this.panelFriendData);
            this.Controls.Add(this.flowLayoutPanelPicturs);
            this.Controls.Add(this.AlbumsListBox);
            this.Controls.Add(this.AlbumsListLabel);
            this.Controls.Add(this.checkBoxRememberUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.LoginBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelFriendData.ResumeLayout(false);
            this.panelFriendData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingNavigator)).EndInit();
            this.userBindingNavigator.ResumeLayout(false);
            this.userBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxRememberUser;
        private System.Windows.Forms.Label AlbumsListLabel;
        private System.Windows.Forms.ListBox AlbumsListBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPicturs;
        private System.Windows.Forms.Panel panelFriendData;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label labelFriendsList;
        private System.Windows.Forms.BindingNavigator userBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton userBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Label emailLabel1;
        private System.Windows.Forms.Label firstNameLabel1;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.Label lastNameLabel1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label birthdayLabel1;
        private System.Windows.Forms.Label labelOptionalForRelatioship;
        private System.Windows.Forms.ListBox listBoxOptionalForRelationship;
        private System.Windows.Forms.Button buttonGoogleFriend;
        private System.Windows.Forms.WebBrowser webBrowserGoogleFriend;
        private System.Windows.Forms.Label labelFeeds;
        private System.Windows.Forms.ListBox listBoxFeeds;
    }
}