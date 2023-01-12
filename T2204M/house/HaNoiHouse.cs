
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using house.cm;
namespace house.hanoi
{
    public class HaNoiHouse : House
    {
        private string tenQuan;
        public string TenQuan { get; set; }

        public HaNoiHouse() { }

        public HaNoiHouse(string SoNha, string DiaChi, string LoaiNha, string tenQuan) : base(SoNha, DiaChi, LoaiNha)
        {
            this.tenQuan = tenQuan;
        }

        public override void input()
        {
            base.input();
        }

        public override void display()
        {
            base.display();
        }

    }
    internal class ManagerHouse
    {
        public ManagerHouse() { }
    }
}