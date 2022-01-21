namespace Deviser.Bank.Core.Utilities.Result
{
    public class ErrorResult: global::Week4_DemoBank_Entities.Utilities.Result.Result
    {
        public ErrorResult(string message) : base(false, message)
        {
        }

        public ErrorResult() : base(false)
        {
        }
    }
}
