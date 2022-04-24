using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using avansdevops.BacklogItems;

namespace avansdevops
{
    public class ProductBacklog
    {
        private List<BacklogItem> _backlogItems;

        public ProductBacklog()
        {
            _backlogItems = new List<BacklogItem>();
        }

        public List<BacklogItem> BacklogItems
        {
            get { return _backlogItems; }
            set { }
        }

        public List<BacklogItem> AddBacklogItem(BacklogItem backlogItem)
        {
            _backlogItems.Add(backlogItem);
            return _backlogItems;
        }

        public void RemoveBacklogItem(BacklogItem backlogItem)
        {
            _backlogItems.Remove(backlogItem);
        }
        
    }
}
