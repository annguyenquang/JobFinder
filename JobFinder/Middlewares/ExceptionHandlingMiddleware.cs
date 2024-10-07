using JobFinder.Model;
using JobFinder.Model.Exceptions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace JobFinder.Middlewares
    {
    public class ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
    {
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleException(context, ex);
            }
        }

        private Task HandleException(HttpContext context, Exception ex)
        {
            logger.LogError(ex, "");

            var code = StatusCodes.Status500InternalServerError;
            var errors = new List<string> { ex.Message };

            code = ex switch
            {
                NotFoundException => StatusCodes.Status404NotFound,
                ResourceNotFoundException => StatusCodes.Status404NotFound,
                BadRequestException => StatusCodes.Status400BadRequest,
                UnprocessableRequestException => StatusCodes.Status422UnprocessableEntity,
                UnauthorizedAccessException => StatusCodes.Status401Unauthorized,
                _ => code
            };

            var result = JsonConvert.SerializeObject(ApiResult<string>.Failure(errors), new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            });

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = code;

            return context.Response.WriteAsync(result);
        }
    }
}
