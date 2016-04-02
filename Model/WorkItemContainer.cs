using ProductivityParty.Misc.Date;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityParty.Model
{
    public class WorkItemContainer
    {
        public List<WorkItem> workItems = new List<WorkItem>();
        public DateHandler date = new DateHandler();
        public int num = 5;
    }
}
