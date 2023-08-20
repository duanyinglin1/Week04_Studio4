using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Week04_Studio4.Models
{
    public class CodeFirst : DbContext
    {
        public CodeFirst(): base("FIT5032_MyModelFirst") {}

        public DbSet<Student> Students { get; set; }
        public DbSet<Unit> Units { get; set; }

    }
}