using System;
using System.ComponentModel.DataAnnotations;

namespace Aeq.CoreMvc.Web.Pages.Books.Book.ViewModels;

public class CreateEditBookViewModel
{
    [Display(Name = "BookName")]
    public string Name { get; set; }

    [Display(Name = "BookType")]
    public string Type { get; set; }

    [Display(Name = "BookDescription")]
    public string Description { get; set; }

    [Display(Name = "BookPublishDate")]
    public DateTime PublishDate { get; set; }
}
