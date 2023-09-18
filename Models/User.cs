using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Models
{
    [Table("users")]
    public class User : IdentityUser<int>
    {
    }
}
