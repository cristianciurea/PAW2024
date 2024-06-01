using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteEF
{
    class Curs
    {
        public long Id { get; set; }
 
        public string Name { get; set; }
 
        public string Url { get; set; }
 
        public List<Student> Students { get; set; }
    }
}
