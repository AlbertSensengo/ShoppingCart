using ShoppingCart.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart
{
    public class ShoppingProduct
    {
        public int CalculateFee(List<Product> products)
        {
            //Step1:一到五集的哈利波特，每一本都是賣100元
            return products.Where(t => t.Type == ProductEnum.Type.Book)
                           .Sum(u => u.Price * u.Quantity);
        }
    }
}
