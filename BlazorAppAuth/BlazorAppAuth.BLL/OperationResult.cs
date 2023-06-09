

namespace CoreIdentitySample6.BLL
{
    public class OperationResult<T>
    {
        public bool IsSuccess { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }
        public int TotalCount { get; set; }
    }
}

