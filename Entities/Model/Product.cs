using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Model
{
    public class Product
    {
        [Key]
        public Guid SerialNumber { get; set; }
        public long Id { get; set; }
    }
}
