using NewApp.Models;

// Employee emp = new Employee();
// emp.NhapTT();
// emp.HienTT();
// Student std = new Student();
// std.Nhapthongtin();
// std.Hienthongtin();
// Fruit hq = new Fruit();
// hq.Nhapttin();
// hq.Hienttin();
int n ; 
System.Console.WriteLine("n = ");
n = Convert.ToInt16(Console.ReadLine());
int[] intArr = new int[n];
for(int i =0 ; i < intArr.Length ; i++)
{
    intArr[i] = i*2 ;
}
for(int i =0 ; i < intArr.Length ; i++)
{
    System.Console.WriteLine("Mang ["+ i + "] = " + intArr[i]);
}