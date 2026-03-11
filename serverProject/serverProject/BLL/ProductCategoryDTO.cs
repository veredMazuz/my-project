using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace serverProject.BLL
{
    [DataContract]
    public class ProductCategoryDTO
    {
        [DataMember]
        public string ID { get; set; }
        [DataMember]
        public int ProductID { get; set; }
        [DataMember]
        public int CategoryID { get; set; }
        [DataMember]
        public BLL.CategoryDTO Category { get; set; }
        [DataMember]
        public BLL.ProductDTO Product { get; set; }

        public ProductCategoryDTO(Data.ProductCategory pc)
        {
            this.ID=pc.ID;
            this.ProductID=pc.ProductID;
            this.CategoryID=pc.CategoryID;
            if(pc.Category != null)
                this.Category=new CategoryDTO(pc.Category);
            if(pc.Product != null)
                this.Product=new ProductDTO(pc.Product);
        }

        public Data.ProductCategory GetData() 
        {
            Data.ProductCategory pc=new Data.ProductCategory();
            pc.ID=this.ID;
            pc.ProductID=this.ProductID;
            pc.CategoryID=this.CategoryID;
            pc.ProductID = this.Product.ProductID;
            pc.CategoryID=this.Category.CategoryID;
            return pc;
        }

        public void FillData(Data.ProductCategory pc)
        {
            pc.ID= this.ID;
            pc.ProductID = this.ProductID;
            pc.CategoryID= this.CategoryID;
        }
        


    }
}
