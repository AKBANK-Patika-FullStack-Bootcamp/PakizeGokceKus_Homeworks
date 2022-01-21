namespace Week4_DemoBank_Entities.Utilities.Result
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
