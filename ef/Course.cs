

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharpdemo.ef 
{
    class Course
    {
        [Key]
        public string Code { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public int Fee { get; set; }
    }
}
