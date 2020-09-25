using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrganistaProject.Entity
{
    public class MessageFromPage
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        [Required(ErrorMessage = "Please, add your email!"), EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Subject { get; set; }
        [Required(ErrorMessage = "Please, add your message!")]
        public string Message { get; set; }
        public bool IsRead { get; set; }
        public bool IsResponsed { get; set; }
    }
}
