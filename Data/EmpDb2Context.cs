﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppGitExercise2.Data
{
    public class EmpDb2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public EmpDb2Context() : base("name=EmpDb2Context")
        {
        }

        public System.Data.Entity.DbSet<WebAppGitExercise2.Models.Emp> Emps { get; set; }
    }
}
