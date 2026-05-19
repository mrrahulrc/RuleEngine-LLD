using RuleEngine.Model;
using RuleEngine.Services.Rules;
using RuleEngine.Utility;

namespace RuleEngine.Services.RuleEngine
{
    public class SimpleRuleEngine : IRuleEngine
    {
        public List<Violation?> Evaluate(
            List<Expense> expenses, 
            List<IExpenseRule> allExpenseRules, 
            Dictionary<ExpenseType, List<IExpenseRule>> expenseRules, 
            List<ITripRule> tripRules)
        {
            List<Violation?> violations = new List<Violation?>();

            // check all expense rules
            foreach (var expense in expenses)
            {
                CheckExpenseAgainstRules(expense, allExpenseRules, violations);

                var expenseTypeRules = expenseRules.GetValueOrDefault(expense.ExpenseType, new List<IExpenseRule>());
                CheckExpenseAgainstRules(expense, expenseTypeRules, violations);
            }

            // check trip wise expense rules
            if (ExpenseUtility.areAllExpensesOfSameTrip(expenses))
            {
                foreach (var tripRule in tripRules)
                {
                    var violation = tripRule.Check(expenses);
                    if (violation != null)
                    {
                        violations.Add(violation);
                    }
                }
            }
            else
            {
                violations.Add(new Violation("All expenses should be of the same trip"));
            }

            return violations;
        }

        public void CheckExpenseAgainstRules(Expense expense, List<IExpenseRule> expenseRules, List<Violation?> violationResults)
        {
            foreach (var expenseRule in expenseRules)
            {
                var violation = expenseRule.Check(expense);
                if (violation != null)
                {
                    violationResults.Add(violation);
                }
            }
        }
    }
}
