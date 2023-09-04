using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello World!!");
        Console.WriteLine("Nhập tên:");
        string name = Console.ReadLine();
        Console.WriteLine("Nhập nơi sinh:");
        string placeofbirth = Console.ReadLine();
        Console.WriteLine("Nhập ngày sinh:");
        string dateofbirth = Console.ReadLine();
        Console.WriteLine("Nhập tuổi:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Thông tin:" + name + " - " + placeofbirth + " - " + dateofbirth + " - " + age);
    }
}