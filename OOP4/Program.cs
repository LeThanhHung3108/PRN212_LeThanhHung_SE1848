using OOP2;
using OOP4_Reuse_OOP2;
using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;

FulltimeEmployee fe = new FulltimeEmployee()
{
    Id = 1,
    IdCard = "123",
    Name = "Hung",
    Birthday = new DateTime(1952, 12,25),
};
Console.WriteLine(fe);
Console.WriteLine("AGE = " +fe.Tuoi());
if (fe.CheckMonthBirthday())
{
    Console.WriteLine("Thang nay la thang sinh nhat cua nhan vien");
}
else
{
    Console.WriteLine("Thang nay khong phai la thang sinh nhat cua nhan vien");
}
