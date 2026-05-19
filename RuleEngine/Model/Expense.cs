namespace RuleEngine.Model
{
    public class Expense
    {
        public string ExpenseId;                
        public string TripId { get; }
        public double Amount { get; }
        public ExpenseType ExpenseType { get; }

        public Expense(string expenseId, string tripId, double amount, ExpenseType expenseType)
        {
            ExpenseId = expenseId;
            TripId = tripId;
            Amount = amount;
            ExpenseType = expenseType;
        }
    }
}
