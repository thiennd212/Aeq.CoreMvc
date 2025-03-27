using System;
using Aeq.CoreMvc.Books.Dtos;
using Volo.Abp.Application.Services;

namespace Aeq.CoreMvc.Books;


public interface IAuthorAppService :
    ICrudAppService< 
        AuthorDto, 
        Guid, 
        AuthorGetListInput,
        CreateUpdateAuthorDto,
        CreateUpdateAuthorDto>
{

}