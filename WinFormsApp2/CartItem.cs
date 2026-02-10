namespace WinFormsApp2
{
    public class CartItem
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public decimal Total => Price * Quantity;

        public CartItem(string code, string name, string category, decimal price, int quantity)
        {
            Code = code;
            Name = name;
            Category = category;
            Price = price;
            Quantity = quantity;
        }
    }
}
