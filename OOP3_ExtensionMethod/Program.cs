using OOP3_ExtensionMethod;
using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;

int n1 = 5;
int n2 = 10;
Console.WriteLine($"Sum from 1 to {n1} = {n1.TongTu1toiN()}");
Console.WriteLine($"Sum from 1 to {n2} = {n2.TongTu1toiN()}");
Console.WriteLine("Sum from 1 to 8 = " + 8.TongTu1toiN());

Console.WriteLine("8 + 7 = " + 8.Cong(7));

int[] M = new int[8];
M.TaoMang();
Console.WriteLine("Mang sau khi tao ngau nhien");
M.XuatMang();
int [] M2 = M.SapXepMangGiamDan();
Console.WriteLine("Mang sau khi sap xep giam dan");
M2.XuatMang();