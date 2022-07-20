using Xuyor.SharedContext;

namespace Xuyor.SubscriptionContext
{
    public class Subscription : Base
    {
        public Plan Plano { get; set; }

        // O aluno está com a subscription ativa quando EXISTE UM ENDDATE e ele NÃO ESTÁ no PASSADO.
        // Tem '?' porque pode ser "null".
        public DateTime? EndDate { get; set; }

        public bool IsInactive => EndDate <= DateTime.Now;

    }
}