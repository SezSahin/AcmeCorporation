using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Model
{
    public class Ticket
    {
        public Guid Id { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [StringLength(11)]
        public string PhoneNumber { get; set; }
        public string DateOfBirth { get; set; }
        [Required]
        public string SerialNumber { get; set; }
    }
}
