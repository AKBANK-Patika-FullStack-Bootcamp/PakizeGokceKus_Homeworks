namespace Deviser.Bank.Core.Utilities.Result
{
    public class SuccessResult:Deviser.Bank.Core.Utilities.Result.Result
    {
       
        public SuccessResult( string message) : base(true, message)
        {
        }

        public SuccessResult() : base(true)
        {
        }
    }
}
