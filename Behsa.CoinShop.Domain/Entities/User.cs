using Behsa.CoinShop.Domain.Common;
using Behsa.CoinShop.Domain.Enums;
using Behsa.CoinShop.Domain.ValueObjects;

namespace Behsa.CoinShop.Domain.Entities;

public class User : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public Address Address { get; set; }
    public Gender Gender { get; set; }
}