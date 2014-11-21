﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Brio.Models
{
    public class CreatePortalAccount
    {
        [Required]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Подтвердите пароль")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Фамилия")]
        public string Surname { get; set; }

        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }

        [Required]
        [Display(Name = "Телефон")]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "Компания")]
        public int CompanyId { get; set; }

        [Required]
        public int RoleId { get; set; }

        [Required]
        [Display(Name = "Запомнить меня")]
        public bool RememberMe { get; set; }
    }
}
