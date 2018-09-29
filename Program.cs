using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct giapha                               //Dinh nghia cau truc cay gia pha
{
    public string hoten,honnhan,goitinh;
    public uint tuoi, ngaysinh, thehe;
    public giapha [] sub;

};

namespace danhsachcongviec
{
    class Program
    {
        static void Menu()   //1.Tao danh sach cac cong viec
        {
            Console.WriteLine(" __________________________MENU___________________________");
            Console.WriteLine("|XEM GIA PHA DUOI DANG CAY                   : AN PHIM 1  |");
            Console.WriteLine("|XEM GIA PHA DUOI DANG DANH SACH             : AN PHIM 2  |");
            Console.WriteLine("|KIEM TRA NGUOI CO THUOC GIA PHA HAY KHONG   : AN PHIM 3  |");
            Console.WriteLine("|TIM KIEM MOT NGUOI TRONG GIA PHA            : AN PHIM 4  |");
            Console.WriteLine("|THEM NGUOI VAO GIA PHA                      : AN PHIM 5  |");
            Console.WriteLine("|_________________________________________________________|");
        }
        static public int ChonMenu()      //2.Hỏi người dùng làm công việc gì
        {
            int n = 0;
            Console.Write("\n         Moi chon cong viec muon lam: ");
            n = int.Parse(Console.ReadLine());
            if ((n > 0) && (n < 6))
                return n;
            else return ChonMenu();
        }
        static void Main(string[] args)
        {
            Menu();
            ChonMenu();
            Console.ReadKey();
        }
    }
    
}
