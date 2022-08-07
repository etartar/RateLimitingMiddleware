using RateLimitingMiddleware.Enums;

namespace RateLimitingMiddleware.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class RateLimitDecorator : Attribute
    {
        public StrategyTypeEnum StrategyType { get; set; }
    }
}
