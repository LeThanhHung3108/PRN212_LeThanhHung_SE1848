using OOP6_Dictionary;
using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Category c1 = new Category();
c1.Id = 1;
c1.Name = "Nước ngọt";

Product p1 = new Product();
p1.Id = 1;
p1.Name = "Pepsi";
p1.Quantity = 10;
p1.Price = 30;
c1.AddProduct(p1);

Product p2 = new Product();
p2.Id = 2;
p2.Name = "Coca";
p2.Quantity = 7;
p2.Price = 25;
c1.AddProduct(p2);

Product p3 = new Product();
p3.Id = 3;
p3.Name = "Sting";
p3.Quantity = 12;
p3.Price = 30;
c1.AddProduct(p3);

Product p4 = new Product();
p4.Id = 4;
p4.Name = "Redbull";
p4.Quantity = 18;
p4.Price = 40;
c1.AddProduct(p4);

Product p5 = new Product();
p5.Id = 5;
p5.Name = "Xá xị";
p5.Quantity = 7;
p5.Price = 25;
c1.AddProduct(p5);

Console.WriteLine("--------Thông tin danh mục--------------");
Console.WriteLine(c1);
Console.WriteLine("--------Danh sách sản phẩm--------------");
c1.PrintAllProducts();

double minPrice = 25;
double maxPrice = 30;

Dictionary<int, Product> products_by_price = c1.FilterProductsByPrice(minPrice, maxPrice);
Console.WriteLine($"Danh sách sản phẩm có giá từ {minPrice} đến {maxPrice}");
foreach(KeyValuePair<int, Product> kvp in products_by_price)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}

Dictionary<int, Product> sorted_products = c1.SortProductByPrice();
Console.WriteLine("Danh sách sản phẩm sau khi sắp xếp Gía tăng dần");
foreach (KeyValuePair<int, Product> kvp in sorted_products)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}

Dictionary<int, Product> sorted_compex_products = c1.SortComplex();
Console.WriteLine("Danh sách sản phẩm sau khi sắp xếp Gía tăng dần");
foreach (KeyValuePair<int, Product> kvp in sorted_compex_products)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}

p5.Name = "Fanta";
p5.Price = 80;
p5.Quantity = 17;
bool ret = c1.UpdateProduct(p5);
Console.WriteLine("Sản phẩm sau khi chỉnh sửa");
c1.PrintAllProducts();

int id = 5;
ret = c1.RemoveProduct(id);
if (ret == false) Console.WriteLine($"Không tìm thấy mã {id} để xóa");
else
{
    Console.WriteLine($"Đã xóa thành công sp có mã {id}: ");
    Console.WriteLine("Sản phần sau khi xóa");
    c1.PrintAllProducts();
}

//c1.RemoveProductsByPrice(30, 35);
//Console.WriteLine("Sau khi xoas gia tu 30 den 35");
//c1.PrintAllProducts();

LinkedList<Category> categories = new LinkedList<Category>();
categories.AddLast(c1);
Category c2 = new Category();
c2.Id = 2;
c2.Name = "Bia cac loai";

c2.AddProduct(new Product() {Id = 6, Name = "Tiger", Quantity = 10, Price = 300});
c2.AddProduct(new Product() { Id = 7, Name = "333", Quantity = 20, Price = 250 });
c2.AddProduct(new Product() { Id = 8, Name = "Ken", Quantity = 15, Price = 500 });

categories.AddFirst(c2);
Console.WriteLine("----Danh sách toàn bộ sản phẩm theo danh mục------");
foreach (Category c in categories)
{
    Console.WriteLine(c);
    Console.WriteLine("---------------------------------------");
    c.PrintAllProducts();
    Console.WriteLine("---------------------------------------");
}
