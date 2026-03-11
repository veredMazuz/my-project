using serverProject.BLL;
using serverProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace serverProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        static CateringDBEntities db = new CateringDBEntities();

        //לקוח
        public List<BLL.CustomerDTO> GetCustomers()
        {
            List<Data.Customer> listS = db.Customers.ToList();
            List<BLL.CustomerDTO> listCustomer = listS.Select(x => new BLL.CustomerDTO(x)).ToList();
            return listCustomer;
        }

        public bool AddCustomer(BLL.CustomerDTO c)
        {
            Data.Customer cc = c.GetData();
            db.Customers.Add(cc);
            int result = db.SaveChanges();
            return result > 0;

        }

        public bool UpDateCustomer(BLL.CustomerDTO customer)
        {
            Data.Customer cDate = db.Customers.FirstOrDefault(x => x.CustomerID == customer.CustomerID);
            customer.FillData(cDate);
            int result = db.SaveChanges();
            return result > 0;
        }

        public bool DeleteCustomer(BLL.CustomerDTO c)
        {
            Data.Customer cData = db.Customers.FirstOrDefault(x => x.CustomerID == c.CustomerID);
            db.Customers.Remove(cData);
            int result = db.SaveChanges();
            return result > 0;

        }

        //הזמנה
        public List<BLL.OrderDTO> GetOrder()
        {
            List<Data.Order> listS = db.Orders.ToList();
            List<BLL.OrderDTO> ListOrder = listS.Select(x => new BLL.OrderDTO(x)).ToList();
            return ListOrder;
        }

        public bool AddOrder(BLL.OrderDTO o)
        {
            Data.Order oo = o.GetData();
            db.Orders.Add(oo);
            int result = db.SaveChanges();
            return result > 0;
        }





        public bool UpDataOrder(BLL.OrderDTO order)
        {
            Data.Order oData = db.Orders.FirstOrDefault(x => x.OrderID == order.OrderID);
            order.FillData(oData);
            int result = db.SaveChanges();
            return result > 0;
        }

        public bool DeleteOrder(BLL.OrderDTO o)
        {
            Data.Order oData = db.Orders.FirstOrDefault(x => x.OrderID == o.OrderID);
            db.Orders.Remove(oData);
            int result = db.SaveChanges();
            return result > 0;
        }

        //פרטי הזמנה
        public List<BLL.OrderDetailDTO> GetOrderDetail()
        {
            List<Data.OrderDetail> lists = db.OrderDetails.ToList();
            List<BLL.OrderDetailDTO> listOrderDetail = lists.Select(x => new BLL.OrderDetailDTO(x)).ToList();
            return listOrderDetail;
        }

        public bool AddOrderDetail(BLL.OrderDetailDTO o)
        {
            Data.OrderDetail od = o.GetData();
            db.OrderDetails.Add(od);
            int result = db.SaveChanges();
            return result > 0;
        }

        public bool UpDataOrderDetail(BLL.OrderDetailDTO o)
        {
            Data.OrderDetail orderDetail = db.OrderDetails.FirstOrDefault(x => x.OrderDetailID == o.OrderDetailID);
            o.FillData(orderDetail);
            int result = db.SaveChanges();
            return result > 0;
        }

        public bool DeleteOrderDetail(BLL.OrderDetailDTO o)
        {
            Data.OrderDetail oData = db.OrderDetails.FirstOrDefault(x => x.OrderDetailID == o.OrderDetailID);
            db.OrderDetails.Remove(oData);
            int result = db.SaveChanges();
            return result > 0;
        }



        //קטגוריה
        public List<BLL.CategoryDTO> GetCategories()
        {
            List<Data.Category> listS = db.Categories.ToList();
            List<BLL.CategoryDTO> listcategory = listS.Select(x => new BLL.CategoryDTO(x)).ToList();
            return listcategory;
        }

        public bool AddCategory(BLL.CategoryDTO c1)
        {
            Data.Category category1 = c1.GetData();
            db.Categories.Add(category1);
            int result = db.SaveChanges();
            return result > 0;
        }

        public bool UpDateCategory(BLL.CategoryDTO category)
        {
            Data.Category cData = db.Categories.FirstOrDefault(x => x.CategoryID == category.CategoryID);
            category.FillData(cData);
            int result = db.SaveChanges();
            return result > 0;

        }

        public bool DeleteCategory(BLL.CategoryDTO c)
        {
            Data.Category cData = db.Categories.FirstOrDefault(x => x.CategoryID == c.CategoryID);
            db.Categories.Remove(cData);
            int result = db.SaveChanges();
            return result > 0;

        }

        //מוצר
        public List<BLL.ProductDTO> GetProducts()
        {
            List<Data.Product> listS = db.Products.ToList();
            List<BLL.ProductDTO> listProduct = listS.Select(x => new BLL.ProductDTO(x)).ToList();
            return listProduct;
        }

        public bool AddProduct(BLL.ProductDTO p)
        {
            Data.Product pp = p.GetData();
            db.Products.Add(pp);
            int result = db.SaveChanges();
            return result > 0;
        }

        public bool UpDateProduct(BLL.ProductDTO product)
        {
            Data.Product pData = db.Products.FirstOrDefault(x => x.ProductID == product.ProductID);
            product.FillData(pData);
            int result = db.SaveChanges();
            return result > 0;
        }

        public bool DeleteClient(BLL.ProductDTO p)
        {
            Data.Product pData = db.Products.FirstOrDefault(x => x.ProductID == p.ProductID);
            db.Products.Remove(pData);
            int result = db.SaveChanges();
            return result > 0;


        }







        public int num()
        { return 50; }

        public int customerCount()
        {
            using (var db = new CateringDBEntities())


                //var list = db.Customers.ToList();
                //Console.WriteLine(list.Count);
                return db.Customers.Count();


        }
        //בדיקת טלפון=סיסמה של הלקוח
        public CustomerDTO GetCustomerByPhone(string phone)
        {
            Data.Customer customer = db.Customers.FirstOrDefault(i => i.Phone == phone);
            if (customer == null)
                return null;

            return new CustomerDTO(customer);

        }

        //האם קיימת הזמנה פתוחה על שם הלקוח?
        public int orderOpen(string s,int id)
        {
            Data.Order order = db.Orders.FirstOrDefault(o => o.CustomerID == id && o.ShabbatParsha.Equals(s));
            if (order == null)
                return -1;
            return order.OrderID;

        }

       



        //מחזירה את ההזמנה האחרונה שנוספה 
        public int GetIdOrder()
        {
            int count = db.Orders.Count();
            Order order1 = db.Orders
                    .OrderByDescending(o => o.OrderDate) // מיון מהחדש לישן
                    .FirstOrDefault();
            //Order order1 = db.Orders.Last();
            OrderDTO order=new OrderDTO(order1);
            return  order.OrderID;

        }



    }


    

}
 

