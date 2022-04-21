using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using avansdevops.BacklogItems;

namespace avansdevops
{
    public class ForumThread
    {
        private List<ForumPost> _posts;
        private BacklogItem _backlogItem;
        private string _title;

        public ForumThread(string title, BacklogItem backlogItem)
        {
            _title = title;
            _backlogItem = backlogItem;

            _posts = new List<ForumPost>();
        }

        public void AddPost(ForumPost post)
        {
            if (post != null)
            {
                _posts.Add(post);
            }
        }
    }
}
