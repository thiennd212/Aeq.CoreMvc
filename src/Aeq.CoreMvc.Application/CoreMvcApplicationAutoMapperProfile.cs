using Aeq.CoreMvc.Books;
using Aeq.CoreMvc.Books.Dtos;
using AutoMapper;

namespace Aeq.CoreMvc;

public class CoreMvcApplicationAutoMapperProfile : Profile
{
    public CoreMvcApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>(MemberList.Source);
    }
}
