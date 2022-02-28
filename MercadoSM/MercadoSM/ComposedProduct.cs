namespace MercadoSM
{
    public class ComposedProduct : Product
    {
      

        public float Discount { get; set; }
        public List <Product> Products { get; set; }
       

        public override decimal ValueToPay()

            
        {
            decimal ProductAaccumulated = 0;
             foreach (Product product in Products)
            {

                ProductAaccumulated += product.ValueToPay() - (product.ValueToPay() * (decimal)Discount);
            }
            return ProductAaccumulated;
        }
        public override string ToString()
        {

            string product = "";
            foreach (Product prod in Products)
            {
                product += prod.Description + ", ";
            }
                return $"   {Id} - {Description} " +
                $"\n\tproducts.............: {$"{product}",18}" +
                $"\n\tDiscount.............: {$"{Discount:P2}",18}" +
                $"\n\tValue................: {$"{ValueToPay():C2}",18}";
        }
    
    }
}
