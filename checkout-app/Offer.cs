namespace checkout_app {

    public class Offer {
        public Offer(string sku, int quantity, decimal price)
        {
            Sku = sku;
            Quantity = quantity;
            Price = price;
        }

        public string Sku { get; }
        public int Quantity { get; }
        public decimal Price { get; }
    }

}