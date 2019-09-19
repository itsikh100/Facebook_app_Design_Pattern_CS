using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C19_Ex01_Itsik_201016151_Zahi_204185490
{
    public partial class Form1 : Form
    {
        private Control[] m_ControlsToChangeVisibility;
        private FacebookManager m_facebookManager;
        private LogoutObserver m_Observable;

        public Form1()
        {
            InitializeComponent();

            m_facebookManager = FacebookManager.Instance;

            m_ControlsToChangeVisibility = new Control[] 
            {LogoutBtn, pictureBox1, AlbumsListBox, AlbumsListLabel,
              labelFriendsList, listBoxFriends, labelOptionalForRelatioship,
              listBoxOptionalForRelationship, buttonGoogleFriend, labelFeeds, listBoxFeeds};

            initializeLogion();

            m_Observable = new LogoutObserver();
            m_Observable.BtnLogoutClicked += LoggedoutMessege;
        }

        private void initializeLogion()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Size = m_facebookManager.GetLastWindowSize();
            this.Location = m_facebookManager.GetLastWindowLocation();
            this.checkBoxRememberUser.Checked = m_facebookManager.GetRememberUser();          
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {         
            m_facebookManager.Login();            
            loggedIn();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (m_facebookManager.GetRememberUser()
               && !string.IsNullOrEmpty(m_facebookManager.GetLastAccessToken()))
            {
                m_facebookManager.Connect();
                new Thread(loggedIn).Start();
            }
        }

        private void loggedIn()
        {           
            m_facebookManager.SetLoggedinUser();
            LoginBtn.Invoke(new Action(() => LoginBtn.Enabled = false));
            changeComponentVisabilty(m_ControlsToChangeVisibility);
            pictureBox1.LoadAsync(m_facebookManager.GetProfilePicture());
            LoginBtn.Invoke(new Action(() => LoginBtn.Text = string.Format(
                    "Hello, {0}.",
                    m_facebookManager.GetProfileName())));
            new Thread(initAlbumsListBox).Start();
            new Thread(initFriendsListBox).Start();
            new Thread(initOptionalFriendsForRelationshipListBox).Start();
            new Thread(initFeedsListBox).Start();
        }

        private void initAlbumsListBox()
        {
            AlbumsListBox.Invoke(new Action(() => AlbumsListBox.DisplayMember = "Name"));
            Album[] albumList = m_facebookManager.GetAlbumsList();
            AlbumsListBox.Invoke(new Action(() => AlbumsListBox.DataSource = albumList));
        }

        private void initOptionalFriendsForRelationshipListBox()
        {
            listBoxOptionalForRelationship.Invoke(new Action(() => listBoxOptionalForRelationship.Items.Clear()));
            listBoxOptionalForRelationship.Invoke(new Action(() => listBoxOptionalForRelationship.DisplayMember = "Name"));
            FindRelationshipLogic findRelationshipLogic = m_facebookManager.FacadeRelationship();
            User[] optionalFriendsForRelationList = findRelationshipLogic.FindOptionalFriendsForRelationship();

            if (findRelationshipLogic.IsNotEmpty())
            {
                foreach (User friend in optionalFriendsForRelationList)
                {
                    listBoxOptionalForRelationship.Invoke(new Action(() => listBoxOptionalForRelationship.Items.Add(friend)));
                }
            }
        }

        private void initFriendsListBox()
        {
            listBoxFriends.Invoke(new Action(() => eventBindingSource.DataSource = m_facebookManager.GetFriendsList()));
            if (!m_facebookManager.IsFriendsListEmpty())
            {
                panelFriendData.Invoke(new Action(() => this.panelFriendData.Visible = true));
            }
        }

        private void initFeedsListBox()
        {
            var newsCollection = m_facebookManager.GetPostList();
            listBoxFeeds.Invoke(new Action(() => listBoxFeeds.DisplayMember = "Message"));
            listBoxFeeds.Invoke(new Action(() => listBoxFeeds.Items.Clear()));
           
            foreach (var item in newsCollection)
            {
                listBoxFeeds.Invoke(new Action(() => listBoxFeeds.Items.Add(item)));
            }         
        }

        private void LoggedoutMessege(object sender, EventArgs args)
        {
            MessageBox.Show("You are Logged out");
        }
           
        private void LogoutBtn_Click_(object sender, EventArgs e)
        {
            changeComponentVisabilty(m_ControlsToChangeVisibility);
            Control[] extraControls = new Control[] { panelFriendData, flowLayoutPanelPicturs };
            changeComponentVisabilty(extraControls);
            if(webBrowserGoogleFriend.Visible == true)
            {
                webBrowserGoogleFriend.Visible = false;
            }

            LoginBtn.Invoke(new Action(() => LoginBtn.Enabled = true));
            LoginBtn.Invoke(new Action(() => LoginBtn.Text = "Login"));
            FacebookService.Logout(m_Observable.NotifyAll);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            m_facebookManager.SetLastLocation(this.Location);
            m_facebookManager.SetLastSize(this.Size);
            m_facebookManager.SetLastRememberUser(this.checkBoxRememberUser.Checked);
            if (m_facebookManager.GetRememberUser())
            {
                m_facebookManager.SetLastToken();
            }
            else
            {
                m_facebookManager.SetLastTokenToNull();
            }

            m_facebookManager.SaveToFile();
        }

        private void AlbumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (AlbumsListBox.SelectedItems.Count == 1)
           {
               flowLayoutPanelPicturs.Controls.Clear();
               Album selectedAlbum = AlbumsListBox.SelectedItem as Album;
               if (selectedAlbum.Count != 0)
               {                 
                   flowLayoutPanelPicturs.Visible = true;
                   Photo[] photos = m_facebookManager.GetPhotosFromAlbum(selectedAlbum);
                   foreach (Photo photo in photos)
                   {                     
                        flowLayoutPanelPicturs.Controls.Add(createPictureBoxInPanel(photo));
                   }                          
               }
               else
               {
                    flowLayoutPanelPicturs.Visible = true;                  
               }
           }
        }

        private PictureBox createPictureBoxInPanel(Photo i_Photo)
        {
            PictureBox pic = new PictureBox();
            pic.Width = 100;
            pic.Height = 92;
            pic.LoadAsync(i_Photo.PictureAlbumURL);
          
            return pic;
        }

        private void changeComponentVisabilty(Control[] i_Controls)
        {
            foreach (Control control in i_Controls)
            {
                control.Invoke(new Action(() => control.Visible = !control.Visible));
            }
        }

        private void buttonGoogleFriend_Click(object sender, EventArgs e)
        {
            webBrowserGoogleFriend.Invoke(new Action(() => webBrowserGoogleFriend.Visible = true));
            User selectedFriend = listBoxFriends.SelectedItem as User;
            string friendNameToGoogle = string.Format("http://www.google.com/search?q={0}+{1}",
                selectedFriend.FirstName,
                selectedFriend.LastName);

            webBrowserGoogleFriend.Navigate(friendNameToGoogle);
        }
    }
}