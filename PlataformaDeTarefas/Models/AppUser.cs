using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace PlataformaDeTarefas.Models;
public class AppUser : IdentityUser
{
    [Required]
    [StringLength(100)]
    public int Name { get; set; }

    [StringLength(300)]
    public string ProfilePicture { get; set; }
}