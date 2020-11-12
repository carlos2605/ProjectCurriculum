using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCurriculum.Models
{
    public class Curriculum
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Authors { get; set; }
        public string smallThubmanail { get; set; }
        public string Descripition { get; set; }
        public string Isbn_10 { get; set; }
        public string Isbn_13 { get; set; }
        public string Publisher { get; set; }
        public int Pagecount { get; set; }
        public string Thumbnail{ get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime PublishedDate { get; set; }

        public virtual User Users { get; set; }
        public ICollection<Register> Registers { get; set; }
    }
}
