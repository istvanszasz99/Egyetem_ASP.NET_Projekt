using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Models
{
    /// <summary>
    /// 
    /// </summary>
    /// 
    [Bind(Exclude = "OrderId")]
    public class Order
    {
        [ScaffoldColumn(false)]
        public int OrderId { get; set; }
        [ScaffoldColumn(false)]
        public string Username { get; set; }
        [ScaffoldColumn(false)]
        public System.DateTime OrderDate { get; set; }
        [Required(ErrorMessage = "Valós vezetéknév megadása szükséges")]
        [DisplayName("Vezetéknév:")]
        [StringLength(160)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Valós keresztnév megadása szükséges")]
        [DisplayName("Keresztnév:")]
        [StringLength(160)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Valós szállítási cím megadása szükséges")]
        [DisplayName("Cím:")]
        [StringLength(70)]
        public string Address { get; set; }
        [Required(ErrorMessage = "Valós település megadása szükséges")]
        [DisplayName("Város:")]
        [StringLength(40)]
        public string City { get; set; }
        [Required(ErrorMessage = "Valós megye megadása szükséges")]
        [DisplayName("Megye:")]
        [StringLength(40)]
        public string State { get; set; }
        [Required(ErrorMessage = "Valós irányítószám megadása szükséges")]
        [DisplayName("Irányítószám")]
        [StringLength(10)]
        public string PostalCode { get; set; }
        [Required(ErrorMessage = "Valós ország megadása szükséges")]
        [DisplayName("Ország:")]
        [StringLength(40)]
        public string Country { get; set; }
        [Required(ErrorMessage = "Valós telefonszám megadása szükséges")]
        [DisplayName("Telefonszám:")]
        [StringLength(24)]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Valós email cím megadása szükséges")]
        [DisplayName("Email cím:")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
        ErrorMessage = "A megadott email cím nem valós.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [ScaffoldColumn(false)]
        public decimal Total { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}