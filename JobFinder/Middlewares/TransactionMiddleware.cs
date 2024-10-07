using JobFinder.DataAccess.Persistent;
using Microsoft.AspNetCore.Identity;

namespace Art.Web.Middlewares
{
    public class TransactionMiddleware(RequestDelegate next)
    {

        public async Task Invoke(HttpContext context, DatabaseContext databaseContext)
        {
            await using var transaction = await databaseContext.Database.BeginTransactionAsync();
            try
            {
                await next(context);

                await transaction.CommitAsync();
            }
            catch
            {
                await transaction.RollbackAsync();
            }
        }
    }
}
