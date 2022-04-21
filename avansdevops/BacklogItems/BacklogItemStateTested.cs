using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.BacklogItems
{
    public class BacklogItemStateTested : IBacklogItemState
    {
        private BacklogItem _backlogItem;

        public BacklogItemStateTested(BacklogItem backlogItem)
        {
            this._backlogItem = backlogItem; 
        }
    }
}
