using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops
{
    internal class ForumPost
    {
        private static int _id;
        private string _content;
        private int _forumThreadId;
        private int? _userId;

        public ForumPost(int forumThreadId, string content, int userId)
        {
            _content = content;
            _forumThreadId = forumThreadId;
            _userId = userId;

            _id = new Random().Next();

        }
    }
}
