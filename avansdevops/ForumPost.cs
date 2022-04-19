using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops
{
    public class ForumPost
    {
        private int _id;
        private string _content;
        private int _forumThreadId;
        private int? _userId;

        public ForumPost(string content, int userId)
        {
            _content = content;
            _userId = userId;

            _id = new Random().Next();

        }
    }
}
