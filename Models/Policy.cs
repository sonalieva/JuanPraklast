using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Juanprak.Models
{
    public class Policy
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 35)]
        public string Title { get; set; }

        [StringLength(maximumLength: 55)]
        public string Desc { get; set; }
        [StringLength(maximumLength: 50)]
        public string Icon { get; set; }
    }
}
