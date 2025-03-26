using System;
using Aeq.CoreMvc.Books.Dtos;
using Volo.Abp.Application.Services;

namespace Aeq.CoreMvc.Books;


public interface IBookAppService :
    ICrudAppService< 
        BookDto, 
        Guid, 
        BookGetListInput,
        CreateUpdateBookDto,
        CreateUpdateBookDto>
{

}