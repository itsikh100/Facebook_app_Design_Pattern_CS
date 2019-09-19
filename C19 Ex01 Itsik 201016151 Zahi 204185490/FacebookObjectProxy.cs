using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace C19_Ex01_Itsik_201016151_Zahi_204185490
{
    public class FacebookObjectProxy
    {
        private User m_LoggedInUser; 

        public FacebookObjectProxy(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
        }

        private int userComparerByUserName(User i_FacebookUser1, User i_FacebookUser2)
        {
            return i_FacebookUser1.Name.CompareTo(i_FacebookUser2.Name);
        }

        private int userComparerByAlbumName(Album i_FacebookAlbum1, Album i_FacebookAlbum2)
        {
            return i_FacebookAlbum1.Name.CompareTo(i_FacebookAlbum2.Name);
        }

        public Album[] GetAlbumsList()
        {
            List<Album> tempList = FacebookListGenerator<Album>.GenerateList(() => m_LoggedInUser.Albums);

            tempList.Sort(new Comparison<Album>(userComparerByAlbumName));
            Album[] returnFriendsList = tempList.ToArray();

            return returnFriendsList;
        }

        public List<Post> GetPostList()
        {
            List<Post> tempList = FacebookListGenerator<Post>.GenerateList(() => m_LoggedInUser.NewsFeed);
            return tempList;
        }

        public User[] GetFriends()
        {
            List<User> tempList = FacebookListGenerator<User>.GenerateList(() => m_LoggedInUser.Friends);

            tempList.Sort(new Comparison<User>(userComparerByUserName));
            User[] returnFriendsList = tempList.ToArray();

            return returnFriendsList;           
        }

        public Photo[] GetPhotosFromAlbum(Album i_SelectedAlbum)
        {
            int index = 0;
            Photo[] returnPhotos = new Photo[i_SelectedAlbum.Photos.Count];
            foreach (Photo photo in i_SelectedAlbum.Photos)
            {
                returnPhotos[index++] = photo;
            }
            
            return returnPhotos;
        }
    }
}
