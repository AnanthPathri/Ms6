using Microsoft.EntityFrameworkCore;
using Ms6case3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ms6case3.DataAccess
{
    public class StudentDbContext : DbContext
    {

        public StudentDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<StudentModel> studentModels { get; set; }

        //  add-migration Initialmigration
        //  update-database
    }
}
