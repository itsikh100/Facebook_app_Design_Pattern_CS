using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace C19_Ex01_Itsik_201016151_Zahi_204185490
{
    public class NewFeedsIterator : IEnumerable
    {
        public List<Post> NewsFeedPosts { get; private set; }

        public NewFeedsIterator(List<Post> i_PostList)
        {
            NewsFeedPosts = i_PostList;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Post post in NewsFeedPosts)
            {
                string retPostData;

                if (post.Message != null)
                {
                    retPostData = post.Message;
                }
                else if (post.Caption != null)
                {
                    retPostData = post.Caption;
                }
                else
                {
                    try
                    {
                        retPostData = string.Format("[{0}]", post.Type);
                    }
                    catch (Exception)
                    {
                        retPostData = "[N/A]";
                    }
                }

                yield return retPostData;
            }
        }
    }
}
