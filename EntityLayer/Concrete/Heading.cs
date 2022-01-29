using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }

        [StringLength(50)]
        public string HeadingName { get; set; }

        public DateTime HeadingDate { get; set; }

        //Category Sınıfı ile ilişki kuruldu
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        //Content sınıfı ile ilişki kuruldu
        public ICollection<Content> Contents { get; set; }

        //Writer sınıfı ile ilşki kuruldu
        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
