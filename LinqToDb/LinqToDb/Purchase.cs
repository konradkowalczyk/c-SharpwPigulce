using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToDb
{
    [Table]
    public class Purchase
    {
        [Column(IsPrimaryKey = true)]
        public int ID;
        [Column]
        public decimal Price;
        [Column]
        public int Customer_id;
    }
}

