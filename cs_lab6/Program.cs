using System;
using System.Threading.Tasks.Dataflow;

namespace cs_lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithDB MyDB = new WorkWithDB();
            //MyDB.AddCustomer
            //MyDB.AddToi
            //MyDB.Command
            //MyDB.RemoveCustomer
            //MyDB.RemoveToi
            int temp;
            do
            {
                Console.WriteLine("0 - Exit\n1 - AddCustomer\n2 - AddToi\n3 - RemoveCustomer\n4 - RemoveToi\n5 - Command");
                int.TryParse(Console.ReadLine(), out temp);
                switch (temp)
                {
                    case 0: break;
                    case 1: MyDB.AddCustomer(); break;
                    case 2: MyDB.AddToi(); break;
                    case 3: MyDB.RemoveCustomer(); break;
                    case 4: MyDB.RemoveToi(); break;
                    case 5: MyDB.Command(); break;
                    default: break;
                }
            }
        }
    }
}
