using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using serverProject.Data;

namespace HostProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var db = new CateringDBEntities())
                {
                    db.Database.Connection.Open();
                    Console.WriteLine("!!!! correct");
                }
            }
            catch (Exception ex)            
            {
                Console.WriteLine("….inCorect");
                Console.WriteLine(ex.ToString());
            }

            AppDomain.CurrentDomain.SetData("DataDirectory", AppDomain.CurrentDomain.BaseDirectory);
            ServiceHost service = new ServiceHost(typeof(serverProject.Service1));
            service.Open();
            Console.WriteLine("this is my project");
            Console.ReadLine();
        }
    }
}
