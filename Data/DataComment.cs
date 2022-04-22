#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TINTUC.Models;

    public class DataComment : DbContext
    {
        public DataComment (DbContextOptions<DataComment> options)
            : base(options)
        {
        }
        public DbSet<TINTUC.Models.Comment> comment { get; set; }
    }
