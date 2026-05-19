using RuleEngine.Model;
using RuleEngine.Services.Rules;

namespace RuleEngine.Services
{
    public interface IRuleEngine
    {
        public List<Violation?> Evaluate(
            List<Expense> expenses,
            List<IExpenseRule> allExpenseRules,
            Dictionary<ExpenseType, List<IExpenseRule>> expenseRules,
            List<ITripRule> tripRules);
    }
}
