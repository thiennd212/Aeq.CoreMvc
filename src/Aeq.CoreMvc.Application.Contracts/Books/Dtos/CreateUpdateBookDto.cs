using System;

namespace Aeq.CoreMvc.Books.Dtos;

[Serializable]
public class CreateUpdateBookDto
{
    public string Name { get; set; }

    public string Type { get; set; }

    public string Description { get; set; }

    public DateTime PublishDate { get; set; }
}