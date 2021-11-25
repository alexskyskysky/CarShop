using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop.Data.Models {

    public class Order {

        [BindNever]
        public int id { get; set; }

        [Display(Name = "Имя")]
        [StringLength(20)]
        [Required(ErrorMessage = "Длина имени не менее 2 символов!")]
        public string first_name { get; set; }

        [Display(Name = "Фамилия")]
        [StringLength(20)]
        [Required(ErrorMessage = "Длина фамилии не менее 1 символа!")]
        public string last_name { get; set; }

        [Display(Name = "Адрес")]
        [StringLength(50)]
        [Required(ErrorMessage = "Длина адреса не менее 10 символов!")]
        public string address { get; set; }

        [Display(Name = "Телефона")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(15)]
        [Required(ErrorMessage = "Длина номера телефона не менее 10 символов!")]
        public string phone { get; set; }

        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        [StringLength(35)]
        [Required(ErrorMessage = "Длина электронной почты не менее 6 символов!")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }
    }
}