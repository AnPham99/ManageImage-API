using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DTO
{
    public class UserForRegistrationDto
    {

        [Required]
        [MaxLength(20, ErrorMessage = "Tên ảnh tối đa 20 ký tự.")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Tên ảnh tối đa 20 ký tự.")]
        public string LastName { get; set; }

        [MaxLength(20, ErrorMessage = "Tên ảnh tối đa 20 ký tự.")]
        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }

        [MaxLength(20, ErrorMessage = "Tên ảnh tối đa 20 ký tự.")]
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required]
        public string ConfirmPassword { get; set; }

        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<string> Roles { get; set; }

    }
}
