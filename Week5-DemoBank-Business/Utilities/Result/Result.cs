namespace Week5_DemoBank_Business.Utilities.Result
{
    public class Result : IResult
    {
        public Result(bool success, string message) : this(success)
        //this(success) başka constructoruda tetiklemek demek aşağıdaki
        //bool succeside alır
        {
            Message = message;
            //Success=success işlemii this(success ile yaptık)
        }

        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }
        public string Message { get; }
    }
}
