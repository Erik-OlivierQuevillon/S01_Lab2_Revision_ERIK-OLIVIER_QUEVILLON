using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;

namespace ZombieParty.Models
{
    public class ZombieType
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Type Name has to be filled")]
        public string TypeName { get; set; }
    }
}
