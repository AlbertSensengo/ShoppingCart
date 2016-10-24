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
            var products = this.GetProductStep1();

            //act
            double actual = target.CalculateFee(products);

            //assert
            var expected = 100;

            Assert.AreEqual(expected, actual);
        }

        private List<Product> GetProductStep1()
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

        [TestMethod]
        public void 第一集買了一本第二集也買了一本價格應為190()
        {
            //arrange 
            var target = new ShoppingProduct();
            var products = this.GetProductStep2();

            //act
            double actual = target.CalculateFee(products);

            //assert
            var expected = 190;

            Assert.AreEqual(expected, actual);
        }

        private List<Product> GetProductStep2()
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
                    Quantity = 1
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

        [TestMethod]
        public void 一二三集各買了一本價格應為270()
        {
            //arrange 
            var target = new ShoppingProduct();
            var products = this.GetProductStep3();

            //act
            double actual = target.CalculateFee(products);

            //assert
            var expected = 270;

            Assert.AreEqual(expected, actual);
        }

        private List<Product> GetProductStep3()
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
                    Quantity = 1
                },
                new Product() {
                    Type = ProductEnum.Type.Book,
                    Name = "Potter",
                    Episode = 3,
                    Price = 100,
                    Quantity = 1
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

        [TestMethod]
        public void 一二三四集各買了一本價格應為320()
        {
            //arrange 
            var target = new ShoppingProduct();
            var products = this.GetProductStep4();

            //act
            double actual = target.CalculateFee(products);

            //assert
            var expected = 320;

            Assert.AreEqual(expected, actual);
        }

        private List<Product> GetProductStep4()
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
                    Quantity = 1
                },
                new Product() {
                    Type = ProductEnum.Type.Book,
                    Name = "Potter",
                    Episode = 3,
                    Price = 100,
                    Quantity = 1
                },
                new Product() {
                    Type = ProductEnum.Type.Book,
                    Name = "Potter",
                    Episode = 4,
                    Price = 100,
                    Quantity = 1
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

        [TestMethod]
        public void 一二三四集各買了一本價格應為375()
        {
            //arrange 
            var target = new ShoppingProduct();
            var products = this.GetProductStep5();

            //act
            double actual = target.CalculateFee(products);

            //assert
            var expected = 375;

            Assert.AreEqual(expected, actual);
        }

        private List<Product> GetProductStep5()
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
                    Quantity = 1
                },
                new Product() {
                    Type = ProductEnum.Type.Book,
                    Name = "Potter",
                    Episode = 3,
                    Price = 100,
                    Quantity = 1
                },
                new Product() {
                    Type = ProductEnum.Type.Book,
                    Name = "Potter",
                    Episode = 4,
                    Price = 100,
                    Quantity = 1
                },
                new Product() {
                    Type = ProductEnum.Type.Book,
                    Name = "Potter",
                    Episode = 5,
                    Price = 100,
                    Quantity = 1
                }
            };
        }

        [TestMethod]
        public void 一二集各買了一本第三集買了兩本價格應為370()
        {
            //arrange 
            var target = new ShoppingProduct();
            var products = this.GetProductStep6();

            //act
            double actual = target.CalculateFee(products);

            //assert
            var expected = 370;

            Assert.AreEqual(expected, actual);
        }

        private List<Product> GetProductStep6()
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
                    Quantity = 1
                },
                new Product() {
                    Type = ProductEnum.Type.Book,
                    Name = "Potter",
                    Episode = 3,
                    Price = 100,
                    Quantity = 2
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

        [TestMethod]
        public void 第一集買了一本第二三集各買了兩本價格應為460()
        {
            //arrange 
            var target = new ShoppingProduct();
            var products = this.GetProductStep7();

            //act
            double actual = target.CalculateFee(products);

            //assert
            var expected = 460;

            Assert.AreEqual(expected, actual);
        }

        private List<Product> GetProductStep7()
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
                    Quantity = 2
                },
                new Product() {
                    Type = ProductEnum.Type.Book,
                    Name = "Potter",
                    Episode = 3,
                    Price = 100,
                    Quantity = 2
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
