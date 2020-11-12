using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoCurriculum.Models;

namespace ProjetoCurriculum.Models
{
    public class Register
    {
        public int Id { get; set; }

        public DateTime LoanDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime ExpectedDate { get; set; }


        public virtual User Users {get; set;}
        public virtual Curriculum Curriculums { get; set; }



    }
}
