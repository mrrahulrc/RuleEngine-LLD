using RuleEngine.Model;
using RuleEngine.Services.Rules;

namespace RuleEngine.Services.Implementation
{
    public class TripMealMaxAmountRule : ITripRule
    {
        public double TripMealMaxAmount;

        public TripMealMaxAmountRule(double tripMeanMaxAmount)
        {
            TripMealMaxAmount = tripMeanMaxAmount;
        }

        public Violation? Check(List<Expense> expenses)
        {
            var tripMealExpenses = expenses
                .Where(ele => ele.ExpenseType == ExpenseType.RESTAURANT)
                .Sum(ele => ele.Amount);

            if (tripMealExpenses > TripMealMaxAmount)
            {
                return new Violation($"Total amount of meal expenses {tripMealExpenses} exceeds the maximum allowed amount of {TripMealMaxAmount} for the trip.");
            }

            return null;
        }
    }
}
