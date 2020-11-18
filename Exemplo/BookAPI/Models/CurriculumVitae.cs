using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVAPI.Models
{
    public class CurriculumVitae
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Education { get; set; }
        public string Description { get; set; }
        public string Experience { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public virtual User Users { get; set; }
        public ICollection<Setting> Settings { get; set; }
    }
}
