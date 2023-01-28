namespace ShopShowcase.Common.Requests
{
    public class BaseRequest : Carrier
    {
        public string Origin { get; set; } = default!;
        public string Type { get; set; } = default!;
    }
}
