using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Aeq.CoreMvc.Books;

public static class AuthorEfCoreQueryableExtensions
{
    public static IQueryable<Author> IncludeDetails(this IQueryable<Author> queryable, bool include = true)
    {
        if (!include)
        {
            return queryable;
        }

        return queryable
            // .Include(x => x.xxx) // TODO: AbpHelper generated
            ;
    }
}
