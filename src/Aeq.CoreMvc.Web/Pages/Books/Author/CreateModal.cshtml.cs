using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aeq.CoreMvc.Books;
using Aeq.CoreMvc.Books.Dtos;
using Aeq.CoreMvc.Web.Pages.Books.Author.ViewModels;

namespace Aeq.CoreMvc.Web.Pages.Books.Author;

public class CreateModalModel : CoreMvcPageModel
{
    [BindProperty]
    public CreateEditAuthorViewModel ViewModel { get; set; }

    private readonly IAuthorAppService _service;

    public CreateModalModel(IAuthorAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditAuthorViewModel, CreateUpdateAuthorDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}