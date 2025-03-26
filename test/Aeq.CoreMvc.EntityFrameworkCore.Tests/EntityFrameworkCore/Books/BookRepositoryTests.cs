using System;
using System.Threading.Tasks;
using Aeq.CoreMvc.Books;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Aeq.CoreMvc.EntityFrameworkCore.Books;

public class BookRepositoryTests : CoreMvcEntityFrameworkCoreTestBase
{
    private readonly IBookRepository _bookRepository;

    public BookRepositoryTests()
    {
        _bookRepository = GetRequiredService<IBookRepository>();
    }

    /*
    [Fact]
    public async Task Test1()
    {
        await WithUnitOfWorkAsync(async () =>
        {
            // Arrange

            // Act

            //Assert
        });
    }
    */
}
