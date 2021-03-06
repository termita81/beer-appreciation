﻿namespace BeerAppreciation.Services.Identity.API.Services
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;
    using Models;

    public class EFLoginService : ILoginService<ApplicationUser>
    {
        readonly UserManager<ApplicationUser> userManager;
        readonly SignInManager<ApplicationUser> signInManager;

        public EFLoginService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager) {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public async Task<ApplicationUser> FindByUsername(string user)
        {
            return await this.userManager.FindByEmailAsync(user);
        }

        public async Task<bool> ValidateCredentials(ApplicationUser user, string password)
        {
            return await this.userManager.CheckPasswordAsync(user, password);
        }

        public Task SignIn(ApplicationUser user) {
            return this.signInManager.SignInAsync(user, true);
        }
    }
}
