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
            List<ADM_SOWN_LOG> result = dataProvider.getSownHistory(ids);
        }
    }
}
