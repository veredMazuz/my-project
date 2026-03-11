using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace serverProject.BLL
{
    [DataContract]
    public class CategoryDTO
    {
        [DataMember]
        public int CategoryID { get; set; }
        [DataMember]
        public string CategoryName { get; set; }
        


        public CategoryDTO(Data.Category c)
        {
            this.CategoryID = c.CategoryID;
            this.CategoryName = c.CategoryName;
            
        }

        public Data.Category GetData()
        {
            Data.Category category = new Data.Category();
            category.CategoryID = this.CategoryID;
            category.CategoryName = this.CategoryName;
           return category;
        }

        public void FillData(Data.Category category)
        {
            category.CategoryID = this.CategoryID;
            category.CategoryName = this.CategoryName;
           
                    
            
        }

    }
}
