using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Entity
{
    public class ClientMessage
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        [Required(ErrorMessage = "Zehmet olmasa, mesaj daxil edin!")]
        public string Message { get; set; }
    }
}
