using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace LinqToDb
{
    [Table]
    public class Customer
    {
        [Column(IsPrimaryKey = true)]
        public int ID;
        [Column]
        public string Name;

        private EntitySet<Purchase> _Purchases;
        [Association(Storage = "_Purchases", OtherKey = "Customer_id")]

        public EntitySet<Purchase> Purchases
        {
            get { return this._Purchases; }
            set { this._Purchases.Assign(value); }
        }
    }
}
