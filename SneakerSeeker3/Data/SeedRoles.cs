using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using SneakerSeeker3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerSeeker3.Data
{
	public static class SeedRoles
	{
		public static async Task CreateRoles(ApplicationDbContext context, UserManager<SneakerSeekerUser> userManager, RoleManager<StoreRole> roleManager)
		{
			context.Database.EnsureCreated();

			String adminId1 = "";
			String adminId2 = "";

			string role1 = "Admin";
			string desc1 = "This is the administration role";

			string role2 = "Member";
			string desc2 = "This is the members role";

			string password = "Admin@2019";

			if (await roleManager.FindByNameAsync(role1) == null)
			{
				await roleManager.CreateAsync(new StoreRole(role1, desc1, DateTime.Now));
			}

			if (await roleManager.FindByNameAsync(role2) == null)
			{
				await roleManager.CreateAsync(new StoreRole(role2, desc2, DateTime.Now));
			}

			if (await userManager.FindByNameAsync("admin@test.com") == null)
			{
				var user = new SneakerSeekerUser
				{
					UserName = "admin@test.com",
					Email = "admin@test.com",
					FirstName = "John",
					LastName = "Doe",
					PhoneNumber = "4162551234"
				};

				var result = await userManager.CreateAsync(user);
				if (result.Succeeded)
				{
					await userManager.AddPasswordAsync(user, password);
					await userManager.AddToRoleAsync(user, role1);
				}

				adminId1 = user.Id;
			}

			if (await userManager.FindByNameAsync("admin1@test.com") == null)
			{
				var user = new SneakerSeekerUser
				{
					UserName = "admin1@test.com",
					Email = "admin1@test.com",
					FirstName = "Jen",
					LastName = "Jackson",
					PhoneNumber = "4167114567"
				};

				var result = await userManager.CreateAsync(user);
				if (result.Succeeded)
				{
					await userManager.AddPasswordAsync(user, password);
					await userManager.AddToRoleAsync(user, role1);
				}

				adminId2 = user.Id;
			}

			if (await userManager.FindByNameAsync("user@test.com") == null)
			{
				var user = new SneakerSeekerUser
				{
					UserName = "user@test.com",
					Email = "user@test.com",
					FirstName = "Victoria",
					LastName = "Hamilton",
					PhoneNumber = "4167771234"
				};

				var result = await userManager.CreateAsync(user);
				if (result.Succeeded)
				{
					await userManager.AddPasswordAsync(user, password);
					await userManager.AddToRoleAsync(user, role2);
				}
			}

			if (await userManager.FindByNameAsync("user1@test.com") == null)
			{
				var user = new SneakerSeekerUser
				{
					UserName = "user1@test.com",
					Email = "user1@test.com",
					FirstName = "Mathew",
					LastName = "Chen",
					PhoneNumber = "4163244567"
				};

				var result = await userManager.CreateAsync(user);
				if (result.Succeeded)
				{
					await userManager.AddPasswordAsync(user, password);
					await userManager.AddToRoleAsync(user, role2);
				}
			}
		}
	}
}
