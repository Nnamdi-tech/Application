using Code360.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Code360.Data
{
  public  class Code360DBContext: DbContext
    {
      public  DbSet<Student> Students { get; set; }
      public  DbSet<Batch> Batches { get; set; }
      public DbSet<Employment> Employments { get; set; }
      

    }
}
