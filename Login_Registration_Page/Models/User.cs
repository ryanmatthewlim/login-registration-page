using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Login_Registration_Page.Models
{
    public class User
    {
        [Key]
        public int ItemId { get; set; }

        [Required(ErrorMessage = "Required.")]
        public string Name { get; set; }

        public string Code { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Required.")]
        public decimal Price { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Date Modified")]
        public DateTime? DateModified { get; set; }

        [Display(Name = "Item Type")]
        public UserType Type { get; set; }
    }
    public enum UserType
    {
        Customer = 1,
        Supplier = 2
    }
}
