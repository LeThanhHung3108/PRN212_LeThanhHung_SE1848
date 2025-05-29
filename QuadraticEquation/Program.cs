// See https://aka.ms/new-console-template for more information
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

void giai_bac1(double a, double b)
{
    if(a == 0 &&  b == 0)
    {
        Console.WriteLine("Phương trình vô số nghiệm");
    }else if(a == 0 && b != 0){
        Console.WriteLine("Phương trình vô nghiệm");
    }else {
        Console.WriteLine("X = {0}", -b/a);
    }

}

void giai_bac2(double a, double b, double c)
{
    if(a == 0)
    {
        giai_bac1(b, c);
    }
    else
    {
        var delta = Math.Pow(b, 2) - 4 * a * c;
        if(delta < 0)
        {
            Console.WriteLine("Phương trình vô nghiệm");
        }else if(delta == 0)
        {
            Console.WriteLine("Phương trình có nghiệm kép: X = {0}", -b/(2*a));
        }else
        {
            var x1 = (-b - Math.Sqrt(delta)) / (2*a);
            var x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("Phương trình có hai nghiệm phân biệt");
            Console.WriteLine("X1 = {0} \nX2 = {1}", x1, x2);
        }
    }
}

Console.WriteLine("Phương trình bậc hai một ẩn ax^2 + bx + c = 0");
Console.WriteLine("Nhập hệ số a: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Nhập hệ số b: ");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Nhập hệ số c: ");
double c = double.Parse(Console.ReadLine());
Console.WriteLine("{0}x^2 + {1}x + {2} = 0", a,b,c);

giai_bac2(a, b, c);
Console.ReadLine();