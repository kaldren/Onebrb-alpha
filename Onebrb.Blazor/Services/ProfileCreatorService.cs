using Microsoft.AspNetCore.Mvc;
using Onebrb.Blazor.Data;
using Onebrb.Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace Onebrb.Blazor.Services
{
    public class ProfileCreatorService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IHttpContextAccessor _httpContext;

        public ProfileCreatorService(ApplicationDbContext dbContext, IHttpContextAccessor httpContext)
        {
            _dbContext = dbContext;
            _httpContext = httpContext;
        }

        public async Task<bool> CreateProfile(OnebrbProfile entity)
        {
            var userId = _httpContext.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (userId == null)
            {
                return false;
            }

            entity.UserId = userId;

            _dbContext.OnebrbProfiles.Add(entity);
            int result = await _dbContext.SaveChangesAsync();

            return result > 0;
        }
    }
}
