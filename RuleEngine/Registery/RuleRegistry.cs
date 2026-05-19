using RuleEngine.Model;
using RuleEngine.Services.Implementation;
using RuleEngine.Services.Rules;

namespace RuleEngine.Registery
{
    public class RuleRegistry
    {
        public static Dictionary<ExpenseType, List<IExpenseRule>> GetExpenseRuleRegistry()
        {
            Dictionary<ExpenseType, List<IExpenseRule>> expenseRuleRegistry = new();

            expenseRuleRegistry.Add(ExpenseType.RESTAURANT, new List<IExpenseRule>
            {
                new MaxAmountRule(75)
            });

            expenseRuleRegistry.Add(ExpenseType.AIRFARE, new List<IExpenseRule>
            {
                new DisAllowRule()
            });

            expenseRuleRegistry.Add(ExpenseType.ENTERTAINMENT, new List<IExpenseRule>
            {
                new DisAllowRule()
            });

            return expenseRuleRegistry;
        }

        public static List<IExpenseRule> GetAllExpenseRuleRegistry()
        {
            return new List<IExpenseRule>
            {
                new MaxAmountRule(250)
            };
        }

        public static List<ITripRule> GetTripRuleRegistry()
        {
            return new List<ITripRule>
            {
                new TripMaxAmountRule(2000),
                new TripMealMaxAmountRule(1000)
            };
        }
    }
}
