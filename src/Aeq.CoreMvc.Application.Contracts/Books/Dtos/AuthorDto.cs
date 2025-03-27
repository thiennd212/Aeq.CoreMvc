using System;
using Volo.Abp.Application.Dtos;

namespace Aeq.CoreMvc.Books.Dtos;

[Serializable]
public class AuthorDto : FullAuditedEntityDto<Guid>
{
    public string Name { get; set; }

    public string PhoneNumber { get; set; }

    public string Email { get; set; }
}