using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace serverProject.BLL
{
    [DataContract]
    public class CustomerDTO
    {
        [DataMember]
        public int CustomerID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string Address { get; set; }

        public CustomerDTO(Data.Customer customer)
        {
            this.CustomerID = customer.CustomerID;
            this.Name = customer.Name;
            this.Phone = customer.Phone;
            this.Address = customer.Address;
        }

        public Data.Customer GetData()
        {
            Data.Customer customer = new Data.Customer();
            customer.CustomerID = this.CustomerID;
            customer.Name = this.Name;
            customer.Phone = this.Phone;
            customer.Address = this.Address;
            return customer;
        }

        public void FillData(Data.Customer customer)
        {
            customer.CustomerID = this.CustomerID;
            customer.Name = this.Name;
            customer.Phone = this.Phone;
            customer.Address = this.Address;
        }
    }
}
