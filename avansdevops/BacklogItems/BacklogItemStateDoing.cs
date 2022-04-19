using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.BacklogItems
{
    internal class BacklogItemStateDoing : IBacklogItemState
    {
        private BacklogItem _backlogItem;

        public BacklogItemStateDoing(BacklogItem backlogItem)
        {
            this._backlogItem = backlogItem;
        }
    }
}
