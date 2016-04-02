using LiteDB;
using ProductivityParty.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityParty.Misc.DBInteraction
{
    public class Database
    {

        LiteDatabase db = new LiteDatabase(Global.dbLoc);

        public void Test()
        {
            //var col = db.GetCollection<WorkItem>("work_items");

            //WorkItem wi = new WorkItem()
            //{
            //    Notes = "Peepee",
            //    Task = "Do the thing",
            //    date = "4/1/2016"
            //};

            //WorkItem wi2 = new WorkItem()
            //{
            //    Notes = "Mamamia",
            //    Task = "Papapia",
            //    date = "4/1/2016"
            //};

            //col.Insert(wi);
            //col.Insert(wi2);

            //var results = col.Find(x => x.date == "4/1/2016");
        }

        class simpleObject
        {
            public int what = 5;
        }

        public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string[] Phones { get; set; }
            public bool IsActive { get; set; }
        }

        internal object GetCollection<T>(string v)
        {
            throw new NotImplementedException();
        }

        public void Test2()
        {
            // Open database (or create if doesn't exist)
            using (var db = new LiteDatabase(Global.dbLoc))
            {
                // Get customer collection
                var col = db.GetCollection<WorkItemContainer>("customers");

                // Create your new customer instance
                var customer = new WorkItemContainer
                {
                    date = new Date.DateHandler(),
                    workItems = new List<WorkItem>()
                };

                // Insert new customer document (Id will be auto-incremented)
                col.Insert(customer);

                // Use Linq to query documents
                var results = col.Find(x => x.num == 5);
            }
        }

        public List<WorkItem> GetWorkItemsForDay(String date)
        {
            List<WorkItem> toReturn = new List<WorkItem>();

            // Open database (or create if doesn't exist)
            using (var db = new LiteDatabase(Global.dbLoc))
            {
                var cur = db.GetCollection<WorkItem>(Global.WorkItemsContainerTable);

                var test = cur.FindAll();
                var results = cur.Find(x => x.date.Equals(date));
                toReturn = results.ToList();
            }

            return toReturn;
        }

        public void SaveWorkItem(WorkItem toSave)
        {
            using (var db = new LiteDatabase(Global.dbLoc))
            {
                var cur = db.GetCollection<WorkItem>(Global.WorkItemsContainerTable);

                try
                {
                    bool up = cur.Update(toSave);
                    if(!up)
                    {
                        cur.Insert(toSave);
                    }
                }
                catch (Exception ex)
                {
                    cur.Insert(toSave);
                }

                cur.EnsureIndex(x => x.date);
            }
        }

    }
}
