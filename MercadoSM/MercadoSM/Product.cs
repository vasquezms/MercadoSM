namespace MercadoSM
{
    public abstract class Product :IPay
    {

        public int Id { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public float Tax { get; set; }

        public abstract decimal ValueToPay();
         
        public override string ToString()
        {
            return $"   {Id} - {Description} "+
                $"\n\tPrice................: {$"{Price:C2}",18}" +
                $"\n\tTax..................: {$"{Tax:P2}",18}"+
                $"\n\tValue................: {$"{ValueToPay():C2}",18}";
        }


    }
}

