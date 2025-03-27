using System;

namespace Aeq.CoreMvc.Books.Dtos;

[Serializable]
public class CreateUpdateAuthorDto
{
    public string Name { get; set; }

    public string PhoneNumber { get; set; }

    public string Email { get; set; }
}