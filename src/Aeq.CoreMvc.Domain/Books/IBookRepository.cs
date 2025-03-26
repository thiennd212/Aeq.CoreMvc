using System;
using Volo.Abp.Domain.Repositories;

namespace Aeq.CoreMvc.Books;

public interface IBookRepository : IRepository<Book, Guid>
{
}
