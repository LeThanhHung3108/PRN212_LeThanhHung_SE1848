using OOP2;
using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;

FulltimeEmployee obama = new FulltimeEmployee();

obama.Id = 1;
obama.IdCard = "124";
obama.Name = "Barac Obama";
obama.Birthday = new DateTime(1960, 12, 25);
Console.WriteLine("Thông tin của Obama");
Console.WriteLine("ID = " + obama.Id);
Console.WriteLine("ID Card = " + obama.IdCard);
Console.WriteLine("Name = " + obama.Name);
Console.WriteLine("Birthday = " + obama.Birthday.ToString("dd/MM/yyyy"));
Console.WriteLine("Salary of Obama => " + obama.calSalary());

Console.WriteLine("------------------------------------Information of Obama 2 ---------------------------------------");   
Console.WriteLine(obama);

ParttimeEmployee trump = new ParttimeEmployee()
{
    Id = 2,
    IdCard = "456",
    Name = "Donal Trump",
    Birthday = new DateTime(1954, 1, 15),
    WorkingHour = 2
};
Console.WriteLine("Thông tin của Trump");
Console.WriteLine("ID = " + trump.Id);
Console.WriteLine("ID Card = " + trump.IdCard);
Console.WriteLine("Name = " + trump.Name);
Console.WriteLine("Birthday = " + trump.Birthday.ToString("dd/MM/yyyy"));
Console.WriteLine("Salary of Obama => " + trump.calSalary());

Console.WriteLine("------------------------------------Information of Trump 2 ---------------------------------------");
Console.WriteLine(trump);
