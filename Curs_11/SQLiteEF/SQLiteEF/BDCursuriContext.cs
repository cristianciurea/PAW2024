using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace SQLiteEF
{
    class BDCursuriContext : DbContext
    {
        //public BDCursuriContext()
        //    : base("BDCursuri")
        //{
        //}

        public BDCursuriContext()
            : base("conString")
        {
        }

        public DbSet<Curs> Cursuri { get; set; }

        public DbSet<Student> Studenti { get; set; }
    }
}
