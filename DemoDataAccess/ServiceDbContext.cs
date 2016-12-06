using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DemoDataAccess
{
    public class ServiceDbContext : DbContext
    {

        public ServiceDbContext() : base("name=azureconnection")
        {
            
        }

        public DbSet<FundCollection> FundCollection { get; set; }
        
    }
}
