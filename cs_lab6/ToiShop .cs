using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace cs_lab6
{
    class ToiShop
    {
        List<Toi> Stoc;
        List<Customer> Customers;
        public void AddToi(Toi newToi)
        {
            Stoc.Add(newToi);
        }
        public void AddCustomer(Customer newCustomer)
        {
            Customers.Add(newCustomer);
        }
        public void RemoveToi(Toi delToi)
        {
            Stoc.Remove(delToi);
        }
        public void RemoveCustomer(Toi delCustomer)
        {
            Stoc.Remove(delCustomer);
        }
    }
}
