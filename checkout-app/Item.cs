namespace checkout_app {

    public class Item {
        public Item(string sku, decimal unitPrice)
        {
            Sku = sku;
            this.UnitPrice = unitPrice;
        }

        public string Sku { get; } 
        public decimal UnitPrice { get; }
    }

}