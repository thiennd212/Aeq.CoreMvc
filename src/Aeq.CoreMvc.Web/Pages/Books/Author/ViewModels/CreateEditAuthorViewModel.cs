using System;
using System.ComponentModel.DataAnnotations;

namespace Aeq.CoreMvc.Web.Pages.Books.Author.ViewModels;

public class CreateEditAuthorViewModel
{
    [Display(Name = "AuthorName")]
    public string Name { get; set; }

    [Display(Name = "AuthorPhoneNumber")]
    public string PhoneNumber { get; set; }

    [Display(Name = "AuthorEmail")]
    public string Email { get; set; }
}
