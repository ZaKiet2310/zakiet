using System.ComponentModel.DataAnnotations;

namespace BaiKiemTra02.Models
{
    public class LopHoc
    {
        [Key]

        public int Id {  get; set; }
        [Required(ErrorMessage ="Không được để trống tên lớp học ")]
        [Display(Name = "Tên lớp học")]

        public string TenLopHoc { get; set; }
        [Required(ErrorMessage = "Không được để trống năm nhập học ")]
        [Display(Name = "Năm nhập học")]

        public int NamNhapHoc { get; set; }
        [Required(ErrorMessage = "Không được để trống năm ra trường ")]
        [Display(Name = "Năm ra trường")]
        public int NamRaTruong { get; set; }
        [Required(ErrorMessage = "Không được để trống số lượng sinh viên")]
        [Display(Name = "Số lượng sinh viên")]
        public int SoLuongSinhVien { get; set; }
    }
}
