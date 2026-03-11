using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace serverProject.BLL
{
    [DataContract]
    public class ProductDTO
    {
        [DataMember]
        public int ProductID { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public byte[] image { get; set; }
      
       

        public ProductDTO(Data.Product p)
        {
            this.ProductID = p.ProductID;
            this.ProductName = p.ProductName;
            this.Description = p.Description;
            this.Price = p.Price;
            this.image = p.image;
        }

        public Data.Product GetData()
        {
            Data.Product p = new Data.Product();
            p.ProductID = this.ProductID;
            p.ProductName = this.ProductName;
            p.Description = this.Description;
            p.Price = this.Price;
            p.image = this.image;
            return p;

        }

        public void FillData(Data.Product p)
        {
            p.ProductID = this.ProductID;
            p.ProductName = this.ProductName;
            p.Description = this.Description;
            p.Price = this.Price;
            p.image = this.image;
        }
    }
}
