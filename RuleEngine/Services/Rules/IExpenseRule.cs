using RuleEngine.Model;

namespace RuleEngine.Services.Rules
{
    public interface IExpenseRule
    {
        Violation? Check(Expense e);
    }
}
