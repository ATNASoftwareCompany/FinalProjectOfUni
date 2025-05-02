using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Logging.Request
{
    public partial class Request_DL
    {
        LogDb logDb;
        public Request_DL()
        {
            logDb = new LogDb();
        }

        public void SaveChanges()
        {
            logDb.SaveChanges();
        }
    }
}
