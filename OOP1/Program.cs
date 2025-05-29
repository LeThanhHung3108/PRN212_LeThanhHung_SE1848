using OOP1;
using System.Text;
Console.OutputEncoding=Encoding.UTF8;

//Create object Category 1

Category c1 = new Category();
c1.Id = 1;
c1.Name = "Nuoc mam";

//Output information by call function 
c1.PrintInfor();

//Suppose we change value in ô nhớ đó
c1.Name = "Dầu ăn";
Console.WriteLine("Sau khi đổi giá trị: ");
c1.PrintInfor();

//using Employee class
Console.WriteLine("--------------ENPLOYEE 1---------------------");
Employee emp1 = new Employee();
emp1.Id = 1; // gọi setter property của Id
emp1.IdCard = "001"; // gọi setter property của IdCard 
emp1.Name = "Hung"; // gọi setter property của Name
emp1.Email = "hung@gmail.com"; // gọi setter property của Email
emp1.Phone = "0344309959"; // gọi setter property của Phone

// Xuất thông tin 
emp1.PrintInfor();

Employee emp2 = new Employee()
{
    Id = 2,
    IdCard = "002",
    Name = "Tu",
    Email = "tu@gmail.com",
    Phone = "0344309929",
};

Console.WriteLine("--------------ENPLOYEE 2---------------------");
emp2.PrintInfor();

Console.WriteLine("--------------ENPLOYEE 3 ---------------------");
Employee emp3 = new Employee();
emp3.PrintInfor();

//create employee 4
Console.WriteLine("--------------ENPLOYEE 4 ---------------------");
Employee emp4 = new Employee(4, "004", "Duan", "duan@gmail.com", "0345265345");
emp4.PrintInfor();
Console.WriteLine("--------------ENPLOYEE 4 Cach 2 ---------------------");
Console.WriteLine(emp4);

Console.WriteLine("-------------------Customer 1 ----------------------");
Customer cus1 = new Customer()
{
    Id = "Cus1",
    Name = "Le Thanh Hung",
    Email = "Hung@gmail.com",
    Phone = "0344309959",
    Address = "So 5, lo lu, truong thanh, quan 9"
};
cus1.PrintInfor();
cus1.Address = "48/17 so  5, lo lu, truong thanh, quan 9, tp Ho Chi Minh";
Console.WriteLine("---------------Customer after edit Address----------------");
cus1.PrintInfor();