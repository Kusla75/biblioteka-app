using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Data.SqlClient;
using ClassLibrary;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(Servis)))
            {
                host.Open();

                Console.WriteLine("Server je u toku rada!");
                Console.ReadKey(true);

            }
        }
    }
}
