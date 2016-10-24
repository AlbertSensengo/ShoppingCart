using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart;
using ShoppingCart.Properties;
using System.Collections.Generic;

namespace ShoppingCartTest
{
    [TestClass]
    public class ShoppingCartTest
    {
        [TestMethod]
        public void 第一集買了一本其他都沒買價格應為100()
        {
            //arrange 
            var target = new ShoppingProduct();
            var products = this.GetProduct();

            //act
            int actual = target.CalculateFee(products);

            //assert
            var expected = 100;

            Assert.AreEqual(expected, actual);
        }

        private List<Product> GetProduct()
        {
            return new List<Product>()
            {
                new Product() {
                    Type = ProductEnum.Type.Book,
                    Name = "Potter",
                    Episode = 1,
                    Price = 100,
                    Quantity = 1
                },
                new Product() {
                    Type = ProductEnum.Type.Book,
                    Name = "Potter",
                    Episode = 2,
                    Price = 100,
                    Quantity = 0
                },
                new Product() {
                    Type = ProductEnum.Type.Book,
                    Name = "Potter",
                    Episode = 3,
                    Price = 100,
                    Quantity = 0
                },
                new Product() {
                    Type = ProductEnum.Type.Book,
                    Name = "Potter",
                    Episode = 4,
                    Price = 100,
                    Quantity = 0
                },
                new Product() {
                    Type = ProductEnum.Type.Book,
                    Name = "Potter",
                    Episode = 5,
                    Price = 100,
                    Quantity = 0
                }
            };
        }
    }
}
