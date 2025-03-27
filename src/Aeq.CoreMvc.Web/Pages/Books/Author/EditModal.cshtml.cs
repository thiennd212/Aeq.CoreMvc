using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aeq.CoreMvc.Books;
using Aeq.CoreMvc.Books.Dtos;
using Aeq.CoreMvc.Web.Pages.Books.Author.ViewModels;

namespace Aeq.CoreMvc.Web.Pages.Books.Author;

public class EditModalModel : CoreMvcPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public CreateEditAuthorViewModel ViewModel { get; set; }

    private readonly IAuthorAppService _service;

    public EditModalModel(IAuthorAppService service)
    {
        _service = service;
    }

    public virtual async Task OnGetAsync()
    {
        var dto = await _service.GetAsync(Id);
        ViewModel = ObjectMapper.Map<AuthorDto, CreateEditAuthorViewModel>(dto);
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditAuthorViewModel, CreateUpdateAuthorDto>(ViewModel);
        await _service.UpdateAsync(Id, dto);
        return NoContent();
    }
}