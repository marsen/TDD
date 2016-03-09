using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestSpec
{
    [TestClass]
    public class ProductsTest
    {
        [TestMethod]
        public void 每三筆一組_取Cost總和()
        {
            ///arrange
            var target = new ProductionCode();            
            var stubData = new List<StubData>
            {
                new StubData { Id = 1 , Cost = 1 ,Revenue =11 ,SellPrice =21 },
                new StubData { Id = 2 , Cost = 2 ,Revenue =12 ,SellPrice =22 },
                new StubData { Id = 3 , Cost = 3 ,Revenue =13 ,SellPrice =23 },
                new StubData { Id = 4 , Cost = 4 ,Revenue =14 ,SellPrice =24 },
                new StubData { Id = 5 , Cost = 5 ,Revenue =15 ,SellPrice =25 },
                new StubData { Id = 6 , Cost = 6 ,Revenue =16 ,SellPrice =26 },
                new StubData { Id = 7 , Cost = 7 ,Revenue =17 ,SellPrice =27 },
                new StubData { Id = 8 , Cost = 8 ,Revenue =18 ,SellPrice =28 },
                new StubData { Id = 9 , Cost = 9 ,Revenue =19 ,SellPrice =29 },
                new StubData { Id = 10 , Cost = 10 ,Revenue =20 ,SellPrice =30 },
                new StubData { Id = 11 , Cost = 11 ,Revenue =21 ,SellPrice =31 },
            };
            var propertyName = "Cost";
            var sumOfNum = 3;
            var expected = new int[6, 15, 24, 21];
            ///act
            var actual = target.Calculate(stubData, propertyName, sumOfNum);
            ///assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 每四筆一組_取Revenue總和()
        {
            ///arrange
            var target = new ProductionCode();
            var stubData = new List<StubData>
            {
                new StubData { Id = 1 , Cost = 1 ,Revenue =11 ,SellPrice =21 },
                new StubData { Id = 2 , Cost = 2 ,Revenue =12 ,SellPrice =22 },
                new StubData { Id = 3 , Cost = 3 ,Revenue =13 ,SellPrice =23 },
                new StubData { Id = 4 , Cost = 4 ,Revenue =14 ,SellPrice =24 },
                new StubData { Id = 5 , Cost = 5 ,Revenue =15 ,SellPrice =25 },
                new StubData { Id = 6 , Cost = 6 ,Revenue =16 ,SellPrice =26 },
                new StubData { Id = 7 , Cost = 7 ,Revenue =17 ,SellPrice =27 },
                new StubData { Id = 8 , Cost = 8 ,Revenue =18 ,SellPrice =28 },
                new StubData { Id = 9 , Cost = 9 ,Revenue =19 ,SellPrice =29 },
                new StubData { Id = 10 , Cost = 10 ,Revenue =20 ,SellPrice =30 },
                new StubData { Id = 11 , Cost = 11 ,Revenue =21 ,SellPrice =31 },
            };
            var propertyName = "Revenue";
            var sumOfNum = 4;
            var expected = new int[6, 15, 24, 21];
            ///act
            var actual = target.Calculate(stubData, propertyName, sumOfNum);
            ///assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }

    internal class StubData
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }
    }
}
