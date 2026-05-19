using RuleEngine.Model;
using RuleEngine.Services.Rules;

namespace RuleEngine.Services.Implementation
{
    public class TripMaxAmountRule : ITripRule
    {
        public double MaxAmount;

        public TripMaxAmountRule(double maxAmount)
        {
            this.MaxAmount = maxAmount;
        }

        public Violation? Check(List<Expense> expenses)
        {
            double totalAmount = expenses.Sum(e => e.Amount);
            if (totalAmount > MaxAmount)
            {
                return new Violation("TotalAmount of trip exceeds the max Amount");
            }

            return null;
        }
    }
}
