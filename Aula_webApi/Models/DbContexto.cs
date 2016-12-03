using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Aula_webApi.Models
{
    public class DbContexto : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public DbContexto() : base("name=Aula_webApiContext")
        {
        }

        public System.Data.Entity.DbSet<Aula_webApi.Models.Pessoa> Pessoas { get; set; }
    }
}
