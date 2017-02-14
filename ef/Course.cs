using System.Data.Linq.Mapping;

namespace csharpdemo.ef 
{
    [Table (Name ="courses")]
    class Course
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public int Fee { get; set; }
    }
}
