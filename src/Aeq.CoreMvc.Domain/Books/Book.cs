using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Aeq.CoreMvc.Books
{
    public class Book : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }

    protected Book()
    {
    }

    public Book(
        Guid id,
        string name,
        string type,
        string description,
        DateTime publishDate
    ) : base(id)
    {
        Name = name;
        Type = type;
        Description = description;
        PublishDate = publishDate;
    }
    }
}
