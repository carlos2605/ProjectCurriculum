using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CVAPI.Models
{
    public class User
    {
        public int Id { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public ICollection<CurriculumVitae> CurriculumVitaes { get; set; }
        public ICollection<Setting> Settings { get; set; }
    }
}
