using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToDb
{
    public static class DataContextHelper
    {
        public static DataContext GetDataContext()
        {
            return new DataContext(@"Data Source=DESKTOP-80FAI3R\SQLEXPRESS;Initial Catalog=RestfulServiceDatabase;User ID=sa;Password=Password123");
        }

    }
}
