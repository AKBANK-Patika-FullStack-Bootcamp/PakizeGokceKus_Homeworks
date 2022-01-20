namespace Deviser.Bank.Core.Utilities.Result
{
   public class ErrorResult:global::Deviser.Bank.Core.Utilities.Result.Result
    {
        public ErrorResult(string message) : base(false, message)
        {
        }

        public ErrorResult() : base(false)
        {
        }
    }
}
