using Xuyor.SharedContext;

namespace Xuyor.SubscriptionContext
{
    // Precisa de um identificador, isso é a "base" de todos os produtos únicos.
    public class Plan : Base
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}