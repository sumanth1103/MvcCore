using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCore
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage="Please enter your name")]
        [RegularExpression("[A-Z]{1}[A-Za-z]{2,15}", ErrorMessage = "Name should be match")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your Email"),DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your Password")]
        [DataType(DataType.Password)]
        [RegularExpression("[A-Z0-9a-z!@$%&*]{8,15}", ErrorMessage = "Password should match")]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password and conform Password should be same")]
        public string Conformpassword { get; set; }
    }
}
