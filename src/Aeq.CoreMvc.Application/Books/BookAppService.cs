using System;
using System.Linq;
using System.Threading.Tasks;
using Aeq.CoreMvc.Permissions;
using Aeq.CoreMvc.Books.Dtos;
using Volo.Abp.Application.Services;

namespace Aeq.CoreMvc.Books;


public class BookAppService : CrudAppService<Book, BookDto, Guid, BookGetListInput, CreateUpdateBookDto, CreateUpdateBookDto>,
    IBookAppService
{
    protected override string GetPolicyName { get; set; } = CoreMvcPermissions.Book.Default;
    protected override string GetListPolicyName { get; set; } = CoreMvcPermissions.Book.Default;
    protected override string CreatePolicyName { get; set; } = CoreMvcPermissions.Book.Create;
    protected override string UpdatePolicyName { get; set; } = CoreMvcPermissions.Book.Update;
    protected override string DeletePolicyName { get; set; } = CoreMvcPermissions.Book.Delete;

    private readonly IBookRepository _repository;

    public BookAppService(IBookRepository repository) : base(repository)
    {
        _repository = repository;
    }

    protected override async Task<IQueryable<Book>> CreateFilteredQueryAsync(BookGetListInput input)
    {
        // TODO: AbpHelper generated
        return (await base.CreateFilteredQueryAsync(input))
            .WhereIf(!input.Name.IsNullOrWhiteSpace(), x => x.Name.Contains(input.Name))
            .WhereIf(!input.Type.IsNullOrWhiteSpace(), x => x.Type.Contains(input.Type))
            .WhereIf(!input.Description.IsNullOrWhiteSpace(), x => x.Description.Contains(input.Description))
            .WhereIf(input.PublishDate != null, x => x.PublishDate == input.PublishDate)
            ;
    }
}
