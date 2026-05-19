using RuleEngine.Model;
using RuleEngine.Registery;
using RuleEngine.Services;
using RuleEngine.Services.RuleEngine;
using RuleEngine.Services.Rules;

namespace RuleEngie
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<Expense> expenses = new List<Expense>()
            {
                new Expense("1", "1", 10.0, ExpenseType.RESTAURANT),
                new Expense("2", "1", 50.0, ExpenseType.RESTAURANT),
                new Expense("3", "1", 100.0, ExpenseType.RESTAURANT)
            };

            RuleManagerRunner ruleManagerRunner = new RuleManagerRunner(new SimpleRuleEngine());
            ruleManagerRunner.Run(expenses);
        }
    }
}