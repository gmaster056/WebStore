using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace WebStore.ViewModels
{
    public class EmployeeViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Укажите Имя")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Имя должно быть от 3 до 20 символов")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Укажите Фамилию")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Укажите Отчество")]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Укажите Возраст")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Укажите Город")]
        public string City { get; set; }

        [Required(ErrorMessage = "Укажите Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Укажите должность")]
        public string Job { get; set; }
    }
}
