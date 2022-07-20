using Xuyor.SharedContext;

namespace Xuyor.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }

        public string Name { get; set; }
        public string Email { get; set; }

        public IList<Subscription> Subscriptions { get; set; }

        public User User { get; set; }

    }
}