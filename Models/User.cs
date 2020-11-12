using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCurriculum.Models
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

        public ICollection<Curriculum> Curriculums { get; set; }

        public ICollection<Register> Registers { get; set; }
    }
}
