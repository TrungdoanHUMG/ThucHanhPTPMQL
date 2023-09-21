namespace NewApp.Models
{   
            public class Student
            {
            public string MaSV { get; set; }
            public string TenSV { get; set; }
            
                    public void Nhapthongtin(){
                        
                            System.Console.Write(" StudentID = ");
                            MaSV = Console.ReadLine();
                            System.Console.Write("Full Name = ");
                            TenSV = Console.ReadLine();                                       
                        }
                    public void Hienthongtin()
                    {
                        System.Console.WriteLine(MaSV + "-" + TenSV);
                    }    
            }   
}    
            