namespace Week5_DemoBank_Business.Utilities.Result
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
