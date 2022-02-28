namespace MercadoSM
{
    public class Invoice : IPay

    { 
        private List<Product>_products = new List<Product>();
       

        public decimal ValueToPay()
        {

            decimal CumulativeTotal = 0;
            foreach(Product product in _products)
            {
                CumulativeTotal += product.ValueToPay();
            }
            return CumulativeTotal ;

        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public override string ToString()
        {
            Console.WriteLine("RECEIPT");
            Console.WriteLine("-------------------------------------------------");
            foreach (Product product in _products)
            {
                Console.WriteLine(product.ToString());
            }
            return $"                               ===================" +
                $"\n\tTotal................: {$"{ValueToPay():C2}",18}";
        }
    }
}

