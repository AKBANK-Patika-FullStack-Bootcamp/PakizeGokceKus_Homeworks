namespace Week5_DemoBank_Business.Utilities.Result
{
    public class SuccessResult : Result
    {

        public SuccessResult(string message) : base(true, message)
        {
        }

        public SuccessResult() : base(true)
        {
        }
    }
}
