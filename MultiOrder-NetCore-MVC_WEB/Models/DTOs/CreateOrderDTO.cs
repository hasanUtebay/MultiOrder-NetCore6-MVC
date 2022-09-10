using EntityLayer.Entities.Concrete;
using MultiOrder_NetCore_MVC_WEB.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace MultiOrder_NetCore_MVC_WEB.Models.DTOs
{
    public class CreateOrderDTO
    {
        [Required(ErrorMessage = "Şirket Adını Giriniz.")]
        [MinLength(5, ErrorMessage = "En Az 5 Karakter Giriniz"), MaxLength(100, ErrorMessage = "En Fazla 100 Karakter Giriniz")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Sipariş Tarihini Giriniz")]        
        [DataType(DataType.DateTime)]
        public DateTime OrderDate { get; set; }

        public List<PreOrder>? Orders { get; set; }



    }
}
