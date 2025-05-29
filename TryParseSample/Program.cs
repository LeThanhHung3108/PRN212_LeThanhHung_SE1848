/*
 Nhập vào một số >= 0, nếu nhập sai bắt nhập lại
 Nếu nhập đúng tính giai thừa của nó
 */

int n = -1;
while(n < 0)
{
    Console.WriteLine("Input n >= 0");
    String s = Console.ReadLine();
    if(int.TryParse(s, out n) == false)
    {
        Console.WriteLine("You must to input number");
    }
    else
    {
        if(n <0)
        {
            Console.WriteLine("You must to input number >= 0");
        }
    }
}

int gt = 1;
for(int i = 1; i <= n; i++)
{
    gt *= i;
}
Console.WriteLine($"{n}! = {gt}");