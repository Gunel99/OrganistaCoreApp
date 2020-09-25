using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Entity
{
    public class Newsletter
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please, add your email!"), EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
