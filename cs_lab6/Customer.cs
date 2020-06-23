using System;
using System.Data.SqlClient;

namespace cs_lab6
{
    class Customer
    {
        int id { get; set; }
        string name { get; set; }
        float discount { get; set; }
        public Customer(int ID, string NAME)
        {
            id = ID;
            name = NAME;
            discount = 0;
        }
    }
}
