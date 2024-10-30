using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CollectionHierarchy
{
    public class MyList : IMyList
    {
        private List<string> items;
        public MyList()
        {
            items = new List<string>();
        }
        public int Add(string item)
        {
            items.Insert(0, item);
            return 0; 
        }
        public string Remove()
        {
            string removedItem = items[0];
            items.RemoveAt(0); 
            return removedItem;
        }
        public int Used => items.Count; 
    }
}