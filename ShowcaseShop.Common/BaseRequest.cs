namespace ASP.NET_Skeleton.Common
{
    public abstract class BaseRequest : Carrier
    {
        public string Origin { get; set; } = default!;
        public string Type { get; set; } = default!;
    }
}
