using System;
using System.Linq;
using System.Threading.Tasks;
using Aeq.CoreMvc.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Aeq.CoreMvc.Books;

public class BookRepository : EfCoreRepository<CoreMvcDbContext, Book, Guid>, IBookRepository
{
    public BookRepository(IDbContextProvider<CoreMvcDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<Book>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}