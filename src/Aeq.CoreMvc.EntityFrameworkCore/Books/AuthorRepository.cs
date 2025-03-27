using System;
using System.Linq;
using System.Threading.Tasks;
using Aeq.CoreMvc.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Aeq.CoreMvc.Books;

public class AuthorRepository : EfCoreRepository<CoreMvcDbContext, Author, Guid>, IAuthorRepository
{
    public AuthorRepository(IDbContextProvider<CoreMvcDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<Author>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}