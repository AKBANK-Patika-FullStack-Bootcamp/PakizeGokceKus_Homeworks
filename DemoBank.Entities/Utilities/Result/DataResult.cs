namespace Deviser.Bank.Core.Utilities.Result
{
    public class DataResult<T>:global::Deviser.Bank.Core.Utilities.Result.Result,IDataResult<T>
    {
        public DataResult(T data,bool success, string message) : base(success, message)
        {
            Data = data;
        }

        public DataResult(T data,bool success) : base(success)
        {
            Data = data;
        }

        public T Data { get; }
    }
}
