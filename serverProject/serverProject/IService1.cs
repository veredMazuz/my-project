using serverProject.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace serverProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int num();
        [OperationContract]
        int customerCount();
        //בדיקת טלפון=סיסמה של הלקוח

        [OperationContract]
        CustomerDTO GetCustomerByPhone(string phone);

        //האם קיימת הזמנה פתוחה על שם הלקוח?
        [OperationContract]
        int orderOpen(string s, int id);

        //מחזירה את ההזמנה האחרון שנוספה
        [OperationContract]
         int GetIdOrder();

        

        //כותרות לפעולות הוספה מחיקה וכו

        //לקוח

        [OperationContract]
        List<BLL.CustomerDTO> GetCustomers();

        [OperationContract]
        bool AddCustomer(BLL.CustomerDTO c);
        [OperationContract]
        bool UpDateCustomer(BLL.CustomerDTO customer);
        [OperationContract]
        bool DeleteCustomer(BLL.CustomerDTO c);

        //הזמנה

        [OperationContract]
        List<BLL.OrderDTO> GetOrder();
        [OperationContract]
        bool AddOrder(BLL.OrderDTO o);
        [OperationContract]
        bool UpDataOrder(BLL.OrderDTO order);
        [OperationContract]
         bool DeleteOrder(BLL.OrderDTO o);

        //פרטי הזמנה
        [OperationContract]
        List<BLL.OrderDetailDTO> GetOrderDetail();

        [OperationContract]
        bool AddOrderDetail(BLL.OrderDetailDTO o);

        [OperationContract]
        bool UpDataOrderDetail(BLL.OrderDetailDTO o);

        [OperationContract]
        bool DeleteOrderDetail(BLL.OrderDetailDTO o);


        //קטגוריה
        [OperationContract]
        List<BLL.CategoryDTO> GetCategories();
        [OperationContract]
        bool AddCategory(BLL.CategoryDTO c1);
        [OperationContract]
        bool UpDateCategory(BLL.CategoryDTO category);
        [OperationContract]
        bool DeleteCategory(BLL.CategoryDTO c);

        //מוצר
        [OperationContract]
        List<BLL.ProductDTO> GetProducts();
        [OperationContract]
        bool AddProduct(BLL.ProductDTO p);
        [OperationContract]
        bool UpDateProduct(BLL.ProductDTO product);
        [OperationContract]
        bool DeleteClient(BLL.ProductDTO p);

        

    }


}

