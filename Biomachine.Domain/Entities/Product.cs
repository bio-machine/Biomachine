using Biomachine.Domain.Commons;

namespace Biomachine.Domain.Entities;

public class Product : Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }
}
