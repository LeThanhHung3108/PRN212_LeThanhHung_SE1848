using System.Diagnostics.CodeAnalysis;

(int, double) sumAndAverage(params int[] values)
{
    int sum = 0;
    double avg = 0;
    foreach(int i in values)
    {
        sum += i;
    }
    avg = sum/values.Length;
    return (sum, avg);

}

int[] values = new int[10];
void create_array(int[] values)
{
    Random rd=new Random();
    for(int i = 0; i < values.Length; i++)
    {
        values[i] = rd.Next(100);
    }
}

void print_array(int[] values)
{
    foreach(int value in values)
    {
        Console.WriteLine($"{value}\t");
    }
}

create_array(values);
print_array(values);
Console.WriteLine("\nThong tin sum + avg:");
(int s, double avg) = sumAndAverage(values);
Console.WriteLine($"SUM = {s}");
Console.WriteLine($"AVG = {avg}");