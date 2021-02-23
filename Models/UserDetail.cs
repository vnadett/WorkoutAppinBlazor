﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorTest.Models
{
    public class UserDetail
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        [DisplayName("Keresztnév")]
        public string FirstName { get; set; }
        [MaxLength(50)]
        [DisplayName("Vezetéknév")]
        public string LastName { get; set; }
        [DisplayName("Magasság")]
        public int Height { get; set; }
        [DisplayName("Súly")]
        public int Weight { get; set; }
        [DisplayName("Kor")]
        public int Age { get; set; }
        public virtual User User { get; set; }
    }
}
