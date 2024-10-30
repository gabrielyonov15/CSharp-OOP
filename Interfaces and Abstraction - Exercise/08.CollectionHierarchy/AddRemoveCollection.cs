using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CollectionHierarchy
{
    public class AddRemoveCollection : IAddRemoveCollection
    {
        private List<string> items;
        public AddRemoveCollection()
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
            string removedItem = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return removedItem;
        }
    }
}