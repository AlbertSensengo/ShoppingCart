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
            var calculateProducts = products.Where(t => t.Type == ProductEnum.Type.Book);
            int totalQuantity = calculateProducts.Sum(t => t.Quantity);

            List<int> recordQuantity = new List<int>();
            int price = 100;

            while (totalQuantity > 0)
            {
                calculateProducts.ToList().ForEach(u => u.Quantity = (u.Quantity > 0 ? u.Quantity - 1 : 0));
                int remainSumQuantity = calculateProducts.Sum(t => t.Quantity);

                int subtractQuantity = totalQuantity - remainSumQuantity;
                totalQuantity = remainSumQuantity;
                recordQuantity.Add(subtractQuantity);
            }

            double[] ruleDiscount = new double[5] { 1, 0.95, 0.9, 0.8, 0.75 };

            return recordQuantity.Select(quantity => price * quantity * ruleDiscount[quantity-1]).Sum();
        }
    }
}
