﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCoreMohamady.Models
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            base.OnConfiguring(options);
            options.UseSqlServer(Connections.SqlServerCon);
        }

        public DbSet<StudentModel> students { get; set; }
        public DbSet<GradeModel> grades { get; set; }
        public DbSet<DepartmentModel> departments { get; set; }
        public DbSet<BookModel> books { get; set; }
    }
}
