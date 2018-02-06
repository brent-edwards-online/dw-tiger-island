using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace tiger_island.Context
{
    public class TigerIslandContext : DbContext      
    {
        const string localConn = "Data Source=localhost;Initial Catalog=dreamworld-marketing;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        const string remoteConn = "Server=tcp:dw-forms.database.windows.net,1433;Initial Catalog=dw-forms;Persist Security Info=False;User ID =uatuser; Password=3SS1money; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30";

    public TigerIslandContext()
            : base(remoteConn)
        {
        }
        
        public DbSet<TigerCubNameCompetition> TigerCubNameCompetitionEntries { get; set; }
    }
}