using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace C19_Ex01_Itsik_201016151_Zahi_204185490
{
    public class FindRelationshipLogic
    {
        private User m_LoggedInUser;
        private User[] m_OptionalFriendsForRelationList;

        public FindRelationshipLogic(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
        }

        public User[] FindOptionalFriendsForRelationship()
        {
            m_OptionalFriendsForRelationList = new User[m_LoggedInUser.Friends.Count];
            User.eGender? myGender = m_LoggedInUser.Gender;
            int index = 0;

            foreach (User friend in m_LoggedInUser.Friends)
            {
                if (!friend.Gender.Equals(myGender) && friend.OnlineStatus.Equals(User.eOnlineStatus.active))
                {
                    if (friend.RelationshipStatus.Equals(User.eRelationshipStatus.Single) ||
                            friend.RelationshipStatus.Equals(User.eRelationshipStatus.Separated) ||
                            friend.RelationshipStatus.Equals(User.eRelationshipStatus.InAnOpenRelationship) ||
                            friend.RelationshipStatus.Equals(User.eRelationshipStatus.Divorced))
                    {
                        m_OptionalFriendsForRelationList[index] = friend;
                        index++;
                    }
                }
            }

            return m_OptionalFriendsForRelationList;
        }

        public bool IsNotEmpty()
        {
            return !m_OptionalFriendsForRelationList.Length.Equals(0) &&
                m_OptionalFriendsForRelationList[0] != null;
        }
    }
}
