using Authentication_Authorization_Manual.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication_Authorization_Manual.Infrastructure
{
    public class CustomUserValidator : UserValidator<AppUser>
    {
        public override async Task<IdentityResult> ValidateAsync(UserManager<AppUser> manager, AppUser user)
        {
            IdentityResult result = await base.ValidateAsync(manager, user);
            List<IdentityError> errors = result.Succeeded ?
                new List<IdentityError>() : result.Errors.ToList();
            if (!user.Email.ToLower().EndsWith("@gmail.com"))
            {
                errors.Add(new IdentityError
                {
                    Code = "EmailDomainError",
                    Description = "Only gmail.com email addresses are allowed"
                });
            }
            return errors.Count == 0 ? IdentityResult.Success :
                IdentityResult.Failed(errors.ToArray());
        }
    }

    //public class CustomUserValidator : IUserValidator<AppUser>
    //{
    //    public Task<IdentityResult> ValidateAsync(UserManager<AppUser> manager, AppUser user)
    //    {
    //        if (user.Email.ToLower().EndsWith("@mail.com"))
    //        {
    //            return Task.FromResult(IdentityResult.Success);
    //        }
    //        else
    //        {
    //            return Task.FromResult(IdentityResult.Failed(new IdentityError
    //            {
    //                Code = "EmailDomainError",
    //                Description = "Only mail.com email addresses are allowed"
    //            }));
    //        }
    //    }
    //}



}
