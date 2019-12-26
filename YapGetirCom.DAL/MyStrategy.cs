using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Model;


namespace YapGetirCom.DAL
{
    class MyStrategy: DropCreateDatabaseIfModelChanges<YapGetirDbContext>
    {
       
    }
}
