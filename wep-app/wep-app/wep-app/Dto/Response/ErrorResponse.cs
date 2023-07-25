using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace wep_app.Dto.Response
{
    public class ErrorResponse
    {
        public int StatusCode { get; set; }
        public string? Message { get; set; }
        public ModelStateDictionary? ModelState { get; set; }

        public ErrorResponse(int statusCode, string? message)
        {
            StatusCode = statusCode;
            Message = message;
        }

        public ErrorResponse(int statusCode, ModelStateDictionary? modelState)
        {
            StatusCode = statusCode;
            ModelState = modelState;
        }
    }
}
