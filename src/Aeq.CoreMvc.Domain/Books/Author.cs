using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Aeq.CoreMvc.Books
{
    public class Author : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

    protected Author()
    {
    }

    public Author(
        Guid id,
        string name,
        string phoneNumber,
        string email
    ) : base(id)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
    }
    }
}
