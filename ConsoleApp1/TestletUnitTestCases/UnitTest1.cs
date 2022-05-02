using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestletOne;
using System.Collections.Generic;


namespace TestletUnitTestCases
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void First_2_Items_Pretest()
        {
            List<Item> ItemCollcetions = new List<Item>
            {
                new Item { ItemId = "1", ItemType= ItemTypeEnum.Pretest },
                new Item { ItemId = "2", ItemType= ItemTypeEnum.Operational },
                new Item { ItemId = "3", ItemType= ItemTypeEnum.Pretest },
                new Item { ItemId = "4", ItemType= ItemTypeEnum.Operational },
                new Item { ItemId = "5", ItemType= ItemTypeEnum.Pretest },
                new Item { ItemId = "6", ItemType= ItemTypeEnum.Operational },
                new Item { ItemId = "7", ItemType= ItemTypeEnum.Pretest },
                new Item { ItemId = "8", ItemType= ItemTypeEnum.Operational },
                new Item { ItemId = "9", ItemType= ItemTypeEnum.Operational },
                new Item { ItemId = "10", ItemType= ItemTypeEnum.Operational },
            };
            Testlet test = new Testlet("one", ItemCollcetions);
            int count = 0;
            test.Randomize().GetRange(0, 2).ForEach(x => { if (x.ItemType == ItemTypeEnum.Pretest) { count++; } });
            Assert.AreEqual(2, count, "First 2 element are Pretest ");
        }

        [TestMethod]
        public void Last_8__Has_2_Pretest_Items()
        {
            List<Item> ItemCollcetions = new List<Item>
            {
                new Item { ItemId = "1", ItemType= ItemTypeEnum.Pretest },
                new Item { ItemId = "2", ItemType= ItemTypeEnum.Operational },
                new Item { ItemId = "3", ItemType= ItemTypeEnum.Pretest },
                new Item { ItemId = "4", ItemType= ItemTypeEnum.Operational },
                new Item { ItemId = "5", ItemType= ItemTypeEnum.Pretest },
                new Item { ItemId = "6", ItemType= ItemTypeEnum.Operational },
                new Item { ItemId = "7", ItemType= ItemTypeEnum.Pretest },
                new Item { ItemId = "8", ItemType= ItemTypeEnum.Operational },
                new Item { ItemId = "9", ItemType= ItemTypeEnum.Operational },
                new Item { ItemId = "10", ItemType= ItemTypeEnum.Operational },
            };
            Testlet test = new Testlet("one", ItemCollcetions);
            int count = 0;
            test.Randomize().GetRange(2, 8).ForEach(x => { if (x.ItemType == ItemTypeEnum.Pretest) { count++; } });
            Assert.AreEqual(2, count, "Last  8 elements has 2 pre test ");
        }


        [TestMethod]
        public void Last_8__Has_6_Operational_Items()
        {
            List<Item> ItemCollcetions = new List<Item>
            {
                new Item { ItemId = "1", ItemType= ItemTypeEnum.Pretest },
                new Item { ItemId = "2", ItemType= ItemTypeEnum.Operational },
                new Item { ItemId = "3", ItemType= ItemTypeEnum.Pretest },
                new Item { ItemId = "4", ItemType= ItemTypeEnum.Operational },
                new Item { ItemId = "5", ItemType= ItemTypeEnum.Pretest },
                new Item { ItemId = "6", ItemType= ItemTypeEnum.Operational },
                new Item { ItemId = "7", ItemType= ItemTypeEnum.Pretest },
                new Item { ItemId = "8", ItemType= ItemTypeEnum.Operational },
                new Item { ItemId = "9", ItemType= ItemTypeEnum.Operational },
                new Item { ItemId = "10", ItemType= ItemTypeEnum.Operational },
            };
            Testlet test = new Testlet("one", ItemCollcetions);
            int count = 0;
            test.Randomize().GetRange(2, 8).ForEach(x => { if (x.ItemType == ItemTypeEnum.Operational) { count++; } });
            Assert.AreEqual(6, count, "Last 8 elements has 6 operational");
        }

        [TestMethod]
        public void Null_Items_Thorows_exception()
        {
            Testlet test = new Testlet("one", null);
            Assert.ThrowsException<ArgumentNullException>(() => test.Randomize());
        }

        [TestMethod]
        public void MoreThan_10_Items_Thorows_exception()
        {
            List<Item> ItemCollcetions = new List<Item>
            {
                new Item { ItemId = "1", ItemType= ItemTypeEnum.Pretest },
                new Item { ItemId = "2", ItemType= ItemTypeEnum.Operational },
                new Item { ItemId = "3", ItemType= ItemTypeEnum.Pretest },
                new Item { ItemId = "4", ItemType= ItemTypeEnum.Operational },
                new Item { ItemId = "5", ItemType= ItemTypeEnum.Pretest },
                new Item { ItemId = "6", ItemType= ItemTypeEnum.Operational },
                new Item { ItemId = "7", ItemType= ItemTypeEnum.Pretest },
                new Item { ItemId = "8", ItemType= ItemTypeEnum.Operational },
                new Item { ItemId = "9", ItemType= ItemTypeEnum.Operational },
                new Item { ItemId = "10", ItemType= ItemTypeEnum.Operational },
                new Item { ItemId = "11", ItemType= ItemTypeEnum.Pretest },
                new Item { ItemId = "12", ItemType= ItemTypeEnum.Operational },
                new Item { ItemId = "13", ItemType= ItemTypeEnum.Pretest },
                new Item { ItemId = "14", ItemType= ItemTypeEnum.Operational },
                new Item { ItemId = "15", ItemType= ItemTypeEnum.Pretest },
                new Item { ItemId = "16", ItemType= ItemTypeEnum.Operational }
            };
            Testlet test = new Testlet("one", ItemCollcetions);
            Assert.ThrowsException<Exception>(() => test.Randomize());
        }

        [TestMethod]
        public void LessThan_10_Items_Thorows_exception()
        {
            List<Item> ItemCollcetions = new List<Item>
            {
                new Item { ItemId = "1", ItemType= ItemTypeEnum.Pretest },
                new Item { ItemId = "2", ItemType= ItemTypeEnum.Operational },
                new Item { ItemId = "3", ItemType= ItemTypeEnum.Pretest },
                new Item { ItemId = "4", ItemType= ItemTypeEnum.Operational },

            };
            Testlet test = new Testlet("one", ItemCollcetions);
            Assert.ThrowsException<Exception>(() => test.Randomize());
        }

    }
}