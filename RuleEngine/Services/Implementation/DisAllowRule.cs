using RuleEngine.Model;
using RuleEngine.Services.Rules;

namespace RuleEngine.Services.Implementation
{
    public class DisAllowRule : IExpenseRule
    {
        public Violation? Check(Expense e)
        {
            return new Violation($"Expense of type {e.ExpenseType} is not allowed.");
        }
    }
}
