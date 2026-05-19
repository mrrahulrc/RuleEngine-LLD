namespace RuleEngine.Services.Rules
{
    public class Violation
    {
        public string Message { get; }
        public Violation(string message)
        {
            Message = message;
        }
    }
}
