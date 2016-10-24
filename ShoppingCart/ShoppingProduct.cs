using ShoppingCart.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart
{
    public class ShoppingProduct
    {
        public double CalculateFee(List<Product> products)
        {
            //Step1:一到五集的哈利波特，每一本都是賣100元
            //Step2:如果你從這個系列買了兩本不同的書，則會有5%的折扣
            var calculateProducts = products.Where(t => t.Type == ProductEnum.Type.Book);
            int sum = calculateProducts.Sum(u => u.Price * u.Quantity);

            int totalEpisode = calculateProducts.Where(t => t.Quantity > 0)
                                                .Select(u => u.Episode)
                                                .Distinct()
                                                .Count();

            double[] ruleDiscount = new double[5] {1, 0.95, 0.9, 0.8, 0.75};

            double discount = ruleDiscount[totalEpisode - 1];

            return sum * discount;
        }
    }
}
