namespace ShoppingCart.Properties
{
    public class Product
    {
        /// <summary>
        /// 集數
        /// </summary>
        public int Episode { get; set; }
        /// <summary>
        /// 名稱
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 價錢
        /// </summary>
        public int Price { get; set; }
        /// <summary>
        /// 數量
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// 類型 <see cref="ProductEnum.Type"/>
        /// </summary>
        public ProductEnum.Type Type { get; set; }
    }
}