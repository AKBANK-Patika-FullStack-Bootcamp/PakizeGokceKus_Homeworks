
namespace Week5_DemoBank_Business.Utilities.Result
{
    public interface IDataResult<out T> : IResult
    {
        T Data { get; }
    }
}
