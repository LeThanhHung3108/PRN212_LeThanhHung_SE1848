using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6_Dictionary
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<int, Product> Products { get; set; }
        public Category() { 
             Products = new Dictionary<int, Product>();
        }
        public override string ToString()
        {
            return $"{Id}\t{Name}";
        }
        /*
         Khi quản lý mọi đối tượng ta đều phải đáp ứng đầy đủ tính năng CRUD
         */
        public void AddProduct(Product p)
        {
            //Kiểm tra nếu Id của Product chưa tồn tại
            //thì thêm mới:
            if(p == null)
            {
                return; //Dữ liệu đầu vào null
            }
            if (Products.ContainsKey(p.Id))
            {
                return; //Id đã tồn tại thì ko thêm
            }
            //thêm mới Product vào Dictionary
            Products.Add(p.Id, p);
        }

        //Xuất toàn bộ sản phẩm 
        public void PrintAllProducts()
        {
            foreach(KeyValuePair<int,Product> kvp in Products)
            {
                Product p = kvp.Value;
                Console.WriteLine(p);
            }
        }

        //Lọc các sản phẩm có giá từ min ts max 
        public Dictionary<int, Product>FilterProductsByPrice(double min, double max)
        {
            return Products
                   .Where(item => item.Value.Price >= min && item.Value.Price <= max)
                   .ToDictionary<int, Product>();
        }
        //Sắp xếp sản phẩm theo đoewn giá tăng dần
        public Dictionary<int, Product> SortProductByPrice()
        {
            return Products
                           .OrderBy(item =>  item.Value.Price)
                           .ToDictionary<int,Product>();
        }

        public Dictionary<int, Product> SortComplex()
        {
            return Products
                           .OrderByDescending(item => item.Value.Quantity)
                           .OrderBy(item => item.Value.Price)
                           .ToDictionary<int, Product>();
        }

        //Sửa 1 sản phẩm mới
        public bool UpdateProduct(Product p)
        {
            if(p == null)
                return false;
            
            if(Products.ContainsKey(p.Id) == false)
            {
                return false ;
            }
            //cập nhật giá trị tại ô nhớ chứa p.Id
            Products[p.Id] = p;
            return true; // đánh dấu là sử thành công
        }

        public bool RemoveProduct(int id)
        {
            if (Products.ContainsKey(id) == false) return false;
            Products.Remove(id);
            return true;
            
        }

        //Viết hàm xóa các sản phẩm có giá từ a ts b
        public void RemoveProductsByPrice(double minPrice, double maxPrice)
        {
            foreach(KeyValuePair<int, Product> kvp in Products)
            {
                if(kvp.Value.Price >= minPrice && kvp.Value.Price <= maxPrice)
                {
                    Products.Remove(kvp.Value.Id);
                }
            }
        }
    }
}
