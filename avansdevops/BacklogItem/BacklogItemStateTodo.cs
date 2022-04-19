using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.BacklogItem
{
    internal class BacklogItemStateTodo : IBacklogItemState
    {
        private BacklogItem _backlogItem;

        public BacklogItemStateTodo(BacklogItem backlogItem)
        {
            _backlogItem = backlogItem;
        }

    }
}
