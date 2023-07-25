namespace wep_app.Dto.Response
{
    public class ValidResponse<T>
    {
        public int StatusCode { get; set; }
        public T Data { get; set; }
        public string? Message { get; set; }

        public ValidResponse(int statusCode, T data)
        {
            Data = data;
            StatusCode = statusCode;
        }

        public ValidResponse(int statusCode)
        {
            StatusCode = statusCode;
        }

        public ValidResponse(int statusCode, T data, string message) : this(statusCode, data)
        {
            Message = message;
        }
    }
}
