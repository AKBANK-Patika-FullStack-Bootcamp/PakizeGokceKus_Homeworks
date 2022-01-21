namespace Week4_DemoBank_Entities.Utilities.Result
{
    public interface IDataResult<out T> : IResult
    {
        T Data { get; }
    }
}
