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
    public class ProfileService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IHttpContextAccessor _httpContext;

        public ProfileService(ApplicationDbContext dbContext, IHttpContextAccessor httpContext)
        {
            _dbContext = dbContext;
            _httpContext = httpContext;
        }

        public bool CreateProfile(OnebrbProfile entity)
        {
            var userId = _httpContext.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (userId == null)
            {
                return false;
            }

            entity.UserId = userId;

            _dbContext.OnebrbProfiles.Add(entity);
            int result = _dbContext.SaveChanges();

            return result > 0;
        }

        public OnebrbProfile GetProfile(string id)
        {
            return _dbContext.OnebrbProfiles.FirstOrDefault(x => x.UserId == id);
        }

        public string GetLoggedInUserIdOrDefault()
        {
            return _httpContext.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        }
    }
}
