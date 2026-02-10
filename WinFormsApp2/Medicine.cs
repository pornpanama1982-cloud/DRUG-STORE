namespace WinFormsApp2
{
    public class Medicine
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

        public Medicine(string code, string name, string category, decimal price)
        {
            Code = code;
            Name = name;
            Category = category;
            Price = price;
        }
    }
}
