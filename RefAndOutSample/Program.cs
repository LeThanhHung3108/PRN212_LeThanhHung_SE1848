using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;

void ham1(int n)
{
    n = 8;
    Console.WriteLine($"n trong ham = {n}");
}

int n = 5;
Console.WriteLine($"n truoc khi vao ham = {n}");
ham1(n);
Console.WriteLine($"n sau khi vao ham = {n}");

void ham2 (ref int n)
{
    n = 8;
    Console.WriteLine($"n trong ham = {n}");
}
Console.WriteLine("-------------------------------------------------");
n = 5;
Console.WriteLine($"n truoc khi vao ham = {n}");
ham2 (ref n);
Console.WriteLine($"n sau khi vao ham = {n}");

//int m;
//ham2(ref m);
// Lỗi vì m chưa có giá trị ban đầu, ref yêu cầu biến đó phải có giá trị ban đầu.

//out thì không cần giá trị ban đầu
//nhưng khi vào hàm phải có giá trị mới 
//còn ref thì yêu cầu giá trị ban đầu 
//nhưng khi vào hàm không cần phải có giá trị mới 
void ham3(out int n)
{
    n = 9; 
}

n = 113;
ham3(out n);