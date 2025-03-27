using System;
using System.ComponentModel;
using Volo.Abp.Application.Dtos;

namespace Aeq.CoreMvc.Books.Dtos;

[Serializable]
public class AuthorGetListInput : PagedAndSortedResultRequestDto
{
    public string? Name { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }
}