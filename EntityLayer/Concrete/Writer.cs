using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }

        [StringLength(50)]
        public String WriterName { get; set; }

        [StringLength(50)]
        public string WriterSurName { get; set; }

        [StringLength(100)]
        public String WriterImage { get; set; }

        [StringLength(50)]
        public String WriterMail { get; set; }

        [StringLength(20)]
        public String WriterPassword { get; set; }

        //Heading sınıfı ile ilişki kuruldu
        public ICollection<Heading> headings { get; set; }

        //Writer sınıfı ile ilişki kuruldu
       public ICollection<Content> Contents { get; set; }
    }
}
