using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.BacklogItems
{
    public class BacklogItemStateTesting : IBacklogItemState
    {
        private BacklogItem _backlogItem;

        public BacklogItemStateTesting(BacklogItem backlogItem)
        {
            this._backlogItem = backlogItem;
        }
    }
}
