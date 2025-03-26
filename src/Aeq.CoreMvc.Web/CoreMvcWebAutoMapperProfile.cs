using Aeq.CoreMvc.Books.Dtos;
using Aeq.CoreMvc.Web.Pages.Books.Book.ViewModels;
using AutoMapper;

namespace Aeq.CoreMvc.Web;

public class CoreMvcWebAutoMapperProfile : Profile
{
    public CoreMvcWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
        CreateMap<BookDto, CreateEditBookViewModel>();
        CreateMap<CreateEditBookViewModel, CreateUpdateBookDto>();
    }
}
