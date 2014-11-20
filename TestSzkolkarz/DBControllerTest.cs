using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using szkolkarz.core;
using szkolkarz;

namespace TestSzkolkarz
{
    [TestClass]
    public class DBControllerTest
    {
        [TestMethod]
        public void getSownHistoryTest()
        {
            List<int> ids = new List<int>{ 1, 2, 10, 15 };
            DBController dataProvider = new DBController();
            List<V_FULL_SOWN_LOG> result = dataProvider.getSownHistory(ids);
            Assert.IsTrue(result.Count > 0);
        }
    }
}
