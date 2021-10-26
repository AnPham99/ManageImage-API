using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Models
{
    public class User : IdentityUser
    {
        [Required]
        [MaxLength(20, ErrorMessage = "Tên ảnh tối đa 20 ký tự.")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Tên ảnh tối đa 20 ký tự.")]
        public string LastName { get; set; }

        public List<Image> Images { set; get; }
        public List<Like> Likes { set; get; }
        public List<Comment> Comments { set; get; }
    }

}
