using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.BacklogItem
{
	public class BacklogItemStateDone : IBacklogItemState
	{
		private BacklogItemStateDone _backlogItem;

		public BacklogItemStateDone(BacklogItem backlogItem)
		{
			this._backlogItem = backlogItem;
		}
	}
}


