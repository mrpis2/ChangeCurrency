using System;
namespace ChangeCurrency
{
class Program
{
    static void Main(string[] args)
    {
        float rate = 23000;
        float USD;
        Console.WriteLine("Nhap so luong USD: ");
        USD = float.Parse(Console.ReadLine());
        Console.WriteLine("Gia tri VND la: " + rate*USD);
    }
}
}