   
namespace NewApp.Models
{
    public class Employee
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public int Tuoi { get; set; }
        public string Luong { get; set; }
    
        public void NhapTT(){
                Console.Write("Ma NV = ");
                MaNV = Console.ReadLine();
                System.Console.Write("Ten NV = ");
                TenNV = Console.ReadLine();
                System.Console.Write("Tuoi = ");
                Tuoi = Convert.ToInt16(Console.ReadLine());
                System.Console.Write("luong = ");
                Luong = Console.ReadLine();
        }
        public void HienTT(){
            
                System.Console.Write(MaNV + "-" + TenNV + "-" + Tuoi + "-" + Luong );
            
        }
            
    }
}