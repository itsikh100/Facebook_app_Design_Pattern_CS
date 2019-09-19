using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C19_Ex01_Itsik_201016151_Zahi_204185490
{
    public class FacebookManager
    {
        private static FacebookManager s_Instance = null;
        private static Object s_LockObject = new object();
        private User m_LoggedInUser;
        private AppSettings m_AppSettings;
        private LoginResult m_LoginResult;

        private FacebookManager()
        {
            m_AppSettings = AppSettings.LoadFromFile();
        }

        public static FacebookManager Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_LockObject)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new FacebookManager();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public void Login()
        {
            m_LoginResult = FacebookService.Login(
            "385686298750430",
                "public_profile",
                "email",
                "publish_to_groups",
                "user_birthday",
                "user_age_range",
                "user_gender",
                "user_link",
                "user_tagged_places",
                "user_videos",
                "publish_to_groups",
                "groups_access_member_info",
                "user_friends",
                "user_events",
                "user_likes",
                "user_location",
                "user_photos",
                "user_posts",
                "user_hometown");
            m_AppSettings.LastAccessToken = m_LoginResult.AccessToken;
            m_LoggedInUser = m_LoginResult.LoggedInUser;         
        }

        public Size GetLastWindowSize()
        {
            return m_AppSettings.LastWindowSize;
        }

        public void SetLastSize(Size i_LastSize)
        {
            m_AppSettings.LastWindowSize = i_LastSize;
        }

        public Point GetLastWindowLocation()
        {
            return m_AppSettings.LastWindowLocation;
        }

        public void SetLastLocation(Point i_Location)
        {
            m_AppSettings.LastWindowLocation = i_Location;
        }

        public bool GetRememberUser()
        {
            return m_AppSettings.RememberUser;
        }

        public void SetLastRememberUser(bool i_RememberUser)
        {
            m_AppSettings.RememberUser = i_RememberUser;
        }

        public string GetProfilePicture()
        {
            return m_LoggedInUser.PictureNormalURL;
        }

        public void SetLoggedinUser()
        {
            m_LoggedInUser = m_LoginResult.LoggedInUser;
        }

        public string GetProfileName()
        {
            return m_LoggedInUser.Name;
        }

        public Album[] GetAlbumsList()
        {
            return new FacebookObjectProxy(m_LoggedInUser).GetAlbumsList();          
        }

        public List<Post> GetPostList()
        {
            return new FacebookObjectProxy(m_LoggedInUser).GetPostList();
        }

        public Photo[] GetPhotosFromAlbum(Album i_SelectedAlbum)
        {
            return new FacebookObjectProxy(m_LoggedInUser).GetPhotosFromAlbum(i_SelectedAlbum);          
        }

        public User[] GetFriendsList()
        {
            return new FacebookObjectProxy(m_LoggedInUser).GetFriends();          
        }

        public bool IsFriendsListEmpty()
        {
            return m_LoggedInUser.Friends.Count != 0 ? false : true;
        }

        public string GetLastAccessToken()
        {
            return m_AppSettings.LastAccessToken;
        }

        public void Connect()
        {
            m_LoginResult = FacebookService.Connect(m_AppSettings.LastAccessToken);
        }

        public void SetLastToken()
        {
            m_AppSettings.LastAccessToken = m_LoginResult.AccessToken;
        }

        public void SetLastTokenToNull()
        {
            m_AppSettings.LastAccessToken = null;
        }

        public void SaveToFile()
        {
            m_AppSettings.SaveToFile();
        }

        public FindRelationshipLogic FacadeRelationship()
        {
            FindRelationshipLogic findRelationshipLogic = new FindRelationshipLogic(m_LoggedInUser);
            return findRelationshipLogic;
        }
    }
}
