using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Logging.Response
{
    public partial class Response_DL
    {
        LogDb logDb;
        public Response_DL()
        {
            logDb = new LogDb();
        }

        public void SaveChanges()
        {
            logDb.SaveChanges();
        }
    }
}
