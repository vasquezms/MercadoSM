namespace MercadoSM
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }

        public float Quantity { get; set; }

        public override decimal ValueToPay()
        {
            return (decimal)Quantity * (Price + (Price * (decimal)Tax));
        }

        public override string ToString()
        {
            return $"{Id} - {Description} " +
                $"\n\tMeasurement:.........: {$"{Measurement}",18}" +
                $"\n\tQuantity.............: {$"{Quantity:F2}",18}"+
                $"\n\tPrice................: {$"{Price:C2}",18}" +
                $"\n\tTax..................: {$"{Tax:P2}",18}" +
                $"\n\tValue................: {$"{ValueToPay():C2}",18}";


        }
    }
}
