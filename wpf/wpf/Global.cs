using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf.ServiceReference1;
namespace wpf
{
   public class Global
    {
        public static ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
        public static CustomerDTO customerDTO = new CustomerDTO();
        public static OrderDTO orderDTO = new OrderDTO();
        public static string ShabbatParsha;

       
    }
}

