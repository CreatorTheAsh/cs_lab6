using System;
using System.Data.SqlClient;

namespace cs_lab6
{
    class Toi
    {
        int id { get; set; }
        string name { get; set; }
        public Toi(int ID, string NAME)
        {
            id = ID;
            name = NAME;
        }
    }
}
