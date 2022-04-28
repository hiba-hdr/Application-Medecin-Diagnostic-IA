﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using TP_InterfaceWeb.Models;

namespace TP_InterfaceWeb.Security
{
    public class SecurityManager
    {
        public async void SignIn(HttpContext httpContext, NewAccount account)
        {
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(getUserClaims(account), CookieAuthenticationDefaults.AuthenticationScheme);
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            await httpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);
        }

        public async void SignOut(HttpContext httpContext)
        {
            await httpContext.SignOutAsync();
        }

        private IEnumerable<Claim> getUserClaims(NewAccount account)
        {
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, account.UserName));
            account.AccountRoles.ToList().ForEach(ac =>
            {
                claims.Add(new Claim(ClaimTypes.Role, ac.Role.Name));
            });
            return claims;
        }
    }
}
