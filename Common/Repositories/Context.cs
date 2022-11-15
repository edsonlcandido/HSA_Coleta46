using Common.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;

namespace Common.Repositories
{
    public class Context : DbContext
    {
        public Context():base(new SQLiteConnection(@"Data Source=HSA_Coleta.db;"),false)
        //public Context() : base("HSA_Coleta")
        {
            
        }
        public virtual DbSet<UsuarioModel> usuario  { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<UsuarioModel>();
        }
    }
}
