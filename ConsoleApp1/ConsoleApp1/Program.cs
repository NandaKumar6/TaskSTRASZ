using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestletOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Testlet
    {
        public string TestletId;
        private List<Item> Items;
        public Testlet(string testletId, List<Item> items)
        {
            TestletId = testletId;
            Items = items;
        }
        public List<Item> Randomize()
        {
            try
            {
                if (Items == null)
                    throw new ArgumentNullException("Items", "Testlet items can't be null");

                if (Items.Count() > 10)
                    throw new Exception("Testlet items are more than 10");

                if (Items.Count() < 10)
                    throw new Exception("Testlet itemsare less than 10");


                //fixed set of 10 items. 6 of the items are operational and 4 of them are pretest items
                //The first 2 items are always pretest items selected randomly from the 4 pretest items.            

                List<Item> preTestItems = Items.Where(x => x.ItemType == ItemTypeEnum.Pretest).Take(2).ToList();

                //The next 8 items are mix of pretest and operational items ordered randomly from the remaining 8 items

                preTestItems.AddRange(Items.Where(x => !preTestItems.Select(y => y.ItemId).Contains(x.ItemId)));
                return preTestItems;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    public class Item
    {
        public string ItemId;
        public ItemTypeEnum ItemType;
    }
    public enum ItemTypeEnum
    {
        Pretest = 0,
        Operational = 1
    }

}
