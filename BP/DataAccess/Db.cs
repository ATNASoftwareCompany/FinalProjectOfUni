using DataModel;
using DataModel.Logging;
using DataModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AppDb : DbContext
    {
        public AppDb() :base("name=Appconstr")
        {
                
        }

        public DbSet<User_VM> Users { get; set; }
        public DbSet<Access_VM> Access { get; set; }
        public DbSet<Person_VM> Persons { get; set; }
        public DbSet<Action_VM> Actions { get; set; }
        public DbSet<Activation_VM> Activations { get; set; }
    }

    public class LogDb : DbContext
    {
        public LogDb() : base("name=Logconstr")
        {

        }

        public DbSet<RequestBaseLog_VM> RequestLog { get; set; }

        public DbSet<ResponseBaseLog_VM> responseLog { get; set; }

    }
}
