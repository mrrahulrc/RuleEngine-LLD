using RuleEngine.Model;
using RuleEngine.Services.Rules;

namespace RuleEngine.Services.Implementation
{
    public class MaxAmountRule : IExpenseRule
    {
        public double MaxAmount { get; }
        public MaxAmountRule(double maxAmount)
        {
            MaxAmount = maxAmount;
        }
        public Violation? Check(Expense e)
        {
            if (e.Amount > MaxAmount)
            {
                return new Violation($"Expense amount {e.Amount} exceeds the maximum allowed amount of {MaxAmount} for expense {e.ExpenseType.ToString()}.");
            }

            return null;
        }
    }
}
