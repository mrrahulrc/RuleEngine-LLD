using RuleEngine.Model;
using RuleEngine.Registery;
using RuleEngine.Services.RuleEngine;

namespace RuleEngine.Services
{
    public class RuleManagerRunner
    {
        public IRuleEngine RuleEngine;

        public RuleManagerRunner(IRuleEngine ruleEngine)
        {
            RuleEngine = ruleEngine;
        }

        public void Run(List<Expense> expenses) 
        {
            Console.WriteLine("Running Rule Manager Runner...");

            IRuleEngine ruleEngine = new SimpleRuleEngine();            

            var violations = ruleEngine.Evaluate(expenses,
                RuleRegistry.GetAllExpenseRuleRegistry(),
                RuleRegistry.GetExpenseRuleRegistry(),
                RuleRegistry.GetTripRuleRegistry());

            foreach(var violation in violations)
            {
                if(violation != null)
                {
                    Console.WriteLine($"Violation: {violation.Message}");
                }
            }

            Console.WriteLine("Finished Running Rule Manager Runner...");
            Console.Read();
        }
    }
}
