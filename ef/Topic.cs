using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.ef
{
    class Topic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Column("Course")]
        public Course Course { get; set; }
    }
}
