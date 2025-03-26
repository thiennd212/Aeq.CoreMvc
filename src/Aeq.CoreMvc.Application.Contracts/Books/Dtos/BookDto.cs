using System;
using Volo.Abp.Application.Dtos;

namespace Aeq.CoreMvc.Books.Dtos;

[Serializable]
public class BookDto : FullAuditedEntityDto<Guid>
{
    public string Name { get; set; }

    public string Type { get; set; }

    public string Description { get; set; }

    public DateTime PublishDate { get; set; }
}