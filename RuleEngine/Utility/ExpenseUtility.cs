using RuleEngine.Model;

namespace RuleEngine.Utility
{
    public class ExpenseUtility
    {
        public static Boolean areAllExpensesOfSameTrip(List<Expense> expenses)
        {
            if (expenses == null || expenses.Count == 0)
            {
                return true;
            }

            var tripId = expenses[0].TripId;
            return expenses.All(e => e.TripId == tripId);
        }
    }
}
