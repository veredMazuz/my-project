using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace serverProject.BLL
{
    [DataContract]
    public class OrderDetailDTO
    {
        [DataMember]
        public int OrderDetailID { get; set; }

        [DataMember]
        public int Quantity { get; set; }
        [DataMember]
        public OrderDTO Order { get; set; }
        [DataMember]
        public ProductDTO Product { get; set; }




        public OrderDetailDTO(Data.OrderDetail orderDetail)
        {
            this.OrderDetailID = orderDetail.OrderDetailID;
            this.Quantity = orderDetail.Quantity;
            if (orderDetail.Order != null)
            {
                this.Order = new OrderDTO(orderDetail.Order);
            }

            if (orderDetail.Product != null)
            {
                this.Product = new ProductDTO(orderDetail.Product);
            }
        }

        public Data.OrderDetail GetData()
        {
            Data.OrderDetail orderDetail = new Data.OrderDetail();
            orderDetail.OrderDetailID = this.OrderDetailID;
            orderDetail.Quantity = this.Quantity;
            orderDetail.OrderID = this.Order.OrderID;
            orderDetail.ProductID = this.Product.ProductID;
            return orderDetail;
        }

        public void FillData(Data.OrderDetail orderDetail)
        {
            orderDetail.OrderDetailID = this.OrderDetailID;
            orderDetail.Quantity = this.Quantity;
            orderDetail.OrderID = this.Order.OrderID;
            orderDetail.ProductID = this.Product.ProductID;
        }


    }
}
