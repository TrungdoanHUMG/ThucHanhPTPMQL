using System.Runtime.Intrinsics.Arm;

namespace NewApp.Models
{
    public class Fruit
    {
        public string Tao { get; set; }
        public string chuoi { get; set; }

            public void Nhapttin()
            {
                System.Console.Write("SL Tao = ");
                Tao = Console.ReadLine();
                System.Console.Write("SL Chuoi = ");
                chuoi = Console.ReadLine();
            }
            public void Hienttin()
            {
                System.Console.WriteLine(Tao + "-" + chuoi);
            }
    }
}