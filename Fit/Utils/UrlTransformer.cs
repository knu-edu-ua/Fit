namespace Fit.Utils
{
    public class UrlTransformer : IOutboundParameterTransformer
    {
        public string? TransformOutbound(object? value)
        {
            return Convert.ToString(value)?.ToLower();
        }
    }
}