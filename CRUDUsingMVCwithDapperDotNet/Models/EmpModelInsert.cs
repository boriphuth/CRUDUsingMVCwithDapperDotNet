using System.ComponentModel.DataAnnotations;

namespace CRUDUsingMVC.Models
{
    public class EmpModelInsert
    {
        [Required(ErrorMessage = "First name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "City is required.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }

    }
}