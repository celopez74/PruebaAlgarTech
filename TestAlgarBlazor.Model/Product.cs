namespace TestAlgarBlazor.Model
{
    public class Product
    {
        public int ProductId { get; set; } 
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public string? ProductReference { get; set; }
        public float productPrice { get; set; }

        public string? urlImage { get; set; }

    }
}