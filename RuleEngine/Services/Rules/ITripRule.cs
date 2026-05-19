using RuleEngine.Model;

namespace RuleEngine.Services.Rules
{
    public interface ITripRule
    {
        Violation? Check(List<Expense> expenses);
    }
}
