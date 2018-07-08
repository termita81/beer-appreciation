﻿namespace BeerAppreciation.Services.BeerAppreciation.Services.Identity.API.Models.ManageViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
    }
}
