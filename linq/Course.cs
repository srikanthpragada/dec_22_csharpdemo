using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    [Table (Name ="courses")]
    class Course
    {
        [Column (IsPrimaryKey = true)]
        public string Code { get; set; }

        [Column (Name ="Title")]
        public string Title { get; set; }

        [Column]
        public int Duration { get; set; }

        [Column]
        public int Fee { get; set; }
    }
}
