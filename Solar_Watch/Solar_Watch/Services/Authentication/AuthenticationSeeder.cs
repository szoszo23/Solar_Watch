﻿using Microsoft.AspNetCore.Identity;

namespace Solar_Watch.Services.Authentication;

public class AuthenticationSeeder
{
    private RoleManager<IdentityRole> roleManager;
    private UserManager<IdentityUser> userManager;

    public AuthenticationSeeder(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
    {
        this.roleManager = roleManager;
        this.userManager = userManager;
    }
    
    public void AddRoles()
    {
        var tAdmin = CreateAdminRole(roleManager);
        tAdmin.Wait();

        var tUser = CreateUserRole(roleManager);
        tUser.Wait();
    }
    private async Task CreateAdminRole(RoleManager<IdentityRole> roleManager)
    {
        await roleManager.CreateAsync(new IdentityRole("Admin")); //The role string should better be stored as a constant or a value in appsettings
    }
    
    async Task CreateUserRole(RoleManager<IdentityRole> roleManager)
    {
        await roleManager.CreateAsync(new IdentityRole("User")); //The role string should better be stored as a constant or a value in appsettings
    }
}