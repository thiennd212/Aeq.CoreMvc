using System;
using System.Linq;
using System.Threading.Tasks;
using Aeq.CoreMvc.Permissions;
using Aeq.CoreMvc.Books.Dtos;
using Volo.Abp.Application.Services;

namespace Aeq.CoreMvc.Books;


public class AuthorAppService : CrudAppService<Author, AuthorDto, Guid, AuthorGetListInput, CreateUpdateAuthorDto, CreateUpdateAuthorDto>,
    IAuthorAppService
{
    protected override string GetPolicyName { get; set; } = CoreMvcPermissions.Author.Default;
    protected override string GetListPolicyName { get; set; } = CoreMvcPermissions.Author.Default;
    protected override string CreatePolicyName { get; set; } = CoreMvcPermissions.Author.Create;
    protected override string UpdatePolicyName { get; set; } = CoreMvcPermissions.Author.Update;
    protected override string DeletePolicyName { get; set; } = CoreMvcPermissions.Author.Delete;

    private readonly IAuthorRepository _repository;

    public AuthorAppService(IAuthorRepository repository) : base(repository)
    {
        _repository = repository;
    }

    protected override async Task<IQueryable<Author>> CreateFilteredQueryAsync(AuthorGetListInput input)
    {
        // TODO: AbpHelper generated
        return (await base.CreateFilteredQueryAsync(input))
            .WhereIf(!input.Name.IsNullOrWhiteSpace(), x => x.Name.Contains(input.Name))
            .WhereIf(!input.PhoneNumber.IsNullOrWhiteSpace(), x => x.PhoneNumber.Contains(input.PhoneNumber))
            .WhereIf(!input.Email.IsNullOrWhiteSpace(), x => x.Email.Contains(input.Email))
            ;
    }
}
