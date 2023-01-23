using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using ShopShowcase.Common;
using ShopShowcase.Data.Entities;

namespace ShopShowcase.Services.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly UserManager<UserDataEntity> _userManager;

        public UserService(UserManager<UserDataEntity> userManager)
        {
            _userManager = userManager;
        }

        public async Task<BaseResponse> AddAsync(BaseRequest request)
        {
            var user = request.Payload.MapTo<UserDataEntity>();
            var result = await _userManager.CreateAsync(user);
            await _userManager.AddToRoleAsync(user, "Customer");
            return new BaseResponse
            {
                Payload = result
            };
        }

        public async Task<BaseResponse> RemoveAsync(BaseRequest request)
        {
            var user = request.Payload.MapTo<UserDataEntity>();
            var roles = await _userManager.GetRolesAsync(user);
            var result = await _userManager.RemoveFromRolesAsync(user, roles);
            return new BaseResponse
            {
                Payload = result
            };
        }

        public async Task<BaseResponse> UpdateAsync(BaseRequest request)
        {
            var user = request.Payload.MapTo<UserDataEntity>();
            var result = await _userManager.UpdateAsync(user);
            return new BaseResponse
            {
                Payload = result
            };
        }

        public async Task<BaseResponse> GetAsync(BaseRequest request)
        {
            var result = await _userManager.GetUserAsync(ClaimsPrincipal.Current);
            return new BaseResponse
            {
                Payload = result
            };
        }
    }
}