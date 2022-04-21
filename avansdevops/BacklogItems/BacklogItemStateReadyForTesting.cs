using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.BacklogItems
{
    public class BacklogItemStateReadyForTesting : IBacklogItemState
    {
        private BacklogItem _backlogItem;

        public BacklogItemStateReadyForTesting(BacklogItem backlogItem)
        {
            this._backlogItem = backlogItem;
        }
    }
}
