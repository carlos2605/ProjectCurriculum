using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVAPI.Models
{
    public class Setting
    {
        public int Id { get; set; }
        public decimal Salary { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime ResignationDate
        { get; set; }

        public virtual User User { get; set; }
        public virtual CurriculumVitae CurriculumVitae { get; set; }
    }
}
