using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aeq.CoreMvc.Books;
using Aeq.CoreMvc.Books.Dtos;
using Aeq.CoreMvc.Web.Pages.Books.Book.ViewModels;

namespace Aeq.CoreMvc.Web.Pages.Books.Book;

public class CreateModalModel : CoreMvcPageModel
{
    [BindProperty]
    public CreateEditBookViewModel ViewModel { get; set; }

    private readonly IBookAppService _service;

    public CreateModalModel(IBookAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditBookViewModel, CreateUpdateBookDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}