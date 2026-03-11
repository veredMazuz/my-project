using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace serverProject.BLL
{
    [DataContract]
    public class OrderDTO
    {
        [DataMember]
        public int OrderID { get; set; }
        [DataMember]
        public System.DateTime OrderDate { get; set; }
        [DataMember]
        public string ShabbatParsha { get; set; }
        
        [DataMember]
        public BLL.CustomerDTO Customer  { get; set; }

        public OrderDTO(Data.Order o)
        {
            this.OrderID = o.OrderID;
            this.OrderDate = o.OrderDate;
            this.ShabbatParsha = o.ShabbatParsha;
            if (o.Customer != null)
                this.Customer = new CustomerDTO(o.Customer);
        }

        public Data.Order GetData()
        {
            Data.Order o = new Data.Order();
            o.OrderID = this.OrderID;
            o.OrderDate = this.OrderDate;
            o.ShabbatParsha = this.ShabbatParsha;
            o.CustomerID = this.Customer.CustomerID;
            return o;

        }

        public void FillData(Data.Order O)
        {
            O.OrderID = this.OrderID;
            O.OrderDate = this.OrderDate;
            O.ShabbatParsha = this.ShabbatParsha;
            O.CustomerID = this.Customer.CustomerID;
        }




    }
}
