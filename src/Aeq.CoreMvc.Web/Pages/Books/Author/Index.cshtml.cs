using System;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace Aeq.CoreMvc.Web.Pages.Books.Author;

public class IndexModel : CoreMvcPageModel
{
    public AuthorFilterInput AuthorFilter { get; set; }
    
    public virtual async Task OnGetAsync()
    {
        await Task.CompletedTask;
    }
}

public class AuthorFilterInput
{
    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "AuthorName")]
    public string? Name { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "AuthorPhoneNumber")]
    public string? PhoneNumber { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "AuthorEmail")]
    public string? Email { get; set; }
}
