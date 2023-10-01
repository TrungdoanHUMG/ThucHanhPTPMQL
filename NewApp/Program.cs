using NewApp.Models;
using System.Collections;
// Employee emp = new Employee();
// emp.NhapTT();
// emp.HienTT();
// Student std = new Student();
// std.Nhapthongtin();
// std.Hienthongtin();
// Fruit hq = new Fruit();
// hq.Nhapttin();
// hq.Hienttin();
ArrayList psList = new ArrayList();
for(int i =0 ; i < 2 ; i++)
{
    Student ps = new Student();
    ps.Nhapthongtin();
    psList.Add(ps);   
}
foreach(Student a in psList)
{
    Console.WriteLine(a.MaSV + "-" + a.TenSV);
}